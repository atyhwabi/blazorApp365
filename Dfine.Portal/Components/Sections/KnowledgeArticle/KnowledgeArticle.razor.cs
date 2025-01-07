using ECSM.Models.DTO;
using ECSM.Services;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components.Common.Dates;

namespace ECSM.Portal.Components.Sections.KnowledgeArticle
{
  public partial class KnowledgeArticle
  {
    KnowledgeItemDTO[] GetKnowledgePopular = [];
    KnowledgeItemDTO[] KnowledgeArticlesLatest = [];
    KnowledgeItemDTO[] FaqArticlesLatest = [];
    KnowledgeItemDTO[] KnowledgeArticlesRating = [];

    [Inject]
    private IKnowledgeService knowledgeService { get; set; }
    [Inject]
    private SearchResults SearchResults { get; set; }

    public int FaqCounter;
    public int KnowledgeCounter;

    protected override async Task OnInitializedAsync()
    {
      await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstReder)
    {
      if (firstReder)
      {
        var GetKnowledgePopularTask =  knowledgeService.GetKnowledgeItemsTop3Popular();
        var KnowledgeArticlesLatestTask =  knowledgeService.GetKnowledgeItemsTop5Latest();
        var FaqArticlesLatestTask =  knowledgeService.GetFaqItemsTop5Latest();
        var KnowledgeArticlesRatingTask =  knowledgeService.GetKnowledgeItemsTop3Rating();

        await Task.WhenAll(new Task[] { GetKnowledgePopularTask, KnowledgeArticlesLatestTask, FaqArticlesLatestTask, KnowledgeArticlesRatingTask});

        GetKnowledgePopular = GetKnowledgePopularTask.Result;

        KnowledgeArticlesLatest = KnowledgeArticlesLatestTask.Result;

        FaqArticlesLatest = FaqArticlesLatestTask.Result;

        KnowledgeArticlesRating = KnowledgeArticlesRatingTask.Result;

        await InvokeAsync(StateHasChanged);

      }
    }

    private void SetSearch(string publicNumber)
    {
      SearchResults.SearchText = "";
      navigationManager.NavigateTo($"/knowledgebasearticlespage/{publicNumber}", ispublic: navigationManager.UriContains("public"));
    }
  }
}
