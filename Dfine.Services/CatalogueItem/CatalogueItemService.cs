namespace ECSM.Services.CatalogueItem
{
  using EC.DynamicsClient;
  using ECSM.Models.DTO.CatalogueItem;
  using Models.DTO.Announcement;
  using Models.DTO.ContentBlocks;
  using Models.DTO.FormElement;
  using Models.DTO.Metadata;
  using Models.Dynamics;
  using Microsoft.Extensions.Configuration;
  using Newtonsoft.Json;

  public class CatalogueItemService(IDynamicsQueryClient queryClient, IConfiguration Configuration) : ICatalogueItemService
  {
    readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();
    readonly IConfiguration Configuration = Configuration.ThrowIfNull();

    public async Task<CatalogueItemDTO> GetCatalogueItemWithContentBlocksById(Guid catalogueItemId)
    {
      var response = await this.queryClient.Get<ecsm_catalogue_item>(
                                     ecsm_catalogue_itemField.EntitySetName
                          .Query()
                          .ExpandOn(new Expand(ecsm_catalogue_itemManyToMany.ecsm_announcement_ecsm_catalogue_item_ecsm_catalogue_item))
                          .Where([ecsm_catalogue_itemField.ecsm_catalogue_itemId.Equal(catalogueItemId)])
                          .Build()).ConfigureAwait(false);

      var result = response!.Entities!.Select(e => new CatalogueItemDTO
      {
        CatalogueItemId = (Guid)e.ecsm_catalogue_itemId!,
        AvailaibeOnPortal = e.ecsm_available_on_portal ?? false,
        Name = e.ecsm_Name ?? "",
        Announcements = JsonConvert.DeserializeObject<List<AnnouncementDTO>>(e["ecsm_announcement_ecsm_catalogue_item_ecsm_catalogue_item"]?.ToString()!) ?? new List<AnnouncementDTO>()
      }).FirstOrDefault();

      result!.ContentBlocks = await this.GetContentBlocks(catalogueItemId).ConfigureAwait(false);
      return result!;
    }

    public async Task<CatalogueItemDTO> GetCatalogueItemWithFormElementsById(Guid CatalogueId)
    {
      var response = await this.queryClient.Get<ecsm_catalogue_item>(
                               ecsm_catalogue_itemField.EntitySetName
                    .Query()
                    .Where([ecsm_catalogue_itemField.ecsm_catalogue_itemId.Equal(CatalogueId)])
                    .Build()).ConfigureAwait(false);

      var result = response!.Entities!.Select(e => new CatalogueItemDTO
      {
        CatalogueItemId = (Guid)e.ecsm_catalogue_itemId!,
        AvailaibeOnPortal = e.ecsm_available_on_portal ?? false,
        Name = e.ecsm_Name ?? "",
        EnableSite = e.ecsm_enable_site ?? false
      }).FirstOrDefault();

      result.FormElements = await this.GetCatalogueFormElements(CatalogueId).ConfigureAwait(false);

      return result!;
    }

    public async Task<string> GetContentBlockFileBase64(Guid contentBlockId)
    {
      var url = new Uri($"{Configuration["DynamicsServiceEndpoint"]}{ecsm_content_blockField.EntitySetName}({contentBlockId})/{ecsm_content_blockField.ecsm_content_file}");
      var response = await this.queryClient.Get<Dictionary<string, object>>(new EntityUrlQuery(url)).ConfigureAwait(false);

      var base64Object = response!["value"];
      return base64Object.ToString()!;
    }

    private async Task<List<FormElementDTO>> GetCatalogueFormElements(Guid catalogueId)
    {
      var formElementResponse = await this.queryClient.Get<ecsm_catalogue_item_form_element>(
             ecsm_catalogue_item_form_elementField.EntitySetName
                    .Query()
                    .OrderBy(new OrderBy(ecsm_catalogue_item_form_elementField.ecsm_order, "asc"))
                           .Where([ecsm_catalogue_item_form_elementField.ecsm_catalogue_item_Lookup.Equal(catalogueId)])
                                  .Build()
                                         ).ConfigureAwait(false);

      var formElements = formElementResponse.Entities.Select(e =>
      {
        var dto = new FormElementDTO
        {
          FormElementId = (Guid)e.ecsm_catalogue_item_form_elementId!,
          Order = (int)e.ecsm_order!,
          Label = e.ecsm_Name ?? "",
          ElementType = (int)e.ecsm_form_element_type!,
          DataType = e.ecsm_variable_data_type,
          ChoiceBase = e.ecsm_Choices ?? "",
          MapToDataverse = e.ecsm_map_to_dataverse_column ?? false,
          ColumnName = e.ecsm_map_to_dataverse_column_name ?? "",
          Tooltip = e.ecsm_description ?? "",
          Required = e.ecsm_required ?? false,
        };

        dto.ParseChoices();

        return dto;
      }).ToList();

      var baseApiUrl = Configuration["DynamicsServiceEndpoint"];
      if (formElements.Any(c => c.MapToDataverse))
      {
        var dataverseElements = formElements.Where(c => c.MapToDataverse).ToList();

        foreach (var item in dataverseElements)
        {
          var url = new Uri($"{baseApiUrl}/EntityDefinitions(LogicalName='{IncidentField.LogicalName}')?$select=LogicalName&$expand=Attributes($filter=LogicalName eq '{item.ColumnName}') ");
          var response = await this.queryClient.Get<EntityMetadata>(
                     new EntityUrlQuery(url)
                          ).ConfigureAwait(false);

          if (response!.Attributes.Any())
          {
            var attributeInfo = response!.Attributes.FirstOrDefault();

            if (attributeInfo!.AttributeType == "Picklist")
            {
              var choiceUrl = new Uri($"{baseApiUrl}EntityDefinitions(LogicalName='{IncidentField.LogicalName}')/Attributes(LogicalName='{item.ColumnName}')/Microsoft.Dynamics.CRM.PicklistAttributeMetadata?$select=LogicalName&$expand=OptionSet,GlobalOptionSet");

              var choiceResponse = await this.queryClient.Get<OptionSetMetadata>(
                 new EntityUrlQuery(choiceUrl)
                      ).ConfigureAwait(false);

              OptionSetMetadataDTO optionSetDto = new()
              {
                Name = choiceResponse.Name,
                MetadataId = choiceResponse.MetadataId,
                Options = choiceResponse?.OptionSet?.Options?.Count > 0
                  ? choiceResponse.OptionSet.Options.Select(o => new OptionDTO
                  {
                    Label = o.Label.UserLocalizedLabel.Label,
                    Value = o.Value,
                  }).ToList()
                  : choiceResponse?.GlobalOptionSet?.Options?.Count > 0
                    ? choiceResponse.GlobalOptionSet.Options.Select(o => new OptionDTO
                    {
                      Label = o.Label.UserLocalizedLabel.Label,
                      Value = o.Value,
                    }).ToList()
                    : new List<OptionDTO>()
              };

              attributeInfo.OptionSetMetadata = optionSetDto;
            }

            // Handle lookup items
            if (attributeInfo!.AttributeType == "Lookup")
            {
              var targetEntity = attributeInfo.Targets.FirstOrDefault();

              var entityUrl = new Uri($"{baseApiUrl}/EntityDefinitions(LogicalName='{targetEntity}')?$select=LogicalName,LogicalCollectionName,PrimaryNameAttribute,PrimaryIdAttribute");
              var entityResponse = await this.queryClient.Get<EntityMetadata>(
                         new EntityUrlQuery(entityUrl)
                              ).ConfigureAwait(false);

              var entityInfo = entityResponse;
              item.ColumnPluralName = entityInfo!.LogicalCollectionName;
              var streamResponse = this.queryClient.Stream<Dictionary<string, object>>(
                new EntityCollectionQuery(
                  entityInfo!.LogicalCollectionName,
                  columnSet: new ColumnSet(new[] { entityInfo.PrimaryNameAttribute }),
                  filterSet: new FilterSet(new Equals("statecode", 0))
                  ));

              var entityList = new List<Dictionary<string, object>>();

              await foreach (var entityItem in streamResponse)
              {
                entityList.Add(entityItem);
              }


              item.LookupItems.AddRange(entityList.Select(c => new LookupItem
              {
                DisplayName = c.FirstOrDefault(c => c.Key == entityInfo.PrimaryNameAttribute).Value?.ToString()!,
                LookupId = Guid.Parse(c.FirstOrDefault(c => c.Key == entityInfo.PrimaryIdAttribute).Value.ToString()!)!
              }));

              item.LookupItems = item.LookupItems.Where(c => c.DisplayName != null).ToList();
            }
            item.DataverseAttrubute = attributeInfo!;
          }
        }
      }

      return formElements;
    }

    private async Task<List<ContentBlockDTO>> GetContentBlocks(Guid catalogueId)
    {
      var resposne = await this.queryClient.Get<ecsm_content_block>(
                                   ecsm_content_blockField.EntitySetName
                          .Query()
                          .OrderBy(new OrderBy(ecsm_content_blockField.ecsm_Order, "asc "))
                          .Select([
                                   ecsm_content_blockField.ecsm_content_blockId,
                                   ecsm_content_blockField.ecsm_CatalogueItem_Lookup,
                                   ecsm_content_blockField.ecsm_ecsm_content_block_type,
                                   ecsm_content_blockField.ecsm_Name,
                                   ecsm_content_blockField.ecsm_ContentText,
                                   ecsm_content_blockField.ecsm_content_file,
                                   ecsm_content_blockField.ecsm_content_file_Name,
                                   ecsm_content_blockField.ecsm_Order
                            ]).Where([
                                    ecsm_content_blockField.ecsm_CatalogueItem_Lookup.Equal(catalogueId)
                            ]).Build()
                            ).ConfigureAwait(false);

      var result = resposne.Entities.Select(e => new ContentBlockDTO
      {
        ContentBlockId = (Guid)e.ecsm_content_blockId!,
        CatalogueItemId = (Guid)e.ecsm_CatalogueItem!,
        ContentType = (int)e.ecsm_ecsm_content_block_type!,
        Name = e.ecsm_Name ?? "",
        ContentText = e.ecsm_ContentText ?? "",
        ContentFile = e.ecsm_content_file,
        FileName = e.ecsm_content_file_Name ?? "",
        Order = (int)e.ecsm_Order!
      }).ToList();

      return result;
    }
  }
}
