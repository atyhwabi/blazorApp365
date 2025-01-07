using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO.ServiceCatalogueItem;
using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace ECSM.Models.DTO
{
    public class KnowledgeItemDTO
    {
        public string Description { get; set; }
        public int Views { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedOnFormatted { get; set; }
        public decimal Rating { get; set; }
        public string Content { get; set; }
        public string Keywords { get; set; }
        public int Status { get; set; }
        public string StateCodeName { get; set; }
        [JsonProperty("articlepublicnumber")]
        public string PublicNumber { get; set; }
        [JsonProperty("knowledgearticle_category")]
        public List<CategoryDTO> Category { get; set; }
        [JsonProperty("ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle")]
        public List<ServiceCatalogueDTO> ServiceCatalogue { get; set; }
        [JsonProperty("msdyn_msdyn_kbattachment_knowledgearticle")]
        public List<AttachmentDTO> Attachment { get; set; }
        [JsonProperty("knowledgearticleid")]
        public Guid KnowledgeId { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonProperty("ecsm_faq")]
        public bool? IsFAQ { get; set; }
        public bool show { get; set; }
    }
}