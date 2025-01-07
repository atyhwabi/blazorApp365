namespace ECSM.Models.Dynamics;

public static partial class ecsm_content_blockManyToOne
{
	/// <summary>ReferencedAttribute: ecsm_catalogue_itemid, ReferencedEntity: ecsm_catalogue_item, ReferencedEntityNavigationPropertyName: ecsm_content_block_CatalogueItem_ecsm_catalogu, ReferencingAttribute: ecsm_catalogueitem, ReferencingEntity: ecsm_content_block, ReferencingEntityNavigationPropertyName: ecsm_CatalogueItem, RelationshipBehavior: 1, SchemaName: ecsm_content_block_CatalogueItem_ecsm_catalogu, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_content_block_CatalogueItem_ecsm_catalogu = "ecsm_CatalogueItem";

	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_ecsm_content_block_ecsm_content_file, ReferencingAttribute: ecsm_content_file, ReferencingEntity: ecsm_content_block, ReferencingEntityNavigationPropertyName: ecsm_content_file, RelationshipBehavior: 0, SchemaName: FileAttachment_ecsm_content_block_ecsm_content_file, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string FileAttachment_ecsm_content_block_ecsm_content_file = "ecsm_content_file";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_content_block_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_content_block, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_content_block_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_content_block_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_content_block_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_content_block, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_content_block_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_content_block_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_content_block_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_content_block, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_content_block_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_content_block_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_content_block_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_content_block, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_content_block_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_content_block_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_content_block, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_content_block, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_content_block, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_content_block = "organizationid";

}

