using ECSM.Models.DTO;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO.ServiceCatalogueItem;

namespace ECSM.Services.ServiceCatalogue
{
  public interface IServiceCatalogueService
  {
    Task<List<ServiceCatalogueDTO>> GetFilteredServiceCataloguesSearch(List<UserRoleDTO> userRoles, string searchValues);
    Task<ServiceCatalogueDTO> GetServiceCatalogueById(Guid id);
    Task<List<ServiceCatalogueDTO>> GetServiceCatalogues(List<UserRoleDTO> userRoles);
    Task<List<ServiceCatalogueDTO>> GetServiceCataloguesWithCategories(List<UserRoleDTO> userRoles);
    Task<List<ServiceCatalogueItemDTO>> GetServiceCataloguesWithCategoriesCatalogueItems(List<UserRoleDTO> userRoles, string searchValue);
  }
}