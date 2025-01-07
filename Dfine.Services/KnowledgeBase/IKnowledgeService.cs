using ECSM.Models.DTO;

namespace ECSM.Services
{
    public interface IKnowledgeService
    {
        Task<KnowledgeItemDTO[]> GetKnowledgeItems(string searchText = null, bool orderby = false);
        Task<KnowledgeItemDTO[]> GetKnowledgeItemsTop3Popular();
        Task<KnowledgeItemDTO[]> GetKnowledgeItemsTop5Latest(string searchText = null);
        Task<KnowledgeItemDTO[]> GetFaqItemsTop5Latest(string searchText = null);
        Task<KnowledgeItemDTO[]> GetKnowledgeItemsTop3Rating();
        Task<KnowledgeItemDTO> GetKnowledgeItemArticle(string articlePublicNumber);
        Task<string> GetAttachmentFileBase64(string attachment_name);
        Task<KnowledgeItemDTO[]> GeFAQItems(string searchText);
    }
}
