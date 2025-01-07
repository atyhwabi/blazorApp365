namespace ECSM.Models.Dynamics;

public static partial class ecsm_categoryManyToOne
{
	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_parent_category_ecsm_category, ReferencingAttribute: ecsm_parent_category, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: ecsm_parent_category, RelationshipBehavior: 1, SchemaName: ecsm_category_parent_category_ecsm_category, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_category_parent_category_ecsm_category = "ecsm_parent_category";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_category_service_catalogue_id_ecsm_servic, ReferencingAttribute: ecsm_service_catalogue_id, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: ecsm_service_catalogue_id, RelationshipBehavior: 1, SchemaName: ecsm_category_service_catalogue_id_ecsm_servic, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_category_service_catalogue_id_ecsm_servic = "ecsm_service_catalogue_id";

	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_ecsm_category_ecsm_image, ReferencingAttribute: ecsm_image, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: ecsm_image, RelationshipBehavior: 0, SchemaName: FileAttachment_ecsm_category_ecsm_image, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string FileAttachment_ecsm_category_ecsm_image = "ecsm_image";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_category_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_category_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_category_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_category_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_category_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_category_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_category_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_category_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_category_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_category_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_category_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_category_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_category, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_category, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_category = "organizationid";

}

