namespace ECSM.Models.Dynamics;

/// <summary>Organizational knowledge for internal and external use.</summary>
public static partial class KnowledgeArticleManyToMany
{
	/// <summary>Entity1IntersectAttribute: knowledgearticleid, Entity1LogicalName: knowledgearticle, Entity1NavigationPropertyName: ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle, Entity2IntersectAttribute: ecsm_service_catalogue_itemid, Entity2LogicalName: ecsm_service_catalogue_item, Entity2NavigationPropertyName: ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle, IntersectEntityName: ecsm_service_catalogue_item_knowledgear, SchemaName: ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle = "ecsm_service_catalogue_item_KnowledgeArticle_KnowledgeArticle";

	/// <summary>Entity1IntersectAttribute: knowledgearticleid, Entity1LogicalName: knowledgearticle, Entity1NavigationPropertyName: knowledgearticle_category, Entity2IntersectAttribute: categoryid, Entity2LogicalName: category, Entity2NavigationPropertyName: knowledgearticle_category, IntersectEntityName: knowledgearticlescategories, SchemaName: knowledgearticle_category, SecurityTypes: None, IntroducedVersion: 8.1.0.0. </summary>
	public const string knowledgearticle_category = "knowledgearticle_category";

	/// <summary>Entity1IntersectAttribute: msdyn_customerassetid, Entity1LogicalName: msdyn_customerasset, Entity2IntersectAttribute: knowledgearticleid, Entity2LogicalName: knowledgearticle, IntersectEntityName: msdyn_msdyn_customerasset_knowledgearticl, SchemaName: msdyn_msdyn_customerasset_knowledgearticle, SecurityTypes: None, IntroducedVersion: 1.0.26.9. </summary>
	public const string msdyn_msdyn_customerasset_knowledgearticle = "msdyn_msdyn_customerasset_knowledgearticle";

	/// <summary>Entity1IntersectAttribute: msdyn_kbattachmentid, Entity1LogicalName: msdyn_kbattachment, Entity1NavigationPropertyName: msdyn_msdyn_kbattachment_knowledgearticle, Entity2IntersectAttribute: knowledgearticleid, Entity2LogicalName: knowledgearticle, Entity2NavigationPropertyName: msdyn_msdyn_kbattachment_knowledgearticle, IntersectEntityName: msdyn_msdyn_kbattachment_knowledgearticle, SchemaName: msdyn_msdyn_kbattachment_knowledgearticle, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string msdyn_msdyn_kbattachment_knowledgearticle = "msdyn_msdyn_kbattachment_knowledgearticle";

	/// <summary>Entity1IntersectAttribute: activityid, Entity1LogicalName: msdyn_ocliveworkitem, Entity2IntersectAttribute: knowledgearticleid, Entity2LogicalName: knowledgearticle, IntersectEntityName: msdyn_msdyn_ocliveworkitem_knowledgeartic, SchemaName: msdyn_msdyn_ocliveworkitem_knowledgearticle, SecurityTypes: None, IntroducedVersion: 1.10.0.81. </summary>
	public const string msdyn_msdyn_ocliveworkitem_knowledgearticle = "msdyn_msdyn_ocliveworkitem_knowledgearticle";

	/// <summary>Entity1IntersectAttribute: productid, Entity1LogicalName: product, Entity2IntersectAttribute: knowledgearticleid, Entity2LogicalName: knowledgearticle, IntersectEntityName: msdyn_product_knowledgearticle, SchemaName: msdyn_product_knowledgearticle, SecurityTypes: None, IntroducedVersion: 1.0.26.9. </summary>
	public const string msdyn_product_knowledgearticle = "msdyn_product_knowledgearticle";

}

