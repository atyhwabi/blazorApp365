using ECSM.Models.DTO;
using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Components
{
    public partial class FAQComponent
    {
        [Parameter]
        public string searchText { get; set; }
        [Parameter]
        public string HeadingText { get; set; }
        public PanelBarItem[] FAQ { get; set; } = [];
        [Parameter]
        public KnowledgeItemDTO[] KnowledgeWithFAQ { get; set; } = [];
        public KnowledgeItemDTO[] KnowledgeWithFAQResult { get; set; } = [];
        public IEnumerable<object> expandedQuestions { get; set; }
        public int selected_fqa_ID = 0;

        protected override void OnInitialized()
        {
            getSetFAQ();
            base.OnInitialized();
        }

        private async void getSetFAQ()
        {
            if(!KnowledgeWithFAQ.Any() || searchText != null)
                KnowledgeWithFAQ = await KnowledgeArticleQueries.GeFAQItems(searchText);

            for(int index = 0; index < KnowledgeWithFAQ.Length; index++)
            {
                KnowledgeWithFAQ[index].Content = KnowledgeWithFAQ[index].Content.Replace("12px","16px");
            }
          
            StateHasChanged();
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
    }
}
