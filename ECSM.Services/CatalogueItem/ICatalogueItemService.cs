using ECSM.Models.DTO.CatalogueItem;

namespace ECSM.Services.CatalogueItem
{
  public interface ICatalogueItemService
  {
    Task<CatalogueItemDTO> GetCatalogueItemWithContentBlocksById(Guid catalogueItemId);
    Task<CatalogueItemDTO> GetCatalogueItemWithFormElementsById(Guid CatalogueId);
    Task<string> GetContentBlockFileBase64(Guid contentBlockId);
  }
}