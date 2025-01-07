namespace ECSM.Models.Dynamics;

/// <summary>Location or branch office where an organization does business. An organization can have multiple sites.</summary>
public static partial class SiteManyToOne
{
	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_site_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: site, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_site_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_site_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_site_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: site, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_site_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_site_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_sitebase_createdby, ReferencingAttribute: createdby, ReferencingEntity: site, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_sitebase_createdby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_sitebase_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_sitebase_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: site, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_sitebase_modifiedby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_sitebase_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_sites, ReferencingAttribute: organizationid, ReferencingEntity: site, ReferencingEntityNavigationPropertyName: organizationid_organization, RelationshipBehavior: 0, SchemaName: organization_sites, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string organization_sites = "organizationid_organization";

}

