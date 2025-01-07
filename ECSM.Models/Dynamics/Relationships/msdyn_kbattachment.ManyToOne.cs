namespace ECSM.Models.Dynamics;

public static partial class msdyn_kbattachmentManyToOne
{
	/// <summary>ReferencedAttribute: businessunitid, ReferencedEntity: businessunit, ReferencedEntityNavigationPropertyName: business_unit_msdyn_kbattachment, ReferencingAttribute: owningbusinessunit, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: owningbusinessunit, RelationshipBehavior: 0, SchemaName: business_unit_msdyn_kbattachment, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string business_unit_msdyn_kbattachment = "owningbusinessunit";

	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_msdyn_kbattachment_msdyn_fileattachment, ReferencingAttribute: msdyn_fileattachment, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: msdyn_fileattachment, RelationshipBehavior: 0, SchemaName: FileAttachment_msdyn_kbattachment_msdyn_fileattachment, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string FileAttachment_msdyn_kbattachment_msdyn_fileattachment = "msdyn_fileattachment";

	/// <summary>ReferencedAttribute: imagedescriptorid, ReferencedEntity: imagedescriptor, ReferencedEntityNavigationPropertyName: ImageDescriptor_msdyn_kbattachment_msdyn_fileicon, ReferencingAttribute: msdyn_fileiconid, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: msdyn_fileiconid_imagedescriptor, RelationshipBehavior: 0, SchemaName: ImageDescriptor_msdyn_kbattachment_msdyn_fileicon, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ImageDescriptor_msdyn_kbattachment_msdyn_fileicon = "msdyn_fileiconid_imagedescriptor";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_msdyn_kbattachment_createdby, ReferencingAttribute: createdby, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_msdyn_kbattachment_createdby, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string lk_msdyn_kbattachment_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_msdyn_kbattachment_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_msdyn_kbattachment_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string lk_msdyn_kbattachment_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_msdyn_kbattachment_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_msdyn_kbattachment_modifiedby, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string lk_msdyn_kbattachment_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_msdyn_kbattachment_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_msdyn_kbattachment_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string lk_msdyn_kbattachment_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: ownerid, ReferencedEntity: owner, ReferencedEntityNavigationPropertyName: owner_msdyn_kbattachment, ReferencingAttribute: ownerid, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: ownerid, RelationshipBehavior: 0, SchemaName: owner_msdyn_kbattachment, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string owner_msdyn_kbattachment = "ownerid";

	/// <summary>ReferencedAttribute: teamid, ReferencedEntity: team, ReferencedEntityNavigationPropertyName: team_msdyn_kbattachment, ReferencingAttribute: owningteam, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: owningteam, RelationshipBehavior: 0, SchemaName: team_msdyn_kbattachment, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string team_msdyn_kbattachment = "owningteam";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: user_msdyn_kbattachment, ReferencingAttribute: owninguser, ReferencingEntity: msdyn_kbattachment, ReferencingEntityNavigationPropertyName: owninguser, RelationshipBehavior: 0, SchemaName: user_msdyn_kbattachment, SecurityTypes: None, IntroducedVersion: 9.1.0.0. </summary>
	public const string user_msdyn_kbattachment = "owninguser";

}

