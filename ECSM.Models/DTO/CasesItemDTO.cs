using ECSM.Models.DTO.Cases;
using Newtonsoft.Json;

namespace ECSM.Models.DTO;
public class CasesItemDTO
{   
    public Guid? CaseCatalogue { get; set; }
    public Guid? CaseCategory { get; set; }
    public Guid CaseId { get; set; }
    public string CasePriority { get; set; }
    public string CaseApprovalStatus { get; set; }
    public string CaseNumber { get; set; }
    public string CaseTitle { get; set; }
    public int CaseType { get; set; }
    public string CasesTicketNumber { get; set; }
    public string Description { get; set; } = string.Empty;
	public DateTime? ModifiedOn { get; set; }
	public string StatusReason { get; set; } = string.Empty;
	public string CreatedBy { get; set; } = string.Empty;
	public string Owner { get; set; } = string.Empty;
	public List<CaseMessage> Messages { get; set; } = new List<CaseMessage>();
    public List<CaseResolution> Resolution { get; set; } = new List<CaseResolution>();
}
