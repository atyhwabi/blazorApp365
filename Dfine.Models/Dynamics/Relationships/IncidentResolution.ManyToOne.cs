namespace ECSM.Models.Dynamics;

/// <summary>Special type of activity that includes description of the resolution, billing status, and the duration of the case.</summary>
public static partial class IncidentResolutionManyToOne
{
	/// <summary>ReferencedAttribute: accountid, ReferencedEntity: account, ReferencedEntityNavigationPropertyName: account_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_account_incidentresolution, RelationshipBehavior: 1, SchemaName: account_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string account_IncidentResolutions = "regardingobjectid_account_incidentresolution";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: activitypointer, ReferencedEntityNavigationPropertyName: activity_pointer_incident_resolution, ReferencingAttribute: activityid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: activityid_activitypointer, RelationshipBehavior: 12, SchemaName: activity_pointer_incident_resolution, SecurityTypes: Pointer, IntroducedVersion: 6.0.0.0. </summary>
	public const string activity_pointer_incident_resolution = "activityid_activitypointer";

	/// <summary>ReferencedAttribute: adx_invitationid, ReferencedEntity: adx_invitation, ReferencedEntityNavigationPropertyName: adx_invitation_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_adx_invitation_incidentresolution, RelationshipBehavior: 1, SchemaName: adx_invitation_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string adx_invitation_IncidentResolutions = "regardingobjectid_adx_invitation_incidentresolution";

	/// <summary>ReferencedAttribute: bookableresourcebookingid, ReferencedEntity: bookableresourcebooking, ReferencedEntityNavigationPropertyName: bookableresourcebooking_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_bookableresourcebooking_incidentresolution, RelationshipBehavior: 1, SchemaName: bookableresourcebooking_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string bookableresourcebooking_IncidentResolutions = "regardingobjectid_bookableresourcebooking_incidentresolution";

	/// <summary>ReferencedAttribute: bookableresourcebookingheaderid, ReferencedEntity: bookableresourcebookingheader, ReferencedEntityNavigationPropertyName: bookableresourcebookingheader_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_bookableresourcebookingheader_incidentresolution, RelationshipBehavior: 1, SchemaName: bookableresourcebookingheader_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string bookableresourcebookingheader_IncidentResolutions = "regardingobjectid_bookableresourcebookingheader_incidentresolution";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: bulkoperation, ReferencedEntityNavigationPropertyName: bulkoperation_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_bulkoperation_incidentresolution, RelationshipBehavior: 1, SchemaName: bulkoperation_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string bulkoperation_IncidentResolutions = "regardingobjectid_bulkoperation_incidentresolution";

	/// <summary>ReferencedAttribute: businessunitid, ReferencedEntity: businessunit, ReferencedEntityNavigationPropertyName: business_unit_incident_resolution_activities, ReferencingAttribute: owningbusinessunit, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: owningbusinessunit_incidentresolution, RelationshipBehavior: 0, SchemaName: business_unit_incident_resolution_activities, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string business_unit_incident_resolution_activities = "owningbusinessunit_incidentresolution";

	/// <summary>ReferencedAttribute: campaignid, ReferencedEntity: campaign, ReferencedEntityNavigationPropertyName: campaign_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_campaign_incidentresolution, RelationshipBehavior: 1, SchemaName: campaign_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string campaign_IncidentResolutions = "regardingobjectid_campaign_incidentresolution";

	/// <summary>ReferencedAttribute: activityid, ReferencedEntity: campaignactivity, ReferencedEntityNavigationPropertyName: campaignactivity_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_campaignactivity_incidentresolution, RelationshipBehavior: 1, SchemaName: campaignactivity_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string campaignactivity_IncidentResolutions = "regardingobjectid_campaignactivity_incidentresolution";

	/// <summary>ReferencedAttribute: entitlementid, ReferencedEntity: entitlement, ReferencedEntityNavigationPropertyName: entitlement_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_entitlement_incidentresolution, RelationshipBehavior: 1, SchemaName: entitlement_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string entitlement_IncidentResolutions = "regardingobjectid_entitlement_incidentresolution";

	/// <summary>ReferencedAttribute: entitlementtemplateid, ReferencedEntity: entitlementtemplate, ReferencedEntityNavigationPropertyName: entitlementtemplate_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_entitlementtemplate_incidentresolution, RelationshipBehavior: 1, SchemaName: entitlementtemplate_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string entitlementtemplate_IncidentResolutions = "regardingobjectid_entitlementtemplate_incidentresolution";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: Incident_IncidentResolutions, ReferencingAttribute: incidentid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: incidentid, RelationshipBehavior: 1, SchemaName: Incident_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string Incident_IncidentResolutions = "incidentid";

