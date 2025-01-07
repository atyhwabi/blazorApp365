namespace ECSM.Models.Dynamics;

public static partial class ecsm_MessageAttachmentManyToOne
{
	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: ecsm_messageattachment_incident_incident, ReferencingAttribute: ecsm_incident, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: ecsm_incident, RelationshipBehavior: 1, SchemaName: ecsm_messageattachment_incident_incident, SecurityTypes: Append, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_messageattachment_incident_incident = "ecsm_incident";

	/// <summary>ReferencedAttribute: ecsm_messageid, ReferencedEntity: ecsm_message, ReferencedEntityNavigationPropertyName: ecsm_messageattachment_message_ecsm_message, ReferencingAttribute: ecsm_message, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: ecsm_message, RelationshipBehavior: 1, SchemaName: ecsm_messageattachment_message_ecsm_message, SecurityTypes: Append, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_messageattachment_message_ecsm_message = "ecsm_message";

	/// <summary>ReferencedAttribute: fileattachmentid, ReferencedEntity: fileattachment, ReferencedEntityNavigationPropertyName: FileAttachment_ecsm_MessageAttachment_ecsm_attachment, ReferencingAttribute: ecsm_attachment, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: ecsm_attachment, RelationshipBehavior: 0, SchemaName: FileAttachment_ecsm_MessageAttachment_ecsm_attachment, SecurityTypes: None, IntroducedVersion: 1.1.0.13. </summary>
	public const string FileAttachment_ecsm_MessageAttachment_ecsm_attachment = "ecsm_attachment";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_messageattachment_createdby, ReferencingAttribute: createdby, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_ecsm_messageattachment_createdby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_messageattachment_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_messageattachment_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_messageattachment_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_messageattachment_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_messageattachment_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_ecsm_messageattachment_modifiedby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_messageattachment_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_ecsm_messageattachment_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_ecsm_messageattachment_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string lk_ecsm_messageattachment_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: organizationid, ReferencedEntity: organization, ReferencedEntityNavigationPropertyName: organization_ecsm_messageattachment, ReferencingAttribute: organizationid, ReferencingEntity: ecsm_messageattachment, ReferencingEntityNavigationPropertyName: organizationid, RelationshipBehavior: 0, SchemaName: organization_ecsm_messageattachment, SecurityTypes: None, IntroducedVersion: 1.0. </summary>
	public const string organization_ecsm_messageattachment = "organizationid";

}

