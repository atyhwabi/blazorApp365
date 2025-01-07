namespace ECSM.Models.Dynamics;

public static partial class ecsm_portal_roleManyToMany
{
	/// <summary>Entity1IntersectAttribute: contactid, Entity1LogicalName: contact, Entity1NavigationPropertyName: ecsm_portal_role_Contact_Contact, Entity2IntersectAttribute: ecsm_portal_roleid, Entity2LogicalName: ecsm_portal_role, Entity2NavigationPropertyName: ecsm_portal_role_Contact_Contact, IntersectEntityName: ecsm_portal_role_contact, SchemaName: ecsm_portal_role_Contact_Contact, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_role_Contact_Contact = "ecsm_portal_role_Contact_Contact";

	/// <summary>Entity1IntersectAttribute: ecsm_categoryid, Entity1LogicalName: ecsm_category, Entity1NavigationPropertyName: ecsm_portal_role_ecsm_category_ecsm_category, Entity2IntersectAttribute: ecsm_portal_roleid, Entity2LogicalName: ecsm_portal_role, Entity2NavigationPropertyName: ecsm_portal_role_ecsm_category_ecsm_category, IntersectEntityName: ecsm_portal_role_ecsm_category, SchemaName: ecsm_portal_role_ecsm_category_ecsm_category, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_role_ecsm_category_ecsm_category = "ecsm_portal_role_ecsm_category_ecsm_category";

	/// <summary>Entity1IntersectAttribute: ecsm_service_catalogueid, Entity1LogicalName: ecsm_service_catalogue, Entity1NavigationPropertyName: ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue, Entity2IntersectAttribute: ecsm_portal_roleid, Entity2LogicalName: ecsm_portal_role, Entity2NavigationPropertyName: ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue, IntersectEntityName: ecsm_portal_role_ecsm_service_catalogue, SchemaName: ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue = "ecsm_portal_role_ecsm_service_catalogue_ecsm_service_catalogue";

	/// <summary>Entity1IntersectAttribute: ecsm_portal_roleid, Entity1LogicalName: ecsm_portal_role, Entity1NavigationPropertyName: ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role, Entity2IntersectAttribute: ecsm_service_catalogue_itemid, Entity2LogicalName: ecsm_service_catalogue_item, Entity2NavigationPropertyName: ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role, IntersectEntityName: ecsm_service_catalogue_item_ecsm_portal, SchemaName: ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role = "ecsm_service_catalogue_item_ecsm_portal_role_ecsm_portal_role";

}

