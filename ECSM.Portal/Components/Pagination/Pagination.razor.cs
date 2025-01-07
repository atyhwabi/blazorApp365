using ECSM.Models.DTO;
using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Components.Pagination
{
    public partial class Pagination
    {
        [Parameter]
        public int PageIndex { get; set; }
        [Parameter]
        public int TotalPages { get; set; }
        [Parameter]
        public int Radius { get; set; }
        [Parameter]
        public EventCallback<int> OnSelectedPage { get; set; }
        private List<PageItem> pageItems;
        private void LastPageClick()
        {
            PageItem pageItem = new PageItem(TotalPages, true, TotalPages.ToString());
            SelectCurrentPage(pageItem);
        }
        private void FirstPageClick()
        {
            PageItem pageItem = new PageItem(1, true, TotalPages.ToString());
            SelectCurrentPage(pageItem);
        }
        private void NextPageClick()
        {
            if (PageIndex < TotalPages)
            {
                PageIndex++;
            }
            PageItem pageItem = new PageItem(PageIndex, true, TotalPages.ToString());
            SelectCurrentPage(pageItem);
        }
        private void PrevPageClick()
        {
            if (PageIndex > 1)
            {
                PageIndex--;
            }
            PageItem pageItem = new PageItem(PageIndex, true, TotalPages.ToString());
            SelectCurrentPage(pageItem);
        }
        protected override void OnParametersSet()
        {
            CreatePages();
        }
        private void CreatePages()
        {
            pageItems = pageItems = new List<PageItem>();

            var hasPreviousPage = PageIndex > 1;
            var previousPageIndex = PageIndex - 1;
            pageItems.Add(new PageItem(previousPageIndex, hasPreviousPage, ""));

            if (Radius >= TotalPages)
            {
                Radius = TotalPages - 1;
                if (Radius == 0)
                    Radius = 1;
            }
            for (int page = 1; page <= TotalPages; page++)
            {
                if (page >= PageIndex - Radius && page <= PageIndex + Radius)
                {
                    pageItems.Add(new PageItem(page, true, page.ToString())
                    {
                        Active = PageIndex == page
                    });
                }
            }
            var hasNextPage = PageIndex <= TotalPages;
            var nextPageIndex = PageIndex + 1;
            pageItems.Add(new PageItem(nextPageIndex, hasNextPage, ""));
        }
        private async Task SelectCurrentPage(PageItem pageItem)
        {
            if (PageIndex == pageItem.PageIndex)
            {
                return;
            }

            if (!pageItem.Enabled)
            {
                return;
            }
            PageIndex = pageItem.PageIndex;
            await OnSelectedPage.InvokeAsync(pageItem.PageIndex);
        }
    }
}
