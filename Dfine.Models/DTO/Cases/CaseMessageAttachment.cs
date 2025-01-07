using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Cases
{
    public class CaseMessageAttachment
    {
        public Guid? CaseId { get; set; }
        public Guid? MessageId { get; set; }
        public List<MessageAttachment> Files { get; set; } = new List<MessageAttachment>();
    }

    public class MessageAttachment
    {
        public string filename { get; set; }
        public string fileData { get; set; }
        public string type { get; set; }
    }
}
