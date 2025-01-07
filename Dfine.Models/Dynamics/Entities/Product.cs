namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Information about products and their pricing information.</summary>
public sealed partial class Product : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who created the record.</summary>
	[JsonIgnore]
	public string? CreatedByExternalPartyFormattedValue
	{
		get
		{
			return TryGetValue("_createdbyexternalparty_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who created the record.</summary>
	[JsonIgnore]
	public Guid? CreatedByExternalParty
	{
		get
		{
			return TryGetValue("_createdbyexternalparty_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who created the record.</summary>
	[JsonIgnore]
	public Guid? CreatedByExternalParty_externalparty
	{
		set
		{
			if (ContainsKey("createdbyexternalparty_externalparty@odata.bind") is false || Remove("createdbyexternalparty_externalparty@odata.bind"))
			{
				if (value is not null)
				{
					Add("createdbyexternalparty_externalparty@odata.bind", $"({value})");
				}
				else
				{
					Add("_createdbyexternalparty_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CreatedByExternalPartyName
	{
		get
		{
			return TryGetValue("createdbyexternalpartyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("createdbyexternalpartyname") is false || Remove("createdbyexternalpartyname"))
			{
				Add("createdbyexternalpartyname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyYomiName, YomiOf: createdbyexternalpartyname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CreatedByExternalPartyYomiName
	{
		get
		{
			return TryGetValue("createdbyexternalpartyyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("createdbyexternalpartyyominame") is false || Remove("createdbyexternalpartyyominame"))
			{
				Add("createdbyexternalpartyyominame", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the product.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Current Cost, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: CurrentCost, IntroducedVersion: 5.0.0.0.  Description: Current cost for the product item. Used in price calculations.</summary>
	[JsonIgnore]
	public string? CurrentCostFormattedValue
	{
		get
		{
			return TryGetValue("currentcost@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Current Cost, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: CurrentCost, IntroducedVersion: 5.0.0.0.  Description: Current cost for the product item. Used in price calculations.</summary>
	[JsonIgnore]
	public decimal? CurrentCost
	{
		get
		{
			return TryGetValue("currentcost", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentcost") is false || Remove("currentcost"))
			{
				Add("currentcost", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Current Cost (Base), CalculationOf: currentcost, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: CurrentCost_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Current Cost in base currency.</summary>
	[JsonIgnore]
	public string? CurrentCost_BaseFormattedValue
	{
		get
		{
			return TryGetValue("currentcost_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Current Cost (Base), CalculationOf: currentcost, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: CurrentCost_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Current Cost in base currency.</summary>
	[JsonIgnore]
	public decimal? CurrentCost_Base
	{
		get
		{
			return TryGetValue("currentcost_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("currentcost_base") is false || Remove("currentcost_base"))
			{
				Add("currentcost_base", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Default Unit, Format: None, SchemaName: DefaultUoMId, IntroducedVersion: 5.0.0.0.  Description: Default unit for the product.</summary>
	[JsonIgnore]
	public string? DefaultUoMIdFormattedValue
	{
		get
		{
			return TryGetValue("_defaultuomid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Default Unit, Format: None, SchemaName: DefaultUoMId, IntroducedVersion: 5.0.0.0.  Description: Default unit for the product.</summary>
	[JsonIgnore]
	public Guid? DefaultUoMId
	{
		get
		{
			return TryGetValue("_defaultuomid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Default Unit, Format: None, SchemaName: DefaultUoMId, IntroducedVersion: 5.0.0.0.  Description: Default unit for the product.</summary>
	[JsonIgnore]
	public Guid? DefaultUoMId_uom
	{
		set
		{
			if (ContainsKey("defaultuomid_uom@odata.bind") is false || Remove("defaultuomid_uom@odata.bind"))
			{
				if (value is not null)
				{
					Add("defaultuomid_uom@odata.bind", $"({value})");
				}
				else
				{
					Add("_defaultuomid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: defaultuomid, Format: Text, MaxLength: 100, SchemaName: DefaultUoMIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? DefaultUoMIdName
	{
		get
		{
			return TryGetValue("defaultuomidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultuomidname") is false || Remove("defaultuomidname"))
			{
				Add("defaultuomidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Unit Group, Format: None, SchemaName: DefaultUoMScheduleId, IntroducedVersion: 5.0.0.0.  Description: Default unit group for the product.</summary>
	[JsonIgnore]
	public string? DefaultUoMScheduleIdFormattedValue
	{
		get
		{
			return TryGetValue("_defaultuomscheduleid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Unit Group, Format: None, SchemaName: DefaultUoMScheduleId, IntroducedVersion: 5.0.0.0.  Description: Default unit group for the product.</summary>
	[JsonIgnore]
	public Guid? DefaultUoMScheduleId
	{
		get
		{
			return TryGetValue("_defaultuomscheduleid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Unit Group, Format: None, SchemaName: DefaultUoMScheduleId, IntroducedVersion: 5.0.0.0.  Description: Default unit group for the product.</summary>
	[JsonIgnore]
	public Guid? DefaultUoMScheduleId_uomschedule
	{
		set
		{
			if (ContainsKey("defaultuomscheduleid_uomschedule@odata.bind") is false || Remove("defaultuomscheduleid_uomschedule@odata.bind"))
			{
				if (value is not null)
				{
					Add("defaultuomscheduleid_uomschedule@odata.bind", $"({value})");
				}
				else
				{
					Add("_defaultuomscheduleid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: defaultuomscheduleid, Format: Text, MaxLength: 100, SchemaName: DefaultUoMScheduleIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? DefaultUoMScheduleIdName
	{
		get
		{
			return TryGetValue("defaultuomscheduleidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultuomscheduleidname") is false || Remove("defaultuomscheduleidname"))
			{
				Add("defaultuomscheduleidname", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Description of the product.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Internal Use Only, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: DMTImportState, IntroducedVersion: 7.0.0.0.  Description: Internal Use Only</summary>
	[JsonIgnore]
	public int? DMTImportState
	{
		get
		{
			return TryGetValue("dmtimportstate", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("dmtimportstate") is false || Remove("dmtimportstate"))
			{
				Add("dmtimportstate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Entity Image, AttributeOf: entityimageid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: EntityImage, IntroducedVersion: 6.0.0.0.  Description: Shows the default image for the record.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, SchemaName: EntityImageId, IntroducedVersion: 6.0.0.0. </summary>
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the product with respect to the base currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Hierarchy Path, Format: Text, MaxLength: 450, SchemaName: HierarchyPath, IntroducedVersion: 7.0.0.0.  Description: Hierarchy path of the product.</summary>
	[JsonIgnore]
	public string? HierarchyPath
	{
		get
		{
			return TryGetValue("hierarchypath", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("hierarchypath") is false || Remove("hierarchypath"))
			{
				Add("hierarchypath", value);
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Kit, SchemaName: IsKit, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether the product is a kit.</summary>
	[JsonIgnore]
	public string? IsKitFormattedValue
	{
		get
		{
			return TryGetValue("iskit@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Kit, SchemaName: IsKit, IntroducedVersion: 5.0.0.0.  Description: Information that specifies whether the product is a kit.</summary>
	[JsonIgnore]
	public bool? IsKit
	{
		get
		{
			return TryGetValue("iskit", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("iskit") is false || Remove("iskit"))
			{
				Add("iskit", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: iskit, SchemaName: IsKitName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsKitName
	{
		get
		{
			return TryGetValue("iskitname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Reparented, SchemaName: IsReparented, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? IsReparentedFormattedValue
	{
		get
		{
			return TryGetValue("isreparented@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Reparented, SchemaName: IsReparented, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public bool? IsReparented
	{
		get
		{
			return TryGetValue("isreparented", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isreparented") is false || Remove("isreparented"))
			{
				Add("isreparented", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isreparented, SchemaName: isreparentedName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? isreparentedName
	{
		get
		{
			return TryGetValue("isreparentedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Stock Item, SchemaName: IsStockItem, IntroducedVersion: 5.0.0.0.  Description: Information about whether the product is a stock item.</summary>
	[JsonIgnore]
	public string? IsStockItemFormattedValue
	{
		get
		{
			return TryGetValue("isstockitem@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Stock Item, SchemaName: IsStockItem, IntroducedVersion: 5.0.0.0.  Description: Information about whether the product is a stock item.</summary>
	[JsonIgnore]
	public bool? IsStockItem
	{
		get
		{
			return TryGetValue("isstockitem", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isstockitem") is false || Remove("isstockitem"))
			{
				Add("isstockitem", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isstockitem, SchemaName: IsStockItemName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsStockItemName
	{
		get
		{
			return TryGetValue("isstockitemname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who modified the record.</summary>
	[JsonIgnore]
	public string? ModifiedByExternalPartyFormattedValue
	{
		get
		{
			return TryGetValue("_modifiedbyexternalparty_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who modified the record.</summary>
	[JsonIgnore]
	public Guid? ModifiedByExternalParty
	{
		get
		{
			return TryGetValue("_modifiedbyexternalparty_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 5.0.0.0.  Description: Shows the external party who modified the record.</summary>
	[JsonIgnore]
	public Guid? ModifiedByExternalParty_externalparty
	{
		set
		{
			if (ContainsKey("modifiedbyexternalparty_externalparty@odata.bind") is false || Remove("modifiedbyexternalparty_externalparty@odata.bind"))
			{
				if (value is not null)
				{
					Add("modifiedbyexternalparty_externalparty@odata.bind", $"({value})");
				}
				else
				{
					Add("_modifiedbyexternalparty_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ModifiedByExternalPartyName
	{
		get
		{
			return TryGetValue("modifiedbyexternalpartyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("modifiedbyexternalpartyname") is false || Remove("modifiedbyexternalpartyname"))
			{
				Add("modifiedbyexternalpartyname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyYomiName, YomiOf: modifiedbyexternalpartyname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ModifiedByExternalPartyYomiName
	{
		get
		{
			return TryGetValue("modifiedbyexternalpartyyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("modifiedbyexternalpartyyominame") is false || Remove("modifiedbyexternalpartyyominame"))
			{
				Add("modifiedbyexternalpartyyominame", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the product.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether product is opted out or not</summary>
	[JsonIgnore]
	public string? msdyn_gdproptoutFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_gdproptout@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether product is opted out or not</summary>
	[JsonIgnore]
	public bool? msdyn_gdproptout
	{
		get
		{
			return TryGetValue("msdyn_gdproptout", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_gdproptout") is false || Remove("msdyn_gdproptout"))
			{
				Add("msdyn_gdproptout", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_gdproptout, SchemaName: msdyn_gdproptoutName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_gdproptoutName
	{
		get
		{
			return TryGetValue("msdyn_gdproptoutname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Name, Format: Text, MaxLength: 100, SchemaName: Name, IntroducedVersion: 5.0.0.0.  Description: Name of the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the organization</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the organization</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the organization</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent, Format: None, SchemaName: ParentProductId, IntroducedVersion: 7.0.0.0.  Description: Specifies the parent product family hierarchy.</summary>
	[JsonIgnore]
	public string? ParentProductIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentproductid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent, Format: None, SchemaName: ParentProductId, IntroducedVersion: 7.0.0.0.  Description: Specifies the parent product family hierarchy.</summary>
	[JsonIgnore]
	public Guid? ParentProductId
	{
		get
		{
			return TryGetValue("_parentproductid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent, Format: None, SchemaName: ParentProductId, IntroducedVersion: 7.0.0.0.  Description: Specifies the parent product family hierarchy.</summary>
	[JsonIgnore]
	public Guid? ParentProductId_product
	{
		set
		{
			if (ContainsKey("parentproductid_product@odata.bind") is false || Remove("parentproductid_product@odata.bind"))
			{
				if (value is not null)
				{
					Add("parentproductid_product@odata.bind", $"({value})");
				}
				else
				{
					Add("_parentproductid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentproductid, Format: Text, MaxLength: 100, SchemaName: ParentProductIdName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentProductIdName
	{
		get
		{
			return TryGetValue("parentproductidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentproductidname") is false || Remove("parentproductidname"))
			{
				Add("parentproductidname", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: List Price, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: Price, IntroducedVersion: 5.0.0.0.  Description: List price for the product item. Used in price calculations.</summary>
	[JsonIgnore]
	public string? PriceFormattedValue
	{
		get
		{
			return TryGetValue("price@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: List Price, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: Price, IntroducedVersion: 5.0.0.0.  Description: List price for the product item. Used in price calculations.</summary>
	[JsonIgnore]
	public decimal? Price
	{
		get
		{
			return TryGetValue("price", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("price") is false || Remove("price"))
			{
				Add("price", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: List Price (Base), CalculationOf: price, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Price_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the List Price in base currency.</summary>
	[JsonIgnore]
	public string? Price_BaseFormattedValue
	{
		get
		{
			return TryGetValue("price_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: List Price (Base), CalculationOf: price, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Price_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the List Price in base currency.</summary>
	[JsonIgnore]
	public decimal? Price_Base
	{
		get
		{
			return TryGetValue("price_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("price_base") is false || Remove("price_base"))
			{
				Add("price_base", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: Recommended, DisplayName: Default Price List, Format: None, SchemaName: PriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Select the default price list for the product.</summary>
	[JsonIgnore]
	public string? PriceLevelIdFormattedValue
	{
		get
		{
			return TryGetValue("_pricelevelid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: Recommended, DisplayName: Default Price List, Format: None, SchemaName: PriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Select the default price list for the product.</summary>
	[JsonIgnore]
	public Guid? PriceLevelId
	{
		get
		{
			return TryGetValue("_pricelevelid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: Recommended, DisplayName: Default Price List, Format: None, SchemaName: PriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Select the default price list for the product.</summary>
	[JsonIgnore]
	public Guid? PriceLevelId_pricelevel
	{
		set
		{
			if (ContainsKey("pricelevelid_pricelevel@odata.bind") is false || Remove("pricelevelid_pricelevel@odata.bind"))
			{
				if (value is not null)
				{
					Add("pricelevelid_pricelevel@odata.bind", $"({value})");
				}
				else
				{
					Add("_pricelevelid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: pricelevelid, Format: Text, MaxLength: 100, SchemaName: PriceLevelIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? PriceLevelIdName
	{
		get
		{
			return TryGetValue("pricelevelidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("pricelevelidname") is false || Remove("pricelevelidname"))
			{
				Add("pricelevelidname", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process Id, SchemaName: ProcessId, IntroducedVersion: 5.0.0.0.  Description: Contains the id of the process associated with the entity.</summary>
	[JsonIgnore]
	public Guid? ProcessId
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Product, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the product.</summary>
	[JsonIgnore]
	public Guid? ProductId
	{
		get
		{
			return TryGetValue("productid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("productid") is false || Remove("productid"))
			{
				Add("productid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Product ID, AutoNumberFormat: P-{SEQNUM:5}-{RANDSTRING:6}, Format: Text, MaxLength: 100, SchemaName: ProductNumber, IntroducedVersion: 5.0.0.0.  Description: User-defined product ID.</summary>
	[JsonIgnore]
	public string? ProductNumber
	{
		get
		{
			return TryGetValue("productnumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("productnumber") is false || Remove("productnumber"))
			{
				Add("productnumber", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Product Structure, SchemaName: ProductStructure, IntroducedVersion: 7.0.0.0.  Description: Product Structure.</summary>
	[JsonIgnore]
	public string? ProductStructureFormattedValue
	{
		get
		{
			return TryGetValue("productstructure@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Product Structure, SchemaName: ProductStructure, IntroducedVersion: 7.0.0.0.  Description: Product Structure.</summary>
	[JsonIgnore]
	public int? ProductStructure
	{
		get
		{
			return TryGetValue("productstructure", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("productstructure") is false || Remove("productstructure"))
			{
				Add("productstructure", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: SystemRequired, AttributeOf: productstructure, SchemaName: ProductStructureName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? ProductStructureName
	{
		get
		{
			return TryGetValue("productstructurename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Product Type, SchemaName: ProductTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of product.</summary>
	[JsonIgnore]
	public string? ProductTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("producttypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Product Type, SchemaName: ProductTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of product.</summary>
	[JsonIgnore]
	public int? ProductTypeCode
	{
		get
		{
			return TryGetValue("producttypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("producttypecode") is false || Remove("producttypecode"))
			{
				Add("producttypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: producttypecode, SchemaName: ProductTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ProductTypeCodeName
	{
		get
		{
			return TryGetValue("producttypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: URL, Format: Url, MaxLength: 255, SchemaName: ProductUrl, IntroducedVersion: 5.0.0.0.  Description: URL for the Website associated with the product.</summary>
	[JsonIgnore]
	public string? ProductUrl
	{
		get
		{
			return TryGetValue("producturl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("producturl") is false || Remove("producturl"))
			{
				Add("producturl", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: ApplicationRequired, DisplayName: Decimals Supported, Format: None, MinValue: 0, MaxValue: 5, SchemaName: QuantityDecimal, IntroducedVersion: 5.0.0.0.  Description: Number of decimal places that can be used in monetary amounts for the product.</summary>
	[JsonIgnore]
	public int? QuantityDecimal
	{
		get
		{
			return TryGetValue("quantitydecimal", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("quantitydecimal") is false || Remove("quantitydecimal"))
			{
				Add("quantitydecimal", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Quantity On Hand, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: QuantityOnHand, IntroducedVersion: 5.0.0.0.  Description: Quantity of the product in stock.</summary>
	[JsonIgnore]
	public decimal? QuantityOnHand
	{
		get
		{
			return TryGetValue("quantityonhand", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("quantityonhand") is false || Remove("quantityonhand"))
			{
				Add("quantityonhand", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Size, Format: Text, MaxLength: 200, SchemaName: Size, IntroducedVersion: 5.0.0.0.  Description: Product size.</summary>
	[JsonIgnore]
	public string? Size
	{
		get
		{
			return TryGetValue("size", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("size") is false || Remove("size"))
			{
				Add("size", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Stage Id, SchemaName: StageId, IntroducedVersion: 5.0.0.0.  Description: Contains the id of the stage where the entity is located.</summary>
	[JsonIgnore]
	public Guid? StageId
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Standard Cost, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: StandardCost, IntroducedVersion: 5.0.0.0.  Description: Standard cost for the product item. Used in price calculations.</summary>
	[JsonIgnore]
	public string? StandardCostFormattedValue
	{
		get
		{
			return TryGetValue("standardcost@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Standard Cost, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: StandardCost, IntroducedVersion: 5.0.0.0.  Description: Standard cost for the product item. Used in price calculations.</summary>
	[JsonIgnore]
	public decimal? StandardCost
	{
		get
		{
			return TryGetValue("standardcost", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("standardcost") is false || Remove("standardcost"))
			{
				Add("standardcost", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Standard Cost (Base), CalculationOf: standardcost, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: StandardCost_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Standard Cost in base currency.</summary>
	[JsonIgnore]
	public string? StandardCost_BaseFormattedValue
	{
		get
		{
			return TryGetValue("standardcost_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Standard Cost (Base), CalculationOf: standardcost, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: StandardCost_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Standard Cost in base currency.</summary>
	[JsonIgnore]
	public decimal? StandardCost_Base
	{
		get
		{
			return TryGetValue("standardcost_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("standardcost_base") is false || Remove("standardcost_base"))
			{
				Add("standardcost_base", value);
			}
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Status of the product.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Status of the product.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Reason for the status of the product.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Reason for the status of the product.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Stock Volume, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: StockVolume, IntroducedVersion: 5.0.0.0.  Description: Stock volume of the product.</summary>
	[JsonIgnore]
	public decimal? StockVolume
	{
		get
		{
			return TryGetValue("stockvolume", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("stockvolume") is false || Remove("stockvolume"))
			{
				Add("stockvolume", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Stock Weight, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: StockWeight, IntroducedVersion: 5.0.0.0.  Description: Stock weight of the product.</summary>
	[JsonIgnore]
	public decimal? StockWeight
	{
		get
		{
			return TryGetValue("stockweight", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("stockweight") is false || Remove("stockweight"))
			{
				Add("stockweight", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Select a category for the product.</summary>
	[JsonIgnore]
	public string? SubjectIdFormattedValue
	{
		get
		{
			return TryGetValue("_subjectid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Select a category for the product.</summary>
	[JsonIgnore]
	public Guid? SubjectId
	{
		get
		{
			return TryGetValue("_subjectid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Select a category for the product.</summary>
	[JsonIgnore]
	public Guid? SubjectId_subject
	{
		set
		{
			if (ContainsKey("subjectid_subject@odata.bind") is false || Remove("subjectid_subject@odata.bind"))
			{
				if (value is not null)
				{
					Add("subjectid_subject@odata.bind", $"({value})");
				}
				else
				{
					Add("_subjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: subjectid, Format: Text, MaxLength: 100, SchemaName: SubjectIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? SubjectIdName
	{
		get
		{
			return TryGetValue("subjectidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("subjectidname") is false || Remove("subjectidname"))
			{
				Add("subjectidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Supplier Name, Format: Text, MaxLength: 100, SchemaName: SupplierName, IntroducedVersion: 5.0.0.0.  Description: Name of the product's supplier.</summary>
	[JsonIgnore]
	public string? SupplierName
	{
		get
		{
			return TryGetValue("suppliername", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("suppliername") is false || Remove("suppliername"))
			{
				Add("suppliername", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the product.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: TraversedPath, IntroducedVersion: 5.0.0.0.  Description: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.</summary>
	[JsonIgnore]
	public string? TraversedPath
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Valid From, DateTimeBehavior: DateOnly, Format: DateOnly, SchemaName: ValidFromDate, IntroducedVersion: 7.0.0.0.  Description: Date from which this product is valid.</summary>
	[JsonIgnore]
	public DateTime? ValidFromDate
	{
		get
		{
			return TryGetValue("validfromdate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("validfromdate") is false || Remove("validfromdate"))
			{
				Add("validfromdate", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Valid To, DateTimeBehavior: DateOnly, Format: DateOnly, SchemaName: ValidToDate, IntroducedVersion: 7.0.0.0.  Description: Date to which this product is valid.</summary>
	[JsonIgnore]
	public DateTime? ValidToDate
	{
		get
		{
			return TryGetValue("validtodate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("validtodate") is false || Remove("validtodate"))
			{
				Add("validtodate", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Vendor ID, Format: Text, MaxLength: 100, SchemaName: VendorID, IntroducedVersion: 7.0.0.0.  Description: Unique identifier of vendor supplying the product.</summary>
	[JsonIgnore]
	public string? VendorID
	{
		get
		{
			return TryGetValue("vendorid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("vendorid") is false || Remove("vendorid"))
			{
				Add("vendorid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Vendor, Format: Text, MaxLength: 100, SchemaName: VendorName, IntroducedVersion: 5.0.0.0.  Description: Name of the product vendor.</summary>
	[JsonIgnore]
	public string? VendorName
	{
		get
		{
			return TryGetValue("vendorname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("vendorname") is false || Remove("vendorname"))
			{
				Add("vendorname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Vendor Name, Format: Text, MaxLength: 100, SchemaName: VendorPartNumber, IntroducedVersion: 5.0.0.0.  Description: Unique part identifier in vendor catalog of this product.</summary>
	[JsonIgnore]
	public string? VendorPartNumber
	{
		get
		{
			return TryGetValue("vendorpartnumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("vendorpartnumber") is false || Remove("vendorpartnumber"))
			{
				Add("vendorpartnumber", value);
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

