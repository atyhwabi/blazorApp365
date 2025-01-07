namespace ECSM.Models.Dynamics;

/// <summary>Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.</summary>
public static partial class SystemUserManyToOne
{
	/// <summary>ReferencedAttribute: businessunitid, ReferencedEntity: businessunit, ReferencedEntityNavigationPropertyName: business_unit_system_users, ReferencingAttribute: businessunitid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: businessunitid, RelationshipBehavior: 0, SchemaName: business_unit_system_users, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string business_unit_system_users = "businessunitid";

	/// <summary>ReferencedAttribute: calendarid, ReferencedEntity: calendar, ReferencedEntityNavigationPropertyName: calendar_system_users, ReferencingAttribute: calendarid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: calendarid, RelationshipBehavior: 1, SchemaName: calendar_system_users, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string calendar_system_users = "calendarid";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_systemuser_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_systemuser_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_systemuser_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: imagedescriptorid, ReferencedEntity: imagedescriptor, ReferencedEntityNavigationPropertyName: lk_systemuser_entityimage, ReferencingAttribute: entityimageid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: entityimageid_imagedescriptor, RelationshipBehavior: 0, SchemaName: lk_systemuser_entityimage, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_systemuser_entityimage = "entityimageid_imagedescriptor";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_systemuser_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_systemuser_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_systemuser_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_systemuserbase_createdby, ReferencingAttribute: createdby, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_systemuserbase_createdby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_systemuserbase_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_systemuserbase_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_systemuserbase_modifiedby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_systemuserbase_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: mobileofflineprofileid, ReferencedEntity: mobileofflineprofile, ReferencedEntityNavigationPropertyName: MobileOfflineProfile_SystemUser, ReferencingAttribute: mobileofflineprofileid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: mobileofflineprofileid, RelationshipBehavior: 2, SchemaName: MobileOfflineProfile_SystemUser, SecurityTypes: ParentChild, IntroducedVersion: 8.0.0.0. </summary>
	public const string MobileOfflineProfile_SystemUser = "mobileofflineprofileid";

	/// <summary>ReferencedAttribute: msdyn_presenceid, ReferencedEntity: msdyn_presence, ReferencedEntityNavigationPropertyName: msdyn_msdyn_presence_systemuser, ReferencingAttribute: msdyn_defaultpresenceiduser, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: msdyn_DefaultPresenceIdUser, RelationshipBehavior: 1, SchemaName: msdyn_msdyn_presence_systemuser, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_msdyn_presence_systemuser = "msdyn_DefaultPresenceIdUser";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_system_users, ReferencingAttribute: organizationid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: organizationid_organization, RelationshipBehavior: 0, SchemaName: organization_system_users, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string organization_system_users = "organizationid_organization";

	/// <summary>ReferencedAttribute: positionid, ReferencedEntity: position, ReferencedEntityNavigationPropertyName: position_users, ReferencingAttribute: positionid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: positionid, RelationshipBehavior: 1, SchemaName: position_users, SecurityTypes: Append, IntroducedVersion: 7.0.0.0. </summary>
	public const string position_users = "positionid";

	/// <summary>ReferencedAttribute: processstageid, ReferencedEntity: processstage, ReferencedEntityNavigationPropertyName: processstage_systemusers, ReferencingAttribute: stageid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: stageid_processstage, RelationshipBehavior: 0, SchemaName: processstage_systemusers, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string processstage_systemusers = "stageid_processstage";

	/// <summary>ReferencedAttribute: queueid, ReferencedEntity: queue, ReferencedEntityNavigationPropertyName: queue_system_user, ReferencingAttribute: queueid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: queueid, RelationshipBehavior: 1, SchemaName: queue_system_user, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string queue_system_user = "queueid";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: site_system_users, ReferencingAttribute: siteid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: siteid, RelationshipBehavior: 1, SchemaName: site_system_users, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string site_system_users = "siteid";

	/// <summary>ReferencedAttribute: mailboxid, ReferencedEntity: mailbox, ReferencedEntityNavigationPropertyName: systemuser_defaultmailbox_mailbox, ReferencingAttribute: defaultmailbox, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: defaultmailbox, RelationshipBehavior: 1, SchemaName: systemuser_defaultmailbox_mailbox, SecurityTypes: Append, IntroducedVersion: 6.0.0.0. </summary>
	public const string systemuser_defaultmailbox_mailbox = "defaultmailbox";

	/// <summary>ReferencedAttribute: territoryid, ReferencedEntity: territory, ReferencedEntityNavigationPropertyName: territory_system_users, ReferencingAttribute: territoryid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: territoryid, RelationshipBehavior: 1, SchemaName: territory_system_users, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string territory_system_users = "territoryid";

	/// <summary>ReferencedAttribute: transactioncurrencyid, ReferencedEntity: transactioncurrency, ReferencedEntityNavigationPropertyName: TransactionCurrency_SystemUser, ReferencingAttribute: transactioncurrencyid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: transactioncurrencyid, RelationshipBehavior: 0, SchemaName: TransactionCurrency_SystemUser, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string TransactionCurrency_SystemUser = "transactioncurrencyid";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: user_parent_user, ReferencingAttribute: parentsystemuserid, ReferencingEntity: systemuser, ReferencingEntityNavigationPropertyName: parentsystemuserid, RelationshipBehavior: 0, SchemaName: user_parent_user, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string user_parent_user = "parentsystemuserid";

}

