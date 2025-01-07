using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.ServiceCatalogue
{
  public class CatalogueCardDTO
  {
    public Guid ServiceCatalogueId { get; set; }

    public Guid? CategoryID { get; set; }

    public string Name { get; set; } = string.Empty;

    public int TileLayout { get; set; }

    public string Description { get; set; } = string.Empty;

    public string IconCode { get; set; } = string.Empty;

    public bool IsCatalogue { get; set; }
  }
}
