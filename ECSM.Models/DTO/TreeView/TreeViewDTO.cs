using ECSM.Models.DTO.ServiceCatalogue;

namespace ECSM.Models.DTO.TreeView
{
  public class TreeViewDTO
  {
    public List<ServiceCatalogueDTO> ServiceCatalogues { get; set; }

    public Guid? SelectedServiceCatalogue { get; set; }

    public Guid? SelectedCategory { get; set; }
  }
}
