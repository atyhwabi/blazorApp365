namespace ECSM.Models.Dynamics;

public static partial class ecsm_service_catalogue_itemManyToOne
{
	/// <summary>ReferencedAttribute: ecsm_catalogue_itemid, ReferencedEntity: ecsm_catalogue_item, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_item_CatalogueItem_ecsm, ReferencingAttribute: ecsm_catalogueitem, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_CatalogueItem, RelationshipBehavior: 1, SchemaName: ecsm_service_catalogue_item_CatalogueItem_ecsm, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_item_CatalogueItem_ecsm = "ecsm_CatalogueItem";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_item_category_ecsm_cate, ReferencingAttribute: ecsm_category, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_category, RelationshipBehavior: 1, SchemaName: ecsm_service_catalogue_item_category_ecsm_cate, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_item_category_ecsm_cate = "ecsm_category";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_item_service_catalogue_, ReferencingAttribute: ecsm_service_catalogue, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_service_catalogue, RelationshipBehavior: 1, SchemaName: ecsm_service_catalogue_item_service_catalogue_, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_item_service_catalogue_ = "ecsm_service_catalogue";

	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_ecsm_service_catalogue_item_ecsm_image, ReferencingAttribute: ecsm_image, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_image, RelationshipBehavior: 0, SchemaName: FileAttachment_ecsm_service_catalogue_item_ecsm_image, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string FileAttachment_ecsm_service_catalogue_item_ecsm_image = "ecsm_image";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_item_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_item_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_service_catalogue_item_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_item_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_item_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_service_catalogue_item_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_item_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_item_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_service_catalogue_item_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_item_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_item_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_service_catalogue_item_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_service_catalogue_item, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_service_catalogue_item, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_service_catalogue_item = "organizationid";

}