	/// <summary>ReferencedAttribute: mailboxid, ReferencedEntity: mailbox, ReferencedEntityNavigationPropertyName: incidentresolution_mailbox_sendermailboxid, ReferencingAttribute: sendermailboxid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: sendermailboxid_incidentresolution, RelationshipBehavior: 0, SchemaName: incidentresolution_mailbox_sendermailboxid, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string incidentresolution_mailbox_sendermailboxid = "sendermailboxid_incidentresolution";

	/// <summary>ReferencedAttribute: ownerid, ReferencedEntity: owner, ReferencedEntityNavigationPropertyName: incidentresolution_owner_ownerid, ReferencingAttribute: ownerid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: ownerid_incidentresolution, RelationshipBehavior: 0, SchemaName: incidentresolution_owner_ownerid, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string incidentresolution_owner_ownerid = "ownerid_incidentresolution";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: incidentresolution_sla_slaid, ReferencingAttribute: slaid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: sla_activitypointer_sla_incidentresolution, RelationshipBehavior: 1, SchemaName: incidentresolution_sla_slaid, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string incidentresolution_sla_slaid = "sla_activitypointer_sla_incidentresolution";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: incidentresolution_sla_slainvokedid, ReferencingAttribute: slainvokedid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: slainvokedid_activitypointer_sla_incidentresolution, RelationshipBehavior: 1, SchemaName: incidentresolution_sla_slainvokedid, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string incidentresolution_sla_slainvokedid = "slainvokedid_activitypointer_sla_incidentresolution";

	/// <summary>ReferencedAttribute: transactioncurrencyid, ReferencedEntity: transactioncurrency, ReferencedEntityNavigationPropertyName: incidentresolution_transactioncurrency_transactioncurrencyid, ReferencingAttribute: transactioncurrencyid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: transactioncurrencyid_incidentresolution, RelationshipBehavior: 0, SchemaName: incidentresolution_transactioncurrency_transactioncurrencyid, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string incidentresolution_transactioncurrency_transactioncurrencyid = "transactioncurrencyid_incidentresolution";

	/// <summary>ReferencedAttribute: interactionforemailid, ReferencedEntity: interactionforemail, ReferencedEntityNavigationPropertyName: interactionforemail_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_new_interactionforemail_incidentresolution, RelationshipBehavior: 1, SchemaName: interactionforemail_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string interactionforemail_IncidentResolutions = "regardingobjectid_new_interactionforemail_incidentresolution";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgearticle_incidentresolution, RelationshipBehavior: 1, SchemaName: knowledgearticle_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgearticle_IncidentResolutions = "regardingobjectid_knowledgearticle_incidentresolution";

	/// <summary>ReferencedAttribute: knowledgebaserecordid, ReferencedEntity: knowledgebaserecord, ReferencedEntityNavigationPropertyName: knowledgebaserecord_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_knowledgebaserecord_incidentresolution, RelationshipBehavior: 1, SchemaName: knowledgebaserecord_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string knowledgebaserecord_IncidentResolutions = "regardingobjectid_knowledgebaserecord_incidentresolution";

	/// <summary>ReferencedAttribute: leadid, ReferencedEntity: lead, ReferencedEntityNavigationPropertyName: lead_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_lead_incidentresolution, RelationshipBehavior: 1, SchemaName: lead_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string lead_IncidentResolutions = "regardingobjectid_lead_incidentresolution";

	/// <summary>ReferencedAttribute: externalpartyid, ReferencedEntity: externalparty, ReferencedEntityNavigationPropertyName: lk_externalparty_incidentresolution_createdby, ReferencingAttribute: createdbyexternalparty, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: CreatedByExternalParty, RelationshipBehavior: 0, SchemaName: lk_externalparty_incidentresolution_createdby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_externalparty_incidentresolution_createdby = "CreatedByExternalParty";

