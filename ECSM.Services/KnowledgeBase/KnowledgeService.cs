using EC.DynamicsClient;

using ECSM.Models.DTO;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.Dynamics;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OneOf.Types;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ECSM.Services
{
  public class KnowledgeService(IDynamicsQueryClient queryClient, IConfiguration Configuration) : IKnowledgeService
  {
    readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();
    readonly IConfiguration Configuration = Configuration.ThrowIfNull();

    public async Task<KnowledgeItemDTO[]> GetKnowledgeItems(string searchText = null, bool orderby = false)
    {
      if (orderby)
      {
        var response = await queryClient
       .Get<KnowledgeArticle>(KnowledgeArticleField.LogicalCollectionName
       .Query()
       .Select([
           KnowledgeArticleField.knowledgearticleId,
                    KnowledgeArticleField.Title,
                    KnowledgeArticleField.Description,
                    KnowledgeArticleField.StateCode,
                    KnowledgeArticleField.ArticlePublicNumber,
                    KnowledgeArticleField.ecsm_faq
         ])
       .ExpandOn(
            new Expand(ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle,
             new ColumnSet
             ([
                 ecsm_service_catalogueField.ecsm_name,
             ])))
       .OrderBy(new OrderBy(KnowledgeArticleField.Title, "asc"))
       .OrderBy(new OrderBy(KnowledgeArticleField.Description, "asc"))
       .Where([ KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published),
                KnowledgeArticleField.ecsm_faq.Equal(false),
                      new Group(Join.or, [
                          KnowledgeArticleField.Title.ToLower().Contains2(searchText?.ToLower()),
                          KnowledgeArticleField.Description.ToLower().Contains2(searchText?.ToLower())
                        ]),])
       .Build()).ConfigureAwait(false);

        if (response is null or { Entities: null or { Length: <= 0 } })
        {
          return [];
        }

        return response.Entities
            .Select(e => new KnowledgeItemDTO
            {
              KnowledgeId = e.knowledgearticleId.Value,
              Title = e.Title ?? "",
              Description = e.Description ?? "",
              Status = e.StateCode.Value,
              PublicNumber = e.ArticlePublicNumber ?? "",
              IsFAQ = e.ecsm_faq,
              ServiceCatalogue = JsonConvert.DeserializeObject<List<ServiceCatalogueDTO>>(e["ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle"]?.ToString())
            })
            .ToArray();
      }
      else
      {
        var response = await queryClient
       .Get<KnowledgeArticle>(KnowledgeArticleField.LogicalCollectionName
       .Query()
       .Select([
            KnowledgeArticleField.knowledgearticleId,
                    KnowledgeArticleField.Title,
                    KnowledgeArticleField.Description,
                    KnowledgeArticleField.StateCode,
                    KnowledgeArticleField.ArticlePublicNumber,
                    KnowledgeArticleField.ecsm_faq
                 ])
               .ExpandOn(
                    new Expand(
                        ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle,
                     new ColumnSet
                     ([
                         ecsm_service_catalogueField.ecsm_name,
                     ])))
               .OrderBy(new OrderBy(KnowledgeArticleField.Title, "desc"))
               .OrderBy(new OrderBy(KnowledgeArticleField.Description, "desc"))
               .Where([ KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published),
                KnowledgeArticleField.ecsm_faq.Equal(false),
                      new Group(Join.or, [
                          KnowledgeArticleField.Title.ToLower().Contains2(searchText?.ToLower()),
                          KnowledgeArticleField.Description.ToLower().Contains2(searchText?.ToLower())
                        ]),])
       .ExpandOn(
            new Expand(
                ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle,
             new ColumnSet
             ([
                 ecsm_service_catalogueField.ecsm_name,
             ])))
       .OrderBy(new OrderBy(KnowledgeArticleField.Title, "desc"))
       .OrderBy(new OrderBy(KnowledgeArticleField.Description, "desc"))
       .Where([ KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published),
                KnowledgeArticleField.ecsm_faq.Equal(false),
                      new Group(Join.or, [
                          KnowledgeArticleField.Title.ToLower().Contains2(searchText?.ToLower()),
                          KnowledgeArticleField.Description.ToLower().Contains2(searchText?.ToLower())
                        ]),])
       .Build()).ConfigureAwait(false);

        if (response is null or { Entities: null or { Length: <= 0 } })
        {
          return [];
        }

                return response.Entities
                    .Select(e => new KnowledgeItemDTO
                    {
                        KnowledgeId = e.knowledgearticleId.Value,
                        Title = e.Title ?? "",
                        Description = e.Description ?? "",
                        Status = e.StateCode.Value,
                        PublicNumber = e.ArticlePublicNumber ?? "",
                        IsFAQ = e.ecsm_faq,
                        ServiceCatalogue = JsonConvert.DeserializeObject<List<ServiceCatalogueDTO>>(e["ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle"]?.ToString())
                    })
                    .ToArray();
            }
        }

    public async Task<KnowledgeItemDTO[]> GetKnowledgeItemsTop3Popular()
    {
      var response = await queryClient
          .Get<KnowledgeArticle>(KnowledgeArticleField.LogicalCollectionName
          .Query()
          .Select([
              KnowledgeArticleField.knowledgearticleId,
                    KnowledgeArticleField.Title,
                    KnowledgeArticleField.Description,
                    KnowledgeArticleField.KnowledgeArticleViews,
                    KnowledgeArticleField.CreatedOn,
                    KnowledgeArticleField.StateCode,
                    KnowledgeArticleField.ArticlePublicNumber,
                    KnowledgeArticleField.ecsm_faq
          ])
          .Top(10)
          .Where([KnowledgeArticleField.ecsm_faq.Equal(false),
                    KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published)
          ])
          .OrderBy(new OrderBy(KnowledgeArticleField.KnowledgeArticleViews, "asc"))
          .Build()).ConfigureAwait(false);

      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }

      return response.Entities
          .Select(e => new KnowledgeItemDTO
          {
            KnowledgeId = (Guid)e.knowledgearticleId.Value,
            Title = e.Title ?? "",
            Description = e.Description ?? "",
            Views = e.KnowledgeArticleViews.Value,
            CreatedOn = e.CreatedOn.Value,
            CreatedOnFormatted = e.CreatedOn.Value!.ToString("MMM dd yyyy"),
            Status = e.StateCode.Value,
            PublicNumber = e.ArticlePublicNumber ?? ""
          })
          .OrderByDescending(e => e.Views)
          .ToArray();
    }

    public async Task<KnowledgeItemDTO[]> GetKnowledgeItemsTop5Latest(string searchText = null)
    {
      var response = await queryClient
          .Get<KnowledgeArticle>(KnowledgeArticleField.LogicalCollectionName
          .Query()
          .Where
              ([
                  new Group(Join.or, [
                          KnowledgeArticleField.Title.ToLower().Contains2(searchText?.ToLower()),
                          KnowledgeArticleField.Description.ToLower().Contains2(searchText?.ToLower())
                        ]),
                        KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published)
              ])
              .ExpandOn(
               new Expand(
                   ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle,
                new ColumnSet
                ([
                    ecsm_service_catalogueField.ecsm_name,
                ])))
          .Select([
              KnowledgeArticleField.knowledgearticleId,
                    KnowledgeArticleField.Title,
                    KnowledgeArticleField.Description,
                    KnowledgeArticleField.KnowledgeArticleViews,
                    KnowledgeArticleField.CreatedOn,
                    KnowledgeArticleField.StateCode,
                    KnowledgeArticleField.ArticlePublicNumber,
                    KnowledgeArticleField.ecsm_faq,
                ])
                .Where([KnowledgeArticleField.ecsm_faq.Equal(false),
                    KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published)
          ])
          .Top(5)
          .OrderBy(new OrderBy(KnowledgeArticleField.CreatedOn, "desc"))
          .Build()).ConfigureAwait(false);

      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }

            return response.Entities
                .Select(e => new KnowledgeItemDTO
                {
                    KnowledgeId = (Guid)e.knowledgearticleId.Value,
                    Title = e.Title ?? "",
                    Description = e.Description ?? "",
                    Views = e.KnowledgeArticleViews.Value,
                    CreatedOn = e.CreatedOn.Value,
                    CreatedOnFormatted = e.CreatedOn.Value!.ToString("MMM dd yyyy"),
                    Status = e.StateCode.Value,
                    PublicNumber = e.ArticlePublicNumber ?? "",
                    IsFAQ = e.ecsm_faq,
                    ServiceCatalogue = JsonConvert.DeserializeObject<List<ServiceCatalogueDTO>>(e["ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle"]?.ToString())
                })
                .ToArray();
        }

    public async Task<KnowledgeItemDTO[]> GetFaqItemsTop5Latest(string searchText = null)
    {
      var response = await queryClient
      .Get<KnowledgeArticle>(KnowledgeArticleField.LogicalCollectionName
      .Query()
      .Where
      ([
        new Group(Join.or, [
          KnowledgeArticleField.Title.ToLower().Contains2(searchText?.ToLower()),
          KnowledgeArticleField.Description.ToLower().Contains2(searchText?.ToLower())
        ]),
        KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published)
      ])
      .ExpandOn(
      new Expand(ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle,
      new ColumnSet
      ([
          ecsm_service_catalogueField.ecsm_name,
      ])))
      .Select([
        KnowledgeArticleField.knowledgearticleId,
          KnowledgeArticleField.Title,
          KnowledgeArticleField.Description,
          KnowledgeArticleField.KnowledgeArticleViews,
          KnowledgeArticleField.CreatedOn,
          KnowledgeArticleField.StateCode,
          KnowledgeArticleField.ArticlePublicNumber,
          KnowledgeArticleField.ecsm_faq,
          KnowledgeArticleField.Content
      ])
      .Where([KnowledgeArticleField.ecsm_faq.Equal(true),
       KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published)
      ])
      .Top(5)
      .OrderBy(new OrderBy(KnowledgeArticleField.CreatedOn, "desc"))
      .Build()).ConfigureAwait(false);

      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }

      return response.Entities
          .Select(e => new KnowledgeItemDTO
          {
            KnowledgeId = (Guid)e.knowledgearticleId.Value,
            Title = e.Title ?? "",
            Description = e.Description ?? "",
            Views = e.KnowledgeArticleViews.Value,
            CreatedOn = e.CreatedOn.Value,
            CreatedOnFormatted = e.CreatedOn.Value!.ToString("MMM dd yyyy"),
            Status = e.StateCode.Value,
            PublicNumber = e.ArticlePublicNumber ?? "",
            IsFAQ = e.ecsm_faq,
            Content = e.Content ?? "",
            ServiceCatalogue = JsonConvert.DeserializeObject<List<ServiceCatalogueDTO>>(e["ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle"]?.ToString())
          })
          .ToArray();
    }

    public async Task<KnowledgeItemDTO[]> GetKnowledgeItemsTop3Rating()
    {
      var response = await queryClient
          .Get<KnowledgeArticle>(KnowledgeArticleField.LogicalCollectionName
          .Query()
          .Select([
                  KnowledgeArticleField.knowledgearticleId,
                        KnowledgeArticleField.Title,
                        KnowledgeArticleField.Description,
                        KnowledgeArticleField.KnowledgeArticleViews,
                        KnowledgeArticleField.CreatedOn,
                        KnowledgeArticleField.Rating,
                        KnowledgeArticleField.StateCode,
                        KnowledgeArticleField.ArticlePublicNumber
              ])
          .Top(3)
          .Where([KnowledgeArticleField.ecsm_faq.Equal(false),
                    KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published)
          ])
          .OrderBy(new OrderBy(KnowledgeArticleField.Rating, "desc"))
          .Build()).ConfigureAwait(false);

      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }

      return response.Entities
          .Select(e => new KnowledgeItemDTO
          {
            KnowledgeId = (Guid)e.knowledgearticleId.Value,
            Title = e.Title ?? "",
            Description = e.Description ?? "",
            Views = e.KnowledgeArticleViews.Value,
            CreatedOn = e.CreatedOn.Value,
            CreatedOnFormatted = e.CreatedOn.Value!.ToString("MMM dd yyyy"),
            Rating = e.Rating.Value,
            PublicNumber = e.ArticlePublicNumber ?? ""
          })
          .OrderByDescending(e => e.Rating)
          .ToArray();
    }

    public async Task<KnowledgeItemDTO> GetKnowledgeItemArticle(string articlePublicNumber)
    {
      var response = await queryClient
          .Get<KnowledgeArticle>(KnowledgeArticleField.LogicalCollectionName
          .Query()
          .Select([
              KnowledgeArticleField.knowledgearticleId,
                    KnowledgeArticleField.Title,
                    KnowledgeArticleField.Description,
                    KnowledgeArticleField.KnowledgeArticleViews,
                    KnowledgeArticleField.CreatedOn,
                    KnowledgeArticleField.Rating,
                    KnowledgeArticleField.StateCode,
                    KnowledgeArticleField.ArticlePublicNumber,
                    KnowledgeArticleField.Content,
                    KnowledgeArticleField.Keywords,
                    KnowledgeArticleManyToMany.knowledgearticle_category,
                    KnowledgeArticleManyToMany.msdyn_msdyn_kbattachment_knowledgearticle
          ])
          .Where([
              KnowledgeArticleField.ArticlePublicNumber.Equal(articlePublicNumber),
                    KnowledgeArticleField.StateCode.Equal(knowledgearticle_expirationstate.Published)
          ])
          .Top(3)
          .ExpandOn(new Expand(KnowledgeArticleManyToMany.msdyn_msdyn_kbattachment_knowledgearticle,
              new ColumnSet
                  ([
                      msdyn_kbattachmentField.msdyn_filename,
                            msdyn_kbattachmentField.msdyn_kbattachmentId
                  ])
          ))
          .ExpandOn(
              new Expand(
                  ecsm_service_catalogue_itemManyToMany.ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle,
              new ColumnSet
                  ([
                      ecsm_service_catalogueField.ecsm_name
                  ])
          ))
          .Build()).ConfigureAwait(false);

      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return null;
      }

      var result = response.Entities
          .Select(e => new KnowledgeItemDTO
          {
            KnowledgeId = (Guid)e.knowledgearticleId.Value,
            Title = e.Title ?? "",
            Description = e.Description ?? "",
            Views = e.KnowledgeArticleViews.Value!,
            CreatedOn = e.CreatedOn.Value!,
            CreatedOnFormatted = e.CreatedOn.Value!.ToString("MMM dd yyyy"),
            Rating = e.Rating.Value!,
            Status = e.StateCode.Value!,
            PublicNumber = e.ArticlePublicNumber ?? "",
            Content = e.Content ?? "",
            Keywords = e.Keywords ?? "",
            ServiceCatalogue = JsonConvert.DeserializeObject<List<ServiceCatalogueDTO>>(e["ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle"]?.ToString() ?? ""),
            Attachment = JsonConvert.DeserializeObject<List<AttachmentDTO>>(e["msdyn_msdyn_kbattachment_knowledgearticle"]?.ToString() ?? "")
          });
      return result.FirstOrDefault();
    }

    public async Task<string> GetAttachmentFileBase64(string attachment_name)
    {
      var url = new Uri($"{Configuration["DynamicsServiceEndpoint"]}{msdyn_kbattachmentField.EntitySetName}({attachment_name})/msdyn_fileattachment");
      var response = await this.queryClient.Get<Dictionary<string, object>>(
       new EntityUrlQuery(url)).ConfigureAwait(false);

      var base64Object = response!["value"];
      return base64Object.ToString()!;
    }

    public async Task<KnowledgeItemDTO[]> GeFAQItems(string searchText)
    {
      var response = await queryClient
          .Get<KnowledgeArticle>(KnowledgeArticleField.EntitySetName
          .Query()
          .Where([
               KnowledgeArticleField.ecsm_faq.Equal(true),
                     new Group(Join.or, [
                         KnowledgeArticleField.Title.ToLower().Contains2(searchText?.ToLower()),
                         KnowledgeArticleField.Description.ToLower().Contains2(searchText?.ToLower())
                        ])
          ])
          .Select([
              KnowledgeArticleField.knowledgearticleId,
                    KnowledgeArticleField.Title,
                    KnowledgeArticleField.Description,
                    KnowledgeArticleField.Content
               ])
          .Build()).ConfigureAwait(false);

      if (response is null or { Entities: null or { Length: <= 0 } })
      {
        return [];
      }

      return response.Entities
       .Select(e => new KnowledgeItemDTO
       {
         KnowledgeId = e.knowledgearticleId.Value,
         Title = e.Title ?? "",
         Description = e.Description ?? "",
         Content = e.Content ?? "",

       }).ToArray();
    }
  }

}

