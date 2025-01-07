using EC.DynamicsClient;
using ECSM.Models.DTO;
using ECSM.Models.DTO.Cases;
using ECSM.Models.Dynamics;
using Newtonsoft.Json;
using System.Buffers;

namespace ECSM.Services.Cases
{
  public class CaseService(IDynamicsQueryClient queryClient, IDynamicsManagerClient managerClient) : ICaseService
  {
    readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();
    readonly IDynamicsManagerClient managerClient = managerClient.ThrowIfNull();

    public async Task<Guid> CreateCase(CasesDTO casesDTODetails)
    {
      try
      {
        var caseAnswers = casesDTODetails.CaseAnswers;

        var formAnswers = caseAnswers.Where(c => c.FormElement.MapToDataverse == false).ToList();

        var dataverseAnswers = caseAnswers.Where(c => c.FormElement.MapToDataverse == true).ToList();

        var formAnswerJson = JsonConvert.SerializeObject(formAnswers);

        var caseEntity = new Incident
        {
          ["customerid_contact@odata.bind"] = $"contacts({casesDTODetails.ContactId})",
          ["ecsm_category@odata.bind"] = $"ecsm_categories({casesDTODetails.CaseCategory})",
          ["ecsm_catalogue_item@odata.bind"] = $"ecsm_catalogue_items({casesDTODetails.CatalogueItemId})",
          Title = $"{casesDTODetails.CatalogueName}",
          Description = casesDTODetails.CaseDescription,
          ecsm_variable_data = formAnswerJson,
          CaseOriginCode = incident_caseorigincode.SelfService,
          ecsm_created_by_portal = true,
        };

        if (casesDTODetails.SiteId != null)
        {
          caseEntity["ecsm_site@odata.bind"] = $"sites({casesDTODetails.SiteId})";
        }

        foreach (var item in dataverseAnswers)
        {
          switch (item.FormElement.DataverseAttrubute.AttributeType)
          {
            case "String":
              caseEntity[item.FormElement.DataverseAttrubute.LogicalName] = item.Answer;
              break;
            case "Memo":
              caseEntity[item.FormElement.DataverseAttrubute.LogicalName] = item.Answer;
              break;
            case "Integer":
              caseEntity[item.FormElement.DataverseAttrubute.LogicalName] = item.NumberAnswer;
              break;
            case "Decimal":
              caseEntity[item.FormElement.DataverseAttrubute.LogicalName] = item.DecimalAnswer;
              break;
            case "DateTime":
              caseEntity[item.FormElement.DataverseAttrubute.LogicalName] = item.DateAnswer;
              break;
            case "Picklist":
              caseEntity[item.FormElement.DataverseAttrubute.LogicalName] = item.NumberAnswer;
              break;
            case "Boolean":
              caseEntity[item.FormElement.DataverseAttrubute.LogicalName] = item.BoolAnswer;
              break;
            case "Lookup":
              caseEntity[$"{item.FormElement.ColumnName}@odata.bind"] = $"{item.FormElement.ColumnPluralName}({item.FormElement.LookupItems.FirstOrDefault(c => c.DisplayName == item.Answer)!.LookupId})";
              break;
          }
        }

        var result = await this.managerClient.CreateAsync<Incident>(
          new CreateRequest<Incident>(
            IncidentField.LogicalCollectionName,
            caseEntity
            )
          ).ConfigureAwait(false);

        return (Guid)result.Id!;
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    public async Task<List<CasesItemDTO>> GetCases(string? searchValue = null)
    {
      var response = await queryClient
      .Get<Incident>(IncidentField.LogicalCollectionName
      .Query()
      .Select([
          IncidentField.IncidentId,
                IncidentField.ecsm_catalogue_item.ToLookup(),
                IncidentField.ecsm_category.ToLookup(),
                IncidentField.PriorityCode,
                IncidentField.ecsm_approval_status,
                IncidentField.Title,
                IncidentField.TicketNumber,
                IncidentField.ModifiedOn,
                IncidentField.StatusCode
       ])
        .Where
         ([
           new Group(Join.or, [
                           IncidentField.Title.ToLower().Contains2(searchValue?.ToLower()),
                            IncidentField.TicketNumber.ToLower().Contains2(searchValue?.ToLower())
                        ])
                    ])
            .Headers([new AddPrefer([new IncludeFormattedValue()])])
            .Build()).ConfigureAwait(false);
      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }
      return response.Entities
          .Select(e => new CasesItemDTO
          {
            CaseId = (Guid)e.IncidentId,
            CaseCatalogue = (Guid?)e.ecsm_catalogue_item,
            CaseCategory = (Guid?)e.ecsm_category,
            CasePriority = e.PriorityCode.ToString() ?? "",
            CaseApprovalStatus = e.ecsm_approval_statusFormattedValue ?? "",
            CaseTitle = e.Title ?? "",
            CaseNumber = e.TicketNumber ?? "",
            ModifiedOn = e.ModifiedOn,
            StatusReason = e.StatusCodeFormattedValue ?? ""
          }).ToList();
    }

    public async Task<CasesItemDTO[]> GetCasesByContactID(string ContactID)
    {
      var response = await queryClient
         .Get<Models.Dynamics.Incident>(IncidentField.LogicalCollectionName
         .Query()
         .Select([
              IncidentField.TicketNumber,
              IncidentField.Title,
              IncidentField.ecsm_incident_type,
              IncidentField.CustomerId.ToLookup(),
              IncidentField.ecsm_catalogue_item.ToLookup(),

            ])
       .Where([
       IncidentField.CustomerId.ToLookup().Equal(ContactID)
       ])
       .Top(5)
       .Build()).ConfigureAwait(false);

      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }

      return response.Entities
          .Select(e => new CasesItemDTO
          {
            CaseId = e.IncidentId.Value,
            CaseTitle = e.Title,
            CasesTicketNumber = e.TicketNumber
          })
          .ToArray();
    }

        public async Task<CasesItemDTO[]> GetCasesAllByContactID(string ContactID)
        {
            var response = await queryClient
               .Get<Models.Dynamics.Incident>(IncidentField.LogicalCollectionName
               .Query()
               .Headers([new AddPrefer([new IncludeFormattedValue()])])
               .Select([
                    IncidentField.TicketNumber,
                    IncidentField.Title,
                    IncidentField.ecsm_incident_type,
                    IncidentField.CustomerId.ToLookup(),
                    IncidentField.ecsm_catalogue_item.ToLookup(),
                    IncidentField.ModifiedOn,
                    IncidentField.StatusCode
                ])
                .Where([
                IncidentField.CustomerId.ToLookup().Equal(ContactID)
                ])
                .Build()).ConfigureAwait(false);

            if (response is null or { Entities: null or { Length: <= 0 } })
            {
                return [];
            }

            return response.Entities
                .Select(e => new CasesItemDTO
                {
                    CaseId = e.IncidentId.Value,
                    CaseTitle = e.Title,
                    CaseNumber = e.TicketNumber,
                    ModifiedOn = e.ModifiedOn,
                    StatusReason = e.StatusCodeFormattedValue
                })
                .ToArray();
        }

        public async Task<CasesItemDTO> GetCaseByID(string caseId)
    {
      try
      {
        var response = await queryClient
        .Get<Incident>(IncidentField.LogicalCollectionName
        .Query()
        .Headers([new AddPrefer([new IncludeFormattedValue()])])
        .Select([
            IncidentField.IncidentId,
                    IncidentField.ecsm_catalogue_item.ToLookup(),
                    IncidentField.ecsm_category.ToLookup(),
                    IncidentField.PriorityCode,
                    IncidentField.ecsm_approval_status,
                    IncidentField.Title,
                    IncidentField.TicketNumber,
                    IncidentField.ModifiedOn,
                    IncidentField.Description,
                    IncidentField.StatusCode,
                    IncidentField.CreatedBy_Lookup,
                    IncidentField.OwnerId_Lookup
         ])
         .ExpandOn(
            new Expand(IncidentOneToMany.ecsm_message_incident_incident))
         .ExpandOn(
            new Expand(IncidentOneToMany.Incident_IncidentResolutions))
         .Where([
            IncidentField.IncidentId.Equal(caseId)
         ])
        .Build()).ConfigureAwait(false);
        if (response is null or { Entities: null or { Length: <= 0 } })
        {
          return null;
        }
        var result = response.Entities
            .Select(e => new CasesItemDTO
            {
              CaseId = (Guid)e.IncidentId,
              CaseCatalogue = (Guid?)e.ecsm_catalogue_item,
              CaseCategory = (Guid?)e.ecsm_category,
              CasePriority = e.PriorityCodeFormattedValue ?? "",
              CaseApprovalStatus = e.ecsm_approval_statusFormattedValue ?? "",
              CaseTitle = e.Title ?? "",
              CaseNumber = e.TicketNumber ?? "",
              ModifiedOn = e.ModifiedOn,
              Description = e.Description ?? "",
              StatusReason = e.StatusCodeFormattedValue ?? "",
              CreatedBy = e.CreatedByFormattedValue ?? "",
              Owner = e.OwnerIdFormattedValue ?? "",
              Messages = JsonConvert.DeserializeObject<List<CaseMessage>>(e["ecsm_message_incident_incident"]?.ToString()),
              Resolution = JsonConvert.DeserializeObject<List<CaseResolution>>(e["Incident_IncidentResolutions"]?.ToString())
            }).FirstOrDefault();

        result.Messages = result.Messages.OrderByDescending(o => o.CreatedDate).ToList();

        return result;
      }
      catch (Exception exception)
      {
        throw new Exception(exception.Message);
      }
    }
  }
}