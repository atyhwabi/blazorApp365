namespace ECSM.Models.Dynamics;

/// <summary>Organizational knowledge for internal and external use.</summary>
public static partial class KnowledgeArticleOneToMany
{
	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: incident_knowledgearticles, ReferencingAttribute: knowledgearticleid, ReferencingEntity: knowledgearticleincident, ReferencingEntityNavigationPropertyName: knowledgearticleid, RelationshipBehavior: 2, SchemaName: incident_knowledgearticles, SecurityTypes: ParentChild, IntroducedVersion: 8.0.0.0. </summary>
	public const string incident_knowledgearticles = "incident_knowledgearticles";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_activity_parties, ReferencingAttribute: partyid, ReferencingEntity: activityparty, ReferencingEntityNavigationPropertyName: partyid_knowledgearticle, RelationshipBehavior: 1, SchemaName: knowledgearticle_activity_parties, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_activity_parties = "knowledgearticle_activity_parties";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_ActivityPointers, ReferencingAttribute: regardingobjectid, ReferencingEntity: activitypointer, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: KnowledgeArticle_ActivityPointers, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_ActivityPointers = "KnowledgeArticle_ActivityPointers";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_adx_inviteredemptions, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_inviteredemption, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_adx_inviteredemption, RelationshipBehavior: 1, SchemaName: knowledgearticle_adx_inviteredemptions, SecurityTypes: Append, IntroducedVersion: 1.0.2402.1. </summary>
	public const string knowledgearticle_adx_inviteredemptions = "knowledgearticle_adx_inviteredemptions";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_adx_portalcomments, ReferencingAttribute: regardingobjectid, ReferencingEntity: adx_portalcomment, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_adx_portalcomment, RelationshipBehavior: 1, SchemaName: knowledgearticle_adx_portalcomments, SecurityTypes: Append, IntroducedVersion: 1.0.2402.1. </summary>
	public const string knowledgearticle_adx_portalcomments = "knowledgearticle_adx_portalcomments";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_Annotations, ReferencingAttribute: objectid, ReferencingEntity: annotation, ReferencingEntityNavigationPropertyName: objectid_knowledgearticle, RelationshipBehavior: 1, SchemaName: knowledgearticle_Annotations, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_Annotations = "knowledgearticle_Annotations";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_Appointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: appointment, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_appointment, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_Appointments, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_Appointments = "KnowledgeArticle_Appointments";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_AsyncOperations, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_AsyncOperations = "knowledgearticle_AsyncOperations";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_BulkDeleteFailures = "knowledgearticle_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_BulkOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_bulkoperation, RelationshipBehavior: 1, SchemaName: knowledgearticle_BulkOperations, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_BulkOperations = "knowledgearticle_BulkOperations";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_CampaignResponses, ReferencingAttribute: regardingobjectid, ReferencingEntity: campaignresponse, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_campaignresponse, RelationshipBehavior: 1, SchemaName: knowledgearticle_CampaignResponses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_CampaignResponses = "knowledgearticle_CampaignResponses";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_chats, ReferencingAttribute: regardingobjectid, ReferencingEntity: chat, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_chat, RelationshipBehavior: 1, SchemaName: knowledgearticle_chats, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_chats = "knowledgearticle_chats";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_connections1, ReferencingAttribute: record1id, ReferencingEntity: connection, ReferencingEntityNavigationPropertyName: record1id_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_connections1, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_connections1 = "knowledgearticle_connections1";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_connections2, ReferencingAttribute: record2id, ReferencingEntity: connection, ReferencingEntityNavigationPropertyName: record2id_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_connections2, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_connections2 = "knowledgearticle_connections2";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_documentindex, ReferencingAttribute: documentid, ReferencingEntity: documentindex, ReferencingEntityNavigationPropertyName: knowledgearticle_documentindex, RelationshipBehavior: 1, SchemaName: knowledgearticle_documentindex, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_documentindex = "knowledgearticle_documentindex";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_DuplicateBaseRecord, ReferencingAttribute: baserecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: baserecordid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_DuplicateBaseRecord, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_DuplicateBaseRecord = "knowledgearticle_DuplicateBaseRecord";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_DuplicateMatchingRecord, ReferencingAttribute: duplicaterecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: duplicaterecordid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_DuplicateMatchingRecord, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_DuplicateMatchingRecord = "knowledgearticle_DuplicateMatchingRecord";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_Emails, ReferencingAttribute: regardingobjectid, ReferencingEntity: email, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_email, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_Emails, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_Emails = "KnowledgeArticle_Emails";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_Faxes, ReferencingAttribute: regardingobjectid, ReferencingEntity: fax, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_fax, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_Faxes, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_Faxes = "KnowledgeArticle_Faxes";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_Feedback, ReferencingAttribute: regardingobjectid, ReferencingEntity: feedback, ReferencingEntityNavigationPropertyName: KnowledgeArticleId, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_Feedback, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string KnowledgeArticle_Feedback = "KnowledgeArticle_Feedback";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_FileAttachments, ReferencingAttribute: objectid, ReferencingEntity: fileattachment, ReferencingEntityNavigationPropertyName: objectid_knowledgearticle, RelationshipBehavior: 2, SchemaName: knowledgearticle_FileAttachments, SecurityTypes: ParentChild, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_FileAttachments = "knowledgearticle_FileAttachments";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_incidentresolution, RelationshipBehavior: 1, SchemaName: knowledgearticle_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_IncidentResolutions = "knowledgearticle_IncidentResolutions";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_Letters, ReferencingAttribute: regardingobjectid, ReferencingEntity: letter, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_letter, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_Letters, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_Letters = "KnowledgeArticle_Letters";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_msdyn_bookingalerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_bookingalert, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_msdyn_bookingalert, RelationshipBehavior: 1, SchemaName: knowledgearticle_msdyn_bookingalerts, SecurityTypes: Append, IntroducedVersion: 3.12.0.448. </summary>
	public const string knowledgearticle_msdyn_bookingalerts = "knowledgearticle_msdyn_bookingalerts";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_msdyn_copilottranscripts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_copilottranscript, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_msdyn_copilottranscript, RelationshipBehavior: 1, SchemaName: knowledgearticle_msdyn_copilottranscripts, SecurityTypes: Append, IntroducedVersion: 9.1.24041.1048. </summary>
	public const string knowledgearticle_msdyn_copilottranscripts = "knowledgearticle_msdyn_copilottranscripts";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_msdyn_ocliveworkitems, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocliveworkitem, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_msdyn_ocliveworkitem, RelationshipBehavior: 1, SchemaName: knowledgearticle_msdyn_ocliveworkitems, SecurityTypes: Append, IntroducedVersion: 1.10.0.81. </summary>
	public const string knowledgearticle_msdyn_ocliveworkitems = "knowledgearticle_msdyn_ocliveworkitems";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_msdyn_ocsessions, ReferencingAttribute: regardingobjectid, ReferencingEntity: msdyn_ocsession, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_msdyn_ocsession, RelationshipBehavior: 1, SchemaName: knowledgearticle_msdyn_ocsessions, SecurityTypes: Append, IntroducedVersion: 1.10.0.81. </summary>
	public const string knowledgearticle_msdyn_ocsessions = "knowledgearticle_msdyn_ocsessions";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_msfp_alerts, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_alert, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_msfp_alert, RelationshipBehavior: 1, SchemaName: knowledgearticle_msfp_alerts, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string knowledgearticle_msfp_alerts = "knowledgearticle_msfp_alerts";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_msfp_surveyinvites, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyinvite, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_msfp_surveyinvite, RelationshipBehavior: 1, SchemaName: knowledgearticle_msfp_surveyinvites, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string knowledgearticle_msfp_surveyinvites = "knowledgearticle_msfp_surveyinvites";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_msfp_surveyresponses, ReferencingAttribute: regardingobjectid, ReferencingEntity: msfp_surveyresponse, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_msfp_surveyresponse, RelationshipBehavior: 1, SchemaName: knowledgearticle_msfp_surveyresponses, SecurityTypes: Append, IntroducedVersion: 2.0.0.45. </summary>
	public const string knowledgearticle_msfp_surveyresponses = "knowledgearticle_msfp_surveyresponses";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_OpportunityCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: opportunityclose, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_opportunityclose, RelationshipBehavior: 1, SchemaName: knowledgearticle_OpportunityCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_OpportunityCloses = "knowledgearticle_OpportunityCloses";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_OrderCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: orderclose, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_orderclose, RelationshipBehavior: 1, SchemaName: knowledgearticle_OrderCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_OrderCloses = "knowledgearticle_OrderCloses";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_parentarticle_contentid, ReferencingAttribute: parentarticlecontentid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: ParentArticleContentId, RelationshipBehavior: 1, SchemaName: knowledgearticle_parentarticle_contentid, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_parentarticle_contentid = "knowledgearticle_parentarticle_contentid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_Phonecalls, ReferencingAttribute: regardingobjectid, ReferencingEntity: phonecall, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_phonecall, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_Phonecalls, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_Phonecalls = "KnowledgeArticle_Phonecalls";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_PostFollows, ReferencingAttribute: regardingobjectid, ReferencingEntity: postfollow, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_PostFollows, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_PostFollows = "knowledgearticle_PostFollows";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_PostRegardings, ReferencingAttribute: regardingobjectid, ReferencingEntity: postregarding, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_PostRegardings, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_PostRegardings = "knowledgearticle_PostRegardings";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_PostRoles, ReferencingAttribute: regardingobjectid, ReferencingEntity: postrole, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_PostRoles, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_PostRoles = "knowledgearticle_PostRoles";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_Posts, ReferencingAttribute: regardingobjectid, ReferencingEntity: post, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_Posts, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string knowledgearticle_Posts = "knowledgearticle_Posts";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_previousarticle_contentid, ReferencingAttribute: previousarticlecontentid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: PreviousArticleContentId, RelationshipBehavior: 1, SchemaName: knowledgearticle_previousarticle_contentid, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_previousarticle_contentid = "knowledgearticle_previousarticle_contentid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_PrincipalObjectAttributeAccess, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_knowledgearticle, RelationshipBehavior: 1, SchemaName: knowledgearticle_PrincipalObjectAttributeAccess, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_PrincipalObjectAttributeAccess = "knowledgearticle_PrincipalObjectAttributeAccess";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_ProcessSession, ReferencingAttribute: regardingobjectid, ReferencingEntity: processsession, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_ProcessSession, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_ProcessSession = "knowledgearticle_ProcessSession";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_QueueItems, ReferencingAttribute: objectid, ReferencingEntity: queueitem, ReferencingEntityNavigationPropertyName: objectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_QueueItems, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_QueueItems = "knowledgearticle_QueueItems";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_QuoteCloses, ReferencingAttribute: regardingobjectid, ReferencingEntity: quoteclose, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_quoteclose, RelationshipBehavior: 1, SchemaName: knowledgearticle_QuoteCloses, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_QuoteCloses = "knowledgearticle_QuoteCloses";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_RecurringAppointmentMasters, ReferencingAttribute: regardingobjectid, ReferencingEntity: recurringappointmentmaster, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_recurringappointmentmaster, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_RecurringAppointmentMasters, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_RecurringAppointmentMasters = "KnowledgeArticle_RecurringAppointmentMasters";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_rootarticle_id, ReferencingAttribute: rootarticleid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: RootArticleId, RelationshipBehavior: 1, SchemaName: knowledgearticle_rootarticle_id, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_rootarticle_id = "knowledgearticle_rootarticle_id";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_ServiceAppointments, ReferencingAttribute: regardingobjectid, ReferencingEntity: serviceappointment, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_serviceappointment, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_ServiceAppointments, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string KnowledgeArticle_ServiceAppointments = "KnowledgeArticle_ServiceAppointments";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_SharePointDocumentLocations, ReferencingAttribute: regardingobjectid, ReferencingEntity: sharepointdocumentlocation, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_SharePointDocumentLocations, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_SharePointDocumentLocations = "knowledgearticle_SharePointDocumentLocations";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_SharePointDocuments, ReferencingAttribute: regardingobjectid, ReferencingEntity: sharepointdocument, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_SharePointDocuments, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_SharePointDocuments = "knowledgearticle_SharePointDocuments";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_SocialActivities, ReferencingAttribute: regardingobjectid, ReferencingEntity: socialactivity, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_socialactivity, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_SocialActivities, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_SocialActivities = "KnowledgeArticle_SocialActivities";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_syncerror, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_SyncErrors, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string KnowledgeArticle_SyncErrors = "KnowledgeArticle_SyncErrors";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: KnowledgeArticle_Tasks, ReferencingAttribute: regardingobjectid, ReferencingEntity: task, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_task, RelationshipBehavior: 1, SchemaName: KnowledgeArticle_Tasks, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string KnowledgeArticle_Tasks = "KnowledgeArticle_Tasks";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_Teams, ReferencingAttribute: regardingobjectid, ReferencingEntity: team, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_Teams, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_Teams = "knowledgearticle_Teams";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_UserEntityInstanceDatas, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_knowledgearticle, RelationshipBehavior: 0, SchemaName: knowledgearticle_UserEntityInstanceDatas, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_UserEntityInstanceDatas = "knowledgearticle_UserEntityInstanceDatas";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_views, ReferencingAttribute: knowledgearticleid, ReferencingEntity: knowledgearticleviews, ReferencingEntityNavigationPropertyName: knowledgearticleid, RelationshipBehavior: 0, SchemaName: knowledgearticle_views, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_views = "knowledgearticle_views";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_expiredprocess, ReferencingAttribute: knowledgearticleid, ReferencingEntity: expiredprocess, ReferencingEntityNavigationPropertyName: knowledgearticleid, RelationshipBehavior: 0, SchemaName: lk_expiredprocess_knowledgearticleid, SecurityTypes: None, IntroducedVersion: 8.2.0.0. </summary>
	public const string lk_expiredprocess_knowledgearticleid = "lk_expiredprocess_knowledgearticleid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_newprocess, ReferencingAttribute: knowledgearticleid, ReferencingEntity: newprocess, ReferencingEntityNavigationPropertyName: knowledgearticleid, RelationshipBehavior: 0, SchemaName: lk_newprocess_knowledgearticleid, SecurityTypes: None, IntroducedVersion: 8.2.0.0. </summary>
	public const string lk_newprocess_knowledgearticleid = "lk_newprocess_knowledgearticleid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_translationprocess, ReferencingAttribute: knowledgearticleid, ReferencingEntity: translationprocess, ReferencingEntityNavigationPropertyName: knowledgearticleid, RelationshipBehavior: 0, SchemaName: lk_translationprocess_knowledgearticleid, SecurityTypes: None, IntroducedVersion: 8.2.0.0. </summary>
	public const string lk_translationprocess_knowledgearticleid = "lk_translationprocess_knowledgearticleid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: msdyn_knowledgearticle_favoriteknowledgearticle, ReferencingAttribute: msdyn_knowledgearticleid, ReferencingEntity: msdyn_favoriteknowledgearticle, ReferencingEntityNavigationPropertyName: msdyn_knowledgearticleid, RelationshipBehavior: 1, SchemaName: msdyn_knowledgearticle_favoriteknowledgearticle, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_knowledgearticle_favoriteknowledgearticle = "msdyn_knowledgearticle_favoriteknowledgearticle";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: msdyn_knowledgearticle_feedback_context, ReferencingAttribute: msdyn_contextobjectid, ReferencingEntity: feedback, ReferencingEntityNavigationPropertyName: msdyn_ContextObjectId_knowledgearticle, RelationshipBehavior: 0, SchemaName: msdyn_knowledgearticle_feedback_context, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string msdyn_knowledgearticle_feedback_context = "msdyn_knowledgearticle_feedback_context";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: msdyn_knowledgearticle_msdyn_kbenrichment_kbid, ReferencingAttribute: msdyn_kbid, ReferencingEntity: msdyn_kbenrichment, ReferencingEntityNavigationPropertyName: msdyn_kbid, RelationshipBehavior: 1, SchemaName: msdyn_knowledgearticle_msdyn_kbenrichment_kbid, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_knowledgearticle_msdyn_kbenrichment_kbid = "msdyn_knowledgearticle_msdyn_kbenrichment_kbid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: msdyn_knowledgearticle_msdyn_knowledgearticlesuggestion_suggestedentity, ReferencingAttribute: msdyn_suggestedentity, ReferencingEntity: msdyn_knowledgearticlesuggestion, ReferencingEntityNavigationPropertyName: msdyn_suggestedentity, RelationshipBehavior: 1, SchemaName: msdyn_knowledgearticle_msdyn_knowledgearticlesuggestion_suggestedentity, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_knowledgearticle_msdyn_knowledgearticlesuggestion_suggestedentity = "msdyn_knowledgearticle_msdyn_knowledgearticlesuggestion_suggestedentity";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: msdyn_knowledgearticle_msdyn_suggestioninteraction_msdyn_suggestedentity, ReferencingAttribute: msdyn_suggestedentity, ReferencingEntity: msdyn_suggestioninteraction, ReferencingEntityNavigationPropertyName: msdyn_suggestedentity_knowledgearticle, RelationshipBehavior: 1, SchemaName: msdyn_knowledgearticle_msdyn_suggestioninteraction_msdyn_suggestedentity, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_knowledgearticle_msdyn_suggestioninteraction_msdyn_suggestedentity = "msdyn_knowledgearticle_msdyn_suggestioninteraction_msdyn_suggestedentity";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: msdyn_knowledgearticleimage_parentknowledgearticleid, ReferencingAttribute: msdyn_parentknowledgearticleid, ReferencingEntity: msdyn_knowledgearticleimage, ReferencingEntityNavigationPropertyName: msdyn_parentknowledgearticleid, RelationshipBehavior: 1, SchemaName: msdyn_knowledgearticleimage_parentknowledgearticleid, SecurityTypes: Append, IntroducedVersion: 9.0.0.0. </summary>
	public const string msdyn_knowledgearticleimage_parentknowledgearticleid = "msdyn_knowledgearticleimage_parentknowledgearticleid";

}

