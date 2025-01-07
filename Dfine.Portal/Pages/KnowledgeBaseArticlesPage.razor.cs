using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Pages
{
  public partial class KnowledgeBaseArticlesPage
  {
    [Parameter]
    public string ID { get; set; }

    [Parameter]
    public string? Publicparameter { get; set; }

    private void navKnowledgebasePage()
    {
      navigationManager.NavigateTo("/knowledgebase", ispublic: navigationManager.UriContains("public"));
    }

    private void navSearchPage(string Searchvalue)
    {
      navigationManager.NavigateTo($"/search/{Searchvalue}", ispublic: navigationManager.UriContains("public"));
    }
  }
}
