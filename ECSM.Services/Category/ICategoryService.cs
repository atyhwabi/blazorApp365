namespace ECSM.Services.Category
{
  using ECSM.Models.DTO;
  using ECSM.Models.DTO.Category;

  public interface ICategoryService
  {
    Task<List<CategoryDTO>> GetCategoriesByServiceId(Guid serviceId, List<UserRoleDTO> userRoles);
    Task<List<CategoryDTO>> GetCategoriesByServicesIds(List<string> serviceCatalogueIds, List<UserRoleDTO> userRoles);
    Task<CategoryDTO> GetCategorieById(string categoryId);
    Task<CardImageDTO> PopulateSettingWithFileDataAsync(Guid? contentBlockId);
  }
}