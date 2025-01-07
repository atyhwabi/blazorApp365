using ECSM.Models.DTO;
using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO.ServiceCatalogueItem;

namespace ECSM.Services.Cases
{
  public interface ICaseService
  {
    Task<List<CasesItemDTO>> GetCases(string? searchValue = null);

    Task<Guid> CreateCase(CasesDTO casesDTODetails);

    Task<CasesItemDTO[]> GetCasesByContactID(string ContactID);

    Task<CasesItemDTO> GetCaseByID(string caseId);

    Task<CasesItemDTO[]> GetCasesAllByContactID(string ContactID);
  }
}