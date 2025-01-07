namespace ECSM.Models.Dynamics;

public static partial class ecsm_PinnedServiceManyToOne
{
	/// <summary>ReferencedAttribute: ecsm_service_catalogue_itemid, ReferencedEntity: ecsm_service_catalogue_item, ReferencedEntityNavigationPropertyName: ecsm_pinnedservice_service_ecsm_service_catalogue_item, ReferencingAttribute: ecsm_service, ReferencingEntity: ecsm_pinnedservice, ReferencingEntityNavigationPropertyName: ecsm_service, RelationshipBehavior: 1, SchemaName: ecsm_pinnedservice_service_ecsm_service_catalogue_item, SecurityTypes: Append, IntroducedVersion: 1.1.0.12. </summary>
	public const string ecsm_pinnedservice_service_ecsm_service_catalogue_item = "ecsm_service";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_pinnedservice_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_pinnedservice, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_pinnedservice_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_pinnedservice_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_pinnedservice_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_pinnedservice, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_pinnedservice_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_pinnedservice_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_pinnedservice_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_pinnedservice, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_pinnedservice_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_pinnedservice_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_pinnedservice_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_pinnedservice, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_pinnedservice_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_pinnedservice_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_pinnedservice, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_pinnedservice, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_pinnedservice, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_pinnedservice = "organizationid";

}

