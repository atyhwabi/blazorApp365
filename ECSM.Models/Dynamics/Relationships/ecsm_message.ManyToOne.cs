namespace ECSM.Models.Dynamics;

public static partial class ecsm_messageManyToOne
{
	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_message_incident_incident, ReferencingAttribute: ecsm_incident, ReferencingEntity: ecsm_message, ReferencingEntityNavigationPropertyName: ecsm_incident, RelationshipBehavior: 1, SchemaName: ecsm_message_incident_incident, SecurityTypes: Append, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_message_incident_incident = "ecsm_incident";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_message_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_message, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_message_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_message_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_message_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_message, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_message_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_message_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_message_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_message, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_message_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_message_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_message_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_message, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_message_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_message_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_message, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_message, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_message, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_message = "organizationid";

}

