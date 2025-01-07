using EC.DynamicsClient;

using ECSM.Models.DTO.ContentBlocks;
using ECSM.Models.DTO.ServiceCatalogueItem;
using ECSM.Services.Cases;
using ECSM.Services.CatalogueItem;
using ECSM.Services.ServiceCatalogueItem;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using Telerik.Blazor;
using Telerik.Blazor.Components;

using static Telerik.Blazor.ThemeConstants;

namespace ECSM.Portal.Pages
{
    public partial class CaseDetails
    {
        [Inject]
        private ICaseService CaseService { get; set; }

        [Inject]
        private IServiceCatalogueItemService ServiceCatalogueItemService { get; set; }

        [Inject]
        private ICatalogueItemService CatalogueItemService { get; set; }

        [Parameter]
        public string PublicParameter { get; set; }

        [Parameter]
        public string ServiceCatalogueItemId { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        private Guid _serviceCatalogueItemId { get; set; }

        private ServiceCatalogueItemDTO ServiceCatalogueItemDTO { get; set; } = new ServiceCatalogueItemDTO();

        private bool IsLoading { get; set; } = true;

        public TelerikNotification Notification { get; set; }

        protected override void OnParametersSet()
        {

            if (ServiceCatalogueItemId != null && ServiceCatalogueItemId != string.Empty)
            {
                _serviceCatalogueItemId = Guid.Parse(ServiceCatalogueItemId);
                GetServiceCatalogueItem();
            }

            base.OnParametersSet();
        }

        private async void GetServiceCatalogueItem()
        {
            ServiceCatalogueItemDTO = await ServiceCatalogueItemService.GetServiceCatalogueItemById(_serviceCatalogueItemId);
            if(!ServiceCatalogueItemDTO.KnowledgeArticles.Any() && 
               !ServiceCatalogueItemDTO.CatalogueItemDTO.ContentBlocks.Any() && 
               !ServiceCatalogueItemDTO.CatalogueItemDTO.Announcements.Any())
                NavigateToLogTickte();
            IsLoading = false;
            StateHasChanged();
        }

        private void NavigateToArticle(string articleId)
        {
            navigationManager.NavigateTo($"knowledgebasearticlespage/{articleId}", ispublic: navigationManager.UriContains("public"));
        }

        private async void DownloadFile(ContentBlockDTO contentBlock)
        {
            var notification = new NotificationModel()
            {
                Text = "Fetching File Information. Your download will start automatically once ready.",
                ThemeColor = ThemeConstants.Notification.ThemeColor.Info,
                CloseAfter = 0
            };

            Notification.Show(notification);

            var fileData = await this.CatalogueItemService.GetContentBlockFileBase64(contentBlock.ContentBlockId);

            await JS.InvokeVoidAsync("downloadFile", contentBlock.FileName, "application/octet-stream", fileData);

            Notification.Hide(notification);
        }

        private void  NavigateToLogTickte()
        {
            navigationManager.NavigateTo($"logTicket/{ServiceCatalogueItemDTO.ServiceCatalogueItemId}", ispublic: navigationManager.UriContains("public"));
        }
    }
}
