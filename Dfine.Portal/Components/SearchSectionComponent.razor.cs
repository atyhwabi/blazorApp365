using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Newtonsoft.Json.Linq;
using System.Web;

namespace ECSM.Portal.Components
{
  public partial class SearchSectionComponent
  {
    [Parameter]
    public string? searchValue { get; set; }
    public void GoToHomePage()
    {
      navigationManager.NavigateTo("/", ispublic: navigationManager.UriContains("public"));
    }

    bool IsRoot()
    {
      return navigationManager.UriEndsWith("/");
    }

    bool IsKnowledgeRoot()
    {
      return navigationManager.UriEndsWith("/knowledgebase") || navigationManager.UriContains("/knowledgesearch") || navigationManager.UriContains("/knowledgebasearticlespage");
    }

    bool IsCaseDetailsRoot()
    {
      return navigationManager.UriEndsWith("/CaseDetails");
    }

    protected override void OnInitialized()
    {
      var uri = new Uri(NavigationManager.Uri);
      var urlString = uri.AbsolutePath;
      if (urlString[urlString.Length - 1] == '/')
      {
        searchValue = "";
      }
      else
      {
        if (uri.AbsolutePath.Contains("knowledgebasearticlespage"))
        {
          searchValue = "";
        }
        else
        {
          searchValue = urlString.Substring(urlString.LastIndexOf('/') + 1).Replace("search", "");
          searchValue = HttpUtility.UrlDecode(searchValue);
        }
      }
      if (searchValue.Length() > 30)
      {
        searchValue = string.Empty;
      }

    }

    void HandleKeyPress(KeyboardEventArgs e)
    {
      if (e.Key == "Enter")
      {
        if (IsKnowledgeRoot())
        {
          if (string.IsNullOrEmpty(searchValue))
          {
            navigationManager.NavigateTo("/knowledgebase", forceReload: true, ispublic: navigationManager.UriContains("public"));
          }
          else
          {
            navigationManager.NavigateTo($"/knowledgesearch/{searchValue}", forceReload: true, ispublic: navigationManager.UriContains("public"));
          }
        }
        else if (string.IsNullOrEmpty(searchValue))
        {
          navigationManager.NavigateTo("/search", forceReload: true, ispublic: navigationManager.UriContains("public"));
        }
        else
        {
          navigationManager.NavigateTo($"/search/{searchValue}", forceReload: true, ispublic: navigationManager.UriContains("public"));
        }
      }
    }

  }
}
