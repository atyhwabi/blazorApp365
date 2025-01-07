namespace ECSM.Models.Dynamics;

/// <summary>Service request case associated with a contract.</summary>
public static partial class IncidentOneToMany
{
	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: bpf_incident_msdyn_iottocaseprocess, ReferencingAttribute: bpf_incidentid, ReferencingEntity: msdyn_iottocaseprocess, ReferencingEntityNavigationPropertyName: bpf_incidentid, RelationshipBehavior: 1, SchemaName: bpf_incident_msdyn_iottocaseprocess, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string bpf_incident_msdyn_iottocaseprocess = "bpf_incident_msdyn_iottocaseprocess";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_change_parent_incident, ReferencingAttribute: ecsm_parent, ReferencingEntity: ecsm_change, ReferencingEntityNavigationPropertyName: ecsm_parent, RelationshipBehavior: 1, SchemaName: ecsm_change_parent_incident, SecurityTypes: Append, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_change_parent_incident = "ecsm_change_parent_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_impacted_services_related_problem_incident, ReferencingAttribute: ecsm_related_problem, ReferencingEntity: ecsm_impacted_services, ReferencingEntityNavigationPropertyName: ecsm_related_problem, RelationshipBehavior: 1, SchemaName: ecsm_impacted_services_related_problem_incident, SecurityTypes: Append, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_impacted_services_related_problem_incident = "ecsm_impacted_services_related_problem_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_item_approval_response_item_incident, ReferencingAttribute: ecsm_item, ReferencingEntity: ecsm_item_approval_response, ReferencingEntityNavigationPropertyName: ecsm_item, RelationshipBehavior: 1, SchemaName: ecsm_item_approval_response_item_incident, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_item_approval_response_item_incident = "ecsm_item_approval_response_item_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_item_escalation_item_incident, ReferencingAttribute: ecsm_item, ReferencingEntity: ecsm_item_escalation, ReferencingEntityNavigationPropertyName: ecsm_item, RelationshipBehavior: 1, SchemaName: ecsm_item_escalation_item_incident, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_item_escalation_item_incident = "ecsm_item_escalation_item_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_message_incident_incident, ReferencingAttribute: ecsm_incident, ReferencingEntity: ecsm_message, ReferencingEntityNavigationPropertyName: ecsm_incident, RelationshipBehavior: 1, SchemaName: ecsm_message_incident_incident, SecurityTypes: Append, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_message_incident_incident = "ecsm_message_incident_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_messageattachment_incident_incident, ReferencingAttribute: ecsm_incident, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: ecsm_incident, RelationshipBehavior: 1, SchemaName: ecsm_messageattachment_incident_incident, SecurityTypes: Append, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_messageattachment_incident_incident = "ecsm_messageattachment_incident_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_actioncard, ReferencingAttribute: regardingobjectid, ReferencingEntity: actioncard, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_actioncard, RelationshipBehavior: 1, SchemaName: incident_actioncard, SecurityTypes: Append, IntroducedVersion: 8.2.0.0. </summary>
	public const string incident_actioncard = "incident_actioncard";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_activity_parties, ReferencingAttribute: partyid, ReferencingEntity: activityparty, ReferencingEntityNavigationPropertyName: partyid_incident, RelationshipBehavior: 1, SchemaName: incident_activity_parties, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_activity_parties = "incident_activity_parties";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_ActivityPointers, ReferencingAttribute: regardingobjectid, ReferencingEntity: activitypointer, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: Incident_ActivityPointers, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_ActivityPointers = "Incident_ActivityPointers";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_adx_inviteredemptions, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_inviteredemption, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_adx_inviteredemption, RelationshipBehavior: 1, SchemaName: incident_adx_inviteredemptions, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_adx_inviteredemptions = "incident_adx_inviteredemptions";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_adx_portalcomments, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_portalcomment, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_adx_portalcomment, RelationshipBehavior: 1, SchemaName: incident_adx_portalcomments, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_adx_portalcomments = "incident_adx_portalcomments";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_Annotation, ReferencingAttribute: objectid, ReferencingEntity: annotation, ReferencingEntityNavigationPropertyName: objectid_incident, RelationshipBehavior: 1, SchemaName: Incident_Annotation, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_Annotation = "Incident_Annotation";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_Appointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: appointment, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_appointment, RelationshipBehavior: 1, SchemaName: Incident_Appointments, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_Appointments = "Incident_Appointments";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: Incident_AsyncOperations, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_AsyncOperations = "Incident_AsyncOperations";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: Incident_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_BulkDeleteFailures = "Incident_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_chats, ReferencingAttribute: regardingobjectid, ReferencingEntity: chat, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_chat, RelationshipBehavior: 1, SchemaName: incident_chats, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_chats = "incident_chats";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_connections1, ReferencingAttribute: record1id, ReferencingEntity: connection, ReferencingEntityNavigationPropertyName: record1id_incident, RelationshipBehavior: 0, SchemaName: incident_connections1, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_connections1 = "incident_connections1";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_connections2, ReferencingAttribute: record2id, ReferencingEntity: connection, ReferencingEntityNavigationPropertyName: record2id_incident, RelationshipBehavior: 0, SchemaName: incident_connections2, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_connections2 = "incident_connections2";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_DuplicateBaseRecord, ReferencingAttribute: baserecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: baserecordid_incident, RelationshipBehavior: 0, SchemaName: Incident_DuplicateBaseRecord, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_DuplicateBaseRecord = "Incident_DuplicateBaseRecord";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_DuplicateMatchingRecord, ReferencingAttribute: duplicaterecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: duplicaterecordid_incident, RelationshipBehavior: 0, SchemaName: Incident_DuplicateMatchingRecord, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_DuplicateMatchingRecord = "Incident_DuplicateMatchingRecord";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_Emails, ReferencingAttribute: regardingobjectid, ReferencingEntity: email, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_email, RelationshipBehavior: 1, SchemaName: Incident_Emails, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_Emails = "Incident_Emails";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_existingcase, ReferencingAttribute: existingcase, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: existingcase, RelationshipBehavior: 1, SchemaName: incident_existingcase, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_existingcase = "incident_existingcase";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_Faxes, ReferencingAttribute: regardingobjectid, ReferencingEntity: fax, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_fax, RelationshipBehavior: 1, SchemaName: Incident_Faxes, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_Faxes = "Incident_Faxes";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_IncidentResolutions, ReferencingAttribute: incidentid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: incidentid, RelationshipBehavior: 1, SchemaName: Incident_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_IncidentResolutions = "Incident_IncidentResolutions";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_Letters, ReferencingAttribute: regardingobjectid, ReferencingEntity: letter, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_letter, RelationshipBehavior: 1, SchemaName: Incident_Letters, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_Letters = "Incident_Letters";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_MailboxTrackingFolder, ReferencingAttribute: regardingobjectid, ReferencingEntity: mailboxtrackingfolder, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 1, SchemaName: Incident_MailboxTrackingFolder, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_MailboxTrackingFolder = "Incident_MailboxTrackingFolder";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_master_incident, ReferencingAttribute: masterid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: masterid, RelationshipBehavior: 1, SchemaName: incident_master_incident, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string incident_master_incident = "incident_master_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_msdyn_bookingalerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_bookingalert, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_msdyn_bookingalert, RelationshipBehavior: 1, SchemaName: incident_msdyn_bookingalerts, SecurityTypes: Append, IntroducedVersion: 3.12.0.448. </summary>
	public const string incident_msdyn_bookingalerts = "incident_msdyn_bookingalerts";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_msdyn_copilottranscripts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_copilottranscript, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_msdyn_copilottranscript, RelationshipBehavior: 1, SchemaName: incident_msdyn_copilottranscripts, SecurityTypes: Append, IntroducedVersion: 9.1.24052.1020. </summary>
	public const string incident_msdyn_copilottranscripts = "incident_msdyn_copilottranscripts";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_msdyn_ocliveworkitems, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocliveworkitem, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_msdyn_ocliveworkitem, RelationshipBehavior: 1, SchemaName: incident_msdyn_ocliveworkitems, SecurityTypes: Append, IntroducedVersion: 1.10.0.82. </summary>
	public const string incident_msdyn_ocliveworkitems = "incident_msdyn_ocliveworkitems";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_msdyn_ocsessions, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocsession, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_msdyn_ocsession, RelationshipBehavior: 1, SchemaName: incident_msdyn_ocsessions, SecurityTypes: Append, IntroducedVersion: 1.10.0.82. </summary>
	public const string incident_msdyn_ocsessions = "incident_msdyn_ocsessions";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_msfp_alerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_alert, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_msfp_alert, RelationshipBehavior: 1, SchemaName: incident_msfp_alerts, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string incident_msfp_alerts = "incident_msfp_alerts";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_msfp_surveyinvites, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyinvite, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_msfp_surveyinvite, RelationshipBehavior: 1, SchemaName: incident_msfp_surveyinvites, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string incident_msfp_surveyinvites = "incident_msfp_surveyinvites";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_msfp_surveyresponses, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyresponse, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_msfp_surveyresponse, RelationshipBehavior: 1, SchemaName: incident_msfp_surveyresponses, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string incident_msfp_surveyresponses = "incident_msfp_surveyresponses";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_OpportunityCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: opportunityclose, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_opportunityclose, RelationshipBehavior: 1, SchemaName: incident_OpportunityCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string incident_OpportunityCloses = "incident_OpportunityCloses";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_OrderCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: orderclose, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_orderclose, RelationshipBehavior: 1, SchemaName: incident_OrderCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string incident_OrderCloses = "incident_OrderCloses";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_parent_incident, ReferencingAttribute: parentcaseid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: parentcaseid, RelationshipBehavior: 1, SchemaName: incident_parent_incident, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string incident_parent_incident = "incident_parent_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_Phonecalls, ReferencingAttribute: regardingobjectid, ReferencingEntity: phonecall, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_phonecall, RelationshipBehavior: 1, SchemaName: Incident_Phonecalls, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_Phonecalls = "Incident_Phonecalls";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_PostFollows, ReferencingAttribute: regardingobjectid, ReferencingEntity: postfollow, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: incident_PostFollows, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_PostFollows = "incident_PostFollows";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_PostRegardings, ReferencingAttribute: regardingobjectid, ReferencingEntity: postregarding, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: incident_PostRegardings, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_PostRegardings = "incident_PostRegardings";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_PostRoles, ReferencingAttribute: regardingobjectid, ReferencingEntity: postrole, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: incident_PostRoles, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_PostRoles = "incident_PostRoles";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_Posts, ReferencingAttribute: regardingobjectid, ReferencingEntity: post, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: incident_Posts, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string incident_Posts = "incident_Posts";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_principalobjectattributeaccess, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_incident, RelationshipBehavior: 1, SchemaName: incident_principalobjectattributeaccess, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_principalobjectattributeaccess = "incident_principalobjectattributeaccess";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_ProcessSessions, ReferencingAttribute: regardingobjectid, ReferencingEntity: processsession, ReferencingEntityNavigationPropertyName: regardingobjectid_incident, RelationshipBehavior: 0, SchemaName: Incident_ProcessSessions, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_ProcessSessions = "Incident_ProcessSessions";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_QueueItem, ReferencingAttribute: objectid, ReferencingEntity: queueitem, ReferencingEntityNavigationPropertyName: objectid_incident, RelationshipBehavior: 1, SchemaName: Incident_QueueItem, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_QueueItem = "Incident_QueueItem";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_QuoteCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: quoteclose, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_quoteclose, RelationshipBehavior: 1, SchemaName: incident_QuoteCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string incident_QuoteCloses = "incident_QuoteCloses";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_RecurringAppointmentMasters, ReferencingAttribute: regardingobjectid, ReferencingEntity: recurringappointmentmaster, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_recurringappointmentmaster, RelationshipBehavior: 1, SchemaName: Incident_RecurringAppointmentMasters, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_RecurringAppointmentMasters = "Incident_RecurringAppointmentMasters";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_ServiceAppointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: serviceappointment, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_serviceappointment, RelationshipBehavior: 1, SchemaName: Incident_ServiceAppointments, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string Incident_ServiceAppointments = "Incident_ServiceAppointments";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_SocialActivities, ReferencingAttribute: regardingobjectid, ReferencingEntity: socialactivity, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_socialactivity, RelationshipBehavior: 1, SchemaName: Incident_SocialActivities, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_SocialActivities = "Incident_SocialActivities";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_syncerror, RelationshipBehavior: 1, SchemaName: Incident_SyncErrors, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_SyncErrors = "Incident_SyncErrors";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_Tasks, ReferencingAttribute: regardingobjectid, ReferencingEntity: task, ReferencingEntityNavigationPropertyName: regardingobjectid_incident_task, RelationshipBehavior: 1, SchemaName: Incident_Tasks, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_Tasks = "Incident_Tasks";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_topic, ReferencingAttribute: incidentid, ReferencingEntity: topic, ReferencingEntityNavigationPropertyName: incidentid, RelationshipBehavior: 0, SchemaName: incident_topic, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string incident_topic = "incident_topic";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: knowledgearticle_incidents, ReferencingAttribute: incidentid, ReferencingEntity: knowledgearticleincident, ReferencingEntityNavigationPropertyName: incidentid, RelationshipBehavior: 1, SchemaName: knowledgearticle_incidents, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_incidents = "knowledgearticle_incidents";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_phonetocaseprocess, ReferencingAttribute: incidentid, ReferencingEntity: phonetocaseprocess, ReferencingEntityNavigationPropertyName: incidentid, RelationshipBehavior: 0, SchemaName: lk_phonetocaseprocess_incidentid, SecurityTypes: None, IntroducedVersion: 8.2.0.0. </summary>
	public const string lk_phonetocaseprocess_incidentid = "lk_phonetocaseprocess_incidentid";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_feedback_context, ReferencingAttribute: msdyn_contextobjectid, ReferencingEntity: feedback, ReferencingEntityNavigationPropertyName: msdyn_ContextObjectId_incident, RelationshipBehavior: 0, SchemaName: msdyn_incident_feedback_context, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string msdyn_incident_feedback_context = "msdyn_incident_feedback_context";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_aicontactsuggestion_sourcerecord, ReferencingAttribute: msdyn_sourcerecord, ReferencingEntity: msdyn_aicontactsuggestion, ReferencingEntityNavigationPropertyName: msdyn_sourcerecord_Incident_incident, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_aicontactsuggestion_sourcerecord, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_incident_msdyn_aicontactsuggestion_sourcerecord = "msdyn_incident_msdyn_aicontactsuggestion_sourcerecord";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_caseenrichment_caseid, ReferencingAttribute: msdyn_caseid, ReferencingEntity: msdyn_caseenrichment, ReferencingEntityNavigationPropertyName: msdyn_caseid, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_caseenrichment_caseid, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_incident_msdyn_caseenrichment_caseid = "msdyn_incident_msdyn_caseenrichment_caseid";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_casesuggestion_suggestedentity, ReferencingAttribute: msdyn_suggestedentity, ReferencingEntity: msdyn_casesuggestion, ReferencingEntityNavigationPropertyName: msdyn_suggestedentity, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_casesuggestion_suggestedentity, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_incident_msdyn_casesuggestion_suggestedentity = "msdyn_incident_msdyn_casesuggestion_suggestedentity";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_casesuggestionrequestpayload_caseid, ReferencingAttribute: msdyn_caseid, ReferencingEntity: msdyn_casesuggestionrequestpayload, ReferencingEntityNavigationPropertyName: msdyn_caseid, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_casesuggestionrequestpayload_caseid, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_incident_msdyn_casesuggestionrequestpayload_caseid = "msdyn_incident_msdyn_casesuggestionrequestpayload_caseid";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_casetopic_incident_incidentid, ReferencingAttribute: msdyn_incidentid, ReferencingEntity: msdyn_casetopic_incident, ReferencingEntityNavigationPropertyName: msdyn_incidentid, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_casetopic_incident_incidentid, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_incident_msdyn_casetopic_incident_incidentid = "msdyn_incident_msdyn_casetopic_incident_incidentid";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_federatedarticleincident_IncidentId, ReferencingAttribute: msdyn_incidentid, ReferencingEntity: msdyn_federatedarticleincident, ReferencingEntityNavigationPropertyName: msdyn_incidentid, RelationshipBehavior: 0, SchemaName: msdyn_incident_msdyn_federatedarticleincident_IncidentId, SecurityTypes: None, IntroducedVersion: 9.0.0.0. </summary>
	public const string msdyn_incident_msdyn_federatedarticleincident_IncidentId = "msdyn_incident_msdyn_federatedarticleincident_IncidentId";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_iotalert_Case, ReferencingAttribute: msdyn_case, ReferencingEntity: msdyn_iotalert, ReferencingEntityNavigationPropertyName: msdyn_Case, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_iotalert_Case, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_incident_msdyn_iotalert_Case = "msdyn_incident_msdyn_iotalert_Case";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_ocliveworkitem, ReferencingAttribute: msdyn_issueid, ReferencingEntity: msdyn_ocliveworkitem, ReferencingEntityNavigationPropertyName: msdyn_IssueId_msdyn_ocliveworkitem, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_ocliveworkitem, SecurityTypes: Append, IntroducedVersion: 1.0.0.1. </summary>
	public const string msdyn_incident_msdyn_ocliveworkitem = "msdyn_incident_msdyn_ocliveworkitem";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_originatingqueue_createdincidentid, ReferencingAttribute: msdyn_createdincidentid, ReferencingEntity: msdyn_originatingqueue, ReferencingEntityNavigationPropertyName: msdyn_createdincidentid, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_originatingqueue_createdincidentid, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_incident_msdyn_originatingqueue_createdincidentid = "msdyn_incident_msdyn_originatingqueue_createdincidentid";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity, ReferencingAttribute: msdyn_suggestedentity, ReferencingEntity: msdyn_suggestioninteraction, ReferencingEntityNavigationPropertyName: msdyn_suggestedentity_incident, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity = "msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor, ReferencingAttribute: msdyn_suggestionfor, ReferencingEntity: msdyn_suggestioninteraction, ReferencingEntityNavigationPropertyName: msdyn_suggestionfor_incident, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor = "msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_incident_msdyn_suggestionrequestpayload, ReferencingAttribute: msdyn_suggestionfor, ReferencingEntity: msdyn_suggestionrequestpayload, ReferencingEntityNavigationPropertyName: msdyn_suggestionfor_incident, RelationshipBehavior: 1, SchemaName: msdyn_incident_msdyn_suggestionrequestpayload, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_incident_msdyn_suggestionrequestpayload = "msdyn_incident_msdyn_suggestionrequestpayload";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_intent_case, ReferencingAttribute: msdyn_objectid, ReferencingEntity: msdyn_intent, ReferencingEntityNavigationPropertyName: msdyn_Objectid_incident, RelationshipBehavior: 1, SchemaName: msdyn_intent_case, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_intent_case = "msdyn_intent_case";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_readtracker_poly_incident, ReferencingAttribute: msdyn_regardingobjectid, ReferencingEntity: msdyn_readtracker, ReferencingEntityNavigationPropertyName: msdyn_RegardingObjectId, RelationshipBehavior: 1, SchemaName: msdyn_readtracker_poly_incident, SecurityTypes: Append, IntroducedVersion: 9.1.0.0. </summary>
	public const string msdyn_readtracker_poly_incident = "msdyn_readtracker_poly_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_relatedentity_msdyn_entityattachment, ReferencingAttribute: msdyn_relatedentity, ReferencingEntity: msdyn_entityattachment, ReferencingEntityNavigationPropertyName: msdyn_relatedentity, RelationshipBehavior: 1, SchemaName: msdyn_relatedentity_msdyn_entityattachment, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_relatedentity_msdyn_entityattachment = "msdyn_relatedentity_msdyn_entityattachment";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: msdyn_swarm_incident, ReferencingAttribute: msdyn_swarmrelatedrecordid, ReferencingEntity: msdyn_swarm, ReferencingEntityNavigationPropertyName: msdyn_swarmrelatedrecordid_incident, RelationshipBehavior: 1, SchemaName: msdyn_swarm_incident, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_swarm_incident = "msdyn_swarm_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: OriginatingCase_Lead, ReferencingAttribute: originatingcaseid, ReferencingEntity: lead, ReferencingEntityNavigationPropertyName: originatingcaseid, RelationshipBehavior: 1, SchemaName: OriginatingCase_Lead, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string OriginatingCase_Lead = "OriginatingCase_Lead";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: slakpiinstance_incident, ReferencingAttribute: regarding, ReferencingEntity: slakpiinstance, ReferencingEntityNavigationPropertyName: regarding, RelationshipBehavior: 1, SchemaName: slakpiinstance_incident, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string slakpiinstance_incident = "slakpiinstance_incident";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: userentityinstancedata_incident, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_incident, RelationshipBehavior: 0, SchemaName: userentityinstancedata_incident, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string userentityinstancedata_incident = "userentityinstancedata_incident";

}

