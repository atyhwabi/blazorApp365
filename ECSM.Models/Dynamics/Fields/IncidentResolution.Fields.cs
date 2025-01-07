namespace ECSM.Models.Dynamics;

/// <summary>Special type of activity that includes description of the resolution, billing status, and the duration of the case.</summary>
public static partial class IncidentResolutionField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "activityid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "subject";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "IncidentResolutions";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "incidentresolutions";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "incidentresolutions";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "incidentresolution";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "IncidentResolution";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Activity Additional Parameters, Format: TextArea, MaxLength: 8192, SchemaName: ActivityAdditionalParams, IntroducedVersion: 7.1.0.0.  Description: Additional information provided by the external application as JSON. For internal use only.</summary>
	public const string ActivityAdditionalParams = "activityadditionalparams";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Case Resolution, SchemaName: ActivityId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case resolution activity.</summary>
	public const string ActivityId = "activityid";

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, DisplayName: Activity Type, SchemaName: ActivityTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of activity.</summary>
	public const string ActivityTypeCode = "activitytypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: activitytypecode, SchemaName: ActivityTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ActivityTypeCodeName = "activitytypecodename";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Actual Duration, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: ActualDurationMinutes, IntroducedVersion: 5.0.0.0.  Description: Actual duration of the case resolution activity in minutes.</summary>
	public const string ActualDurationMinutes = "actualdurationminutes";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Actual End, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ActualEnd, IntroducedVersion: 5.0.0.0.  Description: Actual end time of the case resolution activity.</summary>
	public const string ActualEnd = "actualend";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Actual Start, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ActualStart, IntroducedVersion: 5.0.0.0.  Description: Actual start time of the case resolution activity.</summary>
	public const string ActualStart = "actualstart";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: BCC, Format: None, SchemaName: BCC, IntroducedVersion: 5.0.0.0.  Description: Blind Carbon-copy (bcc) recipients of the activity.</summary>
	public const string BCC = "bcc";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Category, Format: Text, MaxLength: 250, SchemaName: Category, IntroducedVersion: 5.0.0.0.  Description: Category for the case resolution activity.</summary>
	public const string Category = "category";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: CC, Format: None, SchemaName: CC, IntroducedVersion: 5.0.0.0.  Description: Carbon-copy (cc) recipients of the activity.</summary>
	public const string CC = "cc";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Social Channel, SchemaName: Community, IntroducedVersion: 6.1.0.0.  Description: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.</summary>
	public const string Community = "community";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: community, SchemaName: CommunityName, IntroducedVersion: 6.1.0.0. </summary>
	public const string CommunityName = "communityname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the case resolution activity.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the case resolution activity.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who created the record.</summary>
	public const string CreatedByExternalParty = "createdbyexternalparty";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who created the record.</summary>
	public const string CreatedByExternalParty_Lookup = "_createdbyexternalparty_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByExternalPartyName = "createdbyexternalpartyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyYomiName, YomiOf: createdbyexternalpartyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByExternalPartyYomiName = "createdbyexternalpartyyominame";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the case resolution activity was created.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the incidentresolution.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the incidentresolution.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Customers, Format: None, SchemaName: Customers, IntroducedVersion: 5.0.0.0.  Description: Customer with which the activity is associated.</summary>
	public const string Customers = "customers";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Date Delivery Last Attempted, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: DeliveryLastAttemptedOn, IntroducedVersion: 6.0.0.0.  Description: Date and time when the delivery of the activity was last attempted.</summary>
	public const string DeliveryLastAttemptedOn = "deliverylastattemptedon";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Delivery Priority, SchemaName: DeliveryPriorityCode, IntroducedVersion: 6.0.0.0.  Description: Priority of delivery of the activity to the email server.</summary>
	public const string DeliveryPriorityCode = "deliveryprioritycode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: deliveryprioritycode, SchemaName: DeliveryPriorityCodeName, IntroducedVersion: 6.0.0.0. </summary>
	public const string DeliveryPriorityCodeName = "deliveryprioritycodename";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Remarks, Format: Text, MaxLength: 100000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information that describes the case resolution.</summary>
	public const string Description = "description";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Exchange Item ID, Format: Text, MaxLength: 200, SchemaName: ExchangeItemId, IntroducedVersion: 8.2.0.0.  Description: The message id of activity which is returned from Exchange Server.</summary>
	public const string ExchangeItemId = "exchangeitemid";

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the activitypointer with respect to the base currency.</summary>
	public const string ExchangeRate = "exchangerate";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Exchange WebLink, Format: Text, MaxLength: 1250, SchemaName: ExchangeWebLink, IntroducedVersion: 8.2.0.0.  Description: Shows the web link of Activity of type email.</summary>
	public const string ExchangeWebLink = "exchangeweblink";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: From, Format: None, SchemaName: From, IntroducedVersion: 5.0.0.0.  Description: Person who the activity is from.</summary>
	public const string From = "from";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Sequence number of the import that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: IncidentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case.</summary>
	public const string IncidentId = "incidentid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: IncidentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case.</summary>
	public const string IncidentId_Lookup = "_incidentid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: incidentid, Format: Text, MaxLength: 100, SchemaName: IncidentIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncidentIdName = "incidentidname";

	/// <summary>Type: EntityName, RequiredLevel: None, AttributeOf: incidentid, SchemaName: IncidentIdType, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncidentIdType = "incidentidtype";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Recurring Instance Type, SchemaName: InstanceTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of instance of a recurring series.</summary>
	public const string InstanceTypeCode = "instancetypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: instancetypecode, SchemaName: InstanceTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string InstanceTypeCodeName = "instancetypecodename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Billed, SchemaName: IsBilled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the case resolution activity was billed as part of resolving a case.</summary>
	public const string IsBilled = "isbilled";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isbilled, SchemaName: IsBilledName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsBilledName = "isbilledname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Private, SchemaName: IsMapiPrivate, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string IsMapiPrivate = "ismapiprivate";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ismapiprivate, SchemaName: IsMapiPrivateName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsMapiPrivateName = "ismapiprivatename";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Regular Activity, SchemaName: IsRegularActivity, IntroducedVersion: 5.0.0.0.  Description: Information regarding whether the activity is a regular activity type or event type.</summary>
	public const string IsRegularActivity = "isregularactivity";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isregularactivity, SchemaName: IsRegularActivityName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsRegularActivityName = "isregularactivityname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Workflow Created, SchemaName: IsWorkflowCreated, IntroducedVersion: 5.0.0.0.  Description: Information that specifies if the case resolution activity was created from a workflow rule.</summary>
	public const string IsWorkflowCreated = "isworkflowcreated";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isworkflowcreated, SchemaName: IsWorkflowCreatedName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsWorkflowCreatedName = "isworkflowcreatedname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last On Hold Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastOnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Contains the date and time stamp of the last on hold time.</summary>
	public const string LastOnHoldTime = "lastonholdtime";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Left Voice Mail, SchemaName: LeftVoiceMail, IntroducedVersion: 5.0.0.0.  Description: Left the voice mail</summary>
	public const string LeftVoiceMail = "leftvoicemail";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: leftvoicemail, SchemaName: LeftVoiceMailName, IntroducedVersion: 5.0.0.0. </summary>
	public const string LeftVoiceMailName = "leftvoicemailname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the case resolution activity.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the case resolution activity.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who modified the record.</summary>
	public const string ModifiedByExternalParty = "modifiedbyexternalparty";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who modified the record.</summary>
	public const string ModifiedByExternalParty_Lookup = "_modifiedbyexternalparty_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByExternalPartyName = "modifiedbyexternalpartyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyYomiName, YomiOf: modifiedbyexternalpartyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByExternalPartyYomiName = "modifiedbyexternalpartyyominame";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the case resolution activity was last modified.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the incidentresolution.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the incidentresolution.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Propose new knowledge using this case, SchemaName: msdyn_proposeknowledge, IntroducedVersion: 1.0.0.1.  Description: Use this setting to generate knowledge article from the case using copilot if you did not find a relevant article.</summary>
	public const string msdyn_proposeknowledge = "msdyn_proposeknowledge";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_proposeknowledge, SchemaName: msdyn_proposeknowledgeName, IntroducedVersion: 1.0.0.1. </summary>
	public const string msdyn_proposeknowledgeName = "msdyn_proposeknowledgename";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: On Hold Time (Minutes), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Shows how long, in minutes, that the record was on hold.</summary>
	public const string OnHoldTime = "onholdtime";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Optional Attendees, Format: None, SchemaName: OptionalAttendees, IntroducedVersion: 5.0.0.0.  Description: List of optional attendees for the activity.</summary>
	public const string OptionalAttendees = "optionalattendees";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Organizer, Format: None, SchemaName: Organizer, IntroducedVersion: 5.0.0.0.  Description: Person who organized the activity.</summary>
	public const string Organizer = "organizer";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user or team who owns the activity.</summary>
	public const string OwnerId = "ownerid";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user or team who owns the activity.</summary>
	public const string OwnerId_Lookup = "_ownerid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwnerIdName = "owneridname";

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwnerIdType = "owneridtype";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwnerIdYomiName = "owneridyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the activity.</summary>
	public const string OwningBusinessUnit = "owningbusinessunit";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the activity.</summary>
	public const string OwningBusinessUnit_Lookup = "_owningbusinessunit_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwningBusinessUnitName = "owningbusinessunitname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team that owns the activity.</summary>
	public const string OwningTeam = "owningteam";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team that owns the activity.</summary>
	public const string OwningTeam_Lookup = "_owningteam_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user that owns the activity.</summary>
	public const string OwningUser = "owninguser";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user that owns the activity.</summary>
	public const string OwningUser_Lookup = "_owninguser_value";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Outsource Vendors, Format: None, SchemaName: Partners, IntroducedVersion: 5.0.0.0.  Description: Outsource vendor with which activity is associated.</summary>
	public const string Partners = "partners";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Delay activity processing until, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: PostponeActivityProcessingUntil, IntroducedVersion: 6.0.0.0.  Description: For internal use only.</summary>
	public const string PostponeActivityProcessingUntil = "postponeactivityprocessinguntil";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, SchemaName: PriorityCode, IntroducedVersion: 5.0.0.0.  Description: Priority of the activity.</summary>
	public const string PriorityCode = "prioritycode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: prioritycode, SchemaName: PriorityCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PriorityCodeName = "prioritycodename";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process, SchemaName: ProcessId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the Process.</summary>
	public const string ProcessId = "processid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	public const string RegardingObjectId = "regardingobjectid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	public const string RegardingObjectId_Lookup = "_regardingobjectid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: regardingobjectid, Format: Text, MaxLength: 400, SchemaName: RegardingObjectIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string RegardingObjectIdName = "regardingobjectidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: regardingobjectid, Format: Text, MaxLength: 400, SchemaName: RegardingObjectIdYomiName, IntroducedVersion: 5.0.0.0. </summary>
	public const string RegardingObjectIdYomiName = "regardingobjectidyominame";

	/// <summary>Type: EntityName, RequiredLevel: None, AttributeOf: regardingobjectid, SchemaName: RegardingObjectTypeCode, IntroducedVersion: 5.0.0.0. </summary>
	public const string RegardingObjectTypeCode = "regardingobjecttypecode";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Required Attendees, Format: None, SchemaName: RequiredAttendees, IntroducedVersion: 5.0.0.0.  Description: List of required attendees for the activity.</summary>
	public const string RequiredAttendees = "requiredattendees";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Resolution Type, SchemaName: ResolutionTypeCode, IntroducedVersion: 9.1.0.0. </summary>
	public const string ResolutionTypeCode = "resolutiontypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: resolutiontypecode, SchemaName: resolutiontypecodeName, IntroducedVersion: 9.1.0.0. </summary>
	public const string resolutiontypecodeName = "resolutiontypecodename";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Resources, Format: None, SchemaName: Resources, IntroducedVersion: 5.0.0.0.  Description: Users or facility/equipment that are required for the activity.</summary>
	public const string Resources = "resources";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Scheduled Duration, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: ScheduledDurationMinutes, IntroducedVersion: 5.0.0.0.  Description: Scheduled duration of the case resolution activity, specified in minutes.</summary>
	public const string ScheduledDurationMinutes = "scheduleddurationminutes";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Scheduled End, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ScheduledEnd, IntroducedVersion: 5.0.0.0.  Description: Scheduled end time of the case resolution activity.</summary>
	public const string ScheduledEnd = "scheduledend";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Scheduled Start, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ScheduledStart, IntroducedVersion: 5.0.0.0.  Description: Scheduled start time of the case resolution activity.</summary>
	public const string ScheduledStart = "scheduledstart";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sender's Mailbox, Format: None, SchemaName: SenderMailboxId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the mailbox associated with the sender of the email message.</summary>
	public const string SenderMailboxId = "sendermailboxid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sender's Mailbox, Format: None, SchemaName: SenderMailboxId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the mailbox associated with the sender of the email message.</summary>
	public const string SenderMailboxId_Lookup = "_sendermailboxid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: sendermailboxid, Format: Text, MaxLength: 100, SchemaName: SenderMailboxIdName, IntroducedVersion: 6.0.0.0. </summary>
	public const string SenderMailboxIdName = "sendermailboxidname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Date Sent, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: SentOn, IntroducedVersion: 6.0.0.0.  Description: Date and time when the activity was sent.</summary>
	public const string SentOn = "senton";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Series Id, SchemaName: SeriesId, IntroducedVersion: 5.0.0.0.  Description: Uniqueidentifier specifying the id of recurring series of an instance.</summary>
	public const string SeriesId = "seriesid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ServiceId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the service with which the case resolution activity is associated.</summary>
	public const string ServiceId = "serviceid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ServiceId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the service with which the case resolution activity is associated.</summary>
	public const string ServiceId_Lookup = "_serviceid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: serviceid, Format: Text, MaxLength: 100, SchemaName: ServiceIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ServiceIdName = "serviceidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
	public const string SLAId = "slaid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
	public const string SLAId_Lookup = "_slaid_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	public const string SLAInvokedId = "slainvokedid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	public const string SLAInvokedId_Lookup = "_slainvokedid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slainvokedid, Format: Text, MaxLength: 100, SchemaName: SLAInvokedIdName, IntroducedVersion: 8.1.0.0. </summary>
	public const string SLAInvokedIdName = "slainvokedidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: SLAName, IntroducedVersion: 8.1.0.0. </summary>
	public const string SLAName = "slaname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Sort Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: SortDate, IntroducedVersion: 8.2.0.0.  Description: Shows the date and time by which the activities are sorted.</summary>
	public const string SortDate = "sortdate";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Process Stage, SchemaName: StageId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the Stage.</summary>
	public const string StageId = "stageid";

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the case resolution is open, completed, or canceled. By default, all case resolutions are completed and the status value can't be changed.</summary>
	public const string StateCode = "statecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string StateCodeName = "statecodename";

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Reason for the status of the case resolution activity.</summary>
	public const string StatusCode = "statuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string StatusCodeName = "statuscodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Sub-Category, Format: Text, MaxLength: 250, SchemaName: Subcategory, IntroducedVersion: 5.0.0.0.  Description: Subcategory of the case resolution activity.</summary>
	public const string Subcategory = "subcategory";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Subject, Format: Text, MaxLength: 200, SchemaName: Subject, IntroducedVersion: 5.0.0.0.  Description: Subject associated with the case resolution activity.</summary>
	public const string Subject = "subject";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Billable Time, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: TimeSpent, IntroducedVersion: 5.0.0.0.  Description: Time spent on the case resolution activity.</summary>
	public const string TimeSpent = "timespent";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: To, Format: None, SchemaName: To, IntroducedVersion: 5.0.0.0.  Description: Person who is the receiver of the activity.</summary>
	public const string To = "to";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Total Time, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: TotalTimeSpent, IntroducedVersion: 9.0.0.0.  Description: Total time spent on the case resolution activity.</summary>
	public const string TotalTimeSpent = "totaltimespent";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the activitypointer.</summary>
	public const string TransactionCurrencyId = "transactioncurrencyid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the activitypointer.</summary>
	public const string TransactionCurrencyId_Lookup = "_transactioncurrencyid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: TraversedPath, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	public const string TraversedPath = "traversedpath";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the activity.</summary>
	public const string VersionNumber = "versionnumber";

}

