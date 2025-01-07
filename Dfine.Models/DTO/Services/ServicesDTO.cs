using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Services
{
  public class ServicesDTO
  {
    [JsonProperty("ecsm_enable_site")]
    public bool enable_sites { get; set; }

  }
}
