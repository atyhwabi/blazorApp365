namespace ECSM.Models.Dynamics;

/// <summary>Special type of activity that includes description of the resolution, billing status, and the duration of the case.</summary>
public static partial class IncidentResolutionOneToMany
{
	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: CampaignResponse_IncidentResolutions, ReferencingAttribute: originatingactivityid, ReferencingEntity: campaignresponse, ReferencingEntityNavigationPropertyName: originatingactivityid_incidentresolution_campaignresponse, RelationshipBehavior: 0, SchemaName: CampaignResponse_IncidentResolutions, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string CampaignResponse_IncidentResolutions = "CampaignResponse_IncidentResolutions";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: incidentresolution_activity_parties, ReferencingAttribute: activityid, ReferencingEntity: activityparty, ReferencingEntityNavigationPropertyName: activityid_incidentresolution, RelationshipBehavior: 0, SchemaName: incidentresolution_activity_parties, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string incidentresolution_activity_parties = "incidentresolution_activity_parties";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: IncidentResolution_Annotation, ReferencingAttribute: objectid, ReferencingEntity: annotation, ReferencingEntityNavigationPropertyName: objectid_incidentresolution, RelationshipBehavior: 1, SchemaName: IncidentResolution_Annotation, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncidentResolution_Annotation = "IncidentResolution_Annotation";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: IncidentResolution_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_incidentresolution, RelationshipBehavior: 0, SchemaName: IncidentResolution_AsyncOperations, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncidentResolution_AsyncOperations = "IncidentResolution_AsyncOperations";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: IncidentResolution_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_incidentresolution, RelationshipBehavior: 0, SchemaName: IncidentResolution_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncidentResolution_BulkDeleteFailures = "IncidentResolution_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: incidentresolution_MailboxTrackingFolders, ReferencingAttribute: regardingobjectid, ReferencingEntity: mailboxtrackingfolder, ReferencingEntityNavigationPropertyName: regardingobjectid_incidentresolution, RelationshipBehavior: 0, SchemaName: incidentresolution_MailboxTrackingFolders, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string incidentresolution_MailboxTrackingFolders = "incidentresolution_MailboxTrackingFolders";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: incidentresolution_PrincipalObjectAttributeAccesses, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_incidentresolution, RelationshipBehavior: 0, SchemaName: incidentresolution_PrincipalObjectAttributeAccesses, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string incidentresolution_PrincipalObjectAttributeAccesses = "incidentresolution_PrincipalObjectAttributeAccesses";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: IncidentResolution_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_incidentresolution_syncerror, RelationshipBehavior: 1, SchemaName: IncidentResolution_SyncErrors, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncidentResolution_SyncErrors = "IncidentResolution_SyncErrors";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: incidentresolution, ReferencedEntityNavigationPropertyName: userentityinstancedata_incidentresolution, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_incidentresolution, RelationshipBehavior: 0, SchemaName: userentityinstancedata_incidentresolution, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string userentityinstancedata_incidentresolution = "userentityinstancedata_incidentresolution";

}

