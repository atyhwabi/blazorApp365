using ECSM.Models.DTO.ServiceCatalogueItem;
using ECSM.Models.DTO;
using ECSM.Services.ServiceCatalogueItem;
using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Components
{
  public partial class PinnedServicesComponent
  {
    [Inject]
    private IServiceCatalogueItemService serviceCatalogueItemService { get; set; }

    private ServiceCatalogueItemDTO[] PinnedServiceItems = [];

    private AuthModel? authModel { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstReder)
    {
      if (firstReder)
      {
        GetAndSetUserInfo();
        if (authModel != null)
        {
          await GetAndSetPinnedServices();
        }
      }
    }

    private async void GetAndSetUserInfo()
    {
      authModel = await authManager.GetAuthState();
    }

    private async Task GetAndSetPinnedServices()
    {
      PinnedServiceItems = await serviceCatalogueItemService.GetPinnedServices(authModel!.Roles);
      StateHasChanged();
    }
  }
}
