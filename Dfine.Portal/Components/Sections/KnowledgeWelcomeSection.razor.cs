using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ECSM.Portal.Components.Sections
{
    public partial class KnowledgeWelcomeSection
    {
        string? searchValue;

        [Parameter]
        public string? PublicParameter { get; set; }

        void HandleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                navigationManager.NavigateTo($"/search/{searchValue}", ispublic: navigationManager.UriContains("public"));
            }
        }
    }
}
