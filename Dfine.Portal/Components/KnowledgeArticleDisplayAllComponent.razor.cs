using ECSM.Models.DTO;
using Microsoft.AspNetCore.Components;
using ECSM.Models.DTO;
using ECSM.Services;
using LanguageExt;
using ECSM.Portal.Components.Sections.KnowledgeArticle;

namespace ECSM.Portal.Components
{
    public partial class KnowledgeArticleDisplayAllComponent
    {
        [Parameter]
        public string searchText { get; set; } = string.Empty;
        public KnowledgeItemDTO[] articles { get; set; } = [];
        private IEnumerable<KnowledgeItemDTO> AllknowledgeItems = null;
        private IEnumerable<KnowledgeItemDTO> knowledgeItems = Enumerable.Empty<KnowledgeItemDTO>();
        private int pageIndex = 1;
        public int totalPages { get; set; } = 1;
        public int ItemsPerPage { get; set; } = 5;
        public bool IsAscending { get; set; } = true;
        public int selected_article_ID = 0;
        public int number_of_articles = 0;
        public int selected_fqa_ID = 0;
        public int numberOfpages = 0;

        protected void SelectedPage(int selectedPageIndex)
        {
            if (AllknowledgeItems != null)
            {
                pageIndex = selectedPageIndex;
                var skipCount = (pageIndex - 1) * ItemsPerPage;
                knowledgeItems = AllknowledgeItems.Skip(skipCount).Take(ItemsPerPage);
            }
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

        protected override async Task OnInitializedAsync()
        {
            if (articles.Length() == 0)
            {
                articles = await ArticleQueries.GetKnowledgeItems(searchText, true);
                AllknowledgeItems = articles;
                if (AllknowledgeItems != null)
                {
                    totalPages = (int)Math.Ceiling(AllknowledgeItems.Count() / (double)ItemsPerPage);
                    knowledgeItems = AllknowledgeItems.Skip(0).Take(ItemsPerPage);
                    number_of_articles = AllknowledgeItems.Count();
                    IsAscending = false;

                }
            }
            base.OnInitialized();
        }

        private async void HandleAscendingClick()
        {
            articles = await ArticleQueries.GetKnowledgeItems(searchText, true);
            AllknowledgeItems = articles;
            if (AllknowledgeItems != null)
            {
                totalPages = (int)Math.Ceiling(AllknowledgeItems.Count() / (double)ItemsPerPage);
                knowledgeItems = AllknowledgeItems.Skip(0).Take(ItemsPerPage);
                number_of_articles = AllknowledgeItems.Count();
            }
            IsAscending = false;
            StateHasChanged();
        }

        private async void HandleDescendingClick()
        {
            articles = await ArticleQueries.GetKnowledgeItems(searchText, false);
            AllknowledgeItems = articles;
            if (AllknowledgeItems != null)
            {
                totalPages = (int)Math.Ceiling(AllknowledgeItems.Count() / (double)ItemsPerPage);
                knowledgeItems = AllknowledgeItems.Skip(0).Take(ItemsPerPage);
                number_of_articles = AllknowledgeItems.Count();
            }
            IsAscending = true;
            StateHasChanged();
        }

        private void navigateToknowledgeBaseArticle(string publicnumber)
        {
            navigationManager.NavigateTo($"/knowledgebasearticlespage/{publicnumber}", ispublic: navigationManager.UriContains("public"));
        }

        private void SetSearch(string publicNumber)
        {
            SearchResults.SearchText = searchText;
            navigationManager.NavigateTo($"/knowledgebasearticlespage/{publicNumber}", ispublic: navigationManager.UriContains("public"));
        }
    }
}
