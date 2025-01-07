namespace ECSM.Models.Dynamics;

/// <summary>Service request case associated with a contract.</summary>
public static partial class IncidentField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "incidentid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "title";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "Incidents";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "incidents";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "incidents";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "incident";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "Incident";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "entityimage";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the case is associated.</summary>
	public const string AccountId = "accountid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the case is associated.</summary>
	public const string AccountId_Lookup = "_accountid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 100, SchemaName: AccountIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string AccountIdName = "accountidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 100, SchemaName: AccountIdYomiName, YomiOf: accountidname, IntroducedVersion: 5.0.0.0. </summary>
	public const string AccountIdYomiName = "accountidyominame";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Activities Complete, SchemaName: ActivitiesComplete, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	public const string ActivitiesComplete = "activitiescomplete";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: activitiescomplete, SchemaName: ActivitiesCompleteName, IntroducedVersion: 6.0.0.0. </summary>
	public const string ActivitiesCompleteName = "activitiescompletename";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Actual Service Units, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: ActualServiceUnits, IntroducedVersion: 5.0.0.0.  Description: Type the number of service units that were actually required to resolve the case.</summary>
	public const string ActualServiceUnits = "actualserviceunits";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Billed Service Units, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: BilledServiceUnits, IntroducedVersion: 5.0.0.0.  Description: Type the number of service units that were billed to the customer for the case.</summary>
	public const string BilledServiceUnits = "billedserviceunits";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Blocked Profile, SchemaName: BlockedProfile, IntroducedVersion: 6.1.0.0.  Description: Details whether the profile is blocked or not.</summary>
	public const string BlockedProfile = "blockedprofile";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: blockedprofile, SchemaName: BlockedProfileName, IntroducedVersion: 6.1.0.0. </summary>
	public const string BlockedProfileName = "blockedprofilename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Case Age, Format: Text, MaxLength: 4000, SchemaName: caseage, IntroducedVersion: 1.0.0.0.  Description: Shows the duration for which the Case has been active for Active and Resolved Cases.</summary>
	public const string caseage = "caseage";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Origin, SchemaName: CaseOriginCode, IntroducedVersion: 5.0.0.0.  Description: Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.</summary>
	public const string CaseOriginCode = "caseorigincode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: caseorigincode, SchemaName: CaseOriginCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CaseOriginCodeName = "caseorigincodename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Type, SchemaName: CaseTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the type of case to identify the incident for use in case routing and analysis.</summary>
	public const string CaseTypeCode = "casetypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: casetypecode, SchemaName: CaseTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CaseTypeCodeName = "casetypecodename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Check Email, SchemaName: CheckEmail, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	public const string CheckEmail = "checkemail";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: checkemail, SchemaName: CheckEmailName, IntroducedVersion: 6.0.0.0. </summary>
	public const string CheckEmailName = "checkemailname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact associated with the case.</summary>
	public const string ContactId = "contactid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact associated with the case.</summary>
	public const string ContactId_Lookup = "_contactid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contactid, Format: Text, MaxLength: 100, SchemaName: ContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ContactIdName = "contactidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contactid, Format: Text, MaxLength: 100, SchemaName: ContactIdYomiName, YomiOf: contactidname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ContactIdYomiName = "contactidyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Line, Format: None, SchemaName: ContractDetailId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract line that the case should be logged under to make sure the customer is charged correctly.</summary>
	public const string ContractDetailId = "contractdetailid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Line, Format: None, SchemaName: ContractDetailId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract line that the case should be logged under to make sure the customer is charged correctly.</summary>
	public const string ContractDetailId_Lookup = "_contractdetailid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contractdetailid, Format: Text, MaxLength: 100, SchemaName: ContractDetailIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ContractDetailIdName = "contractdetailidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.</summary>
	public const string ContractId = "contractid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.</summary>
	public const string ContractId_Lookup = "_contractid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contractid, Format: Text, MaxLength: 100, SchemaName: ContractIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ContractIdName = "contractidname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Level, SchemaName: ContractServiceLevelCode, IntroducedVersion: 5.0.0.0.  Description: Select the service level for the case to make sure the case is handled correctly.</summary>
	public const string ContractServiceLevelCode = "contractservicelevelcode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: contractservicelevelcode, SchemaName: ContractServiceLevelCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ContractServiceLevelCodeName = "contractservicelevelcodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who created the record.</summary>
	public const string CreatedByExternalParty = "createdbyexternalparty";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who created the record.</summary>
	public const string CreatedByExternalParty_Lookup = "_createdbyexternalparty_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyName, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedByExternalPartyName = "createdbyexternalpartyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyYomiName, YomiOf: createdbyexternalpartyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedByExternalPartyYomiName = "createdbyexternalpartyyominame";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the record was created.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Customer Contacted, SchemaName: CustomerContacted, IntroducedVersion: 6.1.0.0.  Description: Tells whether customer service representative has contacted the customer or not.</summary>
	public const string CustomerContacted = "customercontacted";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customercontacted, SchemaName: customercontactedName, IntroducedVersion: 6.1.0.0. </summary>
	public const string customercontactedName = "customercontactedname";

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.</summary>
	public const string CustomerId = "customerid";

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.</summary>
	public const string CustomerId_Lookup = "_customerid_value";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: customerid, Format: Text, MaxLength: 160, SchemaName: CustomerIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CustomerIdName = "customeridname";

	/// <summary>Type: EntityName, RequiredLevel: ApplicationRequired, DisplayName: Customer Type, AttributeOf: customerid, SchemaName: CustomerIdType, IntroducedVersion: 5.0.0.0. </summary>
	public const string CustomerIdType = "customeridtype";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: customerid, Format: Text, MaxLength: 450, SchemaName: CustomerIdYomiName, YomiOf: customeridname, IntroducedVersion: 5.0.0.0. </summary>
	public const string CustomerIdYomiName = "customeridyominame";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Satisfaction, SchemaName: CustomerSatisfactionCode, IntroducedVersion: 5.0.0.0.  Description: Select the customer's level of satisfaction with the handling and resolution of the case.</summary>
	public const string CustomerSatisfactionCode = "customersatisfactioncode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customersatisfactioncode, SchemaName: CustomerSatisfactionCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string CustomerSatisfactionCodeName = "customersatisfactioncodename";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Deactivated On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: deactivatedon, IntroducedVersion: 1.0.0.0.  Description: Shows the date time when the Case was resolved.</summary>
	public const string deactivatedon = "deactivatedon";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decrement Entitlement Terms, SchemaName: DecrementEntitlementTerm, IntroducedVersion: 7.1.0.0.  Description: Shows whether terms of the associated entitlement should be decremented or not.</summary>
	public const string DecrementEntitlementTerm = "decremententitlementterm";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: decremententitlementterm, SchemaName: DecrementEntitlementTermName, IntroducedVersion: 7.1.0.0. </summary>
	public const string DecrementEntitlementTermName = "decremententitlementtermname";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information to describe the case to assist the service team in reaching a resolution.</summary>
	public const string Description = "description";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Approval Status, SchemaName: ecsm_approval_status, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_approval_status = "ecsm_approval_status";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_approval_status, SchemaName: ecsm_approval_statusName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_approval_statusName = "ecsm_approval_statusname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Approved, SchemaName: ecsm_approved, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_approved = "ecsm_approved";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_approved, SchemaName: ecsm_approvedName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_approvedName = "ecsm_approvedname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ecsm_catalogue_item, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item = "ecsm_catalogue_item";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ecsm_catalogue_item, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_Lookup = "_ecsm_catalogue_item_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_catalogue_item, Format: Text, MaxLength: 100, SchemaName: ecsm_catalogue_itemName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_itemName = "ecsm_catalogue_itemname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Category, Format: None, SchemaName: ecsm_category, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_category = "ecsm_category";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Category, Format: None, SchemaName: ecsm_category, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_category_Lookup = "_ecsm_category_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_category, Format: Text, MaxLength: 100, SchemaName: ecsm_categoryName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_categoryName = "ecsm_categoryname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Change, Format: None, SchemaName: ecsm_change, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_change = "ecsm_change";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Change, Format: None, SchemaName: ecsm_change, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_change_Lookup = "_ecsm_change_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_change, Format: Text, MaxLength: 100, SchemaName: ecsm_changeName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_changeName = "ecsm_changename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Created By Portal, SchemaName: ecsm_created_by_portal, IntroducedVersion: 1.3.0.2.  Description: This is set to true when record is created from the Portal</summary>
	public const string ecsm_created_by_portal = "ecsm_created_by_portal";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_created_by_portal, SchemaName: ecsm_created_by_portalName, IntroducedVersion: 1.3.0.2. </summary>
	public const string ecsm_created_by_portalName = "ecsm_created_by_portalname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Duration, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: ecsm_duration, IntroducedVersion: 1.0. </summary>
	public const string ecsm_duration = "ecsm_duration";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName:  Impact, SchemaName: ecsm_impact, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_impact = "ecsm_impact";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_impact, SchemaName: ecsm_impactName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_impactName = "ecsm_impactname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Incident Type, SchemaName: ecsm_incident_type, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_type = "ecsm_incident_type";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_incident_type, SchemaName: ecsm_incident_typeName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_typeName = "ecsm_incident_typename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Known Issue, SchemaName: ecsm_is_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_is_known_issue = "ecsm_is_known_issue";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_is_known_issue, SchemaName: ecsm_is_known_issueName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_is_known_issueName = "ecsm_is_known_issuename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Major, SchemaName: ecsm_is_major, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_is_major = "ecsm_is_major";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_is_major, SchemaName: ecsm_is_majorName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_is_majorName = "ecsm_is_majorname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Known Issue, Format: None, SchemaName: ecsm_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_known_issue = "ecsm_known_issue";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Known Issue, Format: None, SchemaName: ecsm_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_known_issue_Lookup = "_ecsm_known_issue_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_known_issue, Format: Text, MaxLength: 100, SchemaName: ecsm_known_issueName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_known_issueName = "ecsm_known_issuename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected CI, Format: None, SchemaName: ecsm_problem_affected_ci, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_affected_ci = "ecsm_problem_affected_ci";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected CI, Format: None, SchemaName: ecsm_problem_affected_ci, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_affected_ci_Lookup = "_ecsm_problem_affected_ci_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_problem_affected_ci, Format: Text, MaxLength: 100, SchemaName: ecsm_problem_affected_ciName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_affected_ciName = "ecsm_problem_affected_ciname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected Service, Format: None, SchemaName: ecsm_problem_affected_service, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_affected_service = "ecsm_problem_affected_service";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected Service, Format: None, SchemaName: ecsm_problem_affected_service, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_affected_service_Lookup = "_ecsm_problem_affected_service_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_problem_affected_service, Format: Text, MaxLength: 100, SchemaName: ecsm_problem_affected_serviceName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_affected_serviceName = "ecsm_problem_affected_servicename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Problem Impact, SchemaName: ecsm_problem_impact, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_impact = "ecsm_problem_impact";

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Problem Impact Classification, SchemaName: ecsm_problem_impact_classification, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_impact_classification = "ecsm_problem_impact_classification";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_problem_impact_classification, SchemaName: ecsm_problem_impact_classificationName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_impact_classificationName = "ecsm_problem_impact_classificationname";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_problem_impact, SchemaName: ecsm_problem_impactName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_problem_impactName = "ecsm_problem_impactname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Raise Change, SchemaName: ecsm_raise_change, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_raise_change = "ecsm_raise_change";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_raise_change, SchemaName: ecsm_raise_changeName, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_raise_changeName = "ecsm_raise_changename";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Reproduction Steps, Format: Text, MaxLength: 2000, SchemaName: ecsm_reproduction_steps, IntroducedVersion: 1.0. </summary>
	public const string ecsm_reproduction_steps = "ecsm_reproduction_steps";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Risk Statement, Format: Text, MaxLength: 2000, SchemaName: ecsm_risk_statement, IntroducedVersion: 1.0. </summary>
	public const string ecsm_risk_statement = "ecsm_risk_statement";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Root Cause, Format: Text, MaxLength: 2000, SchemaName: ecsm_root_cause, IntroducedVersion: 1.0. </summary>
	public const string ecsm_root_cause = "ecsm_root_cause";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: ecsm_site, IntroducedVersion: 1.1.0.12.  Description: Site</summary>
	public const string ecsm_site = "ecsm_site";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: ecsm_site, IntroducedVersion: 1.1.0.12.  Description: Site</summary>
	public const string ecsm_site_Lookup = "_ecsm_site_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_site, Format: Text, MaxLength: 160, SchemaName: ecsm_siteName, IntroducedVersion: 1.1.0.12. </summary>
	public const string ecsm_siteName = "ecsm_sitename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Test product Lookup, Format: None, SchemaName: ecsm_test_product_lookup, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_test_product_lookup = "ecsm_test_product_lookup";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Test product Lookup, Format: None, SchemaName: ecsm_test_product_lookup, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_test_product_lookup_Lookup = "_ecsm_test_product_lookup_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_test_product_lookup, Format: Text, MaxLength: 100, SchemaName: ecsm_test_product_lookupName, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_test_product_lookupName = "ecsm_test_product_lookupname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Urgency, SchemaName: ecsm_urgency, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_urgency = "ecsm_urgency";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_urgency, SchemaName: ecsm_urgencyName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_urgencyName = "ecsm_urgencyname";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Variable Data, Format: Text, MaxLength: 1048576, SchemaName: ecsm_variable_data, IntroducedVersion: 1.0. </summary>
	public const string ecsm_variable_data = "ecsm_variable_data";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Workaround, Format: Text, MaxLength: 2000, SchemaName: ecsm_workaround, IntroducedVersion: 1.0. </summary>
	public const string ecsm_workaround = "ecsm_workaround";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Working Synopsis, Format: Text, MaxLength: 2000, SchemaName: ecsm_working_synopsis, IntroducedVersion: 1.0. </summary>
	public const string ecsm_working_synopsis = "ecsm_working_synopsis";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address, Format: Email, MaxLength: 100, SchemaName: EmailAddress, IntroducedVersion: 5.0.0.0.  Description: The primary email address for the entity.</summary>
	public const string EmailAddress = "emailaddress";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement, Format: None, SchemaName: EntitlementId, IntroducedVersion: 6.1.0.0.  Description: Choose the entitlement that is applicable for the case.</summary>
	public const string EntitlementId = "entitlementid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement, Format: None, SchemaName: EntitlementId, IntroducedVersion: 6.1.0.0.  Description: Choose the entitlement that is applicable for the case.</summary>
	public const string EntitlementId_Lookup = "_entitlementid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: entitlementid, Format: Text, MaxLength: 100, SchemaName: EntitlementIdName, IntroducedVersion: 6.1.0.0. </summary>
	public const string EntitlementIdName = "entitlementidname";

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Entity Image, AttributeOf: entityimageid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: EntityImage, IntroducedVersion: 6.0.0.0.  Description: The default image for the entity.</summary>
	public const string EntityImage = "entityimage";

	/// <summary>Type: BigInt, RequiredLevel: None, AttributeOf: entityimageid, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: EntityImage_Timestamp, IntroducedVersion: 6.0.0.0. </summary>
	public const string EntityImage_Timestamp = "entityimage_timestamp";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: entityimageid, Format: Url, MaxLength: 200, SchemaName: EntityImage_URL, IntroducedVersion: 6.0.0.0. </summary>
	public const string EntityImage_URL = "entityimage_url";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, SchemaName: EntityImageId, IntroducedVersion: 6.0.0.0. </summary>
	public const string EntityImageId = "entityimageid";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Escalated On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: EscalatedOn, IntroducedVersion: 6.1.0.0.  Description: Indicates the date and time when the case was escalated.</summary>
	public const string EscalatedOn = "escalatedon";

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.</summary>
	public const string ExchangeRate = "exchangerate";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Existing Case, Format: None, SchemaName: ExistingCase, IntroducedVersion: 5.0.0.0.  Description: Select an existing case for the customer that has been populated. For internal use only.</summary>
	public const string ExistingCase = "existingcase";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Existing Case, Format: None, SchemaName: ExistingCase, IntroducedVersion: 5.0.0.0.  Description: Select an existing case for the customer that has been populated. For internal use only.</summary>
	public const string ExistingCase_Lookup = "_existingcase_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: First Response By KPI, Format: None, SchemaName: FirstResponseByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	public const string FirstResponseByKPIId = "firstresponsebykpiid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: First Response By KPI, Format: None, SchemaName: FirstResponseByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	public const string FirstResponseByKPIId_Lookup = "_firstresponsebykpiid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: firstresponsebykpiid, Format: Text, MaxLength: 100, SchemaName: FirstResponseByKPIIdName, IntroducedVersion: 7.0.0.0. </summary>
	public const string FirstResponseByKPIIdName = "firstresponsebykpiidname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: First Response Sent, SchemaName: FirstResponseSent, IntroducedVersion: 6.1.0.0.  Description: Indicates if the first response has been sent.</summary>
	public const string FirstResponseSent = "firstresponsesent";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: firstresponsesent, SchemaName: FirstResponseSentName, IntroducedVersion: 6.1.0.0. </summary>
	public const string FirstResponseSentName = "firstresponsesentname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: First Response SLA Status, SchemaName: FirstResponseSLAStatus, IntroducedVersion: 6.1.0.0.  Description: Shows the status of the initial response time for the case according to the terms of the SLA.</summary>
	public const string FirstResponseSLAStatus = "firstresponseslastatus";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: firstresponseslastatus, SchemaName: FirstResponseSLAStatusName, IntroducedVersion: 6.1.0.0. </summary>
	public const string FirstResponseSLAStatusName = "firstresponseslastatusname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Follow Up By, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: FollowupBy, IntroducedVersion: 5.0.0.0.  Description: Enter the date by which a customer service representative has to follow up with the customer on this case.</summary>
	public const string FollowupBy = "followupby";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow up Task Created, SchemaName: FollowUpTaskCreated, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	public const string FollowUpTaskCreated = "followuptaskcreated";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: followuptaskcreated, SchemaName: FollowUpTaskCreatedName, IntroducedVersion: 6.0.0.0. </summary>
	public const string FollowUpTaskCreatedName = "followuptaskcreatedname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Sequence number of the import that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Case, SchemaName: IncidentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case.</summary>
	public const string IncidentId = "incidentid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Stage, SchemaName: IncidentStageCode, IntroducedVersion: 5.0.0.0.  Description: Select the current stage of the service process for the case to assist service team members when they review or transfer a case.</summary>
	public const string IncidentStageCode = "incidentstagecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: incidentstagecode, SchemaName: IncidentStageCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IncidentStageCodeName = "incidentstagecodename";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Influence Score, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: InfluenceScore, IntroducedVersion: 6.1.0.0.  Description: Will contain the Influencer score coming from NetBreeze.</summary>
	public const string InfluenceScore = "influencescore";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decrementing, SchemaName: IsDecrementing, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	public const string IsDecrementing = "isdecrementing";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdecrementing, SchemaName: IsDecrementingName, IntroducedVersion: 5.0.0.0. </summary>
	public const string IsDecrementingName = "isdecrementingname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Escalated, SchemaName: IsEscalated, IntroducedVersion: 6.1.0.0.  Description: Indicates if the case has been escalated.</summary>
	public const string IsEscalated = "isescalated";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isescalated, SchemaName: IsEscalatedName, IntroducedVersion: 6.1.0.0. </summary>
	public const string IsEscalatedName = "isescalatedname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Knowledge Base Article, Format: None, SchemaName: KbArticleId, IntroducedVersion: 5.0.0.0.  Description: Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.</summary>
	public const string KbArticleId = "kbarticleid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Knowledge Base Article, Format: None, SchemaName: KbArticleId, IntroducedVersion: 5.0.0.0.  Description: Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.</summary>
	public const string KbArticleId_Lookup = "_kbarticleid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: kbarticleid, Format: Text, MaxLength: 100, SchemaName: KbArticleIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string KbArticleIdName = "kbarticleidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Last Interaction, Format: Text, MaxLength: 200, SchemaName: lastinteraction, IntroducedVersion: 1.0.0.0.  Description: Shows the latest activity associated with the Case and the action performed on that activity.</summary>
	public const string lastinteraction = "lastinteraction";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last On Hold Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastOnHoldTime, IntroducedVersion: 7.0.0.0.  Description: Contains the date time stamp of the last on hold time.</summary>
	public const string LastOnHoldTime = "lastonholdtime";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master Case, Format: None, SchemaName: MasterId, IntroducedVersion: 6.1.0.0.  Description: Choose the primary case the current case was merged into.</summary>
	public const string MasterId = "masterid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master Case, Format: None, SchemaName: MasterId, IntroducedVersion: 6.1.0.0.  Description: Choose the primary case the current case was merged into.</summary>
	public const string MasterId_Lookup = "_masterid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterIdName, IntroducedVersion: 6.1.0.0. </summary>
	public const string MasterIdName = "masteridname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Internal Use Only, SchemaName: Merged, IntroducedVersion: 6.1.0.0.  Description: Tells whether the incident has been merged with another incident.</summary>
	public const string Merged = "merged";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: merged, SchemaName: MergedName, IntroducedVersion: 6.1.0.0. </summary>
	public const string MergedName = "mergedname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Received As, SchemaName: MessageTypeCode, IntroducedVersion: 6.1.0.0.  Description: Shows whether the post originated as a public or private message.</summary>
	public const string MessageTypeCode = "messagetypecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: messagetypecode, SchemaName: MessageTypeCodeName, IntroducedVersion: 6.1.0.0. </summary>
	public const string MessageTypeCodeName = "messagetypecodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who modified the record.</summary>
	public const string ModifiedByExternalParty = "modifiedbyexternalparty";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who modified the record.</summary>
	public const string ModifiedByExternalParty_Lookup = "_modifiedbyexternalparty_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyName, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedByExternalPartyName = "modifiedbyexternalpartyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyYomiName, YomiOf: modifiedbyexternalpartyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedByExternalPartyYomiName = "modifiedbyexternalpartyyominame";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the record was modified.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record on behalf of another user.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record on behalf of another user.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Survey Invite, Format: Text, MaxLength: 500, SchemaName: msdyn_CaseSurveyInviteUrl, IntroducedVersion: 1.0.  Description: Survey invite url for customer feedback.</summary>
	public const string msdyn_CaseSurveyInviteUrl = "msdyn_casesurveyinviteurl";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Copilot Engaged, SchemaName: msdyn_copilotengaged, IntroducedVersion: 1.0.0.1. </summary>
	public const string msdyn_copilotengaged = "msdyn_copilotengaged";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_copilotengaged, SchemaName: msdyn_copilotengagedName, IntroducedVersion: 1.0.0.1. </summary>
	public const string msdyn_copilotengagedName = "msdyn_copilotengagedname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Alert, Format: None, SchemaName: msdyn_iotalert, IntroducedVersion: 1.0.0.0.  Description: The iot alert that initiated this case</summary>
	public const string msdyn_iotalert = "msdyn_iotalert";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Alert, Format: None, SchemaName: msdyn_iotalert, IntroducedVersion: 1.0.0.0.  Description: The iot alert that initiated this case</summary>
	public const string msdyn_iotalert_Lookup = "_msdyn_iotalert_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_iotalert, Format: Text, MaxLength: 100, SchemaName: msdyn_iotalertName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_iotalertName = "msdyn_iotalertname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pre Create Entity Attachments Id, Format: Text, MaxLength: 400, SchemaName: msdyn_precreateattachmentsid, IntroducedVersion: 1.0.  Description: Entity Attachments Id before the case record is created</summary>
	public const string msdyn_precreateattachmentsid = "msdyn_precreateattachmentsid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pre Create Notes Id, Format: Text, MaxLength: 100, SchemaName: msdyn_precreatenotesid, IntroducedVersion: 1.0.  Description: Notes Id before the case record is created</summary>
	public const string msdyn_precreatenotesid = "msdyn_precreatenotesid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Next Sla, Format: Text, MaxLength: 400, SchemaName: nextsla, IntroducedVersion: 1.0.0.0.  Description: Shows the unresolved SLA KPI associated with the Case with the earliest expiry time.</summary>
	public const string nextsla = "nextsla";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Child Cases, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: NumberOfChildIncidents, IntroducedVersion: 6.1.0.0.  Description: Number of child incidents associated with the incident.</summary>
	public const string NumberOfChildIncidents = "numberofchildincidents";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: On Hold Time (Minutes), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OnHoldTime, IntroducedVersion: 7.0.0.0.  Description: Shows the duration in minutes for which the case was on hold.</summary>
	public const string OnHoldTime = "onholdtime";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Owner Id</summary>
	public const string OwnerId = "ownerid";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Owner Id</summary>
	public const string OwnerId_Lookup = "_ownerid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 5.0.0.0.  Description: Name of the owner</summary>
	public const string OwnerIdName = "owneridname";

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 5.0.0.0.  Description: Owner Id Type</summary>
	public const string OwnerIdType = "owneridtype";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 5.0.0.0.  Description: Yomi name of the owner</summary>
	public const string OwnerIdYomiName = "owneridyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	public const string OwningBusinessUnit = "owningbusinessunit";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	public const string OwningBusinessUnit_Lookup = "_owningbusinessunit_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 100, SchemaName: OwningBusinessUnitName, IntroducedVersion: 5.0.0.0. </summary>
	public const string OwningBusinessUnitName = "owningbusinessunitname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	public const string OwningTeam = "owningteam";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	public const string OwningTeam_Lookup = "_owningteam_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	public const string OwningUser = "owninguser";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	public const string OwningUser_Lookup = "_owninguser_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Case, Format: None, SchemaName: ParentCaseId, IntroducedVersion: 6.1.0.0.  Description: Choose the parent case for a case.</summary>
	public const string ParentCaseId = "parentcaseid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Case, Format: None, SchemaName: ParentCaseId, IntroducedVersion: 6.1.0.0.  Description: Choose the parent case for a case.</summary>
	public const string ParentCaseId_Lookup = "_parentcaseid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentcaseid, Format: Text, MaxLength: 100, SchemaName: ParentCaseIdName, IntroducedVersion: 6.1.0.0. </summary>
	public const string ParentCaseIdName = "parentcaseidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 6.1.0.0.  Description: Select a primary contact for this case.</summary>
	public const string PrimaryContactId = "primarycontactid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 6.1.0.0.  Description: Select a primary contact for this case.</summary>
	public const string PrimaryContactId_Lookup = "_primarycontactid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primarycontactid, Format: Text, MaxLength: 100, SchemaName: PrimaryContactIdName, IntroducedVersion: 6.1.0.0. </summary>
	public const string PrimaryContactIdName = "primarycontactidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primarycontactid, Format: Text, MaxLength: 100, SchemaName: PrimaryContactIdYomiName, YomiOf: primarycontactidname, IntroducedVersion: 6.1.0.0. </summary>
	public const string PrimaryContactIdYomiName = "primarycontactidyominame";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, SchemaName: PriorityCode, IntroducedVersion: 5.0.0.0.  Description: Select the priority so that preferred customers or critical issues are handled quickly.</summary>
	public const string PriorityCode = "prioritycode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: prioritycode, SchemaName: PriorityCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string PriorityCodeName = "prioritycodename";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process Id, SchemaName: ProcessId, IntroducedVersion: 5.0.0.0.  Description: Contains the id of the process associated with the entity.</summary>
	public const string ProcessId = "processid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.</summary>
	public const string ProductId = "productid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.</summary>
	public const string ProductId_Lookup = "_productid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: productid, Format: Text, MaxLength: 100, SchemaName: ProductIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ProductIdName = "productidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Serial Number, Format: Text, MaxLength: 100, SchemaName: ProductSerialNumber, IntroducedVersion: 5.0.0.0.  Description: Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.</summary>
	public const string ProductSerialNumber = "productserialnumber";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Resolve By, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ResolveBy, IntroducedVersion: 6.1.0.0.  Description: Enter the date by when the case must be resolved.</summary>
	public const string ResolveBy = "resolveby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Resolve By KPI, Format: None, SchemaName: ResolveByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	public const string ResolveByKPIId = "resolvebykpiid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Resolve By KPI, Format: None, SchemaName: ResolveByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	public const string ResolveByKPIId_Lookup = "_resolvebykpiid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: resolvebykpiid, Format: Text, MaxLength: 100, SchemaName: ResolveByKPIIdName, IntroducedVersion: 7.0.0.0. </summary>
	public const string ResolveByKPIIdName = "resolvebykpiidname";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Resolve By SLA Status, SchemaName: ResolveBySLAStatus, IntroducedVersion: 6.1.0.0.  Description: Shows the status of the resolution time for the case according to the terms of the SLA.</summary>
	public const string ResolveBySLAStatus = "resolvebyslastatus";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: resolvebyslastatus, SchemaName: ResolveBySLAStatusName, IntroducedVersion: 6.1.0.0. </summary>
	public const string ResolveBySLAStatusName = "resolvebyslastatusname";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: First Response By, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ResponseBy, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	public const string ResponseBy = "responseby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Responsible Contact (Deprecated), Format: None, SchemaName: ResponsibleContactId, IntroducedVersion: 5.0.0.0.  Description: Choose an additional customer contact who can also help resolve the case.</summary>
	public const string ResponsibleContactId = "responsiblecontactid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Responsible Contact (Deprecated), Format: None, SchemaName: ResponsibleContactId, IntroducedVersion: 5.0.0.0.  Description: Choose an additional customer contact who can also help resolve the case.</summary>
	public const string ResponsibleContactId_Lookup = "_responsiblecontactid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: responsiblecontactid, Format: Text, MaxLength: 100, SchemaName: ResponsibleContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ResponsibleContactIdName = "responsiblecontactidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: responsiblecontactid, Format: Text, MaxLength: 100, SchemaName: ResponsibleContactIdYomiName, YomiOf: responsiblecontactidname, IntroducedVersion: 5.0.0.0. </summary>
	public const string ResponsibleContactIdYomiName = "responsiblecontactidyominame";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Route Case, SchemaName: RouteCase, IntroducedVersion: 6.1.0.0.  Description: Tells whether the incident has been routed to queue or not.</summary>
	public const string RouteCase = "routecase";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: routecase, SchemaName: routecaseName, IntroducedVersion: 6.1.0.0. </summary>
	public const string routecaseName = "routecasename";

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Sentiment Value, Precision: 2, MinValue: -100000000000, MaxValue: 100000000000, SchemaName: SentimentValue, IntroducedVersion: 6.1.0.0.  Description: Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.</summary>
	public const string SentimentValue = "sentimentvalue";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Stage, SchemaName: ServiceStage, IntroducedVersion: 5.0.0.0.  Description: Select the stage, in the case resolution process, that the case is in.</summary>
	public const string ServiceStage = "servicestage";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: servicestage, SchemaName: ServiceStageName, IntroducedVersion: 5.0.0.0. </summary>
	public const string ServiceStageName = "servicestagename";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Severity, SchemaName: SeverityCode, IntroducedVersion: 5.0.0.0.  Description: Select the severity of this case to indicate the incident's impact on the customer's business.</summary>
	public const string SeverityCode = "severitycode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: severitycode, SchemaName: SeverityCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string SeverityCodeName = "severitycodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.0.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
	public const string SLAId = "slaid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.0.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
	public const string SLAId_Lookup = "_slaid_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 6.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	public const string SLAInvokedId = "slainvokedid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 6.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	public const string SLAInvokedId_Lookup = "_slainvokedid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slainvokedid, Format: Text, MaxLength: 100, SchemaName: SLAInvokedIdName, IntroducedVersion: 6.1.0.0. </summary>
	public const string SLAInvokedIdName = "slainvokedidname";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: SLAName, IntroducedVersion: 5.0.0.0. </summary>
	public const string SLAName = "slaname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Social Profile, Format: None, SchemaName: SocialProfileId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the social profile with which the case is associated.</summary>
	public const string SocialProfileId = "socialprofileid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Social Profile, Format: None, SchemaName: SocialProfileId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the social profile with which the case is associated.</summary>
	public const string SocialProfileId_Lookup = "_socialprofileid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: socialprofileid, Format: Text, MaxLength: 100, SchemaName: SocialProfileIdName, IntroducedVersion: 6.1.0.0. </summary>
	public const string SocialProfileIdName = "socialprofileidname";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Stage Id, SchemaName: StageId, IntroducedVersion: 5.0.0.0.  Description: Contains the id of the stage where the entity is located.</summary>
	public const string StageId = "stageid";

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.</summary>
	public const string StateCode = "statecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string StateCodeName = "statecodename";

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the case's status.</summary>
	public const string StatusCode = "statuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
	public const string StatusCodeName = "statuscodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.</summary>
	public const string SubjectId = "subjectid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.</summary>
	public const string SubjectId_Lookup = "_subjectid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: subjectid, Format: Text, MaxLength: 100, SchemaName: SubjectIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string SubjectIdName = "subjectidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Case Number, AutoNumberFormat: CAS-{SEQNUM:5}-{RANDSTRING:6}, Format: Text, MaxLength: 100, SchemaName: TicketNumber, IntroducedVersion: 5.0.0.0.  Description: Shows the case number for customer reference and searching capabilities. This cannot be modified.</summary>
	public const string TicketNumber = "ticketnumber";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Case Title, Format: Text, MaxLength: 200, SchemaName: Title, IntroducedVersion: 5.0.0.0.  Description: Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics 365 views.</summary>
	public const string Title = "title";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
	public const string TransactionCurrencyId = "transactioncurrencyid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
	public const string TransactionCurrencyId_Lookup = "_transactioncurrencyid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 5.0.0.0. </summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: TraversedPath, IntroducedVersion: 5.0.0.0.  Description: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.</summary>
	public const string TraversedPath = "traversedpath";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version Number</summary>
	public const string VersionNumber = "versionnumber";

}

