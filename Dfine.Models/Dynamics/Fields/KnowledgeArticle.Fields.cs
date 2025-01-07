namespace ECSM.Models.Dynamics;

/// <summary>Organizational knowledge for internal and external use.</summary>
public static partial class KnowledgeArticleField
{
	/// <summary>The primary key for a CRM Entity is the Globally Unique Identifier ( GUID ) that CRM uses to reference everything within the CRM system</summary>
	public const string PrimaryId = "knowledgearticleid";

	/// <summary>Specifies the name of the attribute that is the primary field for the entity</summary>
	public const string PrimaryName = "title";

	/// <summary>CollectionSchemaName is a property of a table in Microsoft Dataverse that represents a plural form of the SchemaName. For example, if the SchemaName of a table is Account, the CollectionSchemaName would be Accounts. The CollectionSchemaName is used to identify collections of records in the Web API and other services.</summary>
	public const string CollectionSchemaName = "KnowledgeArticles";

	/// <summary>The LogicalCollectionName is a property of the EntityMetadata class in Microsoft Dynamics 365. It is used to identify the collection of entities of a specific type in the Web API. For example, the LogicalCollectionName for the Account entity is accounts, and the LogicalCollectionName for the Contact entity is contacts. The LogicalCollectionName is usually the lower-case version of the CollectionSchemaName, which is a plural form of the SchemaName. The SchemaName is typically a Pascal cased version of the logical name of the entity. For example, the SchemaName for the Account entity is Account, and the SchemaName for the Contact entity is Contact.</summary>
	public const string LogicalCollectionName = "knowledgearticles";

	/// <summary>The EntitySetName property is used to set the plural entity name with which the page is exposed in the API endpoint. For example, if you want to expose a page for customers, you can set the EntitySetName property to “Customers”. This will allow you to access the page data through the URL https://{base URL}/api/{API group}/{API version}/Customers. | An entity in Dynamics 365 is a set of attributes that represent a business object, such as account, contact, or opportunity. An entity is like a database table, and the entity attributes correspond to the table columns. You can create custom entities to model your specific business needs. | The logical name of an entity is a unique identifier that is used by the system to reference the entity internally4. For example, the logical name of the account entity is “account”. You can find the logical name of an entity by using tools such as XrmToolBox or by navigating to the system solution and selecting the entity.</summary>
	public const string EntitySetName = "knowledgearticles";

	/// <summary>The LogicalName of a table or a column in Dynamics 365 is a unique name that is automatically generated based on the SchemaName, but with all lowercase letters. The LogicalName is used to identify the table or column in code or queries. For example, the LogicalName of the Account table is account, and the LogicalName of the CategoryId column is categoryid. The LogicalName cannot be changed after the table or column is created. The LogicalName is different from the DisplayName, which is a localizable value that is used to refer to the table or column in an app.</summary>
	public const string LogicalName = "knowledgearticle";

	/// <summary>SchemaName is a property of a table in Dynamics 365 that defines its unique name. It is typically a Pascal cased version of the logical name of the table. For example, the SchemaName for the table that stores account information is Account. The SchemaName is used to identify the table in code and queries. It cannot be changed after the table is created, unless you use a solution publisher with a different customization prefix. The SchemaName is also used to form the primary key and the primary name of the table1. For example, the primary key of the Account table is AccountId and the primary name is AccountName. The SchemaName can also be used to create relationships between tables. For example, if you want to create a one-to-many relationship between Account and Contact, you can use the SchemaName of both tables to define the relationship name as Account_Contacts.</summary>
	public const string SchemaName = "KnowledgeArticle";

