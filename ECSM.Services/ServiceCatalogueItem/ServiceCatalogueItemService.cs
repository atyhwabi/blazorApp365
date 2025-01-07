using EC.DynamicsClient;
using ECSM.Models.DTO;
using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.PinnedServices;
using ECSM.Models.DTO.ServiceCatalogueItem;
using ECSM.Models.Dynamics;
using ECSM.Services.CatalogueItem;
using ECSM.Services.ServiceCatalogue;
using Newtonsoft.Json;
using System.Diagnostics;


namespace ECSM.Services.ServiceCatalogueItem
{
  public class ServiceCatalogueItemService(IDynamicsQueryClient queryClient, ICatalogueItemService catalogueItemService, IServiceCatalogueService serviceCatalogueService) : IServiceCatalogueItemService
  {
    readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();

    readonly ICatalogueItemService catalogueItemService = catalogueItemService.ThrowIfNull();

    readonly IServiceCatalogueService serviceCatalogueService = serviceCatalogueService.ThrowIfNull();

    public async Task<ServiceCatalogueItemDTO> GetServiceCatalogueItemById(Guid serviceCatalogueItemId)
    {
      var serviceCatalogueItemDTO = await this.GetServiceCatalogueItemDTOById(serviceCatalogueItemId).ConfigureAwait(false);
      if (serviceCatalogueItemDTO.CatalogueItemId != null)
      {
        serviceCatalogueItemDTO.CatalogueItemDTO = await catalogueItemService.GetCatalogueItemWithContentBlocksById((Guid)serviceCatalogueItemDTO.CatalogueItemId!).ConfigureAwait(false);
      }
      return serviceCatalogueItemDTO!;
    }

    public async Task<ServiceCatalogueItemDTO[]> GetPinnedServices(List<UserRoleDTO> userRoles)
    {
      var serviceCatalogues = await this.serviceCatalogueService.GetServiceCatalogues(userRoles).ConfigureAwait(false);

      var serviceCatalogueIds = serviceCatalogues.Select(sc => sc.ServiceCatalogueID.ToString()).ToList();

      var response = await this.queryClient.Get<ecsm_service_catalogue_item>(
       ecsm_service_catalogue_itemField.EntitySetName
       .Query()
       .Select([
          ecsm_service_catalogue_itemField.ecsm_service_catalogue_itemId,
          ecsm_service_catalogue_itemField.ecsm_Name,
          ecsm_service_catalogue_itemField.ecsm_icon_code,
          ecsm_service_catalogue_itemField.ecsm_TileLayout,
          ecsm_service_catalogue_itemField.ecsm_short_description,
          ecsm_service_catalogue_itemField.ecsm_category.ToLookup(),
          ecsm_service_catalogue_itemField.ecsm_service_catalogue.ToLookup(),
       ])
       .ExpandOn(new Expand(
          ecsm_service_catalogue_itemOneToMany.ecsm_pinnedservice_service_ecsm_service_catalogue_item,
             new ColumnSet([
                ecsm_PinnedServiceField.ecsm_Name,
                ecsm_PinnedServiceField.ecsm_Order,
                ecsm_PinnedServiceField.ecsm_PinnedServiceId
             ])
          ))
       .ExpandOn(new Expand(
          ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role,
            new ColumnSet(
              ecsm_portal_roleField.ecsm_portal_roleId
            ))
       )
       .ExpandOn(new Expand(
          ecsm_service_catalogue_itemManyToOne.ecsm_service_catalogue_item_category_ecsm_cate,
             new ColumnSet([
                ecsm_categoryField.ecsm_categoryId,
                ecsm_categoryField.ecsm_Name,
                ecsm_categoryField.ecsm_parent_category.ToLookup(),
                ecsm_categoryField.ecsm_service_catalogue_id.ToLookup(),
            ])
        ))
       .Where([ ecsm_service_catalogue_itemField.ecsm_service_catalogue.In([.. serviceCatalogueIds!]),
           ecsm_service_catalogueField.statecode.Equal(ecsm_service_catalogue_statecode.Active)
         ]).Build()
       ).ConfigureAwait(false);
      Debug.WriteLine("");
      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }

