using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.ContentBlocks
{
  public class ContentBlockDTO
  {
    public Guid ContentBlockId { get; set; }

    public Guid CatalogueItemId { get; set; }

    public int ContentType { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ContentText { get; set; } = string.Empty;

    public object? ContentFile { get; set; }

    public string FileName { get; set; } = string.Empty;

    public int Order { get; set; }
  }
}
