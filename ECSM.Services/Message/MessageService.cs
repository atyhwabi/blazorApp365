using EC.DynamicsClient;
using ECSM.Models.DTO;
using ECSM.Models.DTO.Attachments;
using ECSM.Models.DTO.Cases;
using ECSM.Models.Dynamics;
using LanguageExt;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECSM.Services
{
    public class MessageService(IDynamicsQueryClient queryClient, IDynamicsManagerClient managerClient, IConfiguration Configuration) : IMessageService
    {
        IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();
        IDynamicsManagerClient managerClient = managerClient.ThrowIfNull();
        readonly IConfiguration Configuration = Configuration.ThrowIfNull();

        public async Task<string> CreateMessage(MessageCreateDTO message)
        {
            var messageToCreate = new ecsm_message
            {
                ecsm_Name = message.Name,
                ecsm_message_ = message.Message,
                ["ecsm_incident@odata.bind"] = $"/incidents({message.CaseId})"
            };

            var response = await managerClient.CreateAsync<ecsm_message>(
                    new CreateRequest<ecsm_message>(
                        ecsm_messageField.LogicalCollectionName,
                        messageToCreate)
                ).ConfigureAwait(false);

            if (response.IsSuccessStatusCode is false)
            {
                var error = await response.GetError().ConfigureAwait(false);
                throw new Exception(error!.Details.Message);
            }

            return response.Id!.Value.ToString();
        }

        public async Task<List<MessageAttachmentDTO>> GetMessageAttachmentByCaseId(string caseId)
        {
            var entityCollection = await queryClient
                   .Get<ecsm_MessageAttachment>(ecsm_MessageAttachmentField.LogicalCollectionName
                   .Query()
                   .Where([
                       ecsm_MessageAttachmentField.ecsm_incident.ToLookup().Equal(caseId)
                   ])
                   .Select([
                        ecsm_MessageAttachmentField.ecsm_MessageAttachmentId,
                        ecsm_MessageAttachmentField.ecsm_attachment_Name,
                        ecsm_MessageAttachmentField.ecsm_message.ToLookup()
                    ])
                   .Build()).ConfigureAwait(false);

            if (entityCollection is null or { Entities: null or { Length: < 1 } })
            {
                return new List<MessageAttachmentDTO>();
            }

            var result = entityCollection.Entities
                  .Select(e => new MessageAttachmentDTO
                  {
                      AttachmentId = e.ecsm_MessageAttachmentId,
                      AttachmentName = e.ecsm_attachment_Name,
                      MessageId = e.ecsm_message
                  }).ToList();

            return result;
        }

        public async Task CreateMessageAttachment(CaseMessageAttachment messageAttachment)
        {
            try
            {
                foreach (var file in messageAttachment.Files)
                {
                    var messageToCreate = new ecsm_MessageAttachment
                    {
                        ecsm_Name = file.filename,
                        ["ecsm_incident@odata.bind"] = $"/incidents({messageAttachment.CaseId})",
                        ["ecsm_message@odata.bind"] = $"/ecsm_messages({messageAttachment.MessageId})"
                    };

                    var response = await managerClient.CreateAsync<ecsm_MessageAttachment>(
                            new CreateRequest<ecsm_MessageAttachment>(
                                ecsm_MessageAttachmentField.LogicalCollectionName,
                                messageToCreate)
                        ).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode is false)
                    {
                        var error = await response.GetError().ConfigureAwait(false);
                        throw new Exception(error!.Details.Message);
                    }

                    var docBytes = Convert.FromBase64String(file.fileData);

                    var memStream = new MemoryStream(docBytes);

                    var fileUploadResponse = await managerClient.UpdateFileAsync(
                      new UpdateFileRequest(
                          ecsm_MessageAttachmentField.LogicalCollectionName,
                          response.Id!.Value,
                         ecsm_MessageAttachmentField.ecsm_attachment,
                          fileStream: memStream,
                          queryStrings: new[] {
                            new FileName(file.filename)
                          }
                        ));
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }

        public async Task<string> GetMessageAttachmentFileBase64(Guid messageattachmentId)
        {
            try
            {
                var url = new Uri($"{Configuration["DynamicsServiceEndpoint"]}{ecsm_MessageAttachmentField.EntitySetName}({messageattachmentId})/{ecsm_MessageAttachmentField.ecsm_attachment}");
                var response = await this.queryClient.Get<Dictionary<string, object>>(
                 new EntityUrlQuery(url)
                  ).ConfigureAwait(false);

                var base64Object = response!["value"];
                return base64Object.ToString()!;
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
            
    }
}
