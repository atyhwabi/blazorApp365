using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Cases
{
    public class CaseMessage
    {
        [JsonProperty("ecsm_messageid")]
        public Guid? MessageID { get; set; }
        [JsonProperty("ecsm_message")]
        public string Message { get; set; } = string.Empty;
        [JsonProperty("ecsm_name")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("createdon")]
        public DateTime? CreatedDate { get; set; }
        [JsonProperty("_createdby_value@OData.Community.Display.V1.FormattedValue")]
        public string CreatedBy { get; set; }
    }
}
