namespace ECSM.Services.Category
{
  using EC.DynamicsClient;
  using ECSM.Models.DTO.Category;
  using ECSM.Models.DTO;
  using ECSM.Models.Dynamics;
  using ECSM.Models.DTO.ServiceCatalogueItem;
  using ECSM.Models.DTO.Announcement;
  using System.Net;
  using Microsoft.Extensions.Configuration;
  using File = Models.DTO.File;
  using Newtonsoft.Json;

  public class CategoryService(IDynamicsQueryClient queryClient, IConfiguration configuration) : ICategoryService
  {
    readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();
    readonly IConfiguration configuration = configuration.ThrowIfNull();

    public async Task<List<CategoryDTO>> GetCategoriesByServiceId(Guid serviceId, List<UserRoleDTO> userRoles)
    {
      var response = await this.queryClient.Get<ecsm_category>(
          ecsm_categoryField.EntitySetName
          .Query()
          .Select([
            ecsm_categoryField.ecsm_categoryId,
            ecsm_categoryField.ecsm_Name,
            ecsm_categoryField.ecsm_description,
            ecsm_categoryField.ecsm_icon_code,
            ecsm_categoryField.ecsm_tile_layout,
            ecsm_categoryField.ecsm_image_Name,
            ecsm_categoryField.ecsm_service_catalogue_id.ToLookup(),
            ecsm_categoryField.ecsm_parent_category.ToLookup()
                        ]).ExpandOn(new Expand(
                        ecsm_categoryManyToMany.ecsm_portal_role_ecsm_category_ecsm_category,
                        new ColumnSet(
                          ecsm_portal_roleField.ecsm_portal_roleId
                          ))
                        ).Where([
                          ecsm_categoryField.ecsm_service_catalogue_id.ToLookup().Equal(serviceId),
                    ecsm_categoryField.ecsm_available.Equal(true)
                        ]).Build()
                    ).ConfigureAwait(false);

      var result = response.Entities.Select(e => new CategoryDTO
      {
        CategoryID = (Guid)e.ecsm_categoryId!,
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue_id!,
        Name = e.ecsm_Name ?? "",
        Description = e.ecsm_description ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        ParentCategoryId = e.ecsm_parent_category,
        TileLayout = e.ecsm_tile_layout ?? 0,
        PortalRoles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_portal_role_ecsm_category_ecsm_category"]?.ToString()) ?? new List<UserRoleDTO>()
      }).ToList();

      var filteredResult = result.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID))).ToList();

      return filteredResult;
    }

    private async Task<string> GetContentBlockFileBase64Async(Guid? contentBlockId)
    {
      var url = new Uri($"{configuration["DynamicsServiceEndpoint"]}{ecsm_categoryField.EntitySetName}({contentBlockId})/{ecsm_categoryField.ecsm_image}");
      var response = await queryClient.Get<Dictionary<string, object>>(new EntityUrlQuery(url)).ConfigureAwait(false);

      return response?["value"].ToString() ?? string.Empty;
    }

    public async Task<CardImageDTO> PopulateSettingWithFileDataAsync(Guid? contentBlockId)
    {
      var fileDetails = await FetchFileDetailsAsync(contentBlockId).ConfigureAwait(false);

      var cardImageDto = new CardImageDTO
      {
        FileData = new File
        {
          Base64String = await GetContentBlockFileBase64Async(contentBlockId).ConfigureAwait(false),
          FileName = fileDetails.FirstOrDefault()?.FileName ?? string.Empty,
          MimeType = fileDetails.FirstOrDefault()?.MimeType ?? string.Empty
        }
      };

      return cardImageDto;
    }

    private async Task<List<FileData>> FetchFileDetailsAsync(Guid? contentBlockId)
    {
      var url = new Uri($"{configuration["DynamicsServiceEndpoint"]}{ecsm_categoryField.EntitySetName}({contentBlockId})?$filter={ecsm_categoryField.ecsm_image} ne null&$expand={ecsm_categoryField.LogicalName}_FileAttachments($select=createdon,mimetype,filesizeinbytes,filename,regardingfieldname)&$select={ecsm_categoryField.ecsm_image}");
      var response = await queryClient.Get<Dictionary<string, object>>(new EntityUrlQuery(url)).ConfigureAwait(false);

      var jsonString = response?["ecsm_category_FileAttachments"]?.ToString();
      if (string.IsNullOrEmpty(jsonString))
      {
        return [];
      }

      return JsonConvert.DeserializeObject<List<FileData>>(jsonString) ?? [];
    }

    public async Task<List<CategoryDTO>> GetCategoriesByServicesIds(List<string> serviceCatalogueIds, List<UserRoleDTO> userRoles)
    {
      var response = await this.queryClient.Get<ecsm_category>(
          ecsm_categoryField.EntitySetName
          .Query()
          .Select([
            ecsm_categoryField.ecsm_categoryId,
            ecsm_categoryField.ecsm_Name,
            ecsm_categoryField.ecsm_description,
            ecsm_categoryField.ecsm_icon_code,
            ecsm_categoryField.ecsm_service_catalogue_id.ToLookup(),
            ecsm_categoryField.ecsm_parent_category.ToLookup(),
            ecsm_categoryField.ecsm_tile_layout
            ]).ExpandOn(new Expand(
            ecsm_categoryManyToMany.ecsm_portal_role_ecsm_category_ecsm_category,
            new ColumnSet(
              ecsm_portal_roleField.ecsm_portal_roleId
              ))
            ).ExpandOn(new Expand(
              ecsm_categoryManyToMany.ecsm_announcement_ecsm_category_ecsm_category
              )).Where([
              ecsm_categoryField.ecsm_service_catalogue_id.In([.. serviceCatalogueIds!]),
                    ecsm_categoryField.ecsm_available.Equal(true)
            ]).Build()
        ).ConfigureAwait(false);

      var categories = response.Entities.Select(e => new CategoryDTO
      {
        CategoryID = (Guid)e.ecsm_categoryId!,
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue_id!,
        Name = e.ecsm_Name ?? "",
        Description = e.ecsm_description ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        TileLayout = e.ecsm_tile_layout ?? 0,
        ParentCategoryId = e.ecsm_parent_category,
        PortalRoles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_portal_role_ecsm_category_ecsm_category"]?.ToString()),
        Announcements = JsonConvert.DeserializeObject<List<AnnouncementDTO>>(e["ecsm_announcement_ecsm_category_ecsm_category"]?.ToString())
      }).ToList();



      var filteredCategories = categories.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID))).ToList();

      foreach (var item in filteredCategories)
      {
        item.ChildCategoryDTOs = filteredCategories.Where(c => c.ParentCategoryId == item.CategoryID).ToList();
      }

      var categoryIds = filteredCategories.Select(c => c.CategoryID.ToString()).ToList();

      var itemsResponse = await this.queryClient.Get<ecsm_service_catalogue_item>(
        ecsm_service_catalogue_itemField.EntitySetName
          .Query()
          .Select([
            ecsm_service_catalogue_itemField.ecsm_service_catalogue_itemId,
            ecsm_service_catalogue_itemField.ecsm_service_catalogue.ToLookup(),
            ecsm_service_catalogue_itemField.ecsm_category.ToLookup(),
            ecsm_service_catalogue_itemField.ecsm_Name,
            ecsm_service_catalogue_itemField.ecsm_short_description,
            ecsm_service_catalogue_itemField.ecsm_icon_code
                  ]).ExpandOn(new Expand(
                  ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role,
                  new ColumnSet(
                    ecsm_portal_roleField.ecsm_portal_roleId
                    ))
                  ).Where([
                    ecsm_service_catalogue_itemField.ecsm_category.In([.. categoryIds!])
                  ]).Build()
              ).ConfigureAwait(false);

      var serviceItems = itemsResponse.Entities.Select(e => new ServiceCatalogueItemDTO
      {
        ServiceCatalogueItemId = (Guid)e.ecsm_service_catalogue_itemId!,
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue!,
        CategoryId = (Guid)e.ecsm_category!,
        Name = e.ecsm_Name ?? "",
        Description = e.ecsm_short_description ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        PortalRoles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role"]?.ToString())
      }).ToList();

      var filteredServiceItems = serviceItems.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID))).ToList();


      foreach (var item in filteredCategories)
      {
        item.ServiceCatalogueItems = filteredServiceItems.Where(c => c.CategoryId == item.CategoryID).ToList();
      }
      return filteredCategories;
    }

    public async Task<CategoryDTO> GetCategorieById(string categoryId)
    {
      var response = await this.queryClient.Get<ecsm_category>(
          ecsm_categoryField.EntitySetName
          .Query()
          .Select([
              ecsm_categoryField.ecsm_categoryId,
                ecsm_categoryField.ecsm_Name,
                ecsm_categoryField.ecsm_description,
                ecsm_categoryField.ecsm_icon_code,
                ecsm_categoryField.ecsm_tile_layout,
                ecsm_categoryField.ecsm_service_catalogue_id.ToLookup(),
                ecsm_categoryField.ecsm_parent_category.ToLookup()
          ])
          .ExpandOn(new Expand(
              ecsm_categoryManyToMany.ecsm_announcement_ecsm_category_ecsm_category
          )).Where([
              ecsm_categoryField.ecsm_categoryId.Equal(categoryId),
                ecsm_categoryField.ecsm_available.Equal(true)
          ]).Build()
          ).ConfigureAwait(false);

      var category = response.Entities.Select(e => new CategoryDTO
      {
        CategoryID = (Guid)e.ecsm_categoryId!,
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue_id!,
        Name = e.ecsm_Name ?? "",
        Description = e.ecsm_description ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        TileLayout = e.ecsm_tile_layout ?? 0,
        ParentCategoryId = e.ecsm_parent_category == null ? Guid.Empty : (Guid)e.ecsm_parent_category,
        Announcements = JsonConvert.DeserializeObject<List<AnnouncementDTO>>(e["ecsm_announcement_ecsm_category_ecsm_category"]?.ToString())
      }).FirstOrDefault();

      var itemsResponse = await this.queryClient.Get<ecsm_service_catalogue_item>(
          ecsm_service_catalogue_itemField.EntitySetName
          .Query()
          .Select([
              ecsm_service_catalogue_itemField.ecsm_service_catalogue_itemId,
                ecsm_service_catalogue_itemField.ecsm_service_catalogue.ToLookup(),
                ecsm_service_catalogue_itemField.ecsm_category.ToLookup(),
                ecsm_service_catalogue_itemField.ecsm_Name,
                ecsm_service_catalogue_itemField.ecsm_short_description,
                ecsm_service_catalogue_itemField.ecsm_icon_code
          ]).Where([
              ecsm_service_catalogue_itemField.ecsm_category.ToLookup().Equal(categoryId)
          ]).Build()
          ).ConfigureAwait(false);

      var serviceItems = itemsResponse.Entities.Select(e => new ServiceCatalogueItemDTO
      {
        ServiceCatalogueItemId = (Guid)e.ecsm_service_catalogue_itemId!,
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue!,
        CategoryId = (Guid)e.ecsm_category!,
        Name = e.ecsm_Name ?? "",
        Description = e.ecsm_short_description ?? "",
        IconCode = e.ecsm_icon_code ?? ""
      }).ToList();

      if (serviceItems.Any())
        category.ServiceCatalogueItems = serviceItems.ToList();

      return category;
    }
  }
}
