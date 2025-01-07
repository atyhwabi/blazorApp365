namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case</summary>
public sealed partial class SLAKPIInstance : Dictionary<string, object>
{
	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Applicable From Value, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ApplicableFromValue, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public DateTime? ApplicableFromValue
	{
		get
		{
			return TryGetValue("applicablefromvalue", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("applicablefromvalue") is false || Remove("applicablefromvalue"))
			{
				Add("applicablefromvalue", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Computed Failure Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ComputedFailureTime, IntroducedVersion: 7.0.0.0.  Description: Computed Failure Date and time</summary>
	[JsonIgnore]
	public DateTime? ComputedFailureTime
	{
		get
		{
			return TryGetValue("computedfailuretime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("computedfailuretime") is false || Remove("computedfailuretime"))
			{
				Add("computedfailuretime", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Computed Warning Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ComputedWarningTime, IntroducedVersion: 7.0.0.0.  Description: Computed Warning Date and time</summary>
	[JsonIgnore]
	public DateTime? ComputedWarningTime
	{
		get
		{
			return TryGetValue("computedwarningtime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("computedwarningtime") is false || Remove("computedwarningtime"))
			{
				Add("computedwarningtime", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 100, SchemaName: Description, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Elapsed Time (min), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ElapsedTime, IntroducedVersion: 9.1.0.0.  Description: Paused duration of a KPI in business hours</summary>
	[JsonIgnore]
	public int? ElapsedTime
	{
		get
		{
			return TryGetValue("elapsedtime", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("elapsedtime") is false || Remove("elapsedtime"))
			{
				Add("elapsedtime", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Failure Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: FailureTime, IntroducedVersion: 7.0.0.0.  Description: Enter the date and time when the service level agreement (SLA) key performance indicator (KPI) will expire.</summary>
	[JsonIgnore]
	public DateTime? FailureTime
	{
		get
		{
			return TryGetValue("failuretime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("failuretime") is false || Remove("failuretime"))
			{
				Add("failuretime", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: warningtimereached, SchemaName: HasNearedViolationName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? HasNearedViolationName
	{
		get
		{
			return TryGetValue("hasnearedviolationname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Resume Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastResumeTime, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public DateTime? LastResumeTime
	{
		get
		{
			return TryGetValue("lastresumetime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("lastresumetime") is false || Remove("lastresumetime"))
			{
				Add("lastresumetime", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Action Execution Status, SchemaName: msdyn_ActionExecutionStatus, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_ActionExecutionStatusFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_actionexecutionstatus@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Action Execution Status, SchemaName: msdyn_ActionExecutionStatus, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? msdyn_ActionExecutionStatus
	{
		get
		{
			return TryGetValue("msdyn_actionexecutionstatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_actionexecutionstatus") is false || Remove("msdyn_actionexecutionstatus"))
			{
				Add("msdyn_actionexecutionstatus", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_actionexecutionstatus, SchemaName: msdyn_actionexecutionstatusName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_actionexecutionstatusName
	{
		get
		{
			return TryGetValue("msdyn_actionexecutionstatusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Active Duration (min), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: msdyn_activeduration, IntroducedVersion: 1.0.  Description: Time taken in business hours by a KPI instance to reach the Success or failed state</summary>
	[JsonIgnore]
	public int? msdyn_activeduration
	{
		get
		{
			return TryGetValue("msdyn_activeduration", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_activeduration") is false || Remove("msdyn_activeduration"))
			{
				Add("msdyn_activeduration", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Applicable Calendar, Format: Text, MaxLength: 100, SchemaName: msdyn_calendarid, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_calendarid
	{
		get
		{
			return TryGetValue("msdyn_calendarid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_calendarid") is false || Remove("msdyn_calendarid"))
			{
				Add("msdyn_calendarid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Previous SLAKPI Instance, Format: Text, MaxLength: 100, SchemaName: msdyn_prevslakpiinstanceid, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_prevslakpiinstanceid
	{
		get
		{
			return TryGetValue("msdyn_prevslakpiinstanceid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_prevslakpiinstanceid") is false || Remove("msdyn_prevslakpiinstanceid"))
			{
				Add("msdyn_prevslakpiinstanceid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLAItem, Format: None, SchemaName: msdyn_slaitemid, IntroducedVersion: 1.0.  Description: Unique identifier for SLA KPI Instance associated with SLA Item.</summary>
	[JsonIgnore]
	public string? msdyn_slaitemidFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_slaitemid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLAItem, Format: None, SchemaName: msdyn_slaitemid, IntroducedVersion: 1.0.  Description: Unique identifier for SLA KPI Instance associated with SLA Item.</summary>
	[JsonIgnore]
	public Guid? msdyn_slaitemid
	{
		get
		{
			return TryGetValue("_msdyn_slaitemid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLAItem, Format: None, SchemaName: msdyn_slaitemid, IntroducedVersion: 1.0.  Description: Unique identifier for SLA KPI Instance associated with SLA Item.</summary>
	[JsonIgnore]
	public Guid? msdyn_slaitemid_slaitem
	{
		set
		{
			if (ContainsKey("msdyn_slaitemid_slaitem@odata.bind") is false || Remove("msdyn_slaitemid_slaitem@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_slaitemid_slaitem@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_slaitemid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_slaitemid, Format: Text, MaxLength: 100, SchemaName: msdyn_slaitemidName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_slaitemidName
	{
		get
		{
			return TryGetValue("msdyn_slaitemidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_slaitemidname") is false || Remove("msdyn_slaitemidname"))
			{
				Add("msdyn_slaitemidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Name, Format: Text, MaxLength: 100, SchemaName: Name, IntroducedVersion: 7.0.0.0.  Description: Type a descriptive name for the service level agreement (SLA) key performance indicator (KPI) instance.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 7.0.0.0.  Description: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user or team.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 7.0.0.0.  Description: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user or team.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 7.0.0.0.  Description: Owning Business Unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 7.0.0.0.  Description: Owning Business Unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 7.0.0.0.  Description: Owning Business Unit.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Paused On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: PausedOn, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public DateTime? PausedOn
	{
		get
		{
			return TryGetValue("pausedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("pausedon") is false || Remove("pausedon"))
			{
				Add("pausedon", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: Regarding, IntroducedVersion: 7.0.0.0.  Description: Unique identifier of the record that this service level agreement (SLA) key performance indicator (KPI) instance is associated with.</summary>
	[JsonIgnore]
	public string? RegardingFormattedValue
	{
		get
		{
			return TryGetValue("_regarding_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: Regarding, IntroducedVersion: 7.0.0.0.  Description: Unique identifier of the record that this service level agreement (SLA) key performance indicator (KPI) instance is associated with.</summary>
	[JsonIgnore]
	public Guid? Regarding
	{
		get
		{
			return TryGetValue("_regarding_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: Regarding, IntroducedVersion: 7.0.0.0.  Description: Unique identifier of the record that this service level agreement (SLA) key performance indicator (KPI) instance is associated with.</summary>
	[JsonIgnore]
	public Guid? Regarding_incident
	{
		set
		{
			if (ContainsKey("regarding_incident@odata.bind") is false || Remove("regarding_incident@odata.bind"))
			{
				if (value is not null)
				{
					Add("regarding_incident@odata.bind", $"({value})");
				}
				else
				{
					Add("_regarding_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Regarding ID, Format: Text, MaxLength: 100, SchemaName: RegardingEntityID, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? RegardingEntityID
	{
		get
		{
			return TryGetValue("regardingentityid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingentityid") is false || Remove("regardingentityid"))
			{
				Add("regardingentityid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: RegardingName, AttributeOf: regarding, Format: Text, MaxLength: 800, SchemaName: RegardingIdName, IntroducedVersion: 8.1.0.0.  Description: RegardingName</summary>
	[JsonIgnore]
	public string? RegardingIdName
	{
		get
		{
			return TryGetValue("regardingidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingidname") is false || Remove("regardingidname"))
			{
				Add("regardingidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: regarding, Format: Text, MaxLength: 100, SchemaName: RegardingName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public string? RegardingName
	{
		get
		{
			return TryGetValue("regardingname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingname") is false || Remove("regardingname"))
			{
				Add("regardingname", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: None, DisplayName: RegardingObjectTypeCode, AttributeOf: regarding, SchemaName: RegardingObjectTypeCode, IntroducedVersion: 7.0.0.0.  Description: RegardingObjectTypeCode</summary>
	[JsonIgnore]
	public string? RegardingObjectTypeCode
	{
		get
		{
			return TryGetValue("regardingobjecttypecode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingobjecttypecode") is false || Remove("regardingobjecttypecode"))
			{
				Add("regardingobjecttypecode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: RegardingYomiName, AttributeOf: regarding, Format: Text, MaxLength: 800, SchemaName: RegardingYomiName, YomiOf: regardingidname, IntroducedVersion: 8.1.0.0.  Description: RegardingYomiName</summary>
	[JsonIgnore]
	public string? RegardingYomiName
	{
		get
		{
			return TryGetValue("regardingyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingyominame") is false || Remove("regardingyominame"))
			{
				Add("regardingyominame", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: SLA KPI InstanceId, SchemaName: SLAKPIInstanceId, IntroducedVersion: 7.0.0.0.  Description: Unique identifier of the SLA KPI Instance.</summary>
	[JsonIgnore]
	public Guid? SLAKPIInstanceId
	{
		get
		{
			return TryGetValue("slakpiinstanceid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("slakpiinstanceid") is false || Remove("slakpiinstanceid"))
			{
				Add("slakpiinstanceid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Status, SchemaName: Status, IntroducedVersion: 7.0.0.0.  Description: Reason for the status of the service level agreement (SLA) key performance indicator (KPI) instance. For example, the SLA KPI could be Noncompliant or Succeeded.</summary>
	[JsonIgnore]
	public string? StatusFormattedValue
	{
		get
		{
			return TryGetValue("status@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Status, SchemaName: Status, IntroducedVersion: 7.0.0.0.  Description: Reason for the status of the service level agreement (SLA) key performance indicator (KPI) instance. For example, the SLA KPI could be Noncompliant or Succeeded.</summary>
	[JsonIgnore]
	public int? Status
	{
		get
		{
			return TryGetValue("status", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("status") is false || Remove("status"))
			{
				Add("status", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: status, SchemaName: StatusName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? StatusName
	{
		get
		{
			return TryGetValue("statusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Succeeded On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: SucceededOn, IntroducedVersion: 7.0.0.0.  Description: Shows the date and time when the service level agreement (SLA) key performance indicator (KPI) success criteria was met.</summary>
	[JsonIgnore]
	public DateTime? SucceededOn
	{
		get
		{
			return TryGetValue("succeededon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("succeededon") is false || Remove("succeededon"))
			{
				Add("succeededon", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: SuccessCheckedAt, DateTimeBehavior: TimeZoneIndependent, Format: DateAndTime, SchemaName: SuccessCheckedAt, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public DateTime? SuccessCheckedAt
	{
		get
		{
			return TryGetValue("successcheckedat", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("successcheckedat") is false || Remove("successcheckedat"))
			{
				Add("successcheckedat", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Terminal State Reached, SchemaName: TerminalStateReached, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? TerminalStateReachedFormattedValue
	{
		get
		{
			return TryGetValue("terminalstatereached@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Terminal State Reached, SchemaName: TerminalStateReached, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public bool? TerminalStateReached
	{
		get
		{
			return TryGetValue("terminalstatereached", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("terminalstatereached") is false || Remove("terminalstatereached"))
			{
				Add("terminalstatereached", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: terminalstatereached, SchemaName: terminalstatereachedName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? terminalstatereachedName
	{
		get
		{
			return TryGetValue("terminalstatereachedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Terminal State Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: TerminalStateTime, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public DateTime? TerminalStateTime
	{
		get
		{
			return TryGetValue("terminalstatetime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("terminalstatetime") is false || Remove("terminalstatetime"))
			{
				Add("terminalstatetime", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 7.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 7.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 7.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 7.0.0.0. </summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Warning Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: WarningTime, IntroducedVersion: 7.0.0.0.  Description: Enter the date and time when the service level agreement (SLA) key performance indicator (KPI)will go to a warning state.</summary>
	[JsonIgnore]
	public DateTime? WarningTime
	{
		get
		{
			return TryGetValue("warningtime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("warningtime") is false || Remove("warningtime"))
			{
				Add("warningtime", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Warning Time Reached, SchemaName: WarningTimeReached, IntroducedVersion: 7.0.0.0.  Description: Shows information about whether the case has reached its warning time.</summary>
	[JsonIgnore]
	public string? WarningTimeReachedFormattedValue
	{
		get
		{
			return TryGetValue("warningtimereached@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Warning Time Reached, SchemaName: WarningTimeReached, IntroducedVersion: 7.0.0.0.  Description: Shows information about whether the case has reached its warning time.</summary>
	[JsonIgnore]
	public int? WarningTimeReached
	{
		get
		{
			return TryGetValue("warningtimereached", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("warningtimereached") is false || Remove("warningtimereached"))
			{
				Add("warningtimereached", value);
			}
		}
	}

}

