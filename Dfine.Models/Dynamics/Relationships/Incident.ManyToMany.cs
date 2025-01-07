namespace ECSM.Models.Dynamics;

/// <summary>Service request case associated with a contract.</summary>
public static partial class IncidentManyToMany
{
	/// <summary>Entity1IntersectAttribute: knowledgebaserecordid, Entity1LogicalName: knowledgebaserecord, Entity1NavigationPropertyName: KnowledgeBaseRecord_Incident, Entity2IntersectAttribute: incidentid, Entity2LogicalName: incident, Entity2NavigationPropertyName: KnowledgeBaseRecord_Incident, IntersectEntityName: incidentknowledgebaserecord, SchemaName: KnowledgeBaseRecord_Incident, SecurityTypes: None, IntroducedVersion: 7.1.0.0. </summary>
	public const string KnowledgeBaseRecord_Incident = "KnowledgeBaseRecord_Incident";

	/// <summary>Entity1IntersectAttribute: incidentid, Entity1LogicalName: incident, Entity1NavigationPropertyName: msdyn_incident_msdyn_customerasset, Entity2IntersectAttribute: msdyn_customerassetid, Entity2LogicalName: msdyn_customerasset, Entity2NavigationPropertyName: msdyn_incident_msdyn_customerasset, IntersectEntityName: msdyn_incident_msdyn_customerasset, SchemaName: msdyn_incident_msdyn_customerasset, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string msdyn_incident_msdyn_customerasset = "msdyn_incident_msdyn_customerasset";

}

