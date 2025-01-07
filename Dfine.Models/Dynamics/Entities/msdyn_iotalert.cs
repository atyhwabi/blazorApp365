namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public sealed partial class msdyn_iotalert : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 1.0.0.0.  Description: Date and time when the record was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 1.0.0.0.  Description: Sequence number of the import that created this record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 1.0.0.0.  Description: Date and time when the record was modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Alert Data, Format: Text, MaxLength: 8192, SchemaName: msdyn_AlertData, IntroducedVersion: 1.0.0.0.  Description: Data sent from the device about the alert.</summary>
	[JsonIgnore]
	public string? msdyn_AlertData
	{
		get
		{
			return TryGetValue("msdyn_alertdata", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_alertdata") is false || Remove("msdyn_alertdata"))
			{
				Add("msdyn_alertdata", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Priority Score (%), Format: None, MinValue: 0, MaxValue: 100, SchemaName: msdyn_alertpriorityscore, IntroducedVersion: 1.7.9.196.  Description: The suggested priority score for this alert.</summary>
	[JsonIgnore]
	public int? msdyn_alertpriorityscore
	{
		get
		{
			return TryGetValue("msdyn_alertpriorityscore", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_alertpriorityscore") is false || Remove("msdyn_alertpriorityscore"))
			{
				Add("msdyn_alertpriorityscore", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Alert Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: msdyn_AlertTime, IntroducedVersion: 1.0.0.0.  Description: The time the alert was issued.</summary>
	[JsonIgnore]
	public DateTime? msdyn_AlertTime
	{
		get
		{
			return TryGetValue("msdyn_alerttime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_alerttime") is false || Remove("msdyn_alerttime"))
			{
				Add("msdyn_alerttime", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Alert Token, Format: Text, MaxLength: 100, SchemaName: msdyn_AlertToken, IntroducedVersion: 1.0.0.0.  Description: The unique reference to the event id on the IoT provider.</summary>
	[JsonIgnore]
	public string? msdyn_AlertToken
	{
		get
		{
			return TryGetValue("msdyn_alerttoken", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_alerttoken") is false || Remove("msdyn_alerttoken"))
			{
				Add("msdyn_alerttoken", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Alert Type, SchemaName: msdyn_alerttype, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_alerttypeFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_alerttype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Alert Type, SchemaName: msdyn_alerttype, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public int? msdyn_alerttype
	{
		get
		{
			return TryGetValue("msdyn_alerttype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_alerttype") is false || Remove("msdyn_alerttype"))
			{
				Add("msdyn_alerttype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_alerttype, SchemaName: msdyn_alerttypeName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_alerttypeName
	{
		get
		{
			return TryGetValue("msdyn_alerttypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Alert URL, Format: Url, MaxLength: 500, SchemaName: msdyn_AlertURL, IntroducedVersion: 1.0.0.0.  Description: External URL to view more information about the iot alert.</summary>
	[JsonIgnore]
	public string? msdyn_AlertURL
	{
		get
		{
			return TryGetValue("msdyn_alerturl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_alerturl") is false || Remove("msdyn_alerturl"))
			{
				Add("msdyn_alerturl", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: msdyn_case, IntroducedVersion: 1.0.0.0.  Description: Case created for this iot alert.</summary>
	[JsonIgnore]
	public string? msdyn_caseFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_case_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: msdyn_case, IntroducedVersion: 1.0.0.0.  Description: Case created for this iot alert.</summary>
	[JsonIgnore]
	public Guid? msdyn_case
	{
		get
		{
			return TryGetValue("_msdyn_case_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: msdyn_case, IntroducedVersion: 1.0.0.0.  Description: Case created for this iot alert.</summary>
	[JsonIgnore]
	public Guid? msdyn_case_incident
	{
		set
		{
			if (ContainsKey("msdyn_case_incident@odata.bind") is false || Remove("msdyn_case_incident@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_case_incident@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_case_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_case, Format: Text, MaxLength: 200, SchemaName: msdyn_caseName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_caseName
	{
		get
		{
			return TryGetValue("msdyn_casename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_casename") is false || Remove("msdyn_casename"))
			{
				Add("msdyn_casename", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Customer Asset, Format: None, SchemaName: msdyn_CustomerAsset, IntroducedVersion: 1.0.0.0.  Description: The asset connected to the IoT device that raised the alert.</summary>
	[JsonIgnore]
	public string? msdyn_CustomerAssetFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_customerasset_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Customer Asset, Format: None, SchemaName: msdyn_CustomerAsset, IntroducedVersion: 1.0.0.0.  Description: The asset connected to the IoT device that raised the alert.</summary>
	[JsonIgnore]
	public Guid? msdyn_CustomerAsset
	{
		get
		{
			return TryGetValue("_msdyn_customerasset_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Customer Asset, Format: None, SchemaName: msdyn_CustomerAsset, IntroducedVersion: 1.0.0.0.  Description: The asset connected to the IoT device that raised the alert.</summary>
	[JsonIgnore]
	public Guid? msdyn_CustomerAsset_msdyn_customerasset
	{
		set
		{
			if (ContainsKey("msdyn_customerasset_msdyn_customerasset@odata.bind") is false || Remove("msdyn_customerasset_msdyn_customerasset@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_customerasset_msdyn_customerasset@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_customerasset_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_customerasset, Format: Text, MaxLength: 100, SchemaName: msdyn_CustomerAssetName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_CustomerAssetName
	{
		get
		{
			return TryGetValue("msdyn_customerassetname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_customerassetname") is false || Remove("msdyn_customerassetname"))
			{
				Add("msdyn_customerassetname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Description, Format: Text, MaxLength: 100, SchemaName: msdyn_Description, IntroducedVersion: 1.0.0.0.  Description: A description for the alert.</summary>
	[JsonIgnore]
	public string? msdyn_Description
	{
		get
		{
			return TryGetValue("msdyn_description", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_description") is false || Remove("msdyn_description"))
			{
				Add("msdyn_description", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Device, Format: None, SchemaName: msdyn_Device, IntroducedVersion: 1.0.0.0.  Description: The IoT device for which this alert was raised.</summary>
	[JsonIgnore]
	public string? msdyn_DeviceFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_device_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Device, Format: None, SchemaName: msdyn_Device, IntroducedVersion: 1.0.0.0.  Description: The IoT device for which this alert was raised.</summary>
	[JsonIgnore]
	public Guid? msdyn_Device
	{
		get
		{
			return TryGetValue("_msdyn_device_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Device, Format: None, SchemaName: msdyn_Device, IntroducedVersion: 1.0.0.0.  Description: The IoT device for which this alert was raised.</summary>
	[JsonIgnore]
	public Guid? msdyn_Device_msdyn_iotdevice
	{
		set
		{
			if (ContainsKey("msdyn_device_msdyn_iotdevice@odata.bind") is false || Remove("msdyn_device_msdyn_iotdevice@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_device_msdyn_iotdevice@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_device_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Device ID, Format: Text, MaxLength: 100, SchemaName: msdyn_DeviceID, IntroducedVersion: 1.0.0.0.  Description: The ID of the IoT device that sent the alert.</summary>
	[JsonIgnore]
	public string? msdyn_DeviceID
	{
		get
		{
			return TryGetValue("msdyn_deviceid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_deviceid") is false || Remove("msdyn_deviceid"))
			{
				Add("msdyn_deviceid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_device, Format: Text, MaxLength: 100, SchemaName: msdyn_DeviceName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_DeviceName
	{
		get
		{
			return TryGetValue("msdyn_devicename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_devicename") is false || Remove("msdyn_devicename"))
			{
				Add("msdyn_devicename", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: IoT Alert, SchemaName: msdyn_iotalertId, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for entity instances</summary>
	[JsonIgnore]
	public Guid? msdyn_iotalertId
	{
		get
		{
			return TryGetValue("msdyn_iotalertid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_iotalertid") is false || Remove("msdyn_iotalertid"))
			{
				Add("msdyn_iotalertid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last Command Sent, Format: None, SchemaName: msdyn_LastCommandSent, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_LastCommandSentFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_lastcommandsent_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last Command Sent, Format: None, SchemaName: msdyn_LastCommandSent, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? msdyn_LastCommandSent
	{
		get
		{
			return TryGetValue("_msdyn_lastcommandsent_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last Command Sent, Format: None, SchemaName: msdyn_LastCommandSent, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? msdyn_LastCommandSent_msdyn_iotdevicecommand
	{
		set
		{
			if (ContainsKey("msdyn_lastcommandsent_msdyn_iotdevicecommand@odata.bind") is false || Remove("msdyn_lastcommandsent_msdyn_iotdevicecommand@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_lastcommandsent_msdyn_iotdevicecommand@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_lastcommandsent_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_lastcommandsent, Format: Text, MaxLength: 100, SchemaName: msdyn_LastCommandSentName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_LastCommandSentName
	{
		get
		{
			return TryGetValue("msdyn_lastcommandsentname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_lastcommandsentname") is false || Remove("msdyn_lastcommandsentname"))
			{
				Add("msdyn_lastcommandsentname", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Command Sent Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: msdyn_LastCommandSentTime, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public DateTime? msdyn_LastCommandSentTime
	{
		get
		{
			return TryGetValue("msdyn_lastcommandsenttime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_lastcommandsenttime") is false || Remove("msdyn_lastcommandsenttime"))
			{
				Add("msdyn_lastcommandsenttime", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Alert, Format: None, SchemaName: msdyn_ParentAlert, IntroducedVersion: 1.0.0.0.  Description: Reference to a primary alert. This field is inferred if Primary Alert Token is set.</summary>
	[JsonIgnore]
	public string? msdyn_ParentAlertFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_parentalert_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Alert, Format: None, SchemaName: msdyn_ParentAlert, IntroducedVersion: 1.0.0.0.  Description: Reference to a primary alert. This field is inferred if Primary Alert Token is set.</summary>
	[JsonIgnore]
	public Guid? msdyn_ParentAlert
	{
		get
		{
			return TryGetValue("_msdyn_parentalert_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Alert, Format: None, SchemaName: msdyn_ParentAlert, IntroducedVersion: 1.0.0.0.  Description: Reference to a primary alert. This field is inferred if Primary Alert Token is set.</summary>
	[JsonIgnore]
	public Guid? msdyn_ParentAlert_msdyn_iotalert
	{
		set
		{
			if (ContainsKey("msdyn_parentalert_msdyn_iotalert@odata.bind") is false || Remove("msdyn_parentalert_msdyn_iotalert@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_parentalert_msdyn_iotalert@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_parentalert_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_parentalert, Format: Text, MaxLength: 100, SchemaName: msdyn_ParentAlertName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_ParentAlertName
	{
		get
		{
			return TryGetValue("msdyn_parentalertname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_parentalertname") is false || Remove("msdyn_parentalertname"))
			{
				Add("msdyn_parentalertname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Primary Alert Token, Format: Text, MaxLength: 100, SchemaName: msdyn_ParentAlertToken, IntroducedVersion: 1.0.0.0.  Description: Reference to a previously created primary iot alert</summary>
	[JsonIgnore]
	public string? msdyn_ParentAlertToken
	{
		get
		{
			return TryGetValue("msdyn_parentalerttoken", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_parentalerttoken") is false || Remove("msdyn_parentalerttoken"))
			{
				Add("msdyn_parentalerttoken", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Suggested Priority, SchemaName: msdyn_suggestedpriority, IntroducedVersion: 1.7.7.0.  Description: The suggested priority for this alert.</summary>
	[JsonIgnore]
	public string? msdyn_suggestedpriorityFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_suggestedpriority@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Suggested Priority, SchemaName: msdyn_suggestedpriority, IntroducedVersion: 1.7.7.0.  Description: The suggested priority for this alert.</summary>
	[JsonIgnore]
	public int? msdyn_suggestedpriority
	{
		get
		{
			return TryGetValue("msdyn_suggestedpriority", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_suggestedpriority") is false || Remove("msdyn_suggestedpriority"))
			{
				Add("msdyn_suggestedpriority", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_suggestedpriority, SchemaName: msdyn_suggestedpriorityName, IntroducedVersion: 1.7.7.0. </summary>
	[JsonIgnore]
	public object? msdyn_suggestedpriorityName
	{
		get
		{
			return TryGetValue("msdyn_suggestedpriorityname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 1.0.0.0.  Description: Date and time that the record was migrated.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 1.0.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 1.0.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 1.0.0.0.  Description: Name of the owner</summary>
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

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 1.0.0.0.  Description: Owner Id Type</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 1.0.0.0.  Description: Yomi name of the owner</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 100, SchemaName: OwningBusinessUnitName, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process Id, SchemaName: processid, IntroducedVersion: 1.0.0.0.  Description: Contains the id of the process associated with the entity.</summary>
	[JsonIgnore]
	public Guid? processid
	{
		get
		{
			return TryGetValue("processid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("processid") is false || Remove("processid"))
			{
				Add("processid", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Stage Id, SchemaName: stageid, IntroducedVersion: 1.0.0.0.  Description: Contains the id of the stage where the entity is located.</summary>
	[JsonIgnore]
	public Guid? stageid
	{
		get
		{
			return TryGetValue("stageid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("stageid") is false || Remove("stageid"))
			{
				Add("stageid", value);
			}
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: statecode, IntroducedVersion: 1.0.0.0.  Description: Status of the IoT Alert</summary>
	[JsonIgnore]
	public string? statecodeFormattedValue
	{
		get
		{
			return TryGetValue("statecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: statecode, IntroducedVersion: 1.0.0.0.  Description: Status of the IoT Alert</summary>
	[JsonIgnore]
	public int? statecode
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: statecodeName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? statecodeName
	{
		get
		{
			return TryGetValue("statecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Alert Status, SchemaName: statuscode, IntroducedVersion: 1.0.0.0.  Description: Reason for the status of the IoT Alert</summary>
	[JsonIgnore]
	public string? statuscodeFormattedValue
	{
		get
		{
			return TryGetValue("statuscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Alert Status, SchemaName: statuscode, IntroducedVersion: 1.0.0.0.  Description: Reason for the status of the IoT Alert</summary>
	[JsonIgnore]
	public int? statuscode
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: statuscodeName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? statuscodeName
	{
		get
		{
			return TryGetValue("statuscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 1.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Traversed Path, Format: Text, MaxLength: 1250, SchemaName: traversedpath, IntroducedVersion: 1.0.0.0.  Description: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.</summary>
	[JsonIgnore]
	public string? traversedpath
	{
		get
		{
			return TryGetValue("traversedpath", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("traversedpath") is false || Remove("traversedpath"))
			{
				Add("traversedpath", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 1.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 1.0.0.0.  Description: Version Number</summary>
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

