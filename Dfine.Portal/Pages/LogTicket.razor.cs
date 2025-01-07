using System.Collections;

namespace ECSM.Portal.Pages
{
  using Models.DTO;
  using Models.DTO.ServiceCatalogueItem;
  using Models.DTO.Sites;
  using Models.Dynamics;
  using Services.Cases;
  using Services.Sites;
  using Services.ServiceCatalogueItem;

  using Microsoft.AspNetCore.Components;
  using Microsoft.AspNetCore.Components.Forms;

  public partial class LogTicket
  {
    [Inject] private ICaseService CaseService { get; set; }

    [Inject] private ISiteService SiteService { get; set; }

    [Inject] private IServiceCatalogueItemService ServiceCatalogueItemService { get; set; }

    [Parameter] public string ServiceCatalogueItemId { get; set; }

    [Parameter] public string? PublicParameter { get; set; }

    public ServiceCatalogueItemDTO ServiceCatalogueItemDTO { get; set; } = new();

    protected List<SiteDTO> SiteList { get; set; }

    private CasesDTO NewCase { get; set; } = new();

    private AuthModel? AuthModel { get; set; }

    private bool Submitting { get; set; }

    private bool LoadingFormElements = true;

    private readonly Dictionary<string, bool> labelVisibility = [];

    public Guid DescriptionGuid { get; set; } = Guid.NewGuid();

    public Guid SiteGuid { get; set; } = Guid.NewGuid();

    private string GetClass(string id) => labelVisibility.ContainsKey(id) && labelVisibility[id] ? "show" : "hide";

    protected override async Task OnParametersSetAsync()
    {

      if (!string.IsNullOrEmpty(ServiceCatalogueItemId))
      {
        await GetAndSetUserInfo();
        var serviceCatalogueItemId = Guid.Parse(ServiceCatalogueItemId);

        await GetServiceCatalogueItemInfo(serviceCatalogueItemId);
      StateHasChanged();
      }

      await base.OnParametersSetAsync();
    }

    private async Task GetServiceCatalogueItemInfo(Guid id)
    {
      LoadingFormElements = true;
      StateHasChanged();
      ServiceCatalogueItemDTO = await this.ServiceCatalogueItemService.GetServiceCatalogueItemWithCatalogueItemById(id);
      NewCase.CatalogueName = ServiceCatalogueItemDTO.CatalogueItemDTO.Name;
      NewCase.ServiceCatalogueItem = ServiceCatalogueItemDTO.ServiceCatalogueItemId;
      NewCase.CatalogueItemId = ServiceCatalogueItemDTO.CatalogueItemDTO.CatalogueItemId;
      NewCase.CaseCategory = ServiceCatalogueItemDTO.CategoryId;
      NewCase.CaseAnswers = new();
      if (ServiceCatalogueItemDTO.CatalogueItemDTO.EnableSite)
      {
        SiteList = await this.SiteService.GetAllSites();
      }

      foreach (var item in ServiceCatalogueItemDTO.CatalogueItemDTO.FormElements.Where(c =>
                 c.ElementType == ecsm_form_element_type.Variable))
      {
        NewCase.CaseAnswers.Add(new Models.DTO.Cases.CaseAnswer
        {
          FormElementId = item.FormElementId,
          FormElement = item,
          Label = item.Label,
          Tooltip = item.Tooltip,
          Required = item.Required,
        });
      }

      LoadingFormElements = false;
    }

    private async Task GetAndSetUserInfo()
    {
      AuthModel = await authManager.GetAuthState();

      if (AuthModel.Contact.ContactID != null)
      {
        NewCase.ContactId = (Guid)AuthModel.Contact.ContactID;
        NewCase.ContactFullName = AuthModel.Contact.FullName;
      }
    }

    public async Task OnFileSelect(InputFileChangeEventArgs args, Guid FormElementId)
    {
      if (IsObjectEmpty(args))
      {
        labelVisibility["error-message-" + FormElementId] = true;
      }

      var formElement =
        ServiceCatalogueItemDTO.CatalogueItemDTO.FormElements.FirstOrDefault(x => x.FormElementId == FormElementId);

      var file = args.File;
      var fileName = file.Name;
      using var stream = file.OpenReadStream(maxAllowedSize: 1024 * 1024 * 15); // 15 MB

      var buffer = new byte[file.Size];

      int bytesRead;
      int totalBytesRead = 0;
      do
      {
        bytesRead = await stream.ReadAsync(buffer, totalBytesRead, buffer.Length - totalBytesRead);
        totalBytesRead += bytesRead;
      } while (bytesRead > 0);

      var base64String = Convert.ToBase64String(buffer, 0, totalBytesRead);

      NewCase.CaseAnswers.FirstOrDefault(x => x.FormElementId == FormElementId)!.Answer = base64String;
      NewCase.CaseAnswers.FirstOrDefault(x => x.FormElementId == FormElementId)!.fileName = fileName;
    }