	/// <summary>The PrimaryImage is a special type of image column in Dynamics 365 that can be used to store and display the main image of an entity record. The PrimaryImage column has some unique properties and behaviors</summary>
	public const string PrimaryImage = "";

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Article Public Number, AutoNumberFormat: KA-{SEQNUM:5}, Format: Text, MaxLength: 4000, SchemaName: ArticlePublicNumber, IntroducedVersion: 8.0.0.0.  Description: Shows the automatically generated ID exposed to customers, partners, and other external users to reference and look up articles.</summary>
	public const string ArticlePublicNumber = "articlepublicnumber";

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Content, Format: TextArea, MaxLength: 1073741823, SchemaName: Content, IntroducedVersion: 8.0.0.0.  Description: Shows the body of the article stored in HTML format.</summary>
	public const string Content = "content";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
	public const string CreatedBy = "createdby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
	public const string CreatedBy_Lookup = "_createdby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedByName = "createdbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedByYomiName = "createdbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 8.0.0.0.  Description: Date and time when the record was created.</summary>
	public const string CreatedOn = "createdon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
	public const string CreatedOnBehalfBy_Lookup = "_createdonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 155, SchemaName: Description, IntroducedVersion: 8.0.0.0.  Description: A short overview of the article, primarily used in search results and for search engine optimization.</summary>
	public const string Description = "description";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: FAQ, SchemaName: ecsm_faq, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_faq = "ecsm_faq";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_faq, SchemaName: ecsm_faqName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_faqName = "ecsm_faqname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Public, SchemaName: ecsm_public, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_public = "ecsm_public";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_public, SchemaName: ecsm_publicName, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_publicName = "ecsm_publicname";

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: ExchangeRate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 8.0.0.0.  Description: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.</summary>
	public const string ExchangeRate = "exchangerate";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Expiration Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ExpirationDate, IntroducedVersion: 8.0.0.0.  Description: Enter an expiration date for the article. Leave this field blank for no expiration date.</summary>
	public const string ExpirationDate = "expirationdate";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Expiration State Id, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: ExpirationStateId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the expiration state of the entity.</summary>
	public const string ExpirationStateId = "expirationstateid";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Expired Status, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: ExpirationStatusId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the expiration status of the entity.</summary>
	public const string ExpirationStatusId = "expirationstatusid";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Expired Review Options, SchemaName: ExpiredReviewOptions, IntroducedVersion: 8.0.0.0.  Description: Expired Review Options</summary>
	public const string ExpiredReviewOptions = "expiredreviewoptions";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 8.0.0.0.  Description: Sequence number of the import that created this record.</summary>
	public const string ImportSequenceNumber = "importsequencenumber";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: expiredreviewoptions, SchemaName: isExpiredReviewOptions, IntroducedVersion: 8.0.0.0. </summary>
	public const string isExpiredReviewOptions = "isexpiredreviewoptions";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Internal, SchemaName: IsInternal, IntroducedVersion: 8.1.0.0.  Description: Shows whether this article is only visible internally.</summary>
	public const string IsInternal = "isinternal";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isinternal, SchemaName: IsInternalName, IntroducedVersion: 8.1.0.0. </summary>
	public const string IsInternalName = "isinternalname";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Latest Version, SchemaName: IsLatestVersion, IntroducedVersion: 8.0.0.0.  Description: Shows which version of the knowledge article is the latest version.</summary>
	public const string IsLatestVersion = "islatestversion";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: islatestversion, SchemaName: IsLatestVersionName, IntroducedVersion: 8.0.0.0. </summary>
	public const string IsLatestVersionName = "islatestversionname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Primary Article, SchemaName: IsPrimary, IntroducedVersion: 8.0.0.0.  Description: Select whether the article is the primary article.</summary>
	public const string IsPrimary = "isprimary";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isprimary, SchemaName: IsPrimaryName, IntroducedVersion: 8.0.0.0. </summary>
	public const string IsPrimaryName = "isprimaryname";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: setproductassociations, SchemaName: isProductAssociations, IntroducedVersion: 8.0.0.0. </summary>
	public const string isProductAssociations = "isproductassociations";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: readyforreview, SchemaName: isReadyForReview, IntroducedVersion: 8.0.0.0. </summary>
	public const string isReadyForReview = "isreadyforreview";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: review, SchemaName: isReview, IntroducedVersion: 8.0.0.0. </summary>
	public const string isReview = "isreview";

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Root Article, SchemaName: IsRootArticle, IntroducedVersion: 8.0.0.0.  Description: Select whether the article is the root article.</summary>
	public const string IsRootArticle = "isrootarticle";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isrootarticle, SchemaName: IsRootArticleName, IntroducedVersion: 8.0.0.0. </summary>
	public const string IsRootArticleName = "isrootarticlename";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: updatecontent, SchemaName: isUpdateContent, IntroducedVersion: 8.0.0.0. </summary>
	public const string isUpdateContent = "isupdatecontent";

