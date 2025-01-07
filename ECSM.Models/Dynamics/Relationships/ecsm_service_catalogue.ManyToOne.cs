namespace ECSM.Models.Dynamics;

/// <summary>Service Catalogues enable Admins to create unique collections of Service Catalogue Items to make them available in the Portal to relevant Personas</summary>
public static partial class ecsm_service_catalogueManyToOne
{
	/// <summary>ReferencedAttribute: pricelevelid, ReferencedEntity: pricelevel, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_default_pricelist_price, ReferencingAttribute: ecsm_default_pricelist, ReferencingEntity: ecsm_service_catalogue, ReferencingEntityNavigationPropertyName: ecsm_default_pricelist, RelationshipBehavior: 1, SchemaName: ecsm_service_catalogue_default_pricelist_price, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_default_pricelist_price = "ecsm_default_pricelist";

	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_ecsm_service_catalogue_ecsm_image, ReferencingAttribute: ecsm_image, ReferencingEntity: ecsm_service_catalogue, ReferencingEntityNavigationPropertyName: ecsm_image, RelationshipBehavior: 0, SchemaName: FileAttachment_ecsm_service_catalogue_ecsm_image, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string FileAttachment_ecsm_service_catalogue_ecsm_image = "ecsm_image";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_service_catalogue, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_createdby, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string lk_ecsm_service_catalogue_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_service_catalogue, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string lk_ecsm_service_catalogue_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_service_catalogue, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string lk_ecsm_service_catalogue_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_service_catalogue_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_service_catalogue, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_service_catalogue_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string lk_ecsm_service_catalogue_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_service_catalogue, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_service_catalogue, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_service_catalogue, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string organization_ecsm_service_catalogue = "organizationid";

}

