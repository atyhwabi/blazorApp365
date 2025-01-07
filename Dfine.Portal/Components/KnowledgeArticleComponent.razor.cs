using ECSM.Models.DTO;
using ECSM.Portal.Components.Sections.KnowledgeArticle;
using Microsoft.AspNetCore.Components;


namespace ECSM.Portal.Components
{
    public partial class KnowledgeArticleComponent
    {
        [Parameter]
        public string searchText { get; set; } = string.Empty;
        [Parameter]
        public string HeadingText { get; set; } = string.Empty;
        public KnowledgeItemDTO[] articles { get; set; } = [];
        public int selected_article_ID = 0;
        public int selected_fqa_ID = 0;
        protected override async Task OnInitializedAsync()
        {
            if (articles.Count() == 0)
            {
                articles = await ArticleQueries.GetKnowledgeItemsTop5Latest(searchText);
            }
            base.OnInitialized();
        }
        private MarkupString GetHighlightedText(string text)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return (MarkupString)$"<span>{text}</span>";
            }

            var highlightedText = text.Replace(searchText, $"<strong style='color: darkblue'>{searchText}</strong>", StringComparison.OrdinalIgnoreCase);
            return (MarkupString)$"<span>{highlightedText}</span>";
        }
        private void SetSearch(string publicNumber)
        {
            SearchResults.SearchText = searchText;
            navigationManager.NavigateTo($"/knowledgebasearticlespage/{publicNumber}", ispublic: navigationManager.UriContains("public"));
        }

    }
}
