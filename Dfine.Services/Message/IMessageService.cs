using ECSM.Models.DTO;
using ECSM.Models.DTO.Attachments;
using ECSM.Models.DTO.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Services
{
    public interface IMessageService
    {
        Task<string> CreateMessage(MessageCreateDTO message);
        Task CreateMessageAttachment(CaseMessageAttachment messageAttachment);
        Task<List<MessageAttachmentDTO>> GetMessageAttachmentByCaseId(string caseId);
        Task<string> GetMessageAttachmentFileBase64(Guid messageattachmentId);
    }
}
