using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.ServiceCatalogue;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Deflector
{
  public class DeflectorManagerDTO
  {
    public List<DeflectorItem> DeflectorItems { get; set; } = new List<DeflectorItem>();

    public Guid? SelectedCategoryId { get; set; }

    public ServiceCatalogueDTO ServiceCatalogue { get; set; } = new();
  }
}
