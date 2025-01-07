namespace ECSM.Models.Dynamics;

/// <summary>Service Catalogues enable Admins to create unique collections of Service Catalogue Items to make them available in the Portal to relevant Personas</summary>
public static partial class ecsm_service_catalogueOneToMany
{
	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_category_service_catalogue_id_ecsm_servic, ReferencingAttribute: ecsm_service_catalogue_id, ReferencingEntity: ecsm_category, ReferencingEntityNavigationPropertyName: ecsm_service_catalogue_id, RelationshipBehavior: 1, SchemaName: ecsm_category_service_catalogue_id_ecsm_servic, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_category_service_catalogue_id_ecsm_servic = "ecsm_category_service_catalogue_id_ecsm_servic";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_portal_role_service_catalogue_ecsm_service_catalogue, ReferencingAttribute: ecsm_service_catalogue, ReferencingEntity: ecsm_portal_role, ReferencingEntityNavigationPropertyName: ecsm_service_catalogue, RelationshipBehavior: 1, SchemaName: ecsm_portal_role_service_catalogue_ecsm_service_catalogue, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_portal_role_service_catalogue_ecsm_service_catalogue = "ecsm_portal_role_service_catalogue_ecsm_service_catalogue";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_service_catalogue, RelationshipBehavior: 0, SchemaName: ecsm_service_catalogue_AsyncOperations, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_AsyncOperations = "ecsm_service_catalogue_AsyncOperations";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_service_catalogue, RelationshipBehavior: 0, SchemaName: ecsm_service_catalogue_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_BulkDeleteFailures = "ecsm_service_catalogue_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_FileAttachments, ReferencingAttribute: objectid, ReferencingEntity: fileattachment, ReferencingEntityNavigationPropertyName: objectid_ecsm_service_catalogue, RelationshipBehavior: 2, SchemaName: ecsm_service_catalogue_FileAttachments, SecurityTypes: ParentChild, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_FileAttachments = "ecsm_service_catalogue_FileAttachments";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_item_service_catalogue_, ReferencingAttribute: ecsm_service_catalogue, ReferencingEntity: ecsm_service_catalogue_item, ReferencingEntityNavigationPropertyName: ecsm_service_catalogue, RelationshipBehavior: 1, SchemaName: ecsm_service_catalogue_item_service_catalogue_, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_item_service_catalogue_ = "ecsm_service_catalogue_item_service_catalogue_";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_MailboxTrackingFolders, ReferencingAttribute: regardingobjectid, ReferencingEntity: mailboxtrackingfolder, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_service_catalogue, RelationshipBehavior: 0, SchemaName: ecsm_service_catalogue_MailboxTrackingFolders, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_MailboxTrackingFolders = "ecsm_service_catalogue_MailboxTrackingFolders";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_PrincipalObjectAttributeAccesses, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_ecsm_service_catalogue, RelationshipBehavior: 0, SchemaName: ecsm_service_catalogue_PrincipalObjectAttributeAccesses, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_PrincipalObjectAttributeAccesses = "ecsm_service_catalogue_PrincipalObjectAttributeAccesses";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_ProcessSession, ReferencingAttribute: regardingobjectid, ReferencingEntity: processsession, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_service_catalogue, RelationshipBehavior: 0, SchemaName: ecsm_service_catalogue_ProcessSession, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_ProcessSession = "ecsm_service_catalogue_ProcessSession";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_service_catalogue, RelationshipBehavior: 0, SchemaName: ecsm_service_catalogue_SyncErrors, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_SyncErrors = "ecsm_service_catalogue_SyncErrors";

	/// <summary>ReferencedAttribute: ecsm_service_catalogueid, ReferencedEntity: ecsm_service_catalogue, ReferencedEntityNavigationPropertyName: ecsm_service_catalogue_UserEntityInstanceDatas, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_ecsm_service_catalogue, RelationshipBehavior: 0, SchemaName: ecsm_service_catalogue_UserEntityInstanceDatas, SecurityTypes: None, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_service_catalogue_UserEntityInstanceDatas = "ecsm_service_catalogue_UserEntityInstanceDatas";

}

