namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.</summary>
public sealed partial class Lead : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the lead is associated.</summary>
	[JsonIgnore]
	public string? AccountIdFormattedValue
	{
		get
		{
			return TryGetValue("_accountid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the lead is associated.</summary>
	[JsonIgnore]
	public Guid? AccountId
	{
		get
		{
			return TryGetValue("_accountid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the lead is associated.</summary>
	[JsonIgnore]
	public Guid? AccountId_account
	{
		set
		{
			if (ContainsKey("accountid_account@odata.bind") is false || Remove("accountid_account@odata.bind"))
			{
				if (value is not null)
				{
					Add("accountid_account@odata.bind", $"({value})");
				}
				else
				{
					Add("_accountid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 100, SchemaName: AccountIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? AccountIdName
	{
		get
		{
			return TryGetValue("accountidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountidname") is false || Remove("accountidname"))
			{
				Add("accountidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 100, SchemaName: AccountIdYomiName, YomiOf: accountidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? AccountIdYomiName
	{
		get
		{
			return TryGetValue("accountidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountidyominame") is false || Remove("accountidyominame"))
			{
				Add("accountidyominame", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 1: ID, SchemaName: Address1_AddressId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for address 1.</summary>
	[JsonIgnore]
	public Guid? Address1_AddressId
	{
		get
		{
			return TryGetValue("address1_addressid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_addressid") is false || Remove("address1_addressid"))
			{
				Add("address1_addressid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Address Type, SchemaName: Address1_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary address type.</summary>
	[JsonIgnore]
	public string? Address1_AddressTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("address1_addresstypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Address Type, SchemaName: Address1_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary address type.</summary>
	[JsonIgnore]
	public int? Address1_AddressTypeCode
	{
		get
		{
			return TryGetValue("address1_addresstypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_addresstypecode") is false || Remove("address1_addresstypecode"))
			{
				Add("address1_addresstypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_addresstypecode, SchemaName: Address1_AddressTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? Address1_AddressTypeCodeName
	{
		get
		{
			return TryGetValue("address1_addresstypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: City, Format: Text, MaxLength: 80, SchemaName: Address1_City, IntroducedVersion: 5.0.0.0.  Description: Type the city for the primary address.</summary>
	[JsonIgnore]
	public string? Address1_City
	{
		get
		{
			return TryGetValue("address1_city", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_city") is false || Remove("address1_city"))
			{
				Add("address1_city", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address 1, Format: TextArea, MaxLength: 1000, SchemaName: Address1_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete primary address.</summary>
	[JsonIgnore]
	public string? Address1_Composite
	{
		get
		{
			return TryGetValue("address1_composite", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_composite") is false || Remove("address1_composite"))
			{
				Add("address1_composite", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address1_Country, IntroducedVersion: 5.0.0.0.  Description: Type the country or region for the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Country
	{
		get
		{
			return TryGetValue("address1_country", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_country") is false || Remove("address1_country"))
			{
				Add("address1_country", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: County, Format: Text, MaxLength: 50, SchemaName: Address1_County, IntroducedVersion: 5.0.0.0.  Description: Type the county for the primary address.</summary>
	[JsonIgnore]
	public string? Address1_County
	{
		get
		{
			return TryGetValue("address1_county", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_county") is false || Remove("address1_county"))
			{
				Add("address1_county", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Fax, Format: Text, MaxLength: 50, SchemaName: Address1_Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number associated with the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Fax
	{
		get
		{
			return TryGetValue("address1_fax", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_fax") is false || Remove("address1_fax"))
			{
				Add("address1_fax", value);
			}
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address1_Latitude, IntroducedVersion: 5.0.0.0.  Description: Type the latitude value for the primary address for use in mapping and other applications.</summary>
	[JsonIgnore]
	public double? Address1_Latitude
	{
		get
		{
			return TryGetValue("address1_latitude", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_latitude") is false || Remove("address1_latitude"))
			{
				Add("address1_latitude", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 1, Format: Text, MaxLength: 250, SchemaName: Address1_Line1, IntroducedVersion: 5.0.0.0.  Description: Type the first line of the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Line1
	{
		get
		{
			return TryGetValue("address1_line1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_line1") is false || Remove("address1_line1"))
			{
				Add("address1_line1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 2, Format: Text, MaxLength: 250, SchemaName: Address1_Line2, IntroducedVersion: 5.0.0.0.  Description: Type the second line of the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Line2
	{
		get
		{
			return TryGetValue("address1_line2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_line2") is false || Remove("address1_line2"))
			{
				Add("address1_line2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 3, Format: Text, MaxLength: 250, SchemaName: Address1_Line3, IntroducedVersion: 5.0.0.0.  Description: Type the third line of the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Line3
	{
		get
		{
			return TryGetValue("address1_line3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_line3") is false || Remove("address1_line3"))
			{
				Add("address1_line3", value);
			}
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address1_Longitude, IntroducedVersion: 5.0.0.0.  Description: Type the longitude value for the primary address for use in mapping and other applications.</summary>
	[JsonIgnore]
	public double? Address1_Longitude
	{
		get
		{
			return TryGetValue("address1_longitude", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_longitude") is false || Remove("address1_longitude"))
			{
				Add("address1_longitude", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Name, Format: Text, MaxLength: 100, SchemaName: Address1_Name, IntroducedVersion: 5.0.0.0.  Description: Type a descriptive name for the primary address, such as Corporate Headquarters.</summary>
	[JsonIgnore]
	public string? Address1_Name
	{
		get
		{
			return TryGetValue("address1_name", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_name") is false || Remove("address1_name"))
			{
				Add("address1_name", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address1_PostalCode, IntroducedVersion: 5.0.0.0.  Description: Type the ZIP Code or postal code for the primary address.</summary>
	[JsonIgnore]
	public string? Address1_PostalCode
	{
		get
		{
			return TryGetValue("address1_postalcode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_postalcode") is false || Remove("address1_postalcode"))
			{
				Add("address1_postalcode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address1_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Type the post office box number of the primary address.</summary>
	[JsonIgnore]
	public string? Address1_PostOfficeBox
	{
		get
		{
			return TryGetValue("address1_postofficebox", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_postofficebox") is false || Remove("address1_postofficebox"))
			{
				Add("address1_postofficebox", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Shipping Method, SchemaName: Address1_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public string? Address1_ShippingMethodCodeFormattedValue
	{
		get
		{
			return TryGetValue("address1_shippingmethodcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Shipping Method, SchemaName: Address1_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public int? Address1_ShippingMethodCode
	{
		get
		{
			return TryGetValue("address1_shippingmethodcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_shippingmethodcode") is false || Remove("address1_shippingmethodcode"))
			{
				Add("address1_shippingmethodcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_shippingmethodcode, SchemaName: Address1_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? Address1_ShippingMethodCodeName
	{
		get
		{
			return TryGetValue("address1_shippingmethodcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: State/Province, Format: Text, MaxLength: 50, SchemaName: Address1_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: Type the state or province of the primary address.</summary>
	[JsonIgnore]
	public string? Address1_StateOrProvince
	{
		get
		{
			return TryGetValue("address1_stateorprovince", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_stateorprovince") is false || Remove("address1_stateorprovince"))
			{
				Add("address1_stateorprovince", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Telephone 1, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number associated with the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Telephone1
	{
		get
		{
			return TryGetValue("address1_telephone1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_telephone1") is false || Remove("address1_telephone1"))
			{
				Add("address1_telephone1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Telephone 2, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type a second phone number associated with the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Telephone2
	{
		get
		{
			return TryGetValue("address1_telephone2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_telephone2") is false || Remove("address1_telephone2"))
			{
				Add("address1_telephone2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type a third phone number associated with the primary address.</summary>
	[JsonIgnore]
	public string? Address1_Telephone3
	{
		get
		{
			return TryGetValue("address1_telephone3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_telephone3") is false || Remove("address1_telephone3"))
			{
				Add("address1_telephone3", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address1_UPSZone, IntroducedVersion: 5.0.0.0.  Description: Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</summary>
	[JsonIgnore]
	public string? Address1_UPSZone
	{
		get
		{
			return TryGetValue("address1_upszone", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_upszone") is false || Remove("address1_upszone"))
			{
				Add("address1_upszone", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 1: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address1_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</summary>
	[JsonIgnore]
	public int? Address1_UTCOffset
	{
		get
		{
			return TryGetValue("address1_utcoffset", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_utcoffset") is false || Remove("address1_utcoffset"))
			{
				Add("address1_utcoffset", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 2: ID, SchemaName: Address2_AddressId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for address 2.</summary>
	[JsonIgnore]
	public Guid? Address2_AddressId
	{
		get
		{
			return TryGetValue("address2_addressid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_addressid") is false || Remove("address2_addressid"))
			{
				Add("address2_addressid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Address Type, SchemaName: Address2_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the secondary address type.</summary>
	[JsonIgnore]
	public string? Address2_AddressTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("address2_addresstypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Address Type, SchemaName: Address2_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the secondary address type.</summary>
	[JsonIgnore]
	public int? Address2_AddressTypeCode
	{
		get
		{
			return TryGetValue("address2_addresstypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_addresstypecode") is false || Remove("address2_addresstypecode"))
			{
				Add("address2_addresstypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_addresstypecode, SchemaName: Address2_AddressTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? Address2_AddressTypeCodeName
	{
		get
		{
			return TryGetValue("address2_addresstypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: City, Format: Text, MaxLength: 80, SchemaName: Address2_City, IntroducedVersion: 5.0.0.0.  Description: Type the city for the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_City
	{
		get
		{
			return TryGetValue("address2_city", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_city") is false || Remove("address2_city"))
			{
				Add("address2_city", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address 2, Format: TextArea, MaxLength: 1000, SchemaName: Address2_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Composite
	{
		get
		{
			return TryGetValue("address2_composite", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_composite") is false || Remove("address2_composite"))
			{
				Add("address2_composite", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address2_Country, IntroducedVersion: 5.0.0.0.  Description: Type the country or region for the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Country
	{
		get
		{
			return TryGetValue("address2_country", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_country") is false || Remove("address2_country"))
			{
				Add("address2_country", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: County, Format: Text, MaxLength: 50, SchemaName: Address2_County, IntroducedVersion: 5.0.0.0.  Description: Type the county for the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_County
	{
		get
		{
			return TryGetValue("address2_county", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_county") is false || Remove("address2_county"))
			{
				Add("address2_county", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Fax, Format: Text, MaxLength: 50, SchemaName: Address2_Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number associated with the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Fax
	{
		get
		{
			return TryGetValue("address2_fax", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_fax") is false || Remove("address2_fax"))
			{
				Add("address2_fax", value);
			}
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address2_Latitude, IntroducedVersion: 5.0.0.0.  Description: Type the latitude value for the secondary address for use in mapping and other applications.</summary>
	[JsonIgnore]
	public double? Address2_Latitude
	{
		get
		{
			return TryGetValue("address2_latitude", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_latitude") is false || Remove("address2_latitude"))
			{
				Add("address2_latitude", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 1, Format: Text, MaxLength: 250, SchemaName: Address2_Line1, IntroducedVersion: 5.0.0.0.  Description: Type the first line of the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Line1
	{
		get
		{
			return TryGetValue("address2_line1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_line1") is false || Remove("address2_line1"))
			{
				Add("address2_line1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 2, Format: Text, MaxLength: 250, SchemaName: Address2_Line2, IntroducedVersion: 5.0.0.0.  Description: Type the second line of the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Line2
	{
		get
		{
			return TryGetValue("address2_line2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_line2") is false || Remove("address2_line2"))
			{
				Add("address2_line2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Street 3, Format: Text, MaxLength: 250, SchemaName: Address2_Line3, IntroducedVersion: 5.0.0.0.  Description: Type the third line of the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Line3
	{
		get
		{
			return TryGetValue("address2_line3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_line3") is false || Remove("address2_line3"))
			{
				Add("address2_line3", value);
			}
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address2_Longitude, IntroducedVersion: 5.0.0.0.  Description: Type the longitude value for the secondary address for use in mapping and other applications.</summary>
	[JsonIgnore]
	public double? Address2_Longitude
	{
		get
		{
			return TryGetValue("address2_longitude", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_longitude") is false || Remove("address2_longitude"))
			{
				Add("address2_longitude", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Name, Format: Text, MaxLength: 100, SchemaName: Address2_Name, IntroducedVersion: 5.0.0.0.  Description: Type a descriptive name for the secondary address, such as Corporate Headquarters.</summary>
	[JsonIgnore]
	public string? Address2_Name
	{
		get
		{
			return TryGetValue("address2_name", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_name") is false || Remove("address2_name"))
			{
				Add("address2_name", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address2_PostalCode, IntroducedVersion: 5.0.0.0.  Description: Type the ZIP Code or postal code for the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_PostalCode
	{
		get
		{
			return TryGetValue("address2_postalcode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_postalcode") is false || Remove("address2_postalcode"))
			{
				Add("address2_postalcode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address2_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Type the post office box number of the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_PostOfficeBox
	{
		get
		{
			return TryGetValue("address2_postofficebox", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_postofficebox") is false || Remove("address2_postofficebox"))
			{
				Add("address2_postofficebox", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Shipping Method, SchemaName: Address2_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public string? Address2_ShippingMethodCodeFormattedValue
	{
		get
		{
			return TryGetValue("address2_shippingmethodcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Shipping Method, SchemaName: Address2_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public int? Address2_ShippingMethodCode
	{
		get
		{
			return TryGetValue("address2_shippingmethodcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_shippingmethodcode") is false || Remove("address2_shippingmethodcode"))
			{
				Add("address2_shippingmethodcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_shippingmethodcode, SchemaName: Address2_ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? Address2_ShippingMethodCodeName
	{
		get
		{
			return TryGetValue("address2_shippingmethodcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: State/Province, Format: Text, MaxLength: 50, SchemaName: Address2_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: Type the state or province of the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_StateOrProvince
	{
		get
		{
			return TryGetValue("address2_stateorprovince", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_stateorprovince") is false || Remove("address2_stateorprovince"))
			{
				Add("address2_stateorprovince", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 1, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number associated with the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Telephone1
	{
		get
		{
			return TryGetValue("address2_telephone1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_telephone1") is false || Remove("address2_telephone1"))
			{
				Add("address2_telephone1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 2, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type a second phone number associated with the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Telephone2
	{
		get
		{
			return TryGetValue("address2_telephone2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_telephone2") is false || Remove("address2_telephone2"))
			{
				Add("address2_telephone2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type a third phone number associated with the secondary address.</summary>
	[JsonIgnore]
	public string? Address2_Telephone3
	{
		get
		{
			return TryGetValue("address2_telephone3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_telephone3") is false || Remove("address2_telephone3"))
			{
				Add("address2_telephone3", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address2_UPSZone, IntroducedVersion: 5.0.0.0.  Description: Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</summary>
	[JsonIgnore]
	public string? Address2_UPSZone
	{
		get
		{
			return TryGetValue("address2_upszone", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_upszone") is false || Remove("address2_upszone"))
			{
				Add("address2_upszone", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 2: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address2_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</summary>
	[JsonIgnore]
	public int? Address2_UTCOffset
	{
		get
		{
			return TryGetValue("address2_utcoffset", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_utcoffset") is false || Remove("address2_utcoffset"))
			{
				Add("address2_utcoffset", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Budget Amount, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: BudgetAmount, IntroducedVersion: 5.0.0.0.  Description: Information about the budget amount of the lead's company or organization.</summary>
	[JsonIgnore]
	public string? BudgetAmountFormattedValue
	{
		get
		{
			return TryGetValue("budgetamount@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Budget Amount, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: BudgetAmount, IntroducedVersion: 5.0.0.0.  Description: Information about the budget amount of the lead's company or organization.</summary>
	[JsonIgnore]
	public decimal? BudgetAmount
	{
		get
		{
			return TryGetValue("budgetamount", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("budgetamount") is false || Remove("budgetamount"))
			{
				Add("budgetamount", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Budget Amount (Base), CalculationOf: budgetamount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: BudgetAmount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Budget Amount in base currency.</summary>
	[JsonIgnore]
	public string? BudgetAmount_BaseFormattedValue
	{
		get
		{
			return TryGetValue("budgetamount_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Budget Amount (Base), CalculationOf: budgetamount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: BudgetAmount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Budget Amount in base currency.</summary>
	[JsonIgnore]
	public decimal? BudgetAmount_Base
	{
		get
		{
			return TryGetValue("budgetamount_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("budgetamount_base") is false || Remove("budgetamount_base"))
			{
				Add("budgetamount_base", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Budget, SchemaName: BudgetStatus, IntroducedVersion: 5.0.0.0.  Description: Information about the budget status of the lead's company or organization.</summary>
	[JsonIgnore]
	public string? BudgetStatusFormattedValue
	{
		get
		{
			return TryGetValue("budgetstatus@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Budget, SchemaName: BudgetStatus, IntroducedVersion: 5.0.0.0.  Description: Information about the budget status of the lead's company or organization.</summary>
	[JsonIgnore]
	public int? BudgetStatus
	{
		get
		{
			return TryGetValue("budgetstatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("budgetstatus") is false || Remove("budgetstatus"))
			{
				Add("budgetstatus", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: budgetstatus, SchemaName: BudgetStatusName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? BudgetStatusName
	{
		get
		{
			return TryGetValue("budgetstatusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Business Card, Format: TextArea, MaxLength: 1073741823, SchemaName: BusinessCard, IntroducedVersion: 9.0.0.0.  Description: Stores Image of the Business Card</summary>
	[JsonIgnore]
	public string? BusinessCard
	{
		get
		{
			return TryGetValue("businesscard", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("businesscard") is false || Remove("businesscard"))
			{
				Add("businesscard", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: BusinessCardAttributes, Format: Text, MaxLength: 4000, SchemaName: BusinessCardAttributes, IntroducedVersion: 9.0.0.0.  Description: Stores Business Card Control Properties.</summary>
	[JsonIgnore]
	public string? BusinessCardAttributes
	{
		get
		{
			return TryGetValue("businesscardattributes", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("businesscardattributes") is false || Remove("businesscardattributes"))
			{
				Add("businesscardattributes", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Source Campaign, Format: None, SchemaName: CampaignId, IntroducedVersion: 5.0.0.0.  Description: Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify  communications received by the lead.</summary>
	[JsonIgnore]
	public string? CampaignIdFormattedValue
	{
		get
		{
			return TryGetValue("_campaignid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Source Campaign, Format: None, SchemaName: CampaignId, IntroducedVersion: 5.0.0.0.  Description: Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify  communications received by the lead.</summary>
	[JsonIgnore]
	public Guid? CampaignId
	{
		get
		{
			return TryGetValue("_campaignid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Source Campaign, Format: None, SchemaName: CampaignId, IntroducedVersion: 5.0.0.0.  Description: Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify  communications received by the lead.</summary>
	[JsonIgnore]
	public Guid? CampaignId_campaign
	{
		set
		{
			if (ContainsKey("campaignid_campaign@odata.bind") is false || Remove("campaignid_campaign@odata.bind"))
			{
				if (value is not null)
				{
					Add("campaignid_campaign@odata.bind", $"({value})");
				}
				else
				{
					Add("_campaignid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: campaignid, Format: Text, MaxLength: 100, SchemaName: CampaignIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CampaignIdName
	{
		get
		{
			return TryGetValue("campaignidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("campaignidname") is false || Remove("campaignidname"))
			{
				Add("campaignidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: Recommended, DisplayName: Company Name, Format: Text, MaxLength: 100, SchemaName: CompanyName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and converted to a customer account.</summary>
	[JsonIgnore]
	public string? CompanyName
	{
		get
		{
			return TryGetValue("companyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("companyname") is false || Remove("companyname"))
			{
				Add("companyname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Confirm Interest, SchemaName: ConfirmInterest, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.</summary>
	[JsonIgnore]
	public string? ConfirmInterestFormattedValue
	{
		get
		{
			return TryGetValue("confirminterest@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Confirm Interest, SchemaName: ConfirmInterest, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.</summary>
	[JsonIgnore]
	public bool? ConfirmInterest
	{
		get
		{
			return TryGetValue("confirminterest", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("confirminterest") is false || Remove("confirminterest"))
			{
				Add("confirminterest", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: confirminterest, SchemaName: ConfirmInterestName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ConfirmInterestName
	{
		get
		{
			return TryGetValue("confirminterestname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact with which the lead is associated.</summary>
	[JsonIgnore]
	public string? ContactIdFormattedValue
	{
		get
		{
			return TryGetValue("_contactid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact with which the lead is associated.</summary>
	[JsonIgnore]
	public Guid? ContactId
	{
		get
		{
			return TryGetValue("_contactid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact with which the lead is associated.</summary>
	[JsonIgnore]
	public Guid? ContactId_contact
	{
		set
		{
			if (ContainsKey("contactid_contact@odata.bind") is false || Remove("contactid_contact@odata.bind"))
			{
				if (value is not null)
				{
					Add("contactid_contact@odata.bind", $"({value})");
				}
				else
				{
					Add("_contactid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contactid, Format: Text, MaxLength: 100, SchemaName: ContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ContactIdName
	{
		get
		{
			return TryGetValue("contactidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contactidname") is false || Remove("contactidname"))
			{
				Add("contactidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contactid, Format: Text, MaxLength: 100, SchemaName: ContactIdYomiName, YomiOf: contactidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ContactIdYomiName
	{
		get
		{
			return TryGetValue("contactidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contactidyominame") is false || Remove("contactidyominame"))
			{
				Add("contactidyominame", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.</summary>
	[JsonIgnore]
	public string? CustomerIdFormattedValue
	{
		get
		{
			return TryGetValue("_customerid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.</summary>
	[JsonIgnore]
	public Guid? CustomerId
	{
		get
		{
			return TryGetValue("_customerid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: customerid, Format: Text, MaxLength: 160, SchemaName: CustomerIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CustomerIdName
	{
		get
		{
			return TryGetValue("customeridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("customeridname") is false || Remove("customeridname"))
			{
				Add("customeridname", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: None, DisplayName: Customer Type, AttributeOf: customerid, SchemaName: CustomerIdType, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CustomerIdType
	{
		get
		{
			return TryGetValue("customeridtype", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("customeridtype") is false || Remove("customeridtype"))
			{
				Add("customeridtype", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: customerid, Format: Text, MaxLength: 450, SchemaName: CustomerIdYomiName, YomiOf: customeridname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? CustomerIdYomiName
	{
		get
		{
			return TryGetValue("customeridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("customeridyominame") is false || Remove("customeridyominame"))
			{
				Add("customeridyominame", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decision Maker?, SchemaName: DecisionMaker, IntroducedVersion: 5.0.0.0.  Description: Select whether your notes include information about who makes the purchase decisions at the lead's company.</summary>
	[JsonIgnore]
	public string? DecisionMakerFormattedValue
	{
		get
		{
			return TryGetValue("decisionmaker@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decision Maker?, SchemaName: DecisionMaker, IntroducedVersion: 5.0.0.0.  Description: Select whether your notes include information about who makes the purchase decisions at the lead's company.</summary>
	[JsonIgnore]
	public bool? DecisionMaker
	{
		get
		{
			return TryGetValue("decisionmaker", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("decisionmaker") is false || Remove("decisionmaker"))
			{
				Add("decisionmaker", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: decisionmaker, SchemaName: DecisionMakerName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DecisionMakerName
	{
		get
		{
			return TryGetValue("decisionmakername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information to describe the lead, such as an excerpt from the company's website.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Emails, SchemaName: DoNotBulkEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.</summary>
	[JsonIgnore]
	public string? DoNotBulkEMailFormattedValue
	{
		get
		{
			return TryGetValue("donotbulkemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Emails, SchemaName: DoNotBulkEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.</summary>
	[JsonIgnore]
	public bool? DoNotBulkEMail
	{
		get
		{
			return TryGetValue("donotbulkemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("donotbulkemail") is false || Remove("donotbulkemail"))
			{
				Add("donotbulkemail", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotbulkemail, SchemaName: DoNotBulkEMailName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DoNotBulkEMailName
	{
		get
		{
			return TryGetValue("donotbulkemailname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Emails, SchemaName: DoNotEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows direct email sent from Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public string? DoNotEMailFormattedValue
	{
		get
		{
			return TryGetValue("donotemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Emails, SchemaName: DoNotEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows direct email sent from Microsoft Dynamics 365.</summary>
	[JsonIgnore]
	public bool? DoNotEMail
	{
		get
		{
			return TryGetValue("donotemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("donotemail") is false || Remove("donotemail"))
			{
				Add("donotemail", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotemail, SchemaName: DoNotEMailName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DoNotEMailName
	{
		get
		{
			return TryGetValue("donotemailname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Faxes, SchemaName: DoNotFax, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows faxes.</summary>
	[JsonIgnore]
	public string? DoNotFaxFormattedValue
	{
		get
		{
			return TryGetValue("donotfax@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Faxes, SchemaName: DoNotFax, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows faxes.</summary>
	[JsonIgnore]
	public bool? DoNotFax
	{
		get
		{
			return TryGetValue("donotfax", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("donotfax") is false || Remove("donotfax"))
			{
				Add("donotfax", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotfax, SchemaName: DoNotFaxName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DoNotFaxName
	{
		get
		{
			return TryGetValue("donotfaxname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Phone Calls, SchemaName: DoNotPhone, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows phone calls.</summary>
	[JsonIgnore]
	public string? DoNotPhoneFormattedValue
	{
		get
		{
			return TryGetValue("donotphone@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Phone Calls, SchemaName: DoNotPhone, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows phone calls.</summary>
	[JsonIgnore]
	public bool? DoNotPhone
	{
		get
		{
			return TryGetValue("donotphone", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("donotphone") is false || Remove("donotphone"))
			{
				Add("donotphone", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotphone, SchemaName: DoNotPhoneName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DoNotPhoneName
	{
		get
		{
			return TryGetValue("donotphonename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Mails, SchemaName: DoNotPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows direct mail.</summary>
	[JsonIgnore]
	public string? DoNotPostalMailFormattedValue
	{
		get
		{
			return TryGetValue("donotpostalmail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Mails, SchemaName: DoNotPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead allows direct mail.</summary>
	[JsonIgnore]
	public bool? DoNotPostalMail
	{
		get
		{
			return TryGetValue("donotpostalmail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("donotpostalmail") is false || Remove("donotpostalmail"))
			{
				Add("donotpostalmail", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotpostalmail, SchemaName: DoNotPostalMailName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DoNotPostalMailName
	{
		get
		{
			return TryGetValue("donotpostalmailname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotsendmm, SchemaName: DoNotSendMarketingMaterialName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DoNotSendMarketingMaterialName
	{
		get
		{
			return TryGetValue("donotsendmarketingmaterialname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Marketing Material, SchemaName: DoNotSendMM, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.</summary>
	[JsonIgnore]
	public string? DoNotSendMMFormattedValue
	{
		get
		{
			return TryGetValue("donotsendmm@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Marketing Material, SchemaName: DoNotSendMM, IntroducedVersion: 5.0.0.0.  Description: Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.</summary>
	[JsonIgnore]
	public bool? DoNotSendMM
	{
		get
		{
			return TryGetValue("donotsendmm", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("donotsendmm") is false || Remove("donotsendmm"))
			{
				Add("donotsendmm", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress1, IntroducedVersion: 5.0.0.0.  Description: Type the primary email address for the lead.</summary>
	[JsonIgnore]
	public string? EMailAddress1
	{
		get
		{
			return TryGetValue("emailaddress1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailaddress1") is false || Remove("emailaddress1"))
			{
				Add("emailaddress1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 2, Format: Email, MaxLength: 100, SchemaName: EMailAddress2, IntroducedVersion: 5.0.0.0.  Description: Type the secondary email address for the lead.</summary>
	[JsonIgnore]
	public string? EMailAddress2
	{
		get
		{
			return TryGetValue("emailaddress2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailaddress2") is false || Remove("emailaddress2"))
			{
				Add("emailaddress2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 3, Format: Email, MaxLength: 100, SchemaName: EMailAddress3, IntroducedVersion: 5.0.0.0.  Description: Type a third email address for the lead.</summary>
	[JsonIgnore]
	public string? EMailAddress3
	{
		get
		{
			return TryGetValue("emailaddress3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailaddress3") is false || Remove("emailaddress3"))
			{
				Add("emailaddress3", value);
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Est. Value, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: EstimatedAmount, IntroducedVersion: 5.0.0.0.  Description: Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.</summary>
	[JsonIgnore]
	public string? EstimatedAmountFormattedValue
	{
		get
		{
			return TryGetValue("estimatedamount@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Est. Value, Precision: 2, MinValue: 0, MaxValue: 1000000000000, SchemaName: EstimatedAmount, IntroducedVersion: 5.0.0.0.  Description: Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.</summary>
	[JsonIgnore]
	public decimal? EstimatedAmount
	{
		get
		{
			return TryGetValue("estimatedamount", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("estimatedamount") is false || Remove("estimatedamount"))
			{
				Add("estimatedamount", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Est. Value (Base), CalculationOf: estimatedamount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: EstimatedAmount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Est. Value in base currency.</summary>
	[JsonIgnore]
	public string? EstimatedAmount_BaseFormattedValue
	{
		get
		{
			return TryGetValue("estimatedamount_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Est. Value (Base), CalculationOf: estimatedamount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: EstimatedAmount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Est. Value in base currency.</summary>
	[JsonIgnore]
	public decimal? EstimatedAmount_Base
	{
		get
		{
			return TryGetValue("estimatedamount_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("estimatedamount_base") is false || Remove("estimatedamount_base"))
			{
				Add("estimatedamount_base", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Est. Close Date, DateTimeBehavior: DateOnly, Format: DateOnly, SchemaName: EstimatedCloseDate, IntroducedVersion: 5.0.0.0.  Description: Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move the prospect to the next sales stage.</summary>
	[JsonIgnore]
	public DateTime? EstimatedCloseDate
	{
		get
		{
			return TryGetValue("estimatedclosedate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("estimatedclosedate") is false || Remove("estimatedclosedate"))
			{
				Add("estimatedclosedate", value);
			}
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Est. Value (deprecated), Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: EstimatedValue, IntroducedVersion: 5.0.0.0.  Description: Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be specified in the Est. Value field. This can be used for sales forecasting and planning.</summary>
	[JsonIgnore]
	public double? EstimatedValue
	{
		get
		{
			return TryGetValue("estimatedvalue", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("estimatedvalue") is false || Remove("estimatedvalue"))
			{
				Add("estimatedvalue", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Evaluate Fit, SchemaName: EvaluateFit, IntroducedVersion: 5.0.0.0.  Description: Select whether the fit between the lead's requirements and your offerings was evaluated.</summary>
	[JsonIgnore]
	public string? EvaluateFitFormattedValue
	{
		get
		{
			return TryGetValue("evaluatefit@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Evaluate Fit, SchemaName: EvaluateFit, IntroducedVersion: 5.0.0.0.  Description: Select whether the fit between the lead's requirements and your offerings was evaluated.</summary>
	[JsonIgnore]
	public bool? EvaluateFit
	{
		get
		{
			return TryGetValue("evaluatefit", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("evaluatefit") is false || Remove("evaluatefit"))
			{
				Add("evaluatefit", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: evaluatefit, SchemaName: EvaluateFitName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? EvaluateFitName
	{
		get
		{
			return TryGetValue("evaluatefitname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Fax, Format: Text, MaxLength: 50, SchemaName: Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number for the primary contact for the lead.</summary>
	[JsonIgnore]
	public string? Fax
	{
		get
		{
			return TryGetValue("fax", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("fax") is false || Remove("fax"))
			{
				Add("fax", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: Recommended, DisplayName: First Name, Format: Text, MaxLength: 50, SchemaName: FirstName, IntroducedVersion: 5.0.0.0.  Description: Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	[JsonIgnore]
	public string? FirstName
	{
		get
		{
			return TryGetValue("firstname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("firstname") is false || Remove("firstname"))
			{
				Add("firstname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow Email Activity, SchemaName: FollowEmail, IntroducedVersion: 8.2.0.0.  Description: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the lead.</summary>
	[JsonIgnore]
	public string? FollowEmailFormattedValue
	{
		get
		{
			return TryGetValue("followemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow Email Activity, SchemaName: FollowEmail, IntroducedVersion: 8.2.0.0.  Description: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the lead.</summary>
	[JsonIgnore]
	public bool? FollowEmail
	{
		get
		{
			return TryGetValue("followemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("followemail") is false || Remove("followemail"))
			{
				Add("followemail", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: followemail, SchemaName: FollowEmailName, IntroducedVersion: 8.2.0.0. </summary>
	[JsonIgnore]
	public object? FollowEmailName
	{
		get
		{
			return TryGetValue("followemailname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Name, Format: Text, MaxLength: 160, SchemaName: FullName, IntroducedVersion: 5.0.0.0.  Description: Combines and shows the lead's first and last names so the full name can be displayed in views and reports.</summary>
	[JsonIgnore]
	public string? FullName
	{
		get
		{
			return TryGetValue("fullname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("fullname") is false || Remove("fullname"))
			{
				Add("fullname", value);
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Industry, SchemaName: IndustryCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.</summary>
	[JsonIgnore]
	public string? IndustryCodeFormattedValue
	{
		get
		{
			return TryGetValue("industrycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Industry, SchemaName: IndustryCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.</summary>
	[JsonIgnore]
	public int? IndustryCode
	{
		get
		{
			return TryGetValue("industrycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("industrycode") is false || Remove("industrycode"))
			{
				Add("industrycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: industrycode, SchemaName: IndustryCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IndustryCodeName
	{
		get
		{
			return TryGetValue("industrycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Initial Communication, SchemaName: InitialCommunication, IntroducedVersion: 5.0.0.0.  Description: Choose whether someone from the sales team contacted this lead earlier.</summary>
	[JsonIgnore]
	public string? InitialCommunicationFormattedValue
	{
		get
		{
			return TryGetValue("initialcommunication@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Initial Communication, SchemaName: InitialCommunication, IntroducedVersion: 5.0.0.0.  Description: Choose whether someone from the sales team contacted this lead earlier.</summary>
	[JsonIgnore]
	public int? InitialCommunication
	{
		get
		{
			return TryGetValue("initialcommunication", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("initialcommunication") is false || Remove("initialcommunication"))
			{
				Add("initialcommunication", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: initialcommunication, SchemaName: InitialCommunicationName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? InitialCommunicationName
	{
		get
		{
			return TryGetValue("initialcommunicationname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Auto-created, SchemaName: IsAutoCreate, IntroducedVersion: 5.0.0.0.  Description: Information about whether the contact was auto-created when promoting an email or an appointment.</summary>
	[JsonIgnore]
	public string? IsAutoCreateFormattedValue
	{
		get
		{
			return TryGetValue("isautocreate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Auto-created, SchemaName: IsAutoCreate, IntroducedVersion: 5.0.0.0.  Description: Information about whether the contact was auto-created when promoting an email or an appointment.</summary>
	[JsonIgnore]
	public bool? IsAutoCreate
	{
		get
		{
			return TryGetValue("isautocreate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isautocreate") is false || Remove("isautocreate"))
			{
				Add("isautocreate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isautocreate, SchemaName: isautocreateName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? isautocreateName
	{
		get
		{
			return TryGetValue("isautocreatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Private, SchemaName: IsPrivate, IntroducedVersion: 5.0.0.0.  Description: Indicates whether the lead is private or visible to the entire organization.</summary>
	[JsonIgnore]
	public string? IsPrivateFormattedValue
	{
		get
		{
			return TryGetValue("isprivate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Private, SchemaName: IsPrivate, IntroducedVersion: 5.0.0.0.  Description: Indicates whether the lead is private or visible to the entire organization.</summary>
	[JsonIgnore]
	public bool? IsPrivate
	{
		get
		{
			return TryGetValue("isprivate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isprivate") is false || Remove("isprivate"))
			{
				Add("isprivate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isprivate, SchemaName: IsPrivateName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsPrivateName
	{
		get
		{
			return TryGetValue("isprivatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Job Title, Format: Text, MaxLength: 100, SchemaName: JobTitle, IntroducedVersion: 5.0.0.0.  Description: Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	[JsonIgnore]
	public string? JobTitle
	{
		get
		{
			return TryGetValue("jobtitle", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("jobtitle") is false || Remove("jobtitle"))
			{
				Add("jobtitle", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Last Name, Format: Text, MaxLength: 50, SchemaName: LastName, IntroducedVersion: 5.0.0.0.  Description: Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	[JsonIgnore]
	public string? LastName
	{
		get
		{
			return TryGetValue("lastname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("lastname") is false || Remove("lastname"))
			{
				Add("lastname", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last On Hold Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastOnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Contains the date and time stamp of the last on hold time.</summary>
	[JsonIgnore]
	public DateTime? LastOnHoldTime
	{
		get
		{
			return TryGetValue("lastonholdtime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("lastonholdtime") is false || Remove("lastonholdtime"))
			{
				Add("lastonholdtime", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Campaign Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: LastUsedInCampaign, IntroducedVersion: 5.0.0.0.  Description: Shows the date when the lead was last included in a marketing campaign or quick campaign.</summary>
	[JsonIgnore]
	public DateTime? LastUsedInCampaign
	{
		get
		{
			return TryGetValue("lastusedincampaign", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("lastusedincampaign") is false || Remove("lastusedincampaign"))
			{
				Add("lastusedincampaign", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Lead, SchemaName: LeadId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the lead.</summary>
	[JsonIgnore]
	public Guid? LeadId
	{
		get
		{
			return TryGetValue("leadid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("leadid") is false || Remove("leadid"))
			{
				Add("leadid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Rating, SchemaName: LeadQualityCode, IntroducedVersion: 5.0.0.0.  Description: Select a rating value to indicate the lead's potential to become a customer.</summary>
	[JsonIgnore]
	public string? LeadQualityCodeFormattedValue
	{
		get
		{
			return TryGetValue("leadqualitycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Rating, SchemaName: LeadQualityCode, IntroducedVersion: 5.0.0.0.  Description: Select a rating value to indicate the lead's potential to become a customer.</summary>
	[JsonIgnore]
	public int? LeadQualityCode
	{
		get
		{
			return TryGetValue("leadqualitycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("leadqualitycode") is false || Remove("leadqualitycode"))
			{
				Add("leadqualitycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: leadqualitycode, SchemaName: LeadQualityCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? LeadQualityCodeName
	{
		get
		{
			return TryGetValue("leadqualitycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Lead Source, SchemaName: LeadSourceCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary marketing source that prompted the lead to contact you.</summary>
	[JsonIgnore]
	public string? LeadSourceCodeFormattedValue
	{
		get
		{
			return TryGetValue("leadsourcecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Lead Source, SchemaName: LeadSourceCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary marketing source that prompted the lead to contact you.</summary>
	[JsonIgnore]
	public int? LeadSourceCode
	{
		get
		{
			return TryGetValue("leadsourcecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("leadsourcecode") is false || Remove("leadsourcecode"))
			{
				Add("leadsourcecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: leadsourcecode, SchemaName: LeadSourceCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? LeadSourceCodeName
	{
		get
		{
			return TryGetValue("leadsourcecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master lead for merge.</summary>
	[JsonIgnore]
	public string? MasterIdFormattedValue
	{
		get
		{
			return TryGetValue("_masterid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master lead for merge.</summary>
	[JsonIgnore]
	public Guid? MasterId
	{
		get
		{
			return TryGetValue("_masterid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master lead for merge.</summary>
	[JsonIgnore]
	public Guid? MasterId_lead
	{
		set
		{
			if (ContainsKey("masterid_lead@odata.bind") is false || Remove("masterid_lead@odata.bind"))
			{
				if (value is not null)
				{
					Add("masterid_lead@odata.bind", $"({value})");
				}
				else
				{
					Add("_masterid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterLeadIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? MasterLeadIdName
	{
		get
		{
			return TryGetValue("masterleadidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("masterleadidname") is false || Remove("masterleadidname"))
			{
				Add("masterleadidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterLeadIdYomiName, YomiOf: masterleadidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? MasterLeadIdYomiName
	{
		get
		{
			return TryGetValue("masterleadidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("masterleadidyominame") is false || Remove("masterleadidyominame"))
			{
				Add("masterleadidyominame", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Merged, SchemaName: Merged, IntroducedVersion: 5.0.0.0.  Description: Tells whether the lead has been merged with another lead.</summary>
	[JsonIgnore]
	public string? MergedFormattedValue
	{
		get
		{
			return TryGetValue("merged@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Merged, SchemaName: Merged, IntroducedVersion: 5.0.0.0.  Description: Tells whether the lead has been merged with another lead.</summary>
	[JsonIgnore]
	public bool? Merged
	{
		get
		{
			return TryGetValue("merged", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("merged") is false || Remove("merged"))
			{
				Add("merged", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: merged, SchemaName: MergedName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? MergedName
	{
		get
		{
			return TryGetValue("mergedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Middle Name, Format: Text, MaxLength: 50, SchemaName: MiddleName, IntroducedVersion: 5.0.0.0.  Description: Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed correctly.</summary>
	[JsonIgnore]
	public string? MiddleName
	{
		get
		{
			return TryGetValue("middlename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("middlename") is false || Remove("middlename"))
			{
				Add("middlename", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Mobile Phone, Format: Text, MaxLength: 20, SchemaName: MobilePhone, IntroducedVersion: 5.0.0.0.  Description: Type the mobile phone number for the primary contact for the lead.</summary>
	[JsonIgnore]
	public string? MobilePhone
	{
		get
		{
			return TryGetValue("mobilephone", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("mobilephone") is false || Remove("mobilephone"))
			{
				Add("mobilephone", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who last updated the record on behalf of another user.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether lead is opted out or not</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether lead is opted out or not</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: (Deprecated) Lead Grade, SchemaName: msdyn_LeadGrade, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_LeadGradeFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_leadgrade@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: (Deprecated) Lead Grade, SchemaName: msdyn_LeadGrade, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? msdyn_LeadGrade
	{
		get
		{
			return TryGetValue("msdyn_leadgrade", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_leadgrade") is false || Remove("msdyn_leadgrade"))
			{
				Add("msdyn_leadgrade", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_leadgrade, SchemaName: msdyn_leadgradeName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_leadgradeName
	{
		get
		{
			return TryGetValue("msdyn_leadgradename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_leadkpiid, IntroducedVersion: 1.0.  Description: LeadKPIId</summary>
	[JsonIgnore]
	public string? msdyn_leadkpiidFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_leadkpiid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_leadkpiid, IntroducedVersion: 1.0.  Description: LeadKPIId</summary>
	[JsonIgnore]
	public Guid? msdyn_leadkpiid
	{
		get
		{
			return TryGetValue("_msdyn_leadkpiid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_leadkpiid, IntroducedVersion: 1.0.  Description: LeadKPIId</summary>
	[JsonIgnore]
	public Guid? msdyn_leadkpiid_msdyn_leadkpiitem
	{
		set
		{
			if (ContainsKey("msdyn_leadkpiid_msdyn_leadkpiitem@odata.bind") is false || Remove("msdyn_leadkpiid_msdyn_leadkpiitem@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_leadkpiid_msdyn_leadkpiitem@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_leadkpiid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_leadkpiid, Format: Text, MaxLength: 100, SchemaName: msdyn_leadkpiidName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_leadkpiidName
	{
		get
		{
			return TryGetValue("msdyn_leadkpiidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_leadkpiidname") is false || Remove("msdyn_leadkpiidname"))
			{
				Add("msdyn_leadkpiidname", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: (Deprecated) Lead Score, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: msdyn_LeadScore, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? msdyn_LeadScore
	{
		get
		{
			return TryGetValue("msdyn_leadscore", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_leadscore") is false || Remove("msdyn_leadscore"))
			{
				Add("msdyn_leadscore", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: (Deprecated) Lead Score Trend, SchemaName: msdyn_LeadScoreTrend, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_LeadScoreTrendFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_leadscoretrend@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: (Deprecated) Lead Score Trend, SchemaName: msdyn_LeadScoreTrend, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? msdyn_LeadScoreTrend
	{
		get
		{
			return TryGetValue("msdyn_leadscoretrend", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_leadscoretrend") is false || Remove("msdyn_leadscoretrend"))
			{
				Add("msdyn_leadscoretrend", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_leadscoretrend, SchemaName: msdyn_leadscoretrendName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_leadscoretrendName
	{
		get
		{
			return TryGetValue("msdyn_leadscoretrendname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Predictive Score, Format: None, SchemaName: msdyn_PredictiveScoreId, IntroducedVersion: 1.0.0.0.  Description: Predictive score</summary>
	[JsonIgnore]
	public string? msdyn_PredictiveScoreIdFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_predictivescoreid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Predictive Score, Format: None, SchemaName: msdyn_PredictiveScoreId, IntroducedVersion: 1.0.0.0.  Description: Predictive score</summary>
	[JsonIgnore]
	public Guid? msdyn_PredictiveScoreId
	{
		get
		{
			return TryGetValue("_msdyn_predictivescoreid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Predictive Score, Format: None, SchemaName: msdyn_PredictiveScoreId, IntroducedVersion: 1.0.0.0.  Description: Predictive score</summary>
	[JsonIgnore]
	public Guid? msdyn_PredictiveScoreId_msdyn_predictivescore
	{
		set
		{
			if (ContainsKey("msdyn_predictivescoreid_msdyn_predictivescore@odata.bind") is false || Remove("msdyn_predictivescoreid_msdyn_predictivescore@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_predictivescoreid_msdyn_predictivescore@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_predictivescoreid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_predictivescoreid, Format: Text, MaxLength: 128, SchemaName: msdyn_PredictiveScoreIdName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_PredictiveScoreIdName
	{
		get
		{
			return TryGetValue("msdyn_predictivescoreidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_predictivescoreidname") is false || Remove("msdyn_predictivescoreidname"))
			{
				Add("msdyn_predictivescoreidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Assignment Rule Result, SchemaName: msdyn_salesassignmentresult, IntroducedVersion: 1.0.0.  Description: Result of the assignment rule process</summary>
	[JsonIgnore]
	public string? msdyn_salesassignmentresultFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_salesassignmentresult@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Assignment Rule Result, SchemaName: msdyn_salesassignmentresult, IntroducedVersion: 1.0.0.  Description: Result of the assignment rule process</summary>
	[JsonIgnore]
	public int? msdyn_salesassignmentresult
	{
		get
		{
			return TryGetValue("msdyn_salesassignmentresult", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_salesassignmentresult") is false || Remove("msdyn_salesassignmentresult"))
			{
				Add("msdyn_salesassignmentresult", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_salesassignmentresult, SchemaName: msdyn_salesassignmentresultName, IntroducedVersion: 1.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_salesassignmentresultName
	{
		get
		{
			return TryGetValue("msdyn_salesassignmentresultname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: (Deprecated) Score History, Format: Text, MaxLength: 2000, SchemaName: msdyn_ScoreHistory, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_ScoreHistory
	{
		get
		{
			return TryGetValue("msdyn_scorehistory", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_scorehistory") is false || Remove("msdyn_scorehistory"))
			{
				Add("msdyn_scorehistory", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: (Deprecated) Score Reasons, Format: Text, MaxLength: 2000, SchemaName: msdyn_ScoreReasons, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_ScoreReasons
	{
		get
		{
			return TryGetValue("msdyn_scorereasons", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_scorereasons") is false || Remove("msdyn_scorereasons"))
			{
				Add("msdyn_scorereasons", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Segment Id, Format: None, SchemaName: msdyn_segmentid, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for Segment associated with Lead.</summary>
	[JsonIgnore]
	public string? msdyn_segmentidFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_segmentid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Segment Id, Format: None, SchemaName: msdyn_segmentid, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for Segment associated with Lead.</summary>
	[JsonIgnore]
	public Guid? msdyn_segmentid
	{
		get
		{
			return TryGetValue("_msdyn_segmentid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Segment Id, Format: None, SchemaName: msdyn_segmentid, IntroducedVersion: 9.1.0.0.  Description: Unique identifier for Segment associated with Lead.</summary>
	[JsonIgnore]
	public Guid? msdyn_segmentid_msdyn_segment
	{
		set
		{
			if (ContainsKey("msdyn_segmentid_msdyn_segment@odata.bind") is false || Remove("msdyn_segmentid_msdyn_segment@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_segmentid_msdyn_segment@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_segmentid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_segmentid, Format: Text, MaxLength: 100, SchemaName: msdyn_segmentidName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_segmentidName
	{
		get
		{
			return TryGetValue("msdyn_segmentidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_segmentidname") is false || Remove("msdyn_segmentidname"))
			{
				Add("msdyn_segmentidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Need, SchemaName: Need, IntroducedVersion: 5.0.0.0.  Description: Choose how high the level of need is for the lead's company.</summary>
	[JsonIgnore]
	public string? NeedFormattedValue
	{
		get
		{
			return TryGetValue("need@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Need, SchemaName: Need, IntroducedVersion: 5.0.0.0.  Description: Choose how high the level of need is for the lead's company.</summary>
	[JsonIgnore]
	public int? Need
	{
		get
		{
			return TryGetValue("need", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("need") is false || Remove("need"))
			{
				Add("need", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: need, SchemaName: NeedName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? NeedName
	{
		get
		{
			return TryGetValue("needname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: No. of Employees, Format: None, MinValue: 0, MaxValue: 1000000, SchemaName: NumberOfEmployees, IntroducedVersion: 5.0.0.0.  Description: Type the number of employees that work at the company associated with the lead, for use in marketing segmentation and demographic analysis.</summary>
	[JsonIgnore]
	public int? NumberOfEmployees
	{
		get
		{
			return TryGetValue("numberofemployees", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("numberofemployees") is false || Remove("numberofemployees"))
			{
				Add("numberofemployees", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: On Hold Time (Minutes), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Shows how long, in minutes, that the record was on hold.</summary>
	[JsonIgnore]
	public int? OnHoldTime
	{
		get
		{
			return TryGetValue("onholdtime", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("onholdtime") is false || Remove("onholdtime"))
			{
				Add("onholdtime", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Case, Format: None, SchemaName: OriginatingCaseId, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public string? OriginatingCaseIdFormattedValue
	{
		get
		{
			return TryGetValue("_originatingcaseid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Case, Format: None, SchemaName: OriginatingCaseId, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public Guid? OriginatingCaseId
	{
		get
		{
			return TryGetValue("_originatingcaseid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Case, Format: None, SchemaName: OriginatingCaseId, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public Guid? OriginatingCaseId_incident
	{
		set
		{
			if (ContainsKey("originatingcaseid_incident@odata.bind") is false || Remove("originatingcaseid_incident@odata.bind"))
			{
				if (value is not null)
				{
					Add("originatingcaseid_incident@odata.bind", $"({value})");
				}
				else
				{
					Add("_originatingcaseid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: originatingcaseid, Format: Text, MaxLength: 100, SchemaName: OriginatingCaseIdName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public string? OriginatingCaseIdName
	{
		get
		{
			return TryGetValue("originatingcaseidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("originatingcaseidname") is false || Remove("originatingcaseidname"))
			{
				Add("originatingcaseidname", value);
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 5.0.0.0.  Description: Name of the owner</summary>
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

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 5.0.0.0.  Description: Owner Id Type</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 5.0.0.0.  Description: Yomi name of the owner</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 100, SchemaName: OwningBusinessUnitName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pager, Format: Text, MaxLength: 20, SchemaName: Pager, IntroducedVersion: 5.0.0.0.  Description: Type the pager number for the primary contact for the lead.</summary>
	[JsonIgnore]
	public string? Pager
	{
		get
		{
			return TryGetValue("pager", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("pager") is false || Remove("pager"))
			{
				Add("pager", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Account for lead, Format: None, SchemaName: ParentAccountId, IntroducedVersion: 5.0.0.0.  Description: Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.</summary>
	[JsonIgnore]
	public string? ParentAccountIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentaccountid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Account for lead, Format: None, SchemaName: ParentAccountId, IntroducedVersion: 5.0.0.0.  Description: Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.</summary>
	[JsonIgnore]
	public Guid? ParentAccountId
	{
		get
		{
			return TryGetValue("_parentaccountid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Account for lead, Format: None, SchemaName: ParentAccountId, IntroducedVersion: 5.0.0.0.  Description: Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.</summary>
	[JsonIgnore]
	public Guid? ParentAccountId_account
	{
		set
		{
			if (ContainsKey("parentaccountid_account@odata.bind") is false || Remove("parentaccountid_account@odata.bind"))
			{
				if (value is not null)
				{
					Add("parentaccountid_account@odata.bind", $"({value})");
				}
				else
				{
					Add("_parentaccountid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentaccountid, Format: Text, MaxLength: 100, SchemaName: ParentAccountIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentAccountIdName
	{
		get
		{
			return TryGetValue("parentaccountidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentaccountidname") is false || Remove("parentaccountidname"))
			{
				Add("parentaccountidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentaccountid, Format: Text, MaxLength: 100, SchemaName: ParentAccountIdYomiName, YomiOf: parentaccountidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentAccountIdYomiName
	{
		get
		{
			return TryGetValue("parentaccountidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentaccountidyominame") is false || Remove("parentaccountidyominame"))
			{
				Add("parentaccountidyominame", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact for lead, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.</summary>
	[JsonIgnore]
	public string? ParentContactIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentcontactid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact for lead, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.</summary>
	[JsonIgnore]
	public Guid? ParentContactId
	{
		get
		{
			return TryGetValue("_parentcontactid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact for lead, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.</summary>
	[JsonIgnore]
	public Guid? ParentContactId_contact
	{
		set
		{
			if (ContainsKey("parentcontactid_contact@odata.bind") is false || Remove("parentcontactid_contact@odata.bind"))
			{
				if (value is not null)
				{
					Add("parentcontactid_contact@odata.bind", $"({value})");
				}
				else
				{
					Add("_parentcontactid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentcontactid, Format: Text, MaxLength: 100, SchemaName: ParentContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentContactIdName
	{
		get
		{
			return TryGetValue("parentcontactidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentcontactidname") is false || Remove("parentcontactidname"))
			{
				Add("parentcontactidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentcontactid, Format: Text, MaxLength: 100, SchemaName: ParentContactIdYomiName, YomiOf: parentcontactidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentContactIdYomiName
	{
		get
		{
			return TryGetValue("parentcontactidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentcontactidyominame") is false || Remove("parentcontactidyominame"))
			{
				Add("parentcontactidyominame", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Participates in Workflow, SchemaName: ParticipatesInWorkflow, IntroducedVersion: 5.0.0.0.  Description: Shows whether the lead participates in workflow rules.</summary>
	[JsonIgnore]
	public string? ParticipatesInWorkflowFormattedValue
	{
		get
		{
			return TryGetValue("participatesinworkflow@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Participates in Workflow, SchemaName: ParticipatesInWorkflow, IntroducedVersion: 5.0.0.0.  Description: Shows whether the lead participates in workflow rules.</summary>
	[JsonIgnore]
	public bool? ParticipatesInWorkflow
	{
		get
		{
			return TryGetValue("participatesinworkflow", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("participatesinworkflow") is false || Remove("participatesinworkflow"))
			{
				Add("participatesinworkflow", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: participatesinworkflow, SchemaName: ParticipatesInWorkflowName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ParticipatesInWorkflowName
	{
		get
		{
			return TryGetValue("participatesinworkflowname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Method of Contact, SchemaName: PreferredContactMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred method of contact.</summary>
	[JsonIgnore]
	public string? PreferredContactMethodCodeFormattedValue
	{
		get
		{
			return TryGetValue("preferredcontactmethodcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Method of Contact, SchemaName: PreferredContactMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred method of contact.</summary>
	[JsonIgnore]
	public int? PreferredContactMethodCode
	{
		get
		{
			return TryGetValue("preferredcontactmethodcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredcontactmethodcode") is false || Remove("preferredcontactmethodcode"))
			{
				Add("preferredcontactmethodcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredcontactmethodcode, SchemaName: PreferredContactMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PreferredContactMethodCodeName
	{
		get
		{
			return TryGetValue("preferredcontactmethodcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, SchemaName: PriorityCode, IntroducedVersion: 5.0.0.0.  Description: Select the priority so that preferred customers or critical issues are handled quickly.</summary>
	[JsonIgnore]
	public string? PriorityCodeFormattedValue
	{
		get
		{
			return TryGetValue("prioritycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, SchemaName: PriorityCode, IntroducedVersion: 5.0.0.0.  Description: Select the priority so that preferred customers or critical issues are handled quickly.</summary>
	[JsonIgnore]
	public int? PriorityCode
	{
		get
		{
			return TryGetValue("prioritycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("prioritycode") is false || Remove("prioritycode"))
			{
				Add("prioritycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: prioritycode, SchemaName: PriorityCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PriorityCodeName
	{
		get
		{
			return TryGetValue("prioritycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Purchase Process, SchemaName: PurchaseProcess, IntroducedVersion: 5.0.0.0.  Description: Choose whether an individual or a committee will be involved in the  purchase process for the lead.</summary>
	[JsonIgnore]
	public string? PurchaseProcessFormattedValue
	{
		get
		{
			return TryGetValue("purchaseprocess@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Purchase Process, SchemaName: PurchaseProcess, IntroducedVersion: 5.0.0.0.  Description: Choose whether an individual or a committee will be involved in the  purchase process for the lead.</summary>
	[JsonIgnore]
	public int? PurchaseProcess
	{
		get
		{
			return TryGetValue("purchaseprocess", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("purchaseprocess") is false || Remove("purchaseprocess"))
			{
				Add("purchaseprocess", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: purchaseprocess, SchemaName: PurchaseProcessName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PurchaseProcessName
	{
		get
		{
			return TryGetValue("purchaseprocessname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Purchase Timeframe, SchemaName: PurchaseTimeFrame, IntroducedVersion: 5.0.0.0.  Description: Choose how long the lead will likely take to make the purchase, so the sales team will be aware.</summary>
	[JsonIgnore]
	public string? PurchaseTimeFrameFormattedValue
	{
		get
		{
			return TryGetValue("purchasetimeframe@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Purchase Timeframe, SchemaName: PurchaseTimeFrame, IntroducedVersion: 5.0.0.0.  Description: Choose how long the lead will likely take to make the purchase, so the sales team will be aware.</summary>
	[JsonIgnore]
	public int? PurchaseTimeFrame
	{
		get
		{
			return TryGetValue("purchasetimeframe", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("purchasetimeframe") is false || Remove("purchasetimeframe"))
			{
				Add("purchasetimeframe", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: purchasetimeframe, SchemaName: PurchaseTimeFrameName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PurchaseTimeFrameName
	{
		get
		{
			return TryGetValue("purchasetimeframename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Qualification Comments, Format: TextArea, MaxLength: 2000, SchemaName: QualificationComments, IntroducedVersion: 5.0.0.0.  Description: Type comments about the qualification or scoring of the lead.</summary>
	[JsonIgnore]
	public string? QualificationComments
	{
		get
		{
			return TryGetValue("qualificationcomments", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("qualificationcomments") is false || Remove("qualificationcomments"))
			{
				Add("qualificationcomments", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Qualifying Opportunity, Format: None, SchemaName: QualifyingOpportunityId, IntroducedVersion: 5.0.0.0.  Description: Choose the opportunity that the lead was qualified on and then converted to.</summary>
	[JsonIgnore]
	public string? QualifyingOpportunityIdFormattedValue
	{
		get
		{
			return TryGetValue("_qualifyingopportunityid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Qualifying Opportunity, Format: None, SchemaName: QualifyingOpportunityId, IntroducedVersion: 5.0.0.0.  Description: Choose the opportunity that the lead was qualified on and then converted to.</summary>
	[JsonIgnore]
	public Guid? QualifyingOpportunityId
	{
		get
		{
			return TryGetValue("_qualifyingopportunityid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Qualifying Opportunity, Format: None, SchemaName: QualifyingOpportunityId, IntroducedVersion: 5.0.0.0.  Description: Choose the opportunity that the lead was qualified on and then converted to.</summary>
	[JsonIgnore]
	public Guid? QualifyingOpportunityId_opportunity
	{
		set
		{
			if (ContainsKey("qualifyingopportunityid_opportunity@odata.bind") is false || Remove("qualifyingopportunityid_opportunity@odata.bind"))
			{
				if (value is not null)
				{
					Add("qualifyingopportunityid_opportunity@odata.bind", $"({value})");
				}
				else
				{
					Add("_qualifyingopportunityid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: qualifyingopportunityid, Format: Text, MaxLength: 100, SchemaName: QualifyingOpportunityIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? QualifyingOpportunityIdName
	{
		get
		{
			return TryGetValue("qualifyingopportunityidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("qualifyingopportunityidname") is false || Remove("qualifyingopportunityidname"))
			{
				Add("qualifyingopportunityidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Related Campaign Response, Format: None, SchemaName: RelatedObjectId, IntroducedVersion: 6.0.0.0.  Description: Related Campaign Response.</summary>
	[JsonIgnore]
	public string? RelatedObjectIdFormattedValue
	{
		get
		{
			return TryGetValue("_relatedobjectid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Related Campaign Response, Format: None, SchemaName: RelatedObjectId, IntroducedVersion: 6.0.0.0.  Description: Related Campaign Response.</summary>
	[JsonIgnore]
	public Guid? RelatedObjectId
	{
		get
		{
			return TryGetValue("_relatedobjectid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Related Campaign Response, Format: None, SchemaName: RelatedObjectId, IntroducedVersion: 6.0.0.0.  Description: Related Campaign Response.</summary>
	[JsonIgnore]
	public Guid? RelatedObjectId_campaignresponse
	{
		set
		{
			if (ContainsKey("relatedobjectid_campaignresponse@odata.bind") is false || Remove("relatedobjectid_campaignresponse@odata.bind"))
			{
				if (value is not null)
				{
					Add("relatedobjectid_campaignresponse@odata.bind", $"({value})");
				}
				else
				{
					Add("_relatedobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: relatedobjectid, Format: Text, MaxLength: 200, SchemaName: RelatedObjectIdName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public string? RelatedObjectIdName
	{
		get
		{
			return TryGetValue("relatedobjectidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("relatedobjectidname") is false || Remove("relatedobjectidname"))
			{
				Add("relatedobjectidname", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Revenue, IntroducedVersion: 5.0.0.0.  Description: Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.</summary>
	[JsonIgnore]
	public string? RevenueFormattedValue
	{
		get
		{
			return TryGetValue("revenue@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Revenue, IntroducedVersion: 5.0.0.0.  Description: Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.</summary>
	[JsonIgnore]
	public decimal? Revenue
	{
		get
		{
			return TryGetValue("revenue", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("revenue") is false || Remove("revenue"))
			{
				Add("revenue", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue (Base), CalculationOf: revenue, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Revenue_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Annual Revenue in base currency.</summary>
	[JsonIgnore]
	public string? Revenue_BaseFormattedValue
	{
		get
		{
			return TryGetValue("revenue_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue (Base), CalculationOf: revenue, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Revenue_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Annual Revenue in base currency.</summary>
	[JsonIgnore]
	public decimal? Revenue_Base
	{
		get
		{
			return TryGetValue("revenue_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("revenue_base") is false || Remove("revenue_base"))
			{
				Add("revenue_base", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Sales Stage, SchemaName: SalesStage, IntroducedVersion: 5.0.0.0.  Description: Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.</summary>
	[JsonIgnore]
	public string? SalesStageFormattedValue
	{
		get
		{
			return TryGetValue("salesstage@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Sales Stage, SchemaName: SalesStage, IntroducedVersion: 5.0.0.0.  Description: Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.</summary>
	[JsonIgnore]
	public int? SalesStage
	{
		get
		{
			return TryGetValue("salesstage", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("salesstage") is false || Remove("salesstage"))
			{
				Add("salesstage", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Sales Stage Code, SchemaName: SalesStageCode, IntroducedVersion: 5.0.0.0.  Description: Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.</summary>
	[JsonIgnore]
	public string? SalesStageCodeFormattedValue
	{
		get
		{
			return TryGetValue("salesstagecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Sales Stage Code, SchemaName: SalesStageCode, IntroducedVersion: 5.0.0.0.  Description: Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.</summary>
	[JsonIgnore]
	public int? SalesStageCode
	{
		get
		{
			return TryGetValue("salesstagecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("salesstagecode") is false || Remove("salesstagecode"))
			{
				Add("salesstagecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: salesstagecode, SchemaName: SalesStageCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? SalesStageCodeName
	{
		get
		{
			return TryGetValue("salesstagecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: salesstage, SchemaName: SalesStageName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? SalesStageName
	{
		get
		{
			return TryGetValue("salesstagename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Salutation, Format: Text, MaxLength: 100, SchemaName: Salutation, IntroducedVersion: 5.0.0.0.  Description: Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email messages, and marketing campaigns.</summary>
	[JsonIgnore]
	public string? Salutation
	{
		get
		{
			return TryGetValue("salutation", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("salutation") is false || Remove("salutation"))
			{
				Add("salutation", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Schedule Follow Up (Prospect), DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ScheduleFollowUp_Prospect, IntroducedVersion: 5.0.0.0.  Description: Enter the date and time of the prospecting follow-up meeting with the lead.</summary>
	[JsonIgnore]
	public DateTime? ScheduleFollowUp_Prospect
	{
		get
		{
			return TryGetValue("schedulefollowup_prospect", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("schedulefollowup_prospect") is false || Remove("schedulefollowup_prospect"))
			{
				Add("schedulefollowup_prospect", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Schedule Follow Up (Qualify), DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ScheduleFollowUp_Qualify, IntroducedVersion: 5.0.0.0.  Description: Enter the date and time of the qualifying follow-up meeting with the lead.</summary>
	[JsonIgnore]
	public DateTime? ScheduleFollowUp_Qualify
	{
		get
		{
			return TryGetValue("schedulefollowup_qualify", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("schedulefollowup_qualify") is false || Remove("schedulefollowup_qualify"))
			{
				Add("schedulefollowup_qualify", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: SIC Code, Format: Text, MaxLength: 20, SchemaName: SIC, IntroducedVersion: 5.0.0.0.  Description: Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for use in marketing segmentation and demographic analysis.</summary>
	[JsonIgnore]
	public string? SIC
	{
		get
		{
			return TryGetValue("sic", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("sic") is false || Remove("sic"))
			{
				Add("sic", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Lead record.</summary>
	[JsonIgnore]
	public string? SLAIdFormattedValue
	{
		get
		{
			return TryGetValue("_slaid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Lead record.</summary>
	[JsonIgnore]
	public Guid? SLAId
	{
		get
		{
			return TryGetValue("_slaid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Lead record.</summary>
	[JsonIgnore]
	public Guid? SLAId_sla
	{
		set
		{
			if (ContainsKey("slaid_sla@odata.bind") is false || Remove("slaid_sla@odata.bind"))
			{
				if (value is not null)
				{
					Add("slaid_sla@odata.bind", $"({value})");
				}
				else
				{
					Add("_slaid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	[JsonIgnore]
	public string? SLAInvokedIdFormattedValue
	{
		get
		{
			return TryGetValue("_slainvokedid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	[JsonIgnore]
	public Guid? SLAInvokedId
	{
		get
		{
			return TryGetValue("_slainvokedid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
	[JsonIgnore]
	public Guid? SLAInvokedId_sla
	{
		set
		{
			if (ContainsKey("slainvokedid_sla@odata.bind") is false || Remove("slainvokedid_sla@odata.bind"))
			{
				if (value is not null)
				{
					Add("slainvokedid_sla@odata.bind", $"({value})");
				}
				else
				{
					Add("_slainvokedid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slainvokedid, Format: Text, MaxLength: 100, SchemaName: SLAInvokedIdName, IntroducedVersion: 8.1.0.0. </summary>
	[JsonIgnore]
	public string? SLAInvokedIdName
	{
		get
		{
			return TryGetValue("slainvokedidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("slainvokedidname") is false || Remove("slainvokedidname"))
			{
				Add("slainvokedidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: SLAName, IntroducedVersion: 8.1.0.0. </summary>
	[JsonIgnore]
	public string? SLAName
	{
		get
		{
			return TryGetValue("slaname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("slaname") is false || Remove("slaname"))
			{
				Add("slaname", value);
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the lead's status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the lead's status.</summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Topic, Format: Text, MaxLength: 300, SchemaName: Subject, IntroducedVersion: 5.0.0.0.  Description: Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify the lead.</summary>
	[JsonIgnore]
	public string? Subject
	{
		get
		{
			return TryGetValue("subject", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("subject") is false || Remove("subject"))
			{
				Add("subject", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: TeamsFollowed, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: TeamsFollowed, IntroducedVersion: 9.0.0.0.  Description: Number of users or conversations followed the record</summary>
	[JsonIgnore]
	public int? TeamsFollowed
	{
		get
		{
			return TryGetValue("teamsfollowed", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("teamsfollowed") is false || Remove("teamsfollowed"))
			{
				Add("teamsfollowed", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Business Phone, Format: Text, MaxLength: 50, SchemaName: Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the work phone number for the primary contact for the lead.</summary>
	[JsonIgnore]
	public string? Telephone1
	{
		get
		{
			return TryGetValue("telephone1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("telephone1") is false || Remove("telephone1"))
			{
				Add("telephone1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Home Phone, Format: Text, MaxLength: 50, SchemaName: Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type the home phone number for the primary contact for the lead.</summary>
	[JsonIgnore]
	public string? Telephone2
	{
		get
		{
			return TryGetValue("telephone2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("telephone2") is false || Remove("telephone2"))
			{
				Add("telephone2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Phone, Format: Text, MaxLength: 50, SchemaName: Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type an alternate phone number for the primary contact for the lead.</summary>
	[JsonIgnore]
	public string? Telephone3
	{
		get
		{
			return TryGetValue("telephone3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("telephone3") is false || Remove("telephone3"))
			{
				Add("telephone3", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Time Spent by me, Format: Text, MaxLength: 1250, SchemaName: TimeSpentByMeOnEmailAndMeetings, IntroducedVersion: 8.2.0.0.  Description: Total time spent for emails (read and write) and meetings by me in relation to the lead record.</summary>
	[JsonIgnore]
	public string? TimeSpentByMeOnEmailAndMeetings
	{
		get
		{
			return TryGetValue("timespentbymeonemailandmeetings", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("timespentbymeonemailandmeetings") is false || Remove("timespentbymeonemailandmeetings"))
			{
				Add("timespentbymeonemailandmeetings", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Website, Format: Url, MaxLength: 200, SchemaName: WebSiteUrl, IntroducedVersion: 5.0.0.0.  Description: Type the website URL for the company associated with this lead.</summary>
	[JsonIgnore]
	public string? WebSiteUrl
	{
		get
		{
			return TryGetValue("websiteurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("websiteurl") is false || Remove("websiteurl"))
			{
				Add("websiteurl", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Company Name, Format: PhoneticGuide, MaxLength: 100, SchemaName: YomiCompanyName, YomiOf: companyname, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.</summary>
	[JsonIgnore]
	public string? YomiCompanyName
	{
		get
		{
			return TryGetValue("yomicompanyname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yomicompanyname") is false || Remove("yomicompanyname"))
			{
				Add("yomicompanyname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi First Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiFirstName, YomiOf: firstname, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.</summary>
	[JsonIgnore]
	public string? YomiFirstName
	{
		get
		{
			return TryGetValue("yomifirstname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yomifirstname") is false || Remove("yomifirstname"))
			{
				Add("yomifirstname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Full Name, Format: PhoneticGuide, MaxLength: 450, SchemaName: YomiFullName, YomiOf: fullname, IntroducedVersion: 5.0.0.0.  Description: Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and reports.</summary>
	[JsonIgnore]
	public string? YomiFullName
	{
		get
		{
			return TryGetValue("yomifullname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yomifullname") is false || Remove("yomifullname"))
			{
				Add("yomifullname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Last Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiLastName, YomiOf: lastname, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.</summary>
	[JsonIgnore]
	public string? YomiLastName
	{
		get
		{
			return TryGetValue("yomilastname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yomilastname") is false || Remove("yomilastname"))
			{
				Add("yomilastname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Middle Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiMiddleName, YomiOf: middlename, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.</summary>
	[JsonIgnore]
	public string? YomiMiddleName
	{
		get
		{
			return TryGetValue("yomimiddlename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yomimiddlename") is false || Remove("yomimiddlename"))
			{
				Add("yomimiddlename", value);
			}
		}
	}

}