	/// <summary>Type: Memo, RequiredLevel: Recommended, DisplayName: Keywords, Format: Text, MaxLength: 4000, SchemaName: Keywords, IntroducedVersion: 8.0.0.0.  Description: Type keywords to be used for searches in knowledge base articles. Separate keywords by using commas.</summary>
	public const string Keywords = "keywords";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Knowledge Article, SchemaName: knowledgearticleId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for entity instances</summary>
	public const string knowledgearticleId = "knowledgearticleid";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Knowledge Article Views, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: KnowledgeArticleViews, IntroducedVersion: 8.0.0.0.  Description: Shows the total number of article views.</summary>
	public const string KnowledgeArticleViews = "knowledgearticleviews";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Knowledge Article View(Last Updated Time), DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: KnowledgeArticleViews_Date, IntroducedVersion: 8.0.0.0.  Description: The date time for Knowledge Article View.</summary>
	public const string KnowledgeArticleViews_Date = "knowledgearticleviews_date";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Knowledge Article View(State), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: KnowledgeArticleViews_State, IntroducedVersion: 8.0.0.0.  Description: State of Knowledge Article View.</summary>
	public const string KnowledgeArticleViews_State = "knowledgearticleviews_state";

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Language, Format: None, SchemaName: LanguageLocaleId, IntroducedVersion: 8.0.0.0.  Description: Select the language that the article's content is in.</summary>
	public const string LanguageLocaleId = "languagelocaleid";

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Language, Format: None, SchemaName: LanguageLocaleId, IntroducedVersion: 8.0.0.0.  Description: Select the language that the article's content is in.</summary>
	public const string LanguageLocaleId_Lookup = "_languagelocaleid_value";

