namespace ECSM.Models.Dynamics;

/// <summary>Location or branch office where an organization does business. An organization can have multiple sites.</summary>
public static partial class SiteOneToMany
{
	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: ecsm_catalogue_item_approval_rule_approval_sit, ReferencingAttribute: ecsm_approval_site, ReferencingEntity: ecsm_catalogue_item_approval_rule, ReferencingEntityNavigationPropertyName: ecsm_approval_site, RelationshipBehavior: 1, SchemaName: ecsm_catalogue_item_approval_rule_approval_sit, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_approval_rule_approval_sit = "ecsm_catalogue_item_approval_rule_approval_sit";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: ecsm_catalogue_item_assignment_rule_assignment, ReferencingAttribute: ecsm_assignment_site, ReferencingEntity: ecsm_catalogue_item_assignment_rule, ReferencingEntityNavigationPropertyName: ecsm_assignment_site, RelationshipBehavior: 1, SchemaName: ecsm_catalogue_item_assignment_rule_assignment, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_assignment_rule_assignment = "ecsm_catalogue_item_assignment_rule_assignment";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: ecsm_catalogue_item_escalation_rule_escal_site, ReferencingAttribute: ecsm_escalation_site, ReferencingEntity: ecsm_catalogue_item_escalation_rule, ReferencingEntityNavigationPropertyName: ecsm_escalation_site, RelationshipBehavior: 1, SchemaName: ecsm_catalogue_item_escalation_rule_escal_site, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_escalation_rule_escal_site = "ecsm_catalogue_item_escalation_rule_escal_site";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: ecsm_configuration_item_Site_site, ReferencingAttribute: ecsm_site, ReferencingEntity: ecsm_configuration_item, ReferencingEntityNavigationPropertyName: ecsm_Site, RelationshipBehavior: 1, SchemaName: ecsm_configuration_item_Site_site, SecurityTypes: Append, IntroducedVersion: 1.0.0.4. </summary>
	public const string ecsm_configuration_item_Site_site = "ecsm_configuration_item_Site_site";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: ecsm_incident_site_site, ReferencingAttribute: ecsm_site, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_site, RelationshipBehavior: 1, SchemaName: ecsm_incident_site_site, SecurityTypes: Append, IntroducedVersion: 1.1.0.12. </summary>
	public const string ecsm_incident_site_site = "ecsm_incident_site_site";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_ActivityPointers, ReferencingAttribute: regardingobjectid, ReferencingEntity: activitypointer, ReferencingEntityNavigationPropertyName: regardingobjectid_site, RelationshipBehavior: 0, SchemaName: site_ActivityPointers, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_ActivityPointers = "site_ActivityPointers";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_adx_inviteredemptions, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_inviteredemption, ReferencingEntityNavigationPropertyName: regardingobjectid_site_adx_inviteredemption, RelationshipBehavior: 1, SchemaName: site_adx_inviteredemptions, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_adx_inviteredemptions = "site_adx_inviteredemptions";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_adx_portalcomments, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_portalcomment, ReferencingEntityNavigationPropertyName: regardingobjectid_site_adx_portalcomment, RelationshipBehavior: 1, SchemaName: site_adx_portalcomments, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_adx_portalcomments = "site_adx_portalcomments";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_Appointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: appointment, ReferencingEntityNavigationPropertyName: regardingobjectid_site_appointment, RelationshipBehavior: 1, SchemaName: site_Appointments, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_Appointments = "site_Appointments";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: Site_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_site, RelationshipBehavior: 0, SchemaName: Site_AsyncOperations, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Site_AsyncOperations = "Site_AsyncOperations";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: Site_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_site, RelationshipBehavior: 0, SchemaName: Site_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Site_BulkDeleteFailures = "Site_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_chats, ReferencingAttribute: regardingobjectid, ReferencingEntity: chat, ReferencingEntityNavigationPropertyName: regardingobjectid_site_chat, RelationshipBehavior: 1, SchemaName: site_chats, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_chats = "site_chats";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_Emails, ReferencingAttribute: regardingobjectid, ReferencingEntity: email, ReferencingEntityNavigationPropertyName: regardingobjectid_site_email, RelationshipBehavior: 1, SchemaName: site_Emails, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_Emails = "site_Emails";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_equipment, ReferencingAttribute: siteid, ReferencingEntity: equipment, ReferencingEntityNavigationPropertyName: siteid, RelationshipBehavior: 1, SchemaName: site_equipment, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_equipment = "site_equipment";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_Faxes, ReferencingAttribute: regardingobjectid, ReferencingEntity: fax, ReferencingEntityNavigationPropertyName: regardingobjectid_site_fax, RelationshipBehavior: 1, SchemaName: site_Faxes, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_Faxes = "site_Faxes";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_internal_addresses, ReferencingAttribute: parentid, ReferencingEntity: internaladdress, ReferencingEntityNavigationPropertyName: parentid_site, RelationshipBehavior: 0, SchemaName: site_internal_addresses, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_internal_addresses = "site_internal_addresses";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_Letters, ReferencingAttribute: regardingobjectid, ReferencingEntity: letter, ReferencingEntityNavigationPropertyName: regardingobjectid_site_letter, RelationshipBehavior: 1, SchemaName: site_Letters, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_Letters = "site_Letters";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_MailboxTrackingFolders, ReferencingAttribute: regardingobjectid, ReferencingEntity: mailboxtrackingfolder, ReferencingEntityNavigationPropertyName: regardingobjectid_site, RelationshipBehavior: 0, SchemaName: site_MailboxTrackingFolders, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_MailboxTrackingFolders = "site_MailboxTrackingFolders";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_msdyn_bookingalerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_bookingalert, ReferencingEntityNavigationPropertyName: regardingobjectid_site_msdyn_bookingalert, RelationshipBehavior: 1, SchemaName: site_msdyn_bookingalerts, SecurityTypes: Append, IntroducedVersion: 3.12.0.448. </summary>
	public const string site_msdyn_bookingalerts = "site_msdyn_bookingalerts";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_msdyn_copilottranscripts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_copilottranscript, ReferencingEntityNavigationPropertyName: regardingobjectid_site_msdyn_copilottranscript, RelationshipBehavior: 1, SchemaName: site_msdyn_copilottranscripts, SecurityTypes: Append, IntroducedVersion: 9.1.24052.1020. </summary>
	public const string site_msdyn_copilottranscripts = "site_msdyn_copilottranscripts";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_msdyn_ocliveworkitems, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocliveworkitem, ReferencingEntityNavigationPropertyName: regardingobjectid_site_msdyn_ocliveworkitem, RelationshipBehavior: 1, SchemaName: site_msdyn_ocliveworkitems, SecurityTypes: Append, IntroducedVersion: 1.10.0.82. </summary>
	public const string site_msdyn_ocliveworkitems = "site_msdyn_ocliveworkitems";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_msdyn_ocsessions, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocsession, ReferencingEntityNavigationPropertyName: regardingobjectid_site_msdyn_ocsession, RelationshipBehavior: 1, SchemaName: site_msdyn_ocsessions, SecurityTypes: Append, IntroducedVersion: 1.10.0.82. </summary>
	public const string site_msdyn_ocsessions = "site_msdyn_ocsessions";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_msfp_alerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_alert, ReferencingEntityNavigationPropertyName: regardingobjectid_site_msfp_alert, RelationshipBehavior: 1, SchemaName: site_msfp_alerts, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string site_msfp_alerts = "site_msfp_alerts";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_msfp_surveyinvites, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyinvite, ReferencingEntityNavigationPropertyName: regardingobjectid_site_msfp_surveyinvite, RelationshipBehavior: 1, SchemaName: site_msfp_surveyinvites, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string site_msfp_surveyinvites = "site_msfp_surveyinvites";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_msfp_surveyresponses, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyresponse, ReferencingEntityNavigationPropertyName: regardingobjectid_site_msfp_surveyresponse, RelationshipBehavior: 1, SchemaName: site_msfp_surveyresponses, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string site_msfp_surveyresponses = "site_msfp_surveyresponses";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_OpportunityCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: opportunityclose, ReferencingEntityNavigationPropertyName: regardingobjectid_site_opportunityclose, RelationshipBehavior: 1, SchemaName: site_OpportunityCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string site_OpportunityCloses = "site_OpportunityCloses";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_OrderCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: orderclose, ReferencingEntityNavigationPropertyName: regardingobjectid_site_orderclose, RelationshipBehavior: 1, SchemaName: site_OrderCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string site_OrderCloses = "site_OrderCloses";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_PhoneCalls, ReferencingAttribute: regardingobjectid, ReferencingEntity: phonecall, ReferencingEntityNavigationPropertyName: regardingobjectid_site_phonecall, RelationshipBehavior: 1, SchemaName: site_PhoneCalls, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_PhoneCalls = "site_PhoneCalls";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_PrincipalObjectAttributeAccesses, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_site, RelationshipBehavior: 0, SchemaName: site_PrincipalObjectAttributeAccesses, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_PrincipalObjectAttributeAccesses = "site_PrincipalObjectAttributeAccesses";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: Site_ProcessSessions, ReferencingAttribute: regardingobjectid, ReferencingEntity: processsession, ReferencingEntityNavigationPropertyName: regardingobjectid_site, RelationshipBehavior: 0, SchemaName: Site_ProcessSessions, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Site_ProcessSessions = "Site_ProcessSessions";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_QuoteCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: quoteclose, ReferencingEntityNavigationPropertyName: regardingobjectid_site_quoteclose, RelationshipBehavior: 1, SchemaName: site_QuoteCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string site_QuoteCloses = "site_QuoteCloses";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_RecurringAppointmentMasters, ReferencingAttribute: regardingobjectid, ReferencingEntity: recurringappointmentmaster, ReferencingEntityNavigationPropertyName: regardingobjectid_site_recurringappointmentmaster, RelationshipBehavior: 1, SchemaName: site_RecurringAppointmentMasters, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_RecurringAppointmentMasters = "site_RecurringAppointmentMasters";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_resources, ReferencingAttribute: siteid, ReferencingEntity: resource, ReferencingEntityNavigationPropertyName: siteid, RelationshipBehavior: 1, SchemaName: site_resources, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_resources = "site_resources";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_service_appointments, ReferencingAttribute: siteid, ReferencingEntity: serviceappointment, ReferencingEntityNavigationPropertyName: siteid, RelationshipBehavior: 1, SchemaName: site_service_appointments, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_service_appointments = "site_service_appointments";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_ServiceAppointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: serviceappointment, ReferencingEntityNavigationPropertyName: regardingobjectid_site_serviceappointment, RelationshipBehavior: 1, SchemaName: site_ServiceAppointments, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_ServiceAppointments = "site_ServiceAppointments";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_SocialActivities, ReferencingAttribute: regardingobjectid, ReferencingEntity: socialactivity, ReferencingEntityNavigationPropertyName: regardingobjectid_site_socialactivity, RelationshipBehavior: 1, SchemaName: site_SocialActivities, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_SocialActivities = "site_SocialActivities";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: Site_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_site_syncerror, RelationshipBehavior: 1, SchemaName: Site_SyncErrors, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Site_SyncErrors = "Site_SyncErrors";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_system_users, ReferencingAttribute: siteid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: siteid, RelationshipBehavior: 1, SchemaName: site_system_users, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_system_users = "site_system_users";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_Tasks, ReferencingAttribute: regardingobjectid, ReferencingEntity: task, ReferencingEntityNavigationPropertyName: regardingobjectid_site_task, RelationshipBehavior: 1, SchemaName: site_Tasks, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_Tasks = "site_Tasks";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: userentityinstancedata_site, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_site, RelationshipBehavior: 0, SchemaName: userentityinstancedata_site, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string userentityinstancedata_site = "userentityinstancedata_site";

}

