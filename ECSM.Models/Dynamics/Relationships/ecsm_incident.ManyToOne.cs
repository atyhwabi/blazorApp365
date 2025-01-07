namespace ECSM.Models.Dynamics;

public static partial class ecsm_incidentManyToOne
{
	/// <summary>ReferencedAttribute: accountid, ReferencedEntity: account, ReferencedEntityNavigationPropertyName: ecsm_incident_account_account, ReferencingAttribute: ecsm_account, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: ecsm_account, RelationshipBehavior: 1, SchemaName: ecsm_incident_account_account, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_account_account = "ecsm_account";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: ecsm_incident_contact_contact, ReferencingAttribute: ecsm_contact, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: ecsm_contact, RelationshipBehavior: 1, SchemaName: ecsm_incident_contact_contact, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_contact_contact = "ecsm_contact";

	/// <summary>ReferencedAttribute: slakpiinstanceid, ReferencedEntity: slakpiinstance, ReferencedEntityNavigationPropertyName: ecsm_incident_resolve_by_SLA_KPI_slakpiinstanc, ReferencingAttribute: ecsm_resolve_by_sla_kpi, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: ecsm_resolve_by_SLA_KPI, RelationshipBehavior: 1, SchemaName: ecsm_incident_resolve_by_SLA_KPI_slakpiinstanc, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_resolve_by_SLA_KPI_slakpiinstanc = "ecsm_resolve_by_SLA_KPI";

	/// <summary>ReferencedAttribute: slakpiinstanceid, ReferencedEntity: slakpiinstance, ReferencedEntityNavigationPropertyName: ecsm_incident_respond_by_SLA_KPI_slakpiinstanc, ReferencingAttribute: ecsm_respond_by_sla_kpi, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: ecsm_respond_by_SLA_KPI, RelationshipBehavior: 1, SchemaName: ecsm_incident_respond_by_SLA_KPI_slakpiinstanc, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_respond_by_SLA_KPI_slakpiinstanc = "ecsm_respond_by_SLA_KPI";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_incident_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_incident_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_incident_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_incident_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_incident_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_incident_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_incident_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_incident_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_incident_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_incident_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_incident_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_incident_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: manualsla_ecsm_incident, ReferencingAttribute: slaid, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: slaid, RelationshipBehavior: 0, SchemaName: manualsla_ecsm_incident, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string manualsla_ecsm_incident = "slaid";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_incident, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_incident, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_incident = "organizationid";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: sla_ecsm_incident, ReferencingAttribute: slainvokedid, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: slainvokedid, RelationshipBehavior: 0, SchemaName: sla_ecsm_incident, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string sla_ecsm_incident = "slainvokedid";

}

