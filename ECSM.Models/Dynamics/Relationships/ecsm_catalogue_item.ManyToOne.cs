namespace ECSM.Models.Dynamics;

public static partial class ecsm_catalogue_itemManyToOne
{
	/// <summary>ReferencedAttribute: mailmergetemplateid, ReferencedEntity: mailmergetemplate, ReferencedEntityNavigationPropertyName: ecsm_catalogue_item_auto_reply_email_template_, ReferencingAttribute: ecsm_auto_reply_email_template, ReferencingEntity: ecsm_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_auto_reply_email_template, RelationshipBehavior: 1, SchemaName: ecsm_catalogue_item_auto_reply_email_template_, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_auto_reply_email_template_ = "ecsm_auto_reply_email_template";

	/// <summary>ReferencedAttribute: productid, ReferencedEntity: product, ReferencedEntityNavigationPropertyName: ecsm_catalogue_item_product_product, ReferencingAttribute: ecsm_product, ReferencingEntity: ecsm_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_product, RelationshipBehavior: 1, SchemaName: ecsm_catalogue_item_product_product, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_product_product = "ecsm_product";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_catalogue_item, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_catalogue_item, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_catalogue_item, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_catalogue_item, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_catalogue_item, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_catalogue_item, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_catalogue_item, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_catalogue_item = "organizationid";

}

