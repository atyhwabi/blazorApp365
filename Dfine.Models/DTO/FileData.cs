namespace ECSM.Models.DTO
{
  using System.Text.Json.Serialization;

  public class FileData
  {
    [JsonPropertyName("mimetype")]
    public string MimeType { get; set; }
    [JsonPropertyName("filename")]
    public string FileName { get; set; }
  }
}
