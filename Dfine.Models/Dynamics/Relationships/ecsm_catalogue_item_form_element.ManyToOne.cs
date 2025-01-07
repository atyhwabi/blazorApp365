namespace ECSM.Models.Dynamics;

public static partial class ecsm_catalogue_item_form_elementManyToOne
{
	/// <summary>ReferencedAttribute: ecsm_catalogue_itemid, ReferencedEntity: ecsm_catalogue_item, ReferencedEntityNavigationPropertyName: ecsm_catalogue_item_form_element_catalogue_ite, ReferencingAttribute: ecsm_catalogue_item, ReferencingEntity: ecsm_catalogue_item_form_element, ReferencingEntityNavigationPropertyName: ecsm_catalogue_item, RelationshipBehavior: 1, SchemaName: ecsm_catalogue_item_form_element_catalogue_ite, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_form_element_catalogue_ite = "ecsm_catalogue_item";

	/// <summary>ReferencedAttribute: ecsm_content_blockid, ReferencedEntity: ecsm_content_block, ReferencedEntityNavigationPropertyName: ecsm_catalogue_item_form_element_Content_block, ReferencingAttribute: ecsm_content_block, ReferencingEntity: ecsm_catalogue_item_form_element, ReferencingEntityNavigationPropertyName: ecsm_Content_block, RelationshipBehavior: 1, SchemaName: ecsm_catalogue_item_form_element_Content_block, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_catalogue_item_form_element_Content_block = "ecsm_Content_block";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_form_element_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_catalogue_item_form_element, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_form_element_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_form_element_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_form_element_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_catalogue_item_form_element, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_form_element_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_form_element_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_form_element_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_catalogue_item_form_element, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_form_element_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_form_element_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_catalogue_item_form_element_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_catalogue_item_form_element, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_catalogue_item_form_element_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_catalogue_item_form_element_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_catalogue_item_form_element, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_catalogue_item_form_element, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_catalogue_item_form_element, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_catalogue_item_form_element = "organizationid";

}

