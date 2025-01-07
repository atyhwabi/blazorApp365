namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Contains information about the tracked service-level KPIs for cases that belong to different customers.</summary>
public sealed partial class SLA : Dictionary<string, object>
{
	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Pause and Resume, SchemaName: AllowPauseResume, IntroducedVersion: 7.0.0.0.  Description: Select whether this SLA will allow pausing and resuming during the time calculation.</summary>
	[JsonIgnore]
	public string? AllowPauseResumeFormattedValue
	{
		get
		{
			return TryGetValue("allowpauseresume@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Allow Pause and Resume, SchemaName: AllowPauseResume, IntroducedVersion: 7.0.0.0.  Description: Select whether this SLA will allow pausing and resuming during the time calculation.</summary>
	[JsonIgnore]
	public bool? AllowPauseResume
	{
		get
		{
			return TryGetValue("allowpauseresume", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("allowpauseresume") is false || Remove("allowpauseresume"))
			{
				Add("allowpauseresume", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allowpauseresume, SchemaName: AllowPauseResumeName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? AllowPauseResumeName
	{
		get
		{
			return TryGetValue("allowpauseresumename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Applicable From, Format: Text, MaxLength: 100, SchemaName: ApplicableFrom, IntroducedVersion: 6.1.0.0.  Description: Select the field that specifies the date and time from which the SLA items will be calculated for the case record. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created. </summary>
	[JsonIgnore]
	public string? ApplicableFrom
	{
		get
		{
			return TryGetValue("applicablefrom", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("applicablefrom") is false || Remove("applicablefrom"))
			{
				Add("applicablefrom", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: applicablefrompicklist, SchemaName: ApplicableFromName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? ApplicableFromName
	{
		get
		{
			return TryGetValue("applicablefromname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Applicable From, SchemaName: ApplicableFromPickList, IntroducedVersion: 6.1.0.0.  Description: Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created.</summary>
	[JsonIgnore]
	public string? ApplicableFromPickListFormattedValue
	{
		get
		{
			return TryGetValue("applicablefrompicklist@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Applicable From, SchemaName: ApplicableFromPickList, IntroducedVersion: 6.1.0.0.  Description: Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created.</summary>
	[JsonIgnore]
	public int? ApplicableFromPickList
	{
		get
		{
			return TryGetValue("applicablefrompicklist", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("applicablefrompicklist") is false || Remove("applicablefrompicklist"))
			{
				Add("applicablefrompicklist", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Business Hours, Format: None, SchemaName: BusinessHoursId, IntroducedVersion: 6.1.0.0.  Description: Choose the business hours for calculating SLA item timelines.</summary>
	[JsonIgnore]
	public string? BusinessHoursIdFormattedValue
	{
		get
		{
			return TryGetValue("_businesshoursid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Business Hours, Format: None, SchemaName: BusinessHoursId, IntroducedVersion: 6.1.0.0.  Description: Choose the business hours for calculating SLA item timelines.</summary>
	[JsonIgnore]
	public Guid? BusinessHoursId
	{
		get
		{
			return TryGetValue("_businesshoursid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Business Hours, Format: None, SchemaName: BusinessHoursId, IntroducedVersion: 6.1.0.0.  Description: Choose the business hours for calculating SLA item timelines.</summary>
	[JsonIgnore]
	public Guid? BusinessHoursId_calendar
	{
		set
		{
			if (ContainsKey("businesshoursid_calendar@odata.bind") is false || Remove("businesshoursid_calendar@odata.bind"))
			{
				if (value is not null)
				{
					Add("businesshoursid_calendar@odata.bind", $"({value})");
				}
				else
				{
					Add("_businesshoursid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: businesshoursid, Format: Text, MaxLength: 100, SchemaName: BusinessHoursIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? BusinessHoursIdName
	{
		get
		{
			return TryGetValue("businesshoursidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("businesshoursidname") is false || Remove("businesshoursidname"))
			{
				Add("businesshoursidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ChangedAttributeList, Format: Text, MaxLength: 4000, SchemaName: ChangedAttributeList, IntroducedVersion: 6.1.0.0.  Description: Type additional information to describe the SLA</summary>
	[JsonIgnore]
	public string? ChangedAttributeList
	{
		get
		{
			return TryGetValue("changedattributelist", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("changedattributelist") is false || Remove("changedattributelist"))
			{
				Add("changedattributelist", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Component State, SchemaName: ComponentState, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? ComponentStateFormattedValue
	{
		get
		{
			return TryGetValue("componentstate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Component State, SchemaName: ComponentState, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public int? ComponentState
	{
		get
		{
			return TryGetValue("componentstate", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("componentstate") is false || Remove("componentstate"))
			{
				Add("componentstate", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 6.1.0.0.  Description: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 100, SchemaName: Description, IntroducedVersion: 6.1.0.0.  Description: Type additional information to describe the SLA</summary>
	[JsonIgnore]
	public string? Description
	{
		get
		{
			return TryGetValue("description", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("description") is false || Remove("description"))
			{
				Add("description", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 6.1.0.0.  Description: Exchange rate between the currency associated with the SLA record and the base currency.</summary>
	[JsonIgnore]
	public decimal? ExchangeRate
	{
		get
		{
			return TryGetValue("exchangerate", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("exchangerate") is false || Remove("exchangerate"))
			{
				Add("exchangerate", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Default, SchemaName: IsDefault, IntroducedVersion: 6.1.0.0.  Description: Tells whether this SLA is the default one.</summary>
	[JsonIgnore]
	public string? IsDefaultFormattedValue
	{
		get
		{
			return TryGetValue("isdefault@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Default, SchemaName: IsDefault, IntroducedVersion: 6.1.0.0.  Description: Tells whether this SLA is the default one.</summary>
	[JsonIgnore]
	public bool? IsDefault
	{
		get
		{
			return TryGetValue("isdefault", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdefault") is false || Remove("isdefault"))
			{
				Add("isdefault", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdefault, SchemaName: IsDefaultName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? IsDefaultName
	{
		get
		{
			return TryGetValue("isdefaultname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Managed, SchemaName: IsManaged, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? IsManagedFormattedValue
	{
		get
		{
			return TryGetValue("ismanaged@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Managed, SchemaName: IsManaged, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public bool? IsManaged
	{
		get
		{
			return TryGetValue("ismanaged", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismanaged") is false || Remove("ismanaged"))
			{
				Add("ismanaged", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Shows who last updated the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Shows who last updated the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Shows who last updated the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 6.1.0.0.  Description: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Name, Format: Text, MaxLength: 100, SchemaName: Name, IntroducedVersion: 6.1.0.0.  Description: Type a descriptive name of the service level agreement (SLA).</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Object Type Code, SchemaName: ObjectTypeCode, IntroducedVersion: 6.1.0.0.  Description: Choose the entity type that the SLA is defined.</summary>
	[JsonIgnore]
	public string? ObjectTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("objecttypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Object Type Code, SchemaName: ObjectTypeCode, IntroducedVersion: 6.1.0.0.  Description: Choose the entity type that the SLA is defined.</summary>
	[JsonIgnore]
	public int? ObjectTypeCode
	{
		get
		{
			return TryGetValue("objecttypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("objecttypecode") is false || Remove("objecttypecode"))
			{
				Add("objecttypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: objecttypecode, SchemaName: ObjectTypeCodeName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? ObjectTypeCodeName
	{
		get
		{
			return TryGetValue("objecttypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: SystemRequired, DisplayName: Record Overwrite Time, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverwriteTime, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public DateTime? OverwriteTime
	{
		get
		{
			return TryGetValue("overwritetime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("overwritetime") is false || Remove("overwritetime"))
			{
				Add("overwritetime", value);
			}
		}
	}

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 6.1.0.0.  Description: Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.</summary>
	[JsonIgnore]
	public string? OwnerIdFormattedValue
	{
		get
		{
			return TryGetValue("_ownerid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 6.1.0.0.  Description: Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.</summary>
	[JsonIgnore]
	public Guid? OwnerId
	{
		get
		{
			return TryGetValue("_ownerid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? OwnerIdName
	{
		get
		{
			return TryGetValue("owneridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("owneridname") is false || Remove("owneridname"))
			{
				Add("owneridname", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? OwnerIdType
	{
		get
		{
			return TryGetValue("owneridtype", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("owneridtype") is false || Remove("owneridtype"))
			{
				Add("owneridtype", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? OwnerIdYomiName
	{
		get
		{
			return TryGetValue("owneridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("owneridyominame") is false || Remove("owneridyominame"))
			{
				Add("owneridyominame", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	[JsonIgnore]
	public string? OwningBusinessUnitFormattedValue
	{
		get
		{
			return TryGetValue("_owningbusinessunit_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	[JsonIgnore]
	public Guid? OwningBusinessUnit
	{
		get
		{
			return TryGetValue("_owningbusinessunit_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
	[JsonIgnore]
	public Guid? OwningBusinessUnit_businessunit
	{
		set
		{
			if (ContainsKey("owningbusinessunit_businessunit@odata.bind") is false || Remove("owningbusinessunit_businessunit@odata.bind"))
			{
				if (value is not null)
				{
					Add("owningbusinessunit_businessunit@odata.bind", $"({value})");
				}
				else
				{
					Add("_owningbusinessunit_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? OwningBusinessUnitName
	{
		get
		{
			return TryGetValue("owningbusinessunitname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("owningbusinessunitname") is false || Remove("owningbusinessunitname"))
			{
				Add("owningbusinessunitname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	[JsonIgnore]
	public string? OwningTeamFormattedValue
	{
		get
		{
			return TryGetValue("_owningteam_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	[JsonIgnore]
	public Guid? OwningTeam
	{
		get
		{
			return TryGetValue("_owningteam_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
	[JsonIgnore]
	public Guid? OwningTeam_team
	{
		set
		{
			if (ContainsKey("owningteam_team@odata.bind") is false || Remove("owningteam_team@odata.bind"))
			{
				if (value is not null)
				{
					Add("owningteam_team@odata.bind", $"({value})");
				}
				else
				{
					Add("_owningteam_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	[JsonIgnore]
	public string? OwningUserFormattedValue
	{
		get
		{
			return TryGetValue("_owninguser_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	[JsonIgnore]
	public Guid? OwningUser
	{
		get
		{
			return TryGetValue("_owninguser_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
	[JsonIgnore]
	public Guid? OwningUser_systemuser
	{
		set
		{
			if (ContainsKey("owninguser_systemuser@odata.bind") is false || Remove("owninguser_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("owninguser_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_owninguser_value", null);
				}
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Primary Entity, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: PrimaryEntityOTC, IntroducedVersion: 8.1.0.0.  Description: Shows the primary entity that the SLA has been created for.</summary>
	[JsonIgnore]
	public int? PrimaryEntityOTC
	{
		get
		{
			return TryGetValue("primaryentityotc", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("primaryentityotc") is false || Remove("primaryentityotc"))
			{
				Add("primaryentityotc", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: SLA, SchemaName: SLAId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the SLA.</summary>
	[JsonIgnore]
	public Guid? SLAId
	{
		get
		{
			return TryGetValue("slaid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("slaid") is false || Remove("slaid"))
			{
				Add("slaid", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Unique Id, SchemaName: SLAIdUnique, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? SLAIdUnique
	{
		get
		{
			return TryGetValue("slaidunique", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("slaidunique") is false || Remove("slaidunique"))
			{
				Add("slaidunique", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: SLA Type, SchemaName: SLAType, IntroducedVersion: 7.0.0.0.  Description: Select the type of service level agreement (SLA).</summary>
	[JsonIgnore]
	public string? SLATypeFormattedValue
	{
		get
		{
			return TryGetValue("slatype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: SLA Type, SchemaName: SLAType, IntroducedVersion: 7.0.0.0.  Description: Select the type of service level agreement (SLA).</summary>
	[JsonIgnore]
	public int? SLAType
	{
		get
		{
			return TryGetValue("slatype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("slatype") is false || Remove("slatype"))
			{
				Add("slatype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: slatype, SchemaName: SLATypeName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? SLATypeName
	{
		get
		{
			return TryGetValue("slatypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Record version, SchemaName: slaversion, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? slaversionFormattedValue
	{
		get
		{
			return TryGetValue("slaversion@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Record version, SchemaName: slaversion, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? slaversion
	{
		get
		{
			return TryGetValue("slaversion", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("slaversion") is false || Remove("slaversion"))
			{
				Add("slaversion", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: slaversion, SchemaName: slaversionName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? slaversionName
	{
		get
		{
			return TryGetValue("slaversionname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Solution, SchemaName: SolutionId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the associated solution.</summary>
	[JsonIgnore]
	public Guid? SolutionId
	{
		get
		{
			return TryGetValue("solutionid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("solutionid") is false || Remove("solutionid"))
			{
				Add("solutionid", value);
			}
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 6.1.0.0.  Description: Shows whether the Service Level Agreement (SLA) is active or inactive.</summary>
	[JsonIgnore]
	public string? StateCodeFormattedValue
	{
		get
		{
			return TryGetValue("statecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 6.1.0.0.  Description: Shows whether the Service Level Agreement (SLA) is active or inactive.</summary>
	[JsonIgnore]
	public int? StateCode
	{
		get
		{
			return TryGetValue("statecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("statecode") is false || Remove("statecode"))
			{
				Add("statecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? StateCodeName
	{
		get
		{
			return TryGetValue("statecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 6.1.0.0.  Description: Select the status of the service level agreement (SLA).</summary>
	[JsonIgnore]
	public string? StatusCodeFormattedValue
	{
		get
		{
			return TryGetValue("statuscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 6.1.0.0.  Description: Select the status of the service level agreement (SLA).</summary>
	[JsonIgnore]
	public int? StatusCode
	{
		get
		{
			return TryGetValue("statuscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("statuscode") is false || Remove("statuscode"))
			{
				Add("statuscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? StatusCodeName
	{
		get
		{
			return TryGetValue("statuscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Solution, SchemaName: SupportingSolutionId, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? SupportingSolutionId
	{
		get
		{
			return TryGetValue("supportingsolutionid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("supportingsolutionid") is false || Remove("supportingsolutionid"))
			{
				Add("supportingsolutionid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the currency associated with the SLA record.</summary>
	[JsonIgnore]
	public string? TransactionCurrencyIdFormattedValue
	{
		get
		{
			return TryGetValue("_transactioncurrencyid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the currency associated with the SLA record.</summary>
	[JsonIgnore]
	public Guid? TransactionCurrencyId
	{
		get
		{
			return TryGetValue("_transactioncurrencyid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the currency associated with the SLA record.</summary>
	[JsonIgnore]
	public Guid? TransactionCurrencyId_transactioncurrency
	{
		set
		{
			if (ContainsKey("transactioncurrencyid_transactioncurrency@odata.bind") is false || Remove("transactioncurrencyid_transactioncurrency@odata.bind"))
			{
				if (value is not null)
				{
					Add("transactioncurrencyid_transactioncurrency@odata.bind", $"({value})");
				}
				else
				{
					Add("_transactioncurrencyid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? TransactionCurrencyIdName
	{
		get
		{
			return TryGetValue("transactioncurrencyidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("transactioncurrencyidname") is false || Remove("transactioncurrencyidname"))
			{
				Add("transactioncurrencyidname", value);
			}
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 6.1.0.0.  Description: Version number of the SLA.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Workflow ID, Format: None, SchemaName: WorkflowId, IntroducedVersion: 6.1.0.0.  Description: Workflow associated with the SLA.</summary>
	[JsonIgnore]
	public string? WorkflowIdFormattedValue
	{
		get
		{
			return TryGetValue("_workflowid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Workflow ID, Format: None, SchemaName: WorkflowId, IntroducedVersion: 6.1.0.0.  Description: Workflow associated with the SLA.</summary>
	[JsonIgnore]
	public Guid? WorkflowId
	{
		get
		{
			return TryGetValue("_workflowid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Workflow ID, Format: None, SchemaName: WorkflowId, IntroducedVersion: 6.1.0.0.  Description: Workflow associated with the SLA.</summary>
	[JsonIgnore]
	public Guid? WorkflowId_workflow
	{
		set
		{
			if (ContainsKey("workflowid_workflow@odata.bind") is false || Remove("workflowid_workflow@odata.bind"))
			{
				if (value is not null)
				{
					Add("workflowid_workflow@odata.bind", $"({value})");
				}
				else
				{
					Add("_workflowid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: workflowid, Format: Text, MaxLength: 100, SchemaName: WorkflowIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? WorkflowIdName
	{
		get
		{
			return TryGetValue("workflowidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("workflowidname") is false || Remove("workflowidname"))
			{
				Add("workflowidname", value);
			}
		}
	}

}

