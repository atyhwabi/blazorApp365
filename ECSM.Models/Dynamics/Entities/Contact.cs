namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Person with whom a business unit has a relationship, such as customer, supplier, and colleague.</summary>
public sealed partial class Contact : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contact is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contact is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contact is associated.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Role, SchemaName: AccountRoleCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.</summary>
	[JsonIgnore]
	public string? AccountRoleCodeFormattedValue
	{
		get
		{
			return TryGetValue("accountrolecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Role, SchemaName: AccountRoleCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.</summary>
	[JsonIgnore]
	public int? AccountRoleCode
	{
		get
		{
			return TryGetValue("accountrolecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountrolecode") is false || Remove("accountrolecode"))
			{
				Add("accountrolecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: accountrolecode, SchemaName: AccountRoleCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? AccountRoleCodeName
	{
		get
		{
			return TryGetValue("accountrolecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: City, Format: Text, MaxLength: 80, SchemaName: Address1_City, IntroducedVersion: 5.0.0.0.  Description: Type the city for the primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address1_Country, IntroducedVersion: 5.0.0.0.  Description: Type the country or region for the primary address.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Freight Terms, SchemaName: Address1_FreightTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the freight terms for the primary address to make sure shipping orders are processed correctly.</summary>
	[JsonIgnore]
	public string? Address1_FreightTermsCodeFormattedValue
	{
		get
		{
			return TryGetValue("address1_freighttermscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 1: Freight Terms, SchemaName: Address1_FreightTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the freight terms for the primary address to make sure shipping orders are processed correctly.</summary>
	[JsonIgnore]
	public int? Address1_FreightTermsCode
	{
		get
		{
			return TryGetValue("address1_freighttermscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_freighttermscode") is false || Remove("address1_freighttermscode"))
			{
				Add("address1_freighttermscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address1_freighttermscode, SchemaName: Address1_FreightTermsCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? Address1_FreightTermsCodeName
	{
		get
		{
			return TryGetValue("address1_freighttermscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Street 1, Format: Text, MaxLength: 250, SchemaName: Address1_Line1, IntroducedVersion: 5.0.0.0.  Description: Type the first line of the primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Street 2, Format: Text, MaxLength: 250, SchemaName: Address1_Line2, IntroducedVersion: 5.0.0.0.  Description: Type the second line of the primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Street 3, Format: Text, MaxLength: 250, SchemaName: Address1_Line3, IntroducedVersion: 5.0.0.0.  Description: Type the third line of the primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Name, Format: Text, MaxLength: 200, SchemaName: Address1_Name, IntroducedVersion: 5.0.0.0.  Description: Type a descriptive name for the primary address, such as Corporate Headquarters.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address1_PostalCode, IntroducedVersion: 5.0.0.0.  Description: Type the ZIP Code or postal code for the primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Primary Contact Name, Format: Text, MaxLength: 100, SchemaName: Address1_PrimaryContactName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the main contact at the account's primary address.</summary>
	[JsonIgnore]
	public string? Address1_PrimaryContactName
	{
		get
		{
			return TryGetValue("address1_primarycontactname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address1_primarycontactname") is false || Remove("address1_primarycontactname"))
			{
				Add("address1_primarycontactname", value);
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: State/Province, Format: Text, MaxLength: 50, SchemaName: Address1_StateOrProvince, IntroducedVersion: 5.0.0.0.  Description: Type the state or province of the primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 1: Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number associated with the primary address.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Freight Terms, SchemaName: Address2_FreightTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the freight terms for the secondary address to make sure shipping orders are processed correctly.</summary>
	[JsonIgnore]
	public string? Address2_FreightTermsCodeFormattedValue
	{
		get
		{
			return TryGetValue("address2_freighttermscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 2: Freight Terms, SchemaName: Address2_FreightTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the freight terms for the secondary address to make sure shipping orders are processed correctly.</summary>
	[JsonIgnore]
	public int? Address2_FreightTermsCode
	{
		get
		{
			return TryGetValue("address2_freighttermscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_freighttermscode") is false || Remove("address2_freighttermscode"))
			{
				Add("address2_freighttermscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address2_freighttermscode, SchemaName: Address2_FreightTermsCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? Address2_FreightTermsCodeName
	{
		get
		{
			return TryGetValue("address2_freighttermscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Primary Contact Name, Format: Text, MaxLength: 100, SchemaName: Address2_PrimaryContactName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the main contact at the account's secondary address.</summary>
	[JsonIgnore]
	public string? Address2_PrimaryContactName
	{
		get
		{
			return TryGetValue("address2_primarycontactname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address2_primarycontactname") is false || Remove("address2_primarycontactname"))
			{
				Add("address2_primarycontactname", value);
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Address 3: ID, SchemaName: Address3_AddressId, IntroducedVersion: 7.0.0.0.  Description: Unique identifier for address 3.</summary>
	[JsonIgnore]
	public Guid? Address3_AddressId
	{
		get
		{
			return TryGetValue("address3_addressid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_addressid") is false || Remove("address3_addressid"))
			{
				Add("address3_addressid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Address Type, SchemaName: Address3_AddressTypeCode, IntroducedVersion: 7.0.0.0.  Description: Select the third address type.</summary>
	[JsonIgnore]
	public string? Address3_AddressTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("address3_addresstypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Address Type, SchemaName: Address3_AddressTypeCode, IntroducedVersion: 7.0.0.0.  Description: Select the third address type.</summary>
	[JsonIgnore]
	public int? Address3_AddressTypeCode
	{
		get
		{
			return TryGetValue("address3_addresstypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_addresstypecode") is false || Remove("address3_addresstypecode"))
			{
				Add("address3_addresstypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address3_addresstypecode, SchemaName: Address3_AddressTypeCodeName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? Address3_AddressTypeCodeName
	{
		get
		{
			return TryGetValue("address3_addresstypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: City, Format: Text, MaxLength: 80, SchemaName: Address3_City, IntroducedVersion: 7.0.0.0.  Description: Type the city for the 3rd address.</summary>
	[JsonIgnore]
	public string? Address3_City
	{
		get
		{
			return TryGetValue("address3_city", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_city") is false || Remove("address3_city"))
			{
				Add("address3_city", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Address 3, Format: TextArea, MaxLength: 1000, SchemaName: Address3_Composite, IntroducedVersion: 7.0.0.0.  Description: Shows the complete third address.</summary>
	[JsonIgnore]
	public string? Address3_Composite
	{
		get
		{
			return TryGetValue("address3_composite", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_composite") is false || Remove("address3_composite"))
			{
				Add("address3_composite", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Country/Region, Format: Text, MaxLength: 80, SchemaName: Address3_Country, IntroducedVersion: 7.0.0.0.  Description: the country or region for the 3rd address.</summary>
	[JsonIgnore]
	public string? Address3_Country
	{
		get
		{
			return TryGetValue("address3_country", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_country") is false || Remove("address3_country"))
			{
				Add("address3_country", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: County, Format: Text, MaxLength: 50, SchemaName: Address3_County, IntroducedVersion: 7.0.0.0.  Description: Type the county for the third address.</summary>
	[JsonIgnore]
	public string? Address3_County
	{
		get
		{
			return TryGetValue("address3_county", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_county") is false || Remove("address3_county"))
			{
				Add("address3_county", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Fax, Format: Text, MaxLength: 50, SchemaName: Address3_Fax, IntroducedVersion: 7.0.0.0.  Description: Type the fax number associated with the third address.</summary>
	[JsonIgnore]
	public string? Address3_Fax
	{
		get
		{
			return TryGetValue("address3_fax", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_fax") is false || Remove("address3_fax"))
			{
				Add("address3_fax", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Freight Terms, SchemaName: Address3_FreightTermsCode, IntroducedVersion: 7.0.0.0.  Description: Select the freight terms for the third address to make sure shipping orders are processed correctly.</summary>
	[JsonIgnore]
	public string? Address3_FreightTermsCodeFormattedValue
	{
		get
		{
			return TryGetValue("address3_freighttermscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Freight Terms, SchemaName: Address3_FreightTermsCode, IntroducedVersion: 7.0.0.0.  Description: Select the freight terms for the third address to make sure shipping orders are processed correctly.</summary>
	[JsonIgnore]
	public int? Address3_FreightTermsCode
	{
		get
		{
			return TryGetValue("address3_freighttermscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_freighttermscode") is false || Remove("address3_freighttermscode"))
			{
				Add("address3_freighttermscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address3_freighttermscode, SchemaName: Address3_FreightTermsCodeName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? Address3_FreightTermsCodeName
	{
		get
		{
			return TryGetValue("address3_freighttermscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 3: Latitude, Precision: 5, MinValue: -90, MaxValue: 90, SchemaName: Address3_Latitude, IntroducedVersion: 7.0.0.0.  Description: Type the latitude value for the third address for use in mapping and other applications.</summary>
	[JsonIgnore]
	public double? Address3_Latitude
	{
		get
		{
			return TryGetValue("address3_latitude", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_latitude") is false || Remove("address3_latitude"))
			{
				Add("address3_latitude", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Street 1, Format: Text, MaxLength: 250, SchemaName: Address3_Line1, IntroducedVersion: 7.0.0.0.  Description: the first line of the 3rd address.</summary>
	[JsonIgnore]
	public string? Address3_Line1
	{
		get
		{
			return TryGetValue("address3_line1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_line1") is false || Remove("address3_line1"))
			{
				Add("address3_line1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Street 2, Format: Text, MaxLength: 250, SchemaName: Address3_Line2, IntroducedVersion: 7.0.0.0.  Description: the second line of the 3rd address.</summary>
	[JsonIgnore]
	public string? Address3_Line2
	{
		get
		{
			return TryGetValue("address3_line2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_line2") is false || Remove("address3_line2"))
			{
				Add("address3_line2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: Street 3, Format: Text, MaxLength: 250, SchemaName: Address3_Line3, IntroducedVersion: 7.0.0.0.  Description: the third line of the 3rd address.</summary>
	[JsonIgnore]
	public string? Address3_Line3
	{
		get
		{
			return TryGetValue("address3_line3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_line3") is false || Remove("address3_line3"))
			{
				Add("address3_line3", value);
			}
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Address 3: Longitude, Precision: 5, MinValue: -180, MaxValue: 180, SchemaName: Address3_Longitude, IntroducedVersion: 7.0.0.0.  Description: Type the longitude value for the third address for use in mapping and other applications.</summary>
	[JsonIgnore]
	public double? Address3_Longitude
	{
		get
		{
			return TryGetValue("address3_longitude", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_longitude") is false || Remove("address3_longitude"))
			{
				Add("address3_longitude", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Name, Format: Text, MaxLength: 200, SchemaName: Address3_Name, IntroducedVersion: 7.0.0.0.  Description: Type a descriptive name for the third address, such as Corporate Headquarters.</summary>
	[JsonIgnore]
	public string? Address3_Name
	{
		get
		{
			return TryGetValue("address3_name", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_name") is false || Remove("address3_name"))
			{
				Add("address3_name", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: ZIP/Postal Code, Format: Text, MaxLength: 20, SchemaName: Address3_PostalCode, IntroducedVersion: 7.0.0.0.  Description: the ZIP Code or postal code for the 3rd address.</summary>
	[JsonIgnore]
	public string? Address3_PostalCode
	{
		get
		{
			return TryGetValue("address3_postalcode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_postalcode") is false || Remove("address3_postalcode"))
			{
				Add("address3_postalcode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Post Office Box, Format: Text, MaxLength: 20, SchemaName: Address3_PostOfficeBox, IntroducedVersion: 7.0.0.0.  Description: the post office box number of the 3rd address.</summary>
	[JsonIgnore]
	public string? Address3_PostOfficeBox
	{
		get
		{
			return TryGetValue("address3_postofficebox", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_postofficebox") is false || Remove("address3_postofficebox"))
			{
				Add("address3_postofficebox", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Primary Contact Name, Format: Text, MaxLength: 100, SchemaName: Address3_PrimaryContactName, IntroducedVersion: 7.0.0.0.  Description: Type the name of the main contact at the account's third address.</summary>
	[JsonIgnore]
	public string? Address3_PrimaryContactName
	{
		get
		{
			return TryGetValue("address3_primarycontactname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_primarycontactname") is false || Remove("address3_primarycontactname"))
			{
				Add("address3_primarycontactname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Shipping Method, SchemaName: Address3_ShippingMethodCode, IntroducedVersion: 7.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public string? Address3_ShippingMethodCodeFormattedValue
	{
		get
		{
			return TryGetValue("address3_shippingmethodcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Address 3: Shipping Method, SchemaName: Address3_ShippingMethodCode, IntroducedVersion: 7.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public int? Address3_ShippingMethodCode
	{
		get
		{
			return TryGetValue("address3_shippingmethodcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_shippingmethodcode") is false || Remove("address3_shippingmethodcode"))
			{
				Add("address3_shippingmethodcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: address3_shippingmethodcode, SchemaName: Address3_ShippingMethodCodeName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public object? Address3_ShippingMethodCodeName
	{
		get
		{
			return TryGetValue("address3_shippingmethodcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address3: State/Province, Format: Text, MaxLength: 50, SchemaName: Address3_StateOrProvince, IntroducedVersion: 7.0.0.0.  Description: the state or province of the third address.</summary>
	[JsonIgnore]
	public string? Address3_StateOrProvince
	{
		get
		{
			return TryGetValue("address3_stateorprovince", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_stateorprovince") is false || Remove("address3_stateorprovince"))
			{
				Add("address3_stateorprovince", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Telephone1, Format: Text, MaxLength: 50, SchemaName: Address3_Telephone1, IntroducedVersion: 7.0.0.0.  Description: Type the main phone number associated with the third address.</summary>
	[JsonIgnore]
	public string? Address3_Telephone1
	{
		get
		{
			return TryGetValue("address3_telephone1", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_telephone1") is false || Remove("address3_telephone1"))
			{
				Add("address3_telephone1", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Telephone2, Format: Text, MaxLength: 50, SchemaName: Address3_Telephone2, IntroducedVersion: 7.0.0.0.  Description: Type a second phone number associated with the third address.</summary>
	[JsonIgnore]
	public string? Address3_Telephone2
	{
		get
		{
			return TryGetValue("address3_telephone2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_telephone2") is false || Remove("address3_telephone2"))
			{
				Add("address3_telephone2", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: Telephone3, Format: Text, MaxLength: 50, SchemaName: Address3_Telephone3, IntroducedVersion: 7.0.0.0.  Description: Type a third phone number associated with the primary address.</summary>
	[JsonIgnore]
	public string? Address3_Telephone3
	{
		get
		{
			return TryGetValue("address3_telephone3", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_telephone3") is false || Remove("address3_telephone3"))
			{
				Add("address3_telephone3", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 3: UPS Zone, Format: Text, MaxLength: 4, SchemaName: Address3_UPSZone, IntroducedVersion: 7.0.0.0.  Description: Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</summary>
	[JsonIgnore]
	public string? Address3_UPSZone
	{
		get
		{
			return TryGetValue("address3_upszone", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_upszone") is false || Remove("address3_upszone"))
			{
				Add("address3_upszone", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Address 3: UTC Offset, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Address3_UTCOffset, IntroducedVersion: 7.0.0.0.  Description: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</summary>
	[JsonIgnore]
	public int? Address3_UTCOffset
	{
		get
		{
			return TryGetValue("address3_utcoffset", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("address3_utcoffset") is false || Remove("address3_utcoffset"))
			{
				Add("address3_utcoffset", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Confirm Remove Password, SchemaName: adx_ConfirmRemovePassword, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? adx_ConfirmRemovePasswordFormattedValue
	{
		get
		{
			return TryGetValue("adx_confirmremovepassword@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Confirm Remove Password, SchemaName: adx_ConfirmRemovePassword, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public bool? adx_ConfirmRemovePassword
	{
		get
		{
			return TryGetValue("adx_confirmremovepassword", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_confirmremovepassword") is false || Remove("adx_confirmremovepassword"))
			{
				Add("adx_confirmremovepassword", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_confirmremovepassword, SchemaName: adx_confirmremovepasswordName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_confirmremovepasswordName
	{
		get
		{
			return TryGetValue("adx_confirmremovepasswordname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Created By IP Address, Format: Text, MaxLength: 100, SchemaName: Adx_CreatedByIPAddress, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? Adx_CreatedByIPAddress
	{
		get
		{
			return TryGetValue("adx_createdbyipaddress", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_createdbyipaddress") is false || Remove("adx_createdbyipaddress"))
			{
				Add("adx_createdbyipaddress", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Created By Username, Format: Text, MaxLength: 100, SchemaName: Adx_CreatedByUsername, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? Adx_CreatedByUsername
	{
		get
		{
			return TryGetValue("adx_createdbyusername", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_createdbyusername") is false || Remove("adx_createdbyusername"))
			{
				Add("adx_createdbyusername", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Access Failed Count, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: adx_identity_accessfailedcount, IntroducedVersion: 1.0.0.0.  Description: Shows the current count of failed password attempts for the contact.</summary>
	[JsonIgnore]
	public int? adx_identity_accessfailedcount
	{
		get
		{
			return TryGetValue("adx_identity_accessfailedcount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_accessfailedcount") is false || Remove("adx_identity_accessfailedcount"))
			{
				Add("adx_identity_accessfailedcount", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Email Confirmed, SchemaName: adx_identity_emailaddress1confirmed, IntroducedVersion: 1.0.0.0.  Description: Determines if the email is confirmed by the contact.</summary>
	[JsonIgnore]
	public string? adx_identity_emailaddress1confirmedFormattedValue
	{
		get
		{
			return TryGetValue("adx_identity_emailaddress1confirmed@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Email Confirmed, SchemaName: adx_identity_emailaddress1confirmed, IntroducedVersion: 1.0.0.0.  Description: Determines if the email is confirmed by the contact.</summary>
	[JsonIgnore]
	public bool? adx_identity_emailaddress1confirmed
	{
		get
		{
			return TryGetValue("adx_identity_emailaddress1confirmed", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_emailaddress1confirmed") is false || Remove("adx_identity_emailaddress1confirmed"))
			{
				Add("adx_identity_emailaddress1confirmed", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_emailaddress1confirmed, SchemaName: adx_identity_emailaddress1confirmedName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_identity_emailaddress1confirmedName
	{
		get
		{
			return TryGetValue("adx_identity_emailaddress1confirmedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Successful Login, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_identity_lastsuccessfullogin, IntroducedVersion: 1.0.0.0.  Description: Indicates the last date and time the user successfully signed in to a portal.</summary>
	[JsonIgnore]
	public DateTime? adx_identity_lastsuccessfullogin
	{
		get
		{
			return TryGetValue("adx_identity_lastsuccessfullogin", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_lastsuccessfullogin") is false || Remove("adx_identity_lastsuccessfullogin"))
			{
				Add("adx_identity_lastsuccessfullogin", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Local Login Disabled, SchemaName: adx_identity_locallogindisabled, IntroducedVersion: 1.0.0.0.  Description: Indicates that the contact can no longer sign in to the portal using the local account.</summary>
	[JsonIgnore]
	public string? adx_identity_locallogindisabledFormattedValue
	{
		get
		{
			return TryGetValue("adx_identity_locallogindisabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Local Login Disabled, SchemaName: adx_identity_locallogindisabled, IntroducedVersion: 1.0.0.0.  Description: Indicates that the contact can no longer sign in to the portal using the local account.</summary>
	[JsonIgnore]
	public bool? adx_identity_locallogindisabled
	{
		get
		{
			return TryGetValue("adx_identity_locallogindisabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_locallogindisabled") is false || Remove("adx_identity_locallogindisabled"))
			{
				Add("adx_identity_locallogindisabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_locallogindisabled, SchemaName: adx_identity_locallogindisabledName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_identity_locallogindisabledName
	{
		get
		{
			return TryGetValue("adx_identity_locallogindisabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Lockout Enabled, SchemaName: adx_identity_lockoutenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if this contact will track failed access attempts and become locked after too many failed attempts. To prevent the contact from becoming locked, you can disable this setting.</summary>
	[JsonIgnore]
	public string? adx_identity_lockoutenabledFormattedValue
	{
		get
		{
			return TryGetValue("adx_identity_lockoutenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Lockout Enabled, SchemaName: adx_identity_lockoutenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if this contact will track failed access attempts and become locked after too many failed attempts. To prevent the contact from becoming locked, you can disable this setting.</summary>
	[JsonIgnore]
	public bool? adx_identity_lockoutenabled
	{
		get
		{
			return TryGetValue("adx_identity_lockoutenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_lockoutenabled") is false || Remove("adx_identity_lockoutenabled"))
			{
				Add("adx_identity_lockoutenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_lockoutenabled, SchemaName: adx_identity_lockoutenabledName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_identity_lockoutenabledName
	{
		get
		{
			return TryGetValue("adx_identity_lockoutenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Lockout End Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_identity_lockoutenddate, IntroducedVersion: 1.0.0.0.  Description: Shows the moment in time when the locked contact becomes unlocked again.</summary>
	[JsonIgnore]
	public DateTime? adx_identity_lockoutenddate
	{
		get
		{
			return TryGetValue("adx_identity_lockoutenddate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_lockoutenddate") is false || Remove("adx_identity_lockoutenddate"))
			{
				Add("adx_identity_lockoutenddate", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Login Enabled, SchemaName: adx_identity_logonenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if web authentication is enabled for the contact.</summary>
	[JsonIgnore]
	public string? adx_identity_logonenabledFormattedValue
	{
		get
		{
			return TryGetValue("adx_identity_logonenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Login Enabled, SchemaName: adx_identity_logonenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if web authentication is enabled for the contact.</summary>
	[JsonIgnore]
	public bool? adx_identity_logonenabled
	{
		get
		{
			return TryGetValue("adx_identity_logonenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_logonenabled") is false || Remove("adx_identity_logonenabled"))
			{
				Add("adx_identity_logonenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_logonenabled, SchemaName: adx_identity_logonenabledName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_identity_logonenabledName
	{
		get
		{
			return TryGetValue("adx_identity_logonenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Mobile Phone Confirmed, SchemaName: adx_identity_mobilephoneconfirmed, IntroducedVersion: 1.0.0.0.  Description: Determines if the phone number is confirmed by the contact.</summary>
	[JsonIgnore]
	public string? adx_identity_mobilephoneconfirmedFormattedValue
	{
		get
		{
			return TryGetValue("adx_identity_mobilephoneconfirmed@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Mobile Phone Confirmed, SchemaName: adx_identity_mobilephoneconfirmed, IntroducedVersion: 1.0.0.0.  Description: Determines if the phone number is confirmed by the contact.</summary>
	[JsonIgnore]
	public bool? adx_identity_mobilephoneconfirmed
	{
		get
		{
			return TryGetValue("adx_identity_mobilephoneconfirmed", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_mobilephoneconfirmed") is false || Remove("adx_identity_mobilephoneconfirmed"))
			{
				Add("adx_identity_mobilephoneconfirmed", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_mobilephoneconfirmed, SchemaName: adx_identity_mobilephoneconfirmedName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_identity_mobilephoneconfirmedName
	{
		get
		{
			return TryGetValue("adx_identity_mobilephoneconfirmedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: New Password Input, Format: Text, MaxLength: 100, SchemaName: adx_identity_newpassword, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? adx_identity_newpassword
	{
		get
		{
			return TryGetValue("adx_identity_newpassword", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_newpassword") is false || Remove("adx_identity_newpassword"))
			{
				Add("adx_identity_newpassword", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Password Hash, Format: Text, MaxLength: 128, SchemaName: adx_identity_passwordhash, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? adx_identity_passwordhash
	{
		get
		{
			return TryGetValue("adx_identity_passwordhash", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_passwordhash") is false || Remove("adx_identity_passwordhash"))
			{
				Add("adx_identity_passwordhash", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Security Stamp, Format: Text, MaxLength: 100, SchemaName: adx_identity_securitystamp, IntroducedVersion: 1.0.0.0.  Description: A token used to manage the web authentication session.</summary>
	[JsonIgnore]
	public string? adx_identity_securitystamp
	{
		get
		{
			return TryGetValue("adx_identity_securitystamp", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_securitystamp") is false || Remove("adx_identity_securitystamp"))
			{
				Add("adx_identity_securitystamp", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Two Factor Enabled, SchemaName: adx_identity_twofactorenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if two-factor authentication is enabled for the contact.</summary>
	[JsonIgnore]
	public string? adx_identity_twofactorenabledFormattedValue
	{
		get
		{
			return TryGetValue("adx_identity_twofactorenabled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Two Factor Enabled, SchemaName: adx_identity_twofactorenabled, IntroducedVersion: 1.0.0.0.  Description: Determines if two-factor authentication is enabled for the contact.</summary>
	[JsonIgnore]
	public bool? adx_identity_twofactorenabled
	{
		get
		{
			return TryGetValue("adx_identity_twofactorenabled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_twofactorenabled") is false || Remove("adx_identity_twofactorenabled"))
			{
				Add("adx_identity_twofactorenabled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_identity_twofactorenabled, SchemaName: adx_identity_twofactorenabledName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_identity_twofactorenabledName
	{
		get
		{
			return TryGetValue("adx_identity_twofactorenabledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: User Name, Format: Text, MaxLength: 100, SchemaName: adx_identity_username, IntroducedVersion: 1.0.0.0.  Description: Shows the user identity for local web authentication.</summary>
	[JsonIgnore]
	public string? adx_identity_username
	{
		get
		{
			return TryGetValue("adx_identity_username", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_identity_username") is false || Remove("adx_identity_username"))
			{
				Add("adx_identity_username", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Modified By IP Address, Format: Text, MaxLength: 100, SchemaName: Adx_ModifiedByIPAddress, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? Adx_ModifiedByIPAddress
	{
		get
		{
			return TryGetValue("adx_modifiedbyipaddress", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_modifiedbyipaddress") is false || Remove("adx_modifiedbyipaddress"))
			{
				Add("adx_modifiedbyipaddress", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Modified By Username, Format: Text, MaxLength: 100, SchemaName: Adx_ModifiedByUsername, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? Adx_ModifiedByUsername
	{
		get
		{
			return TryGetValue("adx_modifiedbyusername", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_modifiedbyusername") is false || Remove("adx_modifiedbyusername"))
			{
				Add("adx_modifiedbyusername", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Organization Name, Format: Text, MaxLength: 250, SchemaName: Adx_OrganizationName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? Adx_OrganizationName
	{
		get
		{
			return TryGetValue("adx_organizationname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_organizationname") is false || Remove("adx_organizationname"))
			{
				Add("adx_organizationname", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Preferred LCID (Deprecated), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: adx_preferredlcid, IntroducedVersion: 1.0.0.0.  Description: User’s preferred portal LCID</summary>
	[JsonIgnore]
	public int? adx_preferredlcid
	{
		get
		{
			return TryGetValue("adx_preferredlcid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_preferredlcid") is false || Remove("adx_preferredlcid"))
			{
				Add("adx_preferredlcid", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Profile Alert, SchemaName: adx_profilealert, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? adx_profilealertFormattedValue
	{
		get
		{
			return TryGetValue("adx_profilealert@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Profile Alert, SchemaName: adx_profilealert, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public bool? adx_profilealert
	{
		get
		{
			return TryGetValue("adx_profilealert", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_profilealert") is false || Remove("adx_profilealert"))
			{
				Add("adx_profilealert", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Profile Alert Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_profilealertdate, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public DateTime? adx_profilealertdate
	{
		get
		{
			return TryGetValue("adx_profilealertdate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_profilealertdate") is false || Remove("adx_profilealertdate"))
			{
				Add("adx_profilealertdate", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Profile Alert Instructions, Format: Text, MaxLength: 4096, SchemaName: adx_profilealertinstructions, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? adx_profilealertinstructions
	{
		get
		{
			return TryGetValue("adx_profilealertinstructions", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_profilealertinstructions") is false || Remove("adx_profilealertinstructions"))
			{
				Add("adx_profilealertinstructions", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_profilealert, SchemaName: adx_profilealertName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_profilealertName
	{
		get
		{
			return TryGetValue("adx_profilealertname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Profile Is Anonymous, SchemaName: Adx_ProfileIsAnonymous, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? Adx_ProfileIsAnonymousFormattedValue
	{
		get
		{
			return TryGetValue("adx_profileisanonymous@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Profile Is Anonymous, SchemaName: Adx_ProfileIsAnonymous, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public bool? Adx_ProfileIsAnonymous
	{
		get
		{
			return TryGetValue("adx_profileisanonymous", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_profileisanonymous") is false || Remove("adx_profileisanonymous"))
			{
				Add("adx_profileisanonymous", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: adx_profileisanonymous, SchemaName: adx_profileisanonymousName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? adx_profileisanonymousName
	{
		get
		{
			return TryGetValue("adx_profileisanonymousname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Profile Last Activity, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: Adx_ProfileLastActivity, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public DateTime? Adx_ProfileLastActivity
	{
		get
		{
			return TryGetValue("adx_profilelastactivity", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_profilelastactivity") is false || Remove("adx_profilelastactivity"))
			{
				Add("adx_profilelastactivity", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Profile Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: adx_profilemodifiedon, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public DateTime? adx_profilemodifiedon
	{
		get
		{
			return TryGetValue("adx_profilemodifiedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_profilemodifiedon") is false || Remove("adx_profilemodifiedon"))
			{
				Add("adx_profilemodifiedon", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Public Profile Copy, Format: Text, MaxLength: 64000, SchemaName: adx_PublicProfileCopy, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? adx_PublicProfileCopy
	{
		get
		{
			return TryGetValue("adx_publicprofilecopy", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_publicprofilecopy") is false || Remove("adx_publicprofilecopy"))
			{
				Add("adx_publicprofilecopy", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: Adx_TimeZone, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public int? Adx_TimeZone
	{
		get
		{
			return TryGetValue("adx_timezone", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("adx_timezone") is false || Remove("adx_timezone"))
			{
				Add("adx_timezone", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging30, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public string? Aging30FormattedValue
	{
		get
		{
			return TryGetValue("aging30@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging30, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public decimal? Aging30
	{
		get
		{
			return TryGetValue("aging30", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("aging30") is false || Remove("aging30"))
			{
				Add("aging30", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30 (Base), CalculationOf: aging30, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging30_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public string? Aging30_BaseFormattedValue
	{
		get
		{
			return TryGetValue("aging30_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30 (Base), CalculationOf: aging30, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging30_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public decimal? Aging30_Base
	{
		get
		{
			return TryGetValue("aging30_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("aging30_base") is false || Remove("aging30_base"))
			{
				Add("aging30_base", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging60, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public string? Aging60FormattedValue
	{
		get
		{
			return TryGetValue("aging60@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging60, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public decimal? Aging60
	{
		get
		{
			return TryGetValue("aging60", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("aging60") is false || Remove("aging60"))
			{
				Add("aging60", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60 (Base), CalculationOf: aging60, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging60_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public string? Aging60_BaseFormattedValue
	{
		get
		{
			return TryGetValue("aging60_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60 (Base), CalculationOf: aging60, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging60_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public decimal? Aging60_Base
	{
		get
		{
			return TryGetValue("aging60_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("aging60_base") is false || Remove("aging60_base"))
			{
				Add("aging60_base", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging90, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public string? Aging90FormattedValue
	{
		get
		{
			return TryGetValue("aging90@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Aging90, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public decimal? Aging90
	{
		get
		{
			return TryGetValue("aging90", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("aging90") is false || Remove("aging90"))
			{
				Add("aging90", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90 (Base), CalculationOf: aging90, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging90_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public string? Aging90_BaseFormattedValue
	{
		get
		{
			return TryGetValue("aging90_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90 (Base), CalculationOf: aging90, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging90_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public decimal? Aging90_Base
	{
		get
		{
			return TryGetValue("aging90_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("aging90_base") is false || Remove("aging90_base"))
			{
				Add("aging90_base", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Anniversary, DateTimeBehavior: DateOnly, Format: DateOnly, SchemaName: Anniversary, IntroducedVersion: 5.0.0.0.  Description: Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.</summary>
	[JsonIgnore]
	public DateTime? Anniversary
	{
		get
		{
			return TryGetValue("anniversary", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("anniversary") is false || Remove("anniversary"))
			{
				Add("anniversary", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Income, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: AnnualIncome, IntroducedVersion: 5.0.0.0.  Description: Type the contact's annual income for use in profiling and financial analysis.</summary>
	[JsonIgnore]
	public string? AnnualIncomeFormattedValue
	{
		get
		{
			return TryGetValue("annualincome@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Income, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: AnnualIncome, IntroducedVersion: 5.0.0.0.  Description: Type the contact's annual income for use in profiling and financial analysis.</summary>
	[JsonIgnore]
	public decimal? AnnualIncome
	{
		get
		{
			return TryGetValue("annualincome", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("annualincome") is false || Remove("annualincome"))
			{
				Add("annualincome", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Income (Base), CalculationOf: annualincome, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: AnnualIncome_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public string? AnnualIncome_BaseFormattedValue
	{
		get
		{
			return TryGetValue("annualincome_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Income (Base), CalculationOf: annualincome, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: AnnualIncome_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public decimal? AnnualIncome_Base
	{
		get
		{
			return TryGetValue("annualincome_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("annualincome_base") is false || Remove("annualincome_base"))
			{
				Add("annualincome_base", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Assistant, Format: Text, MaxLength: 100, SchemaName: AssistantName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the contact's assistant.</summary>
	[JsonIgnore]
	public string? AssistantName
	{
		get
		{
			return TryGetValue("assistantname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("assistantname") is false || Remove("assistantname"))
			{
				Add("assistantname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Assistant Phone, Format: Text, MaxLength: 50, SchemaName: AssistantPhone, IntroducedVersion: 5.0.0.0.  Description: Type the phone number for the contact's assistant.</summary>
	[JsonIgnore]
	public string? AssistantPhone
	{
		get
		{
			return TryGetValue("assistantphone", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("assistantphone") is false || Remove("assistantphone"))
			{
				Add("assistantphone", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Birthday, DateTimeBehavior: DateOnly, Format: DateOnly, SchemaName: BirthDate, IntroducedVersion: 5.0.0.0.  Description: Enter the contact's birthday for use in customer gift programs or other communications.</summary>
	[JsonIgnore]
	public DateTime? BirthDate
	{
		get
		{
			return TryGetValue("birthdate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("birthdate") is false || Remove("birthdate"))
			{
				Add("birthdate", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Business Phone 2, Format: Text, MaxLength: 50, SchemaName: Business2, IntroducedVersion: 7.0.0.0.  Description: Type a second business phone number for this contact.</summary>
	[JsonIgnore]
	public string? Business2
	{
		get
		{
			return TryGetValue("business2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("business2") is false || Remove("business2"))
			{
				Add("business2", value);
			}
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Callback Number, Format: Text, MaxLength: 50, SchemaName: Callback, IntroducedVersion: 7.0.0.0.  Description: Type a callback phone number for this contact.</summary>
	[JsonIgnore]
	public string? Callback
	{
		get
		{
			return TryGetValue("callback", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("callback") is false || Remove("callback"))
			{
				Add("callback", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Children's Names, Format: Text, MaxLength: 255, SchemaName: ChildrensNames, IntroducedVersion: 5.0.0.0.  Description: Type the names of the contact's children for reference in communications and client programs.</summary>
	[JsonIgnore]
	public string? ChildrensNames
	{
		get
		{
			return TryGetValue("childrensnames", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("childrensnames") is false || Remove("childrensnames"))
			{
				Add("childrensnames", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Company Phone, Format: Text, MaxLength: 50, SchemaName: Company, IntroducedVersion: 7.0.0.0.  Description: Type the company phone of the contact.</summary>
	[JsonIgnore]
	public string? Company
	{
		get
		{
			return TryGetValue("company", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("company") is false || Remove("company"))
			{
				Add("company", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Contact, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact.</summary>
	[JsonIgnore]
	public Guid? ContactId
	{
		get
		{
			return TryGetValue("contactid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("contactid") is false || Remove("contactid"))
			{
				Add("contactid", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (External Party), Format: None, SchemaName: CreatedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyYomiName, YomiOf: createdbyexternalpartyname, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: CreditLimit, IntroducedVersion: 5.0.0.0.  Description: Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.</summary>
	[JsonIgnore]
	public string? CreditLimitFormattedValue
	{
		get
		{
			return TryGetValue("creditlimit@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: CreditLimit, IntroducedVersion: 5.0.0.0.  Description: Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.</summary>
	[JsonIgnore]
	public decimal? CreditLimit
	{
		get
		{
			return TryGetValue("creditlimit", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit (Base), CalculationOf: creditlimit, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: CreditLimit_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public string? CreditLimit_BaseFormattedValue
	{
		get
		{
			return TryGetValue("creditlimit_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit (Base), CalculationOf: creditlimit, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: CreditLimit_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.</summary>
	[JsonIgnore]
	public decimal? CreditLimit_Base
	{
		get
		{
			return TryGetValue("creditlimit_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("creditlimit_base") is false || Remove("creditlimit_base"))
			{
				Add("creditlimit_base", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Credit Hold, SchemaName: CreditOnHold, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.</summary>
	[JsonIgnore]
	public string? CreditOnHoldFormattedValue
	{
		get
		{
			return TryGetValue("creditonhold@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Credit Hold, SchemaName: CreditOnHold, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.</summary>
	[JsonIgnore]
	public bool? CreditOnHold
	{
		get
		{
			return TryGetValue("creditonhold", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("creditonhold") is false || Remove("creditonhold"))
			{
				Add("creditonhold", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: creditonhold, SchemaName: CreditOnHoldName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CreditOnHoldName
	{
		get
		{
			return TryGetValue("creditonholdname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Size, SchemaName: CustomerSizeCode, IntroducedVersion: 5.0.0.0.  Description: Select the size of the contact's company for segmentation and reporting purposes.</summary>
	[JsonIgnore]
	public string? CustomerSizeCodeFormattedValue
	{
		get
		{
			return TryGetValue("customersizecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Size, SchemaName: CustomerSizeCode, IntroducedVersion: 5.0.0.0.  Description: Select the size of the contact's company for segmentation and reporting purposes.</summary>
	[JsonIgnore]
	public int? CustomerSizeCode
	{
		get
		{
			return TryGetValue("customersizecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("customersizecode") is false || Remove("customersizecode"))
			{
				Add("customersizecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customersizecode, SchemaName: CustomerSizeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CustomerSizeCodeName
	{
		get
		{
			return TryGetValue("customersizecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Type, SchemaName: CustomerTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the category that best describes the relationship between the contact and your organization.</summary>
	[JsonIgnore]
	public string? CustomerTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("customertypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Type, SchemaName: CustomerTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the category that best describes the relationship between the contact and your organization.</summary>
	[JsonIgnore]
	public int? CustomerTypeCode
	{
		get
		{
			return TryGetValue("customertypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("customertypecode") is false || Remove("customertypecode"))
			{
				Add("customertypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customertypecode, SchemaName: CustomerTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CustomerTypeCodeName
	{
		get
		{
			return TryGetValue("customertypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
	[JsonIgnore]
	public string? DefaultPriceLevelIdFormattedValue
	{
		get
		{
			return TryGetValue("_defaultpricelevelid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
	[JsonIgnore]
	public Guid? DefaultPriceLevelId
	{
		get
		{
			return TryGetValue("_defaultpricelevelid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
	[JsonIgnore]
	public Guid? DefaultPriceLevelId_pricelevel
	{
		set
		{
			if (ContainsKey("defaultpricelevelid_pricelevel@odata.bind") is false || Remove("defaultpricelevelid_pricelevel@odata.bind"))
			{
				if (value is not null)
				{
					Add("defaultpricelevelid_pricelevel@odata.bind", $"({value})");
				}
				else
				{
					Add("_defaultpricelevelid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: defaultpricelevelid, Format: Text, MaxLength: 100, SchemaName: DefaultPriceLevelIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? DefaultPriceLevelIdName
	{
		get
		{
			return TryGetValue("defaultpricelevelidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("defaultpricelevelidname") is false || Remove("defaultpricelevelidname"))
			{
				Add("defaultpricelevelidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Department, Format: Text, MaxLength: 100, SchemaName: Department, IntroducedVersion: 5.0.0.0.  Description: Type the department or business unit where the contact works in the parent company or business.</summary>
	[JsonIgnore]
	public string? Department
	{
		get
		{
			return TryGetValue("department", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("department") is false || Remove("department"))
			{
				Add("department", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information to describe the contact, such as an excerpt from the company's website.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Emails, SchemaName: DoNotBulkEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Emails, SchemaName: DoNotBulkEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Mails, SchemaName: DoNotBulkPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.</summary>
	[JsonIgnore]
	public string? DoNotBulkPostalMailFormattedValue
	{
		get
		{
			return TryGetValue("donotbulkpostalmail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Mails, SchemaName: DoNotBulkPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.</summary>
	[JsonIgnore]
	public bool? DoNotBulkPostalMail
	{
		get
		{
			return TryGetValue("donotbulkpostalmail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("donotbulkpostalmail") is false || Remove("donotbulkpostalmail"))
			{
				Add("donotbulkpostalmail", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: donotbulkpostalmail, SchemaName: DoNotBulkPostalMailName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? DoNotBulkPostalMailName
	{
		get
		{
			return TryGetValue("donotbulkpostalmailname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Emails, SchemaName: DoNotEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Emails, SchemaName: DoNotEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Faxes, SchemaName: DoNotFax, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Faxes, SchemaName: DoNotFax, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Phone Calls, SchemaName: DoNotPhone, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Phone Calls, SchemaName: DoNotPhone, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Mails, SchemaName: DoNotPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Mails, SchemaName: DoNotPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Send Marketing Materials, SchemaName: DoNotSendMM, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Send Marketing Materials, SchemaName: DoNotSendMM, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: ADObjectID, Format: Text, MaxLength: 100, SchemaName: ecsm_ADObjectID, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? ecsm_ADObjectID
	{
		get
		{
			return TryGetValue("ecsm_adobjectid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_adobjectid") is false || Remove("ecsm_adobjectid"))
			{
				Add("ecsm_adobjectid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Education, SchemaName: EducationCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's highest level of education for use in segmentation and analysis.</summary>
	[JsonIgnore]
	public string? EducationCodeFormattedValue
	{
		get
		{
			return TryGetValue("educationcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Education, SchemaName: EducationCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's highest level of education for use in segmentation and analysis.</summary>
	[JsonIgnore]
	public int? EducationCode
	{
		get
		{
			return TryGetValue("educationcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("educationcode") is false || Remove("educationcode"))
			{
				Add("educationcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: educationcode, SchemaName: EducationCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? EducationCodeName
	{
		get
		{
			return TryGetValue("educationcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress1, IntroducedVersion: 5.0.0.0.  Description: Type the primary email address for the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 2, Format: Email, MaxLength: 100, SchemaName: EMailAddress2, IntroducedVersion: 5.0.0.0.  Description: Type the secondary email address for the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 3, Format: Email, MaxLength: 100, SchemaName: EMailAddress3, IntroducedVersion: 5.0.0.0.  Description: Type an alternate email address for the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Employee, Format: Text, MaxLength: 50, SchemaName: EmployeeId, IntroducedVersion: 5.0.0.0.  Description: Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: External User Identifier, Format: Text, MaxLength: 50, SchemaName: ExternalUserIdentifier, IntroducedVersion: 5.0.0.0.  Description: Identifier for an external user.</summary>
	[JsonIgnore]
	public string? ExternalUserIdentifier
	{
		get
		{
			return TryGetValue("externaluseridentifier", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("externaluseridentifier") is false || Remove("externaluseridentifier"))
			{
				Add("externaluseridentifier", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Marital Status, SchemaName: FamilyStatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the marital status of the contact for reference in follow-up phone calls and other communications.</summary>
	[JsonIgnore]
	public string? FamilyStatusCodeFormattedValue
	{
		get
		{
			return TryGetValue("familystatuscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Marital Status, SchemaName: FamilyStatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the marital status of the contact for reference in follow-up phone calls and other communications.</summary>
	[JsonIgnore]
	public int? FamilyStatusCode
	{
		get
		{
			return TryGetValue("familystatuscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("familystatuscode") is false || Remove("familystatuscode"))
			{
				Add("familystatuscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: familystatuscode, SchemaName: FamilyStatusCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? FamilyStatusCodeName
	{
		get
		{
			return TryGetValue("familystatuscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Fax, Format: Text, MaxLength: 50, SchemaName: Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number for the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: Recommended, DisplayName: First Name, Format: Text, MaxLength: 50, SchemaName: FirstName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow Email Activity, SchemaName: FollowEmail, IntroducedVersion: 8.2.0.0.  Description: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow Email Activity, SchemaName: FollowEmail, IntroducedVersion: 8.2.0.0.  Description: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: FTP Site, Format: Url, MaxLength: 200, SchemaName: FtpSiteUrl, IntroducedVersion: 5.0.0.0.  Description: Type the URL for the contact's FTP site to enable users to access data and share documents.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Full Name, Format: Text, MaxLength: 160, SchemaName: FullName, IntroducedVersion: 5.0.0.0.  Description: Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Gender, SchemaName: GenderCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	[JsonIgnore]
	public string? GenderCodeFormattedValue
	{
		get
		{
			return TryGetValue("gendercode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Gender, SchemaName: GenderCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	[JsonIgnore]
	public int? GenderCode
	{
		get
		{
			return TryGetValue("gendercode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("gendercode") is false || Remove("gendercode"))
			{
				Add("gendercode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: gendercode, SchemaName: GenderCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? GenderCodeName
	{
		get
		{
			return TryGetValue("gendercodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Government, Format: Text, MaxLength: 50, SchemaName: GovernmentId, IntroducedVersion: 5.0.0.0.  Description: Type the passport number or other government ID for the contact for use in documents or reports.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Has Children, SchemaName: HasChildrenCode, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact has any children for reference in follow-up phone calls and other communications.</summary>
	[JsonIgnore]
	public string? HasChildrenCodeFormattedValue
	{
		get
		{
			return TryGetValue("haschildrencode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Has Children, SchemaName: HasChildrenCode, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact has any children for reference in follow-up phone calls and other communications.</summary>
	[JsonIgnore]
	public int? HasChildrenCode
	{
		get
		{
			return TryGetValue("haschildrencode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("haschildrencode") is false || Remove("haschildrencode"))
			{
				Add("haschildrencode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: haschildrencode, SchemaName: HasChildrenCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? HasChildrenCodeName
	{
		get
		{
			return TryGetValue("haschildrencodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Home Phone 2, Format: Text, MaxLength: 50, SchemaName: Home2, IntroducedVersion: 7.0.0.0.  Description: Type a second home phone number for this contact.</summary>
	[JsonIgnore]
	public string? Home2
	{
		get
		{
			return TryGetValue("home2", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("home2") is false || Remove("home2"))
			{
				Add("home2", value);
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Back Office Customer, SchemaName: IsBackofficeCustomer, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.</summary>
	[JsonIgnore]
	public string? IsBackofficeCustomerFormattedValue
	{
		get
		{
			return TryGetValue("isbackofficecustomer@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Back Office Customer, SchemaName: IsBackofficeCustomer, IntroducedVersion: 5.0.0.0.  Description: Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.</summary>
	[JsonIgnore]
	public bool? IsBackofficeCustomer
	{
		get
		{
			return TryGetValue("isbackofficecustomer", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isbackofficecustomer") is false || Remove("isbackofficecustomer"))
			{
				Add("isbackofficecustomer", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isbackofficecustomer, SchemaName: IsBackofficeCustomerName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsBackofficeCustomerName
	{
		get
		{
			return TryGetValue("isbackofficecustomername", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, SchemaName: IsPrivate, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, SchemaName: IsPrivate, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Job Title, Format: Text, MaxLength: 100, SchemaName: JobTitle, IntroducedVersion: 5.0.0.0.  Description: Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Last Name, Format: Text, MaxLength: 50, SchemaName: LastName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Date Included in Campaign, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: LastUsedInCampaign, IntroducedVersion: 5.0.0.0.  Description: Shows the date when the contact was last included in a marketing campaign or quick campaign.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Lead Source, SchemaName: LeadSourceCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary marketing source that directed the contact to your organization.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Lead Source, SchemaName: LeadSourceCode, IntroducedVersion: 5.0.0.0.  Description: Select the primary marketing source that directed the contact to your organization.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Manager, Format: Text, MaxLength: 100, SchemaName: ManagerName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.</summary>
	[JsonIgnore]
	public string? ManagerName
	{
		get
		{
			return TryGetValue("managername", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("managername") is false || Remove("managername"))
			{
				Add("managername", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Manager Phone, Format: Text, MaxLength: 50, SchemaName: ManagerPhone, IntroducedVersion: 5.0.0.0.  Description: Type the phone number for the contact's manager.</summary>
	[JsonIgnore]
	public string? ManagerPhone
	{
		get
		{
			return TryGetValue("managerphone", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("managerphone") is false || Remove("managerphone"))
			{
				Add("managerphone", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Marketing Only, SchemaName: MarketingOnly, IntroducedVersion: 8.2.0.0.  Description: Whether is only for marketing</summary>
	[JsonIgnore]
	public string? MarketingOnlyFormattedValue
	{
		get
		{
			return TryGetValue("marketingonly@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Marketing Only, SchemaName: MarketingOnly, IntroducedVersion: 8.2.0.0.  Description: Whether is only for marketing</summary>
	[JsonIgnore]
	public bool? MarketingOnly
	{
		get
		{
			return TryGetValue("marketingonly", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("marketingonly") is false || Remove("marketingonly"))
			{
				Add("marketingonly", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: marketingonly, SchemaName: MarketingOnlyName, IntroducedVersion: 8.2.0.0. </summary>
	[JsonIgnore]
	public object? MarketingOnlyName
	{
		get
		{
			return TryGetValue("marketingonlyname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? MasterContactIdName
	{
		get
		{
			return TryGetValue("mastercontactidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("mastercontactidname") is false || Remove("mastercontactidname"))
			{
				Add("mastercontactidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterContactIdYomiName, YomiOf: mastercontactidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? MasterContactIdYomiName
	{
		get
		{
			return TryGetValue("mastercontactidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("mastercontactidyominame") is false || Remove("mastercontactidyominame"))
			{
				Add("mastercontactidyominame", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master contact for merge.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master contact for merge.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the master contact for merge.</summary>
	[JsonIgnore]
	public Guid? MasterId_contact
	{
		set
		{
			if (ContainsKey("masterid_contact@odata.bind") is false || Remove("masterid_contact@odata.bind"))
			{
				if (value is not null)
				{
					Add("masterid_contact@odata.bind", $"({value})");
				}
				else
				{
					Add("_masterid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Merged, SchemaName: Merged, IntroducedVersion: 5.0.0.0.  Description: Shows whether the account has been merged with a master contact.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Merged, SchemaName: Merged, IntroducedVersion: 5.0.0.0.  Description: Shows whether the account has been merged with a master contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Middle Name, Format: Text, MaxLength: 50, SchemaName: MiddleName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's middle name or initial to make sure the contact is addressed correctly.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Mobile Phone, Format: Text, MaxLength: 50, SchemaName: MobilePhone, IntroducedVersion: 5.0.0.0.  Description: Type the mobile phone number for the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (External Party), Format: None, SchemaName: ModifiedByExternalParty, IntroducedVersion: 8.0.0.0.  Description: Shows the external party who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyYomiName, YomiOf: modifiedbyexternalpartyname, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Contact.</summary>
	[JsonIgnore]
	public string? msa_managingpartneridFormattedValue
	{
		get
		{
			return TryGetValue("_msa_managingpartnerid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Contact.</summary>
	[JsonIgnore]
	public Guid? msa_managingpartnerid
	{
		get
		{
			return TryGetValue("_msa_managingpartnerid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Contact.</summary>
	[JsonIgnore]
	public Guid? msa_managingpartnerid_account
	{
		set
		{
			if (ContainsKey("msa_managingpartnerid_account@odata.bind") is false || Remove("msa_managingpartnerid_account@odata.bind"))
			{
				if (value is not null)
				{
					Add("msa_managingpartnerid_account@odata.bind", $"({value})");
				}
				else
				{
					Add("_msa_managingpartnerid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msa_managingpartnerid, Format: Text, MaxLength: 160, SchemaName: msa_managingpartneridName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msa_managingpartneridName
	{
		get
		{
			return TryGetValue("msa_managingpartneridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msa_managingpartneridname") is false || Remove("msa_managingpartneridname"))
			{
				Add("msa_managingpartneridname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msa_managingpartnerid, Format: Text, MaxLength: 160, SchemaName: msa_managingpartneridYomiName, YomiOf: msa_managingpartneridname, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msa_managingpartneridYomiName
	{
		get
		{
			return TryGetValue("msa_managingpartneridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msa_managingpartneridyominame") is false || Remove("msa_managingpartneridyominame"))
			{
				Add("msa_managingpartneridyominame", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_contactkpiid, IntroducedVersion: 1.0.  Description: Maps to contact KPI records</summary>
	[JsonIgnore]
	public string? msdyn_contactkpiidFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_contactkpiid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_contactkpiid, IntroducedVersion: 1.0.  Description: Maps to contact KPI records</summary>
	[JsonIgnore]
	public Guid? msdyn_contactkpiid
	{
		get
		{
			return TryGetValue("_msdyn_contactkpiid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_contactkpiid, IntroducedVersion: 1.0.  Description: Maps to contact KPI records</summary>
	[JsonIgnore]
	public Guid? msdyn_contactkpiid_msdyn_contactkpiitem
	{
		set
		{
			if (ContainsKey("msdyn_contactkpiid_msdyn_contactkpiitem@odata.bind") is false || Remove("msdyn_contactkpiid_msdyn_contactkpiitem@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_contactkpiid_msdyn_contactkpiitem@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_contactkpiid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_contactkpiid, Format: Text, MaxLength: 100, SchemaName: msdyn_contactkpiidName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_contactkpiidName
	{
		get
		{
			return TryGetValue("msdyn_contactkpiidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_contactkpiidname") is false || Remove("msdyn_contactkpiidname"))
			{
				Add("msdyn_contactkpiidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Decision influence labels, SchemaName: msdyn_decisioninfluencetag, IntroducedVersion: 1.0.0.0.  Description: Indicate buying influence using labels</summary>
	[JsonIgnore]
	public string? msdyn_decisioninfluencetagFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_decisioninfluencetag@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Decision influence labels, SchemaName: msdyn_decisioninfluencetag, IntroducedVersion: 1.0.0.0.  Description: Indicate buying influence using labels</summary>
	[JsonIgnore]
	public int? msdyn_decisioninfluencetag
	{
		get
		{
			return TryGetValue("msdyn_decisioninfluencetag", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_decisioninfluencetag") is false || Remove("msdyn_decisioninfluencetag"))
			{
				Add("msdyn_decisioninfluencetag", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_decisioninfluencetag, SchemaName: msdyn_decisioninfluencetagName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_decisioninfluencetagName
	{
		get
		{
			return TryGetValue("msdyn_decisioninfluencetagname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Disable Web Tracking, SchemaName: msdyn_disablewebtracking, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact has opted out of web tracking.</summary>
	[JsonIgnore]
	public string? msdyn_disablewebtrackingFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_disablewebtracking@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Disable Web Tracking, SchemaName: msdyn_disablewebtracking, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact has opted out of web tracking.</summary>
	[JsonIgnore]
	public bool? msdyn_disablewebtracking
	{
		get
		{
			return TryGetValue("msdyn_disablewebtracking", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_disablewebtracking") is false || Remove("msdyn_disablewebtracking"))
			{
				Add("msdyn_disablewebtracking", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_disablewebtracking, SchemaName: msdyn_disablewebtrackingName, IntroducedVersion: 8.4.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_disablewebtrackingName
	{
		get
		{
			return TryGetValue("msdyn_disablewebtrackingname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether contact is opted out or not</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether contact is opted out or not</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Assistant, SchemaName: msdyn_isassistantinorgchart, IntroducedVersion: 1.0.0.0.  Description: Describes if the contact is an assistant in org chart</summary>
	[JsonIgnore]
	public string? msdyn_isassistantinorgchartFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_isassistantinorgchart@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Assistant, SchemaName: msdyn_isassistantinorgchart, IntroducedVersion: 1.0.0.0.  Description: Describes if the contact is an assistant in org chart</summary>
	[JsonIgnore]
	public bool? msdyn_isassistantinorgchart
	{
		get
		{
			return TryGetValue("msdyn_isassistantinorgchart", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_isassistantinorgchart") is false || Remove("msdyn_isassistantinorgchart"))
			{
				Add("msdyn_isassistantinorgchart", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isassistantinorgchart, SchemaName: msdyn_isassistantinorgchartName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_isassistantinorgchartName
	{
		get
		{
			return TryGetValue("msdyn_isassistantinorgchartname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Minor, SchemaName: msdyn_isminor, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact is considered a minor in their jurisdiction.</summary>
	[JsonIgnore]
	public string? msdyn_isminorFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_isminor@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Minor, SchemaName: msdyn_isminor, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact is considered a minor in their jurisdiction.</summary>
	[JsonIgnore]
	public bool? msdyn_isminor
	{
		get
		{
			return TryGetValue("msdyn_isminor", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_isminor") is false || Remove("msdyn_isminor"))
			{
				Add("msdyn_isminor", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isminor, SchemaName: msdyn_isminorName, IntroducedVersion: 8.4.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_isminorName
	{
		get
		{
			return TryGetValue("msdyn_isminorname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Minor with Parental Consent, SchemaName: msdyn_isminorwithparentalconsent, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact is considered a minor in their jurisdiction and has parental consent.</summary>
	[JsonIgnore]
	public string? msdyn_isminorwithparentalconsentFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_isminorwithparentalconsent@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Minor with Parental Consent, SchemaName: msdyn_isminorwithparentalconsent, IntroducedVersion: 8.4.0.0.  Description: Indicates that the contact is considered a minor in their jurisdiction and has parental consent.</summary>
	[JsonIgnore]
	public bool? msdyn_isminorwithparentalconsent
	{
		get
		{
			return TryGetValue("msdyn_isminorwithparentalconsent", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_isminorwithparentalconsent") is false || Remove("msdyn_isminorwithparentalconsent"))
			{
				Add("msdyn_isminorwithparentalconsent", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isminorwithparentalconsent, SchemaName: msdyn_isminorwithparentalconsentName, IntroducedVersion: 8.4.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_isminorwithparentalconsentName
	{
		get
		{
			return TryGetValue("msdyn_isminorwithparentalconsentname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Not at Company Flag, SchemaName: msdyn_orgchangestatus, IntroducedVersion: 1.0.  Description: Whether or not the contact belongs to the associated account</summary>
	[JsonIgnore]
	public string? msdyn_orgchangestatusFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_orgchangestatus@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Not at Company Flag, SchemaName: msdyn_orgchangestatus, IntroducedVersion: 1.0.  Description: Whether or not the contact belongs to the associated account</summary>
	[JsonIgnore]
	public int? msdyn_orgchangestatus
	{
		get
		{
			return TryGetValue("msdyn_orgchangestatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_orgchangestatus") is false || Remove("msdyn_orgchangestatus"))
			{
				Add("msdyn_orgchangestatus", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_orgchangestatus, SchemaName: msdyn_orgchangestatusName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_orgchangestatusName
	{
		get
		{
			return TryGetValue("msdyn_orgchangestatusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Portal Terms Agreement Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: msdyn_portaltermsagreementdate, IntroducedVersion: 8.4.0.0.  Description: Indicates the date and time that the person agreed to the portal terms and conditions.</summary>
	[JsonIgnore]
	public DateTime? msdyn_portaltermsagreementdate
	{
		get
		{
			return TryGetValue("msdyn_portaltermsagreementdate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_portaltermsagreementdate") is false || Remove("msdyn_portaltermsagreementdate"))
			{
				Add("msdyn_portaltermsagreementdate", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Primary Time Zone, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: msdyn_PrimaryTimeZone, IntroducedVersion: 1.0.30.0.  Description: Indicates the primary time zone that the contact works on.</summary>
	[JsonIgnore]
	public int? msdyn_PrimaryTimeZone
	{
		get
		{
			return TryGetValue("msdyn_primarytimezone", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_primarytimezone") is false || Remove("msdyn_primarytimezone"))
			{
				Add("msdyn_primarytimezone", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Language, SchemaName: mspp_userpreferredlcid, IntroducedVersion: 1.0.0.0.  Description: User’s preferred portal language</summary>
	[JsonIgnore]
	public string? mspp_userpreferredlcidFormattedValue
	{
		get
		{
			return TryGetValue("mspp_userpreferredlcid@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Language, SchemaName: mspp_userpreferredlcid, IntroducedVersion: 1.0.0.0.  Description: User’s preferred portal language</summary>
	[JsonIgnore]
	public int? mspp_userpreferredlcid
	{
		get
		{
			return TryGetValue("mspp_userpreferredlcid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("mspp_userpreferredlcid") is false || Remove("mspp_userpreferredlcid"))
			{
				Add("mspp_userpreferredlcid", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: mspp_userpreferredlcid, SchemaName: mspp_userpreferredlcidName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? mspp_userpreferredlcidName
	{
		get
		{
			return TryGetValue("mspp_userpreferredlcidname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Nickname, Format: Text, MaxLength: 100, SchemaName: NickName, IntroducedVersion: 5.0.0.0.  Description: Type the contact's nickname.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: No. of Children, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: NumberOfChildren, IntroducedVersion: 5.0.0.0.  Description: Type the number of children the contact has for reference in follow-up phone calls and other communications.</summary>
	[JsonIgnore]
	public int? NumberOfChildren
	{
		get
		{
			return TryGetValue("numberofchildren", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("numberofchildren") is false || Remove("numberofchildren"))
			{
				Add("numberofchildren", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.</summary>
	[JsonIgnore]
	public string? OriginatingLeadIdFormattedValue
	{
		get
		{
			return TryGetValue("_originatingleadid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.</summary>
	[JsonIgnore]
	public Guid? OriginatingLeadId
	{
		get
		{
			return TryGetValue("_originatingleadid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.</summary>
	[JsonIgnore]
	public Guid? OriginatingLeadId_lead
	{
		set
		{
			if (ContainsKey("originatingleadid_lead@odata.bind") is false || Remove("originatingleadid_lead@odata.bind"))
			{
				if (value is not null)
				{
					Add("originatingleadid_lead@odata.bind", $"({value})");
				}
				else
				{
					Add("_originatingleadid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: originatingleadid, Format: Text, MaxLength: 100, SchemaName: OriginatingLeadIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? OriginatingLeadIdName
	{
		get
		{
			return TryGetValue("originatingleadidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("originatingleadidname") is false || Remove("originatingleadidname"))
			{
				Add("originatingleadidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: originatingleadid, Format: Text, MaxLength: 100, SchemaName: OriginatingLeadIdYomiName, YomiOf: originatingleadidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? OriginatingLeadIdYomiName
	{
		get
		{
			return TryGetValue("originatingleadidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("originatingleadidyominame") is false || Remove("originatingleadidyominame"))
			{
				Add("originatingleadidyominame", value);
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pager, Format: Text, MaxLength: 50, SchemaName: Pager, IntroducedVersion: 5.0.0.0.  Description: Type the pager number for the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact, Format: None, SchemaName: ParentContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the parent contact.</summary>
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

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Company Name, Format: None, SchemaName: ParentCustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.</summary>
	[JsonIgnore]
	public string? ParentCustomerIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentcustomerid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Company Name, Format: None, SchemaName: ParentCustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.</summary>
	[JsonIgnore]
	public Guid? ParentCustomerId
	{
		get
		{
			return TryGetValue("_parentcustomerid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: parentcustomerid, Format: Text, MaxLength: 160, SchemaName: ParentCustomerIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentCustomerIdName
	{
		get
		{
			return TryGetValue("parentcustomeridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentcustomeridname") is false || Remove("parentcustomeridname"))
			{
				Add("parentcustomeridname", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: None, DisplayName: Parent Customer Type, AttributeOf: parentcustomerid, SchemaName: ParentCustomerIdType, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentCustomerIdType
	{
		get
		{
			return TryGetValue("parentcustomeridtype", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentcustomeridtype") is false || Remove("parentcustomeridtype"))
			{
				Add("parentcustomeridtype", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: parentcustomerid, Format: Text, MaxLength: 450, SchemaName: ParentCustomerIdYomiName, YomiOf: parentcustomeridname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentCustomerIdYomiName
	{
		get
		{
			return TryGetValue("parentcustomeridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentcustomeridyominame") is false || Remove("parentcustomeridyominame"))
			{
				Add("parentcustomeridyominame", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Participates in Workflow, SchemaName: ParticipatesInWorkflow, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contact participates in workflow rules.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Participates in Workflow, SchemaName: ParticipatesInWorkflow, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contact participates in workflow rules.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Payment Terms, SchemaName: PaymentTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the payment terms to indicate when the customer needs to pay the total amount.</summary>
	[JsonIgnore]
	public string? PaymentTermsCodeFormattedValue
	{
		get
		{
			return TryGetValue("paymenttermscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Payment Terms, SchemaName: PaymentTermsCode, IntroducedVersion: 5.0.0.0.  Description: Select the payment terms to indicate when the customer needs to pay the total amount.</summary>
	[JsonIgnore]
	public int? PaymentTermsCode
	{
		get
		{
			return TryGetValue("paymenttermscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("paymenttermscode") is false || Remove("paymenttermscode"))
			{
				Add("paymenttermscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: paymenttermscode, SchemaName: PaymentTermsCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PaymentTermsCodeName
	{
		get
		{
			return TryGetValue("paymenttermscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Day, SchemaName: PreferredAppointmentDayCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred day of the week for service appointments.</summary>
	[JsonIgnore]
	public string? PreferredAppointmentDayCodeFormattedValue
	{
		get
		{
			return TryGetValue("preferredappointmentdaycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Day, SchemaName: PreferredAppointmentDayCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred day of the week for service appointments.</summary>
	[JsonIgnore]
	public int? PreferredAppointmentDayCode
	{
		get
		{
			return TryGetValue("preferredappointmentdaycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredappointmentdaycode") is false || Remove("preferredappointmentdaycode"))
			{
				Add("preferredappointmentdaycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredappointmentdaycode, SchemaName: PreferredAppointmentDayCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PreferredAppointmentDayCodeName
	{
		get
		{
			return TryGetValue("preferredappointmentdaycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Time, SchemaName: PreferredAppointmentTimeCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred time of day for service appointments.</summary>
	[JsonIgnore]
	public string? PreferredAppointmentTimeCodeFormattedValue
	{
		get
		{
			return TryGetValue("preferredappointmenttimecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Time, SchemaName: PreferredAppointmentTimeCode, IntroducedVersion: 5.0.0.0.  Description: Select the preferred time of day for service appointments.</summary>
	[JsonIgnore]
	public int? PreferredAppointmentTimeCode
	{
		get
		{
			return TryGetValue("preferredappointmenttimecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredappointmenttimecode") is false || Remove("preferredappointmenttimecode"))
			{
				Add("preferredappointmenttimecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: preferredappointmenttimecode, SchemaName: PreferredAppointmentTimeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? PreferredAppointmentTimeCodeName
	{
		get
		{
			return TryGetValue("preferredappointmenttimecodename", out var value)
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
	[JsonIgnore]
	public string? PreferredEquipmentIdFormattedValue
	{
		get
		{
			return TryGetValue("_preferredequipmentid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
	[JsonIgnore]
	public Guid? PreferredEquipmentId
	{
		get
		{
			return TryGetValue("_preferredequipmentid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
	[JsonIgnore]
	public Guid? PreferredEquipmentId_equipment
	{
		set
		{
			if (ContainsKey("preferredequipmentid_equipment@odata.bind") is false || Remove("preferredequipmentid_equipment@odata.bind"))
			{
				if (value is not null)
				{
					Add("preferredequipmentid_equipment@odata.bind", $"({value})");
				}
				else
				{
					Add("_preferredequipmentid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: preferredequipmentid, Format: Text, MaxLength: 100, SchemaName: PreferredEquipmentIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? PreferredEquipmentIdName
	{
		get
		{
			return TryGetValue("preferredequipmentidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredequipmentidname") is false || Remove("preferredequipmentidname"))
			{
				Add("preferredequipmentidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service to make sure services are scheduled correctly for the customer.</summary>
	[JsonIgnore]
	public string? PreferredServiceIdFormattedValue
	{
		get
		{
			return TryGetValue("_preferredserviceid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service to make sure services are scheduled correctly for the customer.</summary>
	[JsonIgnore]
	public Guid? PreferredServiceId
	{
		get
		{
			return TryGetValue("_preferredserviceid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the contact's preferred service to make sure services are scheduled correctly for the customer.</summary>
	[JsonIgnore]
	public Guid? PreferredServiceId_service
	{
		set
		{
			if (ContainsKey("preferredserviceid_service@odata.bind") is false || Remove("preferredserviceid_service@odata.bind"))
			{
				if (value is not null)
				{
					Add("preferredserviceid_service@odata.bind", $"({value})");
				}
				else
				{
					Add("_preferredserviceid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: preferredserviceid, Format: Text, MaxLength: 100, SchemaName: PreferredServiceIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? PreferredServiceIdName
	{
		get
		{
			return TryGetValue("preferredserviceidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredserviceidname") is false || Remove("preferredserviceidname"))
			{
				Add("preferredserviceidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.</summary>
	[JsonIgnore]
	public string? PreferredSystemUserIdFormattedValue
	{
		get
		{
			return TryGetValue("_preferredsystemuserid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.</summary>
	[JsonIgnore]
	public Guid? PreferredSystemUserId
	{
		get
		{
			return TryGetValue("_preferredsystemuserid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.</summary>
	[JsonIgnore]
	public Guid? PreferredSystemUserId_systemuser
	{
		set
		{
			if (ContainsKey("preferredsystemuserid_systemuser@odata.bind") is false || Remove("preferredsystemuserid_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("preferredsystemuserid_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_preferredsystemuserid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: preferredsystemuserid, Format: Text, MaxLength: 100, SchemaName: PreferredSystemUserIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? PreferredSystemUserIdName
	{
		get
		{
			return TryGetValue("preferredsystemuseridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredsystemuseridname") is false || Remove("preferredsystemuseridname"))
			{
				Add("preferredsystemuseridname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: preferredsystemuserid, Format: Text, MaxLength: 100, SchemaName: PreferredSystemUserIdYomiName, YomiOf: preferredsystemuseridname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? PreferredSystemUserIdYomiName
	{
		get
		{
			return TryGetValue("preferredsystemuseridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("preferredsystemuseridyominame") is false || Remove("preferredsystemuseridyominame"))
			{
				Add("preferredsystemuseridyominame", value);
			}
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Salutation, Format: Text, MaxLength: 100, SchemaName: Salutation, IntroducedVersion: 5.0.0.0.  Description: Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method, SchemaName: ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public string? ShippingMethodCodeFormattedValue
	{
		get
		{
			return TryGetValue("shippingmethodcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method, SchemaName: ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to this address.</summary>
	[JsonIgnore]
	public int? ShippingMethodCode
	{
		get
		{
			return TryGetValue("shippingmethodcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("shippingmethodcode") is false || Remove("shippingmethodcode"))
			{
				Add("shippingmethodcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: shippingmethodcode, SchemaName: ShippingMethodCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ShippingMethodCodeName
	{
		get
		{
			return TryGetValue("shippingmethodcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Contact record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Contact record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Contact record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Spouse/Partner Name, Format: Text, MaxLength: 100, SchemaName: SpousesName, IntroducedVersion: 5.0.0.0.  Description: Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.</summary>
	[JsonIgnore]
	public string? SpousesName
	{
		get
		{
			return TryGetValue("spousesname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("spousesname") is false || Remove("spousesname"))
			{
				Add("spousesname", value);
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the contact's status.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Subscription, SchemaName: SubscriptionId, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? SubscriptionId
	{
		get
		{
			return TryGetValue("subscriptionid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("subscriptionid") is false || Remove("subscriptionid"))
			{
				Add("subscriptionid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Suffix, Format: Text, MaxLength: 10, SchemaName: Suffix, IntroducedVersion: 5.0.0.0.  Description: Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.</summary>
	[JsonIgnore]
	public string? Suffix
	{
		get
		{
			return TryGetValue("suffix", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("suffix") is false || Remove("suffix"))
			{
				Add("suffix", value);
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Business Phone, Format: Text, MaxLength: 50, SchemaName: Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number for this contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Home Phone, Format: Text, MaxLength: 50, SchemaName: Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type a second phone number for this contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type a third phone number for this contact.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Territory, SchemaName: TerritoryCode, IntroducedVersion: 5.0.0.0.  Description: Select a region or territory for the contact for use in segmentation and analysis.</summary>
	[JsonIgnore]
	public string? TerritoryCodeFormattedValue
	{
		get
		{
			return TryGetValue("territorycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Territory, SchemaName: TerritoryCode, IntroducedVersion: 5.0.0.0.  Description: Select a region or territory for the contact for use in segmentation and analysis.</summary>
	[JsonIgnore]
	public int? TerritoryCode
	{
		get
		{
			return TryGetValue("territorycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("territorycode") is false || Remove("territorycode"))
			{
				Add("territorycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: territorycode, SchemaName: TerritoryCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? TerritoryCodeName
	{
		get
		{
			return TryGetValue("territorycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Time Spent by me, Format: Text, MaxLength: 1250, SchemaName: TimeSpentByMeOnEmailAndMeetings, IntroducedVersion: 8.2.0.0.  Description: Total time spent for emails (read and write) and meetings by me in relation to the contact record.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Website, Format: Url, MaxLength: 200, SchemaName: WebSiteUrl, IntroducedVersion: 5.0.0.0.  Description: Type the contact's professional or personal website or blog URL.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi First Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiFirstName, YomiOf: firstname, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Full Name, Format: PhoneticGuide, MaxLength: 450, SchemaName: YomiFullName, YomiOf: fullname, IntroducedVersion: 5.0.0.0.  Description: Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Last Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiLastName, YomiOf: lastname, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Middle Name, Format: PhoneticGuide, MaxLength: 150, SchemaName: YomiMiddleName, YomiOf: middlename, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.</summary>
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

