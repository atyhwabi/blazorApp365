using EC.DynamicsClient;

using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSM.Models.Dynamics;
using Newtonsoft.Json;
using ECSM.Services.Category;
using ECSM.Models.DTO.ServiceCatalogueItem;

namespace ECSM.Services.ServiceCatalogue
{
  public class ServiceCatalogueService(IDynamicsQueryClient queryClient,ICategoryService categoryService) : IServiceCatalogueService
  {

    readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();

    readonly ICategoryService categoryService = categoryService.ThrowIfNull();

    public async Task<List<ServiceCatalogueDTO>> GetServiceCatalogues(List<UserRoleDTO> userRoles)
    {
      var results = await this.GetFilteredServiceCatalogues(userRoles).ConfigureAwait(false);
      return results;
    }

    public async Task<List<ServiceCatalogueDTO>> GetServiceCataloguesWithCategories(List<UserRoleDTO> userRoles)
    {
      var serviceCatalogues = await this.GetFilteredServiceCatalogues(userRoles).ConfigureAwait(false);
      var serviceCatalogueIds = serviceCatalogues.Select(sc => sc.ServiceCatalogueID.ToString()).ToList();
      var filteredCategories = await categoryService.GetCategoriesByServicesIds(serviceCatalogueIds, userRoles).ConfigureAwait(false);

      foreach (var item in serviceCatalogues)
      {
        item.Categories = filteredCategories.Where(c => c.ServiceCatalogueId == item.ServiceCatalogueID).ToList();
      }

      return serviceCatalogues;
    }

    public async Task<ServiceCatalogueDTO> GetServiceCatalogueById(Guid id)
    {
      var response = await this.queryClient.Get<ecsm_service_catalogue>(
                   ecsm_service_catalogueField.EntitySetName
                   .Query()
                   .Select([
                     ecsm_service_catalogueField.ecsm_service_catalogueId,
                          ecsm_service_catalogueField.ecsm_name,
                          ecsm_service_catalogueField.ecsm_decription,
                          ecsm_service_catalogueField.ecsm_icon_code
                    ])
                   .Where([
                       ecsm_service_catalogueField.ecsm_service_catalogueId.Equal(id)
                     ]).Build()
                   ).ConfigureAwait(false);

      var result = response!.Entities!.Select(e => new ServiceCatalogueDTO
      {
        ServiceCatalogueID = (Guid)e.ecsm_service_catalogueId!,
        Name = e.ecsm_name ?? "",
        Description = e.ecsm_decription ?? "",
        IconCode = e.ecsm_icon_code ?? ""
      }).FirstOrDefault();

      return result;
    }

    public async Task<List<ServiceCatalogueDTO>> GetFilteredServiceCataloguesSearch(List<UserRoleDTO> userRoles, string searchValues)
    {
      var response = await this.queryClient.Get<ecsm_service_catalogue>(
       ecsm_service_catalogueField.EntitySetName
       .Query()
       .Select([
            ecsm_service_catalogueField.ecsm_service_catalogueId,
                  ecsm_service_catalogueField.ecsm_name,
                  ecsm_service_catalogueField.ecsm_decription,
                  ecsm_service_catalogueField.ecsm_icon_code
       ]).ExpandOn(new Expand(
         ecsm_service_catalogueManyToMany.ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue,

                       new ColumnSet(
                         ecsm_portal_roleField.ecsm_portal_roleId
                         )
                     )).Where([
                       ecsm_service_catalogueField.statecode.Equal(ecsm_service_catalogue_statecode.Active),

                  new Group(Join.or, [
                         ecsm_service_catalogueField.ecsm_name.ToLower().Contains2(searchValues.ToLower()),
                          ecsm_service_catalogueField.ecsm_decription.ToLower().Contains2(searchValues.ToLower()),

                        ])
                     ]).Build()
                   ).ConfigureAwait(false);

      var results = response.Entities.Select(e => new ServiceCatalogueDTO
      {
        ServiceCatalogueID = (Guid)e.ecsm_service_catalogueId!,
        Name = e.ecsm_name,
        Description = e.ecsm_decription,
        PortalRoles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue"]?.ToString())
      }).ToList();

      var filteredResult = results.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID))).ToList();
      return filteredResult;
    }

    private async Task<List<ServiceCatalogueDTO>> GetFilteredServiceCatalogues(List<UserRoleDTO> userRoles)
    {
      var response = await this.queryClient.Get<ecsm_service_catalogue>(
       ecsm_service_catalogueField.EntitySetName
       .Query()
       .Select([
          ecsm_service_catalogueField.ecsm_service_catalogueId,
          ecsm_service_catalogueField.ecsm_name,
          ecsm_service_catalogueField.ecsm_decription,
          ecsm_service_catalogueField.ecsm_Tile_layout,
          ecsm_service_catalogueField.ecsm_icon_code
             ]).ExpandOn(new Expand(
                   ecsm_service_catalogueManyToMany.ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue,
                 new ColumnSet(
                   ecsm_portal_roleField.ecsm_portal_roleId
                   ))).Where([ecsm_service_catalogueField.statecode.Equal(ecsm_service_catalogue_statecode.Active)
               ]).Build()
             ).ConfigureAwait(false);

      var results = response.Entities.Select(e => new ServiceCatalogueDTO
      {
        ServiceCatalogueID = (Guid)e.ecsm_service_catalogueId!,
        Name = e.ecsm_name ?? "",
        Description = e.ecsm_decription ?? "",
        IconCode = e.ecsm_icon_code ?? "",
        TileLayout = e.ecsm_Tile_layout ?? 0,
        PortalRoles = JsonConvert.DeserializeObject<List<UserRoleDTO>>(e["ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue"]?.ToString()!) ?? new()
      }).ToList();

      var filteredResult = results.Where(r => r.PortalRoles.Any(pr => userRoles.Any(ur => ur.RoleID == pr.RoleID))).ToList();
      return filteredResult;
    }

    public async Task<List<ServiceCatalogueItemDTO>> GetServiceCataloguesWithCategoriesCatalogueItems(List<UserRoleDTO> userRoles, string searchValue)
    {
      var serviceCatalogues = await this.GetFilteredServiceCatalogues(userRoles).ConfigureAwait(false);
      var serviceCatalogueIds = serviceCatalogues.Select(sc => sc.ServiceCatalogueID.ToString()).ToList();
      var filteredCategories = await categoryService.GetCategoriesByServicesIds(serviceCatalogueIds, userRoles).ConfigureAwait(false);

      foreach (var item in serviceCatalogues)
      {
        item.Categories = filteredCategories.Where(c => c.ServiceCatalogueId == item.ServiceCatalogueID).ToList();
      }
      var catagoryIds = filteredCategories.Select(c => c.CategoryID.ToString()).ToList();

      var serviceCatalogueItems = await GetServiceCatalogueItemRoles(userRoles, catagoryIds, searchValue).ConfigureAwait(false);
      return serviceCatalogueItems;
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
