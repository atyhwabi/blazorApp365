using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Cases
{
    public class CaseResolution
    {
        [JsonProperty("subject")]
        public string Text { get; set; }
        [JsonProperty("createdon")]
        public DateTime? Date { get; set; }
    }
}
