namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Business that represents a customer or potential customer. The company that is billed in business transactions.</summary>
public sealed partial class Account : Dictionary<string, object>
{
	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Category, SchemaName: AccountCategoryCode, IntroducedVersion: 5.0.0.0.  Description: Select a category to indicate whether the customer account is standard or preferred.</summary>
	[JsonIgnore]
	public string? AccountCategoryCodeFormattedValue
	{
		get
		{
			return TryGetValue("accountcategorycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Category, SchemaName: AccountCategoryCode, IntroducedVersion: 5.0.0.0.  Description: Select a category to indicate whether the customer account is standard or preferred.</summary>
	[JsonIgnore]
	public int? AccountCategoryCode
	{
		get
		{
			return TryGetValue("accountcategorycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountcategorycode") is false || Remove("accountcategorycode"))
			{
				Add("accountcategorycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: accountcategorycode, SchemaName: AccountCategoryCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? AccountCategoryCodeName
	{
		get
		{
			return TryGetValue("accountcategorycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Classification, SchemaName: AccountClassificationCode, IntroducedVersion: 5.0.0.0.  Description: Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.</summary>
	[JsonIgnore]
	public string? AccountClassificationCodeFormattedValue
	{
		get
		{
			return TryGetValue("accountclassificationcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Classification, SchemaName: AccountClassificationCode, IntroducedVersion: 5.0.0.0.  Description: Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.</summary>
	[JsonIgnore]
	public int? AccountClassificationCode
	{
		get
		{
			return TryGetValue("accountclassificationcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountclassificationcode") is false || Remove("accountclassificationcode"))
			{
				Add("accountclassificationcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: accountclassificationcode, SchemaName: AccountClassificationCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? AccountClassificationCodeName
	{
		get
		{
			return TryGetValue("accountclassificationcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Account, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account.</summary>
	[JsonIgnore]
	public Guid? AccountId
	{
		get
		{
			return TryGetValue("accountid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountid") is false || Remove("accountid"))
			{
				Add("accountid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Account Number, Format: Text, MaxLength: 20, SchemaName: AccountNumber, IntroducedVersion: 5.0.0.0.  Description: Type an ID number or code for the account to quickly search and identify the account in system views.</summary>
	[JsonIgnore]
	public string? AccountNumber
	{
		get
		{
			return TryGetValue("accountnumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountnumber") is false || Remove("accountnumber"))
			{
				Add("accountnumber", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Account Rating, SchemaName: AccountRatingCode, IntroducedVersion: 5.0.0.0.  Description: Select a rating to indicate the value of the customer account.</summary>
	[JsonIgnore]
	public string? AccountRatingCodeFormattedValue
	{
		get
		{
			return TryGetValue("accountratingcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Account Rating, SchemaName: AccountRatingCode, IntroducedVersion: 5.0.0.0.  Description: Select a rating to indicate the value of the customer account.</summary>
	[JsonIgnore]
	public int? AccountRatingCode
	{
		get
		{
			return TryGetValue("accountratingcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("accountratingcode") is false || Remove("accountratingcode"))
			{
				Add("accountratingcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: accountratingcode, SchemaName: AccountRatingCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? AccountRatingCodeName
	{
		get
		{
			return TryGetValue("accountratingcodename", out var value)
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address Phone, Format: Text, MaxLength: 50, SchemaName: Address1_Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number associated with the primary address.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Address 2: Name, Format: Text, MaxLength: 200, SchemaName: Address2_Name, IntroducedVersion: 5.0.0.0.  Description: Type a descriptive name for the secondary address, such as Corporate Headquarters.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Created By (IP Address), Format: Text, MaxLength: 100, SchemaName: Adx_CreatedByIPAddress, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Created By (User Name), Format: Text, MaxLength: 100, SchemaName: Adx_CreatedByUsername, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Modified By (IP Address), Format: Text, MaxLength: 100, SchemaName: Adx_ModifiedByIPAddress, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Modified By (User Name), Format: Text, MaxLength: 100, SchemaName: Adx_ModifiedByUsername, IntroducedVersion: 1.0.0.0. </summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30 (Base), CalculationOf: aging30, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging30_Base, IntroducedVersion: 5.0.0.0.  Description: The base currency equivalent of the aging 30 field.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 30 (Base), CalculationOf: aging30, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging30_Base, IntroducedVersion: 5.0.0.0.  Description: The base currency equivalent of the aging 30 field.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60 (Base), CalculationOf: aging60, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging60_Base, IntroducedVersion: 5.0.0.0.  Description: The base currency equivalent of the aging 60 field.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 60 (Base), CalculationOf: aging60, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging60_Base, IntroducedVersion: 5.0.0.0.  Description: The base currency equivalent of the aging 60 field.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90 (Base), CalculationOf: aging90, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging90_Base, IntroducedVersion: 5.0.0.0.  Description: The base currency equivalent of the aging 90 field.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Aging 90 (Base), CalculationOf: aging90, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Aging90_Base, IntroducedVersion: 5.0.0.0.  Description: The base currency equivalent of the aging 90 field.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Business Type, SchemaName: BusinessTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the legal designation or other business type of the account for contracts or reporting purposes.</summary>
	[JsonIgnore]
	public string? BusinessTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("businesstypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Business Type, SchemaName: BusinessTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the legal designation or other business type of the account for contracts or reporting purposes.</summary>
	[JsonIgnore]
	public int? BusinessTypeCode
	{
		get
		{
			return TryGetValue("businesstypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("businesstypecode") is false || Remove("businesstypecode"))
			{
				Add("businesstypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: businesstypecode, SchemaName: BusinessTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? BusinessTypeCodeName
	{
		get
		{
			return TryGetValue("businesstypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: CreditLimit, IntroducedVersion: 5.0.0.0.  Description: Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: CreditLimit, IntroducedVersion: 5.0.0.0.  Description: Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit (Base), CalculationOf: creditlimit, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: CreditLimit_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the credit limit converted to the system's default base currency for reporting purposes.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Credit Limit (Base), CalculationOf: creditlimit, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: CreditLimit_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the credit limit converted to the system's default base currency for reporting purposes.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Credit Hold, SchemaName: CreditOnHold, IntroducedVersion: 5.0.0.0.  Description: Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Credit Hold, SchemaName: CreditOnHold, IntroducedVersion: 5.0.0.0.  Description: Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Size, SchemaName: CustomerSizeCode, IntroducedVersion: 5.0.0.0.  Description: Select the size category or range of the account for segmentation and reporting purposes.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Size, SchemaName: CustomerSizeCode, IntroducedVersion: 5.0.0.0.  Description: Select the size category or range of the account for segmentation and reporting purposes.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Type, SchemaName: CustomerTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the category that best describes the relationship between the account and your organization.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Type, SchemaName: CustomerTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the category that best describes the relationship between the account and your organization.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Price List, Format: None, SchemaName: DefaultPriceLevelId, IntroducedVersion: 5.0.0.0.  Description: Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.</summary>
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

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information to describe the account, such as an excerpt from the company's website.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Emails, SchemaName: DoNotBulkEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Emails, SchemaName: DoNotBulkEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Mails, SchemaName: DoNotBulkPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Bulk Mails, SchemaName: DoNotBulkPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Emails, SchemaName: DoNotEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows direct email sent from Microsoft Dynamics 365.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Emails, SchemaName: DoNotEMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows direct email sent from Microsoft Dynamics 365.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Faxes, SchemaName: DoNotFax, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Faxes, SchemaName: DoNotFax, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Phone Calls, SchemaName: DoNotPhone, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Phone Calls, SchemaName: DoNotPhone, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Mails, SchemaName: DoNotPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Do not allow Mails, SchemaName: DoNotPostalMail, IntroducedVersion: 5.0.0.0.  Description: Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Send Marketing Materials, SchemaName: DoNotSendMM, IntroducedVersion: 5.0.0.0.  Description: Select whether the account accepts marketing materials, such as brochures or catalogs.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Send Marketing Materials, SchemaName: DoNotSendMM, IntroducedVersion: 5.0.0.0.  Description: Select whether the account accepts marketing materials, such as brochures or catalogs.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress1, IntroducedVersion: 5.0.0.0.  Description: Type the primary email address for the account.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 2, Format: Email, MaxLength: 100, SchemaName: EMailAddress2, IntroducedVersion: 5.0.0.0.  Description: Type the secondary email address for the account.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address 3, Format: Email, MaxLength: 100, SchemaName: EMailAddress3, IntroducedVersion: 5.0.0.0.  Description: Type an alternate email address for the account.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Default Image, AttributeOf: entityimageid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: EntityImage, IntroducedVersion: 6.0.0.0.  Description: Shows the default image for the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Fax, Format: Text, MaxLength: 50, SchemaName: Fax, IntroducedVersion: 5.0.0.0.  Description: Type the fax number for the account.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow Email Activity, SchemaName: FollowEmail, IntroducedVersion: 8.2.0.0.  Description: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow Email Activity, SchemaName: FollowEmail, IntroducedVersion: 8.2.0.0.  Description: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: FTP Site, Format: Url, MaxLength: 200, SchemaName: FtpSiteURL, IntroducedVersion: 5.0.0.0.  Description: Type the URL for the account's FTP site to enable users to access data and share documents.</summary>
	[JsonIgnore]
	public string? FtpSiteURL
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Industry, SchemaName: IndustryCode, IntroducedVersion: 5.0.0.0.  Description: Select the account's primary industry for use in marketing segmentation and demographic analysis.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Industry, SchemaName: IndustryCode, IntroducedVersion: 5.0.0.0.  Description: Select the account's primary industry for use in marketing segmentation and demographic analysis.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Date Included in Campaign, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: LastUsedInCampaign, IntroducedVersion: 5.0.0.0.  Description: Shows the date when the account was last included in a marketing campaign or quick campaign.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Market Capitalization, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: MarketCap, IntroducedVersion: 5.0.0.0.  Description: Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.</summary>
	[JsonIgnore]
	public string? MarketCapFormattedValue
	{
		get
		{
			return TryGetValue("marketcap@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Market Capitalization, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: MarketCap, IntroducedVersion: 5.0.0.0.  Description: Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.</summary>
	[JsonIgnore]
	public decimal? MarketCap
	{
		get
		{
			return TryGetValue("marketcap", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("marketcap") is false || Remove("marketcap"))
			{
				Add("marketcap", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Market Capitalization (Base), CalculationOf: marketcap, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: MarketCap_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the market capitalization converted to the system's default base currency.</summary>
	[JsonIgnore]
	public string? MarketCap_BaseFormattedValue
	{
		get
		{
			return TryGetValue("marketcap_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Market Capitalization (Base), CalculationOf: marketcap, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: MarketCap_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the market capitalization converted to the system's default base currency.</summary>
	[JsonIgnore]
	public decimal? MarketCap_Base
	{
		get
		{
			return TryGetValue("marketcap_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("marketcap_base") is false || Remove("marketcap_base"))
			{
				Add("marketcap_base", value);
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterAccountIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? MasterAccountIdName
	{
		get
		{
			return TryGetValue("masteraccountidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("masteraccountidname") is false || Remove("masteraccountidname"))
			{
				Add("masteraccountidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterAccountIdYomiName, YomiOf: masteraccountidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? MasterAccountIdYomiName
	{
		get
		{
			return TryGetValue("masteraccountidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("masteraccountidyominame") is false || Remove("masteraccountidyominame"))
			{
				Add("masteraccountidyominame", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Shows the master account that the account was merged with.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Shows the master account that the account was merged with.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master ID, Format: None, SchemaName: MasterId, IntroducedVersion: 5.0.0.0.  Description: Shows the master account that the account was merged with.</summary>
	[JsonIgnore]
	public Guid? MasterId_account
	{
		set
		{
			if (ContainsKey("masterid_account@odata.bind") is false || Remove("masterid_account@odata.bind"))
			{
				if (value is not null)
				{
					Add("masterid_account@odata.bind", $"({value})");
				}
				else
				{
					Add("_masterid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Merged, SchemaName: Merged, IntroducedVersion: 5.0.0.0.  Description: Shows whether the account has been merged with another account.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Merged, SchemaName: Merged, IntroducedVersion: 5.0.0.0.  Description: Shows whether the account has been merged with another account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Shows who created the record on behalf of another user.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Managing Partner, Format: None, SchemaName: msa_managingpartnerid, IntroducedVersion: 1.0.0.0.  Description: Unique identifier for Account associated with Account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_accountkpiid, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_accountkpiidFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_accountkpiid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_accountkpiid, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public Guid? msdyn_accountkpiid
	{
		get
		{
			return TryGetValue("_msdyn_accountkpiid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: KPI, Format: None, SchemaName: msdyn_accountkpiid, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public Guid? msdyn_accountkpiid_msdyn_accountkpiitem
	{
		set
		{
			if (ContainsKey("msdyn_accountkpiid_msdyn_accountkpiitem@odata.bind") is false || Remove("msdyn_accountkpiid_msdyn_accountkpiitem@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_accountkpiid_msdyn_accountkpiitem@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_accountkpiid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_accountkpiid, Format: Text, MaxLength: 100, SchemaName: msdyn_accountkpiidName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_accountkpiidName
	{
		get
		{
			return TryGetValue("msdyn_accountkpiidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_accountkpiidname") is false || Remove("msdyn_accountkpiidname"))
			{
				Add("msdyn_accountkpiidname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether account is opted out or not</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: GDPR Optout, SchemaName: msdyn_gdproptout, IntroducedVersion: 1.0.  Description: Describes whether account is opted out or not</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Primary Time Zone, Format: TimeZone, MinValue: -1500, MaxValue: 1500, SchemaName: msdyn_PrimaryTimeZone, IntroducedVersion: 1.0.30.0.  Description: Indicates the primary time zone that the client works on.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sales Acceleration Insights ID, Format: None, SchemaName: msdyn_salesaccelerationinsightid, IntroducedVersion: 9.1.2201.5003.  Description: Sales Acceleration Insights ID</summary>
	[JsonIgnore]
	public string? msdyn_salesaccelerationinsightidFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_salesaccelerationinsightid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sales Acceleration Insights ID, Format: None, SchemaName: msdyn_salesaccelerationinsightid, IntroducedVersion: 9.1.2201.5003.  Description: Sales Acceleration Insights ID</summary>
	[JsonIgnore]
	public Guid? msdyn_salesaccelerationinsightid
	{
		get
		{
			return TryGetValue("_msdyn_salesaccelerationinsightid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sales Acceleration Insights ID, Format: None, SchemaName: msdyn_salesaccelerationinsightid, IntroducedVersion: 9.1.2201.5003.  Description: Sales Acceleration Insights ID</summary>
	[JsonIgnore]
	public Guid? msdyn_salesaccelerationinsightid_msdyn_salesaccelerationinsight
	{
		set
		{
			if (ContainsKey("msdyn_salesaccelerationinsightid_msdyn_salesaccelerationinsight@odata.bind") is false || Remove("msdyn_salesaccelerationinsightid_msdyn_salesaccelerationinsight@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_salesaccelerationinsightid_msdyn_salesaccelerationinsight@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_salesaccelerationinsightid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_salesaccelerationinsightid, Format: Text, MaxLength: 100, SchemaName: msdyn_salesaccelerationinsightidName, IntroducedVersion: 9.1.2201.5003. </summary>
	[JsonIgnore]
	public string? msdyn_salesaccelerationinsightidName
	{
		get
		{
			return TryGetValue("msdyn_salesaccelerationinsightidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_salesaccelerationinsightidname") is false || Remove("msdyn_salesaccelerationinsightidname"))
			{
				Add("msdyn_salesaccelerationinsightidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Segment Id, Format: None, SchemaName: msdyn_segmentid, IntroducedVersion: 1.0.  Description: Unique identifier for Segment associated with account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Segment Id, Format: None, SchemaName: msdyn_segmentid, IntroducedVersion: 1.0.  Description: Unique identifier for Segment associated with account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Segment Id, Format: None, SchemaName: msdyn_segmentid, IntroducedVersion: 1.0.  Description: Unique identifier for Segment associated with account.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_segmentid, Format: Text, MaxLength: 100, SchemaName: msdyn_segmentidName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Account Name, Format: Text, MaxLength: 160, SchemaName: Name, IntroducedVersion: 5.0.0.0.  Description: Type the company or business name.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Number of Employees, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: NumberOfEmployees, IntroducedVersion: 5.0.0.0.  Description: Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Open Deals, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OpenDeals, IntroducedVersion: 7.0.0.0.  Description: Number of open opportunities against an account and its child accounts.</summary>
	[JsonIgnore]
	public int? OpenDeals
	{
		get
		{
			return TryGetValue("opendeals", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("opendeals") is false || Remove("opendeals"))
			{
				Add("opendeals", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Open Deals (Last Updated On), DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: OpenDeals_Date, IntroducedVersion: 7.0.0.0.  Description: Last Updated time of rollup field Open Deals.</summary>
	[JsonIgnore]
	public DateTime? OpenDeals_Date
	{
		get
		{
			return TryGetValue("opendeals_date", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("opendeals_date") is false || Remove("opendeals_date"))
			{
				Add("opendeals_date", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Open Deals (State), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OpenDeals_State, IntroducedVersion: 7.0.0.0.  Description: State of rollup field Open Deals.</summary>
	[JsonIgnore]
	public int? OpenDeals_State
	{
		get
		{
			return TryGetValue("opendeals_state", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("opendeals_state") is false || Remove("opendeals_state"))
			{
				Add("opendeals_state", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Open Revenue, Precision: 2, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: OpenRevenue, IntroducedVersion: 7.0.0.0.  Description: Sum of open revenue against an account and its child accounts.</summary>
	[JsonIgnore]
	public string? OpenRevenueFormattedValue
	{
		get
		{
			return TryGetValue("openrevenue@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Open Revenue, Precision: 2, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: OpenRevenue, IntroducedVersion: 7.0.0.0.  Description: Sum of open revenue against an account and its child accounts.</summary>
	[JsonIgnore]
	public decimal? OpenRevenue
	{
		get
		{
			return TryGetValue("openrevenue", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("openrevenue") is false || Remove("openrevenue"))
			{
				Add("openrevenue", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Open Revenue (Base), CalculationOf: openrevenue, Precision: 2, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: OpenRevenue_Base, IntroducedVersion: 7.0.0.0.  Description: Value of the Open Revenue in base currency.</summary>
	[JsonIgnore]
	public string? OpenRevenue_BaseFormattedValue
	{
		get
		{
			return TryGetValue("openrevenue_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Open Revenue (Base), CalculationOf: openrevenue, Precision: 2, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: OpenRevenue_Base, IntroducedVersion: 7.0.0.0.  Description: Value of the Open Revenue in base currency.</summary>
	[JsonIgnore]
	public decimal? OpenRevenue_Base
	{
		get
		{
			return TryGetValue("openrevenue_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("openrevenue_base") is false || Remove("openrevenue_base"))
			{
				Add("openrevenue_base", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Open Revenue (Last Updated On), DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: OpenRevenue_Date, IntroducedVersion: 7.0.0.0.  Description: Last Updated time of rollup field Open Revenue.</summary>
	[JsonIgnore]
	public DateTime? OpenRevenue_Date
	{
		get
		{
			return TryGetValue("openrevenue_date", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("openrevenue_date") is false || Remove("openrevenue_date"))
			{
				Add("openrevenue_date", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Open Revenue (State), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OpenRevenue_State, IntroducedVersion: 7.0.0.0.  Description: State of rollup field Open Revenue.</summary>
	[JsonIgnore]
	public int? OpenRevenue_State
	{
		get
		{
			return TryGetValue("openrevenue_state", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("openrevenue_state") is false || Remove("openrevenue_state"))
			{
				Add("openrevenue_state", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Lead, Format: None, SchemaName: OriginatingLeadId, IntroducedVersion: 5.0.0.0.  Description: Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Ownership, SchemaName: OwnershipCode, IntroducedVersion: 5.0.0.0.  Description: Select the account's ownership structure, such as public or private.</summary>
	[JsonIgnore]
	public string? OwnershipCodeFormattedValue
	{
		get
		{
			return TryGetValue("ownershipcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Ownership, SchemaName: OwnershipCode, IntroducedVersion: 5.0.0.0.  Description: Select the account's ownership structure, such as public or private.</summary>
	[JsonIgnore]
	public int? OwnershipCode
	{
		get
		{
			return TryGetValue("ownershipcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ownershipcode") is false || Remove("ownershipcode"))
			{
				Add("ownershipcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ownershipcode, SchemaName: OwnershipCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? OwnershipCodeName
	{
		get
		{
			return TryGetValue("ownershipcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Shows the business unit that the record owner belongs to.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Shows the business unit that the record owner belongs to.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Shows the business unit that the record owner belongs to.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team who owns the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who owns the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Account, Format: None, SchemaName: ParentAccountId, IntroducedVersion: 5.0.0.0.  Description: Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Account, Format: None, SchemaName: ParentAccountId, IntroducedVersion: 5.0.0.0.  Description: Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Account, Format: None, SchemaName: ParentAccountId, IntroducedVersion: 5.0.0.0.  Description: Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Participates in Workflow, SchemaName: ParticipatesInWorkflow, IntroducedVersion: 5.0.0.0.  Description: For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Participates in Workflow, SchemaName: ParticipatesInWorkflow, IntroducedVersion: 5.0.0.0.  Description: For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Facility/Equipment, Format: None, SchemaName: PreferredEquipmentId, IntroducedVersion: 5.0.0.0.  Description: Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the account's preferred service for reference when you schedule service activities.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the account's preferred service for reference when you schedule service activities.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred Service, Format: None, SchemaName: PreferredServiceId, IntroducedVersion: 5.0.0.0.  Description: Choose the account's preferred service for reference when you schedule service activities.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the preferred service representative for reference when you schedule service activities for the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the preferred service representative for reference when you schedule service activities for the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Preferred User, Format: None, SchemaName: PreferredSystemUserId, IntroducedVersion: 5.0.0.0.  Description: Choose the preferred service representative for reference when you schedule service activities for the account.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 5.0.0.0.  Description: Choose the primary contact for the account to provide quick access to contact details.</summary>
	[JsonIgnore]
	public string? PrimaryContactIdFormattedValue
	{
		get
		{
			return TryGetValue("_primarycontactid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 5.0.0.0.  Description: Choose the primary contact for the account to provide quick access to contact details.</summary>
	[JsonIgnore]
	public Guid? PrimaryContactId
	{
		get
		{
			return TryGetValue("_primarycontactid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 5.0.0.0.  Description: Choose the primary contact for the account to provide quick access to contact details.</summary>
	[JsonIgnore]
	public Guid? PrimaryContactId_contact
	{
		set
		{
			if (ContainsKey("primarycontactid_contact@odata.bind") is false || Remove("primarycontactid_contact@odata.bind"))
			{
				if (value is not null)
				{
					Add("primarycontactid_contact@odata.bind", $"({value})");
				}
				else
				{
					Add("_primarycontactid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primarycontactid, Format: Text, MaxLength: 100, SchemaName: PrimaryContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? PrimaryContactIdName
	{
		get
		{
			return TryGetValue("primarycontactidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("primarycontactidname") is false || Remove("primarycontactidname"))
			{
				Add("primarycontactidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primarycontactid, Format: Text, MaxLength: 100, SchemaName: PrimaryContactIdYomiName, YomiOf: primarycontactidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? PrimaryContactIdYomiName
	{
		get
		{
			return TryGetValue("primarycontactidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("primarycontactidyominame") is false || Remove("primarycontactidyominame"))
			{
				Add("primarycontactidyominame", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Primary Satori ID, Format: Text, MaxLength: 200, SchemaName: PrimarySatoriId, IntroducedVersion: 8.0.0.0.  Description: Primary Satori ID for Account</summary>
	[JsonIgnore]
	public string? PrimarySatoriId
	{
		get
		{
			return TryGetValue("primarysatoriid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("primarysatoriid") is false || Remove("primarysatoriid"))
			{
				Add("primarysatoriid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Primary Twitter ID, Format: Text, MaxLength: 128, SchemaName: PrimaryTwitterId, IntroducedVersion: 8.0.0.0.  Description: Primary Twitter ID for Account</summary>
	[JsonIgnore]
	public string? PrimaryTwitterId
	{
		get
		{
			return TryGetValue("primarytwitterid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("primarytwitterid") is false || Remove("primarytwitterid"))
			{
				Add("primarytwitterid", value);
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Revenue, IntroducedVersion: 5.0.0.0.  Description: Type the annual revenue for the account, used as an indicator in financial performance analysis.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Revenue, IntroducedVersion: 5.0.0.0.  Description: Type the annual revenue for the account, used as an indicator in financial performance analysis.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue (Base), CalculationOf: revenue, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Revenue_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Annual Revenue (Base), CalculationOf: revenue, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Revenue_Base, IntroducedVersion: 5.0.0.0.  Description: Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Shares Outstanding, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: SharesOutstanding, IntroducedVersion: 5.0.0.0.  Description: Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.</summary>
	[JsonIgnore]
	public int? SharesOutstanding
	{
		get
		{
			return TryGetValue("sharesoutstanding", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("sharesoutstanding") is false || Remove("sharesoutstanding"))
			{
				Add("sharesoutstanding", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method, SchemaName: ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method, SchemaName: ShippingMethodCode, IntroducedVersion: 5.0.0.0.  Description: Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: SIC Code, Format: Text, MaxLength: 20, SchemaName: SIC, IntroducedVersion: 5.0.0.0.  Description: Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Account record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Account record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the Account record.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the account's status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the account's status.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Stock Exchange, Format: Text, MaxLength: 20, SchemaName: StockExchange, IntroducedVersion: 5.0.0.0.  Description: Type the stock exchange at which the account is listed to track their stock and financial performance of the company.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Main Phone, Format: Text, MaxLength: 50, SchemaName: Telephone1, IntroducedVersion: 5.0.0.0.  Description: Type the main phone number for this account.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Other Phone, Format: Text, MaxLength: 50, SchemaName: Telephone2, IntroducedVersion: 5.0.0.0.  Description: Type a second phone number for this account.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Telephone 3, Format: Text, MaxLength: 50, SchemaName: Telephone3, IntroducedVersion: 5.0.0.0.  Description: Type a third phone number for this account.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Territory Code, SchemaName: TerritoryCode, IntroducedVersion: 5.0.0.0.  Description: Select a region or territory for the account for use in segmentation and analysis.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Territory Code, SchemaName: TerritoryCode, IntroducedVersion: 5.0.0.0.  Description: Select a region or territory for the account for use in segmentation and analysis.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Territory, Format: None, SchemaName: TerritoryId, IntroducedVersion: 5.0.0.0.  Description: Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ticker Symbol, Format: TickerSymbol, MaxLength: 10, SchemaName: TickerSymbol, IntroducedVersion: 5.0.0.0.  Description: Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Time Spent by me, Format: Text, MaxLength: 1250, SchemaName: TimeSpentByMeOnEmailAndMeetings, IntroducedVersion: 8.2.0.0.  Description: Total time spent for emails (read and write) and meetings by me in relation to account record.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the account.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Website, Format: Url, MaxLength: 200, SchemaName: WebSiteURL, IntroducedVersion: 5.0.0.0.  Description: Type the account's website URL to get quick details about the company profile.</summary>
	[JsonIgnore]
	public string? WebSiteURL
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Account Name, Format: PhoneticGuide, MaxLength: 160, SchemaName: YomiName, YomiOf: name, IntroducedVersion: 5.0.0.0.  Description: Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.</summary>
	[JsonIgnore]
	public string? YomiName
	{
		get
		{
			return TryGetValue("yominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("yominame") is false || Remove("yominame"))
			{
				Add("yominame", value);
			}
		}
	}

}

