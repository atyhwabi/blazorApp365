namespace ECSM.Models.Dynamics;

public static partial class ecsm_portal_roleManyToOne
{
	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_portal_role_service_catalogue_ecsm_service_catalogue, ReferencingAttribute: ecsm_service_catalogue, ReferencingEntity: ecsm_portal_role, ReferencingEntityNavigationPropertyName: ecsm_service_catalogue, RelationshipBehavior: 1, SchemaName: ecsm_portal_role_service_catalogue_ecsm_service_catalogue, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_role_service_catalogue_ecsm_service_catalogue = "ecsm_service_catalogue";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_portal_role_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_portal_role, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_portal_role_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_portal_role_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_portal_role_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_portal_role, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_portal_role_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_portal_role_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_portal_role_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_portal_role, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_portal_role_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_portal_role_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_portal_role_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_portal_role, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_portal_role_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_portal_role_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_portal_role, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_portal_role, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_portal_role, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_portal_role = "organizationid";

}

