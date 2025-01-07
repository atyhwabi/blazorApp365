namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Business, division, or department in the Microsoft Dynamics 365 database.</summary>
public sealed partial class BusinessUnit : Dictionary<string, object>
{
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Address Type, SchemaName: Address1_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of address for address 1, such as billing, shipping, or primary address.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Address Type, SchemaName: Address1_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of address for address 1, such as billing, shipping, or primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bill To City, Format: Text, MaxLength: 80, SchemaName: Address1_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bill To Country/Region, Format: Text, MaxLength: 80, SchemaName: Address1_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: County, Format: Text, MaxLength: 50, SchemaName: Address1_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Fax, Format: Text, MaxLength: 50, SchemaName: Address1_Fax, IntroducedVersion: 5.0.0.0.  Description: Fax number for address 1.</summary>
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

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address1_Latitude, IntroducedVersion: 5.0.0.0.  Description: Latitude for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bill To Street 1, Format: Text, MaxLength: 250, SchemaName: Address1_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 1 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bill To Street 2, Format: Text, MaxLength: 250, SchemaName: Address1_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 1 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bill To Street 3, Format: Text, MaxLength: 250, SchemaName: Address1_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 1 information.</summary>
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

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 1: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address1_Longitude, IntroducedVersion: 5.0.0.0.  Description: Longitude for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Name, Format: Text, MaxLength: 100, SchemaName: Address1_Name, IntroducedVersion: 5.0.0.0.  Description: Name to enter for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bill To ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address1_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address1_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 1.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Shipping Method, SchemaName: Address1_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 1.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Shipping Method, SchemaName: Address1_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bill To State/Province, Format: Text, MaxLength: 50, SchemaName: Address1_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Main Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: First telephone number associated with address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Second telephone number associated with address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Third telephone number associated with address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address1_UPSZone, IntroducedVersion: 5.0.0.0.  Description: United Parcel Service (UPS) zone for address 1.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 1: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address1_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Address Type, SchemaName: Address2_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of address for address 2, such as billing, shipping, or primary address.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Address Type, SchemaName: Address2_AddressTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of address for address 2, such as billing, shipping, or primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ship To City, Format: Text, MaxLength: 80, SchemaName: Address2_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ship To Country/Region, Format: Text, MaxLength: 80, SchemaName: Address2_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: County, Format: Text, MaxLength: 50, SchemaName: Address2_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Fax, Format: Text, MaxLength: 50, SchemaName: Address2_Fax, IntroducedVersion: 5.0.0.0.  Description: Fax number for address 2.</summary>
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

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address2_Latitude, IntroducedVersion: 5.0.0.0.  Description: Latitude for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ship To Street 1, Format: Text, MaxLength: 250, SchemaName: Address2_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 2 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ship To Street 2, Format: Text, MaxLength: 250, SchemaName: Address2_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 2 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ship To Street 3, Format: Text, MaxLength: 250, SchemaName: Address2_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 2 information.</summary>
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

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 2: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address2_Longitude, IntroducedVersion: 5.0.0.0.  Description: Longitude for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Name, Format: Text, MaxLength: 100, SchemaName: Address2_Name, IntroducedVersion: 5.0.0.0.  Description: Name to enter for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ship To ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address2_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address2_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 2.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Shipping Method, SchemaName: Address2_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 2.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Shipping Method, SchemaName: Address2_ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Method of shipment for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ship To State/Province, Format: Text, MaxLength: 50, SchemaName: Address2_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 1, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone1, IntroducedVersion: 5.0.0.0.  Description: First telephone number associated with address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 2, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone2, IntroducedVersion: 5.0.0.0.  Description: Second telephone number associated with address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Address2_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Third telephone number associated with address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address2_UPSZone, IntroducedVersion: 5.0.0.0.  Description: United Parcel Service (UPS) zone for address 2.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 2: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address2_UTCOffset, IntroducedVersion: 5.0.0.0.  Description: UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Business Unit, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit.</summary>
	[JsonIgnore]
	public Guid? BusinessUnitId
	{
		get
		{
			return TryGetValue("businessunitid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("businessunitid") is false || Remove("businessunitid"))
			{
				Add("businessunitid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the business unit.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Cost Center, Format: Text, MaxLength: 100, SchemaName: CostCenter, IntroducedVersion: 5.0.0.0.  Description: Name of the business unit cost center.</summary>
	[JsonIgnore]
	public string? CostCenter
	{
		get
		{
			return TryGetValue("costcenter", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("costcenter") is false || Remove("costcenter"))
			{
				Add("costcenter", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the business unit.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the business unit was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the businessunit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the businessunit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the businessunit.</summary>
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

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Credit Limit, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: CreditLimit, IntroducedVersion: 5.0.0.0.  Description: Credit limit for the business unit.</summary>
	[JsonIgnore]
	public double? CreditLimit
	{
		get
		{
			return TryGetValue("creditlimit", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("creditlimit") is false || Remove("creditlimit"))
			{
				Add("creditlimit", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: Text, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Description of the business unit.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Disable Reason, Format: Text, MaxLength: 500, SchemaName: DisabledReason, IntroducedVersion: 5.0.0.0.  Description: Reason for disabling the business unit.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Division, Format: Text, MaxLength: 100, SchemaName: DivisionName, IntroducedVersion: 5.0.0.0.  Description: Name of the division to which the business unit belongs.</summary>
	[JsonIgnore]
	public string? DivisionName
	{
		get
		{
			return TryGetValue("divisionname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("divisionname") is false || Remove("divisionname"))
			{
				Add("divisionname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress, IntroducedVersion: 5.0.0.0.  Description: Email address for the business unit.</summary>
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the businessunit with respect to the base currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: File as Name, Format: Text, MaxLength: 100, SchemaName: FileAsName, IntroducedVersion: 5.0.0.0.  Description: Alternative name under which the business unit can be filed.</summary>
	[JsonIgnore]
	public string? FileAsName
	{
		get
		{
			return TryGetValue("fileasname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("fileasname") is false || Remove("fileasname"))
			{
				Add("fileasname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: FTP Site, Format: Url, MaxLength: 200, SchemaName: FtpSiteUrl, IntroducedVersion: 5.0.0.0.  Description: FTP site URL for the business unit.</summary>
	[JsonIgnore]
	public string? FtpSiteUrl
	{
		get
		{
			return TryGetValue("ftpsiteurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ftpsiteurl") is false || Remove("ftpsiteurl"))
			{
				Add("ftpsiteurl", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the data import or data migration that created this record.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Inheritance Mask, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: InheritanceMask, IntroducedVersion: 5.0.0.0.  Description: Inheritance mask for the business unit.</summary>
	[JsonIgnore]
	public int? InheritanceMask
	{
		get
		{
			return TryGetValue("inheritancemask", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("inheritancemask") is false || Remove("inheritancemask"))
			{
				Add("inheritancemask", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Disabled, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the business unit is enabled or disabled.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Disabled, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the business unit is enabled or disabled.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the business unit.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the business unit was last modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the businessunit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the businessunit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the businessunit.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Name, Format: Text, MaxLength: 160, SchemaName: Name, IntroducedVersion: 5.0.0.0.  Description: Name of the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the organization associated with the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the organization associated with the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the organization associated with the business unit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Parent Business, Format: None, SchemaName: ParentBusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the parent business unit.</summary>
	[JsonIgnore]
	public string? ParentBusinessUnitIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentbusinessunitid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Parent Business, Format: None, SchemaName: ParentBusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the parent business unit.</summary>
	[JsonIgnore]
	public Guid? ParentBusinessUnitId
	{
		get
		{
			return TryGetValue("_parentbusinessunitid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Parent Business, Format: None, SchemaName: ParentBusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the parent business unit.</summary>
	[JsonIgnore]
	public Guid? ParentBusinessUnitId_businessunit
	{
		set
		{
			if (ContainsKey("parentbusinessunitid_businessunit@odata.bind") is false || Remove("parentbusinessunitid_businessunit@odata.bind"))
			{
				if (value is not null)
				{
					Add("parentbusinessunitid_businessunit@odata.bind", $"({value})");
				}
				else
				{
					Add("_parentbusinessunitid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: parentbusinessunitid, Format: Text, MaxLength: 100, SchemaName: ParentBusinessUnitIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentBusinessUnitIdName
	{
		get
		{
			return TryGetValue("parentbusinessunitidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentbusinessunitidname") is false || Remove("parentbusinessunitidname"))
			{
				Add("parentbusinessunitidname", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Picture, Format: TextArea, MaxLength: 1073741823, SchemaName: Picture, IntroducedVersion: 5.0.0.0.  Description: Picture or diagram of the business unit.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Stock Exchange, Format: Text, MaxLength: 20, SchemaName: StockExchange, IntroducedVersion: 5.0.0.0.  Description: Stock exchange on which the business is listed.</summary>
	[JsonIgnore]
	public string? StockExchange
	{
		get
		{
			return TryGetValue("stockexchange", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("stockexchange") is false || Remove("stockexchange"))
			{
				Add("stockexchange", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ticker Symbol, Format: Text, MaxLength: 10, SchemaName: TickerSymbol, IntroducedVersion: 5.0.0.0.  Description: Stock exchange ticker symbol for the business unit.</summary>
	[JsonIgnore]
	public string? TickerSymbol
	{
		get
		{
			return TryGetValue("tickersymbol", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("tickersymbol") is false || Remove("tickersymbol"))
			{
				Add("tickersymbol", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the businessunit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the businessunit.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the businessunit.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, SchemaName: UserGroupId, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: UTCOffset, IntroducedVersion: 5.0.0.0.  Description: UTC offset for the business unit. This is the difference between local time and standard Coordinated Universal Time.</summary>
	[JsonIgnore]
	public int? UTCOffset
	{
		get
		{
			return TryGetValue("utcoffset", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("utcoffset") is false || Remove("utcoffset"))
			{
				Add("utcoffset", value);
			}
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the business unit.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Website, Format: Url, MaxLength: 200, SchemaName: WebSiteUrl, IntroducedVersion: 5.0.0.0.  Description: Website URL for the business unit.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Workflow Suspended, SchemaName: WorkflowSuspended, IntroducedVersion: 5.0.0.0.  Description: Information about whether workflow or sales process rules have been suspended.</summary>
	[JsonIgnore]
	public string? WorkflowSuspendedFormattedValue
	{
		get
		{
			return TryGetValue("workflowsuspended@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Workflow Suspended, SchemaName: WorkflowSuspended, IntroducedVersion: 5.0.0.0.  Description: Information about whether workflow or sales process rules have been suspended.</summary>
	[JsonIgnore]
	public bool? WorkflowSuspended
	{
		get
		{
			return TryGetValue("workflowsuspended", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("workflowsuspended") is false || Remove("workflowsuspended"))
			{
				Add("workflowsuspended", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: workflowsuspended, SchemaName: WorkflowSuspendedName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? WorkflowSuspendedName
	{
		get
		{
			return TryGetValue("workflowsuspendedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

}

