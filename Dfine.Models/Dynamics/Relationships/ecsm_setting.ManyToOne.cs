namespace ECSM.Models.Dynamics;

public static partial class ecsm_settingManyToOne
{
	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_ecsm_setting_ecsm_LogoValue, ReferencingAttribute: ecsm_logovalue, ReferencingEntity: ecsm_setting, ReferencingEntityNavigationPropertyName: ecsm_logovalue, RelationshipBehavior: 0, SchemaName: FileAttachment_ecsm_setting_ecsm_LogoValue, SecurityTypes: None, IntroducedVersion: 1.3.0.3. </summary>
	public const string FileAttachment_ecsm_setting_ecsm_LogoValue = "ecsm_logovalue";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_setting_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_setting, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_setting_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_setting_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_setting_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_setting, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_setting_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_setting_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_setting_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_setting, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_setting_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_setting_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_setting_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_setting, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_setting_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_setting_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_setting, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_setting, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_setting, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_setting = "organizationid";

}

