using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Attachments
{
    public class MessageAttachmentDTO
    {
        [JsonProperty("ecsm_attachment_name")]
        public string AttachmentName { get; set; }
        [JsonProperty("ecsm_messageattachmentid")]
        public Guid? AttachmentId { get; set; }
        [JsonProperty("_ecsm_message_value")]
        public Guid? MessageId { get; set; }
    }
}
