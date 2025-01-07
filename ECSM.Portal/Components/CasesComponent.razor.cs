using ECSM.Models.DTO;
using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Components
{
    public partial class CasesComponent
    {
        [Parameter]
        public string searchText { get; set; } = string.Empty;
        [Parameter]
        public string HeadingText { get; set; } = string.Empty;

        public List<CasesItemDTO> Cases { get; set; } = [];

        protected override async Task OnInitializedAsync()
        {
            if (Cases.Count() == 0)
            {
                Cases = await caseService.GetCases(searchText);
            }
        }
        protected void GoToCaseDetails(Guid? caseId)
        {
            navigationManager.NavigateTo($"/case/{caseId}");
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
