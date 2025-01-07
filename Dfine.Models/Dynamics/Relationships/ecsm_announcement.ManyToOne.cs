namespace ECSM.Models.Dynamics;

public static partial class ecsm_announcementManyToOne
{
	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_announcement_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_announcement, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_announcement_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_announcement_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_announcement_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_announcement, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_announcement_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_announcement_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_announcement_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_announcement, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_announcement_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_announcement_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_announcement_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_announcement, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_announcement_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_announcement_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_announcement, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_announcement, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_announcement, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_announcement = "organizationid";

}

