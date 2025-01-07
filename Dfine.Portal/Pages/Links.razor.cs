using ECSM.Models.DTO.PortalLink;
using ECSM.Services.PortalLink;

using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Pages
{
  public partial class Links
  {
    private List<PortalLinkDTO> portalLinkDTOs = new List<PortalLinkDTO>();

    [Inject]
    private IPortalLinkService portalLinkService { get; set; }  

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

      if (firstRender && !portalLinkDTOs.Any())
      {
        portalLinkDTOs = await portalLinkService.GetPortalLinks();
        StateHasChanged();
      }
      base.OnAfterRender(firstRender);
    }

  }
}
