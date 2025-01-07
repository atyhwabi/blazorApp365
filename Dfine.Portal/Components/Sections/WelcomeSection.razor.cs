using ECSM.Models.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ECSM.Portal.Components.Sections
{
    public partial class WelcomeSection
    {
        string? searchValue;
		AuthModel authModel { get; set; }
        protected override async Task OnInitializedAsync()
        {
            authModel = await authManager.GetAuthState();
        }
        
        void HandleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                if (string.IsNullOrEmpty(searchValue))
                {
                    navigationManager.NavigateTo($"/search", ispublic: navigationManager.UriContains("public"));
                }
                else
                {
                    navigationManager.NavigateTo($"/search/{searchValue}", ispublic: navigationManager.UriContains("public"));
                }
            }
        }
    }
}
