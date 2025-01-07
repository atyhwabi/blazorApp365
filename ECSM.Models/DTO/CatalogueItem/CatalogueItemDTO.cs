using ECSM.Models.DTO.Announcement;
using ECSM.Models.DTO.ContentBlocks;
using ECSM.Models.DTO.FormElement;

namespace ECSM.Models.DTO.CatalogueItem
{
  public class CatalogueItemDTO
  {
    public Guid CatalogueItemId { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool AvailaibeOnPortal { get; set; }

    public bool EnableSite { get; set; }

    public List<AnnouncementDTO> Announcements { get; set; } = new List<AnnouncementDTO>();

    public List<ContentBlockDTO> ContentBlocks { get; set; } = new List<ContentBlockDTO>();
    public List<FormElementDTO> FormElements { get; set; } = new();
  }
}
