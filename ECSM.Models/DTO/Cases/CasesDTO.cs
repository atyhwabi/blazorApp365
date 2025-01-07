using ECSM.Models.DTO.Cases;
using ECSM.Models.DTO.FormElement;
using ECSM.Models.DTO.Sites;
namespace ECSM.Models.DTO;

public class CasesDTO
{
  public Guid CaseId { get; set; }

  public Guid ServiceCatalogueItem { get; set; }

  public Guid CatalogueItemId { get; set; }

  public string CatalogueName { get; set; } = string.Empty;

  public Guid CaseCategory { get; set; }

  public int CasePriority { get; set; }

  public int CaseApprovalStatus { get; set; }

  public string CaseNumber { get; set; } = string.Empty;

  public string CaseTitle { get; set; } = string.Empty;

  public string CaseTooltip { get; set; } 

  public string CaseEnableSite { get; set; } = string.Empty;

  public string CaseDescription { get; set; } = string.Empty;

  public string SelectedSite { get; set; } = string.Empty;

  public bool BoolAnswer { get; set; }

  public Guid ContactId { get; set; }

  public Guid? SiteId { get; set; }

  public string ContactFullName { get; set; } = string.Empty;

  public List<CaseAnswer> CaseAnswers { get; set; } = new();

  public List<SiteDTO> CaseSites { get; set; } = new();
};
