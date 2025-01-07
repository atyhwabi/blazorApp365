namespace ECSM.Models.Dynamics;

/// <summary>Person with whom a business unit has a relationship, such as customer, supplier, and colleague.</summary>
public static partial class ContactManyToMany
{
	/// <summary>Entity1IntersectAttribute: adx_invitationid, Entity1LogicalName: adx_invitation, Entity1NavigationPropertyName: adx_invitation_invitecontacts, Entity2IntersectAttribute: contactid, Entity2LogicalName: contact, Entity2NavigationPropertyName: adx_invitation_invitecontacts, IntersectEntityName: adx_invitation_invitecontacts, SchemaName: adx_invitation_invitecontacts, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_invitation_invitecontacts = "adx_invitation_invitecontacts";

	/// <summary>Entity1IntersectAttribute: adx_invitationid, Entity1LogicalName: adx_invitation, Entity1NavigationPropertyName: adx_invitation_redeemedcontacts, Entity2IntersectAttribute: contactid, Entity2LogicalName: contact, Entity2NavigationPropertyName: adx_invitation_redeemedcontacts, IntersectEntityName: adx_invitation_redeemedcontacts, SchemaName: adx_invitation_redeemedcontacts, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_invitation_redeemedcontacts = "adx_invitation_redeemedcontacts";

	/// <summary>Entity1IntersectAttribute: bulkoperationid, Entity1LogicalName: bulkoperation, Entity1NavigationPropertyName: BulkOperation_Contacts, Entity2IntersectAttribute: regardingobjectid, Entity2LogicalName: contact, Entity2NavigationPropertyName: BulkOperation_Logs_Contacts, IntersectEntityName: bulkoperationlog, SchemaName: BulkOperation_Contacts, SecurityTypes: ParentChild, IntroducedVersion: 9.0.0.0. </summary>
	public const string BulkOperation_Contacts = "BulkOperation_Contacts";

	/// <summary>Entity1IntersectAttribute: campaignactivityid, Entity1LogicalName: campaignactivity, Entity1NavigationPropertyName: CampaignActivity_Contacts, Entity2IntersectAttribute: regardingobjectid, Entity2LogicalName: contact, Entity2NavigationPropertyName: CampaignActivity_Logs_Contacts, IntersectEntityName: bulkoperationlog, SchemaName: CampaignActivity_Contacts, SecurityTypes: Pointer, IntroducedVersion: 9.0.0.0. </summary>
	public const string CampaignActivity_Contacts = "CampaignActivity_Contacts";

	/// <summary>Entity1IntersectAttribute: subscriptionid, Entity1LogicalName: subscription, Entity1NavigationPropertyName: contact_subscription_association, Entity2IntersectAttribute: objectid, Entity2LogicalName: contact, Entity2NavigationPropertyName: contact_subscription_association, IntersectEntityName: subscriptionmanuallytrackedobject, SchemaName: contact_subscription_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_subscription_association = "contact_subscription_association";

	/// <summary>Entity1IntersectAttribute: invoiceid, Entity1LogicalName: invoice, Entity1NavigationPropertyName: contactinvoices_association, Entity2IntersectAttribute: contactid, Entity2LogicalName: contact, Entity2NavigationPropertyName: contactinvoices_association, IntersectEntityName: contactinvoices, SchemaName: contactinvoices_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contactinvoices_association = "contactinvoices_association";

	/// <summary>Entity1IntersectAttribute: contactid, Entity1LogicalName: contact, Entity1NavigationPropertyName: contactleads_association, Entity2IntersectAttribute: leadid, Entity2LogicalName: lead, Entity2NavigationPropertyName: contactleads_association, IntersectEntityName: contactleads, SchemaName: contactleads_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contactleads_association = "contactleads_association";

	/// <summary>Entity1IntersectAttribute: salesorderid, Entity1LogicalName: salesorder, Entity1NavigationPropertyName: contactorders_association, Entity2IntersectAttribute: contactid, Entity2LogicalName: contact, Entity2NavigationPropertyName: contactorders_association, IntersectEntityName: contactorders, SchemaName: contactorders_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contactorders_association = "contactorders_association";

	/// <summary>Entity1IntersectAttribute: quoteid, Entity1LogicalName: quote, Entity1NavigationPropertyName: contactquotes_association, Entity2IntersectAttribute: contactid, Entity2LogicalName: contact, Entity2NavigationPropertyName: contactquotes_association, IntersectEntityName: contactquotes, SchemaName: contactquotes_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contactquotes_association = "contactquotes_association";

	/// <summary>Entity1IntersectAttribute: contactid, Entity1LogicalName: contact, Entity1NavigationPropertyName: ecsm_portal_role_Contact_Contact, Entity2IntersectAttribute: ecsm_portal_roleid, Entity2LogicalName: ecsm_portal_role, Entity2NavigationPropertyName: ecsm_portal_role_Contact_Contact, IntersectEntityName: ecsm_portal_role_contact, SchemaName: ecsm_portal_role_Contact_Contact, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_role_Contact_Contact = "ecsm_portal_role_Contact_Contact";

	/// <summary>Entity1IntersectAttribute: contactid, Entity1LogicalName: contact, Entity1NavigationPropertyName: entitlementcontacts_association, Entity2IntersectAttribute: entitlementid, Entity2LogicalName: entitlement, Entity2NavigationPropertyName: entitlementcontacts_association, IntersectEntityName: entitlementcontacts, SchemaName: entitlementcontacts_association, SecurityTypes: None, IntroducedVersion: 6.1.0.0. </summary>
	public const string entitlementcontacts_association = "entitlementcontacts_association";

	/// <summary>Entity1IntersectAttribute: listid, Entity1LogicalName: list, Entity1NavigationPropertyName: listcontact_association, Entity2IntersectAttribute: entityid, Entity2LogicalName: contact, Entity2NavigationPropertyName: listcontact_association, IntersectEntityName: listmember, SchemaName: listcontact_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string listcontact_association = "listcontact_association";

	/// <summary>Entity1IntersectAttribute: powerpagecomponentid, Entity1LogicalName: powerpagecomponent, Entity1NavigationPropertyName: powerpagecomponent_mspp_webrole_contact, Entity2IntersectAttribute: contactid, Entity2LogicalName: contact, Entity2NavigationPropertyName: powerpagecomponent_mspp_webrole_contact, IntersectEntityName: powerpagecomponent_mspp_webrole_contact, SchemaName: powerpagecomponent_mspp_webrole_contact, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string powerpagecomponent_mspp_webrole_contact = "powerpagecomponent_mspp_webrole_contact";

	/// <summary>Entity1IntersectAttribute: contactid, Entity1LogicalName: contact, Entity1NavigationPropertyName: servicecontractcontacts_association, Entity2IntersectAttribute: contractid, Entity2LogicalName: contract, Entity2NavigationPropertyName: servicecontractcontacts_association, IntersectEntityName: servicecontractcontacts, SchemaName: servicecontractcontacts_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string servicecontractcontacts_association = "servicecontractcontacts_association";

}

