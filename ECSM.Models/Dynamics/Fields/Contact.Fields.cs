namespace ECSM.Models.Dynamics;

/// <summary>Person with whom a business unit has a relationship, such as customer, supplier, and colleague.</summary>
public static partial class ContactField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "contactid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "fullname";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "Contacts";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "contacts";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "contacts";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "contact";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "Contact";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "entityimage";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contact is associated.</summary>
	public const string AccountId = "accountid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contact is associated.</summary>
	public const string AccountId_Lookup = "_accountid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 100, SchemaName: AccountIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string AccountIdName = "accountidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 100, SchemaName: AccountIdYomiName, YomiOf: accountidname, IntroducedVersion: 5.0.0.0. </summary>
	public const string AccountIdYomiName = "accountidyominame";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Role, SchemaName: AccountRoleCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.</summary>
	public const string AccountRoleCode = "accountrolecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: accountrolecode, SchemaName: AccountRoleCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string AccountRoleCodeName = "accountrolecodename";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 1: ID, SchemaName: Address1_AddressId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for address 1.</summary>
	public const string Address1_AddressId = "address1_addressid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Address Type, SchemaName: Address1_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary address type.</summary>
	public const string Address1_AddressTypeCode = "address1_addresstypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_addresstypecode, SchemaName: Address1_AddressTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address1_AddressTypeCodeName = "address1_addresstypecodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: City, Format: Text, MaxLength: 80, SchemaName: Address1_City, IntroducedVersion: 5.0.0.0.  Description: Type the city for the primary address.</summary>
	public const string Address1_City = "address1_city";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address 1, Format: TextArea, MaxLength: 1000, SchemaName: Address1_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete primary address.</summary>
	public const string Address1_Composite = "address1_composite";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address1_Country, IntroducedVersion: 5.0.0.0.  Description: Type the country or region for the primary address.</summary>
	public const string Address1_Country = "address1_country";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: County, Format: Text, MaxLength: 50, SchemaName: Address1_County, IntroducedVersion: 5.0.0.0.  Description: Type the county for the primary address.</summary>
	public const string Address1_County = "address1_county";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Fax, Format: Text, MaxLength: 50, SchemaName: Address1_Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number associated with the primary address.</summary>
	public const string Address1_Fax = "address1_fax";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Freight Terms, SchemaName: Address1_FreightTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the freight terms for the primary address to make sure shipping orders are processed correctly.</summary>
	public const string Address1_FreightTermsCode = "address1_freighttermscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_freighttermscode, SchemaName: Address1_FreightTermsCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address1_FreightTermsCodeName = "address1_freighttermscodename";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address1_Latitude, IntroducedVersion: 5.0.0.0.  Description: Type the latitude value for the primary address for use in mapping and other applications.</summary>
	public const string Address1_Latitude = "address1_latitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Street 1, Format: Text, MaxLength: 250, SchemaName: Address1_Line1, IntroducedVersion: 5.0.0.0.  Description: Type the first line of the primary address.</summary>
	public const string Address1_Line1 = "address1_line1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Street 2, Format: Text, MaxLength: 250, SchemaName: Address1_Line2, IntroducedVersion: 5.0.0.0.  Description: Type the second line of the primary address.</summary>
	public const string Address1_Line2 = "address1_line2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Street 3, Format: Text, MaxLength: 250, SchemaName: Address1_Line3, IntroducedVersion: 5.0.0.0.  Description: Type the third line of the primary address.</summary>
	public const string Address1_Line3 = "address1_line3";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address1_Longitude, IntroducedVersion: 5.0.0.0.  Description: Type the longitude value for the primary address for use in mapping and other applications.</summary>
	public const string Address1_Longitude = "address1_longitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Name, Format: Text, MaxLength: 200, SchemaName: Address1_Name, IntroducedVersion: 5.0.0.0.  Description: Type a descriptive name for the primary address, such as Corporate Headquarters.</summary>
	public const string Address1_Name = "address1_name";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address1_PostalCode, IntroducedVersion: 5.0.0.0.  Description: Type the ZIP Code or postal code for the primary address.</summary>
	public const string Address1_PostalCode = "address1_postalcode";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address1_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Type the post office box number of the primary address.</summary>
	public const string Address1_PostOfficeBox = "address1_postofficebox";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Primary Contact Name, Format: Text, MaxLength: 100, SchemaName: Address1_PrimaryContactName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the main contact at the account's primary address.</summary>
	public const string Address1_PrimaryContactName = "address1_primarycontactname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Shipping Method, SchemaName: Address1_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_shippingmethodcode, SchemaName: Address1_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address1_ShippingMethodCodeName = "address1_shippingmethodcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: State/Province, Format: Text, MaxLength: 50, SchemaName: Address1_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: Type the state or province of the primary address.</summary>
	public const string Address1_StateOrProvince = "address1_stateorprovince";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number associated with the primary address.</summary>
	public const string Address1_Telephone1 = "address1_telephone1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Telephone 2, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type a second phone number associated with the primary address.</summary>
	public const string Address1_Telephone2 = "address1_telephone2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type a third phone number associated with the primary address.</summary>
	public const string Address1_Telephone3 = "address1_telephone3";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address1_UPSZone, IntroducedVersion: 5.0.0.0.  Description: Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</summary>
	public const string Address1_UPSZone = "address1_upszone";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 1: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address1_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</summary>
	public const string Address1_UTCOffset = "address1_utcoffset";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 2: ID, SchemaName: Address2_AddressId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for address 2.</summary>
	public const string Address2_AddressId = "address2_addressid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Address Type, SchemaName: Address2_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the secondary address type.</summary>
	public const string Address2_AddressTypeCode = "address2_addresstypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_addresstypecode, SchemaName: Address2_AddressTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address2_AddressTypeCodeName = "address2_addresstypecodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: City, Format: Text, MaxLength: 80, SchemaName: Address2_City, IntroducedVersion: 5.0.0.0.  Description: Type the city for the secondary address.</summary>
	public const string Address2_City = "address2_city";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address 2, Format: TextArea, MaxLength: 1000, SchemaName: Address2_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete secondary address.</summary>
	public const string Address2_Composite = "address2_composite";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address2_Country, IntroducedVersion: 5.0.0.0.  Description: Type the country or region for the secondary address.</summary>
	public const string Address2_Country = "address2_country";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: County, Format: Text, MaxLength: 50, SchemaName: Address2_County, IntroducedVersion: 5.0.0.0.  Description: Type the county for the secondary address.</summary>
	public const string Address2_County = "address2_county";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Fax, Format: Text, MaxLength: 50, SchemaName: Address2_Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number associated with the secondary address.</summary>
	public const string Address2_Fax = "address2_fax";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Freight Terms, SchemaName: Address2_FreightTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the freight terms for the secondary address to make sure shipping orders are processed correctly.</summary>
	public const string Address2_FreightTermsCode = "address2_freighttermscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_freighttermscode, SchemaName: Address2_FreightTermsCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address2_FreightTermsCodeName = "address2_freighttermscodename";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address2_Latitude, IntroducedVersion: 5.0.0.0.  Description: Type the latitude value for the secondary address for use in mapping and other applications.</summary>
	public const string Address2_Latitude = "address2_latitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 1, Format: Text, MaxLength: 250, SchemaName: Address2_Line1, IntroducedVersion: 5.0.0.0.  Description: Type the first line of the secondary address.</summary>
	public const string Address2_Line1 = "address2_line1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 2, Format: Text, MaxLength: 250, SchemaName: Address2_Line2, IntroducedVersion: 5.0.0.0.  Description: Type the second line of the secondary address.</summary>
	public const string Address2_Line2 = "address2_line2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 3, Format: Text, MaxLength: 250, SchemaName: Address2_Line3, IntroducedVersion: 5.0.0.0.  Description: Type the third line of the secondary address.</summary>
	public const string Address2_Line3 = "address2_line3";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address2_Longitude, IntroducedVersion: 5.0.0.0.  Description: Type the longitude value for the secondary address for use in mapping and other applications.</summary>
	public const string Address2_Longitude = "address2_longitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Name, Format: Text, MaxLength: 100, SchemaName: Address2_Name, IntroducedVersion: 5.0.0.0.  Description: Type a descriptive name for the secondary address, such as Corporate Headquarters.</summary>
	public const string Address2_Name = "address2_name";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address2_PostalCode, IntroducedVersion: 5.0.0.0.  Description: Type the ZIP Code or postal code for the secondary address.</summary>
	public const string Address2_PostalCode = "address2_postalcode";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address2_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Type the post office box number of the secondary address.</summary>
	public const string Address2_PostOfficeBox = "address2_postofficebox";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Primary Contact Name, Format: Text, MaxLength: 100, SchemaName: Address2_PrimaryContactName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the main contact at the account's secondary address.</summary>
	public const string Address2_PrimaryContactName = "address2_primarycontactname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Shipping Method, SchemaName: Address2_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_shippingmethodcode, SchemaName: Address2_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address2_ShippingMethodCodeName = "address2_shippingmethodcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: State/Province, Format: Text, MaxLength: 50, SchemaName: Address2_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: Type the state or province of the secondary address.</summary>
	public const string Address2_StateOrProvince = "address2_stateorprovince";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 1, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number associated with the secondary address.</summary>
	public const string Address2_Telephone1 = "address2_telephone1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 2, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type a second phone number associated with the secondary address.</summary>
	public const string Address2_Telephone2 = "address2_telephone2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type a third phone number associated with the secondary address.</summary>
	public const string Address2_Telephone3 = "address2_telephone3";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address2_UPSZone, IntroducedVersion: 5.0.0.0.  Description: Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</summary>
	public const string Address2_UPSZone = "address2_upszone";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 2: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address2_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</summary>
	public const string Address2_UTCOffset = "address2_utcoffset";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 3: ID, SchemaName: Address3_AddressId, IntroducedVersion: 7.0.0.0.  Description: Unique identifier for address 3.</summary>
	public const string Address3_AddressId = "address3_addressid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Address Type, SchemaName: Address3_AddressTypeCode, IntroducedVersion: 7.0.0.0.  Description: Select the third address type.</summary>
	public const string Address3_AddressTypeCode = "address3_addresstypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address3_addresstypecode, SchemaName: Address3_AddressTypeCodeName, IntroducedVersion: 7.0.0.0. </summary>
	public const string Address3_AddressTypeCodeName = "address3_addresstypecodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: City, Format: Text, MaxLength: 80, SchemaName: Address3_City, IntroducedVersion: 7.0.0.0.  Description: Type the city for the 3rd address.</summary>
	public const string Address3_City = "address3_city";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address 3, Format: TextArea, MaxLength: 1000, SchemaName: Address3_Composite, IntroducedVersion: 7.0.0.0.  Description: Shows the complete third address.</summary>
	public const string Address3_Composite = "address3_composite";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address3_Country, IntroducedVersion: 7.0.0.0.  Description: the country or region for the 3rd address.</summary>
	public const string Address3_Country = "address3_country";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: County, Format: Text, MaxLength: 50, SchemaName: Address3_County, IntroducedVersion: 7.0.0.0.  Description: Type the county for the third address.</summary>
	public const string Address3_County = "address3_county";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Fax, Format: Text, MaxLength: 50, SchemaName: Address3_Fax, IntroducedVersion: 7.0.0.0.  Description: Type the fax number associated with the third address.</summary>
	public const string Address3_Fax = "address3_fax";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Freight Terms, SchemaName: Address3_FreightTermsCode, IntroducedVersion: 7.0.0.0.  Description: Select the freight terms for the third address to make sure shipping orders are processed correctly.</summary>
	public const string Address3_FreightTermsCode = "address3_freighttermscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address3_freighttermscode, SchemaName: Address3_FreightTermsCodeName, IntroducedVersion: 7.0.0.0. </summary>
	public const string Address3_FreightTermsCodeName = "address3_freighttermscodename";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 3: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address3_Latitude, IntroducedVersion: 7.0.0.0.  Description: Type the latitude value for the third address for use in mapping and other applications.</summary>
	public const string Address3_Latitude = "address3_latitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Street 1, Format: Text, MaxLength: 250, SchemaName: Address3_Line1, IntroducedVersion: 7.0.0.0.  Description: the first line of the 3rd address.</summary>
	public const string Address3_Line1 = "address3_line1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Street 2, Format: Text, MaxLength: 250, SchemaName: Address3_Line2, IntroducedVersion: 7.0.0.0.  Description: the second line of the 3rd address.</summary>
	public const string Address3_Line2 = "address3_line2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Street 3, Format: Text, MaxLength: 250, SchemaName: Address3_Line3, IntroducedVersion: 7.0.0.0.  Description: the third line of the 3rd address.</summary>
	public const string Address3_Line3 = "address3_line3";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 3: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address3_Longitude, IntroducedVersion: 7.0.0.0.  Description: Type the longitude value for the third address for use in mapping and other applications.</summary>
	public const string Address3_Longitude = "address3_longitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Name, Format: Text, MaxLength: 200, SchemaName: Address3_Name, IntroducedVersion: 7.0.0.0.  Description: Type a descriptive name for the third address, such as Corporate Headquarters.</summary>
	public const string Address3_Name = "address3_name";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address3_PostalCode, IntroducedVersion: 7.0.0.0.  Description: the ZIP Code or postal code for the 3rd address.</summary>
	public const string Address3_PostalCode = "address3_postalcode";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address3_PostOfficeBox, IntroducedVersion: 7.0.0.0.  Description: the post office box number of the 3rd address.</summary>
	public const string Address3_PostOfficeBox = "address3_postofficebox";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Primary Contact Name, Format: Text, MaxLength: 100, SchemaName: Address3_PrimaryContactName, IntroducedVersion: 7.0.0.0.  Description: Type the name of the main contact at the account's third address.</summary>
	public const string Address3_PrimaryContactName = "address3_primarycontactname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Shipping Method, SchemaName: Address3_ShippingMethodCode, IntroducedVersion: 7.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	public const string Address3_ShippingMethodCode = "address3_shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address3_shippingmethodcode, SchemaName: Address3_ShippingMethodCodeName, IntroducedVersion: 7.0.0.0. </summary>
	public const string Address3_ShippingMethodCodeName = "address3_shippingmethodcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: State/Province, Format: Text, MaxLength: 50, SchemaName: Address3_StateOrProvince, IntroducedVersion: 7.0.0.0.  Description: the state or province of the third address.</summary>
	public const string Address3_StateOrProvince = "address3_stateorprovince";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Telephone1, Format: Text, MaxLength: 50, SchemaName: Address3_Telephone1, IntroducedVersion: 7.0.0.0.  Description: Type the main phone number associated with the third address.</summary>
	public const string Address3_Telephone1 = "address3_telephone1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Telephone2, Format: Text, MaxLength: 50, SchemaName: Address3_Telephone2, IntroducedVersion: 7.0.0.0.  Description: Type a second phone number associated with the third address.</summary>
	public const string Address3_Telephone2 = "address3_telephone2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Telephone3, Format: Text, MaxLength: 50, SchemaName: Address3_Telephone3, IntroducedVersion: 7.0.0.0.  Description: Type a third phone number associated with the primary address.</summary>
	public const string Address3_Telephone3 = "address3_telephone3";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address3_UPSZone, IntroducedVersion: 7.0.0.0.  Description: Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</summary>
	public const string Address3_UPSZone = "address3_upszone";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 3: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address3_UTCOffset, IntroducedVersion: 7.0.0.0.  Description: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</summary>
	public const string Address3_UTCOffset = "address3_utcoffset";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Confirm Remove Password, SchemaName: adx_ConfirmRemovePassword, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_ConfirmRemovePassword = "adx_confirmremovepassword";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_confirmremovepassword, SchemaName: adx_confirmremovepasswordName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_confirmremovepasswordName = "adx_confirmremovepasswordname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Created By IP Address, Format: Text, MaxLength: 100, SchemaName: Adx_CreatedByIPAddress, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_CreatedByIPAddress = "adx_createdbyipaddress";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Created By Username, Format: Text, MaxLength: 100, SchemaName: Adx_CreatedByUsername, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_CreatedByUsername = "adx_createdbyusername";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Access Failed Count, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: adx_identity_accessfailedcount, IntroducedVersion: 1.0.0.0.  Description: Shows the current count of failed password attempts for the contact.</summary>
	public const string adx_identity_accessfailedcount = "adx_identity_accessfailedcount";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Email Confirmed, SchemaName: adx_identity_emailaddress1confirmed, IntroducedVersion: 1.0.0.0.  Description: Determines if the email is confirmed by the contact.</summary>
	public const string adx_identity_emailaddress1confirmed = "adx_identity_emailaddress1confirmed";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_emailaddress1confirmed, SchemaName: adx_identity_emailaddress1confirmedName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_emailaddress1confirmedName = "adx_identity_emailaddress1confirmedname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Successful Login, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_identity_lastsuccessfullogin, IntroducedVersion: 1.0.0.0.  Description: Indicates the last date and time the user successfully signed in to a portal.</summary>
	public const string adx_identity_lastsuccessfullogin = "adx_identity_lastsuccessfullogin";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Local Login Disabled, SchemaName: adx_identity_locallogindisabled, IntroducedVersion: 1.0.0.0.  Description: Indicates that the contact can no longer sign in to the portal using the local account.</summary>
	public const string adx_identity_locallogindisabled = "adx_identity_locallogindisabled";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_locallogindisabled, SchemaName: adx_identity_locallogindisabledName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_locallogindisabledName = "adx_identity_locallogindisabledname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Lockout Enabled, SchemaName: adx_identity_lockoutenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if this contact will track failed access attempts and become locked after too many failed attempts. To prevent the contact from becoming locked, you can disable this setting.</summary>
	public const string adx_identity_lockoutenabled = "adx_identity_lockoutenabled";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_lockoutenabled, SchemaName: adx_identity_lockoutenabledName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_lockoutenabledName = "adx_identity_lockoutenabledname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Lockout End Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_identity_lockoutenddate, IntroducedVersion: 1.0.0.0.  Description: Shows the moment in time when the locked contact becomes unlocked again.</summary>
	public const string adx_identity_lockoutenddate = "adx_identity_lockoutenddate";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Login Enabled, SchemaName: adx_identity_logonenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if web authentication is enabled for the contact.</summary>
	public const string adx_identity_logonenabled = "adx_identity_logonenabled";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_logonenabled, SchemaName: adx_identity_logonenabledName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_logonenabledName = "adx_identity_logonenabledname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Mobile Phone Confirmed, SchemaName: adx_identity_mobilephoneconfirmed, IntroducedVersion: 1.0.0.0.  Description: Determines if the phone number is confirmed by the contact.</summary>
	public const string adx_identity_mobilephoneconfirmed = "adx_identity_mobilephoneconfirmed";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_mobilephoneconfirmed, SchemaName: adx_identity_mobilephoneconfirmedName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_mobilephoneconfirmedName = "adx_identity_mobilephoneconfirmedname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: New Password Input, Format: Text, MaxLength: 100, SchemaName: adx_identity_newpassword, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_newpassword = "adx_identity_newpassword";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Password Hash, Format: Text, MaxLength: 128, SchemaName: adx_identity_passwordhash, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_passwordhash = "adx_identity_passwordhash";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Security Stamp, Format: Text, MaxLength: 100, SchemaName: adx_identity_securitystamp, IntroducedVersion: 1.0.0.0.  Description: A token used to manage the web authentication session.</summary>
	public const string adx_identity_securitystamp = "adx_identity_securitystamp";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Two Factor Enabled, SchemaName: adx_identity_twofactorenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if two-factor authentication is enabled for the contact.</summary>
	public const string adx_identity_twofactorenabled = "adx_identity_twofactorenabled";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_twofactorenabled, SchemaName: adx_identity_twofactorenabledName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_identity_twofactorenabledName = "adx_identity_twofactorenabledname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: User Name, Format: Text, MaxLength: 100, SchemaName: adx_identity_username, IntroducedVersion: 1.0.0.0.  Description: Shows the user identity for local web authentication.</summary>
	public const string adx_identity_username = "adx_identity_username";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Modified By IP Address, Format: Text, MaxLength: 100, SchemaName: Adx_ModifiedByIPAddress, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_ModifiedByIPAddress = "adx_modifiedbyipaddress";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Modified By Username, Format: Text, MaxLength: 100, SchemaName: Adx_ModifiedByUsername, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_ModifiedByUsername = "adx_modifiedbyusername";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Organization Name, Format: Text, MaxLength: 250, SchemaName: Adx_OrganizationName, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_OrganizationName = "adx_organizationname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Preferred LCID (Deprecated), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: adx_preferredlcid, IntroducedVersion: 1.0.0.0.  Description: User’s preferred portal LCID</summary>
	public const string adx_preferredlcid = "adx_preferredlcid";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Profile Alert, SchemaName: adx_profilealert, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_profilealert = "adx_profilealert";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Profile Alert Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_profilealertdate, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_profilealertdate = "adx_profilealertdate";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Profile Alert Instructions, Format: Text, MaxLength: 4096, SchemaName: adx_profilealertinstructions, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_profilealertinstructions = "adx_profilealertinstructions";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_profilealert, SchemaName: adx_profilealertName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_profilealertName = "adx_profilealertname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Profile Is Anonymous, SchemaName: Adx_ProfileIsAnonymous, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_ProfileIsAnonymous = "adx_profileisanonymous";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_profileisanonymous, SchemaName: adx_profileisanonymousName, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_profileisanonymousName = "adx_profileisanonymousname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Profile Last Activity, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: Adx_ProfileLastActivity, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_ProfileLastActivity = "adx_profilelastactivity";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Profile Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_profilemodifiedon, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_profilemodifiedon = "adx_profilemodifiedon";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Public Profile Copy, Format: Text, MaxLength: 64000, SchemaName: adx_PublicProfileCopy, IntroducedVersion: 1.0.0.0. </summary>
	public const string adx_PublicProfileCopy = "adx_publicprofilecopy";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Adx_TimeZone, IntroducedVersion: 1.0.0.0. </summary>
	public const string Adx_TimeZone = "adx_timezone";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging30, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	public const string Aging30 = "aging30";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30 (Base), CalculationOf: aging30, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging30_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	public const string Aging30_Base = "aging30_base";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging60, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	public const string Aging60 = "aging60";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60 (Base), CalculationOf: aging60, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging60_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	public const string Aging60_Base = "aging60_base";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging90, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	public const string Aging90 = "aging90";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90 (Base), CalculationOf: aging90, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging90_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	public const string Aging90_Base = "aging90_base";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Anniversary, DateTimeBehavior: DateOnly, Format: DateOnly, SchemaName: Anniversary, IntroducedVersion: 5.0.0.0.  Description: Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.</summary>
	public const string Anniversary = "anniversary";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Income, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: AnnualIncome, IntroducedVersion: 5.0.0.0.  Description: Type the contact's annual income for use in profiling and financial analysis.</summary>
	public const string AnnualIncome = "annualincome";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Income (Base), CalculationOf: annualincome, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: AnnualIncome_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	public const string AnnualIncome_Base = "annualincome_base";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Assistant, Format: Text, MaxLength: 100, SchemaName: AssistantName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the contact's assistant.</summary>
	public const string AssistantName = "assistantname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Assistant Phone, Format: Text, MaxLength: 50, SchemaName: AssistantPhone, IntroducedVersion: 5.0.0.0.  Description: Type the phone number for the contact's assistant.</summary>
	public const string AssistantPhone = "assistantphone";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Birthday, DateTimeBehavior: DateOnly, Format: DateOnly, SchemaName: BirthDate, IntroducedVersion: 5.0.0.0.  Description: Enter the contact's birthday for use in customer gift programs or other communications.</summary>
	public const string BirthDate = "birthdate";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Business Phone 2, Format: Text, MaxLength: 50, SchemaName: Business2, IntroducedVersion: 7.0.0.0.  Description: Type a second business phone number for this contact.</summary>
	public const string Business2 = "business2";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Business Card, Format: TextArea, MaxLength: 1073741823, SchemaName: BusinessCard, IntroducedVersion: 9.0.0.0.  Description: Stores Image of the Business Card</summary>
	public const string BusinessCard = "businesscard";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: BusinessCardAttributes, Format: Text, MaxLength: 4000, SchemaName: BusinessCardAttributes, IntroducedVersion: 9.0.0.0.  Description: Stores Business Card Control Properties.</summary>
	public const string BusinessCardAttributes = "businesscardattributes";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Callback Number, Format: Text, MaxLength: 50, SchemaName: Callback, IntroducedVersion: 7.0.0.0.  Description: Type a callback phone number for this contact.</summary>
	public const string Callback = "callback";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Children's Names, Format: Text, MaxLength: 255, SchemaName: ChildrensNames, IntroducedVersion: 5.0.0.0.  Description: Type the names of the contact's children for reference in communications and client programs.</summary>
	public const string ChildrensNames = "childrensnames";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Company Phone, Format: Text, MaxLength: 50, SchemaName: Company, IntroducedVersion: 7.0.0.0.  Description: Type the company phone of the contact.</summary>
	public const string Company = "company";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Contact, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact.</summary>
	public const string ContactId = "contactid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who created the record.</summary>
	public const string CreatedByExternalParty = "createdbyexternalparty";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who created the record.</summary>
	public const string CreatedByExternalParty_Lookup = "_createdbyexternalparty_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyName, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedByExternalPartyName = "createdbyexternalpartyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyYomiName, YomiOf: createdbyexternalpartyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedByExternalPartyYomiName = "createdbyexternalpartyyominame";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: CreditLimit, IntroducedVersion: 5.0.0.0.  Description: Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.</summary>
	public const string CreditLimit = "creditlimit";

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit (Base), CalculationOf: creditlimit, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: CreditLimit_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.</summary>
	public const string CreditLimit_Base = "creditlimit_base";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Credit Hold, SchemaName: CreditOnHold, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.</summary>
	public const string CreditOnHold = "creditonhold";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: creditonhold, SchemaName: CreditOnHoldName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreditOnHoldName = "creditonholdname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Size, SchemaName: CustomerSizeCode, IntroducedVersion: 5.0.0.0.  Description: Select the size of the contact's company for segmentation and reporting purposes.</summary>
	public const string CustomerSizeCode = "customersizecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customersizecode, SchemaName: CustomerSizeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CustomerSizeCodeName = "customersizecodename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Type, SchemaName: CustomerTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the category that best describes the relationship between the contact and your organization.</summary>
	public const string CustomerTypeCode = "customertypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customertypecode, SchemaName: CustomerTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CustomerTypeCodeName = "customertypecodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
	public const string DefaultPriceLevelId = "defaultpricelevelid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
	public const string DefaultPriceLevelId_Lookup = "_defaultpricelevelid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: defaultpricelevelid, Format: Text, MaxLength: 100, SchemaName: DefaultPriceLevelIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DefaultPriceLevelIdName = "defaultpricelevelidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Department, Format: Text, MaxLength: 100, SchemaName: Department, IntroducedVersion: 5.0.0.0.  Description: Type the department or business unit where the contact works in the parent company or business.</summary>
	public const string Department = "department";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information to describe the contact, such as an excerpt from the company's website.</summary>
	public const string Description = "description";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Emails, SchemaName: DoNotBulkEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.</summary>
	public const string DoNotBulkEMail = "donotbulkemail";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotbulkemail, SchemaName: DoNotBulkEMailName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DoNotBulkEMailName = "donotbulkemailname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Mails, SchemaName: DoNotBulkPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.</summary>
	public const string DoNotBulkPostalMail = "donotbulkpostalmail";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotbulkpostalmail, SchemaName: DoNotBulkPostalMailName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DoNotBulkPostalMailName = "donotbulkpostalmailname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Emails, SchemaName: DoNotEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.</summary>
	public const string DoNotEMail = "donotemail";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotemail, SchemaName: DoNotEMailName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DoNotEMailName = "donotemailname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Faxes, SchemaName: DoNotFax, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.</summary>
	public const string DoNotFax = "donotfax";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotfax, SchemaName: DoNotFaxName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DoNotFaxName = "donotfaxname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Phone Calls, SchemaName: DoNotPhone, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.</summary>
	public const string DoNotPhone = "donotphone";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotphone, SchemaName: DoNotPhoneName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DoNotPhoneName = "donotphonename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Mails, SchemaName: DoNotPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.</summary>
	public const string DoNotPostalMail = "donotpostalmail";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotpostalmail, SchemaName: DoNotPostalMailName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DoNotPostalMailName = "donotpostalmailname";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotsendmm, SchemaName: DoNotSendMarketingMaterialName, IntroducedVersion: 5.0.0.0. </summary>
	public const string DoNotSendMarketingMaterialName = "donotsendmarketingmaterialname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Send Marketing Materials, SchemaName: DoNotSendMM, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.</summary>
	public const string DoNotSendMM = "donotsendmm";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ADObjectID, Format: Text, MaxLength: 100, SchemaName: ecsm_ADObjectID, IntroducedVersion: 1.0. </summary>
	public const string ecsm_ADObjectID = "ecsm_adobjectid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Education, SchemaName: EducationCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's highest level of education for use in segmentation and analysis.</summary>
	public const string EducationCode = "educationcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: educationcode, SchemaName: EducationCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string EducationCodeName = "educationcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress1, IntroducedVersion: 5.0.0.0.  Description: Type the primary email address for the contact.</summary>
	public const string EMailAddress1 = "emailaddress1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 2, Format: Email, MaxLength: 100, SchemaName: EMailAddress2, IntroducedVersion: 5.0.0.0.  Description: Type the secondary email address for the contact.</summary>
	public const string EMailAddress2 = "emailaddress2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 3, Format: Email, MaxLength: 100, SchemaName: EMailAddress3, IntroducedVersion: 5.0.0.0.  Description: Type an alternate email address for the contact.</summary>
	public const string EMailAddress3 = "emailaddress3";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Employee, Format: Text, MaxLength: 50, SchemaName: EmployeeId, IntroducedVersion: 5.0.0.0.  Description: Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.</summary>
	public const string EmployeeId = "employeeid";

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Entity Image, AttributeOf: entityimageid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: EntityImage, IntroducedVersion: 6.0.0.0.  Description: Shows the default image for the record.</summary>
	public const string EntityImage = "entityimage";

	/// <summary>Type: BigInt, RequiredLevel: None, AttributeOf: entityimageid, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: EntityImage_Timestamp, IntroducedVersion: 6.0.0.0. </summary>
	public const string EntityImage_Timestamp = "entityimage_timestamp";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: entityimageid, Format: Url, MaxLength: 200, SchemaName: EntityImage_URL, IntroducedVersion: 6.0.0.0. </summary>
	public const string EntityImage_URL = "entityimage_url";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Entity Image Id, SchemaName: EntityImageId, IntroducedVersion: 6.0.0.0.  Description: For internal use only.</summary>
	public const string EntityImageId = "entityimageid";

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.</summary>
	public const string ExchangeRate = "exchangerate";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: External User Identifier, Format: Text, MaxLength: 50, SchemaName: ExternalUserIdentifier, IntroducedVersion: 5.0.0.0.  Description: Identifier for an external user.</summary>
	public const string ExternalUserIdentifier = "externaluseridentifier";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Marital Status, SchemaName: FamilyStatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the marital status of the contact for reference in follow-up phone calls and other communications.</summary>
	public const string FamilyStatusCode = "familystatuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: familystatuscode, SchemaName: FamilyStatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string FamilyStatusCodeName = "familystatuscodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Fax, Format: Text, MaxLength: 50, SchemaName: Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number for the contact.</summary>
	public const string Fax = "fax";

	/// <summary>Type: String, RequiredLevel: Recommended, DisplayName: First Name, Format: Text, MaxLength: 50, SchemaName: FirstName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	public const string FirstName = "firstname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow Email Activity, SchemaName: FollowEmail, IntroducedVersion: 8.2.0.0.  Description: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.</summary>
	public const string FollowEmail = "followemail";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: followemail, SchemaName: FollowEmailName, IntroducedVersion: 8.2.0.0. </summary>
	public const string FollowEmailName = "followemailname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: FTP Site, Format: Url, MaxLength: 200, SchemaName: FtpSiteUrl, IntroducedVersion: 5.0.0.0.  Description: Type the URL for the contact's FTP site to enable users to access data and share documents.</summary>
	public const string FtpSiteUrl = "ftpsiteurl";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Full Name, Format: Text, MaxLength: 160, SchemaName: FullName, IntroducedVersion: 5.0.0.0.  Description: Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.</summary>
	public const string FullName = "fullname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Gender, SchemaName: GenderCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	public const string GenderCode = "gendercode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: gendercode, SchemaName: GenderCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string GenderCodeName = "gendercodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Government, Format: Text, MaxLength: 50, SchemaName: GovernmentId, IntroducedVersion: 5.0.0.0.  Description: Type the passport number or other government ID for the contact for use in documents or reports.</summary>
	public const string GovernmentId = "governmentid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Has Children, SchemaName: HasChildrenCode, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact has any children for reference in follow-up phone calls and other communications.</summary>
	public const string HasChildrenCode = "haschildrencode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: haschildrencode, SchemaName: HasChildrenCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string HasChildrenCodeName = "haschildrencodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Home Phone 2, Format: Text, MaxLength: 50, SchemaName: Home2, IntroducedVersion: 7.0.0.0.  Description: Type a second home phone number for this contact.</summary>
	public const string Home2 = "home2";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the data import or data migration that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Auto-created, SchemaName: IsAutoCreate, IntroducedVersion: 5.0.0.0.  Description: Information about whether the contact was auto-created when promoting an email or an appointment.</summary>
	public const string IsAutoCreate = "isautocreate";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Back Office Customer, SchemaName: IsBackofficeCustomer, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.</summary>
	public const string IsBackofficeCustomer = "isbackofficecustomer";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isbackofficecustomer, SchemaName: IsBackofficeCustomerName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsBackofficeCustomerName = "isbackofficecustomername";

	/// <summary>Type: Boolean, RequiredLevel: None, SchemaName: IsPrivate, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsPrivate = "isprivate";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isprivate, SchemaName: IsPrivateName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsPrivateName = "isprivatename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Job Title, Format: Text, MaxLength: 100, SchemaName: JobTitle, IntroducedVersion: 5.0.0.0.  Description: Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	public const string JobTitle = "jobtitle";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Last Name, Format: Text, MaxLength: 50, SchemaName: LastName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	public const string LastName = "lastname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last On Hold Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastOnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Contains the date and time stamp of the last on hold time.</summary>
	public const string LastOnHoldTime = "lastonholdtime";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Date Included in Campaign, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: LastUsedInCampaign, IntroducedVersion: 5.0.0.0.  Description: Shows the date when the contact was last included in a marketing campaign or quick campaign.</summary>
	public const string LastUsedInCampaign = "lastusedincampaign";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Lead Source, SchemaName: LeadSourceCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary marketing source that directed the contact to your organization.</summary>
	public const string LeadSourceCode = "leadsourcecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: leadsourcecode, SchemaName: LeadSourceCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string LeadSourceCodeName = "leadsourcecodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Manager, Format: Text, MaxLength: 100, SchemaName: ManagerName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.</summary>
	public const string ManagerName = "managername";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Manager Phone, Format: Text, MaxLength: 50, SchemaName: ManagerPhone, IntroducedVersion: 5.0.0.0.  Description: Type the phone number for the contact's manager.</summary>
	public const string ManagerPhone = "managerphone";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Marketing Only, SchemaName: MarketingOnly, IntroducedVersion: 8.2.0.0.  Description: Whether is only for marketing</summary>
	public const string MarketingOnly = "marketingonly";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: marketingonly, SchemaName: MarketingOnlyName, IntroducedVersion: 8.2.0.0. </summary>
	public const string MarketingOnlyName = "marketingonlyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string MasterContactIdName = "mastercontactidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterContactIdYomiName, YomiOf: mastercontactidname, IntroducedVersion: 5.0.0.0. </summary>
	public const string MasterContactIdYomiName = "mastercontactidyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master contact for merge.</summary>
	public const string MasterId = "masterid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master contact for merge.</summary>
	public const string MasterId_Lookup = "_masterid_value";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Merged, SchemaName: Merged, IntroducedVersion: 5.0.0.0.  Description: Shows whether the account has been merged with a master contact.</summary>
	public const string Merged = "merged";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: merged, SchemaName: MergedName, IntroducedVersion: 5.0.0.0. </summary>
	public const string MergedName = "mergedname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Middle Name, Format: Text, MaxLength: 50, SchemaName: MiddleName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's middle name or initial to make sure the contact is addressed correctly.</summary>
	public const string MiddleName = "middlename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Mobile Phone, Format: Text, MaxLength: 50, SchemaName: MobilePhone, IntroducedVersion: 5.0.0.0.  Description: Type the mobile phone number for the contact.</summary>
	public const string MobilePhone = "mobilephone";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who modified the record.</summary>
	public const string ModifiedByExternalParty = "modifiedbyexternalparty";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who modified the record.</summary>
	public const string ModifiedByExternalParty_Lookup = "_modifiedbyexternalparty_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyName, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedByExternalPartyName = "modifiedbyexternalpartyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyYomiName, YomiOf: modifiedbyexternalpartyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedByExternalPartyYomiName = "modifiedbyexternalpartyyominame";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record on behalf of another user.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record on behalf of another user.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Contact.</summary>
	public const string msa_managingpartnerid = "msa_managingpartnerid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Contact.</summary>
	public const string msa_managingpartnerid_Lookup = "_msa_managingpartnerid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msa_managingpartnerid, Format: Text, MaxLength: 160, SchemaName: msa_managingpartneridName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msa_managingpartneridName = "msa_managingpartneridname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msa_managingpartnerid, Format: Text, MaxLength: 160, SchemaName: msa_managingpartneridYomiName, YomiOf: msa_managingpartneridname, IntroducedVersion: 1.0.0.0. </summary>
	public const string msa_managingpartneridYomiName = "msa_managingpartneridyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_contactkpiid, IntroducedVersion: 1.0.  Description: Maps to contact KPI records</summary>
	public const string msdyn_contactkpiid = "msdyn_contactkpiid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_contactkpiid, IntroducedVersion: 1.0.  Description: Maps to contact KPI records</summary>
	public const string msdyn_contactkpiid_Lookup = "_msdyn_contactkpiid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_contactkpiid, Format: Text, MaxLength: 100, SchemaName: msdyn_contactkpiidName, IntroducedVersion: 1.0. </summary>
	public const string msdyn_contactkpiidName = "msdyn_contactkpiidname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Decision influence labels, SchemaName: msdyn_decisioninfluencetag, IntroducedVersion: 1.0.0.0.  Description: Indicate buying influence using labels</summary>
	public const string msdyn_decisioninfluencetag = "msdyn_decisioninfluencetag";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_decisioninfluencetag, SchemaName: msdyn_decisioninfluencetagName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_decisioninfluencetagName = "msdyn_decisioninfluencetagname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Disable Web Tracking, SchemaName: msdyn_disablewebtracking, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact has opted out of web tracking.</summary>
	public const string msdyn_disablewebtracking = "msdyn_disablewebtracking";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_disablewebtracking, SchemaName: msdyn_disablewebtrackingName, IntroducedVersion: 8.4.0.0. </summary>
	public const string msdyn_disablewebtrackingName = "msdyn_disablewebtrackingname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether contact is opted out or not</summary>
	public const string msdyn_gdproptout = "msdyn_gdproptout";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_gdproptout, SchemaName: msdyn_gdproptoutName, IntroducedVersion: 1.0. </summary>
	public const string msdyn_gdproptoutName = "msdyn_gdproptoutname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Assistant, SchemaName: msdyn_isassistantinorgchart, IntroducedVersion: 1.0.0.0.  Description: Describes if the contact is an assistant in org chart</summary>
	public const string msdyn_isassistantinorgchart = "msdyn_isassistantinorgchart";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isassistantinorgchart, SchemaName: msdyn_isassistantinorgchartName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_isassistantinorgchartName = "msdyn_isassistantinorgchartname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Minor, SchemaName: msdyn_isminor, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact is considered a minor in their jurisdiction.</summary>
	public const string msdyn_isminor = "msdyn_isminor";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isminor, SchemaName: msdyn_isminorName, IntroducedVersion: 8.4.0.0. </summary>
	public const string msdyn_isminorName = "msdyn_isminorname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Minor with Parental Consent, SchemaName: msdyn_isminorwithparentalconsent, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact is considered a minor in their jurisdiction and has parental consent.</summary>
	public const string msdyn_isminorwithparentalconsent = "msdyn_isminorwithparentalconsent";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isminorwithparentalconsent, SchemaName: msdyn_isminorwithparentalconsentName, IntroducedVersion: 8.4.0.0. </summary>
	public const string msdyn_isminorwithparentalconsentName = "msdyn_isminorwithparentalconsentname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Not at Company Flag, SchemaName: msdyn_orgchangestatus, IntroducedVersion: 1.0.  Description: Whether or not the contact belongs to the associated account</summary>
	public const string msdyn_orgchangestatus = "msdyn_orgchangestatus";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_orgchangestatus, SchemaName: msdyn_orgchangestatusName, IntroducedVersion: 1.0. </summary>
	public const string msdyn_orgchangestatusName = "msdyn_orgchangestatusname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Portal Terms Agreement Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: msdyn_portaltermsagreementdate, IntroducedVersion: 8.4.0.0.  Description: Indicates the date and time that the person agreed to the portal terms and conditions.</summary>
	public const string msdyn_portaltermsagreementdate = "msdyn_portaltermsagreementdate";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Primary Time Zone, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: msdyn_PrimaryTimeZone, IntroducedVersion: 1.0.30.0.  Description: Indicates the primary time zone that the contact works on.</summary>
	public const string msdyn_PrimaryTimeZone = "msdyn_primarytimezone";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Language, SchemaName: mspp_userpreferredlcid, IntroducedVersion: 1.0.0.0.  Description: User’s preferred portal language</summary>
	public const string mspp_userpreferredlcid = "mspp_userpreferredlcid";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: mspp_userpreferredlcid, SchemaName: mspp_userpreferredlcidName, IntroducedVersion: 1.0.0.0. </summary>
	public const string mspp_userpreferredlcidName = "mspp_userpreferredlcidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Nickname, Format: Text, MaxLength: 100, SchemaName: NickName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's nickname.</summary>
	public const string NickName = "nickname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: No. of Children, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: NumberOfChildren, IntroducedVersion: 5.0.0.0.  Description: Type the number of children the contact has for reference in follow-up phone calls and other communications.</summary>
	public const string NumberOfChildren = "numberofchildren";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: On Hold Time (Minutes), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Shows how long, in minutes, that the record was on hold.</summary>
	public const string OnHoldTime = "onholdtime";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.</summary>
	public const string OriginatingLeadId = "originatingleadid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.</summary>
	public const string OriginatingLeadId_Lookup = "_originatingleadid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: originatingleadid, Format: Text, MaxLength: 100, SchemaName: OriginatingLeadIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OriginatingLeadIdName = "originatingleadidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: originatingleadid, Format: Text, MaxLength: 100, SchemaName: OriginatingLeadIdYomiName, YomiOf: originatingleadidname, IntroducedVersion: 5.0.0.0. </summary>
	public const string OriginatingLeadIdYomiName = "originatingleadidyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.</summary>
	public const string OwnerId = "ownerid";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.</summary>
	public const string OwnerId_Lookup = "_ownerid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwnerIdName = "owneridname";

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwnerIdType = "owneridtype";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwnerIdYomiName = "owneridyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the contact.</summary>
	public const string OwningBusinessUnit = "owningbusinessunit";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the contact.</summary>
	public const string OwningBusinessUnit_Lookup = "_owningbusinessunit_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwningBusinessUnitName = "owningbusinessunitname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
	public const string OwningTeam = "owningteam";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
	public const string OwningTeam_Lookup = "_owningteam_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
	public const string OwningUser = "owninguser";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
	public const string OwningUser_Lookup = "_owninguser_value";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pager, Format: Text, MaxLength: 50, SchemaName: Pager, IntroducedVersion: 5.0.0.0.  Description: Type the pager number for the contact.</summary>
	public const string Pager = "pager";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent contact.</summary>
	public const string ParentContactId = "parentcontactid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent contact.</summary>
	public const string ParentContactId_Lookup = "_parentcontactid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentcontactid, Format: Text, MaxLength: 100, SchemaName: ParentContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParentContactIdName = "parentcontactidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentcontactid, Format: Text, MaxLength: 100, SchemaName: ParentContactIdYomiName, YomiOf: parentcontactidname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParentContactIdYomiName = "parentcontactidyominame";

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Company Name, Format: None, SchemaName: ParentCustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.</summary>
	public const string ParentCustomerId = "parentcustomerid";

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Company Name, Format: None, SchemaName: ParentCustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.</summary>
	public const string ParentCustomerId_Lookup = "_parentcustomerid_value";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: parentcustomerid, Format: Text, MaxLength: 160, SchemaName: ParentCustomerIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParentCustomerIdName = "parentcustomeridname";

	/// <summary>Type: EntityName, RequiredLevel: None, DisplayName: Parent Customer Type, AttributeOf: parentcustomerid, SchemaName: ParentCustomerIdType, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParentCustomerIdType = "parentcustomeridtype";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: parentcustomerid, Format: Text, MaxLength: 450, SchemaName: ParentCustomerIdYomiName, YomiOf: parentcustomeridname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParentCustomerIdYomiName = "parentcustomeridyominame";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Participates in Workflow, SchemaName: ParticipatesInWorkflow, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contact participates in workflow rules.</summary>
	public const string ParticipatesInWorkflow = "participatesinworkflow";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: participatesinworkflow, SchemaName: ParticipatesInWorkflowName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ParticipatesInWorkflowName = "participatesinworkflowname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Payment Terms, SchemaName: PaymentTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the payment terms to indicate when the customer needs to pay the total amount.</summary>
	public const string PaymentTermsCode = "paymenttermscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: paymenttermscode, SchemaName: PaymentTermsCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PaymentTermsCodeName = "paymenttermscodename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Day, SchemaName: PreferredAppointmentDayCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred day of the week for service appointments.</summary>
	public const string PreferredAppointmentDayCode = "preferredappointmentdaycode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredappointmentdaycode, SchemaName: PreferredAppointmentDayCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredAppointmentDayCodeName = "preferredappointmentdaycodename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Time, SchemaName: PreferredAppointmentTimeCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred time of day for service appointments.</summary>
	public const string PreferredAppointmentTimeCode = "preferredappointmenttimecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredappointmenttimecode, SchemaName: PreferredAppointmentTimeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredAppointmentTimeCodeName = "preferredappointmenttimecodename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Method of Contact, SchemaName: PreferredContactMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred method of contact.</summary>
	public const string PreferredContactMethodCode = "preferredcontactmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredcontactmethodcode, SchemaName: PreferredContactMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredContactMethodCodeName = "preferredcontactmethodcodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
	public const string PreferredEquipmentId = "preferredequipmentid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
	public const string PreferredEquipmentId_Lookup = "_preferredequipmentid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: preferredequipmentid, Format: Text, MaxLength: 100, SchemaName: PreferredEquipmentIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredEquipmentIdName = "preferredequipmentidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service to make sure services are scheduled correctly for the customer.</summary>
	public const string PreferredServiceId = "preferredserviceid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service to make sure services are scheduled correctly for the customer.</summary>
	public const string PreferredServiceId_Lookup = "_preferredserviceid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: preferredserviceid, Format: Text, MaxLength: 100, SchemaName: PreferredServiceIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredServiceIdName = "preferredserviceidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.</summary>
	public const string PreferredSystemUserId = "preferredsystemuserid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.</summary>
	public const string PreferredSystemUserId_Lookup = "_preferredsystemuserid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: preferredsystemuserid, Format: Text, MaxLength: 100, SchemaName: PreferredSystemUserIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredSystemUserIdName = "preferredsystemuseridname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: preferredsystemuserid, Format: Text, MaxLength: 100, SchemaName: PreferredSystemUserIdYomiName, YomiOf: preferredsystemuseridname, IntroducedVersion: 5.0.0.0. </summary>
	public const string PreferredSystemUserIdYomiName = "preferredsystemuseridyominame";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process, SchemaName: ProcessId, IntroducedVersion: 6.0.0.0.  Description: Shows the ID of the process.</summary>
	public const string ProcessId = "processid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Salutation, Format: Text, MaxLength: 100, SchemaName: Salutation, IntroducedVersion: 5.0.0.0.  Description: Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.</summary>
	public const string Salutation = "salutation";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method, SchemaName: ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	public const string ShippingMethodCode = "shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: shippingmethodcode, SchemaName: ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ShippingMethodCodeName = "shippingmethodcodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Contact record.</summary>
	public const string SLAId = "slaid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Contact record.</summary>
	public const string SLAId_Lookup = "_slaid_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	public const string SLAInvokedId = "slainvokedid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	public const string SLAInvokedId_Lookup = "_slainvokedid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slainvokedid, Format: Text, MaxLength: 100, SchemaName: SLAInvokedIdName, IntroducedVersion: 8.1.0.0. </summary>
	public const string SLAInvokedIdName = "slainvokedidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: SLAName, IntroducedVersion: 8.1.0.0. </summary>
	public const string SLAName = "slaname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Spouse/Partner Name, Format: Text, MaxLength: 100, SchemaName: SpousesName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.</summary>
	public const string SpousesName = "spousesname";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Process Stage, SchemaName: StageId, IntroducedVersion: 6.0.0.0.  Description: Shows the ID of the stage.</summary>
	public const string StageId = "stageid";

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.</summary>
	public const string StateCode = "statecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string StateCodeName = "statecodename";

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's status.</summary>
	public const string StatusCode = "statuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string StatusCodeName = "statuscodename";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Subscription, SchemaName: SubscriptionId, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string SubscriptionId = "subscriptionid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Suffix, Format: Text, MaxLength: 10, SchemaName: Suffix, IntroducedVersion: 5.0.0.0.  Description: Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	public const string Suffix = "suffix";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: TeamsFollowed, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: TeamsFollowed, IntroducedVersion: 9.0.0.0.  Description: Number of users or conversations followed the record</summary>
	public const string TeamsFollowed = "teamsfollowed";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Business Phone, Format: Text, MaxLength: 50, SchemaName: Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number for this contact.</summary>
	public const string Telephone1 = "telephone1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Home Phone, Format: Text, MaxLength: 50, SchemaName: Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type a second phone number for this contact.</summary>
	public const string Telephone2 = "telephone2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type a third phone number for this contact.</summary>
	public const string Telephone3 = "telephone3";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Territory, SchemaName: TerritoryCode, IntroducedVersion: 5.0.0.0.  Description: Select a region or territory for the contact for use in segmentation and analysis.</summary>
	public const string TerritoryCode = "territorycode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: territorycode, SchemaName: TerritoryCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string TerritoryCodeName = "territorycodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Time Spent by me, Format: Text, MaxLength: 1250, SchemaName: TimeSpentByMeOnEmailAndMeetings, IntroducedVersion: 8.2.0.0.  Description: Total time spent for emails (read and write) and meetings by me in relation to the contact record.</summary>
	public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
	public const string TransactionCurrencyId = "transactioncurrencyid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
	public const string TransactionCurrencyId_Lookup = "_transactioncurrencyid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: TraversedPath, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	public const string TraversedPath = "traversedpath";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the contact.</summary>
	public const string VersionNumber = "versionnumber";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Website, Format: Url, MaxLength: 200, SchemaName: WebSiteUrl, IntroducedVersion: 5.0.0.0.  Description: Type the contact's professional or personal website or blog URL.</summary>
	public const string WebSiteUrl = "websiteurl";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi First Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiFirstName, YomiOf: firstname, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.</summary>
	public const string YomiFirstName = "yomifirstname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Full Name, Format: PhoneticGuide, MaxLength: 450, SchemaName: YomiFullName, YomiOf: fullname, IntroducedVersion: 5.0.0.0.  Description: Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.</summary>
	public const string YomiFullName = "yomifullname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Last Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiLastName, YomiOf: lastname, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.</summary>
	public const string YomiLastName = "yomilastname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Middle Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiMiddleName, YomiOf: middlename, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.</summary>
	public const string YomiMiddleName = "yomimiddlename";

}

