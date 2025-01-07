namespace ECSM.Models.Dynamics;

/// <summary>Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.</summary>
public static partial class SystemUserManyToMany
{
	/// <summary>Entity1IntersectAttribute: msdyn_appconfigurationid, Entity1LogicalName: msdyn_appconfiguration, Entity1NavigationPropertyName: msdyn_appconfiguration_systemuser, Entity2IntersectAttribute: systemuserid, Entity2LogicalName: systemuser, Entity2NavigationPropertyName: msdyn_appconfiguration_systemuser, IntersectEntityName: msdyn_appconfiguration_systemuser, SchemaName: msdyn_appconfiguration_systemuser, SecurityTypes: None, IntroducedVersion: 9.0.0.1. </summary>
	public const string msdyn_appconfiguration_systemuser = "msdyn_appconfiguration_systemuser";

	/// <summary>Entity1IntersectAttribute: msdyn_ciproviderid, Entity1LogicalName: msdyn_ciprovider, Entity1NavigationPropertyName: msdyn_ciprovider_systemuser_membership, Entity2IntersectAttribute: systemuserid, Entity2LogicalName: systemuser, Entity2NavigationPropertyName: msdyn_ciprovider_systemuser_membership, IntersectEntityName: msdyn_ciprovider_systemuser, SchemaName: msdyn_ciprovider_systemuser_membership, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string msdyn_ciprovider_systemuser_membership = "msdyn_ciprovider_systemuser_membership";

	/// <summary>Entity1IntersectAttribute: msdyn_attributevalueid, Entity1LogicalName: msdyn_attributevalue, Entity1NavigationPropertyName: msdyn_msdyn_attributevalue_systemuser, Entity2IntersectAttribute: systemuserid, Entity2LogicalName: systemuser, Entity2NavigationPropertyName: msdyn_msdyn_attributevalue_systemuser, IntersectEntityName: msdyn_msdyn_attributevalue_systemuser, SchemaName: msdyn_msdyn_attributevalue_systemuser, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string msdyn_msdyn_attributevalue_systemuser = "msdyn_msdyn_attributevalue_systemuser";

	/// <summary>Entity1IntersectAttribute: msdyn_liveworkstreamid, Entity1LogicalName: msdyn_liveworkstream, Entity1NavigationPropertyName: msdyn_msdyn_liveworkstream_systemuser, Entity2IntersectAttribute: systemuserid, Entity2LogicalName: systemuser, Entity2NavigationPropertyName: msdyn_msdyn_liveworkstream_systemuser, IntersectEntityName: msdyn_msdyn_liveworkstream_systemuser, SchemaName: msdyn_msdyn_liveworkstream_systemuser, SecurityTypes: None, IntroducedVersion: 1.0.0.3. </summary>
	public const string msdyn_msdyn_liveworkstream_systemuser = "msdyn_msdyn_liveworkstream_systemuser";

	/// <summary>Entity1IntersectAttribute: systemuserid, Entity1LogicalName: systemuser, Entity1NavigationPropertyName: msdyn_systemuser_msdyn_omnichannelqueue, Entity2IntersectAttribute: msdyn_omnichannelqueueid, Entity2LogicalName: msdyn_omnichannelqueue, Entity2NavigationPropertyName: msdyn_systemuser_msdyn_omnichannelqueue, IntersectEntityName: msdyn_systemuser_msdyn_omnichannelqueue, SchemaName: msdyn_systemuser_msdyn_omnichannelqueue, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_systemuser_msdyn_omnichannelqueue = "msdyn_systemuser_msdyn_omnichannelqueue";

	/// <summary>Entity1IntersectAttribute: powerpagecomponentid, Entity1LogicalName: powerpagecomponent, Entity1NavigationPropertyName: powerpagecomponent_webrole_systemuser, Entity2IntersectAttribute: systemuserid, Entity2LogicalName: systemuser, Entity2NavigationPropertyName: powerpagecomponent_webrole_systemuser, IntersectEntityName: powerpagecomponent_webrole_systemuser, SchemaName: powerpagecomponent_webrole_systemuser, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string powerpagecomponent_webrole_systemuser = "powerpagecomponent_webrole_systemuser";

	/// <summary>Entity1IntersectAttribute: queueid, Entity1LogicalName: queue, Entity1NavigationPropertyName: queuemembership_association, Entity2IntersectAttribute: systemuserid, Entity2LogicalName: systemuser, Entity2NavigationPropertyName: queuemembership_association, IntersectEntityName: queuemembership, SchemaName: queuemembership_association, SecurityTypes: None, IntroducedVersion: 6.1.0.0. </summary>
	public const string queuemembership_association = "queuemembership_association";

	/// <summary>Entity1IntersectAttribute: systemuserid, Entity1LogicalName: systemuser, Entity1NavigationPropertyName: systemuserprofiles_association, Entity2IntersectAttribute: fieldsecurityprofileid, Entity2LogicalName: fieldsecurityprofile, Entity2NavigationPropertyName: systemuserprofiles_association, IntersectEntityName: systemuserprofiles, SchemaName: systemuserprofiles_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string systemuserprofiles_association = "systemuserprofiles_association";

	/// <summary>Entity1IntersectAttribute: systemuserid, Entity1LogicalName: systemuser, Entity1NavigationPropertyName: systemuserroles_association, Entity2IntersectAttribute: roleid, Entity2LogicalName: role, Entity2NavigationPropertyName: systemuserroles_association, IntersectEntityName: systemuserroles, SchemaName: systemuserroles_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string systemuserroles_association = "systemuserroles_association";

	/// <summary>Entity1IntersectAttribute: systemuserid, Entity1LogicalName: systemuser, Entity1NavigationPropertyName: systemusersyncmappingprofiles_association, Entity2IntersectAttribute: syncattributemappingprofileid, Entity2LogicalName: syncattributemappingprofile, Entity2NavigationPropertyName: systemusersyncmappingprofiles_association, IntersectEntityName: systemusersyncmappingprofiles, SchemaName: systemusersyncmappingprofiles_association, SecurityTypes: None, IntroducedVersion: 7.0.0.0. </summary>
	public const string systemusersyncmappingprofiles_association = "systemusersyncmappingprofiles_association";

	/// <summary>Entity1IntersectAttribute: teamid, Entity1LogicalName: team, Entity1NavigationPropertyName: teammembership_association, Entity2IntersectAttribute: systemuserid, Entity2LogicalName: systemuser, Entity2NavigationPropertyName: teammembership_association, IntersectEntityName: teammembership, SchemaName: teammembership_association, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string teammembership_association = "teammembership_association";

}

