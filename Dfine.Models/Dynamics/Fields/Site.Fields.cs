namespace ECSM.Models.Dynamics;

/// <summary>Location or branch office where an organization does business. An organization can have multiple sites.</summary>
public static partial class SiteField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "siteid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "name";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "Sites";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "sites";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "sites";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "site";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "Site";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 1: ID, SchemaName: Address1_AddressId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for address 1.</summary>
	public const string Address1_AddressId = "address1_addressid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Address Type, SchemaName: Address1_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of address for address 1, such as billing, shipping, or primary address.</summary>
	public const string Address1_AddressTypeCode = "address1_addresstypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_addresstypecode, SchemaName: Address1_AddressTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address1_AddressTypeCodeName = "address1_addresstypecodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: City, Format: Text, MaxLength: 80, SchemaName: Address1_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 1.</summary>
	public const string Address1_City = "address1_city";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address1_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name for address 1.</summary>
	public const string Address1_Country = "address1_country";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: County, Format: Text, MaxLength: 50, SchemaName: Address1_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 1.</summary>
	public const string Address1_County = "address1_county";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Fax, Format: Text, MaxLength: 50, SchemaName: Address1_Fax, IntroducedVersion: 5.0.0.0.  Description: Fax number for address 1.</summary>
	public const string Address1_Fax = "address1_fax";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address1_Latitude, IntroducedVersion: 5.0.0.0.  Description: Latitude for address 1.</summary>
	public const string Address1_Latitude = "address1_latitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 1, Format: Text, MaxLength: 250, SchemaName: Address1_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 1 information.</summary>
	public const string Address1_Line1 = "address1_line1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 2, Format: Text, MaxLength: 250, SchemaName: Address1_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 1 information.</summary>
	public const string Address1_Line2 = "address1_line2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 3, Format: Text, MaxLength: 250, SchemaName: Address1_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 1 information.</summary>
	public const string Address1_Line3 = "address1_line3";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address1_Longitude, IntroducedVersion: 5.0.0.0.  Description: Longitude for address 1.</summary>
	public const string Address1_Longitude = "address1_longitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Name, Format: Text, MaxLength: 100, SchemaName: Address1_Name, IntroducedVersion: 5.0.0.0.  Description: Name to enter for address 1.</summary>
	public const string Address1_Name = "address1_name";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address1_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 1.</summary>
	public const string Address1_PostalCode = "address1_postalcode";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address1_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 1.</summary>
	public const string Address1_PostOfficeBox = "address1_postofficebox";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Shipping Method, SchemaName: Address1_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 1.</summary>
	public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_shippingmethodcode, SchemaName: Address1_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address1_ShippingMethodCodeName = "address1_shippingmethodcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: State/Province, Format: Text, MaxLength: 50, SchemaName: Address1_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 1.</summary>
	public const string Address1_StateOrProvince = "address1_stateorprovince";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Main Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: First telephone number associated with address 1.</summary>
	public const string Address1_Telephone1 = "address1_telephone1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Second telephone number associated with address 1.</summary>
	public const string Address1_Telephone2 = "address1_telephone2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Third telephone number associated with address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: City, Format: Text, MaxLength: 80, SchemaName: Address2_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 2.</summary>
	public const string Address2_City = "address2_city";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address2_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name for address 2.</summary>
	public const string Address2_Country = "address2_country";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: County, Format: Text, MaxLength: 50, SchemaName: Address2_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 2.</summary>
	public const string Address2_County = "address2_county";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Fax, Format: Text, MaxLength: 50, SchemaName: Address2_Fax, IntroducedVersion: 5.0.0.0.  Description: Fax number for address 2.</summary>
	public const string Address2_Fax = "address2_fax";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address2_Latitude, IntroducedVersion: 5.0.0.0.  Description: Latitude for address 2.</summary>
	public const string Address2_Latitude = "address2_latitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 1, Format: Text, MaxLength: 250, SchemaName: Address2_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 2 information.</summary>
	public const string Address2_Line1 = "address2_line1";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 2, Format: Text, MaxLength: 250, SchemaName: Address2_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 2 information.</summary>
	public const string Address2_Line2 = "address2_line2";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 3, Format: Text, MaxLength: 250, SchemaName: Address2_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 2 information.</summary>
	public const string Address2_Line3 = "address2_line3";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address2_Longitude, IntroducedVersion: 5.0.0.0.  Description: Longitude for address 2.</summary>
	public const string Address2_Longitude = "address2_longitude";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Name, Format: Text, MaxLength: 100, SchemaName: Address2_Name, IntroducedVersion: 5.0.0.0.  Description: Name to enter for address 2.</summary>
	public const string Address2_Name = "address2_name";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address2_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 2.</summary>
	public const string Address2_PostalCode = "address2_postalcode";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address2_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 2.</summary>
	public const string Address2_PostOfficeBox = "address2_postofficebox";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Shipping Method, SchemaName: Address2_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 2.</summary>
	public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_shippingmethodcode, SchemaName: Address2_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string Address2_ShippingMethodCodeName = "address2_shippingmethodcodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: State/Province, Format: Text, MaxLength: 50, SchemaName: Address2_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 2.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the site.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the site.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the site was created.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the site.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the site.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress, IntroducedVersion: 5.0.0.0.  Description: Email address for the site.</summary>
	public const string EMailAddress = "emailaddress";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Sequence number of the import that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the site.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the site.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the site was last modified.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the site.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the site.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Name, Format: Text, MaxLength: 160, SchemaName: Name, IntroducedVersion: 5.0.0.0.  Description: Name of the site.</summary>
	public const string Name = "name";

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the organization</summary>
	public const string OrganizationId = "organizationid";

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the organization</summary>
	public const string OrganizationId_Lookup = "_organizationid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: organizationid, Format: Text, MaxLength: 100, SchemaName: OrganizationIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OrganizationIdName = "organizationidname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Site, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the site.</summary>
	public const string SiteId = "siteid";

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Time Zone, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: TimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Local time zone for the site.</summary>
	public const string TimeZoneCode = "timezonecode";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version Number</summary>
	public const string VersionNumber = "versionnumber";

}

