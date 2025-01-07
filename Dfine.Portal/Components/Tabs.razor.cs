using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO;
using ECSM.Portal.Managers;
using ECSM.Services.Cases;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ECSM.Models.DTO.ServiceCatalogueItem;
using System.Collections.Generic;
using ECSM.Services.ServiceCatalogue;

namespace ECSM.Portal.Components
{
  public partial class Tabs
  {
    [Parameter]
    public string SearchText { get; set; } = string.Empty;

    [Inject]
    private IServiceCatalogueService serviceCatalogueService { get; set; }

    private List<ServiceCatalogueItemDTO> serviceCatalogueItems { get; set; } = [];

    private AuthModel? authModel { get; set; }

    int activeTab = 1;

    async void SetActiveTab(int tab)
    {
      await JSRuntime.InvokeVoidAsync("storeScrollPosition");
      activeTab = tab;
      StateHasChanged();
      await JSRuntime.InvokeVoidAsync("restoreScrollPosition");
    }

    protected override void OnInitialized()
    {
      JSRuntime.InvokeVoidAsync("storeScrollPosition");
    }

    public async void Dispose()
    {
      await JSRuntime.InvokeVoidAsync("restoreScrollPosition");
    }

    private void navigateToServiceCatalogue(Guid? serviceCatalogueid)
    {
      navigationManager.NavigateTo($"/CaseDetails/{serviceCatalogueid}");
    }

    protected override void OnAfterRender(bool firstRender)
    {
      if (firstRender)
      {
        GetAndSetUserInfo();
        if (authModel != null)
        {
          GetAndSetServiceCatalogueItems(SearchText);
        }
      }
    }

    private async void GetAndSetUserInfo()
    {
      authModel = await authManager.GetAuthState();
    }

    private async void GetAndSetServiceCatalogueItems(string searhText)
    {
      serviceCatalogueItems = await serviceCatalogueService.GetServiceCataloguesWithCategoriesCatalogueItems(authModel!.Roles, searhText);
      StateHasChanged();
    }
  }
}
