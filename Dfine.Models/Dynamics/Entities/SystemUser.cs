namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.</summary>
public sealed partial class SystemUser : Dictionary<string, object>
{
	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Access Mode, SchemaName: AccessMode, IntroducedVersion: 5.0.0.0.  Description: Type of user.</summary>
	[JsonIgnore]
	public string? AccessModeFormattedValue
	{
		get
		{
			return TryGetValue("accessmode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Access Mode, SchemaName: AccessMode, IntroducedVersion: 5.0.0.0.  Description: Type of user.</summary>
	[JsonIgnore]
	public int? AccessMode
	{
		get
		{
			return TryGetValue("accessmode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("accessmode") is false || Remove("accessmode"))
			{
				Add("accessmode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: accessmode, SchemaName: AccessModeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? AccessModeName
	{
		get
		{
			return TryGetValue("accessmodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Active Directory Guid, SchemaName: ActiveDirectoryGuid, IntroducedVersion: 5.0.0.0.  Description: Active Directory object GUID for the system user.</summary>
	[JsonIgnore]
	public Guid? ActiveDirectoryGuid
	{
		get
		{
			return TryGetValue("activedirectoryguid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("activedirectoryguid") is false || Remove("activedirectoryguid"))
			{
				Add("activedirectoryguid", value);
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: City, Format: Text, MaxLength: 128, SchemaName: Address1_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 1.</summary>
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

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address, Format: TextArea, MaxLength: 1000, SchemaName: Address1_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Country/Region, Format: Text, MaxLength: 128, SchemaName: Address1_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name in address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: County, Format: Text, MaxLength: 128, SchemaName: Address1_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Fax, Format: Text, MaxLength: 64, SchemaName: Address1_Fax, IntroducedVersion: 5.0.0.0.  Description: Fax number for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 1, Format: Text, MaxLength: 1024, SchemaName: Address1_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 1 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 2, Format: Text, MaxLength: 1024, SchemaName: Address1_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 1 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Street 3, Format: Text, MaxLength: 1024, SchemaName: Address1_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 1 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ZIP/Postal Code, Format: Text, MaxLength: 40, SchemaName: Address1_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Post Office Box, Format: Text, MaxLength: 40, SchemaName: Address1_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: State/Province, Format: Text, MaxLength: 128, SchemaName: Address1_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Main Phone, Format: Text, MaxLength: 64, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: First telephone number associated with address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pager, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone3, IntroducedVersion: 5.0.0.0.  Description: Third telephone number associated with address 1.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other City, Format: Text, MaxLength: 128, SchemaName: Address2_City, IntroducedVersion: 5.0.0.0.  Description: City name for address 2.</summary>
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

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Other Address, Format: TextArea, MaxLength: 1000, SchemaName: Address2_Composite, IntroducedVersion: 6.0.0.0.  Description: Shows the complete secondary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Country/Region, Format: Text, MaxLength: 128, SchemaName: Address2_Country, IntroducedVersion: 5.0.0.0.  Description: Country/region name in address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: County, Format: Text, MaxLength: 128, SchemaName: Address2_County, IntroducedVersion: 5.0.0.0.  Description: County name for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Street 1, Format: Text, MaxLength: 1024, SchemaName: Address2_Line1, IntroducedVersion: 5.0.0.0.  Description: First line for entering address 2 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Street 2, Format: Text, MaxLength: 1024, SchemaName: Address2_Line2, IntroducedVersion: 5.0.0.0.  Description: Second line for entering address 2 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Street 3, Format: Text, MaxLength: 1024, SchemaName: Address2_Line3, IntroducedVersion: 5.0.0.0.  Description: Third line for entering address 2 information.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other ZIP/Postal Code, Format: Text, MaxLength: 40, SchemaName: Address2_PostalCode, IntroducedVersion: 5.0.0.0.  Description: ZIP Code or postal code for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Post Office Box, Format: Text, MaxLength: 40, SchemaName: Address2_PostOfficeBox, IntroducedVersion: 5.0.0.0.  Description: Post office box number for address 2.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other State/Province, Format: Text, MaxLength: 128, SchemaName: Address2_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: State or province for address 2.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Application ID, SchemaName: ApplicationId, IntroducedVersion: 8.2.0.0.  Description: The identifier for the application. This is used to access data in another application.</summary>
	[JsonIgnore]
	public Guid? ApplicationId
	{
		get
		{
			return TryGetValue("applicationid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("applicationid") is false || Remove("applicationid"))
			{
				Add("applicationid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Application ID URI, Format: Text, MaxLength: 1024, SchemaName: ApplicationIdUri, IntroducedVersion: 8.2.0.0.  Description: The URI used as a unique logical identifier for the external app. This can be used to validate the application.</summary>
	[JsonIgnore]
	public string? ApplicationIdUri
	{
		get
		{
			return TryGetValue("applicationiduri", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("applicationiduri") is false || Remove("applicationiduri"))
			{
				Add("applicationiduri", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Azure AD Object ID, SchemaName: AzureActiveDirectoryObjectId, IntroducedVersion: 8.2.0.0.  Description: This is the application directory object Id.</summary>
	[JsonIgnore]
	public Guid? AzureActiveDirectoryObjectId
	{
		get
		{
			return TryGetValue("azureactivedirectoryobjectid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("azureactivedirectoryobjectid") is false || Remove("azureactivedirectoryobjectid"))
			{
				Add("azureactivedirectoryobjectid", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Azure Deleted On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: AzureDeletedOn, IntroducedVersion: 9.2.0.0.  Description: Date and time when the user was set as soft deleted in Azure.</summary>
	[JsonIgnore]
	public DateTime? AzureDeletedOn
	{
		get
		{
			return TryGetValue("azuredeletedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("azuredeletedon") is false || Remove("azuredeletedon"))
			{
				Add("azuredeletedon", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Azure State, SchemaName: AzureState, IntroducedVersion: 9.2.0.0.  Description: Azure state of user</summary>
	[JsonIgnore]
	public string? AzureStateFormattedValue
	{
		get
		{
			return TryGetValue("azurestate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Azure State, SchemaName: AzureState, IntroducedVersion: 9.2.0.0.  Description: Azure state of user</summary>
	[JsonIgnore]
	public int? AzureState
	{
		get
		{
			return TryGetValue("azurestate", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("azurestate") is false || Remove("azurestate"))
			{
				Add("azurestate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: azurestate, SchemaName: azurestateName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? azurestateName
	{
		get
		{
			return TryGetValue("azurestatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the user is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the user is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the user is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Calendar, Format: None, SchemaName: CalendarId, IntroducedVersion: 5.0.0.0.  Description: Fiscal calendar associated with the user.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: License Type, SchemaName: CALType, IntroducedVersion: 5.0.0.0.  Description: License type of user. This is used only in the on-premises version of the product. Online licenses are managed through Microsoft 365 Office Portal</summary>
	[JsonIgnore]
	public string? CALTypeFormattedValue
	{
		get
		{
			return TryGetValue("caltype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: License Type, SchemaName: CALType, IntroducedVersion: 5.0.0.0.  Description: License type of user. This is used only in the on-premises version of the product. Online licenses are managed through Microsoft 365 Office Portal</summary>
	[JsonIgnore]
	public int? CALType
	{
		get
		{
			return TryGetValue("caltype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("caltype") is false || Remove("caltype"))
			{
				Add("caltype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: caltype, SchemaName: CALTypeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CALTypeName
	{
		get
		{
			return TryGetValue("caltypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the user.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the user was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the systemuser.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the systemuser.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the systemuser.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Default Filters Populated, SchemaName: DefaultFiltersPopulated, IntroducedVersion: 5.0.0.0.  Description: Indicates if default outlook filters have been populated.</summary>
	[JsonIgnore]
	public string? DefaultFiltersPopulatedFormattedValue
	{
		get
		{
			return TryGetValue("defaultfilterspopulated@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Default Filters Populated, SchemaName: DefaultFiltersPopulated, IntroducedVersion: 5.0.0.0.  Description: Indicates if default outlook filters have been populated.</summary>
	[JsonIgnore]
	public bool? DefaultFiltersPopulated
	{
		get
		{
			return TryGetValue("defaultfilterspopulated", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultfilterspopulated") is false || Remove("defaultfilterspopulated"))
			{
				Add("defaultfilterspopulated", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mailbox, Format: None, SchemaName: DefaultMailbox, IntroducedVersion: 6.0.0.0.  Description: Select the mailbox associated with this user.</summary>
	[JsonIgnore]
	public string? DefaultMailboxFormattedValue
	{
		get
		{
			return TryGetValue("_defaultmailbox_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mailbox, Format: None, SchemaName: DefaultMailbox, IntroducedVersion: 6.0.0.0.  Description: Select the mailbox associated with this user.</summary>
	[JsonIgnore]
	public Guid? DefaultMailbox
	{
		get
		{
			return TryGetValue("_defaultmailbox_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mailbox, Format: None, SchemaName: DefaultMailbox, IntroducedVersion: 6.0.0.0.  Description: Select the mailbox associated with this user.</summary>
	[JsonIgnore]
	public Guid? DefaultMailbox_mailbox
	{
		set
		{
			if (ContainsKey("defaultmailbox_mailbox@odata.bind") is false || Remove("defaultmailbox_mailbox@odata.bind"))
			{
				if (value is not null)
				{
					Add("defaultmailbox_mailbox@odata.bind", $"({value})");
				}
				else
				{
					Add("_defaultmailbox_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: defaultmailbox, Format: Text, MaxLength: 100, SchemaName: DefaultMailboxName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public string? DefaultMailboxName
	{
		get
		{
			return TryGetValue("defaultmailboxname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultmailboxname") is false || Remove("defaultmailboxname"))
			{
				Add("defaultmailboxname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Default OneDrive for Business Folder Name, Format: Text, MaxLength: 200, SchemaName: DefaultOdbFolderName, IntroducedVersion: 8.0.0.0.  Description: Type a default folder name for the user's OneDrive For Business location.</summary>
	[JsonIgnore]
	public string? DefaultOdbFolderName
	{
		get
		{
			return TryGetValue("defaultodbfoldername", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultodbfoldername") is false || Remove("defaultodbfoldername"))
			{
				Add("defaultodbfoldername", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Deleted State, SchemaName: DeletedState, IntroducedVersion: 9.2.0.0.  Description: User delete state</summary>
	[JsonIgnore]
	public string? DeletedStateFormattedValue
	{
		get
		{
			return TryGetValue("deletedstate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Deleted State, SchemaName: DeletedState, IntroducedVersion: 9.2.0.0.  Description: User delete state</summary>
	[JsonIgnore]
	public int? DeletedState
	{
		get
		{
			return TryGetValue("deletedstate", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("deletedstate") is false || Remove("deletedstate"))
			{
				Add("deletedstate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: deletedstate, SchemaName: deletedstateName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? deletedstateName
	{
		get
		{
			return TryGetValue("deletedstatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Disabled Reason, Format: Text, MaxLength: 500, SchemaName: DisabledReason, IntroducedVersion: 5.0.0.0.  Description: Reason for disabling the user.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Display in Service Views, SchemaName: DisplayInServiceViews, IntroducedVersion: 5.0.0.0.  Description: Whether to display the user in service views.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Display in Service Views, SchemaName: DisplayInServiceViews, IntroducedVersion: 5.0.0.0.  Description: Whether to display the user in service views.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: User Name, Format: Text, MaxLength: 1024, SchemaName: DomainName, IntroducedVersion: 5.0.0.0.  Description: Active Directory domain of which the user is a member.</summary>
	[JsonIgnore]
	public string? DomainName
	{
		get
		{
			return TryGetValue("domainname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("domainname") is false || Remove("domainname"))
			{
				Add("domainname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Primary Email Status, SchemaName: EmailRouterAccessApproval, IntroducedVersion: 5.0.0.0.  Description: Shows the status of the primary email address.</summary>
	[JsonIgnore]
	public string? EmailRouterAccessApprovalFormattedValue
	{
		get
		{
			return TryGetValue("emailrouteraccessapproval@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Primary Email Status, SchemaName: EmailRouterAccessApproval, IntroducedVersion: 5.0.0.0.  Description: Shows the status of the primary email address.</summary>
	[JsonIgnore]
	public int? EmailRouterAccessApproval
	{
		get
		{
			return TryGetValue("emailrouteraccessapproval", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("emailrouteraccessapproval") is false || Remove("emailrouteraccessapproval"))
			{
				Add("emailrouteraccessapproval", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: emailrouteraccessapproval, SchemaName: EmailRouterAccessApprovalName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? EmailRouterAccessApprovalName
	{
		get
		{
			return TryGetValue("emailrouteraccessapprovalname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Employee, Format: Text, MaxLength: 100, SchemaName: EmployeeId, IntroducedVersion: 5.0.0.0.  Description: Employee identifier for the user.</summary>
	[JsonIgnore]
	public string? EmployeeId
	{
		get
		{
			return TryGetValue("employeeid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("employeeid") is false || Remove("employeeid"))
			{
				Add("employeeid", value);
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the systemuser with respect to the base currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: First Name, Format: Text, MaxLength: 256, SchemaName: FirstName, IntroducedVersion: 5.0.0.0.  Description: First name of the user.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Full Name, Format: Text, MaxLength: 200, SchemaName: FullName, IntroducedVersion: 5.0.0.0.  Description: Full name of the user.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Government, Format: Text, MaxLength: 100, SchemaName: GovernmentId, IntroducedVersion: 5.0.0.0.  Description: Government identifier for the user.</summary>
	[JsonIgnore]
	public string? GovernmentId
	{
		get
		{
			return TryGetValue("governmentid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("governmentid") is false || Remove("governmentid"))
			{
				Add("governmentid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Home Phone, Format: Text, MaxLength: 50, SchemaName: HomePhone, IntroducedVersion: 5.0.0.0.  Description: Home phone number for the user.</summary>
	[JsonIgnore]
	public string? HomePhone
	{
		get
		{
			return TryGetValue("homephone", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("homephone") is false || Remove("homephone"))
			{
				Add("homephone", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Unique user identity id, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: IdentityId, IntroducedVersion: 9.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public int? IdentityId
	{
		get
		{
			return TryGetValue("identityid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("identityid") is false || Remove("identityid"))
			{
				Add("identityid", value);
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

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Incoming Email Delivery Method, SchemaName: IncomingEmailDeliveryMethod, IntroducedVersion: 5.0.0.0.  Description: Incoming email delivery method for the user.</summary>
	[JsonIgnore]
	public string? IncomingEmailDeliveryMethodFormattedValue
	{
		get
		{
			return TryGetValue("incomingemaildeliverymethod@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Incoming Email Delivery Method, SchemaName: IncomingEmailDeliveryMethod, IntroducedVersion: 5.0.0.0.  Description: Incoming email delivery method for the user.</summary>
	[JsonIgnore]
	public int? IncomingEmailDeliveryMethod
	{
		get
		{
			return TryGetValue("incomingemaildeliverymethod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("incomingemaildeliverymethod") is false || Remove("incomingemaildeliverymethod"))
			{
				Add("incomingemaildeliverymethod", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: incomingemaildeliverymethod, SchemaName: IncomingEmailDeliveryMethodName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IncomingEmailDeliveryMethodName
	{
		get
		{
			return TryGetValue("incomingemaildeliverymethodname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Primary Email, Format: Email, MaxLength: 100, SchemaName: InternalEMailAddress, IntroducedVersion: 5.0.0.0.  Description: Internal email address for the user.</summary>
	[JsonIgnore]
	public string? InternalEMailAddress
	{
		get
		{
			return TryGetValue("internalemailaddress", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("internalemailaddress") is false || Remove("internalemailaddress"))
			{
				Add("internalemailaddress", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Invitation Status, SchemaName: InviteStatusCode, IntroducedVersion: 5.0.0.0.  Description: User invitation status.</summary>
	[JsonIgnore]
	public string? InviteStatusCodeFormattedValue
	{
		get
		{
			return TryGetValue("invitestatuscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Invitation Status, SchemaName: InviteStatusCode, IntroducedVersion: 5.0.0.0.  Description: User invitation status.</summary>
	[JsonIgnore]
	public int? InviteStatusCode
	{
		get
		{
			return TryGetValue("invitestatuscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("invitestatuscode") is false || Remove("invitestatuscode"))
			{
				Add("invitestatuscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: invitestatuscode, SchemaName: InviteStatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? InviteStatusCodeName
	{
		get
		{
			return TryGetValue("invitestatuscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Active Directory User, SchemaName: IsActiveDirectoryUser, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is an AD user.</summary>
	[JsonIgnore]
	public string? IsActiveDirectoryUserFormattedValue
	{
		get
		{
			return TryGetValue("isactivedirectoryuser@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Active Directory User, SchemaName: IsActiveDirectoryUser, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is an AD user.</summary>
	[JsonIgnore]
	public bool? IsActiveDirectoryUser
	{
		get
		{
			return TryGetValue("isactivedirectoryuser", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isactivedirectoryuser") is false || Remove("isactivedirectoryuser"))
			{
				Add("isactivedirectoryuser", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Status, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is enabled.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Status, SchemaName: IsDisabled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is enabled.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Email Address O365 Admin Approval Status, SchemaName: IsEmailAddressApprovedByO365Admin, IntroducedVersion: 6.0.0.0.  Description: Shows the status of approval of the email address by O365 Admin.</summary>
	[JsonIgnore]
	public string? IsEmailAddressApprovedByO365AdminFormattedValue
	{
		get
		{
			return TryGetValue("isemailaddressapprovedbyo365admin@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Email Address O365 Admin Approval Status, SchemaName: IsEmailAddressApprovedByO365Admin, IntroducedVersion: 6.0.0.0.  Description: Shows the status of approval of the email address by O365 Admin.</summary>
	[JsonIgnore]
	public bool? IsEmailAddressApprovedByO365Admin
	{
		get
		{
			return TryGetValue("isemailaddressapprovedbyo365admin", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isemailaddressapprovedbyo365admin") is false || Remove("isemailaddressapprovedbyo365admin"))
			{
				Add("isemailaddressapprovedbyo365admin", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Integration user mode, SchemaName: IsIntegrationUser, IntroducedVersion: 5.0.0.0.  Description: Check if user is an integration user.</summary>
	[JsonIgnore]
	public string? IsIntegrationUserFormattedValue
	{
		get
		{
			return TryGetValue("isintegrationuser@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Integration user mode, SchemaName: IsIntegrationUser, IntroducedVersion: 5.0.0.0.  Description: Check if user is an integration user.</summary>
	[JsonIgnore]
	public bool? IsIntegrationUser
	{
		get
		{
			return TryGetValue("isintegrationuser", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isintegrationuser") is false || Remove("isintegrationuser"))
			{
				Add("isintegrationuser", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isintegrationuser, SchemaName: IsIntegrationUserName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsIntegrationUserName
	{
		get
		{
			return TryGetValue("isintegrationusername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Licensed, SchemaName: IsLicensed, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is licensed.</summary>
	[JsonIgnore]
	public string? IsLicensedFormattedValue
	{
		get
		{
			return TryGetValue("islicensed@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Licensed, SchemaName: IsLicensed, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is licensed.</summary>
	[JsonIgnore]
	public bool? IsLicensed
	{
		get
		{
			return TryGetValue("islicensed", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("islicensed") is false || Remove("islicensed"))
			{
				Add("islicensed", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: islicensed, SchemaName: IsLicensedName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? IsLicensedName
	{
		get
		{
			return TryGetValue("islicensedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Synced, SchemaName: IsSyncWithDirectory, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is synced with the directory.</summary>
	[JsonIgnore]
	public string? IsSyncWithDirectoryFormattedValue
	{
		get
		{
			return TryGetValue("issyncwithdirectory@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: User Synced, SchemaName: IsSyncWithDirectory, IntroducedVersion: 5.0.0.0.  Description: Information about whether the user is synced with the directory.</summary>
	[JsonIgnore]
	public bool? IsSyncWithDirectory
	{
		get
		{
			return TryGetValue("issyncwithdirectory", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("issyncwithdirectory") is false || Remove("issyncwithdirectory"))
			{
				Add("issyncwithdirectory", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Job Title, Format: Text, MaxLength: 100, SchemaName: JobTitle, IntroducedVersion: 5.0.0.0.  Description: Job title of the user.</summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Last Name, Format: Text, MaxLength: 256, SchemaName: LastName, IntroducedVersion: 5.0.0.0.  Description: Last name of the user.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Latest User Update Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LatestUpdateTime, IntroducedVersion: 9.0.0.0.  Description: Time stamp of the latest update for the user</summary>
	[JsonIgnore]
	public DateTime? LatestUpdateTime
	{
		get
		{
			return TryGetValue("latestupdatetime", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("latestupdatetime") is false || Remove("latestupdatetime"))
			{
				Add("latestupdatetime", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Middle Name, Format: Text, MaxLength: 50, SchemaName: MiddleName, IntroducedVersion: 5.0.0.0.  Description: Middle name of the user.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Mobile Alert Email, Format: Email, MaxLength: 100, SchemaName: MobileAlertEMail, IntroducedVersion: 5.0.0.0.  Description: Mobile alert email address for the user.</summary>
	[JsonIgnore]
	public string? MobileAlertEMail
	{
		get
		{
			return TryGetValue("mobilealertemail", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("mobilealertemail") is false || Remove("mobilealertemail"))
			{
				Add("mobilealertemail", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mobile Offline Profile, Format: None, SchemaName: MobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Items contained with a particular SystemUser.</summary>
	[JsonIgnore]
	public string? MobileOfflineProfileIdFormattedValue
	{
		get
		{
			return TryGetValue("_mobileofflineprofileid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mobile Offline Profile, Format: None, SchemaName: MobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Items contained with a particular SystemUser.</summary>
	[JsonIgnore]
	public Guid? MobileOfflineProfileId
	{
		get
		{
			return TryGetValue("_mobileofflineprofileid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Mobile Offline Profile, Format: None, SchemaName: MobileOfflineProfileId, IntroducedVersion: 8.0.0.0.  Description: Items contained with a particular SystemUser.</summary>
	[JsonIgnore]
	public Guid? MobileOfflineProfileId_mobileofflineprofile
	{
		set
		{
			if (ContainsKey("mobileofflineprofileid_mobileofflineprofile@odata.bind") is false || Remove("mobileofflineprofileid_mobileofflineprofile@odata.bind"))
			{
				if (value is not null)
				{
					Add("mobileofflineprofileid_mobileofflineprofile@odata.bind", $"({value})");
				}
				else
				{
					Add("_mobileofflineprofileid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: mobileofflineprofileid, Format: Text, MaxLength: 100, SchemaName: MobileOfflineProfileIdName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public string? MobileOfflineProfileIdName
	{
		get
		{
			return TryGetValue("mobileofflineprofileidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("mobileofflineprofileidname") is false || Remove("mobileofflineprofileidname"))
			{
				Add("mobileofflineprofileidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Mobile Phone, Format: Text, MaxLength: 64, SchemaName: MobilePhone, IntroducedVersion: 5.0.0.0.  Description: Mobile phone number for the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the user.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the user was last modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the systemuser.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the systemuser.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the systemuser.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: User type, SchemaName: msdyn_AgentType, IntroducedVersion: 1.0.0.0.  Description: Type of user - Application user or Bot application user</summary>
	[JsonIgnore]
	public string? msdyn_AgentTypeFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_agentType@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: User type, SchemaName: msdyn_AgentType, IntroducedVersion: 1.0.0.0.  Description: Type of user - Application user or Bot application user</summary>
	[JsonIgnore]
	public int? msdyn_AgentType
	{
		get
		{
			return TryGetValue("msdyn_agentType", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_agentType") is false || Remove("msdyn_agentType"))
			{
				Add("msdyn_agentType", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_agentType, SchemaName: msdyn_agentTypeName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_agentTypeName
	{
		get
		{
			return TryGetValue("msdyn_agenttypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bot application ID, Format: Text, MaxLength: 100, SchemaName: msdyn_BotApplicationId, IntroducedVersion: 1.0.0.0.  Description: Application ID of the bot.</summary>
	[JsonIgnore]
	public string? msdyn_BotApplicationId
	{
		get
		{
			return TryGetValue("msdyn_botapplicationid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_botapplicationid") is false || Remove("msdyn_botapplicationid"))
			{
				Add("msdyn_botapplicationid", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: Text, MaxLength: 2000, SchemaName: msdyn_BotDescription, IntroducedVersion: 1.0.0.1.  Description: BOT User Description</summary>
	[JsonIgnore]
	public string? msdyn_BotDescription
	{
		get
		{
			return TryGetValue("msdyn_botdescription", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_botdescription") is false || Remove("msdyn_botdescription"))
			{
				Add("msdyn_botdescription", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Endpoint, Format: Text, MaxLength: 100, SchemaName: msdyn_BotEndpoint, IntroducedVersion: 1.0.0.1.  Description: Bot User Endpoint</summary>
	[JsonIgnore]
	public string? msdyn_BotEndpoint
	{
		get
		{
			return TryGetValue("msdyn_botendpoint", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_botendpoint") is false || Remove("msdyn_botendpoint"))
			{
				Add("msdyn_botendpoint", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Bot handle, Format: Text, MaxLength: 100, SchemaName: msdyn_bothandle, IntroducedVersion: 1.0.0.0.  Description: Bot handle</summary>
	[JsonIgnore]
	public string? msdyn_bothandle
	{
		get
		{
			return TryGetValue("msdyn_bothandle", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_bothandle") is false || Remove("msdyn_bothandle"))
			{
				Add("msdyn_bothandle", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Bot Provider, SchemaName: msdyn_BotProvider, IntroducedVersion: 1.0.0.3.  Description: Indicates the type of bot</summary>
	[JsonIgnore]
	public string? msdyn_BotProviderFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_botprovider@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Bot Provider, SchemaName: msdyn_BotProvider, IntroducedVersion: 1.0.0.3.  Description: Indicates the type of bot</summary>
	[JsonIgnore]
	public int? msdyn_BotProvider
	{
		get
		{
			return TryGetValue("msdyn_botprovider", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_botprovider") is false || Remove("msdyn_botprovider"))
			{
				Add("msdyn_botprovider", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_botprovider, SchemaName: msdyn_botproviderName, IntroducedVersion: 1.0.0.3. </summary>
	[JsonIgnore]
	public object? msdyn_botproviderName
	{
		get
		{
			return TryGetValue("msdyn_botprovidername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Secret Keys, Format: Text, MaxLength: 100, SchemaName: msdyn_BotSecretKeys, IntroducedVersion: 1.0.0.1.  Description: Bot User Secret Keys</summary>
	[JsonIgnore]
	public string? msdyn_BotSecretKeys
	{
		get
		{
			return TryGetValue("msdyn_botsecretkeys", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_botsecretkeys") is false || Remove("msdyn_botsecretkeys"))
			{
				Add("msdyn_botsecretkeys", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Capacity, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_Capacity, IntroducedVersion: 1.0.0.0.  Description: Capacity associated with the User.</summary>
	[JsonIgnore]
	public int? msdyn_Capacity
	{
		get
		{
			return TryGetValue("msdyn_capacity", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_capacity") is false || Remove("msdyn_capacity"))
			{
				Add("msdyn_capacity", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Presence, Format: None, SchemaName: msdyn_DefaultPresenceIdUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Presence associated with User.</summary>
	[JsonIgnore]
	public string? msdyn_DefaultPresenceIdUserFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_defaultpresenceiduser_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Presence, Format: None, SchemaName: msdyn_DefaultPresenceIdUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Presence associated with User.</summary>
	[JsonIgnore]
	public Guid? msdyn_DefaultPresenceIdUser
	{
		get
		{
			return TryGetValue("_msdyn_defaultpresenceiduser_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Presence, Format: None, SchemaName: msdyn_DefaultPresenceIdUser, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Presence associated with User.</summary>
	[JsonIgnore]
	public Guid? msdyn_DefaultPresenceIdUser_msdyn_presence
	{
		set
		{
			if (ContainsKey("msdyn_defaultpresenceiduser_msdyn_presence@odata.bind") is false || Remove("msdyn_defaultpresenceiduser_msdyn_presence@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_defaultpresenceiduser_msdyn_presence@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_defaultpresenceiduser_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_defaultpresenceiduser, Format: Text, MaxLength: 100, SchemaName: msdyn_DefaultPresenceIdUserName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_DefaultPresenceIdUserName
	{
		get
		{
			return TryGetValue("msdyn_defaultpresenceidusername", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_defaultpresenceidusername") is false || Remove("msdyn_defaultpresenceidusername"))
			{
				Add("msdyn_defaultpresenceidusername", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether user is opted out or not</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether user is opted out or not</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Grid Wrapper Control field, Format: Text, MaxLength: 4000, SchemaName: msdyn_gridwrappercontrolfield, IntroducedVersion: 1.0.0.0.  Description: Field to bind grid wrapper control</summary>
	[JsonIgnore]
	public string? msdyn_gridwrappercontrolfield
	{
		get
		{
			return TryGetValue("msdyn_gridwrappercontrolfield", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_gridwrappercontrolfield") is false || Remove("msdyn_gridwrappercontrolfield"))
			{
				Add("msdyn_gridwrappercontrolfield", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, DisplayName: Expert Enabled Swarm, SchemaName: msdyn_isexpertenabledforswarm, IntroducedVersion: 1.0.0.0.  Description: Check if swarm is enabled for the experts.</summary>
	[JsonIgnore]
	public string? msdyn_isexpertenabledforswarmFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_isexpertenabledforswarm@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, DisplayName: Expert Enabled Swarm, SchemaName: msdyn_isexpertenabledforswarm, IntroducedVersion: 1.0.0.0.  Description: Check if swarm is enabled for the experts.</summary>
	[JsonIgnore]
	public bool? msdyn_isexpertenabledforswarm
	{
		get
		{
			return TryGetValue("msdyn_isexpertenabledforswarm", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_isexpertenabledforswarm") is false || Remove("msdyn_isexpertenabledforswarm"))
			{
				Add("msdyn_isexpertenabledforswarm", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isexpertenabledforswarm, SchemaName: msdyn_isexpertenabledforswarmName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_isexpertenabledforswarmName
	{
		get
		{
			return TryGetValue("msdyn_isexpertenabledforswarmname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Owning Environment Id, Format: Text, MaxLength: 500, SchemaName: msdyn_OwningEnvironmentId, IntroducedVersion: 1.0.0.0.  Description: Environment Id of the CDS environment that owns the bot user.</summary>
	[JsonIgnore]
	public string? msdyn_OwningEnvironmentId
	{
		get
		{
			return TryGetValue("msdyn_owningenvironmentid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_owningenvironmentid") is false || Remove("msdyn_owningenvironmentid"))
			{
				Add("msdyn_owningenvironmentid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Type, SchemaName: msdyn_UserType, IntroducedVersion: 1.0.0.1.  Description: Type of user - CRM or BOT user</summary>
	[JsonIgnore]
	public string? msdyn_UserTypeFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_usertype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Type, SchemaName: msdyn_UserType, IntroducedVersion: 1.0.0.1.  Description: Type of user - CRM or BOT user</summary>
	[JsonIgnore]
	public int? msdyn_UserType
	{
		get
		{
			return TryGetValue("msdyn_usertype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_usertype") is false || Remove("msdyn_usertype"))
			{
				Add("msdyn_usertype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_usertype, SchemaName: msdyn_usertypeName, IntroducedVersion: 1.0.0.1. </summary>
	[JsonIgnore]
	public object? msdyn_usertypeName
	{
		get
		{
			return TryGetValue("msdyn_usertypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Nickname, Format: Text, MaxLength: 50, SchemaName: NickName, IntroducedVersion: 5.0.0.0.  Description: Nickname of the user.</summary>
	[JsonIgnore]
	public string? NickName
	{
		get
		{
			return TryGetValue("nickname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("nickname") is false || Remove("nickname"))
			{
				Add("nickname", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Organization , SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the organization associated with the user.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Outgoing Email Delivery Method, SchemaName: OutgoingEmailDeliveryMethod, IntroducedVersion: 5.0.0.0.  Description: Outgoing email delivery method for the user.</summary>
	[JsonIgnore]
	public string? OutgoingEmailDeliveryMethodFormattedValue
	{
		get
		{
			return TryGetValue("outgoingemaildeliverymethod@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Outgoing Email Delivery Method, SchemaName: OutgoingEmailDeliveryMethod, IntroducedVersion: 5.0.0.0.  Description: Outgoing email delivery method for the user.</summary>
	[JsonIgnore]
	public int? OutgoingEmailDeliveryMethod
	{
		get
		{
			return TryGetValue("outgoingemaildeliverymethod", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("outgoingemaildeliverymethod") is false || Remove("outgoingemaildeliverymethod"))
			{
				Add("outgoingemaildeliverymethod", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: outgoingemaildeliverymethod, SchemaName: OutgoingEmailDeliveryMethodName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? OutgoingEmailDeliveryMethodName
	{
		get
		{
			return TryGetValue("outgoingemaildeliverymethodname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Manager, Format: None, SchemaName: ParentSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the manager of the user.</summary>
	[JsonIgnore]
	public string? ParentSystemUserIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentsystemuserid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Manager, Format: None, SchemaName: ParentSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the manager of the user.</summary>
	[JsonIgnore]
	public Guid? ParentSystemUserId
	{
		get
		{
			return TryGetValue("_parentsystemuserid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Manager, Format: None, SchemaName: ParentSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the manager of the user.</summary>
	[JsonIgnore]
	public Guid? ParentSystemUserId_systemuser
	{
		set
		{
			if (ContainsKey("parentsystemuserid_systemuser@odata.bind") is false || Remove("parentsystemuserid_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("parentsystemuserid_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_parentsystemuserid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentsystemuserid, Format: Text, MaxLength: 100, SchemaName: ParentSystemUserIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentSystemUserIdName
	{
		get
		{
			return TryGetValue("parentsystemuseridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentsystemuseridname") is false || Remove("parentsystemuseridname"))
			{
				Add("parentsystemuseridname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentsystemuserid, Format: Text, MaxLength: 100, SchemaName: ParentSystemUserIdYomiName, YomiOf: parentsystemuseridname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentSystemUserIdYomiName
	{
		get
		{
			return TryGetValue("parentsystemuseridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentsystemuseridyominame") is false || Remove("parentsystemuseridyominame"))
			{
				Add("parentsystemuseridyominame", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Passport Hi, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: PassportHi, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public int? PassportHi
	{
		get
		{
			return TryGetValue("passporthi", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("passporthi") is false || Remove("passporthi"))
			{
				Add("passporthi", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Passport Lo, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: PassportLo, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public int? PassportLo
	{
		get
		{
			return TryGetValue("passportlo", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("passportlo") is false || Remove("passportlo"))
			{
				Add("passportlo", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email 2, Format: Email, MaxLength: 100, SchemaName: PersonalEMailAddress, IntroducedVersion: 5.0.0.0.  Description: Personal email address of the user.</summary>
	[JsonIgnore]
	public string? PersonalEMailAddress
	{
		get
		{
			return TryGetValue("personalemailaddress", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("personalemailaddress") is false || Remove("personalemailaddress"))
			{
				Add("personalemailaddress", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Photo URL, Format: Url, MaxLength: 200, SchemaName: PhotoUrl, IntroducedVersion: 5.0.0.0.  Description: URL for the Website on which a photo of the user is located.</summary>
	[JsonIgnore]
	public string? PhotoUrl
	{
		get
		{
			return TryGetValue("photourl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("photourl") is false || Remove("photourl"))
			{
				Add("photourl", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Position, Format: None, SchemaName: PositionId, IntroducedVersion: 7.0.0.0.  Description: User's position in hierarchical security model.</summary>
	[JsonIgnore]
	public string? PositionIdFormattedValue
	{
		get
		{
			return TryGetValue("_positionid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Position, Format: None, SchemaName: PositionId, IntroducedVersion: 7.0.0.0.  Description: User's position in hierarchical security model.</summary>
	[JsonIgnore]
	public Guid? PositionId
	{
		get
		{
			return TryGetValue("_positionid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Position, Format: None, SchemaName: PositionId, IntroducedVersion: 7.0.0.0.  Description: User's position in hierarchical security model.</summary>
	[JsonIgnore]
	public Guid? PositionId_position
	{
		set
		{
			if (ContainsKey("positionid_position@odata.bind") is false || Remove("positionid_position@odata.bind"))
			{
				if (value is not null)
				{
					Add("positionid_position@odata.bind", $"({value})");
				}
				else
				{
					Add("_positionid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: positionid, Format: Text, MaxLength: 100, SchemaName: PositionIdName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public string? PositionIdName
	{
		get
		{
			return TryGetValue("positionidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("positionidname") is false || Remove("positionidname"))
			{
				Add("positionidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Address, SchemaName: PreferredAddressCode, IntroducedVersion: 5.0.0.0.  Description: Preferred address for the user.</summary>
	[JsonIgnore]
	public string? PreferredAddressCodeFormattedValue
	{
		get
		{
			return TryGetValue("preferredaddresscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Address, SchemaName: PreferredAddressCode, IntroducedVersion: 5.0.0.0.  Description: Preferred address for the user.</summary>
	[JsonIgnore]
	public int? PreferredAddressCode
	{
		get
		{
			return TryGetValue("preferredaddresscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredaddresscode") is false || Remove("preferredaddresscode"))
			{
				Add("preferredaddresscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredaddresscode, SchemaName: PreferredAddressCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PreferredAddressCodeName
	{
		get
		{
			return TryGetValue("preferredaddresscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Email, SchemaName: PreferredEmailCode, IntroducedVersion: 5.0.0.0.  Description: Preferred email address for the user.</summary>
	[JsonIgnore]
	public string? PreferredEmailCodeFormattedValue
	{
		get
		{
			return TryGetValue("preferredemailcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Email, SchemaName: PreferredEmailCode, IntroducedVersion: 5.0.0.0.  Description: Preferred email address for the user.</summary>
	[JsonIgnore]
	public int? PreferredEmailCode
	{
		get
		{
			return TryGetValue("preferredemailcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredemailcode") is false || Remove("preferredemailcode"))
			{
				Add("preferredemailcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredemailcode, SchemaName: PreferredEmailCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PreferredEmailCodeName
	{
		get
		{
			return TryGetValue("preferredemailcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Phone, SchemaName: PreferredPhoneCode, IntroducedVersion: 5.0.0.0.  Description: Preferred phone number for the user.</summary>
	[JsonIgnore]
	public string? PreferredPhoneCodeFormattedValue
	{
		get
		{
			return TryGetValue("preferredphonecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Phone, SchemaName: PreferredPhoneCode, IntroducedVersion: 5.0.0.0.  Description: Preferred phone number for the user.</summary>
	[JsonIgnore]
	public int? PreferredPhoneCode
	{
		get
		{
			return TryGetValue("preferredphonecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredphonecode") is false || Remove("preferredphonecode"))
			{
				Add("preferredphonecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredphonecode, SchemaName: PreferredPhoneCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PreferredPhoneCodeName
	{
		get
		{
			return TryGetValue("preferredphonecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process, SchemaName: ProcessId, IntroducedVersion: 6.0.0.0.  Description: Shows the ID of the process.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the user.</summary>
	[JsonIgnore]
	public string? QueueIdFormattedValue
	{
		get
		{
			return TryGetValue("_queueid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the user.</summary>
	[JsonIgnore]
	public Guid? QueueId
	{
		get
		{
			return TryGetValue("_queueid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the user.</summary>
	[JsonIgnore]
	public Guid? QueueId_queue
	{
		set
		{
			if (ContainsKey("queueid_queue@odata.bind") is false || Remove("queueid_queue@odata.bind"))
			{
				if (value is not null)
				{
					Add("queueid_queue@odata.bind", $"({value})");
				}
				else
				{
					Add("_queueid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: queueid, Format: Text, MaxLength: 400, SchemaName: QueueIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? QueueIdName
	{
		get
		{
			return TryGetValue("queueidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("queueidname") is false || Remove("queueidname"))
			{
				Add("queueidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Salutation, Format: Text, MaxLength: 20, SchemaName: Salutation, IntroducedVersion: 5.0.0.0.  Description: Salutation for correspondence with the user.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Restricted Access Mode, SchemaName: SetupUser, IntroducedVersion: 5.0.0.0.  Description: Check if user is a setup user.</summary>
	[JsonIgnore]
	public string? SetupUserFormattedValue
	{
		get
		{
			return TryGetValue("setupuser@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Restricted Access Mode, SchemaName: SetupUser, IntroducedVersion: 5.0.0.0.  Description: Check if user is a setup user.</summary>
	[JsonIgnore]
	public bool? SetupUser
	{
		get
		{
			return TryGetValue("setupuser", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("setupuser") is false || Remove("setupuser"))
			{
				Add("setupuser", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: setupuser, SchemaName: SetupUserName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? SetupUserName
	{
		get
		{
			return TryGetValue("setupusername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: SharePoint Email Address, Format: Text, MaxLength: 1024, SchemaName: SharePointEmailAddress, IntroducedVersion: 7.1.0.0.  Description: SharePoint Work Email Address</summary>
	[JsonIgnore]
	public string? SharePointEmailAddress
	{
		get
		{
			return TryGetValue("sharepointemailaddress", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("sharepointemailaddress") is false || Remove("sharepointemailaddress"))
			{
				Add("sharepointemailaddress", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site at which the user is located.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site at which the user is located.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: SiteId, IntroducedVersion: 5.0.0.0.  Description: Site at which the user is located.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Skills, Format: Text, MaxLength: 100, SchemaName: Skills, IntroducedVersion: 5.0.0.0.  Description: Skill set of the user.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Process Stage, SchemaName: StageId, IntroducedVersion: 6.0.0.0.  Description: Shows the ID of the stage.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: User, SchemaName: SystemUserId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the territory to which the user is assigned.</summary>
	[JsonIgnore]
	public string? TerritoryIdFormattedValue
	{
		get
		{
			return TryGetValue("_territoryid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the territory to which the user is assigned.</summary>
	[JsonIgnore]
	public Guid? TerritoryId
	{
		get
		{
			return TryGetValue("_territoryid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the territory to which the user is assigned.</summary>
	[JsonIgnore]
	public Guid? TerritoryId_territory
	{
		set
		{
			if (ContainsKey("territoryid_territory@odata.bind") is false || Remove("territoryid_territory@odata.bind"))
			{
				if (value is not null)
				{
					Add("territoryid_territory@odata.bind", $"({value})");
				}
				else
				{
					Add("_territoryid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: territoryid, Format: Text, MaxLength: 100, SchemaName: TerritoryIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? TerritoryIdName
	{
		get
		{
			return TryGetValue("territoryidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("territoryidname") is false || Remove("territoryidname"))
			{
				Add("territoryidname", value);
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Title, Format: Text, MaxLength: 128, SchemaName: Title, IntroducedVersion: 5.0.0.0.  Description: Title of the user.</summary>
	[JsonIgnore]
	public string? Title
	{
		get
		{
			return TryGetValue("title", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("title") is false || Remove("title"))
			{
				Add("title", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the systemuser.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the systemuser.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the systemuser.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: TraversedPath, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: User License Type, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: UserLicenseType, IntroducedVersion: 6.0.0.0.  Description: Shows the type of user license.</summary>
	[JsonIgnore]
	public int? UserLicenseType
	{
		get
		{
			return TryGetValue("userlicensetype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("userlicensetype") is false || Remove("userlicensetype"))
			{
				Add("userlicensetype", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: User PUID, Format: Text, MaxLength: 100, SchemaName: UserPuid, IntroducedVersion: 9.0.0.0.  Description:  User PUID User Identifiable Information</summary>
	[JsonIgnore]
	public string? UserPuid
	{
		get
		{
			return TryGetValue("userpuid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("userpuid") is false || Remove("userpuid"))
			{
				Add("userpuid", value);
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the user.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Windows Live ID, Format: Email, MaxLength: 1024, SchemaName: WindowsLiveID, IntroducedVersion: 5.0.0.0.  Description: Windows Live ID</summary>
	[JsonIgnore]
	public string? WindowsLiveID
	{
		get
		{
			return TryGetValue("windowsliveid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("windowsliveid") is false || Remove("windowsliveid"))
			{
				Add("windowsliveid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yammer Email, Format: Email, MaxLength: 200, SchemaName: YammerEmailAddress, IntroducedVersion: 5.0.0.0.  Description: User's Yammer login email address</summary>
	[JsonIgnore]
	public string? YammerEmailAddress
	{
		get
		{
			return TryGetValue("yammeremailaddress", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yammeremailaddress") is false || Remove("yammeremailaddress"))
			{
				Add("yammeremailaddress", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yammer User ID, Format: Text, MaxLength: 128, SchemaName: YammerUserId, IntroducedVersion: 5.0.0.0.  Description: User's Yammer ID</summary>
	[JsonIgnore]
	public string? YammerUserId
	{
		get
		{
			return TryGetValue("yammeruserid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yammeruserid") is false || Remove("yammeruserid"))
			{
				Add("yammeruserid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi First Name, Format: PhoneticGuide, MaxLength: 64, SchemaName: YomiFirstName, YomiOf: firstname, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Full Name, Format: PhoneticGuide, MaxLength: 200, SchemaName: YomiFullName, YomiOf: fullname, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Last Name, Format: PhoneticGuide, MaxLength: 64, SchemaName: YomiLastName, YomiOf: lastname, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Middle Name, Format: PhoneticGuide, MaxLength: 50, SchemaName: YomiMiddleName, YomiOf: middlename, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.</summary>
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

