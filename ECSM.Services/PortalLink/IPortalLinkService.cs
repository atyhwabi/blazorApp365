
using ECSM.Models.DTO.PortalLink;

namespace ECSM.Services.PortalLink
{
  public interface IPortalLinkService
  {
    Task<List<PortalLinkDTO>> GetPortalLinks();
  }
}