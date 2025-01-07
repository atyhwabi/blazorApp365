using EC.DynamicsClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSM.Models.DTO;
using ECSM.Models.DTO.Sites;
using ECSM.Models.DTO.ServiceCatalogueItem;
using ECSM.Models.Dynamics;

namespace ECSM.Services.Sites
{
  public class SiteService(IDynamicsQueryClient queryClient) : ISiteService
  {
    readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();

    public async Task<List<SiteDTO>> GetAllSites()
    {
      var response = await this.queryClient.Get<Site>(
        SiteField.EntitySetName
        .Query()
        .Select([
          SiteField.SiteId,
          SiteField.Name
        ]).Build()
        ).ConfigureAwait(false);
      var results = response.Entities.Select(e => new SiteDTO
      {
        SiteId = (Guid)e.SiteId!,
        Name = e.Name ?? ""
      }).ToList();
      return results;
    }
  }
}
