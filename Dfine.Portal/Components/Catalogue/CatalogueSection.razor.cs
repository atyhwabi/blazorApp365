using ECSM.Models.DTO;
using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Services.Cases;
using ECSM.Services.Category;
using ECSM.Services.ServiceCatalogue;

using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ECSM.Portal.Components.Catalogue
{
  public partial class CatalogueSection
  {
    [Inject]
    private IServiceCatalogueService serviceCatalogueService { get; set; }

    [Inject]
    private ICategoryService categoryService { get; set; }

    private List<ServiceCatalogueDTO> serviceCatalogues { get; set; } = [];

    private AuthModel? authModel { get; set; }

    public string setImage { get; set; } = string.Empty;

    public CardImageDTO CardImage { get; set; } = new();

    [Parameter]
    public bool HomeHasAnnoucment { get; set; } = false;

    private string HeadingText { get; set; } = string.Empty;

    protected override void OnAfterRender(bool firstRender)
    {
      if (firstRender)
      {
        GetAndSetUserInfo();
        if (authModel != null)
        {
          GetAndSetServiceCatalogues();
        }
      }
    }

    private async void GetAndSetUserInfo()
    {
      authModel = await authManager.GetAuthState();
    }

    private async void GetAndSetServiceCatalogues()
    {
      serviceCatalogues = await serviceCatalogueService.GetServiceCatalogues(authModel!.Roles);

      if (serviceCatalogues.Count() == 1)
      {
        HeadingText = $"Browse a support Category from the {serviceCatalogues.FirstOrDefault()!.Name} Catalogue you would like to interact with";
        serviceCatalogues.FirstOrDefault()!.Categories = categoryService.GetCategoriesByServiceId(serviceCatalogues.FirstOrDefault()!.ServiceCatalogueID, authModel.Roles).Result;
      }
      StateHasChanged();
    }
  }
}