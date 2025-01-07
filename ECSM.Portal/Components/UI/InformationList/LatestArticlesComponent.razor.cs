using ECSM.Models.DTO;
using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Components.UI.InformationList
{
    public partial class LatestArticlesComponent
    {
        [Parameter]
        public KnowledgeItemDTO[] knowledgeArticle { get; set; } = [];

        protected override async Task OnAfterRenderAsync(bool firstReder)
        {
            if (firstReder)
            {
                knowledgeArticle = await knowledgeService.GetKnowledgeItems();
                await InvokeAsync(StateHasChanged);
            }
        }

        private void SetSearch(string publicNumber)
        {
            SearchResults.SearchText = "";
            navigationManager.NavigateTo($"/knowledgebasearticlespage/{publicNumber}", ispublic: navigationManager.UriContains("public"));
        }

        private void navKnowledgebasePage()
        {
            navigationManager.NavigateTo("/knowledgebase", ispublic: navigationManager.UriContains("public"));
        }
    }
}
