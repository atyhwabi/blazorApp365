namespace ECSM.Models.Dynamics;

public static partial class ecsm_incidentField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "ecsm_incidentid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "ecsm_name";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "ecsm_incidents";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "ecsm_incidents";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "ecsm_incidents";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "ecsm_incident";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "ecsm_incident";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who created the record.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who created the record.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 1.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 1.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 1.0.  Description: Date and time when the record was created.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who created the record.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who created the record.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 1.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 1.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: ecsm_account, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_account = "ecsm_account";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: ecsm_account, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_account_Lookup = "_ecsm_account_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_account, Format: Text, MaxLength: 160, SchemaName: ecsm_accountName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_accountName = "ecsm_accountname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_account, Format: Text, MaxLength: 160, SchemaName: ecsm_accountYomiName, YomiOf: ecsm_accountname, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_accountYomiName = "ecsm_accountyominame";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Approval Status, SchemaName: ecsm_approval_status, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_approval_status = "ecsm_approval_status";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_approval_status, SchemaName: ecsm_approval_statusName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_approval_statusName = "ecsm_approval_statusname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ecsm_contact, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_contact = "ecsm_contact";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ecsm_contact, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_contact_Lookup = "_ecsm_contact_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_contact, Format: Text, MaxLength: 160, SchemaName: ecsm_contactName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_contactName = "ecsm_contactname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_contact, Format: Text, MaxLength: 450, SchemaName: ecsm_contactYomiName, YomiOf: ecsm_contactname, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_contactYomiName = "ecsm_contactyominame";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Default Impact, SchemaName: ecsm_default_impact, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_default_impact = "ecsm_default_impact";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_default_impact, SchemaName: ecsm_default_impactName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_default_impactName = "ecsm_default_impactname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Impact, SchemaName: ecsm_impact, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_impact = "ecsm_impact";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_impact, SchemaName: ecsm_impactName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_impactName = "ecsm_impactname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Incident Type, SchemaName: ecsm_incident_type, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_type = "ecsm_incident_type";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_incident_type, SchemaName: ecsm_incident_typeName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_typeName = "ecsm_incident_typename";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Incident, SchemaName: ecsm_incidentId, IntroducedVersion: 1.0.  Description: Unique identifier for entity instances</summary>
	public const string ecsm_incidentId = "ecsm_incidentid";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Name, Format: Text, MaxLength: 100, SchemaName: ecsm_Name, IntroducedVersion: 1.0. </summary>
	public const string ecsm_Name = "ecsm_name";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, SchemaName: ecsm_priority, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_priority = "ecsm_priority";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_priority, SchemaName: ecsm_priorityName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_priorityName = "ecsm_priorityname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Resolve By SLA KPI, Format: None, SchemaName: ecsm_resolve_by_SLA_KPI, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_resolve_by_SLA_KPI = "ecsm_resolve_by_sla_kpi";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Resolve By SLA KPI, Format: None, SchemaName: ecsm_resolve_by_SLA_KPI, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_resolve_by_SLA_KPI_Lookup = "_ecsm_resolve_by_sla_kpi_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_resolve_by_sla_kpi, Format: Text, MaxLength: 100, SchemaName: ecsm_resolve_by_SLA_KPIName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_resolve_by_SLA_KPIName = "ecsm_resolve_by_sla_kpiname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Respond By SLA KPI, Format: None, SchemaName: ecsm_respond_by_SLA_KPI, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_respond_by_SLA_KPI = "ecsm_respond_by_sla_kpi";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Respond By SLA KPI, Format: None, SchemaName: ecsm_respond_by_SLA_KPI, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_respond_by_SLA_KPI_Lookup = "_ecsm_respond_by_sla_kpi_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_respond_by_sla_kpi, Format: Text, MaxLength: 100, SchemaName: ecsm_respond_by_SLA_KPIName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_respond_by_SLA_KPIName = "ecsm_respond_by_sla_kpiname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Urgency, SchemaName: ecsm_urgency, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_urgency = "ecsm_urgency";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_urgency, SchemaName: ecsm_urgencyName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_urgencyName = "ecsm_urgencyname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 1.0.  Description: Sequence number of the import that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last On Hold Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastOnHoldTime, IntroducedVersion: 1.0.0.0.  Description: Contains the date and time stamp of the last on-hold time</summary>
	public const string LastOnHoldTime = "lastonholdtime";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who modified the record.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who modified the record.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 1.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 1.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 1.0.  Description: Date and time when the record was modified.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 1.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 1.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: On Hold Time (Minutes), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OnHoldTime, IntroducedVersion: 1.0.0.0.  Description: Shows how long, in minutes, that the record was on hold</summary>
	public const string OnHoldTime = "onholdtime";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 1.0.  Description: Unique identifier for the organization</summary>
	public const string OrganizationId = "organizationid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 1.0.  Description: Unique identifier for the organization</summary>
	public const string OrganizationId_Lookup = "_organizationid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: organizationid, Format: Text, MaxLength: 100, SchemaName: OrganizationIdName, IntroducedVersion: 1.0. </summary>
	public const string OrganizationIdName = "organizationidname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 1.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 1.0.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the record.</summary>
	public const string SLAId = "slaid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 1.0.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the record.</summary>
	public const string SLAId_Lookup = "_slaid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: slaidname, IntroducedVersion: 1.0.0.0. </summary>
	public const string slaidname = "slaidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA Applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 1.0.0.0.  Description: For internal use only.</summary>
	public const string SLAInvokedId = "slainvokedid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA Applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 1.0.0.0.  Description: For internal use only.</summary>
	public const string SLAInvokedId_Lookup = "_slainvokedid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slainvokedid, Format: Text, MaxLength: 100, SchemaName: SLAInvokedIdName, IntroducedVersion: 1.0.0.0. </summary>
	public const string SLAInvokedIdName = "slainvokedidname";

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: statecode, IntroducedVersion: 1.0.  Description: Status of the Incident</summary>
	public const string statecode = "statecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: statecodeName, IntroducedVersion: 1.0. </summary>
	public const string statecodeName = "statecodename";

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: statuscode, IntroducedVersion: 1.0.  Description: Reason for the status of the Incident</summary>
	public const string statuscode = "statuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: statuscodeName, IntroducedVersion: 1.0. </summary>
	public const string statuscodeName = "statuscodename";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 1.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 1.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 1.0.  Description: Version Number</summary>
	public const string VersionNumber = "versionnumber";

}

