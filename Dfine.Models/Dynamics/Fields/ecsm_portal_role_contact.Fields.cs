namespace ECSM.Models.Dynamics;

public static partial class ecsm_portal_role_contactField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "ecsm_portal_role_contactid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "ecsm_portal_role_contactset";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "ecsm_portal_role_contact";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "ecsm_portal_role_contact";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: contactid, IntroducedVersion: 1.0.0.0. </summary>
	public const string contactid = "contactid";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: ecsm_portal_role_contactId, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_role_contactId = "ecsm_portal_role_contactid";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: ecsm_portal_roleid, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_roleid = "ecsm_portal_roleid";

	/// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 1.0.0.0. </summary>
	public const string VersionNumber = "versionnumber";

}

