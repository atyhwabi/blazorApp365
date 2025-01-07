using EC.DynamicsClient;
using ECSM.Models.DTO.PortalLink;
using ECSM.Models.Dynamics;

namespace ECSM.Services.PortalLink
{
  public class vnnnvn(IDynamicsQueryClient dynamicsQueryClient) : IPortalLinkService
  {

    readonly IDynamicsQueryClient dynamicsQueryClient = dynamicsQueryClient.ThrowIfNull();

    public async Task<List<PortalLinkDTO>> GetPortalLinks()
    {
      var response = await this.dynamicsQueryClient.Get<ecsm_portal_link>(
        ecsm_portal_linkField.LogicalCollectionName.Query().Build()
        ).ConfigureAwait(false);

      var result = response!.Entities!.Select(e => new PortalLinkDTO
      {
        PortalLinkId = (Guid)e.ecsm_portal_linkId!,
        Name = e.ecsm_Name ?? "",
        URL = e.ecsm_url ?? ""
      }).ToList();

      return result;
    }
  }
}