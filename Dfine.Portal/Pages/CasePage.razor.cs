using ECSM.Models.DTO;
using ECSM.Services.Cases;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components.Editor;
using Telerik.Blazor.Components;
using ECSM.Services;
using ECSM.Models.DTO.Cases;
using Microsoft.JSInterop;
using Telerik.Blazor.Components.ColorGradient;
using ECSM.Models.DTO.Attachments;
using static Telerik.Blazor.ThemeConstants;
using Telerik.Blazor;
using Telerik.SvgIcons;

namespace ECSM.Portal.Pages
{
    public partial class CasePage : ComponentBase
    {
        [Parameter]
        public string CaseId { get; set; }
        [Inject]
        ICaseService caseService { get; set; }
        [Inject]
        IMessageService messageService { get; set; }
        [Inject]
        private IJSRuntime JS { get; set; }

        public TelerikNotification Notification { get; set; }

        public CasesItemDTO caseItem { get; set; }
        public string message { get; set; }

        public List<IEditorTool> Tools { get; set; } =
               new List<IEditorTool>()
               {
                    new EditorButtonGroup(new Telerik.Blazor.Components.Editor.Bold(), new Telerik.Blazor.Components.Editor.Italic(), new Telerik.Blazor.Components.Editor.Underline(), new Telerik.Blazor.Components.Editor.Strikethrough()),
               };

        public List<string> AllowedExtensions { get; set; } = new List<string>() { ".docx", ".pdf", ".jpg", ".png" };

        public AuthModel authModel { get; set; }

        public CaseMessageAttachment caseMessageAttachment { get; set; } = new CaseMessageAttachment();

        public List<MessageAttachmentDTO> messageAttachments { get; set; } = new List<MessageAttachmentDTO>(); 

        TelerikFileSelect fileSelectRef;
        TelerikEditor editorRef;

        protected override async Task OnInitializedAsync()
        {
            authModel = await authManager.GetAuthState();
            caseItem = await caseService.GetCaseByID(CaseId);
            messageAttachments = await messageService.GetMessageAttachmentByCaseId(caseItem.CaseId.ToString());
        }

        public void Back()
        {
            navigationManager.NavigateTo("/mycases");
        }

        public async Task CreateMessage()
        {
            var messageCreateDTO = new MessageCreateDTO
            {
                Name = $"{authModel.Contact.FullName} : {DateTime.Now}",
                Message = this.message,
                CaseId = this.caseItem.CaseId.ToString()
            };

            var messageID = await messageService.CreateMessage(messageCreateDTO);

            this.caseItem.Messages.Insert(0, new Models.DTO.Cases.CaseMessage()
            {
                Name = messageCreateDTO.Name,
                CreatedDate = DateTime.Now,
                Message = messageCreateDTO.Message,
                MessageID = new Guid(messageID),
                CreatedBy = authModel.Contact.FirstName.ToString()
            });

            caseMessageAttachment.CaseId = caseItem.CaseId;
            caseMessageAttachment.MessageId = new Guid(messageID);

            await messageService.CreateMessageAttachment(caseMessageAttachment);

            this.message = string.Empty;
            await editorRef.ExecuteAsync(new HtmlCommandArgs("setHtml", ""));

            fileSelectRef.ClearFiles();
            caseMessageAttachment = new CaseMessageAttachment();

            messageAttachments = await this.messageService.GetMessageAttachmentByCaseId(caseItem.CaseId.ToString());

            await InvokeAsync(() => StateHasChanged());
        }

        async Task OnSelectHandler(FileSelectEventArgs args)
        {
            foreach (var file in args.Files)
            {
                var buffer = new byte[file.Stream.Length];
                await file.Stream.ReadAsync(buffer);
                var base64String = Convert.ToBase64String(buffer);

                caseMessageAttachment.Files.Add(new MessageAttachment
                {
                    filename = file.Name,
                    fileData = base64String,
                    type = file.Extension
                });
            }
        }

        async Task DownloadFile(Guid? fileId, string fileName)
        {
            var notification = new NotificationModel()
            {
                Text = "Fetching File Information. Your download will start automatically once ready.",
                ThemeColor = ThemeConstants.Notification.ThemeColor.Info,
                CloseAfter = 0
            };

            Notification.Show(notification);

            var fileData = await this.messageService.GetMessageAttachmentFileBase64(fileId.Value);

            await JS.InvokeVoidAsync("downloadFile", fileName, "application/octet-stream", fileData);

            Notification.Hide(notification);
        }
    }
}
