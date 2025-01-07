using ECSM.Models.DTO.Announcement;
using ECSM.Models.DTO.ServiceCatalogueItem;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Category
{
  public class CategoryDTO
  {
    public Guid CategoryID { get; set; }

    [JsonProperty("_ecsm_service_catalogue_id_value")]
    public Guid ServiceCatalogueId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int TileLayout { get; set; }

    public bool Available { get; set; }

    public Guid? ParentCategoryId { get; set; }

    public string IconCode { get; set; } = string.Empty;

    public List<UserRoleDTO> PortalRoles { get; set; } = new List<UserRoleDTO>();

    public CategoryDTO? ParentCategory { get; set; }

    public List<CategoryDTO> ChildCategoryDTOs { get; set; } = new List<CategoryDTO>();

    public List<ServiceCatalogueItemDTO> ServiceCatalogueItems { get; set; } = new List<ServiceCatalogueItemDTO>();

    public List<AnnouncementDTO> Announcements { get; set; } = new List<AnnouncementDTO>();
  }
}
