using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class OptionSetMetadataDTO
{
  public string Name { get; set; }

  public string MetadataId { get; set; }

  public List<OptionDTO> Options { get; set; }
}

public class OptionDTO 
{
  public string Label { get; set; }

  public int Value { get; set; }
}


public class OptionSetMetadata
{
  public string Name { get; set; }

  public string OptionSetType { get; set; }

  public string MetadataId { get; set; }

  [JsonPropertyName("OptionSet")]
  public OptionSet OptionSet { get; set; }

  [JsonPropertyName("GlobalOptionSet")]
  public OptionSet GlobalOptionSet { get; set; }

  public List<Option> Options { get; set; }

  public DisplayName DisplayName { get; set; }
}

public class OptionSet
{
  [JsonPropertyName("Options")]
  public List<Option> Options { get; set; }
}

public class Option
{
  public int Value { get; set; }

  public Label Label { get; set; }
}

public class Label
{
  public UserLocalizedLabel UserLocalizedLabel { get; set; }
}

public class LocalizedLabel
{
  public string Label { get; set; }
  public string MetadataId { get; set; }
}

public class UserLocalizedLabel
{
  public string Label { get; set; }
  public string MetadataId { get; set; }
}


public class DisplayName
{
  public UserLocalizedLabel UserLocalizedLabel { get; set; }
}

