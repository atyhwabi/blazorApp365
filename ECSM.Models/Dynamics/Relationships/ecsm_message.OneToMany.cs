namespace ECSM.Models.Dynamics;

public static partial class ecsm_messageOneToMany
{
	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_message_AsyncOperations, ReferencingAttribute: regardingobjectid, ReferencingEntity: asyncoperation, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_message, RelationshipBehavior: 0, SchemaName: ecsm_message_AsyncOperations, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_message_AsyncOperations = "ecsm_message_AsyncOperations";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_message_BulkDeleteFailures, ReferencingAttribute: regardingobjectid, ReferencingEntity: bulkdeletefailure, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_message, RelationshipBehavior: 0, SchemaName: ecsm_message_BulkDeleteFailures, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_message_BulkDeleteFailures = "ecsm_message_BulkDeleteFailures";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_message_MailboxTrackingFolders, ReferencingAttribute: regardingobjectid, ReferencingEntity: mailboxtrackingfolder, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_message, RelationshipBehavior: 0, SchemaName: ecsm_message_MailboxTrackingFolders, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_message_MailboxTrackingFolders = "ecsm_message_MailboxTrackingFolders";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_message_PrincipalObjectAttributeAccesses, ReferencingAttribute: objectid, ReferencingEntity: principalobjectattributeaccess, ReferencingEntityNavigationPropertyName: objectid_ecsm_message, RelationshipBehavior: 0, SchemaName: ecsm_message_PrincipalObjectAttributeAccesses, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_message_PrincipalObjectAttributeAccesses = "ecsm_message_PrincipalObjectAttributeAccesses";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_message_ProcessSession, ReferencingAttribute: regardingobjectid, ReferencingEntity: processsession, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_message, RelationshipBehavior: 0, SchemaName: ecsm_message_ProcessSession, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_message_ProcessSession = "ecsm_message_ProcessSession";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_message_SyncErrors, ReferencingAttribute: regardingobjectid, ReferencingEntity: syncerror, ReferencingEntityNavigationPropertyName: regardingobjectid_ecsm_message, RelationshipBehavior: 0, SchemaName: ecsm_message_SyncErrors, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_message_SyncErrors = "ecsm_message_SyncErrors";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_message_UserEntityInstanceDatas, ReferencingAttribute: objectid, ReferencingEntity: userentityinstancedata, ReferencingEntityNavigationPropertyName: objectid_ecsm_message, RelationshipBehavior: 0, SchemaName: ecsm_message_UserEntityInstanceDatas, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string ecsm_message_UserEntityInstanceDatas = "ecsm_message_UserEntityInstanceDatas";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_messageattachment_message_ecsm_message, ReferencingAttribute: ecsm_message, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: ecsm_message, RelationshipBehavior: 1, SchemaName: ecsm_messageattachment_message_ecsm_message, SecurityTypes: Append, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_messageattachment_message_ecsm_message = "ecsm_messageattachment_message_ecsm_message";

}

