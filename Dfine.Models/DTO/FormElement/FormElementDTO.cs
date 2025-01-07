using ECSM.Models.DTO.Metadata;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.FormElement
{
  public class FormElementDTO
  {
    public Guid FormElementId { get; set; }

    public int Order { get; set; }

    public string Label { get; set; }

    public string Sites { get; set; }

    public int ElementType { get; set; }

    public int? DataType { get; set; }

    public string ChoiceBase { get; set; } = string.Empty;

    public string[] Choices { get; set; } = [];

    public bool MapToDataverse { get; set; }

    public string ColumnName { get; set; } = string.Empty;

    public string Tooltip { get; set; } = string.Empty;

    public string ColumnPluralName { get; set; } = string.Empty;

    public EntityAtrribute DataverseAttrubute { get; set; }

    public List<LookupItem> LookupItems { get; set; } = new();

    public bool Required { get; set; }

    public void ParseChoices()
    {
      Choices = ChoiceBase?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(c => c.Trim())
                          .ToArray() ?? Array.Empty<string>();
    }
  }

  public class LookupItem
  {
    public Guid? LookupId { get; set; }

    public string? DisplayName { get; set; }
  }
}
