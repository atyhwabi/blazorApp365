using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.PinnedServices
{
    public class PinnedServiceDTO
    {
        [JsonProperty ("ecsm_pinnedserviceid")]
        public Guid ecsm_pinnedserviceid { get; set; }
        [JsonProperty ("ecsm_name")]
        public string ecsm_name { get; set; }
        [JsonProperty ("ecsm_order")]
        public int ecsm_order { get; set; }
    }
}
