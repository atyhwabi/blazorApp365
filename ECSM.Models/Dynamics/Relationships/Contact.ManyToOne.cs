namespace ECSM.Models.Dynamics;

/// <summary>Person with whom a business unit has a relationship, such as customer, supplier, and colleague.</summary>
public static partial class ContactManyToOne
{
	/// <summary>ReferencedAttribute: businessunitid, ReferencedEntity: businessunit, ReferencedEntityNavigationPropertyName: business_unit_contacts, ReferencingAttribute: owningbusinessunit, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: owningbusinessunit, RelationshipBehavior: 0, SchemaName: business_unit_contacts, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string business_unit_contacts = "owningbusinessunit";

	/// <summary>ReferencedAttribute: accountid, ReferencedEntity: account, ReferencedEntityNavigationPropertyName: contact_customer_accounts, ReferencingAttribute: parentcustomerid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: parentcustomerid_account, RelationshipBehavior: 1, SchemaName: contact_customer_accounts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_customer_accounts = "parentcustomerid_account";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_customer_contacts, ReferencingAttribute: parentcustomerid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: parentcustomerid_contact, RelationshipBehavior: 1, SchemaName: contact_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_customer_contacts = "parentcustomerid_contact";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_master_contact, ReferencingAttribute: masterid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: masterid, RelationshipBehavior: 1, SchemaName: contact_master_contact, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_master_contact = "masterid";

	/// <summary>ReferencedAttribute: leadid, ReferencedEntity: lead, ReferencedEntityNavigationPropertyName: contact_originating_lead, ReferencingAttribute: originatingleadid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: originatingleadid, RelationshipBehavior: 1, SchemaName: contact_originating_lead, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_originating_lead = "originatingleadid";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: contact_owning_user, ReferencingAttribute: owninguser, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: owninguser, RelationshipBehavior: 0, SchemaName: contact_owning_user, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_owning_user = "owninguser";

	/// <summary>ReferencedAttribute: equipmentid, ReferencedEntity: equipment, ReferencedEntityNavigationPropertyName: equipment_contacts, ReferencingAttribute: preferredequipmentid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: preferredequipmentid, RelationshipBehavior: 1, SchemaName: equipment_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string equipment_contacts = "preferredequipmentid";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_contact_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_contact_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_contact_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: imagedescriptorid, ReferencedEntity: imagedescriptor, ReferencedEntityNavigationPropertyName: lk_contact_entityimage, ReferencingAttribute: entityimageid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: entityimageid_imagedescriptor, RelationshipBehavior: 0, SchemaName: lk_contact_entityimage, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_contact_entityimage = "entityimageid_imagedescriptor";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_contact_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_contact_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_contact_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_contactbase_createdby, ReferencingAttribute: createdby, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_contactbase_createdby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_contactbase_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_contactbase_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_contactbase_modifiedby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_contactbase_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: externalpartyid, ReferencedEntity: externalparty, ReferencedEntityNavigationPropertyName: lk_externalparty_contact_createdby, ReferencingAttribute: createdbyexternalparty, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: CreatedByExternalParty, RelationshipBehavior: 0, SchemaName: lk_externalparty_contact_createdby, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string lk_externalparty_contact_createdby = "CreatedByExternalParty";

	/// <summary>ReferencedAttribute: externalpartyid, ReferencedEntity: externalparty, ReferencedEntityNavigationPropertyName: lk_externalparty_contact_modifiedby, ReferencingAttribute: modifiedbyexternalparty, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: ModifiedByExternalParty, RelationshipBehavior: 0, SchemaName: lk_externalparty_contact_modifiedby, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string lk_externalparty_contact_modifiedby = "ModifiedByExternalParty";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: manualsla_contact, ReferencingAttribute: slaid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: sla_contact_sla, RelationshipBehavior: 1, SchemaName: manualsla_contact, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string manualsla_contact = "sla_contact_sla";

	/// <summary>ReferencedAttribute: accountid, ReferencedEntity: account, ReferencedEntityNavigationPropertyName: msa_contact_managingpartner, ReferencingAttribute: msa_managingpartnerid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: msa_managingpartnerid, RelationshipBehavior: 1, SchemaName: msa_contact_managingpartner, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msa_contact_managingpartner = "msa_managingpartnerid";

	/// <summary>ReferencedAttribute: msdyn_contactkpiitemid, ReferencedEntity: msdyn_contactkpiitem, ReferencedEntityNavigationPropertyName: msdyn_msdyn_contactkpiitem_contact_contactkpiid, ReferencingAttribute: msdyn_contactkpiid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: msdyn_contactkpiid, RelationshipBehavior: 1, SchemaName: msdyn_msdyn_contactkpiitem_contact_contactkpiid, SecurityTypes: Append, IntroducedVersion: 1.0. </summary>
	public const string msdyn_msdyn_contactkpiitem_contact_contactkpiid = "msdyn_contactkpiid";

	/// <summary>ReferencedAttribute: ownerid, ReferencedEntity: owner, ReferencedEntityNavigationPropertyName: owner_contacts, ReferencingAttribute: ownerid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: ownerid, RelationshipBehavior: 0, SchemaName: owner_contacts, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string owner_contacts = "ownerid";

	/// <summary>ReferencedAttribute: pricelevelid, ReferencedEntity: pricelevel, ReferencedEntityNavigationPropertyName: price_level_contacts, ReferencingAttribute: defaultpricelevelid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: defaultpricelevelid, RelationshipBehavior: 1, SchemaName: price_level_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string price_level_contacts = "defaultpricelevelid";

	/// <summary>ReferencedAttribute: processstageid, ReferencedEntity: processstage, ReferencedEntityNavigationPropertyName: processstage_contact, ReferencingAttribute: stageid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: stageid_processstage, RelationshipBehavior: 2, SchemaName: processstage_contact, SecurityTypes: ParentChild, IntroducedVersion: 6.0.0.0. </summary>
	public const string processstage_contact = "stageid_processstage";

	/// <summary>ReferencedAttribute: serviceid, ReferencedEntity: service, ReferencedEntityNavigationPropertyName: service_contacts, ReferencingAttribute: preferredserviceid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: preferredserviceid, RelationshipBehavior: 1, SchemaName: service_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string service_contacts = "preferredserviceid";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: sla_contact, ReferencingAttribute: slainvokedid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: slainvokedid_contact_sla, RelationshipBehavior: 1, SchemaName: sla_contact, SecurityTypes: Append, IntroducedVersion: 8.1.0.0. </summary>
	public const string sla_contact = "slainvokedid_contact_sla";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: system_user_contacts, ReferencingAttribute: preferredsystemuserid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: preferredsystemuserid, RelationshipBehavior: 1, SchemaName: system_user_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string system_user_contacts = "preferredsystemuserid";

	/// <summary>ReferencedAttribute: teamid, ReferencedEntity: team, ReferencedEntityNavigationPropertyName: team_contacts, ReferencingAttribute: owningteam, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: owningteam, RelationshipBehavior: 0, SchemaName: team_contacts, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string team_contacts = "owningteam";

	/// <summary>ReferencedAttribute: transactioncurrencyid, ReferencedEntity: transactioncurrency, ReferencedEntityNavigationPropertyName: transactioncurrency_contact, ReferencingAttribute: transactioncurrencyid, ReferencingEntity: contact, ReferencingEntityNavigationPropertyName: transactioncurrencyid, RelationshipBehavior: 0, SchemaName: transactioncurrency_contact, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string transactioncurrency_contact = "transactioncurrencyid";

}