	/// <summary>ReferencedAttribute: externalpartyid, ReferencedEntity: externalparty, ReferencedEntityNavigationPropertyName: lk_externalparty_incidentresolution_modifiedby, ReferencingAttribute: modifiedbyexternalparty, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: ModifiedByExternalParty, RelationshipBehavior: 0, SchemaName: lk_externalparty_incidentresolution_modifiedby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_externalparty_incidentresolution_modifiedby = "ModifiedByExternalParty";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentresolution_createdby, ReferencingAttribute: createdby, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: createdby_incidentresolution, RelationshipBehavior: 0, SchemaName: lk_incidentresolution_createdby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_incidentresolution_createdby = "createdby_incidentresolution";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentresolution_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: createdonbehalfby_incidentresolution, RelationshipBehavior: 0, SchemaName: lk_incidentresolution_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_incidentresolution_createdonbehalfby = "createdonbehalfby_incidentresolution";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentresolution_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: modifiedby_incidentresolution, RelationshipBehavior: 0, SchemaName: lk_incidentresolution_modifiedby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_incidentresolution_modifiedby = "modifiedby_incidentresolution";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentresolution_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: modifiedonbehalfby_incidentresolution, RelationshipBehavior: 0, SchemaName: lk_incidentresolution_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_incidentresolution_modifiedonbehalfby = "modifiedonbehalfby_incidentresolution";

	/// <summary>ReferencedAttribute: mspp_adplacementid, ReferencedEntity: mspp_adplacement, ReferencedEntityNavigationPropertyName: mspp_adplacement_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_mspp_adplacement_incidentresolution, RelationshipBehavior: 1, SchemaName: mspp_adplacement_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string mspp_adplacement_IncidentResolutions = "regardingobjectid_mspp_adplacement_incidentresolution";

	/// <summary>ReferencedAttribute: mspp_pollplacementid, ReferencedEntity: mspp_pollplacement, ReferencedEntityNavigationPropertyName: mspp_pollplacement_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_mspp_pollplacement_incidentresolution, RelationshipBehavior: 1, SchemaName: mspp_pollplacement_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string mspp_pollplacement_IncidentResolutions = "regardingobjectid_mspp_pollplacement_incidentresolution";

	/// <summary>ReferencedAttribute: mspp_publishingstatetransitionruleid, ReferencedEntity: mspp_publishingstatetransitionrule, ReferencedEntityNavigationPropertyName: mspp_publishingstatetransitionrule_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_mspp_publishingstatetransitionrule_incidentresolution, RelationshipBehavior: 1, SchemaName: mspp_publishingstatetransitionrule_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string mspp_publishingstatetransitionrule_IncidentResolutions = "regardingobjectid_mspp_publishingstatetransitionrule_incidentresolution";

	/// <summary>ReferencedAttribute: mspp_redirectid, ReferencedEntity: mspp_redirect, ReferencedEntityNavigationPropertyName: mspp_redirect_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_mspp_redirect_incidentresolution, RelationshipBehavior: 1, SchemaName: mspp_redirect_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string mspp_redirect_IncidentResolutions = "regardingobjectid_mspp_redirect_incidentresolution";

	/// <summary>ReferencedAttribute: mspp_shortcutid, ReferencedEntity: mspp_shortcut, ReferencedEntityNavigationPropertyName: mspp_shortcut_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_mspp_shortcut_incidentresolution, RelationshipBehavior: 1, SchemaName: mspp_shortcut_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string mspp_shortcut_IncidentResolutions = "regardingobjectid_mspp_shortcut_incidentresolution";

	/// <summary>ReferencedAttribute: mspp_websiteid, ReferencedEntity: mspp_website, ReferencedEntityNavigationPropertyName: mspp_website_IncidentResolutions, ReferencingAttribute: regardingobjectid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: regardingobjectid_mspp_website_incidentresolution, RelationshipBehavior: 1, SchemaName: mspp_website_IncidentResolutions, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string mspp_website_IncidentResolutions = "regardingobjectid_mspp_website_incidentresolution";

	/// <summary>ReferencedAttribute: serviceid, ReferencedEntity: service, ReferencedEntityNavigationPropertyName: service_incidentresolutions, ReferencingAttribute: serviceid, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: serviceid_incidentresolution, RelationshipBehavior: 0, SchemaName: service_incidentresolutions, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string service_incidentresolutions = "serviceid_incidentresolution";

	/// <summary>ReferencedAttribute: teamid, ReferencedEntity: team, ReferencedEntityNavigationPropertyName: team_incidentresolution, ReferencingAttribute: owningteam, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: owningteam_incidentresolution, RelationshipBehavior: 0, SchemaName: team_incidentresolution, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string team_incidentresolution = "owningteam_incidentresolution";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: user_incidentresolution, ReferencingAttribute: owninguser, ReferencingEntity: incidentresolution, ReferencingEntityNavigationPropertyName: owninguser_incidentresolution, RelationshipBehavior: 0, SchemaName: user_incidentresolution, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string user_incidentresolution = "owninguser_incidentresolution";

}

