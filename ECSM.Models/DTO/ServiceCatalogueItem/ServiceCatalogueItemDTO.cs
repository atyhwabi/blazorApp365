using ECSM.Models.DTO.CatalogueItem;
using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.PinnedServices;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.ServiceCatalogueItem
{
  public class ServiceCatalogueItemDTO
  {
    [JsonProperty("ecsm_service_catalogue_itemid")]
    public Guid ServiceCatalogueItemId { get; set; }

    public Guid ServiceCatalogueId { get; set; }

    public Guid CategoryId { get; set; }

    public Guid? CatalogueItemId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int TileLayout { get; set; }

    public string Description { get; set; } = string.Empty;

    public string IconCode { get; set; } = string.Empty;

    public List<UserRoleDTO> PortalRoles { get; set; } = new List<UserRoleDTO>();

    public CategoryDTO Categories { get; set; } = new();

    public ServiceCatalogueDTO ServiceCatalogue { get; set; } = new();

    public CatalogueItemDTO CatalogueItemDTO { get; set; } = new CatalogueItemDTO();

    public List<KnowledgeItemDTO> KnowledgeArticles { get; set; } = new List<KnowledgeItemDTO>();

    public List<PinnedServiceDTO> PinnedServices { get; set; } = new List<PinnedServiceDTO>();
  }
}
