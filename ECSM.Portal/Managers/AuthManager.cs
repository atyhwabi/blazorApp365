#region usings
using ECSM.Models.DTO;
using ECSM.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Caching.Memory;
#endregion

namespace ECSM.Portal.Managers
{
    public class AuthManager(
        AuthenticationStateProvider authprovider,
        IMemoryCache memoryCache,
        IUserRolesQueryService userRolesService,
        IContactQueryService contactQueryService)
    {
        AuthenticationStateProvider authprovider = authprovider ?? throw new ArgumentNullException(nameof(authprovider));
        IUserRolesQueryService userRolesService = userRolesService ?? throw new ArgumentNullException(nameof(userRolesService));
        IContactQueryService contactQueryService = contactQueryService ?? throw new ArgumentNullException(nameof(contactQueryService));
        IMemoryCache memoryCache = memoryCache ?? throw new ArgumentNullException(nameof(memoryCache));

        AuthModel authModel { get; set; } = new AuthModel();

        private bool setCache = false;

        public async Task<AuthModel> GetAuthState()
        {
            var state = await authprovider.GetAuthenticationStateAsync();
            if(state.User.Identity.IsAuthenticated)
            {
                var azureId = state.User.Claims.FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")!.Value;

                Guid azureIdGuid;
                authModel.IDP = "B2C";

                if (!Guid.TryParse(azureId, out azureIdGuid))
                {
                    authModel.IDP = "AAD";
                    azureId = state.User.Claims.FirstOrDefault(x =>
                    x.Type == "http://schemas.microsoft.com/identity/claims/objectidentifier")!.Value;
                }

                authModel.IsAuthenticated = state.User.Identity.IsAuthenticated;
                authModel.user = state.User;

                if (!memoryCache.TryGetValue(azureId, out dynamic model))
                {
                     this.setCache = true;
                }
                else
                {
                    if (model != null)
                    {
                        if(model?.Roles != null)
                            authModel.Roles = model.Roles;

                        if(model?.Contact != null)
                            authModel.Contact = model.Contact;
                    }
                }

                if (authModel.Contact == null || authModel.Contact.ContactID == null)
                {
                    var contactResult = await contactQueryService.GetContactByADObjectID(azureId);
                    if (contactResult != null)
                    {
                        authModel.Contact = contactResult;
                        authModel.Roles = contactResult.Rolles;
                    }
                }

                if(this.setCache)
                {
                    var cacheOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60));
                    memoryCache.Set(azureId, new { Contact = authModel.Contact, Roles = authModel.Roles }, cacheOptions);
                }
            }
            else
            {
                // Get Anonymous user roles
                if(authModel.Roles == null || !authModel.Roles.Any())
                {
                    var contactResult = await contactQueryService.GetAnonContact();
                    if (contactResult != null)
                    {
                        authModel.Contact = contactResult;
                        authModel.Roles = contactResult.Rolles;
                    }
                }
            }

            return authModel;
        }

        // Remove user from cache when logging out
        public async Task RemoveFromCache()
        {
            var state = await authprovider.GetAuthenticationStateAsync();
            memoryCache.Remove(state.User.Claims.FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")!.Value);
        }

        public async Task<bool> IsAuthenticated()
        {
            var state = await authprovider.GetAuthenticationStateAsync();

            return state.User.Identity.IsAuthenticated;
        }
    }
}
