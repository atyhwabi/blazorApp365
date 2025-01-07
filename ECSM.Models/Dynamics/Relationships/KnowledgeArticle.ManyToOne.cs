namespace ECSM.Models.Dynamics;

/// <summary>Organizational knowledge for internal and external use.</summary>
public static partial class KnowledgeArticleManyToOne
{
	/// <summary>ReferencedAttribute: businessunitid, ReferencedEntity: businessunit, ReferencedEntityNavigationPropertyName: business_unit_knowledgearticle, ReferencingAttribute: owningbusinessunit, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: owningbusinessunit, RelationshipBehavior: 0, SchemaName: business_unit_knowledgearticle, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string business_unit_knowledgearticle = "owningbusinessunit";

	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_KnowledgeArticle_msdyn_contentstore, ReferencingAttribute: msdyn_contentstore, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: msdyn_contentstore, RelationshipBehavior: 0, SchemaName: FileAttachment_KnowledgeArticle_msdyn_contentstore, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string FileAttachment_KnowledgeArticle_msdyn_contentstore = "msdyn_contentstore";

	/// <summary>ReferencedAttribute: languagelocaleid, ReferencedEntity: languagelocale, ReferencedEntityNavigationPropertyName: knowledgearticle_languagelocaleid, ReferencingAttribute: languagelocaleid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: languagelocaleid, RelationshipBehavior: 1, SchemaName: knowledgearticle_languagelocaleid, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_languagelocaleid = "languagelocaleid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_parentarticle_contentid, ReferencingAttribute: parentarticlecontentid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: ParentArticleContentId, RelationshipBehavior: 1, SchemaName: knowledgearticle_parentarticle_contentid, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_parentarticle_contentid = "ParentArticleContentId";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_previousarticle_contentid, ReferencingAttribute: previousarticlecontentid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: PreviousArticleContentId, RelationshipBehavior: 1, SchemaName: knowledgearticle_previousarticle_contentid, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_previousarticle_contentid = "PreviousArticleContentId";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: knowledgearticle_primaryauthorid, ReferencingAttribute: primaryauthorid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: primaryauthorid, RelationshipBehavior: 0, SchemaName: knowledgearticle_primaryauthorid, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_primaryauthorid = "primaryauthorid";

	/// <summary>ReferencedAttribute: knowledgearticleid, ReferencedEntity: knowledgearticle, ReferencedEntityNavigationPropertyName: knowledgearticle_rootarticle_id, ReferencingAttribute: rootarticleid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: RootArticleId, RelationshipBehavior: 1, SchemaName: knowledgearticle_rootarticle_id, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string knowledgearticle_rootarticle_id = "RootArticleId";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_knowledgearticle_createdby, ReferencingAttribute: createdby, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_knowledgearticle_createdby, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string lk_knowledgearticle_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_knowledgearticle_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_knowledgearticle_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string lk_knowledgearticle_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_knowledgearticle_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_knowledgearticle_modifiedby, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string lk_knowledgearticle_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_knowledgearticle_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_knowledgearticle_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string lk_knowledgearticle_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: msdyn_integratedsearchproviderid, ReferencedEntity: msdyn_integratedsearchprovider, ReferencedEntityNavigationPropertyName: msdyn_knowledgearticle_integratedsearchprovider, ReferencingAttribute: msdyn_integratedsearchproviderid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: msdyn_integratedsearchproviderid, RelationshipBehavior: 1, SchemaName: msdyn_knowledgearticle_integratedsearchprovider, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_knowledgearticle_integratedsearchprovider = "msdyn_integratedsearchproviderid";

	/// <summary>ReferencedAttribute: ownerid, ReferencedEntity: owner, ReferencedEntityNavigationPropertyName: owner_knowledgearticle, ReferencingAttribute: ownerid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: ownerid, RelationshipBehavior: 0, SchemaName: owner_knowledgearticle, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string owner_knowledgearticle = "ownerid";

	/// <summary>ReferencedAttribute: processstageid, ReferencedEntity: processstage, ReferencedEntityNavigationPropertyName: processstage_knowledgearticle, ReferencingAttribute: stageid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: stageid_processstage, RelationshipBehavior: 2, SchemaName: processstage_knowledgearticle, SecurityTypes: ParentChild, IntroducedVersion: 8.0.0.0. </summary>
	public const string processstage_knowledgearticle = "stageid_processstage";

	/// <summary>ReferencedAttribute: subjectid, ReferencedEntity: subject, ReferencedEntityNavigationPropertyName: subject_knowledgearticles, ReferencingAttribute: subjectid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: subjectid, RelationshipBehavior: 1, SchemaName: subject_knowledgearticles, SecurityTypes: Append, IntroducedVersion: 8.0.0.0. </summary>
	public const string subject_knowledgearticles = "subjectid";

	/// <summary>ReferencedAttribute: teamid, ReferencedEntity: team, ReferencedEntityNavigationPropertyName: team_knowledgearticle, ReferencingAttribute: owningteam, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: owningteam, RelationshipBehavior: 0, SchemaName: team_knowledgearticle, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string team_knowledgearticle = "owningteam";

	/// <summary>ReferencedAttribute: transactioncurrencyid, ReferencedEntity: transactioncurrency, ReferencedEntityNavigationPropertyName: transactioncurrency_knowledgearticle, ReferencingAttribute: transactioncurrencyid, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: transactioncurrencyid, RelationshipBehavior: 0, SchemaName: TransactionCurrency_knowledgearticle, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string TransactionCurrency_knowledgearticle = "transactioncurrencyid";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: user_knowledgearticle, ReferencingAttribute: owninguser, ReferencingEntity: knowledgearticle, ReferencingEntityNavigationPropertyName: owninguser, RelationshipBehavior: 0, SchemaName: user_knowledgearticle, SecurityTypes: None, IntroducedVersion: 8.0.0.0. </summary>
	public const string user_knowledgearticle = "owninguser";

}

