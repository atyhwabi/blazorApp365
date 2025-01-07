namespace ECSM.Models.Dynamics;

public static partial class ecsm_catalogue_item_form_elementField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "ecsm_catalogue_item_form_elementid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "ecsm_name";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "ecsm_catalogue_item_form_elements";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "ecsm_catalogue_item_form_elements";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "ecsm_catalogue_item_form_elements";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "ecsm_catalogue_item_form_element";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "ecsm_catalogue_item_form_element";

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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Catalogue Item, Format: None, SchemaName: ecsm_catalogue_item, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item = "ecsm_catalogue_item";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Catalogue Item, Format: None, SchemaName: ecsm_catalogue_item, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_Lookup = "_ecsm_catalogue_item_value";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Catalogue Item Form Element, SchemaName: ecsm_catalogue_item_form_elementId, IntroducedVersion: 1.0.  Description: Unique identifier for entity instances</summary>
	public const string ecsm_catalogue_item_form_elementId = "ecsm_catalogue_item_form_elementid";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_catalogue_item, Format: Text, MaxLength: 100, SchemaName: ecsm_catalogue_itemName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_itemName = "ecsm_catalogue_itemname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Choices, Format: Text, MaxLength: 2000, SchemaName: ecsm_Choices, IntroducedVersion: 1.0. </summary>
	public const string ecsm_Choices = "ecsm_choices";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Content Block, Format: None, SchemaName: ecsm_Content_block, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_Content_block = "ecsm_content_block";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Content Block, Format: None, SchemaName: ecsm_Content_block, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_Content_block_Lookup = "_ecsm_content_block_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_content_block, Format: Text, MaxLength: 100, SchemaName: ecsm_Content_blockName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_Content_blockName = "ecsm_content_blockname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Description , Format: TextArea, MaxLength: 1000, SchemaName: ecsm_description, IntroducedVersion: 1.0. </summary>
	public const string ecsm_description = "ecsm_description";

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Form Element Type, SchemaName: ecsm_form_element_type, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_form_element_type = "ecsm_form_element_type";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_form_element_type, SchemaName: ecsm_form_element_typeName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_form_element_typeName = "ecsm_form_element_typename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Map To Dataverse Column, SchemaName: ecsm_map_to_dataverse_column, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_map_to_dataverse_column = "ecsm_map_to_dataverse_column";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Map To Dataverse Column Name, Format: Text, MaxLength: 100, SchemaName: ecsm_map_to_dataverse_column_name, IntroducedVersion: 1.0. </summary>
	public const string ecsm_map_to_dataverse_column_name = "ecsm_map_to_dataverse_column_name";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_map_to_dataverse_column, SchemaName: ecsm_map_to_dataverse_columnName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_map_to_dataverse_columnName = "ecsm_map_to_dataverse_columnname";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Name, Format: Text, MaxLength: 100, SchemaName: ecsm_Name, IntroducedVersion: 1.0. </summary>
	public const string ecsm_Name = "ecsm_name";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName:  order, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ecsm_order, IntroducedVersion: 1.0. </summary>
	public const string ecsm_order = "ecsm_order";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Required, SchemaName: ecsm_required, IntroducedVersion: 1.0.0.8. </summary>
	public const string ecsm_required = "ecsm_required";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_required, SchemaName: ecsm_requiredName, IntroducedVersion: 1.0.0.8. </summary>
	public const string ecsm_requiredName = "ecsm_requiredname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Variable Data Type, SchemaName: ecsm_variable_data_type, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_variable_data_type = "ecsm_variable_data_type";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_variable_data_type, SchemaName: ecsm_variable_data_typeName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_variable_data_typeName = "ecsm_variable_data_typename";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 1.0.  Description: Sequence number of the import that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 1.0.  Description: Unique identifier for the organization</summary>
	public const string OrganizationId = "organizationid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 1.0.  Description: Unique identifier for the organization</summary>
	public const string OrganizationId_Lookup = "_organizationid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: organizationid, Format: Text, MaxLength: 100, SchemaName: OrganizationIdName, IntroducedVersion: 1.0. </summary>
	public const string OrganizationIdName = "organizationidname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 1.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: statecode, IntroducedVersion: 1.0.  Description: Status of the Catalogue Item Form Element</summary>
	public const string statecode = "statecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: statecodeName, IntroducedVersion: 1.0. </summary>
	public const string statecodeName = "statecodename";

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: statuscode, IntroducedVersion: 1.0.  Description: Reason for the status of the Catalogue Item Form Element</summary>
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