	/// <summary>Type: Integer, RequiredLevel: None, AttributeOf: languagelocaleid, Format: None, MinValue: 1, MaxValue: 2147483647, SchemaName: LanguageLocaleIdLocaleId, IntroducedVersion: 8.0.0.0. </summary>
	public const string LanguageLocaleIdLocaleId = "languagelocaleidlocaleid";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: languagelocaleid, Format: Text, MaxLength: 500, SchemaName: LanguageLocaleIdName, IntroducedVersion: 8.0.0.0. </summary>
	public const string LanguageLocaleIdName = "languagelocaleidname";

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Major Version Number, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MajorVersionNumber, IntroducedVersion: 8.0.0.0.  Description: Shows the major version number of this article's content.</summary>
	public const string MajorVersionNumber = "majorversionnumber";

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Minor Version Number, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MinorVersionNumber, IntroducedVersion: 8.0.0.0.  Description: Shows the minor version number of this article's content.</summary>
	public const string MinorVersionNumber = "minorversionnumber";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
	public const string ModifiedBy = "modifiedby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
	public const string ModifiedBy_Lookup = "_modifiedby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedByName = "modifiedbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 8.0.0.0.  Description: Date and time when the record was modified.</summary>
	public const string ModifiedOn = "modifiedon";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
	public const string ModifiedOnBehalfBy_Lookup = "_modifiedonbehalfby_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 8.0.0.0. </summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: File storage content reference, MaxSizeInKb: 32768, MaxSizeInKb: 32768, SchemaName: msdyn_contentstore, IntroducedVersion: 1.0.  Description: Stores the reference to content in file store</summary>
	public const string msdyn_contentstore = "msdyn_contentstore";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_contentstore, Format: Text, MaxLength: 200, SchemaName: msdyn_contentstore_Name, IntroducedVersion: 1.0. </summary>
	public const string msdyn_contentstore_Name = "msdyn_contentstore_name";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Creation Mode, SchemaName: msdyn_creationmode, IntroducedVersion: 1.0.  Description: Opiton set to hold details about article if it is generated by AI or manually created</summary>
	public const string msdyn_creationmode = "msdyn_creationmode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_creationmode, SchemaName: msdyn_creationmodeName, IntroducedVersion: 1.0. </summary>
	public const string msdyn_creationmodeName = "msdyn_creationmodename";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: External Reference Id, Format: Text, MaxLength: 450, SchemaName: msdyn_externalreferenceid, IntroducedVersion: 1.0.0.0.  Description: External Reference Id</summary>
	public const string msdyn_externalreferenceid = "msdyn_externalreferenceid";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ingested Article URL, Format: Text, MaxLength: 2048, SchemaName: msdyn_ingestedarticleurl, IntroducedVersion: 9.1.0.0.  Description: Ingested article URL</summary>
	public const string msdyn_ingestedarticleurl = "msdyn_ingestedarticleurl";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Integrated Search Dataprovider Id , Format: None, SchemaName: msdyn_integratedsearchproviderid, IntroducedVersion: 1.0.0.0.  Description: Integrated Search Dataprovider Id </summary>
	public const string msdyn_integratedsearchproviderid = "msdyn_integratedsearchproviderid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Integrated Search Dataprovider Id , Format: None, SchemaName: msdyn_integratedsearchproviderid, IntroducedVersion: 1.0.0.0.  Description: Integrated Search Dataprovider Id </summary>
	public const string msdyn_integratedsearchproviderid_Lookup = "_msdyn_integratedsearchproviderid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_integratedsearchproviderid, Format: Text, MaxLength: 255, SchemaName: msdyn_integratedsearchprovideridName, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_integratedsearchprovideridName = "msdyn_integratedsearchprovideridname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is content synced to file storage, SchemaName: msdyn_iscontentsyncedtostore, IntroducedVersion: 1.0.  Description: Sets whether the article content is synced to file storage</summary>
	public const string msdyn_iscontentsyncedtostore = "msdyn_iscontentsyncedtostore";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_iscontentsyncedtostore, SchemaName: msdyn_iscontentsyncedtostoreName, IntroducedVersion: 1.0. </summary>
	public const string msdyn_iscontentsyncedtostoreName = "msdyn_iscontentsyncedtostorename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Ingested Article, SchemaName: msdyn_isingestedarticle, IntroducedVersion: 9.1.0.0.  Description: Value is true for all Ingested articles</summary>
	public const string msdyn_isingestedarticle = "msdyn_isingestedarticle";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isingestedarticle, SchemaName: msdyn_isingestedarticleName, IntroducedVersion: 9.1.0.0. </summary>
	public const string msdyn_isingestedarticleName = "msdyn_isingestedarticlename";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Keywords and Description Suggestion control, SchemaName: msdyn_keywordsdescsuggestioncontrol, IntroducedVersion: 9.1.0.0. </summary>
	public const string msdyn_keywordsdescsuggestioncontrol = "msdyn_keywordsdescsuggestioncontrol";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_keywordsdescsuggestioncontrol, SchemaName: msdyn_keywordsdescsuggestioncontrolName, IntroducedVersion: 9.1.0.0. </summary>
	public const string msdyn_keywordsdescsuggestioncontrolName = "msdyn_keywordsdescsuggestioncontrolname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Language Code, Format: Text, MaxLength: 100, SchemaName: msdyn_languagecode, IntroducedVersion: 1.0.0.0.  Description: The Language Code that the article's content is in.</summary>
	public const string msdyn_languagecode = "msdyn_languagecode";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: File storage migration retry count, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_retrycountformigrationtocontentstore, IntroducedVersion: 1.0.  Description: Displays the number of times migration to file storage retry is attempted for an article</summary>
	public const string msdyn_retrycountformigrationtocontentstore = "msdyn_retrycountformigrationtocontentstore";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 8.0.0.0.  Description: Date and time that the record was migrated.</summary>
	public const string OverriddenCreatedOn = "overriddencreatedon";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user or team who owns the record.</summary>
	public const string OwnerId = "ownerid";

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user or team who owns the record.</summary>
	public const string OwnerId_Lookup = "_ownerid_value";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 8.0.0.0.  Description: Name of the owner</summary>
	public const string OwnerIdName = "owneridname";

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 8.0.0.0.  Description: Owner Id Type</summary>
	public const string OwnerIdType = "owneridtype";

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 8.0.0.0.  Description: Yomi name of the owner</summary>
	public const string OwnerIdYomiName = "owneridyominame";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	public const string OwningBusinessUnit = "owningbusinessunit";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	public const string OwningBusinessUnit_Lookup = "_owningbusinessunit_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 8.0.0.0. </summary>
	public const string OwningBusinessUnitName = "owningbusinessunitname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	public const string OwningTeam = "owningteam";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	public const string OwningTeam_Lookup = "_owningteam_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	public const string OwningUser = "owninguser";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	public const string OwningUser_Lookup = "_owninguser_value";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Article Content Id, Format: None, SchemaName: ParentArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the parent article content associated with the entity.</summary>
	public const string ParentArticleContentId = "parentarticlecontentid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Article Content Id, Format: None, SchemaName: ParentArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the parent article content associated with the entity.</summary>
	public const string ParentArticleContentId_Lookup = "_parentarticlecontentid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentarticlecontentid, Format: Text, MaxLength: 500, SchemaName: ParentArticleContentIdName, IntroducedVersion: 8.0.0.0. </summary>
	public const string ParentArticleContentIdName = "parentarticlecontentidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Previous Article Content ID, Format: None, SchemaName: PreviousArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Shows the version that the current article was restored from.</summary>
	public const string PreviousArticleContentId = "previousarticlecontentid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Previous Article Content ID, Format: None, SchemaName: PreviousArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Shows the version that the current article was restored from.</summary>
	public const string PreviousArticleContentId_Lookup = "_previousarticlecontentid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: previousarticlecontentid, Format: Text, MaxLength: 100, SchemaName: PreviousArticleContentIdName, IntroducedVersion: 8.0.0.0. </summary>
	public const string PreviousArticleContentIdName = "previousarticlecontentidname";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Author Id, Format: None, SchemaName: primaryauthorid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the primary author associated with the article.</summary>
	public const string primaryauthorid = "primaryauthorid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Author Id, Format: None, SchemaName: primaryauthorid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the primary author associated with the article.</summary>
	public const string primaryauthorid_Lookup = "_primaryauthorid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primaryauthorid, Format: Text, MaxLength: 100, SchemaName: primaryauthoridName, IntroducedVersion: 8.0.0.0. </summary>
	public const string primaryauthoridName = "primaryauthoridname";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process Id, SchemaName: processid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the process associated with the entity.</summary>
	public const string processid = "processid";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Publish On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: PublishOn, IntroducedVersion: 8.0.0.0.  Description: Date and time when the record was published.</summary>
	public const string PublishOn = "publishon";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Published Status, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: PublishStatusId, IntroducedVersion: 8.0.0.0.  Description: Publish Status of the Article.</summary>
	public const string PublishStatusId = "publishstatusid";

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Rating, Precision: 2, MinValue: -100000000000, MaxValue: 100000000000, SchemaName: Rating, IntroducedVersion: 8.1.0.0.  Description: Information which specifies how helpful the related record was.</summary>
	public const string Rating = "rating";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Rating(Count), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: Rating_Count, IntroducedVersion: 8.1.0.0.  Description: Rating Count</summary>
	public const string Rating_Count = "rating_count";

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Rating(Last Updated Time), DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: Rating_Date, IntroducedVersion: 8.1.0.0.  Description: The date time for Rating.</summary>
	public const string Rating_Date = "rating_date";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Rating(State), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: Rating_State, IntroducedVersion: 8.1.0.0.  Description: State of Rating</summary>
	public const string Rating_State = "rating_state";

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Rating(sum), Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: Rating_Sum, IntroducedVersion: 8.1.0.0.  Description: Total sum of Rating</summary>
	public const string Rating_Sum = "rating_sum";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Ready For Review, SchemaName: ReadyForReview, IntroducedVersion: 8.0.0.0.  Description: Ready For Review</summary>
	public const string ReadyForReview = "readyforreview";

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Review, SchemaName: Review, IntroducedVersion: 8.0.0.0.  Description: Review</summary>
	public const string Review = "review";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Root Article Id, Format: None, SchemaName: RootArticleId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the root article.</summary>
	public const string RootArticleId = "rootarticleid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Root Article Id, Format: None, SchemaName: RootArticleId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the root article.</summary>
	public const string RootArticleId_Lookup = "_rootarticleid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: rootarticleid, Format: Text, MaxLength: 100, SchemaName: RootArticleIdName, IntroducedVersion: 8.0.0.0. </summary>
	public const string RootArticleIdName = "rootarticleidname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Scheduled Status, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ScheduledStatusId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the scheduled status of the entity.</summary>
	public const string ScheduledStatusId = "scheduledstatusid";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Set Category Associations, SchemaName: SetCategoryAssociations, IntroducedVersion: 8.1.0.0.  Description: Shows whether category associations have been set</summary>
	public const string SetCategoryAssociations = "setcategoryassociations";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: setcategoryassociations, SchemaName: SetCategoryAssociationsName, IntroducedVersion: 8.1.0.0. </summary>
	public const string SetCategoryAssociationsName = "setcategoryassociationsname";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Set Product Associations, SchemaName: SetProductAssociations, IntroducedVersion: 8.0.0.0.  Description: Set Product Associations</summary>
	public const string SetProductAssociations = "setproductassociations";

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Stage Id, SchemaName: stageid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the stage where the entity is located.</summary>
	public const string stageid = "stageid";

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 8.0.0.0.  Description: Shows whether the article is a draft or is published, archived, or discarded. Draft articles aren't available externally and can be edited. Published articles are available externally, based on applicable permissions, but can't be edited. All metadata changes are reflected in the published version. Archived and discarded articles aren't available externally and can't be edited.</summary>
	public const string StateCode = "statecode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 8.0.0.0. </summary>
	public const string StateCodeName = "statecodename";

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 8.0.0.0.  Description: Select the article's status.</summary>
	public const string StatusCode = "statuscode";

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 8.0.0.0. </summary>
	public const string StatusCodeName = "statuscodename";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 8.0.0.0.  Description: Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.</summary>
	public const string SubjectId = "subjectid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 8.0.0.0.  Description: Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.</summary>
	public const string SubjectId_Lookup = "_subjectid_value";

