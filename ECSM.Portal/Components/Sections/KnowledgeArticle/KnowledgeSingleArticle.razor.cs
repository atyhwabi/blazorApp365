using ECSM.Models.DTO;
using ECSM.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Telerik.Blazor.Components;
using Telerik.Blazor;
using ECSM.Models.Dynamics;
namespace ECSM.Portal.Components.Sections.KnowledgeArticle
{
  public partial class KnowledgeSingleArticle
  {
    [Parameter]
    public string ID { get; set; }

    [Inject]
    private IJSRuntime JS { get; set; }

    KnowledgeItemDTO KnowledgeArticle { get; set; }

    public TelerikNotification Notification { get; set; }

    public MarkupString GetInstructionsMarkup() => (MarkupString)KnowledgeArticle?.Content;

    protected override async Task OnInitializedAsync()
    {
      await base.OnInitializedAsync();
    }
    protected override async Task OnAfterRenderAsync(bool firstReder)
    {
      if (firstReder)
      {
        KnowledgeArticle = await knowledgeService.GetKnowledgeItemArticle(ID);
        await InvokeAsync(StateHasChanged);
      }
    }

    private async void DownloadFile(string attachmentID, string fileName)
    {
      var notification = new NotificationModel()
      {
        Text = "Fetching File Information. Your download will start automatically once ready.",
        ThemeColor = ThemeConstants.Notification.ThemeColor.Info,
        CloseAfter = 0
      };
      var fileData = await this.knowledgeService.GetAttachmentFileBase64(attachmentID);
      await JS.InvokeVoidAsync("downloadFile", fileName, "application/octet-stream", fileData);
    }

    private void logTicket(string ServiceCatalogueID)
    {
      navigationManager.NavigateTo($"/logticket/{@ServiceCatalogueID}", ispublic: navigationManager.UriContains("public"));
    }
  }
}

