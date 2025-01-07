namespace ECSM.Models.Dynamics;

public static partial class msdyn_kbattachmentField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "msdyn_kbattachmentid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "msdyn_filename";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "msdyn_kbattachments";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "msdyn_kbattachments";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "msdyn_kbattachments";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "msdyn_kbattachment";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "msdyn_kbattachment";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "msdyn_fileicon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 9.1.0.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 9.1.0.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 9.1.0.0.  Description: Date and time when the record was created.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 9.1.0.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 9.1.0.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 9.1.0.0.  Description: Sequence number of the import that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 9.1.0.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 9.1.0.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 9.1.0.0.  Description: Date and time when the record was modified.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 9.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 9.1.0.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 9.1.0.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: File Attachment, MaxSizeInKb: 32768, MaxSizeInKb: 32768, SchemaName: msdyn_fileattachment, IntroducedVersion: 1.0.  Description: The reference to the file uploaded as the knowledge article attachment</summary>
	public const string msdyn_fileattachment = "msdyn_fileattachment";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_fileattachment, Format: Text, MaxLength: 200, SchemaName: msdyn_fileattachment_Name, IntroducedVersion: 1.0. </summary>
	public const string msdyn_fileattachment_Name = "msdyn_fileattachment_name";

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: File Icon, AttributeOf: msdyn_fileiconid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: msdyn_fileicon, IntroducedVersion: 1.0.  Description: The icon of the knowledge article attachment</summary>
	public const string msdyn_fileicon = "msdyn_fileicon";

	/// <summary>Type: BigInt, RequiredLevel: None, AttributeOf: msdyn_fileiconid, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: msdyn_fileicon_Timestamp, IntroducedVersion: 1.0. </summary>
	public const string msdyn_fileicon_Timestamp = "msdyn_fileicon_timestamp";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_fileiconid, Format: Url, MaxLength: 200, SchemaName: msdyn_fileicon_URL, IntroducedVersion: 1.0. </summary>
	public const string msdyn_fileicon_URL = "msdyn_fileicon_url";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, SchemaName: msdyn_fileiconId, IntroducedVersion: 1.0. </summary>
	public const string msdyn_fileiconId = "msdyn_fileiconid";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: File Name, Format: Text, MaxLength: 255, SchemaName: msdyn_filename, IntroducedVersion: 1.0.  Description: The name of the knowledge article attachment.</summary>
	public const string msdyn_filename = "msdyn_filename";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: File Size (Bytes), Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: msdyn_filesize, IntroducedVersion: 1.0. </summary>
	public const string msdyn_filesize = "msdyn_filesize";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: File Type, Format: Text, MaxLength: 256, SchemaName: msdyn_filetype, IntroducedVersion: 1.0.  Description: File type of the knowledge article attachment</summary>
	public const string msdyn_filetype = "msdyn_filetype";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Knowledge Article Attachment, SchemaName: msdyn_kbattachmentId, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for entity instances</summary>
	public const string msdyn_kbattachmentId = "msdyn_kbattachmentid";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Related Annotations, Format: Text, MaxLength: 1048576, SchemaName: msdyn_relatedannotations, IntroducedVersion: 1.0.  Description: A list of identical annotation records mapped to their corresponding knowledge article</summary>
	public const string msdyn_relatedannotations = "msdyn_relatedannotations";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 9.1.0.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 9.1.0.0.  Description: Owner Id</summary>
	public const string OwnerId = "ownerid";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 9.1.0.0.  Description: Owner Id</summary>
	public const string OwnerId_Lookup = "_ownerid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 9.1.0.0.  Description: Name of the owner</summary>
	public const string OwnerIdName = "owneridname";

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 9.1.0.0.  Description: Owner Id Type</summary>
	public const string OwnerIdType = "owneridtype";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 9.1.0.0.  Description: Yomi name of the owner</summary>
	public const string OwnerIdYomiName = "owneridyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	public const string OwningBusinessUnit = "owningbusinessunit";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	public const string OwningBusinessUnit_Lookup = "_owningbusinessunit_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 100, SchemaName: OwningBusinessUnitName, IntroducedVersion: 9.1.0.0. </summary>
	public const string OwningBusinessUnitName = "owningbusinessunitname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	public const string OwningTeam = "owningteam";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	public const string OwningTeam_Lookup = "_owningteam_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	public const string OwningUser = "owninguser";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	public const string OwningUser_Lookup = "_owninguser_value";

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: statecode, IntroducedVersion: 9.1.0.0.  Description: Status of the Knowledge Article Attachment</summary>
	public const string statecode = "statecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: statecodeName, IntroducedVersion: 9.1.0.0. </summary>
	public const string statecodeName = "statecodename";

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: statuscode, IntroducedVersion: 9.1.0.0.  Description: Reason for the status of the Knowledge Article Attachment</summary>
	public const string statuscode = "statuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: statuscodeName, IntroducedVersion: 9.1.0.0. </summary>
	public const string statuscodeName = "statuscodename";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 9.1.0.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 9.1.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 9.1.0.0.  Description: Version Number</summary>
	public const string VersionNumber = "versionnumber";

}

