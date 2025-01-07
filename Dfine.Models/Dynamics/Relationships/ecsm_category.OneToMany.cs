namespace ECSM.Models.Dynamics;

public static partial class ecsm_categoryOneToMany
{
	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_AsyncOperations, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_AsyncOperations = "ecsm_category_AsyncOperations";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_BulkDeleteFailures = "ecsm_category_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_DuplicateBaseRecord, ReferencingAttribute: baserecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: baserecordid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_DuplicateBaseRecord, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_DuplicateBaseRecord = "ecsm_category_DuplicateBaseRecord";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_DuplicateMatchingRecord, ReferencingAttribute: duplicaterecordid, ReferencingEntity: duplicaterecord, ReferencingEntityNavigationPropertyName: duplicaterecordid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_DuplicateMatchingRecord, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_DuplicateMatchingRecord = "ecsm_category_DuplicateMatchingRecord";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_FileAttachments, ReferencingAttribute: objectid, ReferencingEntity: fileattachment, ReferencingEntityNavigationPropertyName: objectid_ecsm_category, RelationshipBehavior: 2, SchemaName: ecsm_category_FileAttachments, SecurityTypes: ParentChild, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_category_FileAttachments = "ecsm_category_FileAttachments";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_MailboxTrackingFolders, ReferencingAttribute: regardingobjectid, ReferencingEntity: mailboxtrackingfolder, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_MailboxTrackingFolders, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_MailboxTrackingFolders = "ecsm_category_MailboxTrackingFolders";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_parent_category_ecsm_category, ReferencingAttribute: ecsm_parent_category, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: ecsm_parent_category, RelationshipBehavior: 1, SchemaName: ecsm_category_parent_category_ecsm_category, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_category_parent_category_ecsm_category = "ecsm_category_parent_category_ecsm_category";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_PrincipalObjectAttributeAccesses, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_PrincipalObjectAttributeAccesses, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_PrincipalObjectAttributeAccesses = "ecsm_category_PrincipalObjectAttributeAccesses";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_ProcessSession, ReferencingAttribute: regardingobjectid, ReferencingEntity: processsession, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_ProcessSession, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_ProcessSession = "ecsm_category_ProcessSession";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_SyncErrors, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_SyncErrors = "ecsm_category_SyncErrors";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_category_UserEntityInstanceDatas, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_ecsm_category, RelationshipBehavior: 0, SchemaName: ecsm_category_UserEntityInstanceDatas, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_category_UserEntityInstanceDatas = "ecsm_category_UserEntityInstanceDatas";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_incident_category_ecsm_category, ReferencingAttribute: ecsm_category, ReferencingEntity: ecsm_incident, ReferencingEntityNavigationPropertyName: ecsm_category, RelationshipBehavior: 1, SchemaName: ecsm_incident_category_ecsm_category, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_category_ecsm_category = "ecsm_incident_category_ecsm_category";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_incident_category_ecsm_category_, ReferencingAttribute: ecsm_category, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_category, RelationshipBehavior: 1, SchemaName: ecsm_incident_category_ecsm_category_, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_category_ecsm_category_ = "ecsm_incident_category_ecsm_category_";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_item_category_ecsm_cate, ReferencingAttribute: ecsm_category, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_category, RelationshipBehavior: 1, SchemaName: ecsm_service_catalogue_item_category_ecsm_cate, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_item_category_ecsm_cate = "ecsm_service_catalogue_item_category_ecsm_cate";

}

