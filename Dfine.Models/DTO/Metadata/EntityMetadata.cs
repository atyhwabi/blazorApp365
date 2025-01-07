using System.Text.Json.Serialization;
namespace ECSM.Models.DTO.Metadata
{
  public class EntityMetadata
  {
    public string MetadataId { get; set; }

    public string LogicalName { get; set; }

    public string LogicalCollectionName { get; set; }

    public string PrimaryNameAttribute { get; set; }

    public string PrimaryIdAttribute { get; set; }

    public List<EntityAtrribute> Attributes { get; set; }
  }

  public class EntityAtrribute
  {

    public string MetadataId { get; set; }

    public OptionSetMetadataDTO OptionSetMetadata { get; set; }
    public string LogicalName { get; set; }

    public string AttributeType { get; set; }

    public string Format { get; set; }

    public int Precision { get; set; }

    public FormatName FormatName { get; set; }

    public string[] Targets { get; set; }

    [JsonPropertyName("DisplayName")]
    public DisplayName LabelInfo { get; set; }
  }

  public class DisplayName
  {
    [JsonPropertyName("LocalizedLabels")]
    public List<LocalizedLabels> Labels { get; set; }
  }

  public class LocalizedLabels
  {
    public string Label { get; set; }
  }

  public class FormatName
  {
    public string Value { get; set; }
  }
}
