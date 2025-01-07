using Newtonsoft.Json;

namespace ECSM.Models.DTO.Announcement
{
  public class AnnouncementDTO
  {
    [JsonProperty("ecsm_announcementid")]
    public Guid Id { get; set; }

    [JsonProperty("ecsm_name")]
    public string Title { get; set; } = string.Empty;

    [JsonProperty("ecsm_announcement_body")]
    public string Body { get; set; } = string.Empty;

    [JsonProperty("ecsm_announcement_type")]
    public int AnnouncementType { get; set; }

    [JsonProperty("ecsm_addtohome")]
    public bool AddToHome { get; set; }

    [JsonProperty("ecsm_expiry_date")]
    public DateTime ExpiryDate { get; set; }
  }
}