	/// <summary>Type: Integer, RequiredLevel: None, AttributeOf: subjectid, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: SubjectIdDsc, IntroducedVersion: 8.0.0.0. </summary>
	public const string SubjectIdDsc = "subjectiddsc";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: subjectid, Format: Text, MaxLength: 100, SchemaName: SubjectIdName, IntroducedVersion: 8.0.0.0. </summary>
	public const string SubjectIdName = "subjectidname";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 8.0.0.0.  Description: For internal use only.</summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Title, Format: Text, MaxLength: 4000, SchemaName: Title, IntroducedVersion: 8.0.0.0.  Description: Type a title for the article.</summary>
	public const string Title = "title";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 8.0.0.0.  Description: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.</summary>
	public const string TransactionCurrencyId = "transactioncurrencyid";

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 8.0.0.0.  Description: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.</summary>
	public const string TransactionCurrencyId_Lookup = "_transactioncurrencyid_value";

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 8.0.0.0. </summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: traversedpath, IntroducedVersion: 8.0.0.0.  Description: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.</summary>
	public const string traversedpath = "traversedpath";

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Update Content, SchemaName: UpdateContent, IntroducedVersion: 8.0.0.0.  Description: Update Content</summary>
	public const string UpdateContent = "updatecontent";

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 8.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

	/// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 8.0.0.0. </summary>
	public const string VersionNumber = "versionnumber";

}

