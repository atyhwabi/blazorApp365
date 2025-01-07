using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.ServiceCatalogue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECSM.Models.DTO
{
    public class AttachmentDTO
    {
        [JsonProperty("msdyn_filename")]
        public string FileName { get; set; } 
        [JsonProperty("msdyn_kbattachmentId")]
        public string File_Download { get; set; }
    }
}