    public async Task SubmitForm()
    {
      bool isDataValid = true;
      if (ServiceCatalogueItemDTO.CatalogueItemDTO.EnableSite && NewCase.SiteId == null)
      {
        labelVisibility["error-message-" + SiteGuid] = true;
        if (isDataValid)
        {
          isDataValid = false;
        }
      }
      if (string.IsNullOrWhiteSpace(NewCase.CaseDescription))
      {
        labelVisibility["error-message-" + DescriptionGuid] = true;
        if (isDataValid)
        {
          isDataValid = false;
        }
      }
      Submitting = true;
      StateHasChanged();
      var caseAnswers = new List<CaseAnswerResponse>();

      foreach (var item in NewCase.CaseAnswers)
      {
        if (item.Required && IsObjectEmpty(item.Answer))
        {
          labelVisibility["error-message-" + item.FormElementId] = true;
          if (isDataValid)
          {
            isDataValid = false;
          }
        }
        var formElement =
          ServiceCatalogueItemDTO.CatalogueItemDTO.FormElements.FirstOrDefault(x =>
            x.FormElementId == item.FormElementId);

        var caseAnswer = new CaseAnswerResponse
        {
          FormId = item.FormElementId
        };

        switch (formElement!.DataType)
        {
          case ecsm_variable_data_type.SingleText:
            caseAnswer.Label = item.Label;
            caseAnswer.Answer = item.Answer;
            break;
          case ecsm_variable_data_type.MultiText:
            caseAnswer.Label = item.Label;
            caseAnswer.Answer = item.Answer;
            break;
          case ecsm_variable_data_type.Number:
            caseAnswer.Label = item.Label;
            caseAnswer.Answer = item.NumberAnswer.ToString();
            break;
          case ecsm_variable_data_type.Date:
            caseAnswer.Label = item.Label;
            caseAnswer.Answer = item.DateAnswer.ToString();
            break;
          case ecsm_variable_data_type.Boolean:
            caseAnswer.Label = item.Label;
            caseAnswer.Answer = item.BoolAnswer.ToString();
            break;
          case ecsm_variable_data_type.File:
            caseAnswer.Label = item.Label;
            caseAnswer.FileName = item.fileName;
            caseAnswer.fileData = item.Answer;
            break;
          case ecsm_variable_data_type.Choice:
            caseAnswer.Label = item.Label;
            caseAnswer.Answer = item.Answer;
            break;
        }

        caseAnswers.Add(caseAnswer);
      }

      if (!isDataValid)
      {
        Submitting = false;
        return;
      }

      var caseId = await this.CaseService.CreateCase(NewCase);
      Submitting = false;
      StateHasChanged();
      if (navigationManager.UriContains("public"))
      {
        navigationManager.NavigateTo("/", ispublic: true);
      }
      else
      {
        navigationManager.NavigateTo($"/case/{caseId}");
      }
    }

    private void ValidateValue(bool isRequired, object? value, Guid? id)
    {
      if (isRequired && IsObjectEmpty(value))
      {
        labelVisibility["error-message-" + id] = true;
      }
      else
      {
        labelVisibility["error-message-" + id] = false;
      }
    }

    private bool IsObjectEmpty(object? myObject)
    {
      if (myObject == null)
        return true;

      if (myObject is string str && string.IsNullOrEmpty(str))
        return true;

      if (myObject is ICollection collection && collection.Count == 0)
        return true;

      if (Equals(myObject, GetDefaultValue(myObject.GetType())))
        return true;

      return false;
    }

    private static object? GetDefaultValue(Type type)
    {
      return type.IsValueType ? Activator.CreateInstance(type) : null;
    }
  }

  public class CaseAnswerResponse
  {
    public Guid FormId { get; set; }

    public string Label { get; set; }

    public string Answer { get; set; }

    public string FileName { get; set; }

    public string fileData { get; set; }

    public string Tooltip { get; set; }
  }
}
