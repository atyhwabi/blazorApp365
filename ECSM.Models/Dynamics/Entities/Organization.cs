namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.</summary>
public sealed partial class Organization : Dictionary<string, object>
{
	/// <summary>Type: String, RequiredLevel: None, DisplayName: ACI Tenant URL., Format: Text, MaxLength: 500, SchemaName: ACIWebEndpointUrl, IntroducedVersion: 8.2.0.0.  Description: ACI Web Endpoint URL.</summary>
	[JsonIgnore]
	public string? ACIWebEndpointUrl
	{
		get
		{
			return TryGetValue("aciwebendpointurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("aciwebendpointurl") is false || Remove("aciwebendpointurl"))
			{
				Add("aciwebendpointurl", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Acknowledgement Template, Format: None, SchemaName: AcknowledgementTemplateId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the template to be used for acknowledgement when a user unsubscribes.</summary>
	[JsonIgnore]
	public string? AcknowledgementTemplateIdFormattedValue
	{
		get
		{
			return TryGetValue("_acknowledgementtemplateid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Acknowledgement Template, Format: None, SchemaName: AcknowledgementTemplateId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the template to be used for acknowledgement when a user unsubscribes.</summary>
	[JsonIgnore]
	public Guid? AcknowledgementTemplateId
	{
		get
		{
			return TryGetValue("_acknowledgementtemplateid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Acknowledgement Template, Format: None, SchemaName: AcknowledgementTemplateId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the template to be used for acknowledgement when a user unsubscribes.</summary>
	[JsonIgnore]
	public Guid? AcknowledgementTemplateId_template
	{
		set
		{
			if (ContainsKey("acknowledgementtemplateid_template@odata.bind") is false || Remove("acknowledgementtemplateid_template@odata.bind"))
			{
				if (value is not null)
				{
					Add("acknowledgementtemplateid_template@odata.bind", $"({value})");
				}
				else
				{
					Add("_acknowledgementtemplateid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: acknowledgementtemplateid, Format: Text, MaxLength: 100, SchemaName: AcknowledgementTemplateIdName, IntroducedVersion: 5.0.0.0.  Description: Name of the template to be used for unsubscription acknowledgement.</summary>
	[JsonIgnore]
	public string? AcknowledgementTemplateIdName
	{
		get
		{
			return TryGetValue("acknowledgementtemplateidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("acknowledgementtemplateidname") is false || Remove("acknowledgementtemplateidname"))
			{
				Add("acknowledgementtemplateidname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Rich Editing Experience for Appointment, SchemaName: ActivityTypeFilter, IntroducedVersion: 9.0.0.0.  Description: Information on whether filtering activity based on entity in app.</summary>
	[JsonIgnore]
	public string? ActivityTypeFilterFormattedValue
	{
		get
		{
			return TryGetValue("activitytypefilter@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Rich Editing Experience for Appointment, SchemaName: ActivityTypeFilter, IntroducedVersion: 9.0.0.0.  Description: Information on whether filtering activity based on entity in app.</summary>
	[JsonIgnore]
	public bool? ActivityTypeFilter
	{
		get
		{
			return TryGetValue("activitytypefilter", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("activitytypefilter") is false || Remove("activitytypefilter"))
			{
				Add("activitytypefilter", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: activitytypefilter, SchemaName: activitytypefilterName, IntroducedVersion: 9.0.0.0. </summary>
	[JsonIgnore]
	public object? activitytypefilterName
	{
		get
		{
			return TryGetValue("activitytypefiltername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Show only activities configured in the app when accessing 'New activity' button, SchemaName: ActivityTypeFilterV2, IntroducedVersion: 9.2.0.0.  Description: Whether to show only activities configured in this app or all activities in the 'New activity' button.</summary>
	[JsonIgnore]
	public string? ActivityTypeFilterV2FormattedValue
	{
		get
		{
			return TryGetValue("activitytypefilterv2@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Show only activities configured in the app when accessing 'New activity' button, SchemaName: ActivityTypeFilterV2, IntroducedVersion: 9.2.0.0.  Description: Whether to show only activities configured in this app or all activities in the 'New activity' button.</summary>
	[JsonIgnore]
	public bool? ActivityTypeFilterV2
	{
		get
		{
			return TryGetValue("activitytypefilterv2", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("activitytypefilterv2") is false || Remove("activitytypefilterv2"))
			{
				Add("activitytypefilterv2", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: activitytypefilterv2, SchemaName: activitytypefilterv2Name, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? activitytypefilterv2Name
	{
		get
		{
			return TryGetValue("activitytypefilterv2name", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Advanced column editor enabled, SchemaName: AdvancedColumnEditorEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the display column options on a view in model-driven apps is enabled</summary>
	[JsonIgnore]
	public string? AdvancedColumnEditorEnabledFormattedValue
	{
		get
		{
			return TryGetValue("advancedcolumneditorenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Advanced column editor enabled, SchemaName: AdvancedColumnEditorEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the display column options on a view in model-driven apps is enabled</summary>
	[JsonIgnore]
	public bool? AdvancedColumnEditorEnabled
	{
		get
		{
			return TryGetValue("advancedcolumneditorenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("advancedcolumneditorenabled") is false || Remove("advancedcolumneditorenabled"))
			{
				Add("advancedcolumneditorenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: advancedcolumneditorenabled, SchemaName: advancedcolumneditorenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? advancedcolumneditorenabledName
	{
		get
		{
			return TryGetValue("advancedcolumneditorenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Advanced column filtering enabled, SchemaName: AdvancedColumnFilteringEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the advanced column filtering in a view in model-driven apps is enabled</summary>
	[JsonIgnore]
	public string? AdvancedColumnFilteringEnabledFormattedValue
	{
		get
		{
			return TryGetValue("advancedcolumnfilteringenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Advanced column filtering enabled, SchemaName: AdvancedColumnFilteringEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the advanced column filtering in a view in model-driven apps is enabled</summary>
	[JsonIgnore]
	public bool? AdvancedColumnFilteringEnabled
	{
		get
		{
			return TryGetValue("advancedcolumnfilteringenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("advancedcolumnfilteringenabled") is false || Remove("advancedcolumnfilteringenabled"))
			{
				Add("advancedcolumnfilteringenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: advancedcolumnfilteringenabled, SchemaName: advancedcolumnfilteringenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? advancedcolumnfilteringenabledName
	{
		get
		{
			return TryGetValue("advancedcolumnfilteringenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Advanced filtering enabled, SchemaName: AdvancedFilteringEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the advanced filtering on all tables in a model-driven app is enabled</summary>
	[JsonIgnore]
	public string? AdvancedFilteringEnabledFormattedValue
	{
		get
		{
			return TryGetValue("advancedfilteringenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Advanced filtering enabled, SchemaName: AdvancedFilteringEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the advanced filtering on all tables in a model-driven app is enabled</summary>
	[JsonIgnore]
	public bool? AdvancedFilteringEnabled
	{
		get
		{
			return TryGetValue("advancedfilteringenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("advancedfilteringenabled") is false || Remove("advancedfilteringenabled"))
			{
				Add("advancedfilteringenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: advancedfilteringenabled, SchemaName: advancedfilteringenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? advancedfilteringenabledName
	{
		get
		{
			return TryGetValue("advancedfilteringenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Advanced lookup enabled, SchemaName: AdvancedLookupEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the Advanced Lookup feature is enabled for lookup controls</summary>
	[JsonIgnore]
	public string? AdvancedLookupEnabledFormattedValue
	{
		get
		{
			return TryGetValue("advancedlookupenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Advanced lookup enabled, SchemaName: AdvancedLookupEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the Advanced Lookup feature is enabled for lookup controls</summary>
	[JsonIgnore]
	public bool? AdvancedLookupEnabled
	{
		get
		{
			return TryGetValue("advancedlookupenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("advancedlookupenabled") is false || Remove("advancedlookupenabled"))
			{
				Add("advancedlookupenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: advancedlookupenabled, SchemaName: advancedlookupenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? advancedlookupenabledName
	{
		get
		{
			return TryGetValue("advancedlookupenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Enable Advanced Lookup In Edit Filter, Format: None, MinValue: 0, MaxValue: 100, SchemaName: AdvancedLookupInEditFilter, IntroducedVersion: 9.1.0.0.  Description: Enables advanced lookup in grid edit filter panel</summary>
	[JsonIgnore]
	public int? AdvancedLookupInEditFilter
	{
		get
		{
			return TryGetValue("advancedlookupineditfilter", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("advancedlookupineditfilter") is false || Remove("advancedlookupineditfilter"))
			{
				Add("advancedlookupineditfilter", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Address Book Synchronization, SchemaName: AllowAddressBookSyncs, IntroducedVersion: 5.0.0.0.  Description: Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.</summary>
	[JsonIgnore]
	public string? AllowAddressBookSyncsFormattedValue
	{
		get
		{
			return TryGetValue("allowaddressbooksyncs@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Address Book Synchronization, SchemaName: AllowAddressBookSyncs, IntroducedVersion: 5.0.0.0.  Description: Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.</summary>
	[JsonIgnore]
	public bool? AllowAddressBookSyncs
	{
		get
		{
			return TryGetValue("allowaddressbooksyncs", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowaddressbooksyncs") is false || Remove("allowaddressbooksyncs"))
			{
				Add("allowaddressbooksyncs", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow All Application Users Access., SchemaName: AllowApplicationUserAccess, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether all application users are allowed to access the environment</summary>
	[JsonIgnore]
	public string? AllowApplicationUserAccessFormattedValue
	{
		get
		{
			return TryGetValue("allowapplicationuseraccess@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow All Application Users Access., SchemaName: AllowApplicationUserAccess, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether all application users are allowed to access the environment</summary>
	[JsonIgnore]
	public bool? AllowApplicationUserAccess
	{
		get
		{
			return TryGetValue("allowapplicationuseraccess", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowapplicationuseraccess") is false || Remove("allowapplicationuseraccess"))
			{
				Add("allowapplicationuseraccess", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allowapplicationuseraccess, SchemaName: allowapplicationuseraccessName, IntroducedVersion: 1.0.0.12. </summary>
	[JsonIgnore]
	public object? allowapplicationuseraccessName
	{
		get
		{
			return TryGetValue("allowapplicationuseraccessname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Allow Automatic Response Creation, SchemaName: AllowAutoResponseCreation, IntroducedVersion: 5.0.0.0.  Description: Indicates whether automatic response creation is allowed.</summary>
	[JsonIgnore]
	public string? AllowAutoResponseCreationFormattedValue
	{
		get
		{
			return TryGetValue("allowautoresponsecreation@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Allow Automatic Response Creation, SchemaName: AllowAutoResponseCreation, IntroducedVersion: 5.0.0.0.  Description: Indicates whether automatic response creation is allowed.</summary>
	[JsonIgnore]
	public bool? AllowAutoResponseCreation
	{
		get
		{
			return TryGetValue("allowautoresponsecreation", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowautoresponsecreation") is false || Remove("allowautoresponsecreation"))
			{
				Add("allowautoresponsecreation", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Allow Automatic Unsubscribe, SchemaName: AllowAutoUnsubscribe, IntroducedVersion: 5.0.0.0.  Description: Indicates whether automatic unsubscribe is allowed.</summary>
	[JsonIgnore]
	public string? AllowAutoUnsubscribeFormattedValue
	{
		get
		{
			return TryGetValue("allowautounsubscribe@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Allow Automatic Unsubscribe, SchemaName: AllowAutoUnsubscribe, IntroducedVersion: 5.0.0.0.  Description: Indicates whether automatic unsubscribe is allowed.</summary>
	[JsonIgnore]
	public bool? AllowAutoUnsubscribe
	{
		get
		{
			return TryGetValue("allowautounsubscribe", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowautounsubscribe") is false || Remove("allowautounsubscribe"))
			{
				Add("allowautounsubscribe", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Allow Automatic Unsubscribe Acknowledgement, SchemaName: AllowAutoUnsubscribeAcknowledgement, IntroducedVersion: 5.0.0.0.  Description: Indicates whether automatic unsubscribe acknowledgement email is allowed to send.</summary>
	[JsonIgnore]
	public string? AllowAutoUnsubscribeAcknowledgementFormattedValue
	{
		get
		{
			return TryGetValue("allowautounsubscribeacknowledgement@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Allow Automatic Unsubscribe Acknowledgement, SchemaName: AllowAutoUnsubscribeAcknowledgement, IntroducedVersion: 5.0.0.0.  Description: Indicates whether automatic unsubscribe acknowledgement email is allowed to send.</summary>
	[JsonIgnore]
	public bool? AllowAutoUnsubscribeAcknowledgement
	{
		get
		{
			return TryGetValue("allowautounsubscribeacknowledgement", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowautounsubscribeacknowledgement") is false || Remove("allowautounsubscribeacknowledgement"))
			{
				Add("allowautounsubscribeacknowledgement", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Outlook Client Message Bar Advertisement, SchemaName: AllowClientMessageBarAd, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Outlook Client message bar advertisement is allowed.</summary>
	[JsonIgnore]
	public string? AllowClientMessageBarAdFormattedValue
	{
		get
		{
			return TryGetValue("allowclientmessagebarad@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Outlook Client Message Bar Advertisement, SchemaName: AllowClientMessageBarAd, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Outlook Client message bar advertisement is allowed.</summary>
	[JsonIgnore]
	public bool? AllowClientMessageBarAd
	{
		get
		{
			return TryGetValue("allowclientmessagebarad", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowclientmessagebarad") is false || Remove("allowclientmessagebarad"))
			{
				Add("allowclientmessagebarad", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable connectors on power fx actions., SchemaName: AllowConnectorsOnPowerFXActions, IntroducedVersion: 9.2.0.0.  Description: Information on whether connectors on power fx actions is enabled.</summary>
	[JsonIgnore]
	public string? AllowConnectorsOnPowerFXActionsFormattedValue
	{
		get
		{
			return TryGetValue("allowconnectorsonpowerfxactions@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable connectors on power fx actions., SchemaName: AllowConnectorsOnPowerFXActions, IntroducedVersion: 9.2.0.0.  Description: Information on whether connectors on power fx actions is enabled.</summary>
	[JsonIgnore]
	public bool? AllowConnectorsOnPowerFXActions
	{
		get
		{
			return TryGetValue("allowconnectorsonpowerfxactions", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowconnectorsonpowerfxactions") is false || Remove("allowconnectorsonpowerfxactions"))
			{
				Add("allowconnectorsonpowerfxactions", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allowconnectorsonpowerfxactions, SchemaName: allowconnectorsonpowerfxactionsName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? allowconnectorsonpowerfxactionsName
	{
		get
		{
			return TryGetValue("allowconnectorsonpowerfxactionsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of Applications that are in allow list for the accessing DV resources., Format: Text, MaxLength: 20000, SchemaName: AllowedApplicationsForDVAccess, IntroducedVersion: 1.0.0.12.  Description: Information that specifies the Applications that are in allow list for the accessing DV resources.</summary>
	[JsonIgnore]
	public string? AllowedApplicationsForDVAccess
	{
		get
		{
			return TryGetValue("allowedapplicationsfordvaccess", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowedapplicationsfordvaccess") is false || Remove("allowedapplicationsfordvaccess"))
			{
				Add("allowedapplicationsfordvaccess", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of IP Ranges to be allowed by the firewall rule, Format: Text, MaxLength: 4000, SchemaName: AllowedIpRangeForFirewall, IntroducedVersion: 1.0.0.12.  Description: Information that specifies the range of IP addresses that are in allow list for the firewall.</summary>
	[JsonIgnore]
	public string? AllowedIpRangeForFirewall
	{
		get
		{
			return TryGetValue("allowediprangeforfirewall", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowediprangeforfirewall") is false || Remove("allowediprangeforfirewall"))
			{
				Add("allowediprangeforfirewall", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of IP Ranges to be allowed for generating the SAS URIs., Format: Text, MaxLength: 4000, SchemaName: AllowedIpRangeForStorageAccessSignatures, IntroducedVersion: 1.0.0.5.  Description: Information that specifies the range of IP addresses that are in allowed list for generating the SAS URIs.</summary>
	[JsonIgnore]
	public string? AllowedIpRangeForStorageAccessSignatures
	{
		get
		{
			return TryGetValue("allowediprangeforstorageaccesssignatures", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowediprangeforstorageaccesssignatures") is false || Remove("allowediprangeforstorageaccesssignatures"))
			{
				Add("allowediprangeforstorageaccesssignatures", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of allowed mime types., Format: Text, MaxLength: 1073741823, SchemaName: AllowedMimeTypes, IntroducedVersion: 9.1.0.0.  Description: Allow upload or download of certain mime types.</summary>
	[JsonIgnore]
	public string? AllowedMimeTypes
	{
		get
		{
			return TryGetValue("allowedmimetypes", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowedmimetypes") is false || Remove("allowedmimetypes"))
			{
				Add("allowedmimetypes", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of Service Tags to be allowed by the firewall rule, Format: Text, MaxLength: 4000, SchemaName: AllowedServiceTagsForFirewall, IntroducedVersion: 1.0.0.12.  Description: Information that specifies the List of Service Tags that should be allowed by the firewall.</summary>
	[JsonIgnore]
	public string? AllowedServiceTagsForFirewall
	{
		get
		{
			return TryGetValue("allowedservicetagsforfirewall", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowedservicetagsforfirewall") is false || Remove("allowedservicetagsforfirewall"))
			{
				Add("allowedservicetagsforfirewall", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Entity Level Auditing, SchemaName: AllowEntityOnlyAudit, IntroducedVersion: 5.0.0.0.  Description: Indicates whether auditing of changes to entity is allowed when no attributes have changed.</summary>
	[JsonIgnore]
	public string? AllowEntityOnlyAuditFormattedValue
	{
		get
		{
			return TryGetValue("allowentityonlyaudit@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Entity Level Auditing, SchemaName: AllowEntityOnlyAudit, IntroducedVersion: 5.0.0.0.  Description: Indicates whether auditing of changes to entity is allowed when no attributes have changed.</summary>
	[JsonIgnore]
	public bool? AllowEntityOnlyAudit
	{
		get
		{
			return TryGetValue("allowentityonlyaudit", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowentityonlyaudit") is false || Remove("allowentityonlyaudit"))
			{
				Add("allowentityonlyaudit", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Leading Wildcards In Grid Search, SchemaName: AllowLeadingWildcardsInGridSearch, IntroducedVersion: 9.1.0.0.  Description: Enables ends-with searches in grids with the use of a leading wildcard on all tables in the environment</summary>
	[JsonIgnore]
	public string? AllowLeadingWildcardsInGridSearchFormattedValue
	{
		get
		{
			return TryGetValue("allowleadingwildcardsingridsearch@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Leading Wildcards In Grid Search, SchemaName: AllowLeadingWildcardsInGridSearch, IntroducedVersion: 9.1.0.0.  Description: Enables ends-with searches in grids with the use of a leading wildcard on all tables in the environment</summary>
	[JsonIgnore]
	public bool? AllowLeadingWildcardsInGridSearch
	{
		get
		{
			return TryGetValue("allowleadingwildcardsingridsearch", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowleadingwildcardsingridsearch") is false || Remove("allowleadingwildcardsingridsearch"))
			{
				Add("allowleadingwildcardsingridsearch", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allowleadingwildcardsingridsearch, SchemaName: allowleadingwildcardsingridsearchName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? allowleadingwildcardsingridsearchName
	{
		get
		{
			return TryGetValue("allowleadingwildcardsingridsearchname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Allow Leading Wildcards In Quick Find, Format: None, MinValue: 0, MaxValue: 100, SchemaName: AllowLeadingWildcardsInQuickFind, IntroducedVersion: 9.1.0.0.  Description: Enables ends-with searches in grids with the use of a leading wildcard on all tables in the environment</summary>
	[JsonIgnore]
	public int? AllowLeadingWildcardsInQuickFind
	{
		get
		{
			return TryGetValue("allowleadingwildcardsinquickfind", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowleadingwildcardsinquickfind") is false || Remove("allowleadingwildcardsinquickfind"))
			{
				Add("allowleadingwildcardsinquickfind", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable access to legacy web client UI, SchemaName: AllowLegacyClientExperience, IntroducedVersion: 9.0.0.0.  Description: Enable access to legacy web client UI</summary>
	[JsonIgnore]
	public string? AllowLegacyClientExperienceFormattedValue
	{
		get
		{
			return TryGetValue("allowlegacyclientexperience@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable access to legacy web client UI, SchemaName: AllowLegacyClientExperience, IntroducedVersion: 9.0.0.0.  Description: Enable access to legacy web client UI</summary>
	[JsonIgnore]
	public bool? AllowLegacyClientExperience
	{
		get
		{
			return TryGetValue("allowlegacyclientexperience", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowlegacyclientexperience") is false || Remove("allowlegacyclientexperience"))
			{
				Add("allowlegacyclientexperience", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable embedding of certain legacy dialogs in Unified Interface browser client, SchemaName: AllowLegacyDialogsEmbedding, IntroducedVersion: 9.0.0.0.  Description: Enable embedding of certain legacy dialogs in Unified Interface browser client</summary>
	[JsonIgnore]
	public string? AllowLegacyDialogsEmbeddingFormattedValue
	{
		get
		{
			return TryGetValue("allowlegacydialogsembedding@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable embedding of certain legacy dialogs in Unified Interface browser client, SchemaName: AllowLegacyDialogsEmbedding, IntroducedVersion: 9.0.0.0.  Description: Enable embedding of certain legacy dialogs in Unified Interface browser client</summary>
	[JsonIgnore]
	public bool? AllowLegacyDialogsEmbedding
	{
		get
		{
			return TryGetValue("allowlegacydialogsembedding", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowlegacydialogsembedding") is false || Remove("allowlegacydialogsembedding"))
			{
				Add("allowlegacydialogsembedding", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Marketing Email Execution, SchemaName: AllowMarketingEmailExecution, IntroducedVersion: 5.0.0.0.  Description: Indicates whether marketing emails execution is allowed.</summary>
	[JsonIgnore]
	public string? AllowMarketingEmailExecutionFormattedValue
	{
		get
		{
			return TryGetValue("allowmarketingemailexecution@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Marketing Email Execution, SchemaName: AllowMarketingEmailExecution, IntroducedVersion: 5.0.0.0.  Description: Indicates whether marketing emails execution is allowed.</summary>
	[JsonIgnore]
	public bool? AllowMarketingEmailExecution
	{
		get
		{
			return TryGetValue("allowmarketingemailexecution", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowmarketingemailexecution") is false || Remove("allowmarketingemailexecution"))
			{
				Add("allowmarketingemailexecution", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Microsoft Trusted Service Tags, SchemaName: AllowMicrosoftTrustedServiceTags, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether Microsoft Trusted Service Tags are allowed</summary>
	[JsonIgnore]
	public string? AllowMicrosoftTrustedServiceTagsFormattedValue
	{
		get
		{
			return TryGetValue("allowmicrosofttrustedservicetags@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Microsoft Trusted Service Tags, SchemaName: AllowMicrosoftTrustedServiceTags, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether Microsoft Trusted Service Tags are allowed</summary>
	[JsonIgnore]
	public bool? AllowMicrosoftTrustedServiceTags
	{
		get
		{
			return TryGetValue("allowmicrosofttrustedservicetags", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowmicrosofttrustedservicetags") is false || Remove("allowmicrosofttrustedservicetags"))
			{
				Add("allowmicrosofttrustedservicetags", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allowmicrosofttrustedservicetags, SchemaName: allowmicrosofttrustedservicetagsName, IntroducedVersion: 1.0.0.12. </summary>
	[JsonIgnore]
	public object? allowmicrosofttrustedservicetagsName
	{
		get
		{
			return TryGetValue("allowmicrosofttrustedservicetagsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Offline Scheduled Synchronization, SchemaName: AllowOfflineScheduledSyncs, IntroducedVersion: 5.0.0.0.  Description: Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.</summary>
	[JsonIgnore]
	public string? AllowOfflineScheduledSyncsFormattedValue
	{
		get
		{
			return TryGetValue("allowofflinescheduledsyncs@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Offline Scheduled Synchronization, SchemaName: AllowOfflineScheduledSyncs, IntroducedVersion: 5.0.0.0.  Description: Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.</summary>
	[JsonIgnore]
	public bool? AllowOfflineScheduledSyncs
	{
		get
		{
			return TryGetValue("allowofflinescheduledsyncs", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowofflinescheduledsyncs") is false || Remove("allowofflinescheduledsyncs"))
			{
				Add("allowofflinescheduledsyncs", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Scheduled Synchronization, SchemaName: AllowOutlookScheduledSyncs, IntroducedVersion: 5.0.0.0.  Description: Indicates whether scheduled synchronizations to Outlook are allowed.</summary>
	[JsonIgnore]
	public string? AllowOutlookScheduledSyncsFormattedValue
	{
		get
		{
			return TryGetValue("allowoutlookscheduledsyncs@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Scheduled Synchronization, SchemaName: AllowOutlookScheduledSyncs, IntroducedVersion: 5.0.0.0.  Description: Indicates whether scheduled synchronizations to Outlook are allowed.</summary>
	[JsonIgnore]
	public bool? AllowOutlookScheduledSyncs
	{
		get
		{
			return TryGetValue("allowoutlookscheduledsyncs", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowoutlookscheduledsyncs") is false || Remove("allowoutlookscheduledsyncs"))
			{
				Add("allowoutlookscheduledsyncs", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Redirect Legacy Admin Settings To Modern UI, SchemaName: AllowRedirectAdminSettingsToModernUI, IntroducedVersion: 9.1.0.0.  Description: Control whether the organization Allow Redirect Legacy Admin Settings To Modern UI</summary>
	[JsonIgnore]
	public string? AllowRedirectAdminSettingsToModernUIFormattedValue
	{
		get
		{
			return TryGetValue("allowredirectadminsettingstomodernui@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Redirect Legacy Admin Settings To Modern UI, SchemaName: AllowRedirectAdminSettingsToModernUI, IntroducedVersion: 9.1.0.0.  Description: Control whether the organization Allow Redirect Legacy Admin Settings To Modern UI</summary>
	[JsonIgnore]
	public bool? AllowRedirectAdminSettingsToModernUI
	{
		get
		{
			return TryGetValue("allowredirectadminsettingstomodernui", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowredirectadminsettingstomodernui") is false || Remove("allowredirectadminsettingstomodernui"))
			{
				Add("allowredirectadminsettingstomodernui", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allowredirectadminsettingstomodernui, SchemaName: allowredirectadminsettingstomodernuiName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? allowredirectadminsettingstomodernuiName
	{
		get
		{
			return TryGetValue("allowredirectadminsettingstomodernuiname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Unresolved Address Email Send, SchemaName: AllowUnresolvedPartiesOnEmailSend, IntroducedVersion: 5.0.0.0.  Description: Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).</summary>
	[JsonIgnore]
	public string? AllowUnresolvedPartiesOnEmailSendFormattedValue
	{
		get
		{
			return TryGetValue("allowunresolvedpartiesonemailsend@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Unresolved Address Email Send, SchemaName: AllowUnresolvedPartiesOnEmailSend, IntroducedVersion: 5.0.0.0.  Description: Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).</summary>
	[JsonIgnore]
	public bool? AllowUnresolvedPartiesOnEmailSend
	{
		get
		{
			return TryGetValue("allowunresolvedpartiesonemailsend", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowunresolvedpartiesonemailsend") is false || Remove("allowunresolvedpartiesonemailsend"))
			{
				Add("allowunresolvedpartiesonemailsend", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow User Form Mode Preference, SchemaName: AllowUserFormModePreference, IntroducedVersion: 5.0.0.0.  Description: Indicates whether individuals can select their form mode preference in their personal options.</summary>
	[JsonIgnore]
	public string? AllowUserFormModePreferenceFormattedValue
	{
		get
		{
			return TryGetValue("allowuserformmodepreference@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow User Form Mode Preference, SchemaName: AllowUserFormModePreference, IntroducedVersion: 5.0.0.0.  Description: Indicates whether individuals can select their form mode preference in their personal options.</summary>
	[JsonIgnore]
	public bool? AllowUserFormModePreference
	{
		get
		{
			return TryGetValue("allowuserformmodepreference", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowuserformmodepreference") is false || Remove("allowuserformmodepreference"))
			{
				Add("allowuserformmodepreference", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow users hiding system views, SchemaName: AllowUsersHidingSystemViews, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if allow end users to hide system views in model-driven apps is enabled</summary>
	[JsonIgnore]
	public string? AllowUsersHidingSystemViewsFormattedValue
	{
		get
		{
			return TryGetValue("allowusershidingsystemviews@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow users hiding system views, SchemaName: AllowUsersHidingSystemViews, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if allow end users to hide system views in model-driven apps is enabled</summary>
	[JsonIgnore]
	public bool? AllowUsersHidingSystemViews
	{
		get
		{
			return TryGetValue("allowusershidingsystemviews", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowusershidingsystemviews") is false || Remove("allowusershidingsystemviews"))
			{
				Add("allowusershidingsystemviews", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allowusershidingsystemviews, SchemaName: allowusershidingsystemviewsName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? allowusershidingsystemviewsName
	{
		get
		{
			return TryGetValue("allowusershidingsystemviewsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow the showing tablet application notification bars in a browser., SchemaName: AllowUsersSeeAppdownloadMessage, IntroducedVersion: 6.0.0.0.  Description: Indicates whether the showing tablet application notification bars in a browser is allowed.</summary>
	[JsonIgnore]
	public string? AllowUsersSeeAppdownloadMessageFormattedValue
	{
		get
		{
			return TryGetValue("allowusersseeappdownloadmessage@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow the showing tablet application notification bars in a browser., SchemaName: AllowUsersSeeAppdownloadMessage, IntroducedVersion: 6.0.0.0.  Description: Indicates whether the showing tablet application notification bars in a browser is allowed.</summary>
	[JsonIgnore]
	public bool? AllowUsersSeeAppdownloadMessage
	{
		get
		{
			return TryGetValue("allowusersseeappdownloadmessage", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowusersseeappdownloadmessage") is false || Remove("allowusersseeappdownloadmessage"))
			{
				Add("allowusersseeappdownloadmessage", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Export to Excel, SchemaName: AllowWebExcelExport, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.</summary>
	[JsonIgnore]
	public string? AllowWebExcelExportFormattedValue
	{
		get
		{
			return TryGetValue("allowwebexcelexport@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Export to Excel, SchemaName: AllowWebExcelExport, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.</summary>
	[JsonIgnore]
	public bool? AllowWebExcelExport
	{
		get
		{
			return TryGetValue("allowwebexcelexport", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowwebexcelexport") is false || Remove("allowwebexcelexport"))
			{
				Add("allowwebexcelexport", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: AM Designator, Format: Text, MaxLength: 25, SchemaName: AMDesignator, IntroducedVersion: 5.0.0.0.  Description: AM designator to use throughout Microsoft Dynamics CRM.</summary>
	[JsonIgnore]
	public string? AMDesignator
	{
		get
		{
			return TryGetValue("amdesignator", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("amdesignator") is false || Remove("amdesignator"))
			{
				Add("amdesignator", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable App Designer Experience for this Organization, SchemaName: AppDesignerExperienceEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the appDesignerExperience is enabled for the organization.</summary>
	[JsonIgnore]
	public string? AppDesignerExperienceEnabledFormattedValue
	{
		get
		{
			return TryGetValue("appdesignerexperienceenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable App Designer Experience for this Organization, SchemaName: AppDesignerExperienceEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the appDesignerExperience is enabled for the organization.</summary>
	[JsonIgnore]
	public bool? AppDesignerExperienceEnabled
	{
		get
		{
			return TryGetValue("appdesignerexperienceenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("appdesignerexperienceenabled") is false || Remove("appdesignerexperienceenabled"))
			{
				Add("appdesignerexperienceenabled", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Application Based Access Control Mode, SchemaName: ApplicationBasedAccessControlMode, IntroducedVersion: 1.0.0.12.  Description: Application Based Access Control Mode. 0 is Disabled, 1 is audit mode , 2 is enforcement mode</summary>
	[JsonIgnore]
	public string? ApplicationBasedAccessControlModeFormattedValue
	{
		get
		{
			return TryGetValue("applicationbasedaccesscontrolmode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Application Based Access Control Mode, SchemaName: ApplicationBasedAccessControlMode, IntroducedVersion: 1.0.0.12.  Description: Application Based Access Control Mode. 0 is Disabled, 1 is audit mode , 2 is enforcement mode</summary>
	[JsonIgnore]
	public int? ApplicationBasedAccessControlMode
	{
		get
		{
			return TryGetValue("applicationbasedaccesscontrolmode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("applicationbasedaccesscontrolmode") is false || Remove("applicationbasedaccesscontrolmode"))
			{
				Add("applicationbasedaccesscontrolmode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: applicationbasedaccesscontrolmode, SchemaName: applicationbasedaccesscontrolmodeName, IntroducedVersion: 1.0.0.12. </summary>
	[JsonIgnore]
	public object? applicationbasedaccesscontrolmodeName
	{
		get
		{
			return TryGetValue("applicationbasedaccesscontrolmodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Rich Editing Experience for Appointment, SchemaName: AppointmentRichEditorExperience, IntroducedVersion: 9.0.0.0.  Description: Information on whether rich editing experience for Appointment is enabled.</summary>
	[JsonIgnore]
	public string? AppointmentRichEditorExperienceFormattedValue
	{
		get
		{
			return TryGetValue("appointmentricheditorexperience@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Rich Editing Experience for Appointment, SchemaName: AppointmentRichEditorExperience, IntroducedVersion: 9.0.0.0.  Description: Information on whether rich editing experience for Appointment is enabled.</summary>
	[JsonIgnore]
	public bool? AppointmentRichEditorExperience
	{
		get
		{
			return TryGetValue("appointmentricheditorexperience", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("appointmentricheditorexperience") is false || Remove("appointmentricheditorexperience"))
			{
				Add("appointmentricheditorexperience", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: appointmentricheditorexperience, SchemaName: appointmentricheditorexperienceName, IntroducedVersion: 9.0.0.0. </summary>
	[JsonIgnore]
	public object? appointmentricheditorexperienceName
	{
		get
		{
			return TryGetValue("appointmentricheditorexperiencename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable teams Meeting experience for appointment, SchemaName: AppointmentWithTeamsMeeting, IntroducedVersion: 9.0.0.0.  Description: Information on whether Teams meeting experience for Appointment is enabled.</summary>
	[JsonIgnore]
	public string? AppointmentWithTeamsMeetingFormattedValue
	{
		get
		{
			return TryGetValue("appointmentwithteamsmeeting@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable teams Meeting experience for appointment, SchemaName: AppointmentWithTeamsMeeting, IntroducedVersion: 9.0.0.0.  Description: Information on whether Teams meeting experience for Appointment is enabled.</summary>
	[JsonIgnore]
	public bool? AppointmentWithTeamsMeeting
	{
		get
		{
			return TryGetValue("appointmentwithteamsmeeting", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("appointmentwithteamsmeeting") is false || Remove("appointmentwithteamsmeeting"))
			{
				Add("appointmentwithteamsmeeting", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: appointmentwithteamsmeeting, SchemaName: appointmentwithteamsmeetingName, IntroducedVersion: 9.0.0.0. </summary>
	[JsonIgnore]
	public object? appointmentwithteamsmeetingName
	{
		get
		{
			return TryGetValue("appointmentwithteamsmeetingname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Teams meetings for appointments, SchemaName: AppointmentWithTeamsMeetingV2, IntroducedVersion: 9.2.0.0.  Description: Whether Teams meetings experience for appointments is enabled.</summary>
	[JsonIgnore]
	public string? AppointmentWithTeamsMeetingV2FormattedValue
	{
		get
		{
			return TryGetValue("appointmentwithteamsmeetingv2@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Teams meetings for appointments, SchemaName: AppointmentWithTeamsMeetingV2, IntroducedVersion: 9.2.0.0.  Description: Whether Teams meetings experience for appointments is enabled.</summary>
	[JsonIgnore]
	public bool? AppointmentWithTeamsMeetingV2
	{
		get
		{
			return TryGetValue("appointmentwithteamsmeetingv2", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("appointmentwithteamsmeetingv2") is false || Remove("appointmentwithteamsmeetingv2"))
			{
				Add("appointmentwithteamsmeetingv2", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: appointmentwithteamsmeetingv2, SchemaName: appointmentwithteamsmeetingv2Name, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? appointmentwithteamsmeetingv2Name
	{
		get
		{
			return TryGetValue("appointmentwithteamsmeetingv2name", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Address Suggestions has been enabled for the organization, SchemaName: AreSalesAddressSuggestionsEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Address Suggestions has been enabled for the organization</summary>
	[JsonIgnore]
	public string? AreSalesAddressSuggestionsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("aresalesaddresssuggestionsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Address Suggestions has been enabled for the organization, SchemaName: AreSalesAddressSuggestionsEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Address Suggestions has been enabled for the organization</summary>
	[JsonIgnore]
	public bool? AreSalesAddressSuggestionsEnabled
	{
		get
		{
			return TryGetValue("aresalesaddresssuggestionsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("aresalesaddresssuggestionsenabled") is false || Remove("aresalesaddresssuggestionsenabled"))
			{
				Add("aresalesaddresssuggestionsenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: aresalesaddresssuggestionsenabled, SchemaName: aresalesaddresssuggestionsenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? aresalesaddresssuggestionsenabledName
	{
		get
		{
			return TryGetValue("aresalesaddresssuggestionsenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Audit Retention Period Settings, Format: None, MinValue: 30, MaxValue: 2147483647, SchemaName: AuditRetentionPeriod, IntroducedVersion: 9.1.0.0.  Description: Audit Retention Period settings stored in Organization Database.</summary>
	[JsonIgnore]
	public int? AuditRetentionPeriod
	{
		get
		{
			return TryGetValue("auditretentionperiod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("auditretentionperiod") is false || Remove("auditretentionperiod"))
			{
				Add("auditretentionperiod", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Audit Retention Period Settings, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: AuditRetentionPeriodV2, IntroducedVersion: 9.1.0.0.  Description: Audit Retention Period settings stored in Organization Database.</summary>
	[JsonIgnore]
	public int? AuditRetentionPeriodV2
	{
		get
		{
			return TryGetValue("auditretentionperiodv2", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("auditretentionperiodv2") is false || Remove("auditretentionperiodv2"))
			{
				Add("auditretentionperiodv2", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Auto Apply Default Entitlement on Case Create, SchemaName: AutoApplyDefaultonCaseCreate, IntroducedVersion: 7.1.0.0.  Description: Select whether to auto apply the default customer entitlement on case creation.</summary>
	[JsonIgnore]
	public string? AutoApplyDefaultonCaseCreateFormattedValue
	{
		get
		{
			return TryGetValue("autoapplydefaultoncasecreate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Auto Apply Default Entitlement on Case Create, SchemaName: AutoApplyDefaultonCaseCreate, IntroducedVersion: 7.1.0.0.  Description: Select whether to auto apply the default customer entitlement on case creation.</summary>
	[JsonIgnore]
	public bool? AutoApplyDefaultonCaseCreate
	{
		get
		{
			return TryGetValue("autoapplydefaultoncasecreate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("autoapplydefaultoncasecreate") is false || Remove("autoapplydefaultoncasecreate"))
			{
				Add("autoapplydefaultoncasecreate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: autoapplydefaultoncasecreate, SchemaName: AutoApplyDefaultonCaseCreateName, IntroducedVersion: 7.1.0.0. </summary>
	[JsonIgnore]
	public object? AutoApplyDefaultonCaseCreateName
	{
		get
		{
			return TryGetValue("autoapplydefaultoncasecreatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Auto Apply Default Entitlement on Case Update, SchemaName: AutoApplyDefaultonCaseUpdate, IntroducedVersion: 7.1.0.0.  Description: Select whether to auto apply the default customer entitlement on case update.</summary>
	[JsonIgnore]
	public string? AutoApplyDefaultonCaseUpdateFormattedValue
	{
		get
		{
			return TryGetValue("autoapplydefaultoncaseupdate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Auto Apply Default Entitlement on Case Update, SchemaName: AutoApplyDefaultonCaseUpdate, IntroducedVersion: 7.1.0.0.  Description: Select whether to auto apply the default customer entitlement on case update.</summary>
	[JsonIgnore]
	public bool? AutoApplyDefaultonCaseUpdate
	{
		get
		{
			return TryGetValue("autoapplydefaultoncaseupdate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("autoapplydefaultoncaseupdate") is false || Remove("autoapplydefaultoncaseupdate"))
			{
				Add("autoapplydefaultoncaseupdate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: autoapplydefaultoncaseupdate, SchemaName: AutoApplyDefaultonCaseUpdateName, IntroducedVersion: 7.1.0.0. </summary>
	[JsonIgnore]
	public object? AutoApplyDefaultonCaseUpdateName
	{
		get
		{
			return TryGetValue("autoapplydefaultoncaseupdatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Auto-apply SLA After Manually Over-riding, SchemaName: AutoApplySLA, IntroducedVersion: 8.0.0.0.  Description: Indicates whether to Auto-apply SLA on case record update after SLA was manually applied.</summary>
	[JsonIgnore]
	public string? AutoApplySLAFormattedValue
	{
		get
		{
			return TryGetValue("autoapplysla@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Auto-apply SLA After Manually Over-riding, SchemaName: AutoApplySLA, IntroducedVersion: 8.0.0.0.  Description: Indicates whether to Auto-apply SLA on case record update after SLA was manually applied.</summary>
	[JsonIgnore]
	public bool? AutoApplySLA
	{
		get
		{
			return TryGetValue("autoapplysla", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("autoapplysla") is false || Remove("autoapplysla"))
			{
				Add("autoapplysla", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: For internal use only., Format: Text, MaxLength: 100, SchemaName: AzureSchedulerJobCollectionName, IntroducedVersion: 8.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? AzureSchedulerJobCollectionName
	{
		get
		{
			return TryGetValue("azureschedulerjobcollectionname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("azureschedulerjobcollectionname") is false || Remove("azureschedulerjobcollectionname"))
			{
				Add("azureschedulerjobcollectionname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: BaseCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the base currency of the organization.</summary>
	[JsonIgnore]
	public string? BaseCurrencyIdFormattedValue
	{
		get
		{
			return TryGetValue("_basecurrencyid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: BaseCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the base currency of the organization.</summary>
	[JsonIgnore]
	public Guid? BaseCurrencyId
	{
		get
		{
			return TryGetValue("_basecurrencyid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: BaseCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the base currency of the organization.</summary>
	[JsonIgnore]
	public Guid? BaseCurrencyId_transactioncurrency
	{
		set
		{
			if (ContainsKey("basecurrencyid_transactioncurrency@odata.bind") is false || Remove("basecurrencyid_transactioncurrency@odata.bind"))
			{
				if (value is not null)
				{
					Add("basecurrencyid_transactioncurrency@odata.bind", $"({value})");
				}
				else
				{
					Add("_basecurrencyid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: basecurrencyid, Format: Text, MaxLength: 100, SchemaName: BaseCurrencyIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BaseCurrencyIdName
	{
		get
		{
			return TryGetValue("basecurrencyidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("basecurrencyidname") is false || Remove("basecurrencyidname"))
			{
				Add("basecurrencyidname", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Base Currency Precision, Format: None, MinValue: 0, MaxValue: 10, SchemaName: BaseCurrencyPrecision, IntroducedVersion: 5.0.0.0.  Description: Number of decimal places that can be used for the base currency.</summary>
	[JsonIgnore]
	public int? BaseCurrencyPrecision
	{
		get
		{
			return TryGetValue("basecurrencyprecision", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("basecurrencyprecision") is false || Remove("basecurrencyprecision"))
			{
				Add("basecurrencyprecision", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Base Currency Symbol, Format: Text, MaxLength: 5, SchemaName: BaseCurrencySymbol, IntroducedVersion: 5.0.0.0.  Description: Symbol used for the base currency.</summary>
	[JsonIgnore]
	public string? BaseCurrencySymbol
	{
		get
		{
			return TryGetValue("basecurrencysymbol", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("basecurrencysymbol") is false || Remove("basecurrencysymbol"))
			{
				Add("basecurrencysymbol", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Base ISO Currency Code, Format: Text, MaxLength: 5, SchemaName: BaseISOCurrencyCode, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BaseISOCurrencyCode
	{
		get
		{
			return TryGetValue("baseisocurrencycode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("baseisocurrencycode") is false || Remove("baseisocurrencycode"))
			{
				Add("baseisocurrencycode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bing Maps API Key, Format: Text, MaxLength: 1024, SchemaName: BingMapsApiKey, IntroducedVersion: 6.0.0.0.  Description: Api Key to be used in requests to Bing Maps services.</summary>
	[JsonIgnore]
	public string? BingMapsApiKey
	{
		get
		{
			return TryGetValue("bingmapsapikey", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("bingmapsapikey") is false || Remove("bingmapsapikey"))
			{
				Add("bingmapsapikey", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of Applications that are in block list for the accessing DV resources., Format: Text, MaxLength: 4000, SchemaName: BlockedApplicationsForDVAccess, IntroducedVersion: 1.0.0.12.  Description: Information that specifies the Applications that are in block list for the accessing DV resources.</summary>
	[JsonIgnore]
	public string? BlockedApplicationsForDVAccess
	{
		get
		{
			return TryGetValue("blockedapplicationsfordvaccess", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("blockedapplicationsfordvaccess") is false || Remove("blockedapplicationsfordvaccess"))
			{
				Add("blockedapplicationsfordvaccess", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Block Attachments, Format: Text, MaxLength: 1073741823, SchemaName: BlockedAttachments, IntroducedVersion: 5.0.0.0.  Description: Prevent upload or download of certain attachment types that are considered dangerous.</summary>
	[JsonIgnore]
	public string? BlockedAttachments
	{
		get
		{
			return TryGetValue("blockedattachments", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("blockedattachments") is false || Remove("blockedattachments"))
			{
				Add("blockedattachments", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of blocked mime types., Format: Text, MaxLength: 1073741823, SchemaName: BlockedMimeTypes, IntroducedVersion: 9.1.0.0.  Description: Prevent upload or download of certain mime types that are considered dangerous.</summary>
	[JsonIgnore]
	public string? BlockedMimeTypes
	{
		get
		{
			return TryGetValue("blockedmimetypes", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("blockedmimetypes") is false || Remove("blockedmimetypes"))
			{
				Add("blockedmimetypes", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Display cards in expanded state for Interactive Dashboard, SchemaName: BoundDashboardDefaultCardExpanded, IntroducedVersion: 9.0.0.0.  Description: Display cards in expanded state for interactive dashboard</summary>
	[JsonIgnore]
	public string? BoundDashboardDefaultCardExpandedFormattedValue
	{
		get
		{
			return TryGetValue("bounddashboarddefaultcardexpanded@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Display cards in expanded state for Interactive Dashboard, SchemaName: BoundDashboardDefaultCardExpanded, IntroducedVersion: 9.0.0.0.  Description: Display cards in expanded state for interactive dashboard</summary>
	[JsonIgnore]
	public bool? BoundDashboardDefaultCardExpanded
	{
		get
		{
			return TryGetValue("bounddashboarddefaultcardexpanded", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("bounddashboarddefaultcardexpanded") is false || Remove("bounddashboarddefaultcardexpanded"))
			{
				Add("bounddashboarddefaultcardexpanded", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Bulk Operation Prefix, Format: Text, MaxLength: 20, SchemaName: BulkOperationPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix used for bulk operation numbering.</summary>
	[JsonIgnore]
	public string? BulkOperationPrefix
	{
		get
		{
			return TryGetValue("bulkoperationprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("bulkoperationprefix") is false || Remove("bulkoperationprefix"))
			{
				Add("bulkoperationprefix", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Enable New BusinessCardOptions, Format: Text, MaxLength: 1000, SchemaName: BusinessCardOptions, IntroducedVersion: 9.1.0.0.  Description: BusinessCardOptions</summary>
	[JsonIgnore]
	public string? BusinessCardOptions
	{
		get
		{
			return TryGetValue("businesscardoptions", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("businesscardoptions") is false || Remove("businesscardoptions"))
			{
				Add("businesscardoptions", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Business Closure Calendar, SchemaName: BusinessClosureCalendarId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business closure calendar of organization.</summary>
	[JsonIgnore]
	public Guid? BusinessClosureCalendarId
	{
		get
		{
			return TryGetValue("businessclosurecalendarid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("businessclosurecalendarid") is false || Remove("businessclosurecalendarid"))
			{
				Add("businessclosurecalendarid", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Calendar Type, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CalendarType, IntroducedVersion: 5.0.0.0.  Description: Calendar type for the system. Set to Gregorian US by default.</summary>
	[JsonIgnore]
	public int? CalendarType
	{
		get
		{
			return TryGetValue("calendartype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("calendartype") is false || Remove("calendartype"))
			{
				Add("calendartype", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Campaign Prefix, Format: Text, MaxLength: 20, SchemaName: CampaignPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix used for campaign numbering.</summary>
	[JsonIgnore]
	public string? CampaignPrefix
	{
		get
		{
			return TryGetValue("campaignprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("campaignprefix") is false || Remove("campaignprefix"))
			{
				Add("campaignprefix", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Can disable Oct 2020 Search, SchemaName: CanOptOutNewSearchExperience, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the organization can opt out of the new Relevance search experience (released in Oct 2020)</summary>
	[JsonIgnore]
	public string? CanOptOutNewSearchExperienceFormattedValue
	{
		get
		{
			return TryGetValue("canoptoutnewsearchexperience@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Can disable Oct 2020 Search, SchemaName: CanOptOutNewSearchExperience, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the organization can opt out of the new Relevance search experience (released in Oct 2020)</summary>
	[JsonIgnore]
	public bool? CanOptOutNewSearchExperience
	{
		get
		{
			return TryGetValue("canoptoutnewsearchexperience", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("canoptoutnewsearchexperience") is false || Remove("canoptoutnewsearchexperience"))
			{
				Add("canoptoutnewsearchexperience", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: canoptoutnewsearchexperience, SchemaName: canoptoutnewsearchexperienceName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? canoptoutnewsearchexperienceName
	{
		get
		{
			return TryGetValue("canoptoutnewsearchexperiencename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Cascade Status Update, SchemaName: CascadeStatusUpdate, IntroducedVersion: 6.1.0.0.  Description: Flag to cascade Update on incident.</summary>
	[JsonIgnore]
	public string? CascadeStatusUpdateFormattedValue
	{
		get
		{
			return TryGetValue("cascadestatusupdate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Cascade Status Update, SchemaName: CascadeStatusUpdate, IntroducedVersion: 6.1.0.0.  Description: Flag to cascade Update on incident.</summary>
	[JsonIgnore]
	public bool? CascadeStatusUpdate
	{
		get
		{
			return TryGetValue("cascadestatusupdate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("cascadestatusupdate") is false || Remove("cascadestatusupdate"))
			{
				Add("cascadestatusupdate", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Case Prefix, Format: Text, MaxLength: 20, SchemaName: CasePrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix to use for all cases throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? CasePrefix
	{
		get
		{
			return TryGetValue("caseprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("caseprefix") is false || Remove("caseprefix"))
			{
				Add("caseprefix", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Category Prefix, Format: Text, MaxLength: 20, SchemaName: CategoryPrefix, IntroducedVersion: 8.1.0.0.  Description: Type the prefix to use for all categories in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? CategoryPrefix
	{
		get
		{
			return TryGetValue("categoryprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("categoryprefix") is false || Remove("categoryprefix"))
			{
				Add("categoryprefix", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Client Feature Set, Format: Text, MaxLength: 1073741823, SchemaName: ClientFeatureSet, IntroducedVersion: 9.0.0.0.  Description: Client Features to be enabled as an XML BLOB.</summary>
	[JsonIgnore]
	public string? ClientFeatureSet
	{
		get
		{
			return TryGetValue("clientfeatureset", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("clientfeatureset") is false || Remove("clientfeatureset"))
			{
				Add("clientfeatureset", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Content Security Policy Configuration, Format: Text, MaxLength: 1073741823, SchemaName: ContentSecurityPolicyConfiguration, IntroducedVersion: 9.1.0.0.  Description: Policy configuration for CSP</summary>
	[JsonIgnore]
	public string? ContentSecurityPolicyConfiguration
	{
		get
		{
			return TryGetValue("contentsecuritypolicyconfiguration", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contentsecuritypolicyconfiguration") is false || Remove("contentsecuritypolicyconfiguration"))
			{
				Add("contentsecuritypolicyconfiguration", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Content Security Policy Configuration for Canvas apps, Format: Text, MaxLength: 4000, SchemaName: ContentSecurityPolicyConfigurationForCanvas, IntroducedVersion: 9.1.0.0.  Description: Content Security Policy configuration for Canvas apps.</summary>
	[JsonIgnore]
	public string? ContentSecurityPolicyConfigurationForCanvas
	{
		get
		{
			return TryGetValue("contentsecuritypolicyconfigurationforcanvas", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contentsecuritypolicyconfigurationforcanvas") is false || Remove("contentsecuritypolicyconfigurationforcanvas"))
			{
				Add("contentsecuritypolicyconfigurationforcanvas", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Content Security Policy Options, Format: None, MinValue: 0, MaxValue: 1024, SchemaName: ContentSecurityPolicyOptions, IntroducedVersion: 9.2.0.0.  Description: Content Security Policy Options.</summary>
	[JsonIgnore]
	public int? ContentSecurityPolicyOptions
	{
		get
		{
			return TryGetValue("contentsecuritypolicyoptions", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("contentsecuritypolicyoptions") is false || Remove("contentsecuritypolicyoptions"))
			{
				Add("contentsecuritypolicyoptions", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Content Security Policy Report Uri, Format: Text, MaxLength: 4000, SchemaName: ContentSecurityPolicyReportUri, IntroducedVersion: 9.1.0.0.  Description: Content Security Policy Report Uri.</summary>
	[JsonIgnore]
	public string? ContentSecurityPolicyReportUri
	{
		get
		{
			return TryGetValue("contentsecuritypolicyreporturi", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contentsecuritypolicyreporturi") is false || Remove("contentsecuritypolicyreporturi"))
			{
				Add("contentsecuritypolicyreporturi", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Contract Prefix, Format: Text, MaxLength: 20, SchemaName: ContractPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix to use for all contracts throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? ContractPrefix
	{
		get
		{
			return TryGetValue("contractprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractprefix") is false || Remove("contractprefix"))
			{
				Add("contractprefix", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: CopresenceRefreshRate, Format: None, MinValue: 30, MaxValue: 2147483647, SchemaName: CopresenceRefreshRate, IntroducedVersion: 9.2.0.0.  Description: Refresh rate for copresence data in seconds.</summary>
	[JsonIgnore]
	public int? CopresenceRefreshRate
	{
		get
		{
			return TryGetValue("copresencerefreshrate", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("copresencerefreshrate") is false || Remove("copresencerefreshrate"))
			{
				Add("copresencerefreshrate", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Cortana Proactive Experience Flow processes for this Organization, SchemaName: CortanaProactiveExperienceEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature CortanaProactiveExperience Flow processes should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? CortanaProactiveExperienceEnabledFormattedValue
	{
		get
		{
			return TryGetValue("cortanaproactiveexperienceenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Cortana Proactive Experience Flow processes for this Organization, SchemaName: CortanaProactiveExperienceEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature CortanaProactiveExperience Flow processes should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? CortanaProactiveExperienceEnabled
	{
		get
		{
			return TryGetValue("cortanaproactiveexperienceenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("cortanaproactiveexperienceenabled") is false || Remove("cortanaproactiveexperienceenabled"))
			{
				Add("cortanaproactiveexperienceenabled", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the organization.</summary>
	[JsonIgnore]
	public string? CreatedByFormattedValue
	{
		get
		{
			return TryGetValue("_createdby_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the organization.</summary>
	[JsonIgnore]
	public Guid? CreatedBy
	{
		get
		{
			return TryGetValue("_createdby_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the organization.</summary>
	[JsonIgnore]
	public Guid? CreatedBy_systemuser
	{
		set
		{
			if (ContainsKey("createdby_systemuser@odata.bind") is false || Remove("createdby_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("createdby_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_createdby_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CreatedByName
	{
		get
		{
			return TryGetValue("createdbyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("createdbyname") is false || Remove("createdbyname"))
			{
				Add("createdbyname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CreatedByYomiName
	{
		get
		{
			return TryGetValue("createdbyyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("createdbyyominame") is false || Remove("createdbyyominame"))
			{
				Add("createdbyyominame", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the organization was created.</summary>
	[JsonIgnore]
	public DateTime? CreatedOn
	{
		get
		{
			return TryGetValue("createdon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("createdon") is false || Remove("createdon"))
			{
				Add("createdon", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the organization.</summary>
	[JsonIgnore]
	public string? CreatedOnBehalfByFormattedValue
	{
		get
		{
			return TryGetValue("_createdonbehalfby_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the organization.</summary>
	[JsonIgnore]
	public Guid? CreatedOnBehalfBy
	{
		get
		{
			return TryGetValue("_createdonbehalfby_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the organization.</summary>
	[JsonIgnore]
	public Guid? CreatedOnBehalfBy_systemuser
	{
		set
		{
			if (ContainsKey("createdonbehalfby_systemuser@odata.bind") is false || Remove("createdonbehalfby_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("createdonbehalfby_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_createdonbehalfby_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CreatedOnBehalfByName
	{
		get
		{
			return TryGetValue("createdonbehalfbyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("createdonbehalfbyname") is false || Remove("createdonbehalfbyname"))
			{
				Add("createdonbehalfbyname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CreatedOnBehalfByYomiName
	{
		get
		{
			return TryGetValue("createdonbehalfbyyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("createdonbehalfbyyominame") is false || Remove("createdonbehalfbyyominame"))
			{
				Add("createdonbehalfbyyominame", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Active Initial Product State, SchemaName: CreateProductsWithoutParentInActiveState, IntroducedVersion: 7.0.0.0.  Description: Enable Initial state of newly created products to be Active instead of Draft</summary>
	[JsonIgnore]
	public string? CreateProductsWithoutParentInActiveStateFormattedValue
	{
		get
		{
			return TryGetValue("createproductswithoutparentinactivestate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Active Initial Product State, SchemaName: CreateProductsWithoutParentInActiveState, IntroducedVersion: 7.0.0.0.  Description: Enable Initial state of newly created products to be Active instead of Draft</summary>
	[JsonIgnore]
	public bool? CreateProductsWithoutParentInActiveState
	{
		get
		{
			return TryGetValue("createproductswithoutparentinactivestate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("createproductswithoutparentinactivestate") is false || Remove("createproductswithoutparentinactivestate"))
			{
				Add("createproductswithoutparentinactivestate", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Currency Decimal Precision, Format: None, MinValue: 0, MaxValue: 10, SchemaName: CurrencyDecimalPrecision, IntroducedVersion: 5.0.0.0.  Description: Number of decimal places that can be used for currency.</summary>
	[JsonIgnore]
	public int? CurrencyDecimalPrecision
	{
		get
		{
			return TryGetValue("currencydecimalprecision", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currencydecimalprecision") is false || Remove("currencydecimalprecision"))
			{
				Add("currencydecimalprecision", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Display Currencies Using, SchemaName: CurrencyDisplayOption, IntroducedVersion: 5.0.0.0.  Description: Indicates whether to display money fields with currency code or currency symbol.</summary>
	[JsonIgnore]
	public string? CurrencyDisplayOptionFormattedValue
	{
		get
		{
			return TryGetValue("currencydisplayoption@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Display Currencies Using, SchemaName: CurrencyDisplayOption, IntroducedVersion: 5.0.0.0.  Description: Indicates whether to display money fields with currency code or currency symbol.</summary>
	[JsonIgnore]
	public int? CurrencyDisplayOption
	{
		get
		{
			return TryGetValue("currencydisplayoption", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currencydisplayoption") is false || Remove("currencydisplayoption"))
			{
				Add("currencydisplayoption", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Currency Format Code, SchemaName: CurrencyFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information about how currency symbols are placed throughout Microsoft Dynamics CRM.</summary>
	[JsonIgnore]
	public string? CurrencyFormatCodeFormattedValue
	{
		get
		{
			return TryGetValue("currencyformatcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Currency Format Code, SchemaName: CurrencyFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information about how currency symbols are placed throughout Microsoft Dynamics CRM.</summary>
	[JsonIgnore]
	public int? CurrencyFormatCode
	{
		get
		{
			return TryGetValue("currencyformatcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currencyformatcode") is false || Remove("currencyformatcode"))
			{
				Add("currencyformatcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: currencyformatcode, SchemaName: CurrencyFormatCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CurrencyFormatCodeName
	{
		get
		{
			return TryGetValue("currencyformatcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Currency Symbol, Format: Text, MaxLength: 13, SchemaName: CurrencySymbol, IntroducedVersion: 5.0.0.0.  Description: Symbol used for currency throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? CurrencySymbol
	{
		get
		{
			return TryGetValue("currencysymbol", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("currencysymbol") is false || Remove("currencysymbol"))
			{
				Add("currencysymbol", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Bulk Operation Number, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: CurrentBulkOperationNumber, IntroducedVersion: 5.0.0.0.  Description: Current bulk operation number. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentBulkOperationNumber
	{
		get
		{
			return TryGetValue("currentbulkoperationnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentbulkoperationnumber") is false || Remove("currentbulkoperationnumber"))
			{
				Add("currentbulkoperationnumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Campaign Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentCampaignNumber, IntroducedVersion: 5.0.0.0.  Description: Current campaign number. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentCampaignNumber
	{
		get
		{
			return TryGetValue("currentcampaignnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentcampaignnumber") is false || Remove("currentcampaignnumber"))
			{
				Add("currentcampaignnumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Case Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentCaseNumber, IntroducedVersion: 5.0.0.0.  Description: First case number to use. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentCaseNumber
	{
		get
		{
			return TryGetValue("currentcasenumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentcasenumber") is false || Remove("currentcasenumber"))
			{
				Add("currentcasenumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Current Category Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: CurrentCategoryNumber, IntroducedVersion: 8.1.0.0.  Description: Enter the first number to use for Categories. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentCategoryNumber
	{
		get
		{
			return TryGetValue("currentcategorynumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentcategorynumber") is false || Remove("currentcategorynumber"))
			{
				Add("currentcategorynumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Contract Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentContractNumber, IntroducedVersion: 5.0.0.0.  Description: First contract number to use. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentContractNumber
	{
		get
		{
			return TryGetValue("currentcontractnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentcontractnumber") is false || Remove("currentcontractnumber"))
			{
				Add("currentcontractnumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Current Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Import sequence to use.</summary>
	[JsonIgnore]
	public int? CurrentImportSequenceNumber
	{
		get
		{
			return TryGetValue("currentimportsequencenumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentimportsequencenumber") is false || Remove("currentimportsequencenumber"))
			{
				Add("currentimportsequencenumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Invoice Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentInvoiceNumber, IntroducedVersion: 5.0.0.0.  Description: First invoice number to use. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentInvoiceNumber
	{
		get
		{
			return TryGetValue("currentinvoicenumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentinvoicenumber") is false || Remove("currentinvoicenumber"))
			{
				Add("currentinvoicenumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Current Knowledge Article Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: CurrentKaNumber, IntroducedVersion: 8.0.0.0.  Description: Enter the first number to use for knowledge articles. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentKaNumber
	{
		get
		{
			return TryGetValue("currentkanumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentkanumber") is false || Remove("currentkanumber"))
			{
				Add("currentkanumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Article Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentKbNumber, IntroducedVersion: 5.0.0.0.  Description: First article number to use. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentKbNumber
	{
		get
		{
			return TryGetValue("currentkbnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentkbnumber") is false || Remove("currentkbnumber"))
			{
				Add("currentkbnumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Order Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentOrderNumber, IntroducedVersion: 5.0.0.0.  Description: First order number to use. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentOrderNumber
	{
		get
		{
			return TryGetValue("currentordernumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentordernumber") is false || Remove("currentordernumber"))
			{
				Add("currentordernumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Current Parsed Table Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentParsedTableNumber, IntroducedVersion: 5.0.0.0.  Description: First parsed table number to use.</summary>
	[JsonIgnore]
	public int? CurrentParsedTableNumber
	{
		get
		{
			return TryGetValue("currentparsedtablenumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentparsedtablenumber") is false || Remove("currentparsedtablenumber"))
			{
				Add("currentparsedtablenumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Current Quote Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: CurrentQuoteNumber, IntroducedVersion: 5.0.0.0.  Description: First quote number to use. Deprecated. Use SetAutoNumberSeed message.</summary>
	[JsonIgnore]
	public int? CurrentQuoteNumber
	{
		get
		{
			return TryGetValue("currentquotenumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentquotenumber") is false || Remove("currentquotenumber"))
			{
				Add("currentquotenumber", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Date Format Code, SchemaName: DateFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information about how the date is displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? DateFormatCodeFormattedValue
	{
		get
		{
			return TryGetValue("dateformatcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Date Format Code, SchemaName: DateFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information about how the date is displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public int? DateFormatCode
	{
		get
		{
			return TryGetValue("dateformatcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("dateformatcode") is false || Remove("dateformatcode"))
			{
				Add("dateformatcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: dateformatcode, SchemaName: DateFormatCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DateFormatCodeName
	{
		get
		{
			return TryGetValue("dateformatcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Date Format String, Format: Text, MaxLength: 255, SchemaName: DateFormatString, IntroducedVersion: 5.0.0.0.  Description: String showing how the date is displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? DateFormatString
	{
		get
		{
			return TryGetValue("dateformatstring", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("dateformatstring") is false || Remove("dateformatstring"))
			{
				Add("dateformatstring", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Date Separator, Format: Text, MaxLength: 5, SchemaName: DateSeparator, IntroducedVersion: 5.0.0.0.  Description: Character used to separate the month, the day, and the year in dates throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? DateSeparator
	{
		get
		{
			return TryGetValue("dateseparator", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("dateseparator") is false || Remove("dateseparator"))
			{
				Add("dateseparator", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Number of days before we migrate email description to blob., Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: DaysBeforeEmailDescriptionIsMigrated, IntroducedVersion: 1.8.  Description: Number of days before we migrate email description to blob.</summary>
	[JsonIgnore]
	public int? DaysBeforeEmailDescriptionIsMigrated
	{
		get
		{
			return TryGetValue("daysbeforeemaildescriptionismigrated", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("daysbeforeemaildescriptionismigrated") is false || Remove("daysbeforeemaildescriptionismigrated"))
			{
				Add("daysbeforeemaildescriptionismigrated", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Days Before Inactive Teams Chat Sync Disabled, Format: None, MinValue: 1, MaxValue: 28, SchemaName: DaysBeforeInactiveTeamsChatSyncDisabled, IntroducedVersion: 9.2.0.0.  Description: Days of inactivity before sync is disabled for a Teams Chat.</summary>
	[JsonIgnore]
	public int? DaysBeforeInactiveTeamsChatSyncDisabled
	{
		get
		{
			return TryGetValue("daysbeforeinactiveteamschatsyncdisabled", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("daysbeforeinactiveteamschatsyncdisabled") is false || Remove("daysbeforeinactiveteamschatsyncdisabled"))
			{
				Add("daysbeforeinactiveteamschatsyncdisabled", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max value of Days since record last modified, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: DaysSinceRecordLastModifiedMaxValue, IntroducedVersion: 8.0.0.0.  Description: The maximum value for the Mobile Offline setting Days since record last modified</summary>
	[JsonIgnore]
	public int? DaysSinceRecordLastModifiedMaxValue
	{
		get
		{
			return TryGetValue("dayssincerecordlastmodifiedmaxvalue", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("dayssincerecordlastmodifiedmaxvalue") is false || Remove("dayssincerecordlastmodifiedmaxvalue"))
			{
				Add("dayssincerecordlastmodifiedmaxvalue", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Decimal Symbol, Format: Text, MaxLength: 5, SchemaName: DecimalSymbol, IntroducedVersion: 5.0.0.0.  Description: Symbol used for decimal in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? DecimalSymbol
	{
		get
		{
			return TryGetValue("decimalsymbol", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("decimalsymbol") is false || Remove("decimalsymbol"))
			{
				Add("decimalsymbol", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Default Country Code, Format: Text, MaxLength: 30, SchemaName: DefaultCountryCode, IntroducedVersion: 5.0.0.0.  Description: Text area to enter default country code.</summary>
	[JsonIgnore]
	public string? DefaultCountryCode
	{
		get
		{
			return TryGetValue("defaultcountrycode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultcountrycode") is false || Remove("defaultcountrycode"))
			{
				Add("defaultcountrycode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Name of the default app, Format: Text, MaxLength: 100, SchemaName: DefaultCrmCustomName, IntroducedVersion: 8.2.0.0.  Description: Name of the default crm custom.</summary>
	[JsonIgnore]
	public string? DefaultCrmCustomName
	{
		get
		{
			return TryGetValue("defaultcrmcustomname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultcrmcustomname") is false || Remove("defaultcrmcustomname"))
			{
				Add("defaultcrmcustomname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Email Server Profile, Format: None, SchemaName: DefaultEmailServerProfileId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the default email server profile.</summary>
	[JsonIgnore]
	public string? DefaultEmailServerProfileIdFormattedValue
	{
		get
		{
			return TryGetValue("_defaultemailserverprofileid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Email Server Profile, Format: None, SchemaName: DefaultEmailServerProfileId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the default email server profile.</summary>
	[JsonIgnore]
	public Guid? DefaultEmailServerProfileId
	{
		get
		{
			return TryGetValue("_defaultemailserverprofileid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Email Server Profile, Format: None, SchemaName: DefaultEmailServerProfileId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the default email server profile.</summary>
	[JsonIgnore]
	public Guid? DefaultEmailServerProfileId_emailserverprofile
	{
		set
		{
			if (ContainsKey("defaultemailserverprofileid_emailserverprofile@odata.bind") is false || Remove("defaultemailserverprofileid_emailserverprofile@odata.bind"))
			{
				if (value is not null)
				{
					Add("defaultemailserverprofileid_emailserverprofile@odata.bind", $"({value})");
				}
				else
				{
					Add("_defaultemailserverprofileid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: defaultemailserverprofileid, Format: Text, MaxLength: 100, SchemaName: DefaultEmailServerProfileIdName, IntroducedVersion: 6.0.0.0.  Description: Name of the email server profile to be used as default profile for the mailboxes.</summary>
	[JsonIgnore]
	public string? DefaultEmailServerProfileIdName
	{
		get
		{
			return TryGetValue("defaultemailserverprofileidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultemailserverprofileidname") is false || Remove("defaultemailserverprofileidname"))
			{
				Add("defaultemailserverprofileidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Default Email Settings, Format: Text, MaxLength: 1073741823, SchemaName: DefaultEmailSettings, IntroducedVersion: 6.0.0.0.  Description: XML string containing the default email settings that are applied when a user or queue is created.</summary>
	[JsonIgnore]
	public string? DefaultEmailSettings
	{
		get
		{
			return TryGetValue("defaultemailsettings", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultemailsettings") is false || Remove("defaultemailsettings"))
			{
				Add("defaultemailsettings", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Mobile Offline Profile, Format: None, SchemaName: DefaultMobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the default mobile offline profile.</summary>
	[JsonIgnore]
	public string? DefaultMobileOfflineProfileIdFormattedValue
	{
		get
		{
			return TryGetValue("_defaultmobileofflineprofileid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Mobile Offline Profile, Format: None, SchemaName: DefaultMobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the default mobile offline profile.</summary>
	[JsonIgnore]
	public Guid? DefaultMobileOfflineProfileId
	{
		get
		{
			return TryGetValue("_defaultmobileofflineprofileid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Mobile Offline Profile, Format: None, SchemaName: DefaultMobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the default mobile offline profile.</summary>
	[JsonIgnore]
	public Guid? DefaultMobileOfflineProfileId_mobileofflineprofile
	{
		set
		{
			if (ContainsKey("defaultmobileofflineprofileid_mobileofflineprofile@odata.bind") is false || Remove("defaultmobileofflineprofileid_mobileofflineprofile@odata.bind"))
			{
				if (value is not null)
				{
					Add("defaultmobileofflineprofileid_mobileofflineprofile@odata.bind", $"({value})");
				}
				else
				{
					Add("_defaultmobileofflineprofileid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: defaultmobileofflineprofileid, Format: Text, MaxLength: 100, SchemaName: DefaultMobileOfflineProfileIdName, IntroducedVersion: 8.0.0.0.  Description: Name of the default mobile offline profile to be used as default profile for mobile offline.</summary>
	[JsonIgnore]
	public string? DefaultMobileOfflineProfileIdName
	{
		get
		{
			return TryGetValue("defaultmobileofflineprofileidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultmobileofflineprofileidname") is false || Remove("defaultmobileofflineprofileidname"))
			{
				Add("defaultmobileofflineprofileidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Default Recurrence End Range Type, SchemaName: DefaultRecurrenceEndRangeType, IntroducedVersion: 5.0.0.0.  Description: Type of default recurrence end range date.</summary>
	[JsonIgnore]
	public string? DefaultRecurrenceEndRangeTypeFormattedValue
	{
		get
		{
			return TryGetValue("defaultrecurrenceendrangetype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Default Recurrence End Range Type, SchemaName: DefaultRecurrenceEndRangeType, IntroducedVersion: 5.0.0.0.  Description: Type of default recurrence end range date.</summary>
	[JsonIgnore]
	public int? DefaultRecurrenceEndRangeType
	{
		get
		{
			return TryGetValue("defaultrecurrenceendrangetype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultrecurrenceendrangetype") is false || Remove("defaultrecurrenceendrangetype"))
			{
				Add("defaultrecurrenceendrangetype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: defaultrecurrenceendrangetype, SchemaName: DefaultRecurrenceEndRangeTypeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DefaultRecurrenceEndRangeTypeName
	{
		get
		{
			return TryGetValue("defaultrecurrenceendrangetypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the default teams linked chat title is the record name, SchemaName: DefaultTeamsChatTitleRecordName, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the default teams linked chat title is the record name</summary>
	[JsonIgnore]
	public string? DefaultTeamsChatTitleRecordNameFormattedValue
	{
		get
		{
			return TryGetValue("defaultteamschattitlerecordname@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the default teams linked chat title is the record name, SchemaName: DefaultTeamsChatTitleRecordName, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the default teams linked chat title is the record name</summary>
	[JsonIgnore]
	public bool? DefaultTeamsChatTitleRecordName
	{
		get
		{
			return TryGetValue("defaultteamschattitlerecordname", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultteamschattitlerecordname") is false || Remove("defaultteamschattitlerecordname"))
			{
				Add("defaultteamschattitlerecordname", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: defaultteamschattitlerecordname, SchemaName: defaultteamschattitlerecordnameName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? defaultteamschattitlerecordnameName
	{
		get
		{
			return TryGetValue("defaultteamschattitlerecordnamename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Default Theme Data, Format: TextArea, MaxLength: 1073741823, SchemaName: DefaultThemeData, IntroducedVersion: 7.1.0.0.  Description: Default theme data for the organization.</summary>
	[JsonIgnore]
	public string? DefaultThemeData
	{
		get
		{
			return TryGetValue("defaultthemedata", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultthemedata") is false || Remove("defaultthemedata"))
			{
				Add("defaultthemedata", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Delegated Admin, SchemaName: DelegatedAdminUserId, IntroducedVersion: 7.1.0.0.  Description: Unique identifier of the delegated admin user for the organization.</summary>
	[JsonIgnore]
	public Guid? DelegatedAdminUserId
	{
		get
		{
			return TryGetValue("delegatedadminuserid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("delegatedadminuserid") is false || Remove("delegatedadminuserid"))
			{
				Add("delegatedadminuserid", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: The TTL for new desktop flow queue log records., Format: Duration, MinValue: 0, MaxValue: 33554432, SchemaName: DesktopFlowQueueLogsTtlInMinutes, IntroducedVersion: 1.8.0.0.  Description: Default time to live in minutes for new desktop flow queue log records.</summary>
	[JsonIgnore]
	public int? DesktopFlowQueueLogsTtlInMinutes
	{
		get
		{
			return TryGetValue("desktopflowqueuelogsttlinminutes", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("desktopflowqueuelogsttlinminutes") is false || Remove("desktopflowqueuelogsttlinminutes"))
			{
				Add("desktopflowqueuelogsttlinminutes", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Desktop Flow Run Action Logs Status, SchemaName: DesktopFlowRunActionLogsStatus, IntroducedVersion: 1.7.4.0.  Description: Toggle the activation of the Power Automate Desktop Flow run action logs.</summary>
	[JsonIgnore]
	public string? DesktopFlowRunActionLogsStatusFormattedValue
	{
		get
		{
			return TryGetValue("desktopflowrunactionlogsstatus@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Desktop Flow Run Action Logs Status, SchemaName: DesktopFlowRunActionLogsStatus, IntroducedVersion: 1.7.4.0.  Description: Toggle the activation of the Power Automate Desktop Flow run action logs.</summary>
	[JsonIgnore]
	public int? DesktopFlowRunActionLogsStatus
	{
		get
		{
			return TryGetValue("desktopflowrunactionlogsstatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("desktopflowrunactionlogsstatus") is false || Remove("desktopflowrunactionlogsstatus"))
			{
				Add("desktopflowrunactionlogsstatus", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: desktopflowrunactionlogsstatus, SchemaName: desktopflowrunactionlogsstatusName, IntroducedVersion: 1.7.4.0. </summary>
	[JsonIgnore]
	public object? desktopflowrunactionlogsstatusName
	{
		get
		{
			return TryGetValue("desktopflowrunactionlogsstatusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Desktop Flow Run Action Log Version, SchemaName: DesktopFlowRunActionLogVersion, IntroducedVersion: 1.7.4.0.  Description: Where the Power Automate Desktop Flow Run Action logs are stored.</summary>
	[JsonIgnore]
	public string? DesktopFlowRunActionLogVersionFormattedValue
	{
		get
		{
			return TryGetValue("desktopflowrunactionlogversion@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Desktop Flow Run Action Log Version, SchemaName: DesktopFlowRunActionLogVersion, IntroducedVersion: 1.7.4.0.  Description: Where the Power Automate Desktop Flow Run Action logs are stored.</summary>
	[JsonIgnore]
	public int? DesktopFlowRunActionLogVersion
	{
		get
		{
			return TryGetValue("desktopflowrunactionlogversion", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("desktopflowrunactionlogversion") is false || Remove("desktopflowrunactionlogversion"))
			{
				Add("desktopflowrunactionlogversion", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: desktopflowrunactionlogversion, SchemaName: desktopflowrunactionlogversionName, IntroducedVersion: 1.7.4.0. </summary>
	[JsonIgnore]
	public object? desktopflowrunactionlogversionName
	{
		get
		{
			return TryGetValue("desktopflowrunactionlogversionname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Disabled Reason, Format: Text, MaxLength: 500, SchemaName: DisabledReason, IntroducedVersion: 5.0.0.0.  Description: Reason for disabling the organization.</summary>
	[JsonIgnore]
	public string? DisabledReason
	{
		get
		{
			return TryGetValue("disabledreason", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("disabledreason") is false || Remove("disabledreason"))
			{
				Add("disabledreason", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Social Care disabled, SchemaName: DisableSocialCare, IntroducedVersion: 6.1.0.0.  Description: Indicates whether Social Care is disabled.</summary>
	[JsonIgnore]
	public string? DisableSocialCareFormattedValue
	{
		get
		{
			return TryGetValue("disablesocialcare@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Social Care disabled, SchemaName: DisableSocialCare, IntroducedVersion: 6.1.0.0.  Description: Indicates whether Social Care is disabled.</summary>
	[JsonIgnore]
	public bool? DisableSocialCare
	{
		get
		{
			return TryGetValue("disablesocialcare", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("disablesocialcare") is false || Remove("disablesocialcare"))
			{
				Add("disablesocialcare", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Disable System Labels Cache Sharing., SchemaName: DisableSystemLabelsCacheSharing, IntroducedVersion: 9.2.0.0.  Description: Disable sharing system labels for the organization.</summary>
	[JsonIgnore]
	public string? DisableSystemLabelsCacheSharingFormattedValue
	{
		get
		{
			return TryGetValue("disablesystemlabelscachesharing@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Disable System Labels Cache Sharing., SchemaName: DisableSystemLabelsCacheSharing, IntroducedVersion: 9.2.0.0.  Description: Disable sharing system labels for the organization.</summary>
	[JsonIgnore]
	public bool? DisableSystemLabelsCacheSharing
	{
		get
		{
			return TryGetValue("disablesystemlabelscachesharing", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("disablesystemlabelscachesharing") is false || Remove("disablesystemlabelscachesharing"))
			{
				Add("disablesystemlabelscachesharing", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: disablesystemlabelscachesharing, SchemaName: disablesystemlabelscachesharingName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? disablesystemlabelscachesharingName
	{
		get
		{
			return TryGetValue("disablesystemlabelscachesharingname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Discount calculation method, SchemaName: DiscountCalculationMethod, IntroducedVersion: 7.0.0.0.  Description: Discount calculation method for the QOOI product.</summary>
	[JsonIgnore]
	public string? DiscountCalculationMethodFormattedValue
	{
		get
		{
			return TryGetValue("discountcalculationmethod@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Discount calculation method, SchemaName: DiscountCalculationMethod, IntroducedVersion: 7.0.0.0.  Description: Discount calculation method for the QOOI product.</summary>
	[JsonIgnore]
	public int? DiscountCalculationMethod
	{
		get
		{
			return TryGetValue("discountcalculationmethod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("discountcalculationmethod") is false || Remove("discountcalculationmethod"))
			{
				Add("discountcalculationmethod", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Display Navigation Tour, SchemaName: DisplayNavigationTour, IntroducedVersion: 7.0.0.0.  Description: Indicates whether or not navigation tour is displayed.</summary>
	[JsonIgnore]
	public string? DisplayNavigationTourFormattedValue
	{
		get
		{
			return TryGetValue("displaynavigationtour@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Display Navigation Tour, SchemaName: DisplayNavigationTour, IntroducedVersion: 7.0.0.0.  Description: Indicates whether or not navigation tour is displayed.</summary>
	[JsonIgnore]
	public bool? DisplayNavigationTour
	{
		get
		{
			return TryGetValue("displaynavigationtour", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("displaynavigationtour") is false || Remove("displaynavigationtour"))
			{
				Add("displaynavigationtour", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Email Connection Channel, SchemaName: EmailConnectionChannel, IntroducedVersion: 6.0.0.0.  Description: Select if you want to use the Email Router or server-side synchronization for email processing.</summary>
	[JsonIgnore]
	public string? EmailConnectionChannelFormattedValue
	{
		get
		{
			return TryGetValue("emailconnectionchannel@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Email Connection Channel, SchemaName: EmailConnectionChannel, IntroducedVersion: 6.0.0.0.  Description: Select if you want to use the Email Router or server-side synchronization for email processing.</summary>
	[JsonIgnore]
	public int? EmailConnectionChannel
	{
		get
		{
			return TryGetValue("emailconnectionchannel", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailconnectionchannel") is false || Remove("emailconnectionchannel"))
			{
				Add("emailconnectionchannel", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use Email Correlation, SchemaName: EmailCorrelationEnabled, IntroducedVersion: 6.0.0.0.  Description: Flag to turn email correlation on or off.</summary>
	[JsonIgnore]
	public string? EmailCorrelationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("emailcorrelationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use Email Correlation, SchemaName: EmailCorrelationEnabled, IntroducedVersion: 6.0.0.0.  Description: Flag to turn email correlation on or off.</summary>
	[JsonIgnore]
	public bool? EmailCorrelationEnabled
	{
		get
		{
			return TryGetValue("emailcorrelationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailcorrelationenabled") is false || Remove("emailcorrelationenabled"))
			{
				Add("emailcorrelationenabled", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Email Send Polling Frequency, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: EmailSendPollingPeriod, IntroducedVersion: 5.0.0.0.  Description: Normal polling frequency used for sending email in Microsoft Office Outlook.</summary>
	[JsonIgnore]
	public int? EmailSendPollingPeriod
	{
		get
		{
			return TryGetValue("emailsendpollingperiod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailsendpollingperiod") is false || Remove("emailsendpollingperiod"))
			{
				Add("emailsendpollingperiod", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Select the default view in the enhanced insert e-mail template experience., SchemaName: EmailTemplateDefaultView, IntroducedVersion: 9.0.0.0.  Description: Indicates the selected default view in the enhanced insert e-mail template experience..</summary>
	[JsonIgnore]
	public string? EmailTemplateDefaultViewFormattedValue
	{
		get
		{
			return TryGetValue("emailtemplatedefaultview@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Select the default view in the enhanced insert e-mail template experience., SchemaName: EmailTemplateDefaultView, IntroducedVersion: 9.0.0.0.  Description: Indicates the selected default view in the enhanced insert e-mail template experience..</summary>
	[JsonIgnore]
	public int? EmailTemplateDefaultView
	{
		get
		{
			return TryGetValue("emailtemplatedefaultview", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailtemplatedefaultview") is false || Remove("emailtemplatedefaultview"))
			{
				Add("emailtemplatedefaultview", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: emailtemplatedefaultview, SchemaName: emailtemplatedefaultviewName, IntroducedVersion: 9.0.0.0. </summary>
	[JsonIgnore]
	public object? emailtemplatedefaultviewName
	{
		get
		{
			return TryGetValue("emailtemplatedefaultviewname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Asynchronous merge enabled for UCI, SchemaName: EnableAsyncMergeAPIForUCI, IntroducedVersion: 9.1.0.0.  Description: Determines whether records merged through the merge dialog in UCI are merged asynchronously</summary>
	[JsonIgnore]
	public string? EnableAsyncMergeAPIForUCIFormattedValue
	{
		get
		{
			return TryGetValue("enableasyncmergeapiforuci@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Asynchronous merge enabled for UCI, SchemaName: EnableAsyncMergeAPIForUCI, IntroducedVersion: 9.1.0.0.  Description: Determines whether records merged through the merge dialog in UCI are merged asynchronously</summary>
	[JsonIgnore]
	public bool? EnableAsyncMergeAPIForUCI
	{
		get
		{
			return TryGetValue("enableasyncmergeapiforuci", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableasyncmergeapiforuci") is false || Remove("enableasyncmergeapiforuci"))
			{
				Add("enableasyncmergeapiforuci", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableasyncmergeapiforuci, SchemaName: enableasyncmergeapiforuciName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? enableasyncmergeapiforuciName
	{
		get
		{
			return TryGetValue("enableasyncmergeapiforuciname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Integration with Bing Maps, SchemaName: EnableBingMapsIntegration, IntroducedVersion: 5.0.0.0.  Description: Enable Integration with Bing Maps</summary>
	[JsonIgnore]
	public string? EnableBingMapsIntegrationFormattedValue
	{
		get
		{
			return TryGetValue("enablebingmapsintegration@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Integration with Bing Maps, SchemaName: EnableBingMapsIntegration, IntroducedVersion: 5.0.0.0.  Description: Enable Integration with Bing Maps</summary>
	[JsonIgnore]
	public bool? EnableBingMapsIntegration
	{
		get
		{
			return TryGetValue("enablebingmapsintegration", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablebingmapsintegration") is false || Remove("enablebingmapsintegration"))
			{
				Add("enablebingmapsintegration", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow calendar export import with SLA, SchemaName: EnableCalendarImportExport, IntroducedVersion: 8.0.0.0.  Description: Indicates whether to Allow calendar export import with SLA.</summary>
	[JsonIgnore]
	public string? EnableCalendarImportExportFormattedValue
	{
		get
		{
			return TryGetValue("enablecalendarimportexport@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow calendar export import with SLA, SchemaName: EnableCalendarImportExport, IntroducedVersion: 8.0.0.0.  Description: Indicates whether to Allow calendar export import with SLA.</summary>
	[JsonIgnore]
	public bool? EnableCalendarImportExport
	{
		get
		{
			return TryGetValue("enablecalendarimportexport", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablecalendarimportexport") is false || Remove("enablecalendarimportexport"))
			{
				Add("enablecalendarimportexport", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enablecalendarimportexport, SchemaName: enablecalendarimportexportName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? enablecalendarimportexportName
	{
		get
		{
			return TryGetValue("enablecalendarimportexportname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the creation of Canvas apps in Dataverse / Solution by default, SchemaName: EnableCanvasAppsInSolutionsByDefault, IntroducedVersion: 9.1.0.0.  Description: Note: By enabling this feature, you will also enable the automatic creation of enviornment variables when adding data sources for your apps.</summary>
	[JsonIgnore]
	public string? EnableCanvasAppsInSolutionsByDefaultFormattedValue
	{
		get
		{
			return TryGetValue("enablecanvasappsinsolutionsbydefault@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the creation of Canvas apps in Dataverse / Solution by default, SchemaName: EnableCanvasAppsInSolutionsByDefault, IntroducedVersion: 9.1.0.0.  Description: Note: By enabling this feature, you will also enable the automatic creation of enviornment variables when adding data sources for your apps.</summary>
	[JsonIgnore]
	public bool? EnableCanvasAppsInSolutionsByDefault
	{
		get
		{
			return TryGetValue("enablecanvasappsinsolutionsbydefault", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablecanvasappsinsolutionsbydefault") is false || Remove("enablecanvasappsinsolutionsbydefault"))
			{
				Add("enablecanvasappsinsolutionsbydefault", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enablecanvasappsinsolutionsbydefault, SchemaName: enablecanvasappsinsolutionsbydefaultName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? enablecanvasappsinsolutionsbydefaultName
	{
		get
		{
			return TryGetValue("enablecanvasappsinsolutionsbydefaultname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow email template views in Enhanced Email Template, SchemaName: EnableEmailTemplateViews, IntroducedVersion: 9.0.0.0.  Description: Indicates whether to Allow email template views in Enhanced Email Template.</summary>
	[JsonIgnore]
	public string? EnableEmailTemplateViewsFormattedValue
	{
		get
		{
			return TryGetValue("enableemailtemplateviews@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow email template views in Enhanced Email Template, SchemaName: EnableEmailTemplateViews, IntroducedVersion: 9.0.0.0.  Description: Indicates whether to Allow email template views in Enhanced Email Template.</summary>
	[JsonIgnore]
	public bool? EnableEmailTemplateViews
	{
		get
		{
			return TryGetValue("enableemailtemplateviews", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableemailtemplateviews") is false || Remove("enableemailtemplateviews"))
			{
				Add("enableemailtemplateviews", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableemailtemplateviews, SchemaName: enableemailtemplateviewsName, IntroducedVersion: 9.0.0.0. </summary>
	[JsonIgnore]
	public object? enableemailtemplateviewsName
	{
		get
		{
			return TryGetValue("enableemailtemplateviewsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the creation of flows within a solution by default., SchemaName: EnableFlowsInSolutionByDefault, IntroducedVersion: 1.3.9.0.  Description: Indicates whether the creation of flows is within a solution by default for this organization.</summary>
	[JsonIgnore]
	public string? EnableFlowsInSolutionByDefaultFormattedValue
	{
		get
		{
			return TryGetValue("enableflowsinsolutionbydefault@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the creation of flows within a solution by default., SchemaName: EnableFlowsInSolutionByDefault, IntroducedVersion: 1.3.9.0.  Description: Indicates whether the creation of flows is within a solution by default for this organization.</summary>
	[JsonIgnore]
	public bool? EnableFlowsInSolutionByDefault
	{
		get
		{
			return TryGetValue("enableflowsinsolutionbydefault", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableflowsinsolutionbydefault") is false || Remove("enableflowsinsolutionbydefault"))
			{
				Add("enableflowsinsolutionbydefault", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the organization is opted into a grace period for auto-enablement of 'creation of flows within a solution by default' functionality., SchemaName: EnableFlowsInSolutionByDefaultGracePeriod, IntroducedVersion: 1.5.9.0.  Description: Organizations with this attribute set to true will be granted a grace period and excluded from the initial world wide enablement of 'creation of flows within a solution by default' functionality. Once the grace period expires, the functionality will be enabled in your organization.</summary>
	[JsonIgnore]
	public string? EnableFlowsInSolutionByDefaultGracePeriodFormattedValue
	{
		get
		{
			return TryGetValue("enableflowsinsolutionbydefaultgraceperiod@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the organization is opted into a grace period for auto-enablement of 'creation of flows within a solution by default' functionality., SchemaName: EnableFlowsInSolutionByDefaultGracePeriod, IntroducedVersion: 1.5.9.0.  Description: Organizations with this attribute set to true will be granted a grace period and excluded from the initial world wide enablement of 'creation of flows within a solution by default' functionality. Once the grace period expires, the functionality will be enabled in your organization.</summary>
	[JsonIgnore]
	public bool? EnableFlowsInSolutionByDefaultGracePeriod
	{
		get
		{
			return TryGetValue("enableflowsinsolutionbydefaultgraceperiod", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableflowsinsolutionbydefaultgraceperiod") is false || Remove("enableflowsinsolutionbydefaultgraceperiod"))
			{
				Add("enableflowsinsolutionbydefaultgraceperiod", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableflowsinsolutionbydefaultgraceperiod, SchemaName: enableflowsinsolutionbydefaultgraceperiodName, IntroducedVersion: 1.5.9.0. </summary>
	[JsonIgnore]
	public object? enableflowsinsolutionbydefaultgraceperiodName
	{
		get
		{
			return TryGetValue("enableflowsinsolutionbydefaultgraceperiodname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableflowsinsolutionbydefault, SchemaName: enableflowsinsolutionbydefaultName, IntroducedVersion: 1.3.9.0. </summary>
	[JsonIgnore]
	public object? enableflowsinsolutionbydefaultName
	{
		get
		{
			return TryGetValue("enableflowsinsolutionbydefaultname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Integration with Immersive Skype, SchemaName: EnableImmersiveSkypeIntegration, IntroducedVersion: 9.0.0.0.  Description: Enable Integration with Immersive Skype</summary>
	[JsonIgnore]
	public string? EnableImmersiveSkypeIntegrationFormattedValue
	{
		get
		{
			return TryGetValue("enableimmersiveskypeintegration@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Integration with Immersive Skype, SchemaName: EnableImmersiveSkypeIntegration, IntroducedVersion: 9.0.0.0.  Description: Enable Integration with Immersive Skype</summary>
	[JsonIgnore]
	public bool? EnableImmersiveSkypeIntegration
	{
		get
		{
			return TryGetValue("enableimmersiveskypeintegration", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableimmersiveskypeintegration") is false || Remove("enableimmersiveskypeintegration"))
			{
				Add("enableimmersiveskypeintegration", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP Address Based Cookie Binding, SchemaName: EnableIpBasedCookieBinding, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether IP based cookie binding is enabled</summary>
	[JsonIgnore]
	public string? EnableIpBasedCookieBindingFormattedValue
	{
		get
		{
			return TryGetValue("enableipbasedcookiebinding@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP Address Based Cookie Binding, SchemaName: EnableIpBasedCookieBinding, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether IP based cookie binding is enabled</summary>
	[JsonIgnore]
	public bool? EnableIpBasedCookieBinding
	{
		get
		{
			return TryGetValue("enableipbasedcookiebinding", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableipbasedcookiebinding") is false || Remove("enableipbasedcookiebinding"))
			{
				Add("enableipbasedcookiebinding", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableipbasedcookiebinding, SchemaName: enableipbasedcookiebindingName, IntroducedVersion: 1.0.0.12. </summary>
	[JsonIgnore]
	public object? enableipbasedcookiebindingName
	{
		get
		{
			return TryGetValue("enableipbasedcookiebindingname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP Range based Firewall, SchemaName: EnableIpBasedFirewallRule, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether IP based firewall rule is enabled</summary>
	[JsonIgnore]
	public string? EnableIpBasedFirewallRuleFormattedValue
	{
		get
		{
			return TryGetValue("enableipbasedfirewallrule@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP Range based Firewall, SchemaName: EnableIpBasedFirewallRule, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether IP based firewall rule is enabled</summary>
	[JsonIgnore]
	public bool? EnableIpBasedFirewallRule
	{
		get
		{
			return TryGetValue("enableipbasedfirewallrule", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableipbasedfirewallrule") is false || Remove("enableipbasedfirewallrule"))
			{
				Add("enableipbasedfirewallrule", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP Range based Firewall In Audit Only Mode, SchemaName: EnableIpBasedFirewallRuleInAuditMode, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether IP based firewall rule is enabled in Audit Only Mode</summary>
	[JsonIgnore]
	public string? EnableIpBasedFirewallRuleInAuditModeFormattedValue
	{
		get
		{
			return TryGetValue("enableipbasedfirewallruleinauditmode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP Range based Firewall In Audit Only Mode, SchemaName: EnableIpBasedFirewallRuleInAuditMode, IntroducedVersion: 1.0.0.12.  Description: Information that specifies whether IP based firewall rule is enabled in Audit Only Mode</summary>
	[JsonIgnore]
	public bool? EnableIpBasedFirewallRuleInAuditMode
	{
		get
		{
			return TryGetValue("enableipbasedfirewallruleinauditmode", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableipbasedfirewallruleinauditmode") is false || Remove("enableipbasedfirewallruleinauditmode"))
			{
				Add("enableipbasedfirewallruleinauditmode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableipbasedfirewallruleinauditmode, SchemaName: enableipbasedfirewallruleinauditmodeName, IntroducedVersion: 1.0.0.12. </summary>
	[JsonIgnore]
	public object? enableipbasedfirewallruleinauditmodeName
	{
		get
		{
			return TryGetValue("enableipbasedfirewallruleinauditmodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableipbasedfirewallrule, SchemaName: enableipbasedfirewallruleName, IntroducedVersion: 1.0.0.12. </summary>
	[JsonIgnore]
	public object? enableipbasedfirewallruleName
	{
		get
		{
			return TryGetValue("enableipbasedfirewallrulename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP SAS URI generation rule, SchemaName: EnableIpBasedStorageAccessSignatureRule, IntroducedVersion: 1.0.0.5.  Description: Information that specifies whether IP based SAS URI generation rule is enabled</summary>
	[JsonIgnore]
	public string? EnableIpBasedStorageAccessSignatureRuleFormattedValue
	{
		get
		{
			return TryGetValue("enableipbasedstorageaccesssignaturerule@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable IP SAS URI generation rule, SchemaName: EnableIpBasedStorageAccessSignatureRule, IntroducedVersion: 1.0.0.5.  Description: Information that specifies whether IP based SAS URI generation rule is enabled</summary>
	[JsonIgnore]
	public bool? EnableIpBasedStorageAccessSignatureRule
	{
		get
		{
			return TryGetValue("enableipbasedstorageaccesssignaturerule", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableipbasedstorageaccesssignaturerule") is false || Remove("enableipbasedstorageaccesssignaturerule"))
			{
				Add("enableipbasedstorageaccesssignaturerule", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableipbasedstorageaccesssignaturerule, SchemaName: enableipbasedstorageaccesssignatureruleName, IntroducedVersion: 1.0.0.5. </summary>
	[JsonIgnore]
	public object? enableipbasedstorageaccesssignatureruleName
	{
		get
		{
			return TryGetValue("enableipbasedstorageaccesssignaturerulename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the user has enabled or disabled Live Persona Card feature in UCI., SchemaName: EnableLivePersonaCardUCI, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the user has enabled or disabled Live Persona Card feature in UCI.</summary>
	[JsonIgnore]
	public string? EnableLivePersonaCardUCIFormattedValue
	{
		get
		{
			return TryGetValue("enablelivepersonacarduci@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the user has enabled or disabled Live Persona Card feature in UCI., SchemaName: EnableLivePersonaCardUCI, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the user has enabled or disabled Live Persona Card feature in UCI.</summary>
	[JsonIgnore]
	public bool? EnableLivePersonaCardUCI
	{
		get
		{
			return TryGetValue("enablelivepersonacarduci", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablelivepersonacarduci") is false || Remove("enablelivepersonacarduci"))
			{
				Add("enablelivepersonacarduci", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the user has enabled or disabled LivePersonCardIntegration in Office., SchemaName: EnableLivePersonCardIntegrationInOffice, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the user has enabled or disabled LivePersonCardIntegration in Office.</summary>
	[JsonIgnore]
	public string? EnableLivePersonCardIntegrationInOfficeFormattedValue
	{
		get
		{
			return TryGetValue("enablelivepersoncardintegrationinoffice@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether the user has enabled or disabled LivePersonCardIntegration in Office., SchemaName: EnableLivePersonCardIntegrationInOffice, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the user has enabled or disabled LivePersonCardIntegration in Office.</summary>
	[JsonIgnore]
	public bool? EnableLivePersonCardIntegrationInOffice
	{
		get
		{
			return TryGetValue("enablelivepersoncardintegrationinoffice", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablelivepersoncardintegrationinoffice") is false || Remove("enablelivepersoncardintegrationinoffice"))
			{
				Add("enablelivepersoncardintegrationinoffice", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Learning Path Authoring, SchemaName: EnableLPAuthoring, IntroducedVersion: 8.2.0.0.  Description: Select to enable learning path auhtoring.</summary>
	[JsonIgnore]
	public string? EnableLPAuthoringFormattedValue
	{
		get
		{
			return TryGetValue("enablelpauthoring@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Learning Path Authoring, SchemaName: EnableLPAuthoring, IntroducedVersion: 8.2.0.0.  Description: Select to enable learning path auhtoring.</summary>
	[JsonIgnore]
	public bool? EnableLPAuthoring
	{
		get
		{
			return TryGetValue("enablelpauthoring", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablelpauthoring") is false || Remove("enablelpauthoring"))
			{
				Add("enablelpauthoring", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Switch Maker Portal to Classic, SchemaName: EnableMakerSwitchToClassic, IntroducedVersion: 9.1.0.0.  Description: Control whether the organization Switch Maker Portal to Classic</summary>
	[JsonIgnore]
	public string? EnableMakerSwitchToClassicFormattedValue
	{
		get
		{
			return TryGetValue("enablemakerswitchtoclassic@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Switch Maker Portal to Classic, SchemaName: EnableMakerSwitchToClassic, IntroducedVersion: 9.1.0.0.  Description: Control whether the organization Switch Maker Portal to Classic</summary>
	[JsonIgnore]
	public bool? EnableMakerSwitchToClassic
	{
		get
		{
			return TryGetValue("enablemakerswitchtoclassic", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablemakerswitchtoclassic") is false || Remove("enablemakerswitchtoclassic"))
			{
				Add("enablemakerswitchtoclassic", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enablemakerswitchtoclassic, SchemaName: enablemakerswitchtoclassicName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? enablemakerswitchtoclassicName
	{
		get
		{
			return TryGetValue("enablemakerswitchtoclassicname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Integration with Microsoft Flow, SchemaName: EnableMicrosoftFlowIntegration, IntroducedVersion: 8.2.0.0.  Description: Enable Integration with Microsoft Flow</summary>
	[JsonIgnore]
	public string? EnableMicrosoftFlowIntegrationFormattedValue
	{
		get
		{
			return TryGetValue("enablemicrosoftflowintegration@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Integration with Microsoft Flow, SchemaName: EnableMicrosoftFlowIntegration, IntroducedVersion: 8.2.0.0.  Description: Enable Integration with Microsoft Flow</summary>
	[JsonIgnore]
	public bool? EnableMicrosoftFlowIntegration
	{
		get
		{
			return TryGetValue("enablemicrosoftflowintegration", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablemicrosoftflowintegration") is false || Remove("enablemicrosoftflowintegration"))
			{
				Add("enablemicrosoftflowintegration", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Pricing On Create, SchemaName: EnablePricingOnCreate, IntroducedVersion: 5.0.0.0.  Description: Enable pricing calculations on a Create call.</summary>
	[JsonIgnore]
	public string? EnablePricingOnCreateFormattedValue
	{
		get
		{
			return TryGetValue("enablepricingoncreate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Pricing On Create, SchemaName: EnablePricingOnCreate, IntroducedVersion: 5.0.0.0.  Description: Enable pricing calculations on a Create call.</summary>
	[JsonIgnore]
	public bool? EnablePricingOnCreate
	{
		get
		{
			return TryGetValue("enablepricingoncreate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablepricingoncreate") is false || Remove("enablepricingoncreate"))
			{
				Add("enablepricingoncreate", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether privacy and sensitivity attributes for new team creation has been enabled, SchemaName: EnableSensitivityLabelsForTeamsCollab, IntroducedVersion: 9.1.0.0.  Description: Indicates whether privacy and sensitivity attributes for new team creation has been enabled</summary>
	[JsonIgnore]
	public string? EnableSensitivityLabelsForTeamsCollabFormattedValue
	{
		get
		{
			return TryGetValue("enablesensitivitylabelsforteamscollab@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether privacy and sensitivity attributes for new team creation has been enabled, SchemaName: EnableSensitivityLabelsForTeamsCollab, IntroducedVersion: 9.1.0.0.  Description: Indicates whether privacy and sensitivity attributes for new team creation has been enabled</summary>
	[JsonIgnore]
	public bool? EnableSensitivityLabelsForTeamsCollab
	{
		get
		{
			return TryGetValue("enablesensitivitylabelsforteamscollab", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablesensitivitylabelsforteamscollab") is false || Remove("enablesensitivitylabelsforteamscollab"))
			{
				Add("enablesensitivitylabelsforteamscollab", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enablesensitivitylabelsforteamscollab, SchemaName: enablesensitivitylabelsforteamscollabName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? enablesensitivitylabelsforteamscollabName
	{
		get
		{
			return TryGetValue("enablesensitivitylabelsforteamscollabname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Enable Smart Matching, SchemaName: EnableSmartMatching, IntroducedVersion: 5.0.0.0.  Description: Use Smart Matching.</summary>
	[JsonIgnore]
	public string? EnableSmartMatchingFormattedValue
	{
		get
		{
			return TryGetValue("enablesmartmatching@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Enable Smart Matching, SchemaName: EnableSmartMatching, IntroducedVersion: 5.0.0.0.  Description: Use Smart Matching.</summary>
	[JsonIgnore]
	public bool? EnableSmartMatching
	{
		get
		{
			return TryGetValue("enablesmartmatching", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enablesmartmatching") is false || Remove("enablesmartmatching"))
			{
				Add("enablesmartmatching", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable UCI CDN for organization, SchemaName: EnableUnifiedClientCDN, IntroducedVersion: 9.1.0.0.  Description: Leave empty to use default setting. Set to on/off to enable/disable CDN for UCI.</summary>
	[JsonIgnore]
	public string? EnableUnifiedClientCDNFormattedValue
	{
		get
		{
			return TryGetValue("enableunifiedclientcdn@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable UCI CDN for organization, SchemaName: EnableUnifiedClientCDN, IntroducedVersion: 9.1.0.0.  Description: Leave empty to use default setting. Set to on/off to enable/disable CDN for UCI.</summary>
	[JsonIgnore]
	public bool? EnableUnifiedClientCDN
	{
		get
		{
			return TryGetValue("enableunifiedclientcdn", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableunifiedclientcdn") is false || Remove("enableunifiedclientcdn"))
			{
				Add("enableunifiedclientcdn", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: enableunifiedclientcdn, SchemaName: enableunifiedclientcdnName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? enableunifiedclientcdnName
	{
		get
		{
			return TryGetValue("enableunifiedclientcdnname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable site map and commanding update, SchemaName: EnableUnifiedInterfaceShellRefresh, IntroducedVersion: 9.1.0.0.  Description: Enable site map and commanding update</summary>
	[JsonIgnore]
	public string? EnableUnifiedInterfaceShellRefreshFormattedValue
	{
		get
		{
			return TryGetValue("enableunifiedinterfaceshellrefresh@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable site map and commanding update, SchemaName: EnableUnifiedInterfaceShellRefresh, IntroducedVersion: 9.1.0.0.  Description: Enable site map and commanding update</summary>
	[JsonIgnore]
	public bool? EnableUnifiedInterfaceShellRefresh
	{
		get
		{
			return TryGetValue("enableunifiedinterfaceshellrefresh", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enableunifiedinterfaceshellrefresh") is false || Remove("enableunifiedinterfaceshellrefresh"))
			{
				Add("enableunifiedinterfaceshellrefresh", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Organization setting to enforce read only plugins., SchemaName: EnforceReadOnlyPlugins, IntroducedVersion: 7.1.0.0.  Description: Organization setting to enforce read only plugins.</summary>
	[JsonIgnore]
	public string? EnforceReadOnlyPluginsFormattedValue
	{
		get
		{
			return TryGetValue("enforcereadonlyplugins@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Organization setting to enforce read only plugins., SchemaName: EnforceReadOnlyPlugins, IntroducedVersion: 7.1.0.0.  Description: Organization setting to enforce read only plugins.</summary>
	[JsonIgnore]
	public bool? EnforceReadOnlyPlugins
	{
		get
		{
			return TryGetValue("enforcereadonlyplugins", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("enforcereadonlyplugins") is false || Remove("enforcereadonlyplugins"))
			{
				Add("enforcereadonlyplugins", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Enhanced Add Products Settings, Format: Text, MaxLength: 1000, SchemaName: EnhancedOQOIAddProductsSettings, IntroducedVersion: 9.1.0.0.  Description: JSON string containing settings for enhanced add products experience in Sales</summary>
	[JsonIgnore]
	public string? EnhancedOQOIAddProductsSettings
	{
		get
		{
			return TryGetValue("enhancedoqoiaddproductssettings", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("enhancedoqoiaddproductssettings") is false || Remove("enhancedoqoiaddproductssettings"))
			{
				Add("enhancedoqoiaddproductssettings", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Entity Image, AttributeOf: entityimageid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: EntityImage, IntroducedVersion: 6.0.0.0.  Description: The default image for the entity.</summary>
	[JsonIgnore]
	public object? EntityImage
	{
		get
		{
			return TryGetValue("entityimage", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: None, AttributeOf: entityimageid, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: EntityImage_Timestamp, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public long? EntityImage_Timestamp
	{
		get
		{
			return TryGetValue("entityimage_timestamp", out var value)
				? value is not null ? ((JsonElement)value).GetInt64()
				: null : null;
		}
		set
		{
			if (ContainsKey("entityimage_timestamp") is false || Remove("entityimage_timestamp"))
			{
				Add("entityimage_timestamp", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: entityimageid, Format: Url, MaxLength: 200, SchemaName: EntityImage_URL, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public string? EntityImage_URL
	{
		get
		{
			return TryGetValue("entityimage_url", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("entityimage_url") is false || Remove("entityimage_url"))
			{
				Add("entityimage_url", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Entity Image Id, SchemaName: EntityImageId, IntroducedVersion: 6.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? EntityImageId
	{
		get
		{
			return TryGetValue("entityimageid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("entityimageid") is false || Remove("entityimageid"))
			{
				Add("entityimageid", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Days to Expire Change Tracking Deleted Records, Format: None, MinValue: 0, MaxValue: 365, SchemaName: ExpireChangeTrackingInDays, IntroducedVersion: 7.1.0.0.  Description: Maximum number of days to keep change tracking deleted records</summary>
	[JsonIgnore]
	public int? ExpireChangeTrackingInDays
	{
		get
		{
			return TryGetValue("expirechangetrackingindays", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("expirechangetrackingindays") is false || Remove("expirechangetrackingindays"))
			{
				Add("expirechangetrackingindays", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Days to Expire Subscriptions, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: ExpireSubscriptionsInDays, IntroducedVersion: 5.0.0.0.  Description: Maximum number of days before deleting inactive subscriptions.</summary>
	[JsonIgnore]
	public int? ExpireSubscriptionsInDays
	{
		get
		{
			return TryGetValue("expiresubscriptionsindays", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("expiresubscriptionsindays") is false || Remove("expiresubscriptionsindays"))
			{
				Add("expiresubscriptionsindays", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: External Base URL, Format: Text, MaxLength: 500, SchemaName: ExternalBaseUrl, IntroducedVersion: 8.2.0.0.  Description: Specify the base URL to use to look for external document suggestions.</summary>
	[JsonIgnore]
	public string? ExternalBaseUrl
	{
		get
		{
			return TryGetValue("externalbaseurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("externalbaseurl") is false || Remove("externalbaseurl"))
			{
				Add("externalbaseurl", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ExternalPartyEnabled Entities correlation Keys, Format: Text, MaxLength: 1073741823, SchemaName: ExternalPartyCorrelationKeys, IntroducedVersion: 8.0.0.0.  Description: XML string containing the ExternalPartyEnabled entities correlation keys for association of existing External Party instance entities to newly created IsExternalPartyEnabled entities.For internal use only</summary>
	[JsonIgnore]
	public string? ExternalPartyCorrelationKeys
	{
		get
		{
			return TryGetValue("externalpartycorrelationkeys", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("externalpartycorrelationkeys") is false || Remove("externalpartycorrelationkeys"))
			{
				Add("externalpartycorrelationkeys", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ExternalPartyEnabled Entities Settings.For internal use only, Format: Text, MaxLength: 1073741823, SchemaName: ExternalPartyEntitySettings, IntroducedVersion: 8.0.0.0.  Description: XML string containing the ExternalPartyEnabled entities settings.</summary>
	[JsonIgnore]
	public string? ExternalPartyEntitySettings
	{
		get
		{
			return TryGetValue("externalpartyentitysettings", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("externalpartyentitysettings") is false || Remove("externalpartyentitysettings"))
			{
				Add("externalpartyentitysettings", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Feature Set, Format: Text, MaxLength: 1073741823, SchemaName: FeatureSet, IntroducedVersion: 5.0.0.0.  Description: Features to be enabled as an XML BLOB.</summary>
	[JsonIgnore]
	public string? FeatureSet
	{
		get
		{
			return TryGetValue("featureset", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("featureset") is false || Remove("featureset"))
			{
				Add("featureset", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Fiscal Calendar Start, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: FiscalCalendarStart, IntroducedVersion: 5.0.0.0.  Description: Start date for the fiscal period that is to be used throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public DateTime? FiscalCalendarStart
	{
		get
		{
			return TryGetValue("fiscalcalendarstart", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalcalendarstart") is false || Remove("fiscalcalendarstart"))
			{
				Add("fiscalcalendarstart", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Fiscal Period Format, Format: Text, MaxLength: 25, SchemaName: FiscalPeriodFormat, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how the name of the fiscal period is displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? FiscalPeriodFormat
	{
		get
		{
			return TryGetValue("fiscalperiodformat", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalperiodformat") is false || Remove("fiscalperiodformat"))
			{
				Add("fiscalperiodformat", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Format for Fiscal Period, SchemaName: FiscalPeriodFormatPeriod, IntroducedVersion: 5.0.0.0.  Description: Format in which the fiscal period will be displayed.</summary>
	[JsonIgnore]
	public string? FiscalPeriodFormatPeriodFormattedValue
	{
		get
		{
			return TryGetValue("fiscalperiodformatperiod@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Format for Fiscal Period, SchemaName: FiscalPeriodFormatPeriod, IntroducedVersion: 5.0.0.0.  Description: Format in which the fiscal period will be displayed.</summary>
	[JsonIgnore]
	public int? FiscalPeriodFormatPeriod
	{
		get
		{
			return TryGetValue("fiscalperiodformatperiod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalperiodformatperiod") is false || Remove("fiscalperiodformatperiod"))
			{
				Add("fiscalperiodformatperiod", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: fiscalperiodformatperiod, SchemaName: FiscalPeriodFormatPeriodName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? FiscalPeriodFormatPeriodName
	{
		get
		{
			return TryGetValue("fiscalperiodformatperiodname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Fiscal Period Type, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: FiscalPeriodType, IntroducedVersion: 5.0.0.0.  Description: Type of fiscal period used throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public int? FiscalPeriodType
	{
		get
		{
			return TryGetValue("fiscalperiodtype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalperiodtype") is false || Remove("fiscalperiodtype"))
			{
				Add("fiscalperiodtype", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Fiscal Settings Updated, SchemaName: FiscalSettingsUpdated, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether the fiscal settings have been updated.</summary>
	[JsonIgnore]
	public string? FiscalSettingsUpdatedFormattedValue
	{
		get
		{
			return TryGetValue("fiscalsettingsupdated@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Fiscal Settings Updated, SchemaName: FiscalSettingsUpdated, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether the fiscal settings have been updated.</summary>
	[JsonIgnore]
	public bool? FiscalSettingsUpdated
	{
		get
		{
			return TryGetValue("fiscalsettingsupdated", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalsettingsupdated") is false || Remove("fiscalsettingsupdated"))
			{
				Add("fiscalsettingsupdated", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: fiscalsettingsupdated, SchemaName: FiscalSettingsUpdatedName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? FiscalSettingsUpdatedName
	{
		get
		{
			return TryGetValue("fiscalsettingsupdatedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Fiscal Year Display, Format: None, SchemaName: FiscalYearDisplayCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether the fiscal year should be displayed based on the start date or the end date of the fiscal year.</summary>
	[JsonIgnore]
	public int? FiscalYearDisplayCode
	{
		get
		{
			return TryGetValue("fiscalyeardisplaycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalyeardisplaycode") is false || Remove("fiscalyeardisplaycode"))
			{
				Add("fiscalyeardisplaycode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Fiscal Year Format, Format: Text, MaxLength: 25, SchemaName: FiscalYearFormat, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how the name of the fiscal year is displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? FiscalYearFormat
	{
		get
		{
			return TryGetValue("fiscalyearformat", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalyearformat") is false || Remove("fiscalyearformat"))
			{
				Add("fiscalyearformat", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Prefix for Fiscal Year, SchemaName: FiscalYearFormatPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix for the display of the fiscal year.</summary>
	[JsonIgnore]
	public string? FiscalYearFormatPrefixFormattedValue
	{
		get
		{
			return TryGetValue("fiscalyearformatprefix@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Prefix for Fiscal Year, SchemaName: FiscalYearFormatPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix for the display of the fiscal year.</summary>
	[JsonIgnore]
	public int? FiscalYearFormatPrefix
	{
		get
		{
			return TryGetValue("fiscalyearformatprefix", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalyearformatprefix") is false || Remove("fiscalyearformatprefix"))
			{
				Add("fiscalyearformatprefix", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: fiscalyearformatprefix, SchemaName: FiscalYearFormatPrefixName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? FiscalYearFormatPrefixName
	{
		get
		{
			return TryGetValue("fiscalyearformatprefixname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Suffix for Fiscal Year, SchemaName: FiscalYearFormatSuffix, IntroducedVersion: 5.0.0.0.  Description: Suffix for the display of the fiscal year.</summary>
	[JsonIgnore]
	public string? FiscalYearFormatSuffixFormattedValue
	{
		get
		{
			return TryGetValue("fiscalyearformatsuffix@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Suffix for Fiscal Year, SchemaName: FiscalYearFormatSuffix, IntroducedVersion: 5.0.0.0.  Description: Suffix for the display of the fiscal year.</summary>
	[JsonIgnore]
	public int? FiscalYearFormatSuffix
	{
		get
		{
			return TryGetValue("fiscalyearformatsuffix", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalyearformatsuffix") is false || Remove("fiscalyearformatsuffix"))
			{
				Add("fiscalyearformatsuffix", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: fiscalyearformatsuffix, SchemaName: FiscalYearFormatSuffixName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? FiscalYearFormatSuffixName
	{
		get
		{
			return TryGetValue("fiscalyearformatsuffixname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Fiscal Year Format Year, SchemaName: FiscalYearFormatYear, IntroducedVersion: 5.0.0.0.  Description: Format for the year.</summary>
	[JsonIgnore]
	public string? FiscalYearFormatYearFormattedValue
	{
		get
		{
			return TryGetValue("fiscalyearformatyear@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Fiscal Year Format Year, SchemaName: FiscalYearFormatYear, IntroducedVersion: 5.0.0.0.  Description: Format for the year.</summary>
	[JsonIgnore]
	public int? FiscalYearFormatYear
	{
		get
		{
			return TryGetValue("fiscalyearformatyear", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalyearformatyear") is false || Remove("fiscalyearformatyear"))
			{
				Add("fiscalyearformatyear", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: fiscalyearformatyear, SchemaName: FiscalYearFormatYearName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? FiscalYearFormatYearName
	{
		get
		{
			return TryGetValue("fiscalyearformatyearname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Fiscal Year Period Connector, Format: Text, MaxLength: 5, SchemaName: FiscalYearPeriodConnect, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how the names of the fiscal year and the fiscal period should be connected when displayed together.</summary>
	[JsonIgnore]
	public string? FiscalYearPeriodConnect
	{
		get
		{
			return TryGetValue("fiscalyearperiodconnect", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("fiscalyearperiodconnect") is false || Remove("fiscalyearperiodconnect"))
			{
				Add("fiscalyearperiodconnect", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: The TTL for records in the Flow Logs Entity., Format: Duration, MinValue: 0, MaxValue: 33554432, SchemaName: FlowLogsTtlInMinutes, IntroducedVersion: 1.8.0.0.  Description: Default time to live in minutes for new records in the Flow Logs entity.</summary>
	[JsonIgnore]
	public int? FlowLogsTtlInMinutes
	{
		get
		{
			return TryGetValue("flowlogsttlinminutes", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("flowlogsttlinminutes") is false || Remove("flowlogsttlinminutes"))
			{
				Add("flowlogsttlinminutes", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Time to live (in seconds) for flow run, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: FlowRunTimeToLiveInSeconds, IntroducedVersion: 1.6.2.0.  Description: Time to live (in seconds) for flow run</summary>
	[JsonIgnore]
	public int? FlowRunTimeToLiveInSeconds
	{
		get
		{
			return TryGetValue("flowruntimetoliveinseconds", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("flowruntimetoliveinseconds") is false || Remove("flowruntimetoliveinseconds"))
			{
				Add("flowruntimetoliveinseconds", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Full Name Display Order, SchemaName: FullNameConventionCode, IntroducedVersion: 5.0.0.0.  Description: Order in which names are to be displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? FullNameConventionCodeFormattedValue
	{
		get
		{
			return TryGetValue("fullnameconventioncode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Full Name Display Order, SchemaName: FullNameConventionCode, IntroducedVersion: 5.0.0.0.  Description: Order in which names are to be displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public int? FullNameConventionCode
	{
		get
		{
			return TryGetValue("fullnameconventioncode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("fullnameconventioncode") is false || Remove("fullnameconventioncode"))
			{
				Add("fullnameconventioncode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: fullnameconventioncode, SchemaName: FullNameConventionCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? FullNameConventionCodeName
	{
		get
		{
			return TryGetValue("fullnameconventioncodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Future Expansion Window, Format: None, MinValue: 1, MaxValue: 140, SchemaName: FutureExpansionWindow, IntroducedVersion: 5.0.0.0.  Description: Specifies the maximum number of months in future for which the recurring activities can be created.</summary>
	[JsonIgnore]
	public int? FutureExpansionWindow
	{
		get
		{
			return TryGetValue("futureexpansionwindow", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("futureexpansionwindow") is false || Remove("futureexpansionwindow"))
			{
				Add("futureexpansionwindow", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Generate Alerts For Errors, SchemaName: GenerateAlertsForErrors, IntroducedVersion: 6.0.0.0.  Description: Indicates whether alerts will be generated for errors.</summary>
	[JsonIgnore]
	public string? GenerateAlertsForErrorsFormattedValue
	{
		get
		{
			return TryGetValue("generatealertsforerrors@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Generate Alerts For Errors, SchemaName: GenerateAlertsForErrors, IntroducedVersion: 6.0.0.0.  Description: Indicates whether alerts will be generated for errors.</summary>
	[JsonIgnore]
	public bool? GenerateAlertsForErrors
	{
		get
		{
			return TryGetValue("generatealertsforerrors", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("generatealertsforerrors") is false || Remove("generatealertsforerrors"))
			{
				Add("generatealertsforerrors", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Generate Alerts For Information, SchemaName: GenerateAlertsForInformation, IntroducedVersion: 6.0.0.0.  Description: Indicates whether alerts will be generated for information.</summary>
	[JsonIgnore]
	public string? GenerateAlertsForInformationFormattedValue
	{
		get
		{
			return TryGetValue("generatealertsforinformation@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Generate Alerts For Information, SchemaName: GenerateAlertsForInformation, IntroducedVersion: 6.0.0.0.  Description: Indicates whether alerts will be generated for information.</summary>
	[JsonIgnore]
	public bool? GenerateAlertsForInformation
	{
		get
		{
			return TryGetValue("generatealertsforinformation", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("generatealertsforinformation") is false || Remove("generatealertsforinformation"))
			{
				Add("generatealertsforinformation", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Generate Alerts For Warnings, SchemaName: GenerateAlertsForWarnings, IntroducedVersion: 6.0.0.0.  Description: Indicates whether alerts will be generated for warnings.</summary>
	[JsonIgnore]
	public string? GenerateAlertsForWarningsFormattedValue
	{
		get
		{
			return TryGetValue("generatealertsforwarnings@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Generate Alerts For Warnings, SchemaName: GenerateAlertsForWarnings, IntroducedVersion: 6.0.0.0.  Description: Indicates whether alerts will be generated for warnings.</summary>
	[JsonIgnore]
	public bool? GenerateAlertsForWarnings
	{
		get
		{
			return TryGetValue("generatealertsforwarnings", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("generatealertsforwarnings") is false || Remove("generatealertsforwarnings"))
			{
				Add("generatealertsforwarnings", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Get Started Pane Content Enabled, SchemaName: GetStartedPaneContentEnabled, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Get Started content is enabled for this organization.</summary>
	[JsonIgnore]
	public string? GetStartedPaneContentEnabledFormattedValue
	{
		get
		{
			return TryGetValue("getstartedpanecontentenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Get Started Pane Content Enabled, SchemaName: GetStartedPaneContentEnabled, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Get Started content is enabled for this organization.</summary>
	[JsonIgnore]
	public bool? GetStartedPaneContentEnabled
	{
		get
		{
			return TryGetValue("getstartedpanecontentenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("getstartedpanecontentenabled") is false || Remove("getstartedpanecontentenabled"))
			{
				Add("getstartedpanecontentenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is AppendUrl Parameters enabled, SchemaName: GlobalAppendUrlParametersEnabled, IntroducedVersion: 7.0.0.0.  Description: Indicates whether the append URL parameters is enabled.</summary>
	[JsonIgnore]
	public string? GlobalAppendUrlParametersEnabledFormattedValue
	{
		get
		{
			return TryGetValue("globalappendurlparametersenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is AppendUrl Parameters enabled, SchemaName: GlobalAppendUrlParametersEnabled, IntroducedVersion: 7.0.0.0.  Description: Indicates whether the append URL parameters is enabled.</summary>
	[JsonIgnore]
	public bool? GlobalAppendUrlParametersEnabled
	{
		get
		{
			return TryGetValue("globalappendurlparametersenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("globalappendurlparametersenabled") is false || Remove("globalappendurlparametersenabled"))
			{
				Add("globalappendurlparametersenabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Global Help URL., Format: Text, MaxLength: 500, SchemaName: GlobalHelpUrl, IntroducedVersion: 7.0.0.0.  Description: URL for the web page global help.</summary>
	[JsonIgnore]
	public string? GlobalHelpUrl
	{
		get
		{
			return TryGetValue("globalhelpurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("globalhelpurl") is false || Remove("globalhelpurl"))
			{
				Add("globalhelpurl", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Customizable Global Help enabled, SchemaName: GlobalHelpUrlEnabled, IntroducedVersion: 7.0.0.0.  Description: Indicates whether the customizable global help is enabled.</summary>
	[JsonIgnore]
	public string? GlobalHelpUrlEnabledFormattedValue
	{
		get
		{
			return TryGetValue("globalhelpurlenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Customizable Global Help enabled, SchemaName: GlobalHelpUrlEnabled, IntroducedVersion: 7.0.0.0.  Description: Indicates whether the customizable global help is enabled.</summary>
	[JsonIgnore]
	public bool? GlobalHelpUrlEnabled
	{
		get
		{
			return TryGetValue("globalhelpurlenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("globalhelpurlenabled") is false || Remove("globalhelpurlenabled"))
			{
				Add("globalhelpurlenabled", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Rollup Expiration Time for Goal, Format: None, MinValue: 0, MaxValue: 400, SchemaName: GoalRollupExpiryTime, IntroducedVersion: 5.0.0.0.  Description: Number of days after the goal's end date after which the rollup of the goal stops automatically.</summary>
	[JsonIgnore]
	public int? GoalRollupExpiryTime
	{
		get
		{
			return TryGetValue("goalrollupexpirytime", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("goalrollupexpirytime") is false || Remove("goalrollupexpirytime"))
			{
				Add("goalrollupexpirytime", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Automatic Rollup Frequency for Goal, Format: None, MinValue: 1, MaxValue: 2147483647, SchemaName: GoalRollupFrequency, IntroducedVersion: 5.0.0.0.  Description: Number of hours between automatic rollup jobs .</summary>
	[JsonIgnore]
	public int? GoalRollupFrequency
	{
		get
		{
			return TryGetValue("goalrollupfrequency", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("goalrollupfrequency") is false || Remove("goalrollupfrequency"))
			{
				Add("goalrollupfrequency", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Grant Access To Network Service, SchemaName: GrantAccessToNetworkService, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? GrantAccessToNetworkServiceFormattedValue
	{
		get
		{
			return TryGetValue("grantaccesstonetworkservice@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Grant Access To Network Service, SchemaName: GrantAccessToNetworkService, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public bool? GrantAccessToNetworkService
	{
		get
		{
			return TryGetValue("grantaccesstonetworkservice", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("grantaccesstonetworkservice") is false || Remove("grantaccesstonetworkservice"))
			{
				Add("grantaccesstonetworkservice", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Hash Delta Subject Count, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: HashDeltaSubjectCount, IntroducedVersion: 5.0.0.0.  Description: Maximum difference allowed between subject keywords count of the email messaged to be correlated</summary>
	[JsonIgnore]
	public int? HashDeltaSubjectCount
	{
		get
		{
			return TryGetValue("hashdeltasubjectcount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("hashdeltasubjectcount") is false || Remove("hashdeltasubjectcount"))
			{
				Add("hashdeltasubjectcount", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Hash Filter Keywords, Format: Text, MaxLength: 1073741823, SchemaName: HashFilterKeywords, IntroducedVersion: 5.0.0.0.  Description: Filter Subject Keywords</summary>
	[JsonIgnore]
	public string? HashFilterKeywords
	{
		get
		{
			return TryGetValue("hashfilterkeywords", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("hashfilterkeywords") is false || Remove("hashfilterkeywords"))
			{
				Add("hashfilterkeywords", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Hash Max Count, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: HashMaxCount, IntroducedVersion: 5.0.0.0.  Description: Maximum number of subject keywords or recipients used for correlation</summary>
	[JsonIgnore]
	public int? HashMaxCount
	{
		get
		{
			return TryGetValue("hashmaxcount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("hashmaxcount") is false || Remove("hashmaxcount"))
			{
				Add("hashmaxcount", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Hash Min Address Count, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: HashMinAddressCount, IntroducedVersion: 5.0.0.0.  Description: Minimum number of recipients required to match for email messaged to be correlated</summary>
	[JsonIgnore]
	public int? HashMinAddressCount
	{
		get
		{
			return TryGetValue("hashminaddresscount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("hashminaddresscount") is false || Remove("hashminaddresscount"))
			{
				Add("hashminaddresscount", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: High contrast Theme Data, Format: TextArea, MaxLength: 1073741823, SchemaName: HighContrastThemeData, IntroducedVersion: 7.1.0.0.  Description: High contrast theme data for the organization.</summary>
	[JsonIgnore]
	public string? HighContrastThemeData
	{
		get
		{
			return TryGetValue("highcontrastthemedata", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("highcontrastthemedata") is false || Remove("highcontrastthemedata"))
			{
				Add("highcontrastthemedata", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Ignore Internal Email, SchemaName: IgnoreInternalEmail, IntroducedVersion: 5.0.0.0.  Description: Indicates whether incoming email sent by internal Microsoft Dynamics 365 users or queues should be tracked.</summary>
	[JsonIgnore]
	public string? IgnoreInternalEmailFormattedValue
	{
		get
		{
			return TryGetValue("ignoreinternalemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Ignore Internal Email, SchemaName: IgnoreInternalEmail, IntroducedVersion: 5.0.0.0.  Description: Indicates whether incoming email sent by internal Microsoft Dynamics 365 users or queues should be tracked.</summary>
	[JsonIgnore]
	public bool? IgnoreInternalEmail
	{
		get
		{
			return TryGetValue("ignoreinternalemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ignoreinternalemail") is false || Remove("ignoreinternalemail"))
			{
				Add("ignoreinternalemail", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Share search query data, SchemaName: ImproveSearchLoggingEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether an organization has consented to sharing search query data to help improve search results</summary>
	[JsonIgnore]
	public string? ImproveSearchLoggingEnabledFormattedValue
	{
		get
		{
			return TryGetValue("improvesearchloggingenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Share search query data, SchemaName: ImproveSearchLoggingEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether an organization has consented to sharing search query data to help improve search results</summary>
	[JsonIgnore]
	public bool? ImproveSearchLoggingEnabled
	{
		get
		{
			return TryGetValue("improvesearchloggingenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("improvesearchloggingenabled") is false || Remove("improvesearchloggingenabled"))
			{
				Add("improvesearchloggingenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: improvesearchloggingenabled, SchemaName: improvesearchloggingenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? improvesearchloggingenabledName
	{
		get
		{
			return TryGetValue("improvesearchloggingenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Inactivity timeout enabled, SchemaName: InactivityTimeoutEnabled, IntroducedVersion: 8.2.0.0.  Description: Information that specifies whether Inactivity timeout is enabled</summary>
	[JsonIgnore]
	public string? InactivityTimeoutEnabledFormattedValue
	{
		get
		{
			return TryGetValue("inactivitytimeoutenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Inactivity timeout enabled, SchemaName: InactivityTimeoutEnabled, IntroducedVersion: 8.2.0.0.  Description: Information that specifies whether Inactivity timeout is enabled</summary>
	[JsonIgnore]
	public bool? InactivityTimeoutEnabled
	{
		get
		{
			return TryGetValue("inactivitytimeoutenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("inactivitytimeoutenabled") is false || Remove("inactivitytimeoutenabled"))
			{
				Add("inactivitytimeoutenabled", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Inactivity timeout in minutes, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: InactivityTimeoutInMins, IntroducedVersion: 8.2.0.0.  Description: Inactivity timeout in minutes</summary>
	[JsonIgnore]
	public int? InactivityTimeoutInMins
	{
		get
		{
			return TryGetValue("inactivitytimeoutinmins", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("inactivitytimeoutinmins") is false || Remove("inactivitytimeoutinmins"))
			{
				Add("inactivitytimeoutinmins", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Inactivity timeout reminder in minutes, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: InactivityTimeoutReminderInMins, IntroducedVersion: 8.2.0.0.  Description: Inactivity timeout reminder in minutes</summary>
	[JsonIgnore]
	public int? InactivityTimeoutReminderInMins
	{
		get
		{
			return TryGetValue("inactivitytimeoutreminderinmins", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("inactivitytimeoutreminderinmins") is false || Remove("inactivitytimeoutreminderinmins"))
			{
				Add("inactivitytimeoutreminderinmins", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Exchange Email Retrieval Batch Size, Format: None, MinValue: 1, MaxValue: 2147483647, SchemaName: IncomingEmailExchangeEmailRetrievalBatchSize, IntroducedVersion: 6.0.0.0.  Description: Setting for the Async Service Mailbox Queue. Defines the retrieval batch size of exchange server.</summary>
	[JsonIgnore]
	public int? IncomingEmailExchangeEmailRetrievalBatchSize
	{
		get
		{
			return TryGetValue("incomingemailexchangeemailretrievalbatchsize", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("incomingemailexchangeemailretrievalbatchsize") is false || Remove("incomingemailexchangeemailretrievalbatchsize"))
			{
				Add("incomingemailexchangeemailretrievalbatchsize", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Initial Version, Format: Text, MaxLength: 20, SchemaName: InitialVersion, IntroducedVersion: 5.0.0.0.  Description: Initial version of the organization.</summary>
	[JsonIgnore]
	public string? InitialVersion
	{
		get
		{
			return TryGetValue("initialversion", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("initialversion") is false || Remove("initialversion"))
			{
				Add("initialversion", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Integration User, SchemaName: IntegrationUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the integration user for the organization.</summary>
	[JsonIgnore]
	public Guid? IntegrationUserId
	{
		get
		{
			return TryGetValue("integrationuserid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("integrationuserid") is false || Remove("integrationuserid"))
			{
				Add("integrationuserid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Invoice Prefix, Format: Text, MaxLength: 20, SchemaName: InvoicePrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix to use for all invoice numbers throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? InvoicePrefix
	{
		get
		{
			return TryGetValue("invoiceprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("invoiceprefix") is false || Remove("invoiceprefix"))
			{
				Add("invoiceprefix", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: IP Based SAS mode, SchemaName: IpBasedStorageAccessSignatureMode, IntroducedVersion: 1.0.0.5.  Description: IP Based SAS mode.</summary>
	[JsonIgnore]
	public string? IpBasedStorageAccessSignatureModeFormattedValue
	{
		get
		{
			return TryGetValue("ipbasedstorageaccesssignaturemode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: IP Based SAS mode, SchemaName: IpBasedStorageAccessSignatureMode, IntroducedVersion: 1.0.0.5.  Description: IP Based SAS mode.</summary>
	[JsonIgnore]
	public int? IpBasedStorageAccessSignatureMode
	{
		get
		{
			return TryGetValue("ipbasedstorageaccesssignaturemode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ipbasedstorageaccesssignaturemode") is false || Remove("ipbasedstorageaccesssignaturemode"))
			{
				Add("ipbasedstorageaccesssignaturemode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ipbasedstorageaccesssignaturemode, SchemaName: ipbasedstorageaccesssignaturemodeName, IntroducedVersion: 1.0.0.5. </summary>
	[JsonIgnore]
	public object? ipbasedstorageaccesssignaturemodeName
	{
		get
		{
			return TryGetValue("ipbasedstorageaccesssignaturemodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Action Card for this Organization, SchemaName: IsActionCardEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Action Card should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsActionCardEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isactioncardenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Action Card for this Organization, SchemaName: IsActionCardEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Action Card should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsActionCardEnabled
	{
		get
		{
			return TryGetValue("isactioncardenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isactioncardenabled") is false || Remove("isactioncardenabled"))
			{
				Add("isactioncardenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Action Support Feature enabled, SchemaName: IsActionSupportFeatureEnabled, IntroducedVersion: 9.0.0.0.  Description: Information that specifies whether Action Support Feature is enabled</summary>
	[JsonIgnore]
	public string? IsActionSupportFeatureEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isactionsupportfeatureenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Action Support Feature enabled, SchemaName: IsActionSupportFeatureEnabled, IntroducedVersion: 9.0.0.0.  Description: Information that specifies whether Action Support Feature is enabled</summary>
	[JsonIgnore]
	public bool? IsActionSupportFeatureEnabled
	{
		get
		{
			return TryGetValue("isactionsupportfeatureenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isactionsupportfeatureenabled") is false || Remove("isactionsupportfeatureenabled"))
			{
				Add("isactionsupportfeatureenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Relationship Analytics for this Organization, SchemaName: IsActivityAnalysisEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Relationship Analytics should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsActivityAnalysisEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isactivityanalysisenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Relationship Analytics for this Organization, SchemaName: IsActivityAnalysisEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Relationship Analytics should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsActivityAnalysisEnabled
	{
		get
		{
			return TryGetValue("isactivityanalysisenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isactivityanalysisenabled") is false || Remove("isactivityanalysisenabled"))
			{
				Add("isactivityanalysisenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Set if all money attributes are converted to decimal, SchemaName: IsAllMoneyDecimal, IntroducedVersion: 9.1.0.0.  Description: Indicates whether all money attributes are converted to decimal.</summary>
	[JsonIgnore]
	public string? IsAllMoneyDecimalFormattedValue
	{
		get
		{
			return TryGetValue("isallmoneydecimal@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Set if all money attributes are converted to decimal, SchemaName: IsAllMoneyDecimal, IntroducedVersion: 9.1.0.0.  Description: Indicates whether all money attributes are converted to decimal.</summary>
	[JsonIgnore]
	public bool? IsAllMoneyDecimal
	{
		get
		{
			return TryGetValue("isallmoneydecimal", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isallmoneydecimal") is false || Remove("isallmoneydecimal"))
			{
				Add("isallmoneydecimal", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Application Mode Enabled, SchemaName: IsAppMode, IntroducedVersion: 5.0.0.0.  Description: Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.</summary>
	[JsonIgnore]
	public string? IsAppModeFormattedValue
	{
		get
		{
			return TryGetValue("isappmode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Application Mode Enabled, SchemaName: IsAppMode, IntroducedVersion: 5.0.0.0.  Description: Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.</summary>
	[JsonIgnore]
	public bool? IsAppMode
	{
		get
		{
			return TryGetValue("isappmode", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isappmode") is false || Remove("isappmode"))
			{
				Add("isappmode", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Attachment Sync Enabled, SchemaName: IsAppointmentAttachmentSyncEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable attachments sync for outlook and exchange.</summary>
	[JsonIgnore]
	public string? IsAppointmentAttachmentSyncEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isappointmentattachmentsyncenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Attachment Sync Enabled, SchemaName: IsAppointmentAttachmentSyncEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable attachments sync for outlook and exchange.</summary>
	[JsonIgnore]
	public bool? IsAppointmentAttachmentSyncEnabled
	{
		get
		{
			return TryGetValue("isappointmentattachmentsyncenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isappointmentattachmentsyncenabled") is false || Remove("isappointmentattachmentsyncenabled"))
			{
				Add("isappointmentattachmentsyncenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Assigned Tasks Sync Enabled, SchemaName: IsAssignedTasksSyncEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable assigned tasks sync for outlook and exchange.</summary>
	[JsonIgnore]
	public string? IsAssignedTasksSyncEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isassignedtaskssyncenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Assigned Tasks Sync Enabled, SchemaName: IsAssignedTasksSyncEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable assigned tasks sync for outlook and exchange.</summary>
	[JsonIgnore]
	public bool? IsAssignedTasksSyncEnabled
	{
		get
		{
			return TryGetValue("isassignedtaskssyncenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isassignedtaskssyncenabled") is false || Remove("isassignedtaskssyncenabled"))
			{
				Add("isassignedtaskssyncenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Auditing Enabled, SchemaName: IsAuditEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable or disable auditing of changes.</summary>
	[JsonIgnore]
	public string? IsAuditEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isauditenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Auditing Enabled, SchemaName: IsAuditEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable or disable auditing of changes.</summary>
	[JsonIgnore]
	public bool? IsAuditEnabled
	{
		get
		{
			return TryGetValue("isauditenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isauditenabled") is false || Remove("isauditenabled"))
			{
				Add("isauditenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Auto Capture for this Organization, SchemaName: IsAutoDataCaptureEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Auto Capture should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsAutoDataCaptureEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isautodatacaptureenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Auto Capture for this Organization, SchemaName: IsAutoDataCaptureEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Auto Capture should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsAutoDataCaptureEnabled
	{
		get
		{
			return TryGetValue("isautodatacaptureenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isautodatacaptureenabled") is false || Remove("isautodatacaptureenabled"))
			{
				Add("isautodatacaptureenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Auto Capture V2 for this Organization, SchemaName: IsAutoDataCaptureV2Enabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the V2 feature of Auto Capture should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsAutoDataCaptureV2EnabledFormattedValue
	{
		get
		{
			return TryGetValue("isautodatacapturev2enabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Auto Capture V2 for this Organization, SchemaName: IsAutoDataCaptureV2Enabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the V2 feature of Auto Capture should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsAutoDataCaptureV2Enabled
	{
		get
		{
			return TryGetValue("isautodatacapturev2enabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isautodatacapturev2enabled") is false || Remove("isautodatacapturev2enabled"))
			{
				Add("isautodatacapturev2enabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsAutoInstallAppForD365InTeamsEnabled, SchemaName: IsAutoInstallAppForD365InTeamsEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public string? IsAutoInstallAppForD365InTeamsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isautoinstallappford365inteamsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsAutoInstallAppForD365InTeamsEnabled, SchemaName: IsAutoInstallAppForD365InTeamsEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public bool? IsAutoInstallAppForD365InTeamsEnabled
	{
		get
		{
			return TryGetValue("isautoinstallappford365inteamsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isautoinstallappford365inteamsenabled") is false || Remove("isautoinstallappford365inteamsenabled"))
			{
				Add("isautoinstallappford365inteamsenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isautoinstallappford365inteamsenabled, SchemaName: isautoinstallappford365inteamsenabledName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? isautoinstallappford365inteamsenabledName
	{
		get
		{
			return TryGetValue("isautoinstallappford365inteamsenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Auto Save Enabled, SchemaName: IsAutoSaveEnabled, IntroducedVersion: 6.0.0.0.  Description: Information on whether auto save is enabled.</summary>
	[JsonIgnore]
	public string? IsAutoSaveEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isautosaveenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Auto Save Enabled, SchemaName: IsAutoSaveEnabled, IntroducedVersion: 6.0.0.0.  Description: Information on whether auto save is enabled.</summary>
	[JsonIgnore]
	public bool? IsAutoSaveEnabled
	{
		get
		{
			return TryGetValue("isautosaveenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isautosaveenabled") is false || Remove("isautosaveenabled"))
			{
				Add("isautosaveenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsBaseCardStaticFieldDataEnabled, SchemaName: IsBaseCardStaticFieldDataEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public string? IsBaseCardStaticFieldDataEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isbasecardstaticfielddataenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsBaseCardStaticFieldDataEnabled, SchemaName: IsBaseCardStaticFieldDataEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public bool? IsBaseCardStaticFieldDataEnabled
	{
		get
		{
			return TryGetValue("isbasecardstaticfielddataenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isbasecardstaticfielddataenabled") is false || Remove("isbasecardstaticfielddataenabled"))
			{
				Add("isbasecardstaticfielddataenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isbasecardstaticfielddataenabled, SchemaName: isbasecardstaticfielddataenabledName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? isbasecardstaticfielddataenabledName
	{
		get
		{
			return TryGetValue("isbasecardstaticfielddataenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the basic Geospatial features in Canvas Apps, SchemaName: IsBasicGeospatialIntegrationEnabled, IntroducedVersion: 9.1.0.0.  Description: Determines whether users can make use of basic Geospatial featuers in Canvas apps.</summary>
	[JsonIgnore]
	public string? IsBasicGeospatialIntegrationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isbasicgeospatialintegrationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the basic Geospatial features in Canvas Apps, SchemaName: IsBasicGeospatialIntegrationEnabled, IntroducedVersion: 9.1.0.0.  Description: Determines whether users can make use of basic Geospatial featuers in Canvas apps.</summary>
	[JsonIgnore]
	public bool? IsBasicGeospatialIntegrationEnabled
	{
		get
		{
			return TryGetValue("isbasicgeospatialintegrationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isbasicgeospatialintegrationenabled") is false || Remove("isbasicgeospatialintegrationenabled"))
			{
				Add("isbasicgeospatialintegrationenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isbasicgeospatialintegrationenabled, SchemaName: isbasicgeospatialintegrationenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? isbasicgeospatialintegrationenabledName
	{
		get
		{
			return TryGetValue("isbasicgeospatialintegrationenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: BPF Entity Customization Feature enabled, SchemaName: IsBPFEntityCustomizationFeatureEnabled, IntroducedVersion: 9.0.0.0.  Description: Information that specifies whether BPF Entity Customization Feature is enabled</summary>
	[JsonIgnore]
	public string? IsBPFEntityCustomizationFeatureEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isbpfentitycustomizationfeatureenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: BPF Entity Customization Feature enabled, SchemaName: IsBPFEntityCustomizationFeatureEnabled, IntroducedVersion: 9.0.0.0.  Description: Information that specifies whether BPF Entity Customization Feature is enabled</summary>
	[JsonIgnore]
	public bool? IsBPFEntityCustomizationFeatureEnabled
	{
		get
		{
			return TryGetValue("isbpfentitycustomizationfeatureenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isbpfentitycustomizationfeatureenabled") is false || Remove("isbpfentitycustomizationfeatureenabled"))
			{
				Add("isbpfentitycustomizationfeatureenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsCollaborationExperienceEnabled, SchemaName: IsCollaborationExperienceEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public string? IsCollaborationExperienceEnabledFormattedValue
	{
		get
		{
			return TryGetValue("iscollaborationexperienceenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsCollaborationExperienceEnabled, SchemaName: IsCollaborationExperienceEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public bool? IsCollaborationExperienceEnabled
	{
		get
		{
			return TryGetValue("iscollaborationexperienceenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscollaborationexperienceenabled") is false || Remove("iscollaborationexperienceenabled"))
			{
				Add("iscollaborationexperienceenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: iscollaborationexperienceenabled, SchemaName: iscollaborationexperienceenabledName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? iscollaborationexperienceenabledName
	{
		get
		{
			return TryGetValue("iscollaborationexperienceenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Conflict Detection for Mobile Client enabled, SchemaName: IsConflictDetectionEnabledForMobileClient, IntroducedVersion: 8.1.0.0.  Description: Information that specifies whether conflict detection for mobile client is enabled.</summary>
	[JsonIgnore]
	public string? IsConflictDetectionEnabledForMobileClientFormattedValue
	{
		get
		{
			return TryGetValue("isconflictdetectionenabledformobileclient@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Conflict Detection for Mobile Client enabled, SchemaName: IsConflictDetectionEnabledForMobileClient, IntroducedVersion: 8.1.0.0.  Description: Information that specifies whether conflict detection for mobile client is enabled.</summary>
	[JsonIgnore]
	public bool? IsConflictDetectionEnabledForMobileClient
	{
		get
		{
			return TryGetValue("isconflictdetectionenabledformobileclient", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isconflictdetectionenabledformobileclient") is false || Remove("isconflictdetectionenabledformobileclient"))
			{
				Add("isconflictdetectionenabledformobileclient", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mailing Address Sync Enabled, SchemaName: IsContactMailingAddressSyncEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable mailing address sync for outlook and exchange.</summary>
	[JsonIgnore]
	public string? IsContactMailingAddressSyncEnabledFormattedValue
	{
		get
		{
			return TryGetValue("iscontactmailingaddresssyncenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mailing Address Sync Enabled, SchemaName: IsContactMailingAddressSyncEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable mailing address sync for outlook and exchange.</summary>
	[JsonIgnore]
	public bool? IsContactMailingAddressSyncEnabled
	{
		get
		{
			return TryGetValue("iscontactmailingaddresssyncenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscontactmailingaddresssyncenabled") is false || Remove("iscontactmailingaddresssyncenabled"))
			{
				Add("iscontactmailingaddresssyncenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Content Security Policy for this organization, SchemaName: IsContentSecurityPolicyEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Content Security Policy has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsContentSecurityPolicyEnabledFormattedValue
	{
		get
		{
			return TryGetValue("iscontentsecuritypolicyenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Content Security Policy for this organization, SchemaName: IsContentSecurityPolicyEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Content Security Policy has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsContentSecurityPolicyEnabled
	{
		get
		{
			return TryGetValue("iscontentsecuritypolicyenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscontentsecuritypolicyenabled") is false || Remove("iscontentsecuritypolicyenabled"))
			{
				Add("iscontentsecuritypolicyenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Content Security Policy for this organization's Canvas apps, SchemaName: IsContentSecurityPolicyEnabledForCanvas, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Content Security Policy has been enabled for this organization's Canvas apps.</summary>
	[JsonIgnore]
	public string? IsContentSecurityPolicyEnabledForCanvasFormattedValue
	{
		get
		{
			return TryGetValue("iscontentsecuritypolicyenabledforcanvas@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Content Security Policy for this organization's Canvas apps, SchemaName: IsContentSecurityPolicyEnabledForCanvas, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Content Security Policy has been enabled for this organization's Canvas apps.</summary>
	[JsonIgnore]
	public bool? IsContentSecurityPolicyEnabledForCanvas
	{
		get
		{
			return TryGetValue("iscontentsecuritypolicyenabledforcanvas", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscontentsecuritypolicyenabledforcanvas") is false || Remove("iscontentsecuritypolicyenabledforcanvas"))
			{
				Add("iscontentsecuritypolicyenabledforcanvas", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: iscontentsecuritypolicyenabledforcanvas, SchemaName: iscontentsecuritypolicyenabledforcanvasName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? iscontentsecuritypolicyenabledforcanvasName
	{
		get
		{
			return TryGetValue("iscontentsecuritypolicyenabledforcanvasname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Contextual email experience is enabled on this organization, SchemaName: IsContextualEmailEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Contextual email experience is enabled on this organization</summary>
	[JsonIgnore]
	public string? IsContextualEmailEnabledFormattedValue
	{
		get
		{
			return TryGetValue("iscontextualemailenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Contextual email experience is enabled on this organization, SchemaName: IsContextualEmailEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Contextual email experience is enabled on this organization</summary>
	[JsonIgnore]
	public bool? IsContextualEmailEnabled
	{
		get
		{
			return TryGetValue("iscontextualemailenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscontextualemailenabled") is false || Remove("iscontextualemailenabled"))
			{
				Add("iscontextualemailenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enables Contextual Help in UCI, SchemaName: IsContextualHelpEnabled, IntroducedVersion: 9.1.0.0.  Description: Select to enable Contextual Help in UCI.</summary>
	[JsonIgnore]
	public string? IsContextualHelpEnabledFormattedValue
	{
		get
		{
			return TryGetValue("iscontextualhelpenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enables Contextual Help in UCI, SchemaName: IsContextualHelpEnabled, IntroducedVersion: 9.1.0.0.  Description: Select to enable Contextual Help in UCI.</summary>
	[JsonIgnore]
	public bool? IsContextualHelpEnabled
	{
		get
		{
			return TryGetValue("iscontextualhelpenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscontextualhelpenabled") is false || Remove("iscontextualhelpenabled"))
			{
				Add("iscontextualhelpenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow users to provide feedback to improve Copilot experiences, SchemaName: IsCopilotFeedbackEnabled, IntroducedVersion: 9.2.0.0.  Description: Determines whether users can provide feedback Copilot experiences.</summary>
	[JsonIgnore]
	public string? IsCopilotFeedbackEnabledFormattedValue
	{
		get
		{
			return TryGetValue("iscopilotfeedbackenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow users to provide feedback to improve Copilot experiences, SchemaName: IsCopilotFeedbackEnabled, IntroducedVersion: 9.2.0.0.  Description: Determines whether users can provide feedback Copilot experiences.</summary>
	[JsonIgnore]
	public bool? IsCopilotFeedbackEnabled
	{
		get
		{
			return TryGetValue("iscopilotfeedbackenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscopilotfeedbackenabled") is false || Remove("iscopilotfeedbackenabled"))
			{
				Add("iscopilotfeedbackenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: iscopilotfeedbackenabled, SchemaName: iscopilotfeedbackenabledName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? iscopilotfeedbackenabledName
	{
		get
		{
			return TryGetValue("iscopilotfeedbackenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Custom Controls in canvas PowerApps feature for this organization, SchemaName: IsCustomControlsInCanvasAppsEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Custom Controls in canvas PowerApps feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsCustomControlsInCanvasAppsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("iscustomcontrolsincanvasappsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Custom Controls in canvas PowerApps feature for this organization, SchemaName: IsCustomControlsInCanvasAppsEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Custom Controls in canvas PowerApps feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsCustomControlsInCanvasAppsEnabled
	{
		get
		{
			return TryGetValue("iscustomcontrolsincanvasappsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iscustomcontrolsincanvasappsenabled") is false || Remove("iscustomcontrolsincanvasappsenabled"))
			{
				Add("iscustomcontrolsincanvasappsenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable or disable country code selection, SchemaName: IsDefaultCountryCodeCheckEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable or disable country code selection.</summary>
	[JsonIgnore]
	public string? IsDefaultCountryCodeCheckEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isdefaultcountrycodecheckenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable or disable country code selection, SchemaName: IsDefaultCountryCodeCheckEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable or disable country code selection.</summary>
	[JsonIgnore]
	public bool? IsDefaultCountryCodeCheckEnabled
	{
		get
		{
			return TryGetValue("isdefaultcountrycodecheckenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdefaultcountrycodecheckenabled") is false || Remove("isdefaultcountrycodecheckenabled"))
			{
				Add("isdefaultcountrycodecheckenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Delegation Access Enabled, SchemaName: IsDelegateAccessEnabled, IntroducedVersion: 7.0.1.0.  Description: Enable Delegation Access content</summary>
	[JsonIgnore]
	public string? IsDelegateAccessEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isdelegateaccessenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Delegation Access Enabled, SchemaName: IsDelegateAccessEnabled, IntroducedVersion: 7.0.1.0.  Description: Enable Delegation Access content</summary>
	[JsonIgnore]
	public bool? IsDelegateAccessEnabled
	{
		get
		{
			return TryGetValue("isdelegateaccessenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdelegateaccessenabled") is false || Remove("isdelegateaccessenabled"))
			{
				Add("isdelegateaccessenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Action Hub for this Organization, SchemaName: IsDelveActionHubIntegrationEnabled, IntroducedVersion: 8.1.0.0.  Description: Indicates whether the feature Action Hub should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsDelveActionHubIntegrationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isdelveactionhubintegrationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Action Hub for this Organization, SchemaName: IsDelveActionHubIntegrationEnabled, IntroducedVersion: 8.1.0.0.  Description: Indicates whether the feature Action Hub should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsDelveActionHubIntegrationEnabled
	{
		get
		{
			return TryGetValue("isdelveactionhubintegrationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdelveactionhubintegrationenabled") is false || Remove("isdelveactionhubintegrationenabled"))
			{
				Add("isdelveactionhubintegrationenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable connection embedding in Desktop Flows for this organization, SchemaName: IsDesktopFlowConnectionEmbeddingEnabled, IntroducedVersion: 1.8.9.0.  Description: Indicates whether connection embedding in Desktop Flows is enabled in this organization.</summary>
	[JsonIgnore]
	public string? IsDesktopFlowConnectionEmbeddingEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isdesktopflowconnectionembeddingenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable connection embedding in Desktop Flows for this organization, SchemaName: IsDesktopFlowConnectionEmbeddingEnabled, IntroducedVersion: 1.8.9.0.  Description: Indicates whether connection embedding in Desktop Flows is enabled in this organization.</summary>
	[JsonIgnore]
	public bool? IsDesktopFlowConnectionEmbeddingEnabled
	{
		get
		{
			return TryGetValue("isdesktopflowconnectionembeddingenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdesktopflowconnectionembeddingenabled") is false || Remove("isdesktopflowconnectionembeddingenabled"))
			{
				Add("isdesktopflowconnectionembeddingenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdesktopflowconnectionembeddingenabled, SchemaName: isdesktopflowconnectionembeddingenabledName, IntroducedVersion: 1.8.9.0. </summary>
	[JsonIgnore]
	public object? isdesktopflowconnectionembeddingenabledName
	{
		get
		{
			return TryGetValue("isdesktopflowconnectionembeddingenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the Desktop Flows UI Automation Runtime Repair for Attended feature for this organization, SchemaName: IsDesktopFlowRuntimeRepairAttendedEnabled, IntroducedVersion: 1.8.6.0.  Description: Indicates whether the Desktop Flows UI Automation Runtime Repair for Attended feature for this organization.</summary>
	[JsonIgnore]
	public string? IsDesktopFlowRuntimeRepairAttendedEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isdesktopflowruntimerepairattendedenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the Desktop Flows UI Automation Runtime Repair for Attended feature for this organization, SchemaName: IsDesktopFlowRuntimeRepairAttendedEnabled, IntroducedVersion: 1.8.6.0.  Description: Indicates whether the Desktop Flows UI Automation Runtime Repair for Attended feature for this organization.</summary>
	[JsonIgnore]
	public bool? IsDesktopFlowRuntimeRepairAttendedEnabled
	{
		get
		{
			return TryGetValue("isdesktopflowruntimerepairattendedenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdesktopflowruntimerepairattendedenabled") is false || Remove("isdesktopflowruntimerepairattendedenabled"))
			{
				Add("isdesktopflowruntimerepairattendedenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdesktopflowruntimerepairattendedenabled, SchemaName: isdesktopflowruntimerepairattendedenabledName, IntroducedVersion: 1.8.6.0. </summary>
	[JsonIgnore]
	public object? isdesktopflowruntimerepairattendedenabledName
	{
		get
		{
			return TryGetValue("isdesktopflowruntimerepairattendedenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the Desktop Flows UI Automation Runtime Repair for Unattended feature for this organization, SchemaName: IsDesktopFlowRuntimeRepairUnattendedEnabled, IntroducedVersion: 1.8.6.0.  Description: Indicates whether the Desktop Flows UI Automation Runtime Repair for Unattended feature for this organization.</summary>
	[JsonIgnore]
	public string? IsDesktopFlowRuntimeRepairUnattendedEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isdesktopflowruntimerepairunattendedenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the Desktop Flows UI Automation Runtime Repair for Unattended feature for this organization, SchemaName: IsDesktopFlowRuntimeRepairUnattendedEnabled, IntroducedVersion: 1.8.6.0.  Description: Indicates whether the Desktop Flows UI Automation Runtime Repair for Unattended feature for this organization.</summary>
	[JsonIgnore]
	public bool? IsDesktopFlowRuntimeRepairUnattendedEnabled
	{
		get
		{
			return TryGetValue("isdesktopflowruntimerepairunattendedenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdesktopflowruntimerepairunattendedenabled") is false || Remove("isdesktopflowruntimerepairunattendedenabled"))
			{
				Add("isdesktopflowruntimerepairunattendedenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdesktopflowruntimerepairunattendedenabled, SchemaName: isdesktopflowruntimerepairunattendedenabledName, IntroducedVersion: 1.8.6.0. </summary>
	[JsonIgnore]
	public object? isdesktopflowruntimerepairunattendedenabledName
	{
		get
		{
			return TryGetValue("isdesktopflowruntimerepairunattendedenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable v2 schema for Desktop Flows in this organization., SchemaName: IsDesktopFlowSchemaV2Enabled, IntroducedVersion: 1.3.1.0.  Description: Indicates whether v2 schema for Desktop Flows is enabled in this organization.</summary>
	[JsonIgnore]
	public string? IsDesktopFlowSchemaV2EnabledFormattedValue
	{
		get
		{
			return TryGetValue("isdesktopflowschemav2enabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable v2 schema for Desktop Flows in this organization., SchemaName: IsDesktopFlowSchemaV2Enabled, IntroducedVersion: 1.3.1.0.  Description: Indicates whether v2 schema for Desktop Flows is enabled in this organization.</summary>
	[JsonIgnore]
	public bool? IsDesktopFlowSchemaV2Enabled
	{
		get
		{
			return TryGetValue("isdesktopflowschemav2enabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdesktopflowschemav2enabled") is false || Remove("isdesktopflowschemav2enabled"))
			{
				Add("isdesktopflowschemav2enabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdesktopflowschemav2enabled, SchemaName: isdesktopflowschemav2enabledName, IntroducedVersion: 1.3.1.0. </summary>
	[JsonIgnore]
	public object? isdesktopflowschemav2enabledName
	{
		get
		{
			return TryGetValue("isdesktopflowschemav2enabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Organization Disabled, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether the organization is disabled.</summary>
	[JsonIgnore]
	public string? IsDisabledFormattedValue
	{
		get
		{
			return TryGetValue("isdisabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Organization Disabled, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether the organization is disabled.</summary>
	[JsonIgnore]
	public bool? IsDisabled
	{
		get
		{
			return TryGetValue("isdisabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdisabled") is false || Remove("isdisabled"))
			{
				Add("isdisabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdisabled, SchemaName: IsDisabledName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsDisabledName
	{
		get
		{
			return TryGetValue("isdisabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled, SchemaName: IsDuplicateDetectionEnabled, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection of records is enabled.</summary>
	[JsonIgnore]
	public string? IsDuplicateDetectionEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled, SchemaName: IsDuplicateDetectionEnabled, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection of records is enabled.</summary>
	[JsonIgnore]
	public bool? IsDuplicateDetectionEnabled
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isduplicatedetectionenabled") is false || Remove("isduplicatedetectionenabled"))
			{
				Add("isduplicatedetectionenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled For Import, SchemaName: IsDuplicateDetectionEnabledForImport, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection of records during import is enabled.</summary>
	[JsonIgnore]
	public string? IsDuplicateDetectionEnabledForImportFormattedValue
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabledforimport@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled For Import, SchemaName: IsDuplicateDetectionEnabledForImport, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection of records during import is enabled.</summary>
	[JsonIgnore]
	public bool? IsDuplicateDetectionEnabledForImport
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabledforimport", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isduplicatedetectionenabledforimport") is false || Remove("isduplicatedetectionenabledforimport"))
			{
				Add("isduplicatedetectionenabledforimport", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled For Offline Synchronization, SchemaName: IsDuplicateDetectionEnabledForOfflineSync, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection of records during offline synchronization is enabled.</summary>
	[JsonIgnore]
	public string? IsDuplicateDetectionEnabledForOfflineSyncFormattedValue
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabledforofflinesync@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled For Offline Synchronization, SchemaName: IsDuplicateDetectionEnabledForOfflineSync, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection of records during offline synchronization is enabled.</summary>
	[JsonIgnore]
	public bool? IsDuplicateDetectionEnabledForOfflineSync
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabledforofflinesync", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isduplicatedetectionenabledforofflinesync") is false || Remove("isduplicatedetectionenabledforofflinesync"))
			{
				Add("isduplicatedetectionenabledforofflinesync", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled for Online Create/Update, SchemaName: IsDuplicateDetectionEnabledForOnlineCreateUpdate, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection during online create or update is enabled.</summary>
	[JsonIgnore]
	public string? IsDuplicateDetectionEnabledForOnlineCreateUpdateFormattedValue
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabledforonlinecreateupdate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Duplicate Detection Enabled for Online Create/Update, SchemaName: IsDuplicateDetectionEnabledForOnlineCreateUpdate, IntroducedVersion: 5.0.0.0.  Description: Indicates whether duplicate detection during online create or update is enabled.</summary>
	[JsonIgnore]
	public bool? IsDuplicateDetectionEnabledForOnlineCreateUpdate
	{
		get
		{
			return TryGetValue("isduplicatedetectionenabledforonlinecreateupdate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isduplicatedetectionenabledforonlinecreateupdate") is false || Remove("isduplicatedetectionenabledforonlinecreateupdate"))
			{
				Add("isduplicatedetectionenabledforonlinecreateupdate", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Smart Email Address Validation., SchemaName: IsEmailAddressValidationEnabled, IntroducedVersion: 9.2.0.0.  Description: Information on whether Smart Email Address Validation is enabled.</summary>
	[JsonIgnore]
	public string? IsEmailAddressValidationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isemailaddressvalidationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Smart Email Address Validation., SchemaName: IsEmailAddressValidationEnabled, IntroducedVersion: 9.2.0.0.  Description: Information on whether Smart Email Address Validation is enabled.</summary>
	[JsonIgnore]
	public bool? IsEmailAddressValidationEnabled
	{
		get
		{
			return TryGetValue("isemailaddressvalidationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isemailaddressvalidationenabled") is false || Remove("isemailaddressvalidationenabled"))
			{
				Add("isemailaddressvalidationenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isemailaddressvalidationenabled, SchemaName: isemailaddressvalidationenabledName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? isemailaddressvalidationenabledName
	{
		get
		{
			return TryGetValue("isemailaddressvalidationenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow tracking recipient activity on sent emails, SchemaName: IsEmailMonitoringAllowed, IntroducedVersion: 8.2.0.0.  Description: Allow tracking recipient activity on sent emails.</summary>
	[JsonIgnore]
	public string? IsEmailMonitoringAllowedFormattedValue
	{
		get
		{
			return TryGetValue("isemailmonitoringallowed@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow tracking recipient activity on sent emails, SchemaName: IsEmailMonitoringAllowed, IntroducedVersion: 8.2.0.0.  Description: Allow tracking recipient activity on sent emails.</summary>
	[JsonIgnore]
	public bool? IsEmailMonitoringAllowed
	{
		get
		{
			return TryGetValue("isemailmonitoringallowed", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isemailmonitoringallowed") is false || Remove("isemailmonitoringallowed"))
			{
				Add("isemailmonitoringallowed", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Email Server Profile Content Filtering Enabled, SchemaName: IsEmailServerProfileContentFilteringEnabled, IntroducedVersion: 6.1.0.0.  Description: Enable Email Server Profile content filtering</summary>
	[JsonIgnore]
	public string? IsEmailServerProfileContentFilteringEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isemailserverprofilecontentfilteringenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Email Server Profile Content Filtering Enabled, SchemaName: IsEmailServerProfileContentFilteringEnabled, IntroducedVersion: 6.1.0.0.  Description: Enable Email Server Profile content filtering</summary>
	[JsonIgnore]
	public bool? IsEmailServerProfileContentFilteringEnabled
	{
		get
		{
			return TryGetValue("isemailserverprofilecontentfilteringenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isemailserverprofilecontentfilteringenabled") is false || Remove("isemailserverprofilecontentfilteringenabled"))
			{
				Add("isemailserverprofilecontentfilteringenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether embed Teams collaboration has been enabled for the organization, SchemaName: IsEmbedTeamsCollabEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether embed Teams collaboration has been enabled for the organization</summary>
	[JsonIgnore]
	public string? IsEmbedTeamsCollabEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isembedteamscollabenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether embed Teams collaboration has been enabled for the organization, SchemaName: IsEmbedTeamsCollabEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether embed Teams collaboration has been enabled for the organization</summary>
	[JsonIgnore]
	public bool? IsEmbedTeamsCollabEnabled
	{
		get
		{
			return TryGetValue("isembedteamscollabenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isembedteamscollabenabled") is false || Remove("isembedteamscollabenabled"))
			{
				Add("isembedteamscollabenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isembedteamscollabenabled, SchemaName: isembedteamscollabenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? isembedteamscollabenabledName
	{
		get
		{
			return TryGetValue("isembedteamscollabenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: option set values for isenabledforallroles, SchemaName: IsEnabledForAllRoles, IntroducedVersion: 8.2.0.0.  Description: Indicates whether appmodule is enabled for all roles</summary>
	[JsonIgnore]
	public string? IsEnabledForAllRolesFormattedValue
	{
		get
		{
			return TryGetValue("isenabledforallroles@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: option set values for isenabledforallroles, SchemaName: IsEnabledForAllRoles, IntroducedVersion: 8.2.0.0.  Description: Indicates whether appmodule is enabled for all roles</summary>
	[JsonIgnore]
	public bool? IsEnabledForAllRoles
	{
		get
		{
			return TryGetValue("isenabledforallroles", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isenabledforallroles") is false || Remove("isenabledforallroles"))
			{
				Add("isenabledforallroles", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable external file storage, SchemaName: IsExternalFileStorageEnabled, IntroducedVersion: 9.0.0.0.  Description: Indicates whether the organization's files are being stored in Azure.</summary>
	[JsonIgnore]
	public string? IsExternalFileStorageEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isexternalfilestorageenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable external file storage, SchemaName: IsExternalFileStorageEnabled, IntroducedVersion: 9.0.0.0.  Description: Indicates whether the organization's files are being stored in Azure.</summary>
	[JsonIgnore]
	public bool? IsExternalFileStorageEnabled
	{
		get
		{
			return TryGetValue("isexternalfilestorageenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isexternalfilestorageenabled") is false || Remove("isexternalfilestorageenabled"))
			{
				Add("isexternalfilestorageenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable external search data syncing, SchemaName: IsExternalSearchIndexEnabled, IntroducedVersion: 8.0.0.0.  Description: Select whether data can be synchronized with an external search index.</summary>
	[JsonIgnore]
	public string? IsExternalSearchIndexEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isexternalsearchindexenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable external search data syncing, SchemaName: IsExternalSearchIndexEnabled, IntroducedVersion: 8.0.0.0.  Description: Select whether data can be synchronized with an external search index.</summary>
	[JsonIgnore]
	public bool? IsExternalSearchIndexEnabled
	{
		get
		{
			return TryGetValue("isexternalsearchindexenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isexternalsearchindexenabled") is false || Remove("isexternalsearchindexenabled"))
			{
				Add("isexternalsearchindexenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Fiscal Period Monthly, SchemaName: IsFiscalPeriodMonthBased, IntroducedVersion: 5.0.0.0.  Description: Indicates whether the fiscal period is displayed as the month number.</summary>
	[JsonIgnore]
	public string? IsFiscalPeriodMonthBasedFormattedValue
	{
		get
		{
			return TryGetValue("isfiscalperiodmonthbased@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Fiscal Period Monthly, SchemaName: IsFiscalPeriodMonthBased, IntroducedVersion: 5.0.0.0.  Description: Indicates whether the fiscal period is displayed as the month number.</summary>
	[JsonIgnore]
	public bool? IsFiscalPeriodMonthBased
	{
		get
		{
			return TryGetValue("isfiscalperiodmonthbased", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isfiscalperiodmonthbased") is false || Remove("isfiscalperiodmonthbased"))
			{
				Add("isfiscalperiodmonthbased", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Automatically create folders, SchemaName: IsFolderAutoCreatedonSP, IntroducedVersion: 8.1.0.0.  Description: Select whether folders should be automatically created on SharePoint.</summary>
	[JsonIgnore]
	public string? IsFolderAutoCreatedonSPFormattedValue
	{
		get
		{
			return TryGetValue("isfolderautocreatedonsp@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Automatically create folders, SchemaName: IsFolderAutoCreatedonSP, IntroducedVersion: 8.1.0.0.  Description: Select whether folders should be automatically created on SharePoint.</summary>
	[JsonIgnore]
	public bool? IsFolderAutoCreatedonSP
	{
		get
		{
			return TryGetValue("isfolderautocreatedonsp", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isfolderautocreatedonsp") is false || Remove("isfolderautocreatedonsp"))
			{
				Add("isfolderautocreatedonsp", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Folder Based Tracking Enabled, SchemaName: IsFolderBasedTrackingEnabled, IntroducedVersion: 7.1.0.0.  Description: Enable or disable folder based tracking for Server Side Sync.</summary>
	[JsonIgnore]
	public string? IsFolderBasedTrackingEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isfolderbasedtrackingenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Folder Based Tracking Enabled, SchemaName: IsFolderBasedTrackingEnabled, IntroducedVersion: 7.1.0.0.  Description: Enable or disable folder based tracking for Server Side Sync.</summary>
	[JsonIgnore]
	public bool? IsFolderBasedTrackingEnabled
	{
		get
		{
			return TryGetValue("isfolderbasedtrackingenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isfolderbasedtrackingenabled") is false || Remove("isfolderbasedtrackingenabled"))
			{
				Add("isfolderbasedtrackingenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Full-text search for Quick Find, SchemaName: IsFullTextSearchEnabled, IntroducedVersion: 7.1.0.0.  Description: Indicates whether full-text search for Quick Find entities should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsFullTextSearchEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isfulltextsearchenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Full-text search for Quick Find, SchemaName: IsFullTextSearchEnabled, IntroducedVersion: 7.1.0.0.  Description: Indicates whether full-text search for Quick Find entities should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsFullTextSearchEnabled
	{
		get
		{
			return TryGetValue("isfulltextsearchenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isfulltextsearchenabled") is false || Remove("isfulltextsearchenabled"))
			{
				Add("isfulltextsearchenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Enable geospatial Azure Maps integration., SchemaName: IsGeospatialAzureMapsIntegrationEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether geospatial capabilities leveraging Azure Maps are enabled.</summary>
	[JsonIgnore]
	public string? IsGeospatialAzureMapsIntegrationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isgeospatialazuremapsintegrationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Enable geospatial Azure Maps integration., SchemaName: IsGeospatialAzureMapsIntegrationEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether geospatial capabilities leveraging Azure Maps are enabled.</summary>
	[JsonIgnore]
	public bool? IsGeospatialAzureMapsIntegrationEnabled
	{
		get
		{
			return TryGetValue("isgeospatialazuremapsintegrationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isgeospatialazuremapsintegrationenabled") is false || Remove("isgeospatialazuremapsintegrationenabled"))
			{
				Add("isgeospatialazuremapsintegrationenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Hierarchical Security Model, SchemaName: IsHierarchicalSecurityModelEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable Hierarchical Security Model</summary>
	[JsonIgnore]
	public string? IsHierarchicalSecurityModelEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ishierarchicalsecuritymodelenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Hierarchical Security Model, SchemaName: IsHierarchicalSecurityModelEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable Hierarchical Security Model</summary>
	[JsonIgnore]
	public bool? IsHierarchicalSecurityModelEnabled
	{
		get
		{
			return TryGetValue("ishierarchicalsecuritymodelenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ishierarchicalsecuritymodelenabled") is false || Remove("ishierarchicalsecuritymodelenabled"))
			{
				Add("ishierarchicalsecuritymodelenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Ideas data collection., SchemaName: IsIdeasDataCollectionEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether data collection for ideas in canvas PowerApps has been enabled.</summary>
	[JsonIgnore]
	public string? IsIdeasDataCollectionEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isideasdatacollectionenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Ideas data collection., SchemaName: IsIdeasDataCollectionEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether data collection for ideas in canvas PowerApps has been enabled.</summary>
	[JsonIgnore]
	public bool? IsIdeasDataCollectionEnabled
	{
		get
		{
			return TryGetValue("isideasdatacollectionenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isideasdatacollectionenabled") is false || Remove("isideasdatacollectionenabled"))
			{
				Add("isideasdatacollectionenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isideasdatacollectionenabled, SchemaName: isideasdatacollectionenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? isideasdatacollectionenabledName
	{
		get
		{
			return TryGetValue("isideasdatacollectionenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: LUIS Consent for Dynamics 365 Bot, SchemaName: IsLUISEnabledforD365Bot, IntroducedVersion: 9.0.2.0.  Description: Give Consent to use LUIS in Dynamics 365 Bot</summary>
	[JsonIgnore]
	public string? IsLUISEnabledforD365BotFormattedValue
	{
		get
		{
			return TryGetValue("isluisenabledford365bot@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: LUIS Consent for Dynamics 365 Bot, SchemaName: IsLUISEnabledforD365Bot, IntroducedVersion: 9.0.2.0.  Description: Give Consent to use LUIS in Dynamics 365 Bot</summary>
	[JsonIgnore]
	public bool? IsLUISEnabledforD365Bot
	{
		get
		{
			return TryGetValue("isluisenabledford365bot", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isluisenabledford365bot") is false || Remove("isluisenabledford365bot"))
			{
				Add("isluisenabledford365bot", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mailbox Forced Unlocking Enabled, SchemaName: IsMailboxForcedUnlockingEnabled, IntroducedVersion: 7.1.0.0.  Description: Enable or disable forced unlocking for Server Side Sync mailboxes.</summary>
	[JsonIgnore]
	public string? IsMailboxForcedUnlockingEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismailboxforcedunlockingenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mailbox Forced Unlocking Enabled, SchemaName: IsMailboxForcedUnlockingEnabled, IntroducedVersion: 7.1.0.0.  Description: Enable or disable forced unlocking for Server Side Sync mailboxes.</summary>
	[JsonIgnore]
	public bool? IsMailboxForcedUnlockingEnabled
	{
		get
		{
			return TryGetValue("ismailboxforcedunlockingenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismailboxforcedunlockingenabled") is false || Remove("ismailboxforcedunlockingenabled"))
			{
				Add("ismailboxforcedunlockingenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mailbox Keep Alive Enabled, SchemaName: IsMailboxInactiveBackoffEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable mailbox keep alive for Server Side Sync.</summary>
	[JsonIgnore]
	public string? IsMailboxInactiveBackoffEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismailboxinactivebackoffenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mailbox Keep Alive Enabled, SchemaName: IsMailboxInactiveBackoffEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable or disable mailbox keep alive for Server Side Sync.</summary>
	[JsonIgnore]
	public bool? IsMailboxInactiveBackoffEnabled
	{
		get
		{
			return TryGetValue("ismailboxinactivebackoffenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismailboxinactivebackoffenabled") is false || Remove("ismailboxinactivebackoffenabled"))
			{
				Add("ismailboxinactivebackoffenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Manual Sales Forecasting feature for this organization, SchemaName: IsManualSalesForecastingEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Manual Sales Forecasting feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsManualSalesForecastingEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismanualsalesforecastingenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Manual Sales Forecasting feature for this organization, SchemaName: IsManualSalesForecastingEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Manual Sales Forecasting feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsManualSalesForecastingEnabled
	{
		get
		{
			return TryGetValue("ismanualsalesforecastingenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismanualsalesforecastingenabled") is false || Remove("ismanualsalesforecastingenabled"))
			{
				Add("ismanualsalesforecastingenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mobile Client On Demand Sync enabled, SchemaName: IsMobileClientOnDemandSyncEnabled, IntroducedVersion: 8.2.0.0.  Description: Information that specifies whether mobile client on demand sync is enabled.</summary>
	[JsonIgnore]
	public string? IsMobileClientOnDemandSyncEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismobileclientondemandsyncenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Mobile Client On Demand Sync enabled, SchemaName: IsMobileClientOnDemandSyncEnabled, IntroducedVersion: 8.2.0.0.  Description: Information that specifies whether mobile client on demand sync is enabled.</summary>
	[JsonIgnore]
	public bool? IsMobileClientOnDemandSyncEnabled
	{
		get
		{
			return TryGetValue("ismobileclientondemandsyncenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismobileclientondemandsyncenabled") is false || Remove("ismobileclientondemandsyncenabled"))
			{
				Add("ismobileclientondemandsyncenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable MobileOffline for this Organization, SchemaName: IsMobileOfflineEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature MobileOffline should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsMobileOfflineEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismobileofflineenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable MobileOffline for this Organization, SchemaName: IsMobileOfflineEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature MobileOffline should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsMobileOfflineEnabled
	{
		get
		{
			return TryGetValue("ismobileofflineenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismobileofflineenabled") is false || Remove("ismobileofflineenabled"))
			{
				Add("ismobileofflineenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable embedding Model Apps in Microsoft Teams, SchemaName: IsModelDrivenAppsInMSTeamsEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Model Apps can be embedded within Microsoft Teams. This is a tenant admin controlled preview/experimental feature.</summary>
	[JsonIgnore]
	public string? IsModelDrivenAppsInMSTeamsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismodeldrivenappsinmsteamsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable embedding Model Apps in Microsoft Teams, SchemaName: IsModelDrivenAppsInMSTeamsEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Model Apps can be embedded within Microsoft Teams. This is a tenant admin controlled preview/experimental feature.</summary>
	[JsonIgnore]
	public bool? IsModelDrivenAppsInMSTeamsEnabled
	{
		get
		{
			return TryGetValue("ismodeldrivenappsinmsteamsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismodeldrivenappsinmsteamsenabled") is false || Remove("ismodeldrivenappsinmsteamsenabled"))
			{
				Add("ismodeldrivenappsinmsteamsenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Microsoft Teams Collaboration for this organization, SchemaName: IsMSTeamsCollaborationEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Microsoft Teams Collaboration feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsMSTeamsCollaborationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismsteamscollaborationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Microsoft Teams Collaboration for this organization, SchemaName: IsMSTeamsCollaborationEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Microsoft Teams Collaboration feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsMSTeamsCollaborationEnabled
	{
		get
		{
			return TryGetValue("ismsteamscollaborationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismsteamscollaborationenabled") is false || Remove("ismsteamscollaborationenabled"))
			{
				Add("ismsteamscollaborationenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Microsoft Teams integration, SchemaName: IsMSTeamsEnabled, IntroducedVersion: 9.0.2.0.  Description: Indicates whether Microsoft Teams integration has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsMSTeamsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismsteamsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Microsoft Teams integration, SchemaName: IsMSTeamsEnabled, IntroducedVersion: 9.0.2.0.  Description: Indicates whether Microsoft Teams integration has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsMSTeamsEnabled
	{
		get
		{
			return TryGetValue("ismsteamsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismsteamsenabled") is false || Remove("ismsteamsenabled"))
			{
				Add("ismsteamsenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Microsoft Teams integration changed by user, SchemaName: IsMSTeamsSettingChangedByUser, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the user has enabled or disabled Microsoft Teams integration.</summary>
	[JsonIgnore]
	public string? IsMSTeamsSettingChangedByUserFormattedValue
	{
		get
		{
			return TryGetValue("ismsteamssettingchangedbyuser@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Microsoft Teams integration changed by user, SchemaName: IsMSTeamsSettingChangedByUser, IntroducedVersion: 9.1.0.0.  Description: Indicates whether the user has enabled or disabled Microsoft Teams integration.</summary>
	[JsonIgnore]
	public bool? IsMSTeamsSettingChangedByUser
	{
		get
		{
			return TryGetValue("ismsteamssettingchangedbyuser", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismsteamssettingchangedbyuser") is false || Remove("ismsteamssettingchangedbyuser"))
			{
				Add("ismsteamssettingchangedbyuser", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Microsoft Teams User Sync for this organization, SchemaName: IsMSTeamsUserSyncEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Microsoft Teams User Sync feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsMSTeamsUserSyncEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ismsteamsusersyncenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Microsoft Teams User Sync for this organization, SchemaName: IsMSTeamsUserSyncEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Microsoft Teams User Sync feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsMSTeamsUserSyncEnabled
	{
		get
		{
			return TryGetValue("ismsteamsusersyncenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismsteamsusersyncenabled") is false || Remove("ismsteamsusersyncenabled"))
			{
				Add("ismsteamsusersyncenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether new add product experience is enabled in opportunity form, SchemaName: IsNewAddProductExperienceEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether new add product experience is enabled.</summary>
	[JsonIgnore]
	public string? IsNewAddProductExperienceEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isnewaddproductexperienceenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether new add product experience is enabled in opportunity form, SchemaName: IsNewAddProductExperienceEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether new add product experience is enabled.</summary>
	[JsonIgnore]
	public bool? IsNewAddProductExperienceEnabled
	{
		get
		{
			return TryGetValue("isnewaddproductexperienceenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isnewaddproductexperienceenabled") is false || Remove("isnewaddproductexperienceenabled"))
			{
				Add("isnewaddproductexperienceenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Notes Analysis for this Organization, SchemaName: IsNotesAnalysisEnabled, IntroducedVersion: 9.0.0.0.  Description: Indicates whether the feature Notes Analysis should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsNotesAnalysisEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isnotesanalysisenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Notes Analysis for this Organization, SchemaName: IsNotesAnalysisEnabled, IntroducedVersion: 9.0.0.0.  Description: Indicates whether the feature Notes Analysis should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsNotesAnalysisEnabled
	{
		get
		{
			return TryGetValue("isnotesanalysisenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isnotesanalysisenabled") is false || Remove("isnotesanalysisenabled"))
			{
				Add("isnotesanalysisenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsNotificationForD365InTeamsEnabled, SchemaName: IsNotificationForD365InTeamsEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public string? IsNotificationForD365InTeamsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isnotificationford365inteamsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsNotificationForD365InTeamsEnabled, SchemaName: IsNotificationForD365InTeamsEnabled, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public bool? IsNotificationForD365InTeamsEnabled
	{
		get
		{
			return TryGetValue("isnotificationford365inteamsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isnotificationford365inteamsenabled") is false || Remove("isnotificationford365inteamsenabled"))
			{
				Add("isnotificationford365inteamsenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isnotificationford365inteamsenabled, SchemaName: isnotificationford365inteamsenabledName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? isnotificationford365inteamsenabledName
	{
		get
		{
			return TryGetValue("isnotificationford365inteamsenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable OfficeGraph for this Organization, SchemaName: IsOfficeGraphEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature OfficeGraph should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsOfficeGraphEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isofficegraphenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable OfficeGraph for this Organization, SchemaName: IsOfficeGraphEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature OfficeGraph should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsOfficeGraphEnabled
	{
		get
		{
			return TryGetValue("isofficegraphenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isofficegraphenabled") is false || Remove("isofficegraphenabled"))
			{
				Add("isofficegraphenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable One Drive for this Organization, SchemaName: IsOneDriveEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature One Drive should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsOneDriveEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isonedriveenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable One Drive for this Organization, SchemaName: IsOneDriveEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the feature One Drive should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsOneDriveEnabled
	{
		get
		{
			return TryGetValue("isonedriveenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isonedriveenabled") is false || Remove("isonedriveenabled"))
			{
				Add("isonedriveenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable PAI feature for this organization, SchemaName: IsPAIEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether PAI feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsPAIEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ispaienabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable PAI feature for this organization, SchemaName: IsPAIEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether PAI feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsPAIEnabled
	{
		get
		{
			return TryGetValue("ispaienabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ispaienabled") is false || Remove("ispaienabled"))
			{
				Add("ispaienabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Enable PDF Generation feature for this organization, Format: Text, MaxLength: 1000, SchemaName: IsPDFGenerationEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether PDF Generation feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsPDFGenerationEnabled
	{
		get
		{
			return TryGetValue("ispdfgenerationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ispdfgenerationenabled") is false || Remove("ispdfgenerationenabled"))
			{
				Add("ispdfgenerationenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the Per Process overage feature for this organization, SchemaName: IsPerProcessCapacityOverageEnabled, IntroducedVersion: 1.7.8.0.  Description: Indicates whether the Per Process overage feature is enabled in this organization.</summary>
	[JsonIgnore]
	public string? IsPerProcessCapacityOverageEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isperprocesscapacityoverageenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the Per Process overage feature for this organization, SchemaName: IsPerProcessCapacityOverageEnabled, IntroducedVersion: 1.7.8.0.  Description: Indicates whether the Per Process overage feature is enabled in this organization.</summary>
	[JsonIgnore]
	public bool? IsPerProcessCapacityOverageEnabled
	{
		get
		{
			return TryGetValue("isperprocesscapacityoverageenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isperprocesscapacityoverageenabled") is false || Remove("isperprocesscapacityoverageenabled"))
			{
				Add("isperprocesscapacityoverageenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isperprocesscapacityoverageenabled, SchemaName: isperprocesscapacityoverageenabledName, IntroducedVersion: 1.7.8.0. </summary>
	[JsonIgnore]
	public object? isperprocesscapacityoverageenabledName
	{
		get
		{
			return TryGetValue("isperprocesscapacityoverageenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable playbook feature for this organization, SchemaName: IsPlaybookEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether playbook feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsPlaybookEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isplaybookenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable playbook feature for this organization, SchemaName: IsPlaybookEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether playbook feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsPlaybookEnabled
	{
		get
		{
			return TryGetValue("isplaybookenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isplaybookenabled") is false || Remove("isplaybookenabled"))
			{
				Add("isplaybookenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Presence Enabled, SchemaName: IsPresenceEnabled, IntroducedVersion: 5.0.0.0.  Description: Information on whether IM presence is enabled.</summary>
	[JsonIgnore]
	public string? IsPresenceEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ispresenceenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Presence Enabled, SchemaName: IsPresenceEnabled, IntroducedVersion: 5.0.0.0.  Description: Information on whether IM presence is enabled.</summary>
	[JsonIgnore]
	public bool? IsPresenceEnabled
	{
		get
		{
			return TryGetValue("ispresenceenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ispresenceenabled") is false || Remove("ispresenceenabled"))
			{
				Add("ispresenceenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ispresenceenabled, SchemaName: IsPresenceEnabledName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsPresenceEnabledName
	{
		get
		{
			return TryGetValue("ispresenceenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Preview Action Card feature for this Organization, SchemaName: IsPreviewEnabledForActionCard, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the Preview feature for Action Card should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsPreviewEnabledForActionCardFormattedValue
	{
		get
		{
			return TryGetValue("ispreviewenabledforactioncard@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Preview Action Card feature for this Organization, SchemaName: IsPreviewEnabledForActionCard, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the Preview feature for Action Card should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsPreviewEnabledForActionCard
	{
		get
		{
			return TryGetValue("ispreviewenabledforactioncard", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ispreviewenabledforactioncard") is false || Remove("ispreviewenabledforactioncard"))
			{
				Add("ispreviewenabledforactioncard", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Auto Capture for this Organization at Preview Settings, SchemaName: IsPreviewForAutoCaptureEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Auto Capture should be enabled for the organization at Preview Settings.</summary>
	[JsonIgnore]
	public string? IsPreviewForAutoCaptureEnabledFormattedValue
	{
		get
		{
			return TryGetValue("ispreviewforautocaptureenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Auto Capture for this Organization at Preview Settings, SchemaName: IsPreviewForAutoCaptureEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Auto Capture should be enabled for the organization at Preview Settings.</summary>
	[JsonIgnore]
	public bool? IsPreviewForAutoCaptureEnabled
	{
		get
		{
			return TryGetValue("ispreviewforautocaptureenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ispreviewforautocaptureenabled") is false || Remove("ispreviewforautocaptureenabled"))
			{
				Add("ispreviewforautocaptureenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allows Preview For Email Monitoring, SchemaName: IsPreviewForEmailMonitoringAllowed, IntroducedVersion: 8.2.0.0.  Description: Is Preview For Email Monitoring Allowed.</summary>
	[JsonIgnore]
	public string? IsPreviewForEmailMonitoringAllowedFormattedValue
	{
		get
		{
			return TryGetValue("ispreviewforemailmonitoringallowed@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allows Preview For Email Monitoring, SchemaName: IsPreviewForEmailMonitoringAllowed, IntroducedVersion: 8.2.0.0.  Description: Is Preview For Email Monitoring Allowed.</summary>
	[JsonIgnore]
	public bool? IsPreviewForEmailMonitoringAllowed
	{
		get
		{
			return TryGetValue("ispreviewforemailmonitoringallowed", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ispreviewforemailmonitoringallowed") is false || Remove("ispreviewforemailmonitoringallowed"))
			{
				Add("ispreviewforemailmonitoringallowed", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether PriceList is mandatory for adding existing products to sales entities, SchemaName: IsPriceListMandatory, IntroducedVersion: 9.1.0.0.  Description: Indicates whether PriceList is mandatory for adding existing products to sales entities.</summary>
	[JsonIgnore]
	public string? IsPriceListMandatoryFormattedValue
	{
		get
		{
			return TryGetValue("ispricelistmandatory@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether PriceList is mandatory for adding existing products to sales entities, SchemaName: IsPriceListMandatory, IntroducedVersion: 9.1.0.0.  Description: Indicates whether PriceList is mandatory for adding existing products to sales entities.</summary>
	[JsonIgnore]
	public bool? IsPriceListMandatory
	{
		get
		{
			return TryGetValue("ispricelistmandatory", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ispricelistmandatory") is false || Remove("ispricelistmandatory"))
			{
				Add("ispricelistmandatory", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable quick create form for opportunity close feature for this organization, SchemaName: IsQuickCreateEnabledForOpportunityClose, IntroducedVersion: 9.1.0.0.  Description: Select whether to use the standard Out-of-box Opportunity Close experience or opt to for a customized experience.</summary>
	[JsonIgnore]
	public string? IsQuickCreateEnabledForOpportunityCloseFormattedValue
	{
		get
		{
			return TryGetValue("isquickcreateenabledforopportunityclose@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable quick create form for opportunity close feature for this organization, SchemaName: IsQuickCreateEnabledForOpportunityClose, IntroducedVersion: 9.1.0.0.  Description: Select whether to use the standard Out-of-box Opportunity Close experience or opt to for a customized experience.</summary>
	[JsonIgnore]
	public bool? IsQuickCreateEnabledForOpportunityClose
	{
		get
		{
			return TryGetValue("isquickcreateenabledforopportunityclose", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isquickcreateenabledforopportunityclose") is false || Remove("isquickcreateenabledforopportunityclose"))
			{
				Add("isquickcreateenabledforopportunityclose", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Read Auditing Enabled, SchemaName: IsReadAuditEnabled, IntroducedVersion: 9.0.0.0.  Description: Enable or disable auditing of read operations.</summary>
	[JsonIgnore]
	public string? IsReadAuditEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isreadauditenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Read Auditing Enabled, SchemaName: IsReadAuditEnabled, IntroducedVersion: 9.0.0.0.  Description: Enable or disable auditing of read operations.</summary>
	[JsonIgnore]
	public bool? IsReadAuditEnabled
	{
		get
		{
			return TryGetValue("isreadauditenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isreadauditenabled") is false || Remove("isreadauditenabled"))
			{
				Add("isreadauditenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Relationship Insights for this Organization, SchemaName: IsRelationshipInsightsEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Relationship Insights should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsRelationshipInsightsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isrelationshipinsightsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Relationship Insights for this Organization, SchemaName: IsRelationshipInsightsEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates whether the feature Relationship Insights should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsRelationshipInsightsEnabled
	{
		get
		{
			return TryGetValue("isrelationshipinsightsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrelationshipinsightsenabled") is false || Remove("isrelationshipinsightsenabled"))
			{
				Add("isrelationshipinsightsenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Resource booking synchronization enabled, SchemaName: IsResourceBookingExchangeSyncEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates if the synchronization of user resource booking with Exchange is enabled at organization level.</summary>
	[JsonIgnore]
	public string? IsResourceBookingExchangeSyncEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isresourcebookingexchangesyncenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Resource booking synchronization enabled, SchemaName: IsResourceBookingExchangeSyncEnabled, IntroducedVersion: 8.2.0.0.  Description: Indicates if the synchronization of user resource booking with Exchange is enabled at organization level.</summary>
	[JsonIgnore]
	public bool? IsResourceBookingExchangeSyncEnabled
	{
		get
		{
			return TryGetValue("isresourcebookingexchangesyncenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isresourcebookingexchangesyncenabled") is false || Remove("isresourcebookingexchangesyncenabled"))
			{
				Add("isresourcebookingexchangesyncenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether rich text editor for notes experience is enabled on this organization, SchemaName: IsRichTextNotesEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether rich text editor for notes experience is enabled on this organization</summary>
	[JsonIgnore]
	public string? IsRichTextNotesEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isrichtextnotesenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether rich text editor for notes experience is enabled on this organization, SchemaName: IsRichTextNotesEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether rich text editor for notes experience is enabled on this organization</summary>
	[JsonIgnore]
	public bool? IsRichTextNotesEnabled
	{
		get
		{
			return TryGetValue("isrichtextnotesenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrichtextnotesenabled") is false || Remove("isrichtextnotesenabled"))
			{
				Add("isrichtextnotesenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable AAD Join for RPA Autoscale feature for this organization., SchemaName: IsRpaAutoscaleAadJoinEnabled, IntroducedVersion: 1.3.4.0.  Description: Indicates whether AAD Join for RPA Autoscale is enabled in this organization..</summary>
	[JsonIgnore]
	public string? IsRpaAutoscaleAadJoinEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isrpaautoscaleaadjoinenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable AAD Join for RPA Autoscale feature for this organization., SchemaName: IsRpaAutoscaleAadJoinEnabled, IntroducedVersion: 1.3.4.0.  Description: Indicates whether AAD Join for RPA Autoscale is enabled in this organization..</summary>
	[JsonIgnore]
	public bool? IsRpaAutoscaleAadJoinEnabled
	{
		get
		{
			return TryGetValue("isrpaautoscaleaadjoinenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrpaautoscaleaadjoinenabled") is false || Remove("isrpaautoscaleaadjoinenabled"))
			{
				Add("isrpaautoscaleaadjoinenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isrpaautoscaleaadjoinenabled, SchemaName: isrpaautoscaleaadjoinenabledName, IntroducedVersion: 1.3.4.0. </summary>
	[JsonIgnore]
	public object? isrpaautoscaleaadjoinenabledName
	{
		get
		{
			return TryGetValue("isrpaautoscaleaadjoinenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Autoscale feature for this organization, SchemaName: IsRpaAutoscaleEnabled, IntroducedVersion: 1.3.0.0.  Description: Indicates whether Autoscale feature for RPA is enabled in this organization.</summary>
	[JsonIgnore]
	public string? IsRpaAutoscaleEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isrpaautoscaleenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Autoscale feature for this organization, SchemaName: IsRpaAutoscaleEnabled, IntroducedVersion: 1.3.0.0.  Description: Indicates whether Autoscale feature for RPA is enabled in this organization.</summary>
	[JsonIgnore]
	public bool? IsRpaAutoscaleEnabled
	{
		get
		{
			return TryGetValue("isrpaautoscaleenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrpaautoscaleenabled") is false || Remove("isrpaautoscaleenabled"))
			{
				Add("isrpaautoscaleenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isrpaautoscaleenabled, SchemaName: isrpaautoscaleenabledName, IntroducedVersion: 1.3.0.0. </summary>
	[JsonIgnore]
	public object? isrpaautoscaleenabledName
	{
		get
		{
			return TryGetValue("isrpaautoscaleenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Box cross geo feature for this organization, SchemaName: IsRpaBoxCrossGeoEnabled, IntroducedVersion: 1.4.25.0.  Description: Indicates whether RPA Box feature is enabled in this organization in locations outside the tenant's geographical location.</summary>
	[JsonIgnore]
	public string? IsRpaBoxCrossGeoEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isrpaboxcrossgeoenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Box cross geo feature for this organization, SchemaName: IsRpaBoxCrossGeoEnabled, IntroducedVersion: 1.4.25.0.  Description: Indicates whether RPA Box feature is enabled in this organization in locations outside the tenant's geographical location.</summary>
	[JsonIgnore]
	public bool? IsRpaBoxCrossGeoEnabled
	{
		get
		{
			return TryGetValue("isrpaboxcrossgeoenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrpaboxcrossgeoenabled") is false || Remove("isrpaboxcrossgeoenabled"))
			{
				Add("isrpaboxcrossgeoenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isrpaboxcrossgeoenabled, SchemaName: isrpaboxcrossgeoenabledName, IntroducedVersion: 1.4.25.0. </summary>
	[JsonIgnore]
	public object? isrpaboxcrossgeoenabledName
	{
		get
		{
			return TryGetValue("isrpaboxcrossgeoenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Box feature for this organization, SchemaName: IsRpaBoxEnabled, IntroducedVersion: 1.4.0.0.  Description: Indicates whether RPA Box feature is enabled in this organization.</summary>
	[JsonIgnore]
	public string? IsRpaBoxEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isrpaboxenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Box feature for this organization, SchemaName: IsRpaBoxEnabled, IntroducedVersion: 1.4.0.0.  Description: Indicates whether RPA Box feature is enabled in this organization.</summary>
	[JsonIgnore]
	public bool? IsRpaBoxEnabled
	{
		get
		{
			return TryGetValue("isrpaboxenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrpaboxenabled") is false || Remove("isrpaboxenabled"))
			{
				Add("isrpaboxenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isrpaboxenabled, SchemaName: isrpaboxenabledName, IntroducedVersion: 1.4.0.0. </summary>
	[JsonIgnore]
	public object? isrpaboxenabledName
	{
		get
		{
			return TryGetValue("isrpaboxenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Unattended feature for this organization, SchemaName: IsRpaUnattendedEnabled, IntroducedVersion: 1.3.0.0.  Description: Indicates whether Unattended runs feature for RPA is enabled in this organization.</summary>
	[JsonIgnore]
	public string? IsRpaUnattendedEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isrpaunattendedenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable RPA Unattended feature for this organization, SchemaName: IsRpaUnattendedEnabled, IntroducedVersion: 1.3.0.0.  Description: Indicates whether Unattended runs feature for RPA is enabled in this organization.</summary>
	[JsonIgnore]
	public bool? IsRpaUnattendedEnabled
	{
		get
		{
			return TryGetValue("isrpaunattendedenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrpaunattendedenabled") is false || Remove("isrpaunattendedenabled"))
			{
				Add("isrpaunattendedenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isrpaunattendedenabled, SchemaName: isrpaunattendedenabledName, IntroducedVersion: 1.3.0.0. </summary>
	[JsonIgnore]
	public object? isrpaunattendedenabledName
	{
		get
		{
			return TryGetValue("isrpaunattendedenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Sales Assistant mobile app, SchemaName: IsSalesAssistantEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Assistant mobile app has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? IsSalesAssistantEnabledFormattedValue
	{
		get
		{
			return TryGetValue("issalesassistantenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Sales Assistant mobile app, SchemaName: IsSalesAssistantEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Assistant mobile app has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? IsSalesAssistantEnabled
	{
		get
		{
			return TryGetValue("issalesassistantenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("issalesassistantenabled") is false || Remove("issalesassistantenabled"))
			{
				Add("issalesassistantenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Sales Mobile Preview has been enabled for the organization, SchemaName: IsSalesMobilePreviewEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Mobile Preview has been enabled for the organization</summary>
	[JsonIgnore]
	public string? IsSalesMobilePreviewEnabledFormattedValue
	{
		get
		{
			return TryGetValue("issalesmobilepreviewenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Sales Mobile Preview has been enabled for the organization, SchemaName: IsSalesMobilePreviewEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Mobile Preview has been enabled for the organization</summary>
	[JsonIgnore]
	public bool? IsSalesMobilePreviewEnabled
	{
		get
		{
			return TryGetValue("issalesmobilepreviewenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("issalesmobilepreviewenabled") is false || Remove("issalesmobilepreviewenabled"))
			{
				Add("issalesmobilepreviewenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: issalesmobilepreviewenabled, SchemaName: issalesmobilepreviewenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? issalesmobilepreviewenabledName
	{
		get
		{
			return TryGetValue("issalesmobilepreviewenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsSharingInOrgAllowed, SchemaName: IsSharingInOrgAllowed, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public string? IsSharingInOrgAllowedFormattedValue
	{
		get
		{
			return TryGetValue("issharinginorgallowed@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: IsSharingInOrgAllowed, SchemaName: IsSharingInOrgAllowed, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public bool? IsSharingInOrgAllowed
	{
		get
		{
			return TryGetValue("issharinginorgallowed", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("issharinginorgallowed") is false || Remove("issharinginorgallowed"))
			{
				Add("issharinginorgallowed", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: issharinginorgallowed, SchemaName: issharinginorgallowedName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? issharinginorgallowedName
	{
		get
		{
			return TryGetValue("issharinginorgallowedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Sales Order Integration Enabled, SchemaName: IsSOPIntegrationEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable sales order processing integration.</summary>
	[JsonIgnore]
	public string? IsSOPIntegrationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("issopintegrationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Sales Order Integration Enabled, SchemaName: IsSOPIntegrationEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable sales order processing integration.</summary>
	[JsonIgnore]
	public bool? IsSOPIntegrationEnabled
	{
		get
		{
			return TryGetValue("issopintegrationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("issopintegrationenabled") is false || Remove("issopintegrationenabled"))
			{
				Add("issopintegrationenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Text Wrap, SchemaName: IsTextWrapEnabled, IntroducedVersion: 9.0.0.0.  Description: Information on whether text wrap is enabled.</summary>
	[JsonIgnore]
	public string? IsTextWrapEnabledFormattedValue
	{
		get
		{
			return TryGetValue("istextwrapenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Text Wrap, SchemaName: IsTextWrapEnabled, IntroducedVersion: 9.0.0.0.  Description: Information on whether text wrap is enabled.</summary>
	[JsonIgnore]
	public bool? IsTextWrapEnabled
	{
		get
		{
			return TryGetValue("istextwrapenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("istextwrapenabled") is false || Remove("istextwrapenabled"))
			{
				Add("istextwrapenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is User Access Auditing Enabled, SchemaName: IsUserAccessAuditEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable or disable auditing of user access.</summary>
	[JsonIgnore]
	public string? IsUserAccessAuditEnabledFormattedValue
	{
		get
		{
			return TryGetValue("isuseraccessauditenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is User Access Auditing Enabled, SchemaName: IsUserAccessAuditEnabled, IntroducedVersion: 5.0.0.0.  Description: Enable or disable auditing of user access.</summary>
	[JsonIgnore]
	public bool? IsUserAccessAuditEnabled
	{
		get
		{
			return TryGetValue("isuseraccessauditenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isuseraccessauditenabled") is false || Remove("isuseraccessauditenabled"))
			{
				Add("isuseraccessauditenabled", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: ISV Integration Mode, SchemaName: ISVIntegrationCode, IntroducedVersion: 5.0.0.0.  Description: Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.</summary>
	[JsonIgnore]
	public string? ISVIntegrationCodeFormattedValue
	{
		get
		{
			return TryGetValue("isvintegrationcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: ISV Integration Mode, SchemaName: ISVIntegrationCode, IntroducedVersion: 5.0.0.0.  Description: Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.</summary>
	[JsonIgnore]
	public int? ISVIntegrationCode
	{
		get
		{
			return TryGetValue("isvintegrationcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("isvintegrationcode") is false || Remove("isvintegrationcode"))
			{
				Add("isvintegrationcode", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Write-in Products can be added to Opportunity/Quote/Order/Invoice or not, SchemaName: IsWriteInProductsAllowed, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Write-in Products can be added to Opportunity/Quote/Order/Invoice or not.</summary>
	[JsonIgnore]
	public string? IsWriteInProductsAllowedFormattedValue
	{
		get
		{
			return TryGetValue("iswriteinproductsallowed@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Write-in Products can be added to Opportunity/Quote/Order/Invoice or not, SchemaName: IsWriteInProductsAllowed, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Write-in Products can be added to Opportunity/Quote/Order/Invoice or not.</summary>
	[JsonIgnore]
	public bool? IsWriteInProductsAllowed
	{
		get
		{
			return TryGetValue("iswriteinproductsallowed", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iswriteinproductsallowed") is false || Remove("iswriteinproductsallowed"))
			{
				Add("iswriteinproductsallowed", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Knowledge Article Prefix, Format: Text, MaxLength: 20, SchemaName: KaPrefix, IntroducedVersion: 8.0.0.0.  Description: Type the prefix to use for all knowledge articles in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? KaPrefix
	{
		get
		{
			return TryGetValue("kaprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("kaprefix") is false || Remove("kaprefix"))
			{
				Add("kaprefix", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Article Prefix, Format: Text, MaxLength: 20, SchemaName: KbPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix to use for all articles in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? KbPrefix
	{
		get
		{
			return TryGetValue("kbprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("kbprefix") is false || Remove("kbprefix"))
			{
				Add("kbprefix", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Knowledge Management Settings, Format: Text, MaxLength: 1073741823, SchemaName: KMSettings, IntroducedVersion: 7.1.0.0.  Description: XML string containing the Knowledge Management settings that are applied in Knowledge Management Wizard.</summary>
	[JsonIgnore]
	public string? KMSettings
	{
		get
		{
			return TryGetValue("kmsettings", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("kmsettings") is false || Remove("kmsettings"))
			{
				Add("kmsettings", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Language, Format: Locale, MinValue: 0, MaxValue: 2147483647, SchemaName: LanguageCode, IntroducedVersion: 5.0.0.0.  Description: Preferred language for the organization.</summary>
	[JsonIgnore]
	public int? LanguageCode
	{
		get
		{
			return TryGetValue("languagecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("languagecode") is false || Remove("languagecode"))
			{
				Add("languagecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: languagecode, SchemaName: LanguageCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? LanguageCodeName
	{
		get
		{
			return TryGetValue("languagecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Show legacy app for admins, SchemaName: LegacyAppToggle, IntroducedVersion: 9.1.0.0.  Description: Show legacy app for admins</summary>
	[JsonIgnore]
	public string? LegacyAppToggleFormattedValue
	{
		get
		{
			return TryGetValue("legacyapptoggle@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Show legacy app for admins, SchemaName: LegacyAppToggle, IntroducedVersion: 9.1.0.0.  Description: Show legacy app for admins</summary>
	[JsonIgnore]
	public int? LegacyAppToggle
	{
		get
		{
			return TryGetValue("legacyapptoggle", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("legacyapptoggle") is false || Remove("legacyapptoggle"))
			{
				Add("legacyapptoggle", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: legacyapptoggle, SchemaName: legacyapptoggleName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? legacyapptoggleName
	{
		get
		{
			return TryGetValue("legacyapptogglename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Locale, Format: Locale, MinValue: 0, MaxValue: 2147483647, SchemaName: LocaleId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the locale of the organization.</summary>
	[JsonIgnore]
	public int? LocaleId
	{
		get
		{
			return TryGetValue("localeid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("localeid") is false || Remove("localeid"))
			{
				Add("localeid", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Long Date Format, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: LongDateFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how the Long Date format is displayed in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public int? LongDateFormatCode
	{
		get
		{
			return TryGetValue("longdateformatcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("longdateformatcode") is false || Remove("longdateformatcode"))
			{
				Add("longdateformatcode", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Minimum number of characters before resolving suggestions in lookup, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: LookupCharacterCountBeforeResolve, IntroducedVersion: 9.1.0.0.  Description: Minimum number of characters that should be entered in the lookup control before resolving for suggestions</summary>
	[JsonIgnore]
	public int? LookupCharacterCountBeforeResolve
	{
		get
		{
			return TryGetValue("lookupcharactercountbeforeresolve", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("lookupcharactercountbeforeresolve") is false || Remove("lookupcharactercountbeforeresolve"))
			{
				Add("lookupcharactercountbeforeresolve", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Minimum delay (in milliseconds) for debouncing lookup control input, Format: None, MinValue: 250, MaxValue: 2147483647, SchemaName: LookupResolveDelayMS, IntroducedVersion: 9.1.0.0.  Description: Minimum delay (in milliseconds) between consecutive inputs in a lookup control that will trigger a search for suggestions</summary>
	[JsonIgnore]
	public int? LookupResolveDelayMS
	{
		get
		{
			return TryGetValue("lookupresolvedelayms", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("lookupresolvedelayms") is false || Remove("lookupresolvedelayms"))
			{
				Add("lookupresolvedelayms", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Lower Threshold For Mailbox Intermittent Issue, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MailboxIntermittentIssueMinRange, IntroducedVersion: 7.1.0.0.  Description: Lower Threshold For Mailbox Intermittent Issue.</summary>
	[JsonIgnore]
	public int? MailboxIntermittentIssueMinRange
	{
		get
		{
			return TryGetValue("mailboxintermittentissueminrange", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("mailboxintermittentissueminrange") is false || Remove("mailboxintermittentissueminrange"))
			{
				Add("mailboxintermittentissueminrange", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Lower Threshold For Mailbox Permanent Issue., Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MailboxPermanentIssueMinRange, IntroducedVersion: 7.1.0.0.  Description: Lower Threshold For Mailbox Permanent Issue.</summary>
	[JsonIgnore]
	public int? MailboxPermanentIssueMinRange
	{
		get
		{
			return TryGetValue("mailboxpermanentissueminrange", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("mailboxpermanentissueminrange") is false || Remove("mailboxpermanentissueminrange"))
			{
				Add("mailboxpermanentissueminrange", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Maximum number of actionsteps allowed in a BPF, Format: None, MinValue: 0, MaxValue: 100, SchemaName: MaxActionStepsInBPF, IntroducedVersion: 9.0.0.0.  Description: Maximum number of actionsteps allowed in a BPF</summary>
	[JsonIgnore]
	public int? MaxActionStepsInBPF
	{
		get
		{
			return TryGetValue("maxactionstepsinbpf", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxactionstepsinbpf") is false || Remove("maxactionstepsinbpf"))
			{
				Add("maxactionstepsinbpf", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: MaxAllowedPendingRollupJobCount, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxAllowedPendingRollupJobCount, IntroducedVersion: 1.0.0.0.  Description: Maximum Allowed Pending Rollup Job Count</summary>
	[JsonIgnore]
	public int? MaxAllowedPendingRollupJobCount
	{
		get
		{
			return TryGetValue("maxallowedpendingrollupjobcount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxallowedpendingrollupjobcount") is false || Remove("maxallowedpendingrollupjobcount"))
			{
				Add("maxallowedpendingrollupjobcount", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: MaxAllowedPendingRollupJobPercentage, Format: None, MinValue: 0, MaxValue: 100, SchemaName: MaxAllowedPendingRollupJobPercentage, IntroducedVersion: 1.0.0.0.  Description: Percentage Of Entity Table Size For Kicking Off Bootstrap Job</summary>
	[JsonIgnore]
	public int? MaxAllowedPendingRollupJobPercentage
	{
		get
		{
			return TryGetValue("maxallowedpendingrollupjobpercentage", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxallowedpendingrollupjobpercentage") is false || Remove("maxallowedpendingrollupjobpercentage"))
			{
				Add("maxallowedpendingrollupjobpercentage", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max Appointment Duration, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxAppointmentDurationDays, IntroducedVersion: 5.0.0.0.  Description: Maximum number of days an appointment can last.</summary>
	[JsonIgnore]
	public int? MaxAppointmentDurationDays
	{
		get
		{
			return TryGetValue("maxappointmentdurationdays", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxappointmentdurationdays") is false || Remove("maxappointmentdurationdays"))
			{
				Add("maxappointmentdurationdays", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Maximum number of conditions allowed for mobile offline filters, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxConditionsForMobileOfflineFilters, IntroducedVersion: 8.1.0.0.  Description: Maximum number of conditions allowed for mobile offline filters</summary>
	[JsonIgnore]
	public int? MaxConditionsForMobileOfflineFilters
	{
		get
		{
			return TryGetValue("maxconditionsformobileofflinefilters", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxconditionsformobileofflinefilters") is false || Remove("maxconditionsformobileofflinefilters"))
			{
				Add("maxconditionsformobileofflinefilters", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Maximum depth for hierarchy security propagation., Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MaxDepthForHierarchicalSecurityModel, IntroducedVersion: 7.0.0.0.  Description: Maximum depth for hierarchy security propagation.</summary>
	[JsonIgnore]
	public int? MaxDepthForHierarchicalSecurityModel
	{
		get
		{
			return TryGetValue("maxdepthforhierarchicalsecuritymodel", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxdepthforhierarchicalsecuritymodel") is false || Remove("maxdepthforhierarchicalsecuritymodel"))
			{
				Add("maxdepthforhierarchicalsecuritymodel", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max Folder Based Tracking Mappings, Format: None, MinValue: 1, MaxValue: 25, SchemaName: MaxFolderBasedTrackingMappings, IntroducedVersion: 7.1.0.0.  Description: Maximum number of Folder Based Tracking mappings user can add</summary>
	[JsonIgnore]
	public int? MaxFolderBasedTrackingMappings
	{
		get
		{
			return TryGetValue("maxfolderbasedtrackingmappings", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxfolderbasedtrackingmappings") is false || Remove("maxfolderbasedtrackingmappings"))
			{
				Add("maxfolderbasedtrackingmappings", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Maximum active business process flows per entity, Format: None, MinValue: 1, MaxValue: 2147483647, SchemaName: MaximumActiveBusinessProcessFlowsAllowedPerEntity, IntroducedVersion: 6.0.0.0.  Description: Maximum number of active business process flows allowed per entity</summary>
	[JsonIgnore]
	public int? MaximumActiveBusinessProcessFlowsAllowedPerEntity
	{
		get
		{
			return TryGetValue("maximumactivebusinessprocessflowsallowedperentity", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maximumactivebusinessprocessflowsallowedperentity") is false || Remove("maximumactivebusinessprocessflowsallowedperentity"))
			{
				Add("maximumactivebusinessprocessflowsallowedperentity", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Product Properties Item Limit, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaximumDynamicPropertiesAllowed, IntroducedVersion: 7.0.0.0.  Description: Restrict the maximum number of product properties for a product family/bundle</summary>
	[JsonIgnore]
	public int? MaximumDynamicPropertiesAllowed
	{
		get
		{
			return TryGetValue("maximumdynamicpropertiesallowed", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maximumdynamicpropertiesallowed") is false || Remove("maximumdynamicpropertiesallowed"))
			{
				Add("maximumdynamicpropertiesallowed", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Maximum number of active SLA allowed per entity in online, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaximumEntitiesWithActiveSLA, IntroducedVersion: 8.1.0.0.  Description: Maximum number of active SLA allowed per entity in online</summary>
	[JsonIgnore]
	public int? MaximumEntitiesWithActiveSLA
	{
		get
		{
			return TryGetValue("maximumentitieswithactivesla", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maximumentitieswithactivesla") is false || Remove("maximumentitieswithactivesla"))
			{
				Add("maximumentitieswithactivesla", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Maximum number of active SLA KPI allowed per entity in online, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaximumSLAKPIPerEntityWithActiveSLA, IntroducedVersion: 8.1.0.0.  Description: Maximum number of SLA KPI per active SLA allowed for entity in online</summary>
	[JsonIgnore]
	public int? MaximumSLAKPIPerEntityWithActiveSLA
	{
		get
		{
			return TryGetValue("maximumslakpiperentitywithactivesla", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maximumslakpiperentitywithactivesla") is false || Remove("maximumslakpiperentitywithactivesla"))
			{
				Add("maximumslakpiperentitywithactivesla", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Max Tracking Number, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaximumTrackingNumber, IntroducedVersion: 5.0.0.0.  Description: Maximum tracking number before recycling takes place.</summary>
	[JsonIgnore]
	public int? MaximumTrackingNumber
	{
		get
		{
			return TryGetValue("maximumtrackingnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maximumtrackingnumber") is false || Remove("maximumtrackingnumber"))
			{
				Add("maximumtrackingnumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Bundle Item Limit, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxProductsInBundle, IntroducedVersion: 7.0.0.0.  Description: Restrict the maximum no of items in a bundle</summary>
	[JsonIgnore]
	public int? MaxProductsInBundle
	{
		get
		{
			return TryGetValue("maxproductsinbundle", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxproductsinbundle") is false || Remove("maxproductsinbundle"))
			{
				Add("maxproductsinbundle", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max Records For Excel Export, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxRecordsForExportToExcel, IntroducedVersion: 5.0.0.0.  Description: Maximum number of records that will be exported to a static Microsoft Office Excel worksheet when exporting from the grid.</summary>
	[JsonIgnore]
	public int? MaxRecordsForExportToExcel
	{
		get
		{
			return TryGetValue("maxrecordsforexporttoexcel", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxrecordsforexporttoexcel") is false || Remove("maxrecordsforexporttoexcel"))
			{
				Add("maxrecordsforexporttoexcel", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max Records Filter Selection, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxRecordsForLookupFilters, IntroducedVersion: 5.0.0.0.  Description: Maximum number of lookup and picklist records that can be selected by user for filtering.</summary>
	[JsonIgnore]
	public int? MaxRecordsForLookupFilters
	{
		get
		{
			return TryGetValue("maxrecordsforlookupfilters", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxrecordsforlookupfilters") is false || Remove("maxrecordsforlookupfilters"))
			{
				Add("maxrecordsforlookupfilters", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: MaxRollupFieldsPerEntity, Format: None, MinValue: 0, MaxValue: 50, SchemaName: MaxRollupFieldsPerEntity, IntroducedVersion: 1.0.0.0.  Description: Maximum Rollup Fields Per Entity</summary>
	[JsonIgnore]
	public int? MaxRollupFieldsPerEntity
	{
		get
		{
			return TryGetValue("maxrollupfieldsperentity", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxrollupfieldsperentity") is false || Remove("maxrollupfieldsperentity"))
			{
				Add("maxrollupfieldsperentity", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: MaxRollupFieldsPerOrg, Format: None, MinValue: 0, MaxValue: 500, SchemaName: MaxRollupFieldsPerOrg, IntroducedVersion: 1.0.0.0.  Description: Maximum Rollup Fields Per Organization</summary>
	[JsonIgnore]
	public int? MaxRollupFieldsPerOrg
	{
		get
		{
			return TryGetValue("maxrollupfieldsperorg", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxrollupfieldsperorg") is false || Remove("maxrollupfieldsperorg"))
			{
				Add("maxrollupfieldsperorg", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Max SLA Items Per SLA, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxSLAItemsPerSLA, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public int? MaxSLAItemsPerSLA
	{
		get
		{
			return TryGetValue("maxslaitemspersla", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxslaitemspersla") is false || Remove("maxslaitemspersla"))
			{
				Add("maxslaitemspersla", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max supported IE version, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxSupportedInternetExplorerVersion, IntroducedVersion: 7.0.0.0.  Description: The maximum version of IE to run browser emulation for in Outlook client</summary>
	[JsonIgnore]
	public int? MaxSupportedInternetExplorerVersion
	{
		get
		{
			return TryGetValue("maxsupportedinternetexplorerversion", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxsupportedinternetexplorerversion") is false || Remove("maxsupportedinternetexplorerversion"))
			{
				Add("maxsupportedinternetexplorerversion", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max Upload File Size, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MaxUploadFileSize, IntroducedVersion: 5.0.0.0.  Description: Maximum allowed size of an attachment.</summary>
	[JsonIgnore]
	public int? MaxUploadFileSize
	{
		get
		{
			return TryGetValue("maxuploadfilesize", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxuploadfilesize") is false || Remove("maxuploadfilesize"))
			{
				Add("maxuploadfilesize", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max No Of Mailboxes To Enable For Verbose Logging, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MaxVerboseLoggingMailbox, IntroducedVersion: 8.0.0.0.  Description: Maximum number of mailboxes that can be toggled for verbose logging</summary>
	[JsonIgnore]
	public int? MaxVerboseLoggingMailbox
	{
		get
		{
			return TryGetValue("maxverboseloggingmailbox", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxverboseloggingmailbox") is false || Remove("maxverboseloggingmailbox"))
			{
				Add("maxverboseloggingmailbox", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Maximum number of sync cycles for which verbose logging will be enabled by default, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MaxVerboseLoggingSyncCycles, IntroducedVersion: 8.0.0.0.  Description: Maximum number of sync cycles for which verbose logging will be enabled by default</summary>
	[JsonIgnore]
	public int? MaxVerboseLoggingSyncCycles
	{
		get
		{
			return TryGetValue("maxverboseloggingsynccycles", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("maxverboseloggingsynccycles") is false || Remove("maxverboseloggingsynccycles"))
			{
				Add("maxverboseloggingsynccycles", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: The last date/time for never expired metadata tracking deleted objects, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: MetadataSyncLastTimeOfNeverExpiredDeletedObjects, IntroducedVersion: 5.0.0.0.  Description: What is the last date/time where there are metadata tracking deleted objects that have never been outside of the expiration period.</summary>
	[JsonIgnore]
	public DateTime? MetadataSyncLastTimeOfNeverExpiredDeletedObjects
	{
		get
		{
			return TryGetValue("metadatasynclasttimeofneverexpireddeletedobjects", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("metadatasynclasttimeofneverexpireddeletedobjects") is false || Remove("metadatasynclasttimeofneverexpireddeletedobjects"))
			{
				Add("metadatasynclasttimeofneverexpireddeletedobjects", value);
			}
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: SystemRequired, DisplayName: Metadata sync version, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: MetadataSyncTimestamp, IntroducedVersion: 5.0.0.0.  Description: Contains the maximum version number for attributes used by metadata synchronization that have changed.</summary>
	[JsonIgnore]
	public long? MetadataSyncTimestamp
	{
		get
		{
			return TryGetValue("metadatasynctimestamp", out var value)
				? value is not null ? ((JsonElement)value).GetInt64()
				: null : null;
		}
		set
		{
			if (ContainsKey("metadatasynctimestamp") is false || Remove("metadatasynctimestamp"))
			{
				Add("metadatasynctimestamp", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Environment selected for Integration with Microsoft Flow, Format: Text, MaxLength: 1024, SchemaName: MicrosoftFlowEnvironment, IntroducedVersion: 9.0.0.0.  Description: (Deprecated) Environment selected for Integration with Microsoft Flow</summary>
	[JsonIgnore]
	public string? MicrosoftFlowEnvironment
	{
		get
		{
			return TryGetValue("microsoftflowenvironment", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("microsoftflowenvironment") is false || Remove("microsoftflowenvironment"))
			{
				Add("microsoftflowenvironment", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Min Address Synchronization Frequency, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MinAddressBookSyncInterval, IntroducedVersion: 5.0.0.0.  Description: Normal polling frequency used for address book synchronization in Microsoft Office Outlook.</summary>
	[JsonIgnore]
	public int? MinAddressBookSyncInterval
	{
		get
		{
			return TryGetValue("minaddressbooksyncinterval", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("minaddressbooksyncinterval") is false || Remove("minaddressbooksyncinterval"))
			{
				Add("minaddressbooksyncinterval", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Min Offline Synchronization Frequency, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MinOfflineSyncInterval, IntroducedVersion: 5.0.0.0.  Description: Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.</summary>
	[JsonIgnore]
	public int? MinOfflineSyncInterval
	{
		get
		{
			return TryGetValue("minofflinesyncinterval", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("minofflinesyncinterval") is false || Remove("minofflinesyncinterval"))
			{
				Add("minofflinesyncinterval", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Min Synchronization Frequency, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MinOutlookSyncInterval, IntroducedVersion: 5.0.0.0.  Description: Minimum allowed time between scheduled Outlook synchronizations.</summary>
	[JsonIgnore]
	public int? MinOutlookSyncInterval
	{
		get
		{
			return TryGetValue("minoutlooksyncinterval", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("minoutlooksyncinterval") is false || Remove("minoutlooksyncinterval"))
			{
				Add("minoutlooksyncinterval", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Minimum number of user license required for mobile offline service by production/preview organization, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MobileOfflineMinLicenseProd, IntroducedVersion: 8.0.0.0.  Description: Minimum number of user license required for mobile offline service by production/preview organization</summary>
	[JsonIgnore]
	public int? MobileOfflineMinLicenseProd
	{
		get
		{
			return TryGetValue("mobileofflineminlicenseprod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("mobileofflineminlicenseprod") is false || Remove("mobileofflineminlicenseprod"))
			{
				Add("mobileofflineminlicenseprod", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Minimum number of user license required for mobile offline service by trial organization, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: MobileOfflineMinLicenseTrial, IntroducedVersion: 8.0.0.0.  Description: Minimum number of user license required for mobile offline service by trial organization</summary>
	[JsonIgnore]
	public int? MobileOfflineMinLicenseTrial
	{
		get
		{
			return TryGetValue("mobileofflineminlicensetrial", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("mobileofflineminlicensetrial") is false || Remove("mobileofflineminlicensetrial"))
			{
				Add("mobileofflineminlicensetrial", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Sync interval for mobile offline., Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MobileOfflineSyncInterval, IntroducedVersion: 8.0.0.0.  Description: Sync interval for mobile offline.</summary>
	[JsonIgnore]
	public int? MobileOfflineSyncInterval
	{
		get
		{
			return TryGetValue("mobileofflinesyncinterval", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("mobileofflinesyncinterval") is false || Remove("mobileofflinesyncinterval"))
			{
				Add("mobileofflinesyncinterval", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Modern advanced find filtering, SchemaName: ModernAdvancedFindFiltering, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the modern advanced find filtering on all tables in a model-driven app is enabled</summary>
	[JsonIgnore]
	public string? ModernAdvancedFindFilteringFormattedValue
	{
		get
		{
			return TryGetValue("modernadvancedfindfiltering@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Modern advanced find filtering, SchemaName: ModernAdvancedFindFiltering, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the modern advanced find filtering on all tables in a model-driven app is enabled</summary>
	[JsonIgnore]
	public bool? ModernAdvancedFindFiltering
	{
		get
		{
			return TryGetValue("modernadvancedfindfiltering", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("modernadvancedfindfiltering") is false || Remove("modernadvancedfindfiltering"))
			{
				Add("modernadvancedfindfiltering", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: modernadvancedfindfiltering, SchemaName: modernadvancedfindfilteringName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? modernadvancedfindfilteringName
	{
		get
		{
			return TryGetValue("modernadvancedfindfilteringname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Coauthoring in Modern App Designer Enabled, SchemaName: ModernAppDesignerCoauthoringEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether coauthoring is enabled in modern app designer</summary>
	[JsonIgnore]
	public string? ModernAppDesignerCoauthoringEnabledFormattedValue
	{
		get
		{
			return TryGetValue("modernappdesignercoauthoringenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Coauthoring in Modern App Designer Enabled, SchemaName: ModernAppDesignerCoauthoringEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether coauthoring is enabled in modern app designer</summary>
	[JsonIgnore]
	public bool? ModernAppDesignerCoauthoringEnabled
	{
		get
		{
			return TryGetValue("modernappdesignercoauthoringenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("modernappdesignercoauthoringenabled") is false || Remove("modernappdesignercoauthoringenabled"))
			{
				Add("modernappdesignercoauthoringenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: modernappdesignercoauthoringenabled, SchemaName: modernappdesignercoauthoringenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? modernappdesignercoauthoringenabledName
	{
		get
		{
			return TryGetValue("modernappdesignercoauthoringenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the organization.</summary>
	[JsonIgnore]
	public string? ModifiedByFormattedValue
	{
		get
		{
			return TryGetValue("_modifiedby_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the organization.</summary>
	[JsonIgnore]
	public Guid? ModifiedBy
	{
		get
		{
			return TryGetValue("_modifiedby_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the organization.</summary>
	[JsonIgnore]
	public Guid? ModifiedBy_systemuser
	{
		set
		{
			if (ContainsKey("modifiedby_systemuser@odata.bind") is false || Remove("modifiedby_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("modifiedby_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_modifiedby_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ModifiedByName
	{
		get
		{
			return TryGetValue("modifiedbyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("modifiedbyname") is false || Remove("modifiedbyname"))
			{
				Add("modifiedbyname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ModifiedByYomiName
	{
		get
		{
			return TryGetValue("modifiedbyyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("modifiedbyyominame") is false || Remove("modifiedbyyominame"))
			{
				Add("modifiedbyyominame", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the organization was last modified.</summary>
	[JsonIgnore]
	public DateTime? ModifiedOn
	{
		get
		{
			return TryGetValue("modifiedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("modifiedon") is false || Remove("modifiedon"))
			{
				Add("modifiedon", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the organization.</summary>
	[JsonIgnore]
	public string? ModifiedOnBehalfByFormattedValue
	{
		get
		{
			return TryGetValue("_modifiedonbehalfby_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the organization.</summary>
	[JsonIgnore]
	public Guid? ModifiedOnBehalfBy
	{
		get
		{
			return TryGetValue("_modifiedonbehalfby_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the organization.</summary>
	[JsonIgnore]
	public Guid? ModifiedOnBehalfBy_systemuser
	{
		set
		{
			if (ContainsKey("modifiedonbehalfby_systemuser@odata.bind") is false || Remove("modifiedonbehalfby_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("modifiedonbehalfby_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_modifiedonbehalfby_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ModifiedOnBehalfByName
	{
		get
		{
			return TryGetValue("modifiedonbehalfbyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("modifiedonbehalfbyname") is false || Remove("modifiedonbehalfbyname"))
			{
				Add("modifiedonbehalfbyname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ModifiedOnBehalfByYomiName
	{
		get
		{
			return TryGetValue("modifiedonbehalfbyyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("modifiedonbehalfbyyominame") is false || Remove("modifiedonbehalfbyyominame"))
			{
				Add("modifiedonbehalfbyyominame", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Enable Multi Column Sort Editor In Views, Format: None, MinValue: 0, MaxValue: 100, SchemaName: MultiColumnSortEnabled, IntroducedVersion: 9.1.0.0.  Description: Show the sort by button on views</summary>
	[JsonIgnore]
	public int? MultiColumnSortEnabled
	{
		get
		{
			return TryGetValue("multicolumnsortenabled", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("multicolumnsortenabled") is false || Remove("multicolumnsortenabled"))
			{
				Add("multicolumnsortenabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Organization Name, Format: Text, MaxLength: 160, SchemaName: Name, IntroducedVersion: 5.0.0.0.  Description: Name of the organization. The name is set when Microsoft CRM is installed and should not be changed.</summary>
	[JsonIgnore]
	public string? Name
	{
		get
		{
			return TryGetValue("name", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("name") is false || Remove("name"))
			{
				Add("name", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Natural Language Assist, SchemaName: NaturalLanguageAssistFilter, IntroducedVersion: 9.1.0.0.  Description: Enables Natural Language Assist Filter.</summary>
	[JsonIgnore]
	public string? NaturalLanguageAssistFilterFormattedValue
	{
		get
		{
			return TryGetValue("naturallanguageassistfilter@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Natural Language Assist, SchemaName: NaturalLanguageAssistFilter, IntroducedVersion: 9.1.0.0.  Description: Enables Natural Language Assist Filter.</summary>
	[JsonIgnore]
	public bool? NaturalLanguageAssistFilter
	{
		get
		{
			return TryGetValue("naturallanguageassistfilter", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("naturallanguageassistfilter") is false || Remove("naturallanguageassistfilter"))
			{
				Add("naturallanguageassistfilter", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: naturallanguageassistfilter, SchemaName: naturallanguageassistfilterName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? naturallanguageassistfilterName
	{
		get
		{
			return TryGetValue("naturallanguageassistfiltername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Negative Currency Format, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: NegativeCurrencyFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how negative currency numbers are displayed throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public int? NegativeCurrencyFormatCode
	{
		get
		{
			return TryGetValue("negativecurrencyformatcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("negativecurrencyformatcode") is false || Remove("negativecurrencyformatcode"))
			{
				Add("negativecurrencyformatcode", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Negative Format, SchemaName: NegativeFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how negative numbers are displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? NegativeFormatCodeFormattedValue
	{
		get
		{
			return TryGetValue("negativeformatcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Negative Format, SchemaName: NegativeFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how negative numbers are displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public int? NegativeFormatCode
	{
		get
		{
			return TryGetValue("negativeformatcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("negativeformatcode") is false || Remove("negativeformatcode"))
			{
				Add("negativeformatcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: negativeformatcode, SchemaName: NegativeFormatCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? NegativeFormatCodeName
	{
		get
		{
			return TryGetValue("negativeformatcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Oct 2020 Search enabled, SchemaName: NewSearchExperienceEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether an organization has enabled the new Relevance search experience (released in Oct 2020) for the organization</summary>
	[JsonIgnore]
	public string? NewSearchExperienceEnabledFormattedValue
	{
		get
		{
			return TryGetValue("newsearchexperienceenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Oct 2020 Search enabled, SchemaName: NewSearchExperienceEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether an organization has enabled the new Relevance search experience (released in Oct 2020) for the organization</summary>
	[JsonIgnore]
	public bool? NewSearchExperienceEnabled
	{
		get
		{
			return TryGetValue("newsearchexperienceenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("newsearchexperienceenabled") is false || Remove("newsearchexperienceenabled"))
			{
				Add("newsearchexperienceenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: newsearchexperienceenabled, SchemaName: newsearchexperienceenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? newsearchexperienceenabledName
	{
		get
		{
			return TryGetValue("newsearchexperienceenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Next Entity Type Code, Format: None, MinValue: 10000, MaxValue: 2147483647, SchemaName: NextCustomObjectTypeCode, IntroducedVersion: 5.0.0.0.  Description: Next entity type code to use for custom entities.</summary>
	[JsonIgnore]
	public int? NextCustomObjectTypeCode
	{
		get
		{
			return TryGetValue("nextcustomobjecttypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("nextcustomobjecttypecode") is false || Remove("nextcustomobjecttypecode"))
			{
				Add("nextcustomobjecttypecode", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Next Tracking Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: NextTrackingNumber, IntroducedVersion: 5.0.0.0.  Description: Next token to be placed on the subject line of an email message.</summary>
	[JsonIgnore]
	public int? NextTrackingNumber
	{
		get
		{
			return TryGetValue("nexttrackingnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("nexttrackingnumber") is false || Remove("nexttrackingnumber"))
			{
				Add("nexttrackingnumber", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Notify Mailbox Owner Of Email Server Level Alerts, SchemaName: NotifyMailboxOwnerOfEmailServerLevelAlerts, IntroducedVersion: 6.0.0.0.  Description: Indicates whether mailbox owners will be notified of email server profile level alerts.</summary>
	[JsonIgnore]
	public string? NotifyMailboxOwnerOfEmailServerLevelAlertsFormattedValue
	{
		get
		{
			return TryGetValue("notifymailboxownerofemailserverlevelalerts@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Notify Mailbox Owner Of Email Server Level Alerts, SchemaName: NotifyMailboxOwnerOfEmailServerLevelAlerts, IntroducedVersion: 6.0.0.0.  Description: Indicates whether mailbox owners will be notified of email server profile level alerts.</summary>
	[JsonIgnore]
	public bool? NotifyMailboxOwnerOfEmailServerLevelAlerts
	{
		get
		{
			return TryGetValue("notifymailboxownerofemailserverlevelalerts", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("notifymailboxownerofemailserverlevelalerts") is false || Remove("notifymailboxownerofemailserverlevelalerts"))
			{
				Add("notifymailboxownerofemailserverlevelalerts", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Number Format, Format: Text, MaxLength: 2, SchemaName: NumberFormat, IntroducedVersion: 5.0.0.0.  Description: Specification of how numbers are displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? NumberFormat
	{
		get
		{
			return TryGetValue("numberformat", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("numberformat") is false || Remove("numberformat"))
			{
				Add("numberformat", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Number Grouping Format, Format: Text, MaxLength: 50, SchemaName: NumberGroupFormat, IntroducedVersion: 5.0.0.0.  Description: Specifies how numbers are grouped in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? NumberGroupFormat
	{
		get
		{
			return TryGetValue("numbergroupformat", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("numbergroupformat") is false || Remove("numbergroupformat"))
			{
				Add("numbergroupformat", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Number Separator, Format: Text, MaxLength: 5, SchemaName: NumberSeparator, IntroducedVersion: 5.0.0.0.  Description: Symbol used for number separation in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? NumberSeparator
	{
		get
		{
			return TryGetValue("numberseparator", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("numberseparator") is false || Remove("numberseparator"))
			{
				Add("numberseparator", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Office Apps Auto Deployment for this Organization, SchemaName: OfficeAppsAutoDeploymentEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the Office Apps auto deployment is enabled for the organization.</summary>
	[JsonIgnore]
	public string? OfficeAppsAutoDeploymentEnabledFormattedValue
	{
		get
		{
			return TryGetValue("officeappsautodeploymentenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Office Apps Auto Deployment for this Organization, SchemaName: OfficeAppsAutoDeploymentEnabled, IntroducedVersion: 8.0.0.0.  Description: Indicates whether the Office Apps auto deployment is enabled for the organization.</summary>
	[JsonIgnore]
	public bool? OfficeAppsAutoDeploymentEnabled
	{
		get
		{
			return TryGetValue("officeappsautodeploymentenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("officeappsautodeploymentenabled") is false || Remove("officeappsautodeploymentenabled"))
			{
				Add("officeappsautodeploymentenabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: The url to open the Delve, Format: Text, MaxLength: 1000, SchemaName: OfficeGraphDelveUrl, IntroducedVersion: 8.0.0.0.  Description: The url to open the Delve for the organization.</summary>
	[JsonIgnore]
	public string? OfficeGraphDelveUrl
	{
		get
		{
			return TryGetValue("officegraphdelveurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("officegraphdelveurl") is false || Remove("officegraphdelveurl"))
			{
				Add("officegraphdelveurl", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable OOB Price calculation, SchemaName: OOBPriceCalculationEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable OOB pricing calculation logic for Opportunity, Quote, Order and Invoice entities.</summary>
	[JsonIgnore]
	public string? OOBPriceCalculationEnabledFormattedValue
	{
		get
		{
			return TryGetValue("oobpricecalculationenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable OOB Price calculation, SchemaName: OOBPriceCalculationEnabled, IntroducedVersion: 7.0.0.0.  Description: Enable OOB pricing calculation logic for Opportunity, Quote, Order and Invoice entities.</summary>
	[JsonIgnore]
	public bool? OOBPriceCalculationEnabled
	{
		get
		{
			return TryGetValue("oobpricecalculationenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("oobpricecalculationenabled") is false || Remove("oobpricecalculationenabled"))
			{
				Add("oobpricecalculationenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Opt-out of schema v2 being automatically enabled for this organization., SchemaName: OptOutSchemaV2EnabledByDefault, IntroducedVersion: 1.5.11.0.  Description: Indicates if this organization will opt-out from automatically enabling schema v2 on the organization.</summary>
	[JsonIgnore]
	public string? OptOutSchemaV2EnabledByDefaultFormattedValue
	{
		get
		{
			return TryGetValue("optoutschemav2enabledbydefault@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Opt-out of schema v2 being automatically enabled for this organization., SchemaName: OptOutSchemaV2EnabledByDefault, IntroducedVersion: 1.5.11.0.  Description: Indicates if this organization will opt-out from automatically enabling schema v2 on the organization.</summary>
	[JsonIgnore]
	public bool? OptOutSchemaV2EnabledByDefault
	{
		get
		{
			return TryGetValue("optoutschemav2enabledbydefault", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("optoutschemav2enabledbydefault") is false || Remove("optoutschemav2enabledbydefault"))
			{
				Add("optoutschemav2enabledbydefault", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: optoutschemav2enabledbydefault, SchemaName: optoutschemav2enabledbydefaultName, IntroducedVersion: 1.5.11.0. </summary>
	[JsonIgnore]
	public object? optoutschemav2enabledbydefaultName
	{
		get
		{
			return TryGetValue("optoutschemav2enabledbydefaultname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Order Prefix, Format: Text, MaxLength: 20, SchemaName: OrderPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix to use for all orders throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? OrderPrefix
	{
		get
		{
			return TryGetValue("orderprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("orderprefix") is false || Remove("orderprefix"))
			{
				Add("orderprefix", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Organization, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the organization.</summary>
	[JsonIgnore]
	public Guid? OrganizationId
	{
		get
		{
			return TryGetValue("organizationid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("organizationid") is false || Remove("organizationid"))
			{
				Add("organizationid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Organization State, SchemaName: OrganizationState, IntroducedVersion: 9.0.0.0.  Description: Indicates the organization lifecycle state</summary>
	[JsonIgnore]
	public string? OrganizationStateFormattedValue
	{
		get
		{
			return TryGetValue("organizationstate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Organization State, SchemaName: OrganizationState, IntroducedVersion: 9.0.0.0.  Description: Indicates the organization lifecycle state</summary>
	[JsonIgnore]
	public int? OrganizationState
	{
		get
		{
			return TryGetValue("organizationstate", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("organizationstate") is false || Remove("organizationstate"))
			{
				Add("organizationstate", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Organization Database Organization Settings, Format: Text, MaxLength: 1073741823, SchemaName: OrgDbOrgSettings, IntroducedVersion: 5.0.0.0.  Description: Organization settings stored in Organization Database.</summary>
	[JsonIgnore]
	public string? OrgDbOrgSettings
	{
		get
		{
			return TryGetValue("orgdborgsettings", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("orgdborgsettings") is false || Remove("orgdborgsettings"))
			{
				Add("orgdborgsettings", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable OrgInsights for this Organization, SchemaName: OrgInsightsEnabled, IntroducedVersion: 8.1.0.0.  Description: Select whether to turn on OrgInsights for the organization.</summary>
	[JsonIgnore]
	public string? OrgInsightsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("orginsightsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable OrgInsights for this Organization, SchemaName: OrgInsightsEnabled, IntroducedVersion: 8.1.0.0.  Description: Select whether to turn on OrgInsights for the organization.</summary>
	[JsonIgnore]
	public bool? OrgInsightsEnabled
	{
		get
		{
			return TryGetValue("orginsightsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("orginsightsenabled") is false || Remove("orginsightsenabled"))
			{
				Add("orginsightsenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Display Preview Feature for this organization, SchemaName: PaiPreviewScenarioEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Preview feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public string? PaiPreviewScenarioEnabledFormattedValue
	{
		get
		{
			return TryGetValue("paipreviewscenarioenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Display Preview Feature for this organization, SchemaName: PaiPreviewScenarioEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Preview feature has been enabled for the organization.</summary>
	[JsonIgnore]
	public bool? PaiPreviewScenarioEnabled
	{
		get
		{
			return TryGetValue("paipreviewscenarioenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("paipreviewscenarioenabled") is false || Remove("paipreviewscenarioenabled"))
			{
				Add("paipreviewscenarioenabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Parsed Table Column Prefix, Format: Text, MaxLength: 20, SchemaName: ParsedTableColumnPrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix used for parsed table columns.</summary>
	[JsonIgnore]
	public string? ParsedTableColumnPrefix
	{
		get
		{
			return TryGetValue("parsedtablecolumnprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parsedtablecolumnprefix") is false || Remove("parsedtablecolumnprefix"))
			{
				Add("parsedtablecolumnprefix", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Parsed Table Prefix, Format: Text, MaxLength: 20, SchemaName: ParsedTablePrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix used for parsed tables.</summary>
	[JsonIgnore]
	public string? ParsedTablePrefix
	{
		get
		{
			return TryGetValue("parsedtableprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parsedtableprefix") is false || Remove("parsedtableprefix"))
			{
				Add("parsedtableprefix", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Past Expansion Window, Format: None, MinValue: 1, MaxValue: 120, SchemaName: PastExpansionWindow, IntroducedVersion: 5.0.0.0.  Description: Specifies the maximum number of months in past for which the recurring activities can be created.</summary>
	[JsonIgnore]
	public int? PastExpansionWindow
	{
		get
		{
			return TryGetValue("pastexpansionwindow", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("pastexpansionwindow") is false || Remove("pastexpansionwindow"))
			{
				Add("pastexpansionwindow", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Enable modern grids in model-driven apps, Format: Text, MaxLength: 16, SchemaName: PcfDatasetGridEnabled, IntroducedVersion: 9.1.0.0.  Description: Leave empty to use default setting. Set to on/off to enable/disable replacement of default grids with modern ones in model-driven apps.</summary>
	[JsonIgnore]
	public string? PcfDatasetGridEnabled
	{
		get
		{
			return TryGetValue("pcfdatasetgridenabled", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("pcfdatasetgridenabled") is false || Remove("pcfdatasetgridenabled"))
			{
				Add("pcfdatasetgridenabled", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: PerformACTSyncAfter, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: PerformACTSyncAfter, IntroducedVersion: 9.2.0.0.  Description: This setting contains the date time before an ACT sync can execute.</summary>
	[JsonIgnore]
	public DateTime? PerformACTSyncAfter
	{
		get
		{
			return TryGetValue("performactsyncafter", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("performactsyncafter") is false || Remove("performactsyncafter"))
			{
				Add("performactsyncafter", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Picture, Format: TextArea, MaxLength: 1073741823, SchemaName: Picture, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? Picture
	{
		get
		{
			return TryGetValue("picture", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("picture") is false || Remove("picture"))
			{
				Add("picture", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, Format: Locale, MinValue: 0, MaxValue: 2147483647, SchemaName: PinpointLanguageCode, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public int? PinpointLanguageCode
	{
		get
		{
			return TryGetValue("pinpointlanguagecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("pinpointlanguagecode") is false || Remove("pinpointlanguagecode"))
			{
				Add("pinpointlanguagecode", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Plug-in Trace Log Setting, SchemaName: PluginTraceLogSetting, IntroducedVersion: 7.1.0.0.  Description: Plug-in Trace Log Setting for the Organization.</summary>
	[JsonIgnore]
	public string? PluginTraceLogSettingFormattedValue
	{
		get
		{
			return TryGetValue("plugintracelogsetting@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Plug-in Trace Log Setting, SchemaName: PluginTraceLogSetting, IntroducedVersion: 7.1.0.0.  Description: Plug-in Trace Log Setting for the Organization.</summary>
	[JsonIgnore]
	public int? PluginTraceLogSetting
	{
		get
		{
			return TryGetValue("plugintracelogsetting", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("plugintracelogsetting") is false || Remove("plugintracelogsetting"))
			{
				Add("plugintracelogsetting", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: plugintracelogsetting, SchemaName: PluginTraceLogSettingName, IntroducedVersion: 7.1.0.0. </summary>
	[JsonIgnore]
	public object? PluginTraceLogSettingName
	{
		get
		{
			return TryGetValue("plugintracelogsettingname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: PM Designator, Format: Text, MaxLength: 25, SchemaName: PMDesignator, IntroducedVersion: 5.0.0.0.  Description: PM designator to use throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? PMDesignator
	{
		get
		{
			return TryGetValue("pmdesignator", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("pmdesignator") is false || Remove("pmdesignator"))
			{
				Add("pmdesignator", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: For internal use only., Format: Text, MaxLength: 500, SchemaName: PostMessageWhitelistDomains, IntroducedVersion: 8.2.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? PostMessageWhitelistDomains
	{
		get
		{
			return TryGetValue("postmessagewhitelistdomains", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("postmessagewhitelistdomains") is false || Remove("postmessagewhitelistdomains"))
			{
				Add("postmessagewhitelistdomains", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Enable bot for makers., SchemaName: PowerAppsMakerBotEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether bot for makers is enabled.</summary>
	[JsonIgnore]
	public string? PowerAppsMakerBotEnabledFormattedValue
	{
		get
		{
			return TryGetValue("powerappsmakerbotenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Enable bot for makers., SchemaName: PowerAppsMakerBotEnabled, IntroducedVersion: 9.1.0.0.  Description: Indicates whether bot for makers is enabled.</summary>
	[JsonIgnore]
	public bool? PowerAppsMakerBotEnabled
	{
		get
		{
			return TryGetValue("powerappsmakerbotenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("powerappsmakerbotenabled") is false || Remove("powerappsmakerbotenabled"))
			{
				Add("powerappsmakerbotenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: powerappsmakerbotenabled, SchemaName: powerappsmakerbotenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? powerappsmakerbotenabledName
	{
		get
		{
			return TryGetValue("powerappsmakerbotenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Power BI allow cross region operations, SchemaName: PowerBIAllowCrossRegionOperations, IntroducedVersion: 9.1.0.0.  Description: Indicates whether cross region operations are allowed for the organization</summary>
	[JsonIgnore]
	public string? PowerBIAllowCrossRegionOperationsFormattedValue
	{
		get
		{
			return TryGetValue("powerbiallowcrossregionoperations@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Power BI allow cross region operations, SchemaName: PowerBIAllowCrossRegionOperations, IntroducedVersion: 9.1.0.0.  Description: Indicates whether cross region operations are allowed for the organization</summary>
	[JsonIgnore]
	public bool? PowerBIAllowCrossRegionOperations
	{
		get
		{
			return TryGetValue("powerbiallowcrossregionoperations", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("powerbiallowcrossregionoperations") is false || Remove("powerbiallowcrossregionoperations"))
			{
				Add("powerbiallowcrossregionoperations", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: powerbiallowcrossregionoperations, SchemaName: powerbiallowcrossregionoperationsName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? powerbiallowcrossregionoperationsName
	{
		get
		{
			return TryGetValue("powerbiallowcrossregionoperationsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Power BI automatic permissions assignment, SchemaName: PowerBIAutomaticPermissionsAssignment, IntroducedVersion: 9.1.0.0.  Description: Indicates whether automatic permissions assignment to Power BI has been enabled for the organization</summary>
	[JsonIgnore]
	public string? PowerBIAutomaticPermissionsAssignmentFormattedValue
	{
		get
		{
			return TryGetValue("powerbiautomaticpermissionsassignment@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Power BI automatic permissions assignment, SchemaName: PowerBIAutomaticPermissionsAssignment, IntroducedVersion: 9.1.0.0.  Description: Indicates whether automatic permissions assignment to Power BI has been enabled for the organization</summary>
	[JsonIgnore]
	public bool? PowerBIAutomaticPermissionsAssignment
	{
		get
		{
			return TryGetValue("powerbiautomaticpermissionsassignment", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("powerbiautomaticpermissionsassignment") is false || Remove("powerbiautomaticpermissionsassignment"))
			{
				Add("powerbiautomaticpermissionsassignment", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: powerbiautomaticpermissionsassignment, SchemaName: powerbiautomaticpermissionsassignmentName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? powerbiautomaticpermissionsassignmentName
	{
		get
		{
			return TryGetValue("powerbiautomaticpermissionsassignmentname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Power BI components creation, SchemaName: PowerBIComponentsCreate, IntroducedVersion: 9.1.0.0.  Description: Indicates whether creation of Power BI components has been enabled for the organization</summary>
	[JsonIgnore]
	public string? PowerBIComponentsCreateFormattedValue
	{
		get
		{
			return TryGetValue("powerbicomponentscreate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Power BI components creation, SchemaName: PowerBIComponentsCreate, IntroducedVersion: 9.1.0.0.  Description: Indicates whether creation of Power BI components has been enabled for the organization</summary>
	[JsonIgnore]
	public bool? PowerBIComponentsCreate
	{
		get
		{
			return TryGetValue("powerbicomponentscreate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("powerbicomponentscreate") is false || Remove("powerbicomponentscreate"))
			{
				Add("powerbicomponentscreate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: powerbicomponentscreate, SchemaName: powerbicomponentscreateName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? powerbicomponentscreateName
	{
		get
		{
			return TryGetValue("powerbicomponentscreatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Power BI feature for this Organization, SchemaName: PowerBiFeatureEnabled, IntroducedVersion: 8.1.0.0.  Description: Indicates whether the Power BI feature should be enabled for the organization.</summary>
	[JsonIgnore]
	public string? PowerBiFeatureEnabledFormattedValue
	{
		get
		{
			return TryGetValue("powerbifeatureenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Power BI feature for this Organization, SchemaName: PowerBiFeatureEnabled, IntroducedVersion: 8.1.0.0.  Description: Indicates whether the Power BI feature should be enabled for the organization.</summary>
	[JsonIgnore]
	public bool? PowerBiFeatureEnabled
	{
		get
		{
			return TryGetValue("powerbifeatureenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("powerbifeatureenabled") is false || Remove("powerbifeatureenabled"))
			{
				Add("powerbifeatureenabled", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Pricing Decimal Precision, Format: None, MinValue: 0, MaxValue: 10, SchemaName: PricingDecimalPrecision, IntroducedVersion: 5.0.0.0.  Description: Number of decimal places that can be used for prices.</summary>
	[JsonIgnore]
	public int? PricingDecimalPrecision
	{
		get
		{
			return TryGetValue("pricingdecimalprecision", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("pricingdecimalprecision") is false || Remove("pricingdecimalprecision"))
			{
				Add("pricingdecimalprecision", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Privacy Statement URL, Format: Text, MaxLength: 500, SchemaName: PrivacyStatementUrl, IntroducedVersion: 7.1.0.0.  Description: Privacy Statement URL</summary>
	[JsonIgnore]
	public string? PrivacyStatementUrl
	{
		get
		{
			return TryGetValue("privacystatementurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("privacystatementurl") is false || Remove("privacystatementurl"))
			{
				Add("privacystatementurl", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Privilege User Group, SchemaName: PrivilegeUserGroupId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default privilege for users in the organization.</summary>
	[JsonIgnore]
	public Guid? PrivilegeUserGroupId
	{
		get
		{
			return TryGetValue("privilegeusergroupid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("privilegeusergroupid") is false || Remove("privilegeusergroupid"))
			{
				Add("privilegeusergroupid", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Privilege Reporting Group, SchemaName: PrivReportingGroupId, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? PrivReportingGroupId
	{
		get
		{
			return TryGetValue("privreportinggroupid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("privreportinggroupid") is false || Remove("privreportinggroupid"))
			{
				Add("privreportinggroupid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Privilege Reporting Group Name, Format: Text, MaxLength: 256, SchemaName: PrivReportingGroupName, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? PrivReportingGroupName
	{
		get
		{
			return TryGetValue("privreportinggroupname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("privreportinggroupname") is false || Remove("privreportinggroupname"))
			{
				Add("privreportinggroupname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Product Recommendations for this Organization, SchemaName: ProductRecommendationsEnabled, IntroducedVersion: 8.1.0.0.  Description: Select whether to turn on product recommendations for the organization.</summary>
	[JsonIgnore]
	public string? ProductRecommendationsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("productrecommendationsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Product Recommendations for this Organization, SchemaName: ProductRecommendationsEnabled, IntroducedVersion: 8.1.0.0.  Description: Select whether to turn on product recommendations for the organization.</summary>
	[JsonIgnore]
	public bool? ProductRecommendationsEnabled
	{
		get
		{
			return TryGetValue("productrecommendationsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("productrecommendationsenabled") is false || Remove("productrecommendationsenabled"))
			{
				Add("productrecommendationsenabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Enable New Qualify Lead Experience with configuration MDD, Format: Text, MaxLength: 1000, SchemaName: QualifyLeadAdditionalOptions, IntroducedVersion: 9.1.0.0.  Description: Indicates whether prompt should be shown for new Qualify Lead Experience</summary>
	[JsonIgnore]
	public string? QualifyLeadAdditionalOptions
	{
		get
		{
			return TryGetValue("qualifyleadadditionaloptions", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("qualifyleadadditionaloptions") is false || Remove("qualifyleadadditionaloptions"))
			{
				Add("qualifyleadadditionaloptions", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable quick actions to open records in search side pane, SchemaName: QuickActionToOpenRecordsInSidePaneEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the feature to use quick action to open records in search side pane is enabled</summary>
	[JsonIgnore]
	public string? QuickActionToOpenRecordsInSidePaneEnabledFormattedValue
	{
		get
		{
			return TryGetValue("quickactiontoopenrecordsinsidepaneenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable quick actions to open records in search side pane, SchemaName: QuickActionToOpenRecordsInSidePaneEnabled, IntroducedVersion: 9.1.0.0.  Description: Flag to indicate if the feature to use quick action to open records in search side pane is enabled</summary>
	[JsonIgnore]
	public bool? QuickActionToOpenRecordsInSidePaneEnabled
	{
		get
		{
			return TryGetValue("quickactiontoopenrecordsinsidepaneenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("quickactiontoopenrecordsinsidepaneenabled") is false || Remove("quickactiontoopenrecordsinsidepaneenabled"))
			{
				Add("quickactiontoopenrecordsinsidepaneenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: quickactiontoopenrecordsinsidepaneenabled, SchemaName: quickactiontoopenrecordsinsidepaneenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? quickactiontoopenrecordsinsidepaneenabledName
	{
		get
		{
			return TryGetValue("quickactiontoopenrecordsinsidepaneenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Quick Find Record Limit Enabled, SchemaName: QuickFindRecordLimitEnabled, IntroducedVersion: 5.0.0.0.  Description: Indicates whether a quick find record limit should be enabled for this organization (allows for faster Quick Find queries but prevents overly broad searches).</summary>
	[JsonIgnore]
	public string? QuickFindRecordLimitEnabledFormattedValue
	{
		get
		{
			return TryGetValue("quickfindrecordlimitenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Quick Find Record Limit Enabled, SchemaName: QuickFindRecordLimitEnabled, IntroducedVersion: 5.0.0.0.  Description: Indicates whether a quick find record limit should be enabled for this organization (allows for faster Quick Find queries but prevents overly broad searches).</summary>
	[JsonIgnore]
	public bool? QuickFindRecordLimitEnabled
	{
		get
		{
			return TryGetValue("quickfindrecordlimitenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("quickfindrecordlimitenabled") is false || Remove("quickfindrecordlimitenabled"))
			{
				Add("quickfindrecordlimitenabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Quote Prefix, Format: Text, MaxLength: 20, SchemaName: QuotePrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix to use for all quotes throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? QuotePrefix
	{
		get
		{
			return TryGetValue("quoteprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("quoteprefix") is false || Remove("quoteprefix"))
			{
				Add("quoteprefix", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether SLA Recalculation has been enabled for the organization, SchemaName: RecalculateSLA, IntroducedVersion: 9.1.0.0.  Description: Indicates whether SLA Recalculation has been enabled for the organization</summary>
	[JsonIgnore]
	public string? RecalculateSLAFormattedValue
	{
		get
		{
			return TryGetValue("recalculatesla@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether SLA Recalculation has been enabled for the organization, SchemaName: RecalculateSLA, IntroducedVersion: 9.1.0.0.  Description: Indicates whether SLA Recalculation has been enabled for the organization</summary>
	[JsonIgnore]
	public bool? RecalculateSLA
	{
		get
		{
			return TryGetValue("recalculatesla", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("recalculatesla") is false || Remove("recalculatesla"))
			{
				Add("recalculatesla", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: recalculatesla, SchemaName: recalculateslaName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? recalculateslaName
	{
		get
		{
			return TryGetValue("recalculateslaname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Recurrence Default Number of Occurrences, Format: None, MinValue: 1, MaxValue: 999, SchemaName: RecurrenceDefaultNumberOfOccurrences, IntroducedVersion: 5.0.0.0.  Description: Specifies the default value for number of occurrences field in the recurrence dialog.</summary>
	[JsonIgnore]
	public int? RecurrenceDefaultNumberOfOccurrences
	{
		get
		{
			return TryGetValue("recurrencedefaultnumberofoccurrences", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("recurrencedefaultnumberofoccurrences") is false || Remove("recurrencedefaultnumberofoccurrences"))
			{
				Add("recurrencedefaultnumberofoccurrences", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Recurrence Expansion Job Batch Interval, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: RecurrenceExpansionJobBatchInterval, IntroducedVersion: 5.0.0.0.  Description: Specifies the interval (in seconds) for pausing expansion job.</summary>
	[JsonIgnore]
	public int? RecurrenceExpansionJobBatchInterval
	{
		get
		{
			return TryGetValue("recurrenceexpansionjobbatchinterval", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("recurrenceexpansionjobbatchinterval") is false || Remove("recurrenceexpansionjobbatchinterval"))
			{
				Add("recurrenceexpansionjobbatchinterval", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Recurrence Expansion On Demand Job Batch Size, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: RecurrenceExpansionJobBatchSize, IntroducedVersion: 5.0.0.0.  Description: Specifies the value for number of instances created in on demand job in one shot.</summary>
	[JsonIgnore]
	public int? RecurrenceExpansionJobBatchSize
	{
		get
		{
			return TryGetValue("recurrenceexpansionjobbatchsize", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("recurrenceexpansionjobbatchsize") is false || Remove("recurrenceexpansionjobbatchsize"))
			{
				Add("recurrenceexpansionjobbatchsize", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Recurrence Expansion Synchronization Create Maximum, Format: None, MinValue: 1, MaxValue: 1000, SchemaName: RecurrenceExpansionSynchCreateMax, IntroducedVersion: 5.0.0.0.  Description: Specifies the maximum number of instances to be created synchronously after creating a recurring appointment.</summary>
	[JsonIgnore]
	public int? RecurrenceExpansionSynchCreateMax
	{
		get
		{
			return TryGetValue("recurrenceexpansionsynchcreatemax", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("recurrenceexpansionsynchcreatemax") is false || Remove("recurrenceexpansionsynchcreatemax"))
			{
				Add("recurrenceexpansionsynchcreatemax", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Reference SiteMap XML, Format: Text, MaxLength: 1073741823, SchemaName: ReferenceSiteMapXml, IntroducedVersion: 5.0.0.0.  Description: XML string that defines the navigation structure for the application. This is the site map from the previously upgraded build and is used in a 3-way merge during upgrade.</summary>
	[JsonIgnore]
	public string? ReferenceSiteMapXml
	{
		get
		{
			return TryGetValue("referencesitemapxml", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("referencesitemapxml") is false || Remove("referencesitemapxml"))
			{
				Add("referencesitemapxml", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Current orgnization release cadence value, Format: None, MinValue: 0, MaxValue: 100, SchemaName: ReleaseCadence, IntroducedVersion: 9.2.0.0.  Description: Current orgnization release cadence value</summary>
	[JsonIgnore]
	public int? ReleaseCadence
	{
		get
		{
			return TryGetValue("releasecadence", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("releasecadence") is false || Remove("releasecadence"))
			{
				Add("releasecadence", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Model app refresh channel, SchemaName: ReleaseChannel, IntroducedVersion: 9.1.0.0.  Description: Model app refresh channel</summary>
	[JsonIgnore]
	public string? ReleaseChannelFormattedValue
	{
		get
		{
			return TryGetValue("releasechannel@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Model app refresh channel, SchemaName: ReleaseChannel, IntroducedVersion: 9.1.0.0.  Description: Model app refresh channel</summary>
	[JsonIgnore]
	public int? ReleaseChannel
	{
		get
		{
			return TryGetValue("releasechannel", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("releasechannel") is false || Remove("releasechannel"))
			{
				Add("releasechannel", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: releasechannel, SchemaName: releasechannelName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? releasechannelName
	{
		get
		{
			return TryGetValue("releasechannelname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Release Wave, Format: Text, MaxLength: 200, SchemaName: ReleaseWaveName, IntroducedVersion: 9.1.0.0.  Description: Release Wave Applied to Environment.</summary>
	[JsonIgnore]
	public string? ReleaseWaveName
	{
		get
		{
			return TryGetValue("releasewavename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("releasewavename") is false || Remove("releasewavename"))
			{
				Add("releasewavename", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Relevance search enabled automatically by Dataverse, SchemaName: RelevanceSearchEnabledByPlatform, IntroducedVersion: 9.1.0.0.  Description: Indicates whether relevance search was enabled for the environment as part of Dataverse's relevance search on-by-default sweep</summary>
	[JsonIgnore]
	public string? RelevanceSearchEnabledByPlatformFormattedValue
	{
		get
		{
			return TryGetValue("relevancesearchenabledbyplatform@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Relevance search enabled automatically by Dataverse, SchemaName: RelevanceSearchEnabledByPlatform, IntroducedVersion: 9.1.0.0.  Description: Indicates whether relevance search was enabled for the environment as part of Dataverse's relevance search on-by-default sweep</summary>
	[JsonIgnore]
	public bool? RelevanceSearchEnabledByPlatform
	{
		get
		{
			return TryGetValue("relevancesearchenabledbyplatform", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("relevancesearchenabledbyplatform") is false || Remove("relevancesearchenabledbyplatform"))
			{
				Add("relevancesearchenabledbyplatform", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: relevancesearchenabledbyplatform, SchemaName: relevancesearchenabledbyplatformName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? relevancesearchenabledbyplatformName
	{
		get
		{
			return TryGetValue("relevancesearchenabledbyplatformname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: RelevanceSearchModifiedOnDate, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: RelevanceSearchModifiedOn, IntroducedVersion: 9.1.0.0.  Description: This setting contains the last modified date for relevance search setting that appears as a toggle in PPAC.</summary>
	[JsonIgnore]
	public DateTime? RelevanceSearchModifiedOn
	{
		get
		{
			return TryGetValue("relevancesearchmodifiedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("relevancesearchmodifiedon") is false || Remove("relevancesearchmodifiedon"))
			{
				Add("relevancesearchmodifiedon", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Render Secure Frame For Email, SchemaName: RenderSecureIFrameForEmail, IntroducedVersion: 5.0.0.0.  Description: Flag to render the body of email in the Web form in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.</summary>
	[JsonIgnore]
	public string? RenderSecureIFrameForEmailFormattedValue
	{
		get
		{
			return TryGetValue("rendersecureiframeforemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Render Secure Frame For Email, SchemaName: RenderSecureIFrameForEmail, IntroducedVersion: 5.0.0.0.  Description: Flag to render the body of email in the Web form in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.</summary>
	[JsonIgnore]
	public bool? RenderSecureIFrameForEmail
	{
		get
		{
			return TryGetValue("rendersecureiframeforemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("rendersecureiframeforemail") is false || Remove("rendersecureiframeforemail"))
			{
				Add("rendersecureiframeforemail", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Reporting Group, SchemaName: ReportingGroupId, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? ReportingGroupId
	{
		get
		{
			return TryGetValue("reportinggroupid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("reportinggroupid") is false || Remove("reportinggroupid"))
			{
				Add("reportinggroupid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Reporting Group Name, Format: Text, MaxLength: 256, SchemaName: ReportingGroupName, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? ReportingGroupName
	{
		get
		{
			return TryGetValue("reportinggroupname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("reportinggroupname") is false || Remove("reportinggroupname"))
			{
				Add("reportinggroupname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Report Script Errors, SchemaName: ReportScriptErrors, IntroducedVersion: 5.0.0.0.  Description: Picklist for selecting the organization preference for reporting scripting errors.</summary>
	[JsonIgnore]
	public string? ReportScriptErrorsFormattedValue
	{
		get
		{
			return TryGetValue("reportscripterrors@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Report Script Errors, SchemaName: ReportScriptErrors, IntroducedVersion: 5.0.0.0.  Description: Picklist for selecting the organization preference for reporting scripting errors.</summary>
	[JsonIgnore]
	public int? ReportScriptErrors
	{
		get
		{
			return TryGetValue("reportscripterrors", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("reportscripterrors") is false || Remove("reportscripterrors"))
			{
				Add("reportscripterrors", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: reportscripterrors, SchemaName: ReportScriptErrorsName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ReportScriptErrorsName
	{
		get
		{
			return TryGetValue("reportscripterrorsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Approval For Queue Email Required, SchemaName: RequireApprovalForQueueEmail, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Send As Other User privilege is enabled.</summary>
	[JsonIgnore]
	public string? RequireApprovalForQueueEmailFormattedValue
	{
		get
		{
			return TryGetValue("requireapprovalforqueueemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Approval For Queue Email Required, SchemaName: RequireApprovalForQueueEmail, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Send As Other User privilege is enabled.</summary>
	[JsonIgnore]
	public bool? RequireApprovalForQueueEmail
	{
		get
		{
			return TryGetValue("requireapprovalforqueueemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("requireapprovalforqueueemail") is false || Remove("requireapprovalforqueueemail"))
			{
				Add("requireapprovalforqueueemail", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Approval For User Email Required, SchemaName: RequireApprovalForUserEmail, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Send As Other User privilege is enabled.</summary>
	[JsonIgnore]
	public string? RequireApprovalForUserEmailFormattedValue
	{
		get
		{
			return TryGetValue("requireapprovalforuseremail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Approval For User Email Required, SchemaName: RequireApprovalForUserEmail, IntroducedVersion: 5.0.0.0.  Description: Indicates whether Send As Other User privilege is enabled.</summary>
	[JsonIgnore]
	public bool? RequireApprovalForUserEmail
	{
		get
		{
			return TryGetValue("requireapprovalforuseremail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("requireapprovalforuseremail") is false || Remove("requireapprovalforuseremail"))
			{
				Add("requireapprovalforuseremail", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Apply same email address to all unresolved matches when you manually resolve it for one, SchemaName: ResolveSimilarUnresolvedEmailAddress, IntroducedVersion: 9.0.0.0.  Description: Apply same email address to all unresolved matches when you manually resolve it for one</summary>
	[JsonIgnore]
	public string? ResolveSimilarUnresolvedEmailAddressFormattedValue
	{
		get
		{
			return TryGetValue("resolvesimilarunresolvedemailaddress@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Apply same email address to all unresolved matches when you manually resolve it for one, SchemaName: ResolveSimilarUnresolvedEmailAddress, IntroducedVersion: 9.0.0.0.  Description: Apply same email address to all unresolved matches when you manually resolve it for one</summary>
	[JsonIgnore]
	public bool? ResolveSimilarUnresolvedEmailAddress
	{
		get
		{
			return TryGetValue("resolvesimilarunresolvedemailaddress", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("resolvesimilarunresolvedemailaddress") is false || Remove("resolvesimilarunresolvedemailaddress"))
			{
				Add("resolvesimilarunresolvedemailaddress", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Restrict guest users access to the organization, SchemaName: RestrictGuestUserAccess, IntroducedVersion: 1.0.0.1.  Description: Information that specifies whether guest user restriction is enabled</summary>
	[JsonIgnore]
	public string? RestrictGuestUserAccessFormattedValue
	{
		get
		{
			return TryGetValue("restrictGuestUserAccess@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Restrict guest users access to the organization, SchemaName: RestrictGuestUserAccess, IntroducedVersion: 1.0.0.1.  Description: Information that specifies whether guest user restriction is enabled</summary>
	[JsonIgnore]
	public bool? RestrictGuestUserAccess
	{
		get
		{
			return TryGetValue("restrictGuestUserAccess", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("restrictGuestUserAccess") is false || Remove("restrictGuestUserAccess"))
			{
				Add("restrictGuestUserAccess", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: restrictGuestUserAccess, SchemaName: restrictGuestUserAccessName, IntroducedVersion: 1.0.0.1. </summary>
	[JsonIgnore]
	public object? restrictGuestUserAccessName
	{
		get
		{
			return TryGetValue("restrictguestuseraccessname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Restrict Status Update, SchemaName: RestrictStatusUpdate, IntroducedVersion: 6.1.0.0.  Description: Flag to restrict Update on incident.</summary>
	[JsonIgnore]
	public string? RestrictStatusUpdateFormattedValue
	{
		get
		{
			return TryGetValue("restrictstatusupdate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Restrict Status Update, SchemaName: RestrictStatusUpdate, IntroducedVersion: 6.1.0.0.  Description: Flag to restrict Update on incident.</summary>
	[JsonIgnore]
	public bool? RestrictStatusUpdate
	{
		get
		{
			return TryGetValue("restrictstatusupdate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("restrictstatusupdate") is false || Remove("restrictstatusupdate"))
			{
				Add("restrictstatusupdate", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: List of reverse proxy IP addresses to be allowed., Format: Text, MaxLength: 4000, SchemaName: ReverseProxyIpAddresses, IntroducedVersion: 1.0.0.12.  Description: Information that specifies Reverse Proxy IP addresses from which requests have to be allowed.</summary>
	[JsonIgnore]
	public string? ReverseProxyIpAddresses
	{
		get
		{
			return TryGetValue("reverseproxyipaddresses", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("reverseproxyipaddresses") is false || Remove("reverseproxyipaddresses"))
			{
				Add("reverseproxyipaddresses", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Error status of Relationship Insights provisioning., Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: RiErrorStatus, IntroducedVersion: 8.2.0.0.  Description: Error status of Relationship Insights provisioning.</summary>
	[JsonIgnore]
	public int? RiErrorStatus
	{
		get
		{
			return TryGetValue("rierrorstatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("rierrorstatus") is false || Remove("rierrorstatus"))
			{
				Add("rierrorstatus", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Disable the option to quick create new records and activities in the Sales mobile application, SchemaName: SalesMobileQuickCreateDisabled, IntroducedVersion: 9.1.0.0.  Description: Disable the option to quick create new records and activities in the Sales mobile application</summary>
	[JsonIgnore]
	public string? SalesMobileQuickCreateDisabledFormattedValue
	{
		get
		{
			return TryGetValue("salesmobilequickcreatedisabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Disable the option to quick create new records and activities in the Sales mobile application, SchemaName: SalesMobileQuickCreateDisabled, IntroducedVersion: 9.1.0.0.  Description: Disable the option to quick create new records and activities in the Sales mobile application</summary>
	[JsonIgnore]
	public bool? SalesMobileQuickCreateDisabled
	{
		get
		{
			return TryGetValue("salesmobilequickcreatedisabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("salesmobilequickcreatedisabled") is false || Remove("salesmobilequickcreatedisabled"))
			{
				Add("salesmobilequickcreatedisabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: salesmobilequickcreatedisabled, SchemaName: salesmobilequickcreatedisabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? salesmobilequickcreatedisabledName
	{
		get
		{
			return TryGetValue("salesmobilequickcreatedisabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Sales Mobile should use UCI forms for create, SchemaName: SalesMobileUseUCIFormsForCreate, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Mobile should use UCI forms for create</summary>
	[JsonIgnore]
	public string? SalesMobileUseUCIFormsForCreateFormattedValue
	{
		get
		{
			return TryGetValue("salesmobileuseuciformsforcreate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Sales Mobile should use UCI forms for create, SchemaName: SalesMobileUseUCIFormsForCreate, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Mobile should use UCI forms for create</summary>
	[JsonIgnore]
	public bool? SalesMobileUseUCIFormsForCreate
	{
		get
		{
			return TryGetValue("salesmobileuseuciformsforcreate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("salesmobileuseuciformsforcreate") is false || Remove("salesmobileuseuciformsforcreate"))
			{
				Add("salesmobileuseuciformsforcreate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: salesmobileuseuciformsforcreate, SchemaName: salesmobileuseuciformsforcreateName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? salesmobileuseuciformsforcreateName
	{
		get
		{
			return TryGetValue("salesmobileuseuciformsforcreatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Sales Mobile should use UCI forms for view, SchemaName: SalesMobileUseUCIFormsForView, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Mobile should use UCI forms for view</summary>
	[JsonIgnore]
	public string? SalesMobileUseUCIFormsForViewFormattedValue
	{
		get
		{
			return TryGetValue("salesmobileuseuciformsforview@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Indicates whether Sales Mobile should use UCI forms for view, SchemaName: SalesMobileUseUCIFormsForView, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Sales Mobile should use UCI forms for view</summary>
	[JsonIgnore]
	public bool? SalesMobileUseUCIFormsForView
	{
		get
		{
			return TryGetValue("salesmobileuseuciformsforview", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("salesmobileuseuciformsforview") is false || Remove("salesmobileuseuciformsforview"))
			{
				Add("salesmobileuseuciformsforview", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: salesmobileuseuciformsforview, SchemaName: salesmobileuseuciformsforviewName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? salesmobileuseuciformsforviewName
	{
		get
		{
			return TryGetValue("salesmobileuseuciformsforviewname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Samesite mode for Session Cookie, SchemaName: SameSiteModeForSessionCookie, IntroducedVersion: 1.0.0.12.  Description: Samesite mode for Session Cookie 0 is Default, 1 is None, 2 is Lax , 3 is Strict</summary>
	[JsonIgnore]
	public string? SameSiteModeForSessionCookieFormattedValue
	{
		get
		{
			return TryGetValue("samesitemodeforsessioncookie@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Samesite mode for Session Cookie, SchemaName: SameSiteModeForSessionCookie, IntroducedVersion: 1.0.0.12.  Description: Samesite mode for Session Cookie 0 is Default, 1 is None, 2 is Lax , 3 is Strict</summary>
	[JsonIgnore]
	public int? SameSiteModeForSessionCookie
	{
		get
		{
			return TryGetValue("samesitemodeforsessioncookie", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("samesitemodeforsessioncookie") is false || Remove("samesitemodeforsessioncookie"))
			{
				Add("samesitemodeforsessioncookie", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: samesitemodeforsessioncookie, SchemaName: samesitemodeforsessioncookieName, IntroducedVersion: 1.0.0.12. </summary>
	[JsonIgnore]
	public object? samesitemodeforsessioncookieName
	{
		get
		{
			return TryGetValue("samesitemodeforsessioncookiename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Sample Data Import, SchemaName: SampleDataImportId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the sample data import job.</summary>
	[JsonIgnore]
	public Guid? SampleDataImportId
	{
		get
		{
			return TryGetValue("sampledataimportid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("sampledataimportid") is false || Remove("sampledataimportid"))
			{
				Add("sampledataimportid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Scheduling engine for Appointments and Service Activities, SchemaName: SchedulingEngine, IntroducedVersion: 9.0.2.0.  Description: Scheduling engine for Appointments and Service Activities</summary>
	[JsonIgnore]
	public string? SchedulingEngineFormattedValue
	{
		get
		{
			return TryGetValue("schedulingengine@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Scheduling engine for Appointments and Service Activities, SchemaName: SchedulingEngine, IntroducedVersion: 9.0.2.0.  Description: Scheduling engine for Appointments and Service Activities</summary>
	[JsonIgnore]
	public int? SchedulingEngine
	{
		get
		{
			return TryGetValue("schedulingengine", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("schedulingengine") is false || Remove("schedulingengine"))
			{
				Add("schedulingengine", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: schedulingengine, SchemaName: schedulingengineName, IntroducedVersion: 9.0.2.0. </summary>
	[JsonIgnore]
	public object? schedulingengineName
	{
		get
		{
			return TryGetValue("schedulingenginename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Customization Name Prefix, Format: Text, MaxLength: 8, SchemaName: SchemaNamePrefix, IntroducedVersion: 5.0.0.0.  Description: Prefix used for custom entities and attributes.</summary>
	[JsonIgnore]
	public string? SchemaNamePrefix
	{
		get
		{
			return TryGetValue("schemanameprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("schemanameprefix") is false || Remove("schemanameprefix"))
			{
				Add("schemanameprefix", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Send Bulk Email in UCI, SchemaName: SendBulkEmailInUCI, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Send Bulk Email in UCI is enabled for the org.</summary>
	[JsonIgnore]
	public string? SendBulkEmailInUCIFormattedValue
	{
		get
		{
			return TryGetValue("sendbulkemailinuci@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Send Bulk Email in UCI, SchemaName: SendBulkEmailInUCI, IntroducedVersion: 9.1.0.0.  Description: Indicates whether Send Bulk Email in UCI is enabled for the org.</summary>
	[JsonIgnore]
	public bool? SendBulkEmailInUCI
	{
		get
		{
			return TryGetValue("sendbulkemailinuci", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("sendbulkemailinuci") is false || Remove("sendbulkemailinuci"))
			{
				Add("sendbulkemailinuci", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Serve Static Content From CDN, SchemaName: ServeStaticResourcesFromAzureCDN, IntroducedVersion: 8.2.0.0.  Description: Serve Static Content From CDN</summary>
	[JsonIgnore]
	public string? ServeStaticResourcesFromAzureCDNFormattedValue
	{
		get
		{
			return TryGetValue("servestaticresourcesfromazurecdn@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Serve Static Content From CDN, SchemaName: ServeStaticResourcesFromAzureCDN, IntroducedVersion: 8.2.0.0.  Description: Serve Static Content From CDN</summary>
	[JsonIgnore]
	public bool? ServeStaticResourcesFromAzureCDN
	{
		get
		{
			return TryGetValue("servestaticresourcesfromazurecdn", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("servestaticresourcesfromazurecdn") is false || Remove("servestaticresourcesfromazurecdn"))
			{
				Add("servestaticresourcesfromazurecdn", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the session recording feature, SchemaName: SessionRecordingEnabled, IntroducedVersion: 9.1.0.0.  Description: Enable the session recording feature to record user sessions in UCI</summary>
	[JsonIgnore]
	public string? SessionRecordingEnabledFormattedValue
	{
		get
		{
			return TryGetValue("sessionrecordingenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the session recording feature, SchemaName: SessionRecordingEnabled, IntroducedVersion: 9.1.0.0.  Description: Enable the session recording feature to record user sessions in UCI</summary>
	[JsonIgnore]
	public bool? SessionRecordingEnabled
	{
		get
		{
			return TryGetValue("sessionrecordingenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("sessionrecordingenabled") is false || Remove("sessionrecordingenabled"))
			{
				Add("sessionrecordingenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: sessionrecordingenabled, SchemaName: sessionrecordingenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? sessionrecordingenabledName
	{
		get
		{
			return TryGetValue("sessionrecordingenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Session timeout enabled, SchemaName: SessionTimeoutEnabled, IntroducedVersion: 8.2.0.0.  Description: Information that specifies whether session timeout is enabled</summary>
	[JsonIgnore]
	public string? SessionTimeoutEnabledFormattedValue
	{
		get
		{
			return TryGetValue("sessiontimeoutenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Session timeout enabled, SchemaName: SessionTimeoutEnabled, IntroducedVersion: 8.2.0.0.  Description: Information that specifies whether session timeout is enabled</summary>
	[JsonIgnore]
	public bool? SessionTimeoutEnabled
	{
		get
		{
			return TryGetValue("sessiontimeoutenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("sessiontimeoutenabled") is false || Remove("sessiontimeoutenabled"))
			{
				Add("sessiontimeoutenabled", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Session timeout in minutes, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: SessionTimeoutInMins, IntroducedVersion: 8.2.0.0.  Description: Session timeout in minutes</summary>
	[JsonIgnore]
	public int? SessionTimeoutInMins
	{
		get
		{
			return TryGetValue("sessiontimeoutinmins", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("sessiontimeoutinmins") is false || Remove("sessiontimeoutinmins"))
			{
				Add("sessiontimeoutinmins", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Session timeout reminder in minutes, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: SessionTimeoutReminderInMins, IntroducedVersion: 8.2.0.0.  Description: Session timeout reminder in minutes</summary>
	[JsonIgnore]
	public int? SessionTimeoutReminderInMins
	{
		get
		{
			return TryGetValue("sessiontimeoutreminderinmins", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("sessiontimeoutreminderinmins") is false || Remove("sessiontimeoutreminderinmins"))
			{
				Add("sessiontimeoutreminderinmins", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Choose SharePoint Deployment Type, SchemaName: SharePointDeploymentType, IntroducedVersion: 7.1.0.0.  Description: Indicates which SharePoint deployment type is configured for Server to Server. (Online or On-Premises)</summary>
	[JsonIgnore]
	public string? SharePointDeploymentTypeFormattedValue
	{
		get
		{
			return TryGetValue("sharepointdeploymenttype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Choose SharePoint Deployment Type, SchemaName: SharePointDeploymentType, IntroducedVersion: 7.1.0.0.  Description: Indicates which SharePoint deployment type is configured for Server to Server. (Online or On-Premises)</summary>
	[JsonIgnore]
	public int? SharePointDeploymentType
	{
		get
		{
			return TryGetValue("sharepointdeploymenttype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("sharepointdeploymenttype") is false || Remove("sharepointdeploymenttype"))
			{
				Add("sharepointdeploymenttype", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Share To Previous Owner On Assign, SchemaName: ShareToPreviousOwnerOnAssign, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether to share to previous owner on assign.</summary>
	[JsonIgnore]
	public string? ShareToPreviousOwnerOnAssignFormattedValue
	{
		get
		{
			return TryGetValue("sharetopreviousowneronassign@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Share To Previous Owner On Assign, SchemaName: ShareToPreviousOwnerOnAssign, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether to share to previous owner on assign.</summary>
	[JsonIgnore]
	public bool? ShareToPreviousOwnerOnAssign
	{
		get
		{
			return TryGetValue("sharetopreviousowneronassign", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("sharetopreviousowneronassign") is false || Remove("sharetopreviousowneronassign"))
			{
				Add("sharetopreviousowneronassign", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Show KBArticle deprecation message to user, SchemaName: ShowKBArticleDeprecationNotification, IntroducedVersion: 8.0.0.0.  Description: Select whether to display a KB article deprecation notification to the user.</summary>
	[JsonIgnore]
	public string? ShowKBArticleDeprecationNotificationFormattedValue
	{
		get
		{
			return TryGetValue("showkbarticledeprecationnotification@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Show KBArticle deprecation message to user, SchemaName: ShowKBArticleDeprecationNotification, IntroducedVersion: 8.0.0.0.  Description: Select whether to display a KB article deprecation notification to the user.</summary>
	[JsonIgnore]
	public bool? ShowKBArticleDeprecationNotification
	{
		get
		{
			return TryGetValue("showkbarticledeprecationnotification", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("showkbarticledeprecationnotification") is false || Remove("showkbarticledeprecationnotification"))
			{
				Add("showkbarticledeprecationnotification", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Show Week Number, SchemaName: ShowWeekNumber, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? ShowWeekNumberFormattedValue
	{
		get
		{
			return TryGetValue("showweeknumber@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Show Week Number, SchemaName: ShowWeekNumber, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public bool? ShowWeekNumber
	{
		get
		{
			return TryGetValue("showweeknumber", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("showweeknumber") is false || Remove("showweeknumber"))
			{
				Add("showweeknumber", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: showweeknumber, SchemaName: ShowWeekNumberName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ShowWeekNumberName
	{
		get
		{
			return TryGetValue("showweeknumbername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: CRMForOutlookDownloadURL, Format: Text, MaxLength: 200, SchemaName: SignupOutlookDownloadFWLink, IntroducedVersion: 6.0.0.0.  Description: CRM for Outlook Download URL</summary>
	[JsonIgnore]
	public string? SignupOutlookDownloadFWLink
	{
		get
		{
			return TryGetValue("signupoutlookdownloadfwlink", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("signupoutlookdownloadfwlink") is false || Remove("signupoutlookdownloadfwlink"))
			{
				Add("signupoutlookdownloadfwlink", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: SiteMap XML, Format: TextArea, MaxLength: 1073741823, SchemaName: SiteMapXml, IntroducedVersion: 5.0.0.0.  Description: XML string that defines the navigation structure for the application.</summary>
	[JsonIgnore]
	public string? SiteMapXml
	{
		get
		{
			return TryGetValue("sitemapxml", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("sitemapxml") is false || Remove("sitemapxml"))
			{
				Add("sitemapxml", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow select record dialog in Enhanced Email Template, SchemaName: SkipSelectRecordDialog, IntroducedVersion: 9.0.0.0.  Description: Indicates whether to Allow select record dialog in Enhanced Email Template.</summary>
	[JsonIgnore]
	public string? SkipSelectRecordDialogFormattedValue
	{
		get
		{
			return TryGetValue("skipselectrecorddialog@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow select record dialog in Enhanced Email Template, SchemaName: SkipSelectRecordDialog, IntroducedVersion: 9.0.0.0.  Description: Indicates whether to Allow select record dialog in Enhanced Email Template.</summary>
	[JsonIgnore]
	public bool? SkipSelectRecordDialog
	{
		get
		{
			return TryGetValue("skipselectrecorddialog", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("skipselectrecorddialog") is false || Remove("skipselectrecorddialog"))
			{
				Add("skipselectrecorddialog", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: skipselectrecorddialog, SchemaName: skipselectrecorddialogName, IntroducedVersion: 9.0.0.0. </summary>
	[JsonIgnore]
	public object? skipselectrecorddialogName
	{
		get
		{
			return TryGetValue("skipselectrecorddialogname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: SLA pause states, Format: Text, MaxLength: 1073741823, SchemaName: SlaPauseStates, IntroducedVersion: 7.0.0.0.  Description: Contains the on hold case status values.</summary>
	[JsonIgnore]
	public string? SlaPauseStates
	{
		get
		{
			return TryGetValue("slapausestates", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("slapausestates") is false || Remove("slapausestates"))
			{
				Add("slapausestates", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Social Insights Enabled, SchemaName: SocialInsightsEnabled, IntroducedVersion: 7.0.0.0.  Description: Flag for whether the organization is using Social Insights.</summary>
	[JsonIgnore]
	public string? SocialInsightsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("socialinsightsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Social Insights Enabled, SchemaName: SocialInsightsEnabled, IntroducedVersion: 7.0.0.0.  Description: Flag for whether the organization is using Social Insights.</summary>
	[JsonIgnore]
	public bool? SocialInsightsEnabled
	{
		get
		{
			return TryGetValue("socialinsightsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("socialinsightsenabled") is false || Remove("socialinsightsenabled"))
			{
				Add("socialinsightsenabled", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Social Insights instance identifier, Format: Text, MaxLength: 2048, SchemaName: SocialInsightsInstance, IntroducedVersion: 6.1.0.0.  Description: Identifier for the Social Insights instance for the organization.</summary>
	[JsonIgnore]
	public string? SocialInsightsInstance
	{
		get
		{
			return TryGetValue("socialinsightsinstance", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("socialinsightsinstance") is false || Remove("socialinsightsinstance"))
			{
				Add("socialinsightsinstance", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Social Insights Terms of Use, SchemaName: SocialInsightsTermsAccepted, IntroducedVersion: 6.1.0.0.  Description: Flag for whether the organization has accepted the Social Insights terms of use.</summary>
	[JsonIgnore]
	public string? SocialInsightsTermsAcceptedFormattedValue
	{
		get
		{
			return TryGetValue("socialinsightstermsaccepted@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Social Insights Terms of Use, SchemaName: SocialInsightsTermsAccepted, IntroducedVersion: 6.1.0.0.  Description: Flag for whether the organization has accepted the Social Insights terms of use.</summary>
	[JsonIgnore]
	public bool? SocialInsightsTermsAccepted
	{
		get
		{
			return TryGetValue("socialinsightstermsaccepted", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("socialinsightstermsaccepted") is false || Remove("socialinsightstermsaccepted"))
			{
				Add("socialinsightstermsaccepted", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Sort, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: SortId, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public int? SortId
	{
		get
		{
			return TryGetValue("sortid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("sortid") is false || Remove("sortid"))
			{
				Add("sortid", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: SQL Access Group, SchemaName: SqlAccessGroupId, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? SqlAccessGroupId
	{
		get
		{
			return TryGetValue("sqlaccessgroupid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("sqlaccessgroupid") is false || Remove("sqlaccessgroupid"))
			{
				Add("sqlaccessgroupid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: SQL Access Group Name, Format: Text, MaxLength: 256, SchemaName: SqlAccessGroupName, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? SqlAccessGroupName
	{
		get
		{
			return TryGetValue("sqlaccessgroupname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("sqlaccessgroupname") is false || Remove("sqlaccessgroupname"))
			{
				Add("sqlaccessgroupname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is SQM Enabled, SchemaName: SQMEnabled, IntroducedVersion: 5.0.0.0.  Description: Setting for SQM data collection, 0 no, 1 yes enabled</summary>
	[JsonIgnore]
	public string? SQMEnabledFormattedValue
	{
		get
		{
			return TryGetValue("sqmenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is SQM Enabled, SchemaName: SQMEnabled, IntroducedVersion: 5.0.0.0.  Description: Setting for SQM data collection, 0 no, 1 yes enabled</summary>
	[JsonIgnore]
	public bool? SQMEnabled
	{
		get
		{
			return TryGetValue("sqmenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("sqmenabled") is false || Remove("sqmenabled"))
			{
				Add("sqmenabled", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Support User, SchemaName: SupportUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the support user for the organization.</summary>
	[JsonIgnore]
	public Guid? SupportUserId
	{
		get
		{
			return TryGetValue("supportuserid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("supportuserid") is false || Remove("supportuserid"))
			{
				Add("supportuserid", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is SLA suppressed, SchemaName: SuppressSLA, IntroducedVersion: 6.1.0.0.  Description: Indicates whether SLA is suppressed.</summary>
	[JsonIgnore]
	public string? SuppressSLAFormattedValue
	{
		get
		{
			return TryGetValue("suppresssla@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is SLA suppressed, SchemaName: SuppressSLA, IntroducedVersion: 6.1.0.0.  Description: Indicates whether SLA is suppressed.</summary>
	[JsonIgnore]
	public bool? SuppressSLA
	{
		get
		{
			return TryGetValue("suppresssla", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("suppresssla") is false || Remove("suppresssla"))
			{
				Add("suppresssla", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Whether Admin emails are sent when Solution Checker validation fails, SchemaName: SuppressValidationEmails, IntroducedVersion: 9.1.0.0.  Description: Leave empty to use default setting. Set to on/off to enable/disable Admin emails when Solution Checker validation fails.</summary>
	[JsonIgnore]
	public string? SuppressValidationEmailsFormattedValue
	{
		get
		{
			return TryGetValue("suppressvalidationemails@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Whether Admin emails are sent when Solution Checker validation fails, SchemaName: SuppressValidationEmails, IntroducedVersion: 9.1.0.0.  Description: Leave empty to use default setting. Set to on/off to enable/disable Admin emails when Solution Checker validation fails.</summary>
	[JsonIgnore]
	public bool? SuppressValidationEmails
	{
		get
		{
			return TryGetValue("suppressvalidationemails", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("suppressvalidationemails") is false || Remove("suppressvalidationemails"))
			{
				Add("suppressvalidationemails", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: suppressvalidationemails, SchemaName: suppressvalidationemailsName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? suppressvalidationemailsName
	{
		get
		{
			return TryGetValue("suppressvalidationemailsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Number of records to update per operation in Sync Bulk Pause/Resume/Cancel, Format: None, MinValue: 1, MaxValue: 1000, SchemaName: SyncBulkOperationBatchSize, IntroducedVersion: 9.1.0.0.  Description: Number of records to update per operation in Sync Bulk Pause/Resume/Cancel</summary>
	[JsonIgnore]
	public int? SyncBulkOperationBatchSize
	{
		get
		{
			return TryGetValue("syncbulkoperationbatchsize", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("syncbulkoperationbatchsize") is false || Remove("syncbulkoperationbatchsize"))
			{
				Add("syncbulkoperationbatchsize", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Max total number of records to update in database for Sync Bulk Pause/Resume/Cancel, Format: None, MinValue: 1, MaxValue: 500000, SchemaName: SyncBulkOperationMaxLimit, IntroducedVersion: 9.1.0.0.  Description: Max total number of records to update in database for Sync Bulk Pause/Resume/Cancel</summary>
	[JsonIgnore]
	public int? SyncBulkOperationMaxLimit
	{
		get
		{
			return TryGetValue("syncbulkoperationmaxlimit", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("syncbulkoperationmaxlimit") is false || Remove("syncbulkoperationmaxlimit"))
			{
				Add("syncbulkoperationmaxlimit", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable dynamics 365 azure sync framework for this organization., SchemaName: SyncOptInSelection, IntroducedVersion: 8.2.0.0.  Description: Indicates the selection to use the dynamics 365 azure sync framework or server side sync.</summary>
	[JsonIgnore]
	public string? SyncOptInSelectionFormattedValue
	{
		get
		{
			return TryGetValue("syncoptinselection@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable dynamics 365 azure sync framework for this organization., SchemaName: SyncOptInSelection, IntroducedVersion: 8.2.0.0.  Description: Indicates the selection to use the dynamics 365 azure sync framework or server side sync.</summary>
	[JsonIgnore]
	public bool? SyncOptInSelection
	{
		get
		{
			return TryGetValue("syncoptinselection", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("syncoptinselection") is false || Remove("syncoptinselection"))
			{
				Add("syncoptinselection", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Status of opt-in or opt-out operation for dynamics 365 azure sync., SchemaName: SyncOptInSelectionStatus, IntroducedVersion: 8.2.0.0.  Description: Indicates the status of the opt-in or opt-out operation for dynamics 365 azure sync.</summary>
	[JsonIgnore]
	public string? SyncOptInSelectionStatusFormattedValue
	{
		get
		{
			return TryGetValue("syncoptinselectionstatus@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Status of opt-in or opt-out operation for dynamics 365 azure sync., SchemaName: SyncOptInSelectionStatus, IntroducedVersion: 8.2.0.0.  Description: Indicates the status of the opt-in or opt-out operation for dynamics 365 azure sync.</summary>
	[JsonIgnore]
	public int? SyncOptInSelectionStatus
	{
		get
		{
			return TryGetValue("syncoptinselectionstatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("syncoptinselectionstatus") is false || Remove("syncoptinselectionstatus"))
			{
				Add("syncoptinselectionstatus", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: System User, SchemaName: SystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the system user for the organization.</summary>
	[JsonIgnore]
	public Guid? SystemUserId
	{
		get
		{
			return TryGetValue("systemuserid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("systemuserid") is false || Remove("systemuserid"))
			{
				Add("systemuserid", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Table Scoped Dataverse Search In Apps, SchemaName: TableScopedDVSearchInApps, IntroducedVersion: 9.1.0.0.  Description: Controls the appearance of option to search over a single DV search indexed table in model-driven apps’ global search in the header.</summary>
	[JsonIgnore]
	public string? TableScopedDVSearchInAppsFormattedValue
	{
		get
		{
			return TryGetValue("tablescopeddvsearchinapps@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Table Scoped Dataverse Search In Apps, SchemaName: TableScopedDVSearchInApps, IntroducedVersion: 9.1.0.0.  Description: Controls the appearance of option to search over a single DV search indexed table in model-driven apps’ global search in the header.</summary>
	[JsonIgnore]
	public bool? TableScopedDVSearchInApps
	{
		get
		{
			return TryGetValue("tablescopeddvsearchinapps", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("tablescopeddvsearchinapps") is false || Remove("tablescopeddvsearchinapps"))
			{
				Add("tablescopeddvsearchinapps", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: tablescopeddvsearchinapps, SchemaName: tablescopeddvsearchinappsName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? tablescopeddvsearchinappsName
	{
		get
		{
			return TryGetValue("tablescopeddvsearchinappsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Auto-Tag Max Cycles, Format: None, SchemaName: TagMaxAggressiveCycles, IntroducedVersion: 5.0.0.0.  Description: Maximum number of aggressive polling cycles executed for email auto-tagging when a new email is received.</summary>
	[JsonIgnore]
	public int? TagMaxAggressiveCycles
	{
		get
		{
			return TryGetValue("tagmaxaggressivecycles", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("tagmaxaggressivecycles") is false || Remove("tagmaxaggressivecycles"))
			{
				Add("tagmaxaggressivecycles", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Auto-Tag Interval, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: TagPollingPeriod, IntroducedVersion: 5.0.0.0.  Description: Normal polling frequency used for email receive auto-tagging in outlook.</summary>
	[JsonIgnore]
	public int? TagPollingPeriod
	{
		get
		{
			return TryGetValue("tagpollingperiod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("tagpollingperiod") is false || Remove("tagpollingperiod"))
			{
				Add("tagpollingperiod", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Task Flow processes for this Organization, SchemaName: TaskBasedFlowEnabled, IntroducedVersion: 8.0.0.0.  Description: Select whether to turn on task flows for the organization.</summary>
	[JsonIgnore]
	public string? TaskBasedFlowEnabledFormattedValue
	{
		get
		{
			return TryGetValue("taskbasedflowenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Task Flow processes for this Organization, SchemaName: TaskBasedFlowEnabled, IntroducedVersion: 8.0.0.0.  Description: Select whether to turn on task flows for the organization.</summary>
	[JsonIgnore]
	public bool? TaskBasedFlowEnabled
	{
		get
		{
			return TryGetValue("taskbasedflowenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("taskbasedflowenabled") is false || Remove("taskbasedflowenabled"))
			{
				Add("taskbasedflowenabled", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Teams Chat Data Sync., SchemaName: TeamsChatDataSync, IntroducedVersion: 9.2.0.0.  Description: Information on whether Teams Chat Data Sync is enabled.</summary>
	[JsonIgnore]
	public string? TeamsChatDataSyncFormattedValue
	{
		get
		{
			return TryGetValue("teamschatdatasync@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Teams Chat Data Sync., SchemaName: TeamsChatDataSync, IntroducedVersion: 9.2.0.0.  Description: Information on whether Teams Chat Data Sync is enabled.</summary>
	[JsonIgnore]
	public bool? TeamsChatDataSync
	{
		get
		{
			return TryGetValue("teamschatdatasync", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("teamschatdatasync") is false || Remove("teamschatdatasync"))
			{
				Add("teamschatdatasync", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: teamschatdatasync, SchemaName: teamschatdatasyncName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? teamschatdatasyncName
	{
		get
		{
			return TryGetValue("teamschatdatasyncname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Telemetry Instrumentation Key, Format: Text, MaxLength: 100, SchemaName: TelemetryInstrumentationKey, IntroducedVersion: 9.1.0.0.  Description: Instrumentation key for Application Insights used to log plugins telemetry.</summary>
	[JsonIgnore]
	public string? TelemetryInstrumentationKey
	{
		get
		{
			return TryGetValue("telemetryinstrumentationkey", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("telemetryinstrumentationkey") is false || Remove("telemetryinstrumentationkey"))
			{
				Add("telemetryinstrumentationkey", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Text Analytics for this Organization, SchemaName: TextAnalyticsEnabled, IntroducedVersion: 8.1.0.0.  Description: Select whether to turn on text analytics for the organization.</summary>
	[JsonIgnore]
	public string? TextAnalyticsEnabledFormattedValue
	{
		get
		{
			return TryGetValue("textanalyticsenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable Text Analytics for this Organization, SchemaName: TextAnalyticsEnabled, IntroducedVersion: 8.1.0.0.  Description: Select whether to turn on text analytics for the organization.</summary>
	[JsonIgnore]
	public bool? TextAnalyticsEnabled
	{
		get
		{
			return TryGetValue("textanalyticsenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("textanalyticsenabled") is false || Remove("textanalyticsenabled"))
			{
				Add("textanalyticsenabled", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Time Format Code, SchemaName: TimeFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how the time is displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public string? TimeFormatCodeFormattedValue
	{
		get
		{
			return TryGetValue("timeformatcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Time Format Code, SchemaName: TimeFormatCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how the time is displayed throughout Microsoft CRM.</summary>
	[JsonIgnore]
	public int? TimeFormatCode
	{
		get
		{
			return TryGetValue("timeformatcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("timeformatcode") is false || Remove("timeformatcode"))
			{
				Add("timeformatcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: timeformatcode, SchemaName: TimeFormatCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? TimeFormatCodeName
	{
		get
		{
			return TryGetValue("timeformatcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Time Format String, Format: Text, MaxLength: 255, SchemaName: TimeFormatString, IntroducedVersion: 5.0.0.0.  Description: Text for how time is displayed in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? TimeFormatString
	{
		get
		{
			return TryGetValue("timeformatstring", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("timeformatstring") is false || Remove("timeformatstring"))
			{
				Add("timeformatstring", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Time Separator, Format: Text, MaxLength: 5, SchemaName: TimeSeparator, IntroducedVersion: 5.0.0.0.  Description: Text for how the time separator is displayed throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? TimeSeparator
	{
		get
		{
			return TryGetValue("timeseparator", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("timeseparator") is false || Remove("timeseparator"))
			{
				Add("timeseparator", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public int? TimeZoneRuleVersionNumber
	{
		get
		{
			return TryGetValue("timezoneruleversionnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("timezoneruleversionnumber") is false || Remove("timezoneruleversionnumber"))
			{
				Add("timezoneruleversionnumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Token Expiration Duration, Format: None, SchemaName: TokenExpiry, IntroducedVersion: 5.0.0.0.  Description: Duration used for token expiration.</summary>
	[JsonIgnore]
	public int? TokenExpiry
	{
		get
		{
			return TryGetValue("tokenexpiry", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("tokenexpiry") is false || Remove("tokenexpiry"))
			{
				Add("tokenexpiry", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Token Key, Format: Text, MaxLength: 90, SchemaName: TokenKey, IntroducedVersion: 5.0.0.0.  Description: Token key.</summary>
	[JsonIgnore]
	public string? TokenKey
	{
		get
		{
			return TryGetValue("tokenkey", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("tokenkey") is false || Remove("tokenkey"))
			{
				Add("tokenkey", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Tracelog record maximum age in days, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: TraceLogMaximumAgeInDays, IntroducedVersion: 9.1.0.0.  Description: Tracelog record maximum age in days</summary>
	[JsonIgnore]
	public int? TraceLogMaximumAgeInDays
	{
		get
		{
			return TryGetValue("tracelogmaximumageindays", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("tracelogmaximumageindays") is false || Remove("tracelogmaximumageindays"))
			{
				Add("tracelogmaximumageindays", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Tracking Prefix, Format: Text, MaxLength: 256, SchemaName: TrackingPrefix, IntroducedVersion: 5.0.0.0.  Description: History list of tracking token prefixes.</summary>
	[JsonIgnore]
	public string? TrackingPrefix
	{
		get
		{
			return TryGetValue("trackingprefix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("trackingprefix") is false || Remove("trackingprefix"))
			{
				Add("trackingprefix", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Tracking Token Base, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: TrackingTokenIdBase, IntroducedVersion: 5.0.0.0.  Description: Base number used to provide separate tracking token identifiers to users belonging to different deployments.</summary>
	[JsonIgnore]
	public int? TrackingTokenIdBase
	{
		get
		{
			return TryGetValue("trackingtokenidbase", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("trackingtokenidbase") is false || Remove("trackingtokenidbase"))
			{
				Add("trackingtokenidbase", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Tracking Token Digits, Format: None, SchemaName: TrackingTokenIdDigits, IntroducedVersion: 5.0.0.0.  Description: Number of digits used to represent a tracking token identifier.</summary>
	[JsonIgnore]
	public int? TrackingTokenIdDigits
	{
		get
		{
			return TryGetValue("trackingtokeniddigits", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("trackingtokeniddigits") is false || Remove("trackingtokeniddigits"))
			{
				Add("trackingtokeniddigits", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Unique String Length, Format: None, MinValue: 4, MaxValue: 6, SchemaName: UniqueSpecifierLength, IntroducedVersion: 5.0.0.0.  Description: Number of characters appended to invoice, quote, and order numbers.</summary>
	[JsonIgnore]
	public int? UniqueSpecifierLength
	{
		get
		{
			return TryGetValue("uniquespecifierlength", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("uniquespecifierlength") is false || Remove("uniquespecifierlength"))
			{
				Add("uniquespecifierlength", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Set To,cc,bcc fields as unresolved if multiple matches are found, SchemaName: UnresolveEmailAddressIfMultipleMatch, IntroducedVersion: 8.2.0.0.  Description: Indicates whether email address should be unresolved if multiple matches are found</summary>
	[JsonIgnore]
	public string? UnresolveEmailAddressIfMultipleMatchFormattedValue
	{
		get
		{
			return TryGetValue("unresolveemailaddressifmultiplematch@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Set To,cc,bcc fields as unresolved if multiple matches are found, SchemaName: UnresolveEmailAddressIfMultipleMatch, IntroducedVersion: 8.2.0.0.  Description: Indicates whether email address should be unresolved if multiple matches are found</summary>
	[JsonIgnore]
	public bool? UnresolveEmailAddressIfMultipleMatch
	{
		get
		{
			return TryGetValue("unresolveemailaddressifmultiplematch", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("unresolveemailaddressifmultiplematch") is false || Remove("unresolveemailaddressifmultiplematch"))
			{
				Add("unresolveemailaddressifmultiplematch", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Use Inbuilt Rule For Default Pricelist Selection, SchemaName: UseInbuiltRuleForDefaultPricelistSelection, IntroducedVersion: 7.0.0.0.  Description: Flag indicates whether to Use Inbuilt Rule For DefaultPricelist.</summary>
	[JsonIgnore]
	public string? UseInbuiltRuleForDefaultPricelistSelectionFormattedValue
	{
		get
		{
			return TryGetValue("useinbuiltrulefordefaultpricelistselection@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Use Inbuilt Rule For Default Pricelist Selection, SchemaName: UseInbuiltRuleForDefaultPricelistSelection, IntroducedVersion: 7.0.0.0.  Description: Flag indicates whether to Use Inbuilt Rule For DefaultPricelist.</summary>
	[JsonIgnore]
	public bool? UseInbuiltRuleForDefaultPricelistSelection
	{
		get
		{
			return TryGetValue("useinbuiltrulefordefaultpricelistselection", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("useinbuiltrulefordefaultpricelistselection") is false || Remove("useinbuiltrulefordefaultpricelistselection"))
			{
				Add("useinbuiltrulefordefaultpricelistselection", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Legacy Form Rendering, SchemaName: UseLegacyRendering, IntroducedVersion: 7.1.0.0.  Description: Select whether to use legacy form rendering.</summary>
	[JsonIgnore]
	public string? UseLegacyRenderingFormattedValue
	{
		get
		{
			return TryGetValue("uselegacyrendering@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Legacy Form Rendering, SchemaName: UseLegacyRendering, IntroducedVersion: 7.1.0.0.  Description: Select whether to use legacy form rendering.</summary>
	[JsonIgnore]
	public bool? UseLegacyRendering
	{
		get
		{
			return TryGetValue("uselegacyrendering", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("uselegacyrendering") is false || Remove("uselegacyrendering"))
			{
				Add("uselegacyrendering", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use position hierarchy, SchemaName: UsePositionHierarchy, IntroducedVersion: 7.0.0.0.  Description: Use position hierarchy</summary>
	[JsonIgnore]
	public string? UsePositionHierarchyFormattedValue
	{
		get
		{
			return TryGetValue("usepositionhierarchy@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use position hierarchy, SchemaName: UsePositionHierarchy, IntroducedVersion: 7.0.0.0.  Description: Use position hierarchy</summary>
	[JsonIgnore]
	public bool? UsePositionHierarchy
	{
		get
		{
			return TryGetValue("usepositionhierarchy", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("usepositionhierarchy") is false || Remove("usepositionhierarchy"))
			{
				Add("usepositionhierarchy", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use Quick Find view when searching in grids, SchemaName: UseQuickFindViewForGridSearch, IntroducedVersion: 9.1.0.0.  Description: Indicates whether searching in a grid should use the Quick Find view for the entity.</summary>
	[JsonIgnore]
	public string? UseQuickFindViewForGridSearchFormattedValue
	{
		get
		{
			return TryGetValue("usequickfindviewforgridsearch@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use Quick Find view when searching in grids, SchemaName: UseQuickFindViewForGridSearch, IntroducedVersion: 9.1.0.0.  Description: Indicates whether searching in a grid should use the Quick Find view for the entity.</summary>
	[JsonIgnore]
	public bool? UseQuickFindViewForGridSearch
	{
		get
		{
			return TryGetValue("usequickfindviewforgridsearch", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("usequickfindviewforgridsearch") is false || Remove("usequickfindviewforgridsearch"))
			{
				Add("usequickfindviewforgridsearch", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: User Authentication Auditing Interval, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: UserAccessAuditingInterval, IntroducedVersion: 5.0.0.0.  Description: The interval at which user access is checked for auditing.</summary>
	[JsonIgnore]
	public int? UserAccessAuditingInterval
	{
		get
		{
			return TryGetValue("useraccessauditinginterval", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("useraccessauditinginterval") is false || Remove("useraccessauditinginterval"))
			{
				Add("useraccessauditinginterval", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use Read-Optimized Form, SchemaName: UseReadForm, IntroducedVersion: 5.0.0.0.  Description: Indicates whether the read-optimized form should be enabled for this organization.</summary>
	[JsonIgnore]
	public string? UseReadFormFormattedValue
	{
		get
		{
			return TryGetValue("usereadform@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Use Read-Optimized Form, SchemaName: UseReadForm, IntroducedVersion: 5.0.0.0.  Description: Indicates whether the read-optimized form should be enabled for this organization.</summary>
	[JsonIgnore]
	public bool? UseReadForm
	{
		get
		{
			return TryGetValue("usereadform", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("usereadform") is false || Remove("usereadform"))
			{
				Add("usereadform", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: User Group, SchemaName: UserGroupId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default group of users in the organization.</summary>
	[JsonIgnore]
	public Guid? UserGroupId
	{
		get
		{
			return TryGetValue("usergroupid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("usergroupid") is false || Remove("usergroupid"))
			{
				Add("usergroupid", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the user rating feature, SchemaName: UserRatingEnabled, IntroducedVersion: 9.1.0.0.  Description: Enable the user rating feature to show the NSAT score and comment to maker</summary>
	[JsonIgnore]
	public string? UserRatingEnabledFormattedValue
	{
		get
		{
			return TryGetValue("userratingenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Enable the user rating feature, SchemaName: UserRatingEnabled, IntroducedVersion: 9.1.0.0.  Description: Enable the user rating feature to show the NSAT score and comment to maker</summary>
	[JsonIgnore]
	public bool? UserRatingEnabled
	{
		get
		{
			return TryGetValue("userratingenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("userratingenabled") is false || Remove("userratingenabled"))
			{
				Add("userratingenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: userratingenabled, SchemaName: userratingenabledName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? userratingenabledName
	{
		get
		{
			return TryGetValue("userratingenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Skype Protocol, SchemaName: UseSkypeProtocol, IntroducedVersion: 5.0.0.0.  Description: Indicates default protocol selected for organization.</summary>
	[JsonIgnore]
	public string? UseSkypeProtocolFormattedValue
	{
		get
		{
			return TryGetValue("useskypeprotocol@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Skype Protocol, SchemaName: UseSkypeProtocol, IntroducedVersion: 5.0.0.0.  Description: Indicates default protocol selected for organization.</summary>
	[JsonIgnore]
	public bool? UseSkypeProtocol
	{
		get
		{
			return TryGetValue("useskypeprotocol", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("useskypeprotocol") is false || Remove("useskypeprotocol"))
			{
				Add("useskypeprotocol", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
	[JsonIgnore]
	public int? UTCConversionTimeZoneCode
	{
		get
		{
			return TryGetValue("utcconversiontimezonecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("utcconversiontimezonecode") is false || Remove("utcconversiontimezonecode"))
			{
				Add("utcconversiontimezonecode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: V3 Callout Hash, Format: Text, MaxLength: 256, SchemaName: V3CalloutConfigHash, IntroducedVersion: 5.0.0.0.  Description: Hash of the V3 callout configuration file.</summary>
	[JsonIgnore]
	public string? V3CalloutConfigHash
	{
		get
		{
			return TryGetValue("v3calloutconfighash", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("v3calloutconfighash") is false || Remove("v3calloutconfighash"))
			{
				Add("v3calloutconfighash", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Validation mode for apps in this environment, SchemaName: ValidationMode, IntroducedVersion: 9.1.0.0.  Description: Validation mode for apps in this environment</summary>
	[JsonIgnore]
	public string? ValidationModeFormattedValue
	{
		get
		{
			return TryGetValue("validationmode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Validation mode for apps in this environment, SchemaName: ValidationMode, IntroducedVersion: 9.1.0.0.  Description: Validation mode for apps in this environment</summary>
	[JsonIgnore]
	public int? ValidationMode
	{
		get
		{
			return TryGetValue("validationmode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("validationmode") is false || Remove("validationmode"))
			{
				Add("validationmode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: validationmode, SchemaName: validationmodeName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? validationmodeName
	{
		get
		{
			return TryGetValue("validationmodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the organization.</summary>
	[JsonIgnore]
	public long? VersionNumber
	{
		get
		{
			return TryGetValue("versionnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt64()
				: null : null;
		}
		set
		{
			if (ContainsKey("versionnumber") is false || Remove("versionnumber"))
			{
				Add("versionnumber", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Web resource hash, Format: Text, MaxLength: 100, SchemaName: WebResourceHash, IntroducedVersion: 7.1.0.0.  Description: Hash value of web resources.</summary>
	[JsonIgnore]
	public string? WebResourceHash
	{
		get
		{
			return TryGetValue("webresourcehash", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("webresourcehash") is false || Remove("webresourcehash"))
			{
				Add("webresourcehash", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Week Start Day Code, SchemaName: WeekStartDayCode, IntroducedVersion: 5.0.0.0.  Description: Designated first day of the week throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? WeekStartDayCodeFormattedValue
	{
		get
		{
			return TryGetValue("weekstartdaycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Week Start Day Code, SchemaName: WeekStartDayCode, IntroducedVersion: 5.0.0.0.  Description: Designated first day of the week throughout Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public int? WeekStartDayCode
	{
		get
		{
			return TryGetValue("weekstartdaycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("weekstartdaycode") is false || Remove("weekstartdaycode"))
			{
				Add("weekstartdaycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: weekstartdaycode, SchemaName: WeekStartDayCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? WeekStartDayCodeName
	{
		get
		{
			return TryGetValue("weekstartdaycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: For Internal use only., Format: Text, MaxLength: 100, SchemaName: WidgetProperties, IntroducedVersion: 8.2.0.0.  Description: For Internal use only.</summary>
	[JsonIgnore]
	public string? WidgetProperties
	{
		get
		{
			return TryGetValue("widgetproperties", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("widgetproperties") is false || Remove("widgetproperties"))
			{
				Add("widgetproperties", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Yammer Group Id, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: YammerGroupId, IntroducedVersion: 5.0.0.0.  Description: Denotes the Yammer group ID</summary>
	[JsonIgnore]
	public int? YammerGroupId
	{
		get
		{
			return TryGetValue("yammergroupid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("yammergroupid") is false || Remove("yammergroupid"))
			{
				Add("yammergroupid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yammer Network Permalink, Format: Text, MaxLength: 100, SchemaName: YammerNetworkPermalink, IntroducedVersion: 5.0.0.0.  Description: Denotes the Yammer network permalink</summary>
	[JsonIgnore]
	public string? YammerNetworkPermalink
	{
		get
		{
			return TryGetValue("yammernetworkpermalink", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yammernetworkpermalink") is false || Remove("yammernetworkpermalink"))
			{
				Add("yammernetworkpermalink", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Yammer OAuth Access Token Expired, SchemaName: YammerOAuthAccessTokenExpired, IntroducedVersion: 5.0.0.0.  Description: Denotes whether the OAuth access token for Yammer network has expired</summary>
	[JsonIgnore]
	public string? YammerOAuthAccessTokenExpiredFormattedValue
	{
		get
		{
			return TryGetValue("yammeroauthaccesstokenexpired@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Yammer OAuth Access Token Expired, SchemaName: YammerOAuthAccessTokenExpired, IntroducedVersion: 5.0.0.0.  Description: Denotes whether the OAuth access token for Yammer network has expired</summary>
	[JsonIgnore]
	public bool? YammerOAuthAccessTokenExpired
	{
		get
		{
			return TryGetValue("yammeroauthaccesstokenexpired", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("yammeroauthaccesstokenexpired") is false || Remove("yammeroauthaccesstokenexpired"))
			{
				Add("yammeroauthaccesstokenexpired", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Internal Use Only, SchemaName: YammerPostMethod, IntroducedVersion: 5.0.0.0.  Description: Internal Use Only</summary>
	[JsonIgnore]
	public string? YammerPostMethodFormattedValue
	{
		get
		{
			return TryGetValue("yammerpostmethod@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Internal Use Only, SchemaName: YammerPostMethod, IntroducedVersion: 5.0.0.0.  Description: Internal Use Only</summary>
	[JsonIgnore]
	public int? YammerPostMethod
	{
		get
		{
			return TryGetValue("yammerpostmethod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("yammerpostmethod") is false || Remove("yammerpostmethod"))
			{
				Add("yammerpostmethod", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Year Start Week Code, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: YearStartWeekCode, IntroducedVersion: 5.0.0.0.  Description: Information that specifies how the first week of the year is specified in Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public int? YearStartWeekCode
	{
		get
		{
			return TryGetValue("yearstartweekcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("yearstartweekcode") is false || Remove("yearstartweekcode"))
			{
				Add("yearstartweekcode", value);
			}
		}
	}

}

