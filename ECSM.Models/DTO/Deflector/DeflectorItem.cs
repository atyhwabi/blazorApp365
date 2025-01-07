using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.ServiceCatalogue;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Deflector
{
  public class DeflectorItem
  {
    public Guid CategoryId { get; set; }

    public Guid? ServiceCatalogueItemId { get; set; }

    public string Name { get; set; }

    public int TileLayout { get; set; }

    public string Description { get; set; }

    public string IconCode { get; set; }

    public Guid ServiceCatalogueId { get; set; }

    public bool IsCategory { get; set; } = false;

    public Guid? ParentCategoryId { get; set; }

    public CategoryDTO? ParentCategory { get; set; }
  }
}
