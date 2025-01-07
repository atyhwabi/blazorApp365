using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECSM.Models.DTO
{
    public class UserRoleDTO {
       [JsonProperty("ecsm_portal_roleid")]
       public Guid? RoleID { get; set; }
        [JsonProperty("ecsm_Name")]
        public string RoleName { get; set; }
        [JsonProperty("ecsm_description")]
        public string Description { get; set; }
    }
}
