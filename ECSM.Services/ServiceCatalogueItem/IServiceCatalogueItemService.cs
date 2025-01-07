using ECSM.Models.DTO;
using ECSM.Models.DTO.ServiceCatalogueItem;

namespace ECSM.Services.ServiceCatalogueItem
{
  public interface IServiceCatalogueItemService
  {
    Task<ServiceCatalogueItemDTO[]> GetPinnedServices(List<UserRoleDTO> userRoles);
    Task<ServiceCatalogueItemDTO> GetServiceCatalogueItemById(Guid serviceCatalogueItemId);
    Task<List<ServiceCatalogueItemDTO>> GetServiceCatalogueItemRoles(List<UserRoleDTO> userRoles, List<string> catagoryIds, string searchValues);
    Task<ServiceCatalogueItemDTO> GetServiceCatalogueItemWithCatalogueItemById(Guid serviceCatalogueItemID);
  }
}