namespace ECSM.Models.Dynamics;

/// <summary>Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.</summary>
public static partial class SystemUserField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "systemuserid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "fullname";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "SystemUsers";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "systemusers";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "systemusers";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "systemuser";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "SystemUser";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "entityimage";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Access Mode, SchemaName: AccessMode, IntroducedVersion: 5.0.0.0.  Description: Type of user.</summary>
	public const string AccessMode = "accessmode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: accessmode, SchemaName: AccessModeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string AccessModeName = "accessmodename";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Active Directory Guid, SchemaName: ActiveDirectoryGuid, IntroducedVersion: 5.0.0.0.  Description: Active Directory object GUID for the system user.</summary>
	public const string ActiveDirectoryGuid = "activedirectoryguid";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 1: ID, SchemaName: Address1_AddressId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for address 1.</summary>
	public const string Address1_AddressId = "address1_addressid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Address Type, SchemaName: Address1_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of address for address 1, such as billing, shipping, or primary address.</summary>
	public const string Address1_AddressTypeCode = "address1_addresstypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_addresstypecode, SchemaName: Address1_AddressTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address1_AddressTypeCodeName = "address1_addresstypecodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: City, Format: Text, MaxLength: 128, SchemaName: Address1_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 1.</summary>
	public const string Address1_City = "address1_city";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address, Format: TextArea, MaxLength: 1000, SchemaName: Address1_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete primary address.</summary>
	public const string Address1_Composite = "address1_composite";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Country/Region, Format: Text, MaxLength: 128, SchemaName: Address1_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name in address 1.</summary>
	public const string Address1_Country = "address1_country";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: County, Format: Text, MaxLength: 128, SchemaName: Address1_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 1.</summary>
	public const string Address1_County = "address1_county";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Fax, Format: Text, MaxLength: 64, SchemaName: Address1_Fax, IntroducedVersion: 5.0.0.0.  Description: Fax number for address 1.</summary>
	public const string Address1_Fax = "address1_fax";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address1_Latitude, IntroducedVersion: 5.0.0.0.  Description: Latitude for address 1.</summary>
	public const string Address1_Latitude = "address1_latitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 1, Format: Text, MaxLength: 1024, SchemaName: Address1_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 1 information.</summary>
	public const string Address1_Line1 = "address1_line1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 2, Format: Text, MaxLength: 1024, SchemaName: Address1_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 1 information.</summary>
	public const string Address1_Line2 = "address1_line2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 3, Format: Text, MaxLength: 1024, SchemaName: Address1_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 1 information.</summary>
	public const string Address1_Line3 = "address1_line3";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address1_Longitude, IntroducedVersion: 5.0.0.0.  Description: Longitude for address 1.</summary>
	public const string Address1_Longitude = "address1_longitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Name, Format: Text, MaxLength: 100, SchemaName: Address1_Name, IntroducedVersion: 5.0.0.0.  Description: Name to enter for address 1.</summary>
	public const string Address1_Name = "address1_name";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ZIP/Postal Code, Format: Text, MaxLength: 40, SchemaName: Address1_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 1.</summary>
	public const string Address1_PostalCode = "address1_postalcode";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Post Office Box, Format: Text, MaxLength: 40, SchemaName: Address1_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 1.</summary>
	public const string Address1_PostOfficeBox = "address1_postofficebox";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Shipping Method, SchemaName: Address1_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 1.</summary>
	public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_shippingmethodcode, SchemaName: Address1_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address1_ShippingMethodCodeName = "address1_shippingmethodcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: State/Province, Format: Text, MaxLength: 128, SchemaName: Address1_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 1.</summary>
	public const string Address1_StateOrProvince = "address1_stateorprovince";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Main Phone, Format: Text, MaxLength: 64, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: First telephone number associated with address 1.</summary>
	public const string Address1_Telephone1 = "address1_telephone1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Second telephone number associated with address 1.</summary>
	public const string Address1_Telephone2 = "address1_telephone2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pager, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Third telephone number associated with address 1.</summary>
	public const string Address1_Telephone3 = "address1_telephone3";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address1_UPSZone, IntroducedVersion: 5.0.0.0.  Description: United Parcel Service (UPS) zone for address 1.</summary>
	public const string Address1_UPSZone = "address1_upszone";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 1: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address1_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.</summary>
	public const string Address1_UTCOffset = "address1_utcoffset";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 2: ID, SchemaName: Address2_AddressId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for address 2.</summary>
	public const string Address2_AddressId = "address2_addressid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Address Type, SchemaName: Address2_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of address for address 2, such as billing, shipping, or primary address.</summary>
	public const string Address2_AddressTypeCode = "address2_addresstypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_addresstypecode, SchemaName: Address2_AddressTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address2_AddressTypeCodeName = "address2_addresstypecodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other City, Format: Text, MaxLength: 128, SchemaName: Address2_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 2.</summary>
	public const string Address2_City = "address2_city";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Other Address, Format: TextArea, MaxLength: 1000, SchemaName: Address2_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete secondary address.</summary>
	public const string Address2_Composite = "address2_composite";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Country/Region, Format: Text, MaxLength: 128, SchemaName: Address2_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name in address 2.</summary>
	public const string Address2_Country = "address2_country";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: County, Format: Text, MaxLength: 128, SchemaName: Address2_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 2.</summary>
	public const string Address2_County = "address2_county";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Fax, Format: Text, MaxLength: 50, SchemaName: Address2_Fax, IntroducedVersion: 5.0.0.0.  Description: Fax number for address 2.</summary>
	public const string Address2_Fax = "address2_fax";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address2_Latitude, IntroducedVersion: 5.0.0.0.  Description: Latitude for address 2.</summary>
	public const string Address2_Latitude = "address2_latitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Street 1, Format: Text, MaxLength: 1024, SchemaName: Address2_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 2 information.</summary>
	public const string Address2_Line1 = "address2_line1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Street 2, Format: Text, MaxLength: 1024, SchemaName: Address2_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 2 information.</summary>
	public const string Address2_Line2 = "address2_line2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Street 3, Format: Text, MaxLength: 1024, SchemaName: Address2_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 2 information.</summary>
	public const string Address2_Line3 = "address2_line3";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address2_Longitude, IntroducedVersion: 5.0.0.0.  Description: Longitude for address 2.</summary>
	public const string Address2_Longitude = "address2_longitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Name, Format: Text, MaxLength: 100, SchemaName: Address2_Name, IntroducedVersion: 5.0.0.0.  Description: Name to enter for address 2.</summary>
	public const string Address2_Name = "address2_name";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other ZIP/Postal Code, Format: Text, MaxLength: 40, SchemaName: Address2_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 2.</summary>
	public const string Address2_PostalCode = "address2_postalcode";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Post Office Box, Format: Text, MaxLength: 40, SchemaName: Address2_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 2.</summary>
	public const string Address2_PostOfficeBox = "address2_postofficebox";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Shipping Method, SchemaName: Address2_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 2.</summary>
	public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_shippingmethodcode, SchemaName: Address2_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address2_ShippingMethodCodeName = "address2_shippingmethodcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other State/Province, Format: Text, MaxLength: 128, SchemaName: Address2_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 2.</summary>
	public const string Address2_StateOrProvince = "address2_stateorprovince";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 1, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone1, IntroducedVersion: 5.0.0.0.  Description: First telephone number associated with address 2.</summary>
	public const string Address2_Telephone1 = "address2_telephone1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 2, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Second telephone number associated with address 2.</summary>
	public const string Address2_Telephone2 = "address2_telephone2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Third telephone number associated with address 2.</summary>
	public const string Address2_Telephone3 = "address2_telephone3";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address2_UPSZone, IntroducedVersion: 5.0.0.0.  Description: United Parcel Service (UPS) zone for address 2.</summary>
	public const string Address2_UPSZone = "address2_upszone";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 2: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address2_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.</summary>
	public const string Address2_UTCOffset = "address2_utcoffset";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Application ID, SchemaName: ApplicationId, IntroducedVersion: 8.2.0.0.  Description: The identifier for the application. This is used to access data in another application.</summary>
	public const string ApplicationId = "applicationid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Application ID URI, Format: Text, MaxLength: 1024, SchemaName: ApplicationIdUri, IntroducedVersion: 8.2.0.0.  Description: The URI used as a unique logical identifier for the external app. This can be used to validate the application.</summary>
	public const string ApplicationIdUri = "applicationiduri";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Azure AD Object ID, SchemaName: AzureActiveDirectoryObjectId, IntroducedVersion: 8.2.0.0.  Description: This is the application directory object Id.</summary>
	public const string AzureActiveDirectoryObjectId = "azureactivedirectoryobjectid";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Azure Deleted On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: AzureDeletedOn, IntroducedVersion: 9.2.0.0.  Description: Date and time when the user was set as soft deleted in Azure.</summary>
	public const string AzureDeletedOn = "azuredeletedon";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Azure State, SchemaName: AzureState, IntroducedVersion: 9.2.0.0.  Description: Azure state of user</summary>
	public const string AzureState = "azurestate";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: azurestate, SchemaName: azurestateName, IntroducedVersion: 9.2.0.0. </summary>
	public const string azurestateName = "azurestatename";

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the user is associated.</summary>
	public const string BusinessUnitId = "businessunitid";

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the user is associated.</summary>
	public const string BusinessUnitId_Lookup = "_businessunitid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: businessunitid, Format: Text, MaxLength: 100, SchemaName: BusinessUnitIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string BusinessUnitIdName = "businessunitidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the user.</summary>
	public const string CalendarId = "calendarid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the user.</summary>
	public const string CalendarId_Lookup = "_calendarid_value";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: License Type, SchemaName: CALType, IntroducedVersion: 5.0.0.0.  Description: License type of user. This is used only in the on-premises version of the product. Online licenses are managed through Microsoft 365 Office Portal</summary>
	public const string CALType = "caltype";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: caltype, SchemaName: CALTypeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CALTypeName = "caltypename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the user.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the user.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the user was created.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the systemuser.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the systemuser.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Default Filters Populated, SchemaName: DefaultFiltersPopulated, IntroducedVersion: 5.0.0.0.  Description: Indicates if default outlook filters have been populated.</summary>
	public const string DefaultFiltersPopulated = "defaultfilterspopulated";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mailbox, Format: None, SchemaName: DefaultMailbox, IntroducedVersion: 6.0.0.0.  Description: Select the mailbox associated with this user.</summary>
	public const string DefaultMailbox = "defaultmailbox";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mailbox, Format: None, SchemaName: DefaultMailbox, IntroducedVersion: 6.0.0.0.  Description: Select the mailbox associated with this user.</summary>
	public const string DefaultMailbox_Lookup = "_defaultmailbox_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: defaultmailbox, Format: Text, MaxLength: 100, SchemaName: DefaultMailboxName, IntroducedVersion: 6.0.0.0. </summary>
	public const string DefaultMailboxName = "defaultmailboxname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Default OneDrive for Business Folder Name, Format: Text, MaxLength: 200, SchemaName: DefaultOdbFolderName, IntroducedVersion: 8.0.0.0.  Description: Type a default folder name for the user's OneDrive For Business location.</summary>
	public const string DefaultOdbFolderName = "defaultodbfoldername";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Deleted State, SchemaName: DeletedState, IntroducedVersion: 9.2.0.0.  Description: User delete state</summary>
	public const string DeletedState = "deletedstate";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: deletedstate, SchemaName: deletedstateName, IntroducedVersion: 9.2.0.0. </summary>
	public const string deletedstateName = "deletedstatename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Disabled Reason, Format: Text, MaxLength: 500, SchemaName: DisabledReason, IntroducedVersion: 5.0.0.0.  Description: Reason for disabling the user.</summary>
	public const string DisabledReason = "disabledreason";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Display in Service Views, SchemaName: DisplayInServiceViews, IntroducedVersion: 5.0.0.0.  Description: Whether to display the user in service views.</summary>
	public const string DisplayInServiceViews = "displayinserviceviews";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: displayinserviceviews, SchemaName: DisplayInServiceViewsName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DisplayInServiceViewsName = "displayinserviceviewsname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: User Name, Format: Text, MaxLength: 1024, SchemaName: DomainName, IntroducedVersion: 5.0.0.0.  Description: Active Directory domain of which the user is a member.</summary>
	public const string DomainName = "domainname";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Primary Email Status, SchemaName: EmailRouterAccessApproval, IntroducedVersion: 5.0.0.0.  Description: Shows the status of the primary email address.</summary>
	public const string EmailRouterAccessApproval = "emailrouteraccessapproval";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: emailrouteraccessapproval, SchemaName: EmailRouterAccessApprovalName, IntroducedVersion: 5.0.0.0. </summary>
	public const string EmailRouterAccessApprovalName = "emailrouteraccessapprovalname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Employee, Format: Text, MaxLength: 100, SchemaName: EmployeeId, IntroducedVersion: 5.0.0.0.  Description: Employee identifier for the user.</summary>
	public const string EmployeeId = "employeeid";

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Entity Image, AttributeOf: entityimageid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: EntityImage, IntroducedVersion: 6.0.0.0.  Description: Shows the default image for the record.</summary>
	public const string EntityImage = "entityimage";

	/// <summary>Type: BigInt, RequiredLevel: None, AttributeOf: entityimageid, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: EntityImage_Timestamp, IntroducedVersion: 6.0.0.0. </summary>
	public const string EntityImage_Timestamp = "entityimage_timestamp";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: entityimageid, Format: Url, MaxLength: 200, SchemaName: EntityImage_URL, IntroducedVersion: 6.0.0.0. </summary>
	public const string EntityImage_URL = "entityimage_url";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Entity Image Id, SchemaName: EntityImageId, IntroducedVersion: 6.0.0.0.  Description: For internal use only.</summary>
	public const string EntityImageId = "entityimageid";

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the systemuser with respect to the base currency.</summary>
	public const string ExchangeRate = "exchangerate";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: First Name, Format: Text, MaxLength: 256, SchemaName: FirstName, IntroducedVersion: 5.0.0.0.  Description: First name of the user.</summary>
	public const string FirstName = "firstname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Full Name, Format: Text, MaxLength: 200, SchemaName: FullName, IntroducedVersion: 5.0.0.0.  Description: Full name of the user.</summary>
	public const string FullName = "fullname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Government, Format: Text, MaxLength: 100, SchemaName: GovernmentId, IntroducedVersion: 5.0.0.0.  Description: Government identifier for the user.</summary>
	public const string GovernmentId = "governmentid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Home Phone, Format: Text, MaxLength: 50, SchemaName: HomePhone, IntroducedVersion: 5.0.0.0.  Description: Home phone number for the user.</summary>
	public const string HomePhone = "homephone";

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Unique user identity id, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: IdentityId, IntroducedVersion: 9.0.0.0.  Description: For internal use only.</summary>
	public const string IdentityId = "identityid";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the data import or data migration that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Incoming Email Delivery Method, SchemaName: IncomingEmailDeliveryMethod, IntroducedVersion: 5.0.0.0.  Description: Incoming email delivery method for the user.</summary>
	public const string IncomingEmailDeliveryMethod = "incomingemaildeliverymethod";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: incomingemaildeliverymethod, SchemaName: IncomingEmailDeliveryMethodName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncomingEmailDeliveryMethodName = "incomingemaildeliverymethodname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Primary Email, Format: Email, MaxLength: 100, SchemaName: InternalEMailAddress, IntroducedVersion: 5.0.0.0.  Description: Internal email address for the user.</summary>
	public const string InternalEMailAddress = "internalemailaddress";

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Invitation Status, SchemaName: InviteStatusCode, IntroducedVersion: 5.0.0.0.  Description: User invitation status.</summary>
	public const string InviteStatusCode = "invitestatuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: invitestatuscode, SchemaName: InviteStatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string InviteStatusCodeName = "invitestatuscodename";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Active Directory User, SchemaName: IsActiveDirectoryUser, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is an AD user.</summary>
	public const string IsActiveDirectoryUser = "isactivedirectoryuser";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Status, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is enabled.</summary>
	public const string IsDisabled = "isdisabled";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdisabled, SchemaName: IsDisabledName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsDisabledName = "isdisabledname";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Email Address O365 Admin Approval Status, SchemaName: IsEmailAddressApprovedByO365Admin, IntroducedVersion: 6.0.0.0.  Description: Shows the status of approval of the email address by O365 Admin.</summary>
	public const string IsEmailAddressApprovedByO365Admin = "isemailaddressapprovedbyo365admin";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Integration user mode, SchemaName: IsIntegrationUser, IntroducedVersion: 5.0.0.0.  Description: Check if user is an integration user.</summary>
	public const string IsIntegrationUser = "isintegrationuser";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isintegrationuser, SchemaName: IsIntegrationUserName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsIntegrationUserName = "isintegrationusername";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Licensed, SchemaName: IsLicensed, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is licensed.</summary>
	public const string IsLicensed = "islicensed";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: islicensed, SchemaName: IsLicensedName, IntroducedVersion: 9.1.0.0. </summary>
	public const string IsLicensedName = "islicensedname";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Synced, SchemaName: IsSyncWithDirectory, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is synced with the directory.</summary>
	public const string IsSyncWithDirectory = "issyncwithdirectory";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Job Title, Format: Text, MaxLength: 100, SchemaName: JobTitle, IntroducedVersion: 5.0.0.0.  Description: Job title of the user.</summary>
	public const string JobTitle = "jobtitle";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Last Name, Format: Text, MaxLength: 256, SchemaName: LastName, IntroducedVersion: 5.0.0.0.  Description: Last name of the user.</summary>
	public const string LastName = "lastname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Latest User Update Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LatestUpdateTime, IntroducedVersion: 9.0.0.0.  Description: Time stamp of the latest update for the user</summary>
	public const string LatestUpdateTime = "latestupdatetime";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Middle Name, Format: Text, MaxLength: 50, SchemaName: MiddleName, IntroducedVersion: 5.0.0.0.  Description: Middle name of the user.</summary>
	public const string MiddleName = "middlename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Mobile Alert Email, Format: Email, MaxLength: 100, SchemaName: MobileAlertEMail, IntroducedVersion: 5.0.0.0.  Description: Mobile alert email address for the user.</summary>
	public const string MobileAlertEMail = "mobilealertemail";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mobile Offline Profile, Format: None, SchemaName: MobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Items contained with a particular SystemUser.</summary>
	public const string MobileOfflineProfileId = "mobileofflineprofileid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mobile Offline Profile, Format: None, SchemaName: MobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Items contained with a particular SystemUser.</summary>
	public const string MobileOfflineProfileId_Lookup = "_mobileofflineprofileid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: mobileofflineprofileid, Format: Text, MaxLength: 100, SchemaName: MobileOfflineProfileIdName, IntroducedVersion: 8.0.0.0. </summary>
	public const string MobileOfflineProfileIdName = "mobileofflineprofileidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Mobile Phone, Format: Text, MaxLength: 64, SchemaName: MobilePhone, IntroducedVersion: 5.0.0.0.  Description: Mobile phone number for the user.</summary>
	public const string MobilePhone = "mobilephone";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the user.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the user.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the user was last modified.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the systemuser.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the systemuser.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: User type, SchemaName: msdyn_AgentType, IntroducedVersion: 1.0.0.0.  Description: Type of user - Application user or Bot application user</summary>
	public const string msdyn_AgentType = "msdyn_agentType";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_agentType, SchemaName: msdyn_agentTypeName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_agentTypeName = "msdyn_agenttypename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bot application ID, Format: Text, MaxLength: 100, SchemaName: msdyn_BotApplicationId, IntroducedVersion: 1.0.0.0.  Description: Application ID of the bot.</summary>
	public const string msdyn_BotApplicationId = "msdyn_botapplicationid";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: Text, MaxLength: 2000, SchemaName: msdyn_BotDescription, IntroducedVersion: 1.0.0.1.  Description: BOT User Description</summary>
	public const string msdyn_BotDescription = "msdyn_botdescription";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Endpoint, Format: Text, MaxLength: 100, SchemaName: msdyn_BotEndpoint, IntroducedVersion: 1.0.0.1.  Description: Bot User Endpoint</summary>
	public const string msdyn_BotEndpoint = "msdyn_botendpoint";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bot handle, Format: Text, MaxLength: 100, SchemaName: msdyn_bothandle, IntroducedVersion: 1.0.0.0.  Description: Bot handle</summary>
	public const string msdyn_bothandle = "msdyn_bothandle";

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Bot Provider, SchemaName: msdyn_BotProvider, IntroducedVersion: 1.0.0.3.  Description: Indicates the type of bot</summary>
	public const string msdyn_BotProvider = "msdyn_botprovider";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_botprovider, SchemaName: msdyn_botproviderName, IntroducedVersion: 1.0.0.3. </summary>
	public const string msdyn_botproviderName = "msdyn_botprovidername";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Secret Keys, Format: Text, MaxLength: 100, SchemaName: msdyn_BotSecretKeys, IntroducedVersion: 1.0.0.1.  Description: Bot User Secret Keys</summary>
	public const string msdyn_BotSecretKeys = "msdyn_botsecretkeys";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Capacity, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_Capacity, IntroducedVersion: 1.0.0.0.  Description: Capacity associated with the User.</summary>
	public const string msdyn_Capacity = "msdyn_capacity";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Presence, Format: None, SchemaName: msdyn_DefaultPresenceIdUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Presence associated with User.</summary>
	public const string msdyn_DefaultPresenceIdUser = "msdyn_defaultpresenceiduser";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Presence, Format: None, SchemaName: msdyn_DefaultPresenceIdUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Presence associated with User.</summary>
	public const string msdyn_DefaultPresenceIdUser_Lookup = "_msdyn_defaultpresenceiduser_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_defaultpresenceiduser, Format: Text, MaxLength: 100, SchemaName: msdyn_DefaultPresenceIdUserName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_DefaultPresenceIdUserName = "msdyn_defaultpresenceidusername";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether user is opted out or not</summary>
	public const string msdyn_gdproptout = "msdyn_gdproptout";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_gdproptout, SchemaName: msdyn_gdproptoutName, IntroducedVersion: 1.0. </summary>
	public const string msdyn_gdproptoutName = "msdyn_gdproptoutname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Grid Wrapper Control field, Format: Text, MaxLength: 4000, SchemaName: msdyn_gridwrappercontrolfield, IntroducedVersion: 1.0.0.0.  Description: Field to bind grid wrapper control</summary>
	public const string msdyn_gridwrappercontrolfield = "msdyn_gridwrappercontrolfield";

	/// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, DisplayName: Expert Enabled Swarm, SchemaName: msdyn_isexpertenabledforswarm, IntroducedVersion: 1.0.0.0.  Description: Check if swarm is enabled for the experts.</summary>
	public const string msdyn_isexpertenabledforswarm = "msdyn_isexpertenabledforswarm";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isexpertenabledforswarm, SchemaName: msdyn_isexpertenabledforswarmName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_isexpertenabledforswarmName = "msdyn_isexpertenabledforswarmname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Owning Environment Id, Format: Text, MaxLength: 500, SchemaName: msdyn_OwningEnvironmentId, IntroducedVersion: 1.0.0.0.  Description: Environment Id of the CDS environment that owns the bot user.</summary>
	public const string msdyn_OwningEnvironmentId = "msdyn_owningenvironmentid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Type, SchemaName: msdyn_UserType, IntroducedVersion: 1.0.0.1.  Description: Type of user - CRM or BOT user</summary>
	public const string msdyn_UserType = "msdyn_usertype";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_usertype, SchemaName: msdyn_usertypeName, IntroducedVersion: 1.0.0.1. </summary>
	public const string msdyn_usertypeName = "msdyn_usertypename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Nickname, Format: Text, MaxLength: 50, SchemaName: NickName, IntroducedVersion: 5.0.0.0.  Description: Nickname of the user.</summary>
	public const string NickName = "nickname";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Organization , SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the organization associated with the user.</summary>
	public const string OrganizationId = "organizationid";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: organizationid, Format: Text, MaxLength: 100, SchemaName: OrganizationIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OrganizationIdName = "organizationidname";

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Outgoing Email Delivery Method, SchemaName: OutgoingEmailDeliveryMethod, IntroducedVersion: 5.0.0.0.  Description: Outgoing email delivery method for the user.</summary>
	public const string OutgoingEmailDeliveryMethod = "outgoingemaildeliverymethod";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: outgoingemaildeliverymethod, SchemaName: OutgoingEmailDeliveryMethodName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OutgoingEmailDeliveryMethodName = "outgoingemaildeliverymethodname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Manager, Format: None, SchemaName: ParentSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the manager of the user.</summary>
	public const string ParentSystemUserId = "parentsystemuserid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Manager, Format: None, SchemaName: ParentSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the manager of the user.</summary>
	public const string ParentSystemUserId_Lookup = "_parentsystemuserid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentsystemuserid, Format: Text, MaxLength: 100, SchemaName: ParentSystemUserIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParentSystemUserIdName = "parentsystemuseridname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentsystemuserid, Format: Text, MaxLength: 100, SchemaName: ParentSystemUserIdYomiName, YomiOf: parentsystemuseridname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParentSystemUserIdYomiName = "parentsystemuseridyominame";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Passport Hi, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: PassportHi, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string PassportHi = "passporthi";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Passport Lo, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: PassportLo, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string PassportLo = "passportlo";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email 2, Format: Email, MaxLength: 100, SchemaName: PersonalEMailAddress, IntroducedVersion: 5.0.0.0.  Description: Personal email address of the user.</summary>
	public const string PersonalEMailAddress = "personalemailaddress";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Photo URL, Format: Url, MaxLength: 200, SchemaName: PhotoUrl, IntroducedVersion: 5.0.0.0.  Description: URL for the Website on which a photo of the user is located.</summary>
	public const string PhotoUrl = "photourl";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Position, Format: None, SchemaName: PositionId, IntroducedVersion: 7.0.0.0.  Description: User's position in hierarchical security model.</summary>
	public const string PositionId = "positionid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Position, Format: None, SchemaName: PositionId, IntroducedVersion: 7.0.0.0.  Description: User's position in hierarchical security model.</summary>
	public const string PositionId_Lookup = "_positionid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: positionid, Format: Text, MaxLength: 100, SchemaName: PositionIdName, IntroducedVersion: 7.0.0.0. </summary>
	public const string PositionIdName = "positionidname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Address, SchemaName: PreferredAddressCode, IntroducedVersion: 5.0.0.0.  Description: Preferred address for the user.</summary>
	public const string PreferredAddressCode = "preferredaddresscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredaddresscode, SchemaName: PreferredAddressCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredAddressCodeName = "preferredaddresscodename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Email, SchemaName: PreferredEmailCode, IntroducedVersion: 5.0.0.0.  Description: Preferred email address for the user.</summary>
	public const string PreferredEmailCode = "preferredemailcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredemailcode, SchemaName: PreferredEmailCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredEmailCodeName = "preferredemailcodename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Phone, SchemaName: PreferredPhoneCode, IntroducedVersion: 5.0.0.0.  Description: Preferred phone number for the user.</summary>
	public const string PreferredPhoneCode = "preferredphonecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredphonecode, SchemaName: PreferredPhoneCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredPhoneCodeName = "preferredphonecodename";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process, SchemaName: ProcessId, IntroducedVersion: 6.0.0.0.  Description: Shows the ID of the process.</summary>
	public const string ProcessId = "processid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the user.</summary>
	public const string QueueId = "queueid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the user.</summary>
	public const string QueueId_Lookup = "_queueid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: queueid, Format: Text, MaxLength: 400, SchemaName: QueueIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string QueueIdName = "queueidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Salutation, Format: Text, MaxLength: 20, SchemaName: Salutation, IntroducedVersion: 5.0.0.0.  Description: Salutation for correspondence with the user.</summary>
	public const string Salutation = "salutation";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Restricted Access Mode, SchemaName: SetupUser, IntroducedVersion: 5.0.0.0.  Description: Check if user is a setup user.</summary>
	public const string SetupUser = "setupuser";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: setupuser, SchemaName: SetupUserName, IntroducedVersion: 5.0.0.0. </summary>
	public const string SetupUserName = "setupusername";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: SharePoint Email Address, Format: Text, MaxLength: 1024, SchemaName: SharePointEmailAddress, IntroducedVersion: 7.1.0.0.  Description: SharePoint Work Email Address</summary>
	public const string SharePointEmailAddress = "sharepointemailaddress";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site at which the user is located.</summary>
	public const string SiteId = "siteid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site at which the user is located.</summary>
	public const string SiteId_Lookup = "_siteid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: siteid, Format: Text, MaxLength: 100, SchemaName: SiteIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string SiteIdName = "siteidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Skills, Format: Text, MaxLength: 100, SchemaName: Skills, IntroducedVersion: 5.0.0.0.  Description: Skill set of the user.</summary>
	public const string Skills = "skills";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Process Stage, SchemaName: StageId, IntroducedVersion: 6.0.0.0.  Description: Shows the ID of the stage.</summary>
	public const string StageId = "stageid";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: User, SchemaName: SystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the user.</summary>
	public const string SystemUserId = "systemuserid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the territory to which the user is assigned.</summary>
	public const string TerritoryId = "territoryid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the territory to which the user is assigned.</summary>
	public const string TerritoryId_Lookup = "_territoryid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: territoryid, Format: Text, MaxLength: 100, SchemaName: TerritoryIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string TerritoryIdName = "territoryidname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Title, Format: Text, MaxLength: 128, SchemaName: Title, IntroducedVersion: 5.0.0.0.  Description: Title of the user.</summary>
	public const string Title = "title";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the systemuser.</summary>
	public const string TransactionCurrencyId = "transactioncurrencyid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the systemuser.</summary>
	public const string TransactionCurrencyId_Lookup = "_transactioncurrencyid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: TraversedPath, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	public const string TraversedPath = "traversedpath";

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: User License Type, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: UserLicenseType, IntroducedVersion: 6.0.0.0.  Description: Shows the type of user license.</summary>
	public const string UserLicenseType = "userlicensetype";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: User PUID, Format: Text, MaxLength: 100, SchemaName: UserPuid, IntroducedVersion: 9.0.0.0.  Description:  User PUID User Identifiable Information</summary>
	public const string UserPuid = "userpuid";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the user.</summary>
	public const string VersionNumber = "versionnumber";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Windows Live ID, Format: Email, MaxLength: 1024, SchemaName: WindowsLiveID, IntroducedVersion: 5.0.0.0.  Description: Windows Live ID</summary>
	public const string WindowsLiveID = "windowsliveid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yammer Email, Format: Email, MaxLength: 200, SchemaName: YammerEmailAddress, IntroducedVersion: 5.0.0.0.  Description: User's Yammer login email address</summary>
	public const string YammerEmailAddress = "yammeremailaddress";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yammer User ID, Format: Text, MaxLength: 128, SchemaName: YammerUserId, IntroducedVersion: 5.0.0.0.  Description: User's Yammer ID</summary>
	public const string YammerUserId = "yammeruserid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi First Name, Format: PhoneticGuide, MaxLength: 64, SchemaName: YomiFirstName, YomiOf: firstname, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.</summary>
	public const string YomiFirstName = "yomifirstname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Full Name, Format: PhoneticGuide, MaxLength: 200, SchemaName: YomiFullName, YomiOf: fullname, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.</summary>
	public const string YomiFullName = "yomifullname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Last Name, Format: PhoneticGuide, MaxLength: 64, SchemaName: YomiLastName, YomiOf: lastname, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.</summary>
	public const string YomiLastName = "yomilastname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Middle Name, Format: PhoneticGuide, MaxLength: 50, SchemaName: YomiMiddleName, YomiOf: middlename, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.</summary>
	public const string YomiMiddleName = "yomimiddlename";

}

