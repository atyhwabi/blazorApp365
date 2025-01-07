namespace ECSM.Models.Dynamics;

/// <summary>Person with whom a business unit has a relationship, such as customer, supplier, and colleague.</summary>
public static partial class ContactOneToMany
{
	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: account_primary_contact, ReferencingAttribute: primarycontactid, ReferencingEntity: account, ReferencingEntityNavigationPropertyName: primarycontactid, RelationshipBehavior: 1, SchemaName: account_primary_contact, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string account_primary_contact = "account_primary_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: adx_contact_externalidentity, ReferencingAttribute: adx_contactid, ReferencingEntity: adx_externalidentity, ReferencingEntityNavigationPropertyName: adx_contactid, RelationshipBehavior: 1, SchemaName: adx_contact_externalidentity, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_contact_externalidentity = "adx_contact_externalidentity";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: adx_invitation_invitecontact, ReferencingAttribute: adx_invitecontact, ReferencingEntity: adx_invitation, ReferencingEntityNavigationPropertyName: adx_inviteContact, RelationshipBehavior: 1, SchemaName: adx_invitation_invitecontact, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_invitation_invitecontact = "adx_invitation_invitecontact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: adx_invitation_invitercontact, ReferencingAttribute: adx_invitercontact, ReferencingEntity: adx_invitation, ReferencingEntityNavigationPropertyName: adx_invitercontact, RelationshipBehavior: 1, SchemaName: adx_invitation_invitercontact, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_invitation_invitercontact = "adx_invitation_invitercontact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: adx_invitation_redeemedContact, ReferencingAttribute: adx_redeemedcontact, ReferencingEntity: adx_invitation, ReferencingEntityNavigationPropertyName: adx_redeemedContact, RelationshipBehavior: 1, SchemaName: adx_invitation_redeemedContact, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_invitation_redeemedContact = "adx_invitation_redeemedContact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: adx_webformsession_contact, ReferencingAttribute: adx_contact, ReferencingEntity: adx_webformsession, ReferencingEntityNavigationPropertyName: adx_contact, RelationshipBehavior: 1, SchemaName: adx_webformsession_contact, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_webformsession_contact = "adx_webformsession_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_actioncard, ReferencingAttribute: regardingobjectid, ReferencingEntity: actioncard, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_actioncard, RelationshipBehavior: 1, SchemaName: contact_actioncard, SecurityTypes: Append, IntroducedVersion: 8.2.0.0. </summary>
	public const string contact_actioncard = "contact_actioncard";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_activity_parties, ReferencingAttribute: partyid, ReferencingEntity: activityparty, ReferencingEntityNavigationPropertyName: partyid_contact, RelationshipBehavior: 1, SchemaName: contact_activity_parties, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_activity_parties = "contact_activity_parties";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_ActivityPointers, ReferencingAttribute: regardingobjectid, ReferencingEntity: activitypointer, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: Contact_ActivityPointers, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_ActivityPointers = "Contact_ActivityPointers";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_adx_inviteredemptions, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_inviteredemption, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_adx_inviteredemption, RelationshipBehavior: 1, SchemaName: contact_adx_inviteredemptions, SecurityTypes: Append, IntroducedVersion: 1.0.2402.1. </summary>
	public const string contact_adx_inviteredemptions = "contact_adx_inviteredemptions";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_adx_portalcomments, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_portalcomment, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_adx_portalcomment, RelationshipBehavior: 1, SchemaName: contact_adx_portalcomments, SecurityTypes: Append, IntroducedVersion: 1.0.2402.1. </summary>
	public const string contact_adx_portalcomments = "contact_adx_portalcomments";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Annotation, ReferencingAttribute: objectid, ReferencingEntity: annotation, ReferencingEntityNavigationPropertyName: objectid_contact, RelationshipBehavior: 1, SchemaName: Contact_Annotation, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_Annotation = "Contact_Annotation";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Appointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: appointment, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_appointment, RelationshipBehavior: 1, SchemaName: Contact_Appointments, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_Appointments = "Contact_Appointments";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_as_primary_contact, ReferencingAttribute: primarycontactid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: primarycontactid, RelationshipBehavior: 1, SchemaName: contact_as_primary_contact, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string contact_as_primary_contact = "contact_as_primary_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_as_responsible_contact, ReferencingAttribute: responsiblecontactid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: responsiblecontactid, RelationshipBehavior: 1, SchemaName: contact_as_responsible_contact, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_as_responsible_contact = "contact_as_responsible_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: Contact_AsyncOperations, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_AsyncOperations = "Contact_AsyncOperations";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_bookableresource_ContactId, ReferencingAttribute: contactid, ReferencingEntity: bookableresource, ReferencingEntityNavigationPropertyName: ContactId, RelationshipBehavior: 1, SchemaName: contact_bookableresource_ContactId, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string contact_bookableresource_ContactId = "contact_bookableresource_ContactId";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: Contact_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_BulkDeleteFailures = "Contact_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_BulkOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_bulkoperation, RelationshipBehavior: 1, SchemaName: contact_BulkOperations, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string contact_BulkOperations = "contact_BulkOperations";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_CampaignResponses, ReferencingAttribute: regardingobjectid, ReferencingEntity: campaignresponse, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_campaignresponse, RelationshipBehavior: 1, SchemaName: contact_CampaignResponses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string contact_CampaignResponses = "contact_CampaignResponses";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_chats, ReferencingAttribute: regardingobjectid, ReferencingEntity: chat, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_chat, RelationshipBehavior: 1, SchemaName: contact_chats, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string contact_chats = "contact_chats";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_connections1, ReferencingAttribute: record1id, ReferencingEntity: connection, ReferencingEntityNavigationPropertyName: record1id_contact, RelationshipBehavior: 0, SchemaName: contact_connections1, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_connections1 = "contact_connections1";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_connections2, ReferencingAttribute: record2id, ReferencingEntity: connection, ReferencingEntityNavigationPropertyName: record2id_contact, RelationshipBehavior: 0, SchemaName: contact_connections2, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_connections2 = "contact_connections2";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_customer_contacts, ReferencingAttribute: parentcustomerid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: parentcustomerid_contact, RelationshipBehavior: 1, SchemaName: contact_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_customer_contacts = "contact_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_customer_opportunity_roles, ReferencingAttribute: customerid, ReferencingEntity: customeropportunityrole, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: contact_customer_opportunity_roles, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_customer_opportunity_roles = "contact_customer_opportunity_roles";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_customer_relationship_customer, ReferencingAttribute: customerid, ReferencingEntity: customerrelationship, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: contact_customer_relationship_customer, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_customer_relationship_customer = "contact_customer_relationship_customer";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_customer_relationship_partner, ReferencingAttribute: partnerid, ReferencingEntity: customerrelationship, ReferencingEntityNavigationPropertyName: partnerid_contact, RelationshipBehavior: 1, SchemaName: contact_customer_relationship_partner, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_customer_relationship_partner = "contact_customer_relationship_partner";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_CustomerAddress, ReferencingAttribute: parentid, ReferencingEntity: customeraddress, ReferencingEntityNavigationPropertyName: parentid_contact, RelationshipBehavior: 1, SchemaName: Contact_CustomerAddress, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_CustomerAddress = "Contact_CustomerAddress";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_DuplicateBaseRecord, ReferencingAttribute: baserecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: baserecordid_contact, RelationshipBehavior: 0, SchemaName: Contact_DuplicateBaseRecord, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_DuplicateBaseRecord = "Contact_DuplicateBaseRecord";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_DuplicateMatchingRecord, ReferencingAttribute: duplicaterecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: duplicaterecordid_contact, RelationshipBehavior: 0, SchemaName: Contact_DuplicateMatchingRecord, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_DuplicateMatchingRecord = "Contact_DuplicateMatchingRecord";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Email_EmailSender, ReferencingAttribute: emailsender, ReferencingEntity: email, ReferencingEntityNavigationPropertyName: emailsender_contact, RelationshipBehavior: 1, SchemaName: Contact_Email_EmailSender, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string Contact_Email_EmailSender = "Contact_Email_EmailSender";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Emails, ReferencingAttribute: regardingobjectid, ReferencingEntity: email, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_email, RelationshipBehavior: 1, SchemaName: Contact_Emails, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_Emails = "Contact_Emails";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_entitlement_ContactId, ReferencingAttribute: contactid, ReferencingEntity: entitlement, ReferencingEntityNavigationPropertyName: contactid, RelationshipBehavior: 1, SchemaName: contact_entitlement_ContactId, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string contact_entitlement_ContactId = "contact_entitlement_ContactId";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_entitlement_Customer, ReferencingAttribute: customerid, ReferencingEntity: entitlement, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: contact_entitlement_Customer, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string contact_entitlement_Customer = "contact_entitlement_Customer";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_ExternalPartyItems, ReferencingAttribute: regardingobjectid, ReferencingEntity: externalpartyitem, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: Contact_ExternalPartyItems, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string Contact_ExternalPartyItems = "Contact_ExternalPartyItems";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Faxes, ReferencingAttribute: regardingobjectid, ReferencingEntity: fax, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_fax, RelationshipBehavior: 1, SchemaName: Contact_Faxes, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_Faxes = "Contact_Faxes";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Feedback, ReferencingAttribute: regardingobjectid, ReferencingEntity: feedback, ReferencingEntityNavigationPropertyName: ContactId, RelationshipBehavior: 1, SchemaName: Contact_Feedback, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string Contact_Feedback = "Contact_Feedback";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Letters, ReferencingAttribute: regardingobjectid, ReferencingEntity: letter, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_letter, RelationshipBehavior: 1, SchemaName: Contact_Letters, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_Letters = "Contact_Letters";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_MailboxTrackingFolder, ReferencingAttribute: regardingobjectid, ReferencingEntity: mailboxtrackingfolder, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 1, SchemaName: Contact_MailboxTrackingFolder, SecurityTypes: Append, IntroducedVersion: 7.1.0.0. </summary>
	public const string Contact_MailboxTrackingFolder = "Contact_MailboxTrackingFolder";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_master_contact, ReferencingAttribute: masterid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: masterid, RelationshipBehavior: 1, SchemaName: contact_master_contact, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_master_contact = "contact_master_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_msdyn_bookingalerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_bookingalert, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_msdyn_bookingalert, RelationshipBehavior: 1, SchemaName: contact_msdyn_bookingalerts, SecurityTypes: Append, IntroducedVersion: 3.12.0.448. </summary>
	public const string contact_msdyn_bookingalerts = "contact_msdyn_bookingalerts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_msdyn_copilottranscripts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_copilottranscript, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_msdyn_copilottranscript, RelationshipBehavior: 1, SchemaName: contact_msdyn_copilottranscripts, SecurityTypes: Append, IntroducedVersion: 9.1.24052.1020. </summary>
	public const string contact_msdyn_copilottranscripts = "contact_msdyn_copilottranscripts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_msdyn_ocliveworkitems, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocliveworkitem, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_msdyn_ocliveworkitem, RelationshipBehavior: 1, SchemaName: contact_msdyn_ocliveworkitems, SecurityTypes: Append, IntroducedVersion: 1.10.0.82. </summary>
	public const string contact_msdyn_ocliveworkitems = "contact_msdyn_ocliveworkitems";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_msdyn_ocsessions, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocsession, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_msdyn_ocsession, RelationshipBehavior: 1, SchemaName: contact_msdyn_ocsessions, SecurityTypes: Append, IntroducedVersion: 1.10.0.82. </summary>
	public const string contact_msdyn_ocsessions = "contact_msdyn_ocsessions";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: new_contact_msdyn_orgchartnodeupdated_msdyn_noderecordupdated, ReferencingAttribute: msdyn_noderecord, ReferencingEntity: msdyn_orgchartnode, ReferencingEntityNavigationPropertyName: msdyn_noderecord, RelationshipBehavior: 1, SchemaName: contact_msdyn_orgchartnode_msdyn_noderecord, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string contact_msdyn_orgchartnode_msdyn_noderecord = "contact_msdyn_orgchartnode_msdyn_noderecord";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_msfp_alerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_alert, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_msfp_alert, RelationshipBehavior: 1, SchemaName: contact_msfp_alerts, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string contact_msfp_alerts = "contact_msfp_alerts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_msfp_surveyinvites, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyinvite, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_msfp_surveyinvite, RelationshipBehavior: 1, SchemaName: contact_msfp_surveyinvites, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string contact_msfp_surveyinvites = "contact_msfp_surveyinvites";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_msfp_surveyresponses, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyresponse, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_msfp_surveyresponse, RelationshipBehavior: 1, SchemaName: contact_msfp_surveyresponses, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string contact_msfp_surveyresponses = "contact_msfp_surveyresponses";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Phonecalls, ReferencingAttribute: regardingobjectid, ReferencingEntity: phonecall, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_phonecall, RelationshipBehavior: 1, SchemaName: Contact_Phonecalls, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_Phonecalls = "Contact_Phonecalls";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_PostFollows, ReferencingAttribute: regardingobjectid, ReferencingEntity: postfollow, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: contact_PostFollows, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_PostFollows = "contact_PostFollows";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_PostRegardings, ReferencingAttribute: regardingobjectid, ReferencingEntity: postregarding, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: contact_PostRegardings, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_PostRegardings = "contact_PostRegardings";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_PostRoles, ReferencingAttribute: regardingobjectid, ReferencingEntity: postrole, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: contact_PostRoles, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_PostRoles = "contact_PostRoles";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_Posts, ReferencingAttribute: regardingobjectid, ReferencingEntity: post, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: contact_Posts, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string contact_Posts = "contact_Posts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_principalobjectattributeaccess, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_contact, RelationshipBehavior: 1, SchemaName: contact_principalobjectattributeaccess, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_principalobjectattributeaccess = "contact_principalobjectattributeaccess";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_ProcessSessions, ReferencingAttribute: regardingobjectid, ReferencingEntity: processsession, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: Contact_ProcessSessions, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_ProcessSessions = "Contact_ProcessSessions";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_RecurringAppointmentMasters, ReferencingAttribute: regardingobjectid, ReferencingEntity: recurringappointmentmaster, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_recurringappointmentmaster, RelationshipBehavior: 1, SchemaName: Contact_RecurringAppointmentMasters, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_RecurringAppointmentMasters = "Contact_RecurringAppointmentMasters";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_ServiceAppointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: serviceappointment, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_serviceappointment, RelationshipBehavior: 1, SchemaName: Contact_ServiceAppointments, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string Contact_ServiceAppointments = "Contact_ServiceAppointments";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_SharePointDocuments, ReferencingAttribute: regardingobjectid, ReferencingEntity: sharepointdocument, ReferencingEntityNavigationPropertyName: regardingobjectid_opportunity, RelationshipBehavior: 0, SchemaName: contact_SharePointDocuments, SecurityTypes: None, IntroducedVersion: 6.1.0.0. </summary>
	public const string contact_SharePointDocuments = "contact_SharePointDocuments";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_SocialActivities, ReferencingAttribute: regardingobjectid, ReferencingEntity: socialactivity, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_socialactivity, RelationshipBehavior: 1, SchemaName: Contact_SocialActivities, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string Contact_SocialActivities = "Contact_SocialActivities";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_syncerror, RelationshipBehavior: 1, SchemaName: Contact_SyncErrors, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string Contact_SyncErrors = "Contact_SyncErrors";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Contact_Tasks, ReferencingAttribute: regardingobjectid, ReferencingEntity: task, ReferencingEntityNavigationPropertyName: regardingobjectid_contact_task, RelationshipBehavior: 1, SchemaName: Contact_Tasks, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Contact_Tasks = "Contact_Tasks";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contract_billingcustomer_contacts, ReferencingAttribute: billingcustomerid, ReferencingEntity: contract, ReferencingEntityNavigationPropertyName: billingcustomerid_contact, RelationshipBehavior: 1, SchemaName: contract_billingcustomer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contract_billingcustomer_contacts = "contract_billingcustomer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contract_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: contract, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: contract_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contract_customer_contacts = "contract_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contractlineitem_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: contractdetail, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: contractlineitem_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contractlineitem_customer_contacts = "contractlineitem_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: CreatedContact_BulkOperationLogs, ReferencingAttribute: createdobjectid, ReferencingEntity: bulkoperationlog, ReferencingEntityNavigationPropertyName: createdobjectid_contact, RelationshipBehavior: 0, SchemaName: CreatedContact_BulkOperationLogs, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedContact_BulkOperationLogs = "CreatedContact_BulkOperationLogs";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: incident_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: incident_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_customer_contacts = "incident_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: invoice_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: invoice, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: invoice_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string invoice_customer_contacts = "invoice_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: lead_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: lead, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: lead_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string lead_customer_contacts = "lead_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: lead_parent_contact, ReferencingAttribute: parentcontactid, ReferencingEntity: lead, ReferencingEntityNavigationPropertyName: parentcontactid, RelationshipBehavior: 1, SchemaName: lead_parent_contact, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string lead_parent_contact = "lead_parent_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: lk_contact_feedback_createdby, ReferencingAttribute: createdbycontact, ReferencingEntity: feedback, ReferencingEntityNavigationPropertyName: CreatedByContact, RelationshipBehavior: 1, SchemaName: lk_contact_feedback_createdby, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string lk_contact_feedback_createdby = "lk_contact_feedback_createdby";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: lk_contact_feedback_createdonbehalfby, ReferencingAttribute: createdonbehalfbycontact, ReferencingEntity: feedback, ReferencingEntityNavigationPropertyName: CreatedOnBehalfByContact, RelationshipBehavior: 1, SchemaName: lk_contact_feedback_createdonbehalfby, SecurityTypes: Append, IntroducedVersion: 8.2.0.0. </summary>
	public const string lk_contact_feedback_createdonbehalfby = "lk_contact_feedback_createdonbehalfby";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_dailycontactkpiitem_entityid, ReferencingAttribute: msdyn_entityid, ReferencingEntity: msdyn_dailycontactkpiitem, ReferencingEntityNavigationPropertyName: msdyn_entityid, RelationshipBehavior: 1, SchemaName: msdyn_contact_dailycontactkpiitem_entityid, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_contact_dailycontactkpiitem_entityid = "msdyn_contact_dailycontactkpiitem_entityid";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_actual_ContactCustomer, ReferencingAttribute: msdyn_contactcustomer, ReferencingEntity: msdyn_actual, ReferencingEntityNavigationPropertyName: msdyn_ContactCustomer, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_actual_ContactCustomer, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_contact_msdyn_actual_ContactCustomer = "msdyn_contact_msdyn_actual_ContactCustomer";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_actual_ContactVendor, ReferencingAttribute: msdyn_contactvendor, ReferencingEntity: msdyn_actual, ReferencingEntityNavigationPropertyName: msdyn_ContactVendor, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_actual_ContactVendor, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_contact_msdyn_actual_ContactVendor = "msdyn_contact_msdyn_actual_ContactVendor";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_contactkpiitem_contactid, ReferencingAttribute: msdyn_contactid, ReferencingEntity: msdyn_contactkpiitem, ReferencingEntityNavigationPropertyName: msdyn_contactid, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_contactkpiitem_contactid, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_contact_msdyn_contactkpiitem_contactid = "msdyn_contact_msdyn_contactkpiitem_contactid";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_liveconversation_Customer, ReferencingAttribute: msdyn_customer, ReferencingEntity: msdyn_liveconversation, ReferencingEntityNavigationPropertyName: msdyn_customer_msdyn_liveconversation_contact, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_liveconversation_Customer, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_contact_msdyn_liveconversation_Customer = "msdyn_contact_msdyn_liveconversation_Customer";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_mostcontacted_regardingObjectId, ReferencingAttribute: msdyn_contact_regardingobjectid, ReferencingEntity: msdyn_mostcontacted, ReferencingEntityNavigationPropertyName: msdyn_contact_regardingObjectId, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_mostcontacted_regardingObjectId, SecurityTypes: Append, IntroducedVersion: 9.0.0.0. </summary>
	public const string msdyn_contact_msdyn_mostcontacted_regardingObjectId = "msdyn_contact_msdyn_mostcontacted_regardingObjectId";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_mostcontactedby_regardingObjectId, ReferencingAttribute: msdyn_contact_regardingobjectid, ReferencingEntity: msdyn_mostcontactedby, ReferencingEntityNavigationPropertyName: msdyn_contact_regardingObjectId, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_mostcontactedby_regardingObjectId, SecurityTypes: Append, IntroducedVersion: 9.0.0.0. </summary>
	public const string msdyn_contact_msdyn_mostcontactedby_regardingObjectId = "msdyn_contact_msdyn_mostcontactedby_regardingObjectId";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_ocliveworkitem_Customer, ReferencingAttribute: msdyn_customer, ReferencingEntity: msdyn_ocliveworkitem, ReferencingEntityNavigationPropertyName: msdyn_customer_msdyn_ocliveworkitem_contact, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_ocliveworkitem_Customer, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_contact_msdyn_ocliveworkitem_Customer = "msdyn_contact_msdyn_ocliveworkitem_Customer";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_salesroutingrun_targetobject, ReferencingAttribute: msdyn_targetobject, ReferencingEntity: msdyn_salesroutingrun, ReferencingEntityNavigationPropertyName: msdyn_targetobject_contact, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_salesroutingrun_targetobject, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_contact_msdyn_salesroutingrun_targetobject = "msdyn_contact_msdyn_salesroutingrun_targetobject";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_contact_msdyn_salessuggestion, ReferencingAttribute: msdyn_sequencecontact, ReferencingEntity: msdyn_salessuggestion, ReferencingEntityNavigationPropertyName: msdyn_sequencecontact, RelationshipBehavior: 1, SchemaName: msdyn_contact_msdyn_salessuggestion, SecurityTypes: Append, IntroducedVersion: 9.0.0.0. </summary>
	public const string msdyn_contact_msdyn_salessuggestion = "msdyn_contact_msdyn_salessuggestion";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_linkeditemvalidity_polymorphic_contactid, ReferencingAttribute: msdyn_linkeditemlookup, ReferencingEntity: msdyn_linkedentityattributevalidity, ReferencingEntityNavigationPropertyName: msdyn_linkeditemlookup_contact, RelationshipBehavior: 1, SchemaName: msdyn_linkeditemvalidity_polymorphic_contactid, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_linkeditemvalidity_polymorphic_contactid = "msdyn_linkeditemvalidity_polymorphic_contactid";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_msdyn_conversationparticipantinsights_contact_msdyn_user, ReferencingAttribute: msdyn_user, ReferencingEntity: msdyn_conversationparticipantinsights, ReferencingEntityNavigationPropertyName: msdyn_user_contact, RelationshipBehavior: 1, SchemaName: msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User, SecurityTypes: Append, IntroducedVersion: 9.0.1.871. </summary>
	public const string msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User = "msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_msdyn_preferredagent_contact_msdyn_recordId, ReferencingAttribute: msdyn_recordid, ReferencingEntity: msdyn_preferredagent, ReferencingEntityNavigationPropertyName: msdyn_recordId_contact, RelationshipBehavior: 1, SchemaName: msdyn_msdyn_preferredagent_contact_msdyn_recordId, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_msdyn_preferredagent_contact_msdyn_recordId = "msdyn_msdyn_preferredagent_contact_msdyn_recordId";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid, ReferencingAttribute: msdyn_targetentityid, ReferencingEntity: msdyn_salescopilotinsight, ReferencingEntityNavigationPropertyName: msdyn_targetentityid_contact, RelationshipBehavior: 1, SchemaName: msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid, SecurityTypes: Append, IntroducedVersion: 1.0.0.1. </summary>
	public const string msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid = "msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid, ReferencingAttribute: msdyn_dynamicsrecordid, ReferencingEntity: msdyn_taggedrecord, ReferencingEntityNavigationPropertyName: msdyn_dynamicsrecordid_contact, RelationshipBehavior: 1, SchemaName: msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid = "msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_playbookinstance_contact, ReferencingAttribute: regarding, ReferencingEntity: msdyn_playbookinstance, ReferencingEntityNavigationPropertyName: regarding_contact, RelationshipBehavior: 1, SchemaName: msdyn_playbookinstance_contact, SecurityTypes: Append, IntroducedVersion: 9.0.0.0. </summary>
	public const string msdyn_playbookinstance_contact = "msdyn_playbookinstance_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_sabackupdiagnostic_contact_msdyn_target, ReferencingAttribute: msdyn_target, ReferencingEntity: msdyn_sabackupdiagnostic, ReferencingEntityNavigationPropertyName: msdyn_target, RelationshipBehavior: 1, SchemaName: msdyn_sabackupdiagnostic_contact_msdyn_target, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_sabackupdiagnostic_contact_msdyn_target = "msdyn_sabackupdiagnostic_contact_msdyn_target";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_salesroutingdiagnostic_contact_msdyn_target, ReferencingAttribute: msdyn_target, ReferencingEntity: msdyn_salesroutingdiagnostic, ReferencingEntityNavigationPropertyName: msdyn_target, RelationshipBehavior: 1, SchemaName: msdyn_salesroutingdiagnostic_contact_msdyn_target, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_salesroutingdiagnostic_contact_msdyn_target = "msdyn_salesroutingdiagnostic_contact_msdyn_target";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: msdyn_sequencetarget_contact_msdyn_target, ReferencingAttribute: msdyn_target, ReferencingEntity: msdyn_sequencetarget, ReferencingEntityNavigationPropertyName: msdyn_target, RelationshipBehavior: 1, SchemaName: msdyn_sequencetarget_contact_msdyn_target, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_sequencetarget_contact_msdyn_target = "msdyn_sequencetarget_contact_msdyn_target";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: opportunity_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: opportunity, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: opportunity_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string opportunity_customer_contacts = "opportunity_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: opportunity_parent_contact, ReferencingAttribute: parentcontactid, ReferencingEntity: opportunity, ReferencingEntityNavigationPropertyName: parentcontactid, RelationshipBehavior: 1, SchemaName: opportunity_parent_contact, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string opportunity_parent_contact = "opportunity_parent_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: order_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: salesorder, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: order_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string order_customer_contacts = "order_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: quote_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: quote, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: quote_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string quote_customer_contacts = "quote_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: slakpiinstance_contact, ReferencingAttribute: regarding, ReferencingEntity: slakpiinstance, ReferencingEntityNavigationPropertyName: regarding_contact, RelationshipBehavior: 1, SchemaName: slakpiinstance_contact, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string slakpiinstance_contact = "slakpiinstance_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: socialactivity_postauthor_contacts, ReferencingAttribute: postauthor, ReferencingEntity: socialactivity, ReferencingEntityNavigationPropertyName: postauthor_contact, RelationshipBehavior: 1, SchemaName: socialactivity_postauthor_contacts, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string socialactivity_postauthor_contacts = "socialactivity_postauthor_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: socialactivity_postauthoraccount_contacts, ReferencingAttribute: postauthoraccount, ReferencingEntity: socialactivity, ReferencingEntityNavigationPropertyName: postauthoraccount_contact, RelationshipBehavior: 1, SchemaName: socialactivity_postauthoraccount_contacts, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string socialactivity_postauthoraccount_contacts = "socialactivity_postauthoraccount_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: Socialprofile_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: socialprofile, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: Socialprofile_customer_contacts, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string Socialprofile_customer_contacts = "Socialprofile_customer_contacts";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: SourceContact_BulkOperationLogs, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkoperationlog, ReferencingEntityNavigationPropertyName: regardingobjectid_contact, RelationshipBehavior: 0, SchemaName: SourceContact_BulkOperationLogs, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string SourceContact_BulkOperationLogs = "SourceContact_BulkOperationLogs";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: userentityinstancedata_contact, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_contact, RelationshipBehavior: 0, SchemaName: userentityinstancedata_contact, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string userentityinstancedata_contact = "userentityinstancedata_contact";

}

