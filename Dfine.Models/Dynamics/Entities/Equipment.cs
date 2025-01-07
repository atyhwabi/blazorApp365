namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Resource that can be scheduled.</summary>
public sealed partial class Equipment : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Shows the business unit that the Equipment belongs to.</summary>
	[JsonIgnore]
	public string? BusinessUnitIdFormattedValue
	{
		get
		{
			return TryGetValue("_businessunitid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Shows the business unit that the Equipment belongs to.</summary>
	[JsonIgnore]
	public Guid? BusinessUnitId
	{
		get
		{
			return TryGetValue("_businessunitid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Shows the business unit that the Equipment belongs to.</summary>
	[JsonIgnore]
	public Guid? BusinessUnitId_businessunit
	{
		set
		{
			if (ContainsKey("businessunitid_businessunit@odata.bind") is false || Remove("businessunitid_businessunit@odata.bind"))
			{
				if (value is not null)
				{
					Add("businessunitid_businessunit@odata.bind", $"({value})");
				}
				else
				{
					Add("_businessunitid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: businessunitid, Format: Text, MaxLength: 100, SchemaName: BusinessUnitIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BusinessUnitIdName
	{
		get
		{
			return TryGetValue("businessunitidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("businessunitidname") is false || Remove("businessunitidname"))
			{
				Add("businessunitidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the facility/equipment.</summary>
	[JsonIgnore]
	public string? CalendarIdFormattedValue
	{
		get
		{
			return TryGetValue("_calendarid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the facility/equipment.</summary>
	[JsonIgnore]
	public Guid? CalendarId
	{
		get
		{
			return TryGetValue("_calendarid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the facility/equipment.</summary>
	[JsonIgnore]
	public Guid? CalendarId_calendar
	{
		set
		{
			if (ContainsKey("calendarid_calendar@odata.bind") is false || Remove("calendarid_calendar@odata.bind"))
			{
				if (value is not null)
				{
					Add("calendarid_calendar@odata.bind", $"({value})");
				}
				else
				{
					Add("_calendarid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the facility/equipment entry.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the facility/equipment entry.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the facility/equipment entry.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the record was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the equipment.</summary>
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

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: Text, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Description of the facility/equipment.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Display in Service Views, SchemaName: DisplayInServiceViews, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? DisplayInServiceViewsFormattedValue
	{
		get
		{
			return TryGetValue("displayinserviceviews@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Display in Service Views, SchemaName: DisplayInServiceViews, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public bool? DisplayInServiceViews
	{
		get
		{
			return TryGetValue("displayinserviceviews", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("displayinserviceviews") is false || Remove("displayinserviceviews"))
			{
				Add("displayinserviceviews", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: displayinserviceviews, SchemaName: DisplayInServiceViewsName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DisplayInServiceViewsName
	{
		get
		{
			return TryGetValue("displayinserviceviewsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Primary Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress, IntroducedVersion: 5.0.0.0.  Description: Email address of person to contact about the use of the facility/equipment.</summary>
	[JsonIgnore]
	public string? EMailAddress
	{
		get
		{
			return TryGetValue("emailaddress", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailaddress") is false || Remove("emailaddress"))
			{
				Add("emailaddress", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Facility/Equipment, SchemaName: EquipmentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the facility/equipment.</summary>
	[JsonIgnore]
	public Guid? EquipmentId
	{
		get
		{
			return TryGetValue("equipmentid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("equipmentid") is false || Remove("equipmentid"))
			{
				Add("equipmentid", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 10, MinValue: 1E-10, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the equipment with respect to the base currency.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Sequence number of the import that created this record.</summary>
	[JsonIgnore]
	public int? ImportSequenceNumber
	{
		get
		{
			return TryGetValue("importsequencenumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("importsequencenumber") is false || Remove("importsequencenumber"))
			{
				Add("importsequencenumber", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Disabled, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Whether the facility/equipment is disabled or operational.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Disabled, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Whether the facility/equipment is disabled or operational.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the facility/equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the facility/equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the facility/equipment.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the record was modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organizational Unit, Format: None, SchemaName: msdyn_OrganizationalUnitId, IntroducedVersion: 9.0.0.0.  Description: Unique identifier for OrganizationalUnit associated with Equipment</summary>
	[JsonIgnore]
	public string? msdyn_OrganizationalUnitIdFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_organizationalunitid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organizational Unit, Format: None, SchemaName: msdyn_OrganizationalUnitId, IntroducedVersion: 9.0.0.0.  Description: Unique identifier for OrganizationalUnit associated with Equipment</summary>
	[JsonIgnore]
	public Guid? msdyn_OrganizationalUnitId
	{
		get
		{
			return TryGetValue("_msdyn_organizationalunitid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organizational Unit, Format: None, SchemaName: msdyn_OrganizationalUnitId, IntroducedVersion: 9.0.0.0.  Description: Unique identifier for OrganizationalUnit associated with Equipment</summary>
	[JsonIgnore]
	public Guid? msdyn_OrganizationalUnitId_msdyn_organizationalunit
	{
		set
		{
			if (ContainsKey("msdyn_organizationalunitid_msdyn_organizationalunit@odata.bind") is false || Remove("msdyn_organizationalunitid_msdyn_organizationalunit@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_organizationalunitid_msdyn_organizationalunit@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_organizationalunitid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_organizationalunitid, Format: Text, MaxLength: 100, SchemaName: msdyn_organizationalunitidName, IntroducedVersion: 9.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_organizationalunitidName
	{
		get
		{
			return TryGetValue("msdyn_organizationalunitidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_organizationalunitidname") is false || Remove("msdyn_organizationalunitidname"))
			{
				Add("msdyn_organizationalunitidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Name, Format: Text, MaxLength: 160, SchemaName: Name, IntroducedVersion: 5.0.0.0.  Description: Name of the facility/equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent business unit.</summary>
	[JsonIgnore]
	public string? OrganizationIdFormattedValue
	{
		get
		{
			return TryGetValue("_organizationid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent business unit.</summary>
	[JsonIgnore]
	public Guid? OrganizationId
	{
		get
		{
			return TryGetValue("_organizationid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent business unit.</summary>
	[JsonIgnore]
	public Guid? OrganizationId_organization
	{
		set
		{
			if (ContainsKey("organizationid_organization@odata.bind") is false || Remove("organizationid_organization@odata.bind"))
			{
				if (value is not null)
				{
					Add("organizationid_organization@odata.bind", $"({value})");
				}
				else
				{
					Add("_organizationid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: organizationid, Format: Text, MaxLength: 100, SchemaName: OrganizationIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? OrganizationIdName
	{
		get
		{
			return TryGetValue("organizationidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("organizationidname") is false || Remove("organizationidname"))
			{
				Add("organizationidname", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time that the record was migrated.</summary>
	[JsonIgnore]
	public DateTime? OverriddenCreatedOn
	{
		get
		{
			return TryGetValue("overriddencreatedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("overriddencreatedon") is false || Remove("overriddencreatedon"))
			{
				Add("overriddencreatedon", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site where the facility/equipment is located.</summary>
	[JsonIgnore]
	public string? SiteIdFormattedValue
	{
		get
		{
			return TryGetValue("_siteid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site where the facility/equipment is located.</summary>
	[JsonIgnore]
	public Guid? SiteId
	{
		get
		{
			return TryGetValue("_siteid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site where the facility/equipment is located.</summary>
	[JsonIgnore]
	public Guid? SiteId_site
	{
		set
		{
			if (ContainsKey("siteid_site@odata.bind") is false || Remove("siteid_site@odata.bind"))
			{
				if (value is not null)
				{
					Add("siteid_site@odata.bind", $"({value})");
				}
				else
				{
					Add("_siteid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: siteid, Format: Text, MaxLength: 100, SchemaName: SiteIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? SiteIdName
	{
		get
		{
			return TryGetValue("siteidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("siteidname") is false || Remove("siteidname"))
			{
				Add("siteidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Skills, Format: Text, MaxLength: 100, SchemaName: Skills, IntroducedVersion: 5.0.0.0.  Description: Skills needed to operate the facility/equipment.</summary>
	[JsonIgnore]
	public string? Skills
	{
		get
		{
			return TryGetValue("skills", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("skills") is false || Remove("skills"))
			{
				Add("skills", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Time Zone, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: TimeZoneCode, IntroducedVersion: 5.0.0.0.  Description: Local time zone where the facility/equipment is located.</summary>
	[JsonIgnore]
	public int? TimeZoneCode
	{
		get
		{
			return TryGetValue("timezonecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("timezonecode") is false || Remove("timezonecode"))
			{
				Add("timezonecode", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the equipment.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the equipment.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version Number</summary>
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

}

