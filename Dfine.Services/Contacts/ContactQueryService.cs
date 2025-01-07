#region usings
using EC.DynamicsClient;
using ECSM.Models.DTO;
using ECSM.Models.Dynamics;
using ECSM.Services.SettingsService;
using LanguageExt.Pipes;
using Newtonsoft.Json;
#endregion

namespace ECSM.Services
{
    public sealed class ContactQueryService(IDynamicsQueryClient queryClient, ISettingsService settingsService) : IContactQueryService
    {
        readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();
        readonly ISettingsService settingsService = settingsService.ThrowIfNull();

        /// <summary>
        /// Gets Contact
        /// </summary>
        /// <returns>ContactReturnDTO</returns>
        /// <exception cref="FailedStatusCodeException"></exception>
        public async Task<ContactReturnDTO> GetContactByADObjectID(string objID)
        {
            try
            {
                var entityCollection = await queryClient
                    .Get<Contact>(ContactField.LogicalCollectionName
                    .Query()
                    .Where([
                        ContactField.ecsm_ADObjectID.Equal(objID)
                    ])
                    .Select([
                        ContactField.ContactId,
                        ContactField.FullName,
                        ContactField.FirstName,
                        ContactManyToMany.ecsm_portal_role_Contact_Contact
                     ])
                    .ExpandOn(
                        new Expand(
                            ContactManyToMany.ecsm_portal_role_Contact_Contact, 
                            new ColumnSet
                            ([
                                ecsm_portal_roleField.ecsm_portal_roleId, 
                                ecsm_portal_roleField.ecsm_Name, 
                                ecsm_portal_roleField.ecsm_description
                            ])
                         )
                     )
                    .Build()).ConfigureAwait(false);

                if (entityCollection is null or { Entities: null or { Length: < 1 } })
                {
                    throw new Exception("Contact not found");
                }

                var result =  entityCollection.Entities
                      .Select(e => new ContactReturnDTO
                      {
                          ContactID = e.ContactId,
                          FullName = e.FullName,
                          FirstName = e.FirstName,
                          Rolles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_portal_role_Contact_Contact"]?.ToString())
                      }).FirstOrDefault();

                return result;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets Contact
        /// </summary>
        /// <returns>ContactReturnDTO</returns>
        /// <exception cref="FailedStatusCodeException"></exception>
        public async Task<ContactReturnDTO> GetAnonContact()
        {
            try
            {
                var setting = await settingsService.GetSettingByName("AnonymousUserId").ConfigureAwait(false);

                var entityCollection = await queryClient
                    .Get<Contact>(ContactField.LogicalCollectionName
                    .Query()
                    .Where([
                        ContactField.ContactId.Equal(setting.Value)
                    ])
                    .Select([
                        ContactField.ContactId,
                        ContactField.FullName,
                        ContactField.FirstName,
                        ContactManyToMany.ecsm_portal_role_Contact_Contact
                     ])
                    .ExpandOn(
                        new Expand(
                            ContactManyToMany.ecsm_portal_role_Contact_Contact,
                            new ColumnSet
                            ([
                                ecsm_portal_roleField.ecsm_portal_roleId,
                                ecsm_portal_roleField.ecsm_Name,
                                ecsm_portal_roleField.ecsm_description
                            ])
                         )
                     )
                    .Build()).ConfigureAwait(false);

                if (entityCollection is null or { Entities: null or { Length: < 1 } })
                {
                    throw new Exception("Contact not found");
                }

                var result = entityCollection.Entities
                      .Select(e => new ContactReturnDTO
                      {
                          ContactID = e.ContactId,
                          FullName = e.FullName,
                          FirstName = e.FirstName,
                          Rolles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_portal_role_Contact_Contact"]?.ToString())
                      }).FirstOrDefault();

                return result;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

    }
}