      var results = response.Entities.Select(e => new ServiceCatalogueItemDTO
      {
        ServiceCatalogueItemId = (Guid)e.ecsm_service_catalogue_itemId!,
        CategoryId = (Guid)e.ecsm_category!,
        Categories = JsonConvert.DeserializeObject<CategoryDTO>(e["ecsm_category"]?.ToString()) ?? new(),
        Name = e.ecsm_Name ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        Description = e.ecsm_short_description ?? "",
        TileLayout = e.ecsm_TileLayout ?? 0,
        PortalRoles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role"]?.ToString()),
        PinnedServices = JsonConvert.DeserializeObject<List<PinnedServiceDTO>>(e["ecsm_pinnedservice_service_ecsm_service_catalogue_item"]?.ToString()!) ?? new()
      }).ToArray();
      var filteredResult = results.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID))).ToArray();
      return filteredResult;
    }

    public async Task<List<ServiceCatalogueItemDTO>> GetFilteredServiceItemCatalogues(List<UserRoleDTO> userRoles)
    {
      var response = await this.queryClient.Get<ecsm_service_catalogue_item>(
       ecsm_service_catalogue_itemField.EntitySetName
       .Query()
       .Select([
          ecsm_service_catalogue_itemField.ecsm_service_catalogue_itemId,
                ecsm_service_catalogue_itemField.ecsm_Name,
                ecsm_service_catalogue_itemField.ecsm_icon_code
        ])
        .Where([
          ecsm_service_catalogueField.statecode.Equal(ecsm_service_catalogue_statecode.Active)
        ]).Build()
).ConfigureAwait(false);
      var results = response.Entities.Select(e => new ServiceCatalogueItemDTO
      {
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue_itemId!,
        Name = e.ecsm_Name ?? "",
        IconCode = e.ecsm_icon_code ?? "",
      }).ToList();
      var filteredResult = results.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID))).ToList();
      return filteredResult;
    }

    public async Task<ServiceCatalogueItemDTO> GetServiceCatalogueItemWithCatalogueItemById(Guid serviceCatalogueItemID)
    {
      var serviceCatalogueItem = await this.GetServiceCatalogueItemDTOById(serviceCatalogueItemID).ConfigureAwait(false);

      serviceCatalogueItem.ServiceCatalogue = await serviceCatalogueService.GetServiceCatalogueById(serviceCatalogueItem.ServiceCatalogueId).ConfigureAwait(false);

      serviceCatalogueItem.CatalogueItemDTO = await catalogueItemService.GetCatalogueItemWithFormElementsById((Guid)serviceCatalogueItem.CatalogueItemId!).ConfigureAwait(false);
      return serviceCatalogueItem;
    }

    private async Task<ServiceCatalogueItemDTO> GetServiceCatalogueItemDTOById(Guid serviceCatalogueItemId)
    {
      var response = await this.queryClient.Get<ecsm_service_catalogue_item>(
           ecsm_service_catalogue_itemField.EntitySetName
                    .Query()
                    .ExpandOn(new Expand(
                      ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle,
                      new ColumnSet([
                        KnowledgeArticleField.PrimaryId,
                        KnowledgeArticleField.ArticlePublicNumber,
                        KnowledgeArticleField.Title,
                        KnowledgeArticleField.ecsm_faq,
                        KnowledgeArticleField.Content
                        ])
                    ))
                    .ExpandOn(new Expand(
                      ecsm_service_catalogue_itemManyToOne.ecsm_service_catalogue_item_CatalogueItem_ecsm
                    ))
                    .Where([ecsm_service_catalogue_itemField.ecsm_service_catalogue_itemId.Equal(serviceCatalogueItemId)])
                    .Build()
             ).ConfigureAwait(false);

      var result = response!.Entities!.Select(e => new ServiceCatalogueItemDTO
      {
        ServiceCatalogueItemId = (Guid)e.ecsm_service_catalogue_itemId!,
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue!,
        CategoryId = (Guid)e.ecsm_category!,
        Name = e.ecsm_Name ?? "",
        Description = e.ecsm_short_description ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        CatalogueItemId = e.ecsm_CatalogueItem,
        KnowledgeArticles = JsonConvert.DeserializeObject<List<KnowledgeItemDTO>>(e["ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle"]?.ToString()!) ?? new(),
      }).FirstOrDefault();

      return result!;
    }

    public async Task<List<ServiceCatalogueItemDTO>> GetServiceCatalogueItemRoles(List<UserRoleDTO> userRoles, List<string> catagoryIds, string searchValues)
    {
      var response = await this.queryClient.Get<ecsm_service_catalogue_item>(
           ecsm_service_catalogue_itemField.EntitySetName
                    .Query()
                    .ExpandOn(new Expand(
                ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role,
                new ColumnSet(
                ecsm_portal_roleField.ecsm_portal_roleId
             )
                ))
                 .Where([ ecsm_service_catalogue_itemField.ecsm_category.In([.. catagoryIds!]),
                   new Group(Join.or, [
                      ecsm_service_catalogue_itemField.ecsm_Name.ToLower().Contains2(searchValues?.ToLower()),
                      ecsm_service_catalogue_itemField.ecsm_short_description.ToLower().Contains2(searchValues?.ToLower())
                      ])
             ])
              .Build()
             ).ConfigureAwait(false);

      var result = response!.Entities!.Select(e => new ServiceCatalogueItemDTO
      {
        ServiceCatalogueItemId = (Guid)e.ecsm_service_catalogue_itemId,
        ServiceCatalogueId = (Guid)e.ecsm_service_catalogue!,
        CategoryId = (Guid)e.ecsm_category!,
        Name = e.ecsm_Name ?? "",
        Description = e.ecsm_short_description ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        CatalogueItemId = e.ecsm_CatalogueItem,
        PortalRoles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role"]?.ToString()!) ?? new()

      });

      var filteredResult = result.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID)) && r.CatalogueItemId != null).ToList();
      return filteredResult;
    }
  }
}
