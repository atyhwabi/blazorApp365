using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ECSM.Portal.Components.Sections
{
    public partial class KnowledgeSearchSection
    {
        string? searchValue;

        void HandleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                navigationManager.NavigateTo($"/knowledgesearch/{searchValue}", ispublic: navigationManager.UriContains("public"));
            }
        }
    }
}