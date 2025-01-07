namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Line item in a contract that specifies the type of service a customer is entitled to.</summary>
public sealed partial class ContractDetail : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contract is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contract is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the contract is associated.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: SystemRequired, DisplayName: Start Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ActiveOn, IntroducedVersion: 5.0.0.0.  Description: Enter the date when the contract line becomes active.</summary>
	[JsonIgnore]
	public DateTime? ActiveOn
	{
		get
		{
			return TryGetValue("activeon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("activeon") is false || Remove("activeon"))
			{
				Add("activeon", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Allotments Overage, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: AllotmentsOverage, IntroducedVersion: 5.0.0.0.  Description: Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the contract line.</summary>
	[JsonIgnore]
	public int? AllotmentsOverage
	{
		get
		{
			return TryGetValue("allotmentsoverage", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("allotmentsoverage") is false || Remove("allotmentsoverage"))
			{
				Add("allotmentsoverage", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Allotments Remaining, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: AllotmentsRemaining, IntroducedVersion: 5.0.0.0.  Description: Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.</summary>
	[JsonIgnore]
	public int? AllotmentsRemaining
	{
		get
		{
			return TryGetValue("allotmentsremaining", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("allotmentsremaining") is false || Remove("allotmentsremaining"))
			{
				Add("allotmentsremaining", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Allotments Used, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: AllotmentsUsed, IntroducedVersion: 5.0.0.0.  Description: Shows the number of cases or minutes used in the resolved cases on the contract line.</summary>
	[JsonIgnore]
	public int? AllotmentsUsed
	{
		get
		{
			return TryGetValue("allotmentsused", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("allotmentsused") is false || Remove("allotmentsused"))
			{
				Add("allotmentsused", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the contact associated with the contract line.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the contact associated with the contract line.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the contact associated with the contract line.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Contract Line, SchemaName: ContractDetailId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contract line.</summary>
	[JsonIgnore]
	public Guid? ContractDetailId
	{
		get
		{
			return TryGetValue("contractdetailid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractdetailid") is false || Remove("contractdetailid"))
			{
				Add("contractdetailid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contract associated with the contract line.</summary>
	[JsonIgnore]
	public string? ContractIdFormattedValue
	{
		get
		{
			return TryGetValue("_contractid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contract associated with the contract line.</summary>
	[JsonIgnore]
	public Guid? ContractId
	{
		get
		{
			return TryGetValue("_contractid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contract associated with the contract line.</summary>
	[JsonIgnore]
	public Guid? ContractId_contract
	{
		set
		{
			if (ContainsKey("contractid_contract@odata.bind") is false || Remove("contractid_contract@odata.bind"))
			{
				if (value is not null)
				{
					Add("contractid_contract@odata.bind", $"({value})");
				}
				else
				{
					Add("_contractid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contractid, Format: Text, MaxLength: 100, SchemaName: ContractIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ContractIdName
	{
		get
		{
			return TryGetValue("contractidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractidname") is false || Remove("contractidname"))
			{
				Add("contractidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Contract State, SchemaName: ContractStateCode, IntroducedVersion: 5.0.0.0.  Description: Status of the contract.</summary>
	[JsonIgnore]
	public string? ContractStateCodeFormattedValue
	{
		get
		{
			return TryGetValue("contractstatecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Contract State, SchemaName: ContractStateCode, IntroducedVersion: 5.0.0.0.  Description: Status of the contract.</summary>
	[JsonIgnore]
	public int? ContractStateCode
	{
		get
		{
			return TryGetValue("contractstatecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractstatecode") is false || Remove("contractstatecode"))
			{
				Add("contractstatecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: contractstatecode, SchemaName: ContractStateCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ContractStateCodeName
	{
		get
		{
			return TryGetValue("contractstatecodename", out var value)
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

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.</summary>
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

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.</summary>
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

	/// <summary>Type: EntityName, RequiredLevel: ApplicationRequired, DisplayName: Customer Type, AttributeOf: customerid, SchemaName: CustomerIdType, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Discount, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Discount, IntroducedVersion: 5.0.0.0.  Description: Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.</summary>
	[JsonIgnore]
	public string? DiscountFormattedValue
	{
		get
		{
			return TryGetValue("discount@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Discount, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Discount, IntroducedVersion: 5.0.0.0.  Description: Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.</summary>
	[JsonIgnore]
	public decimal? Discount
	{
		get
		{
			return TryGetValue("discount", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("discount") is false || Remove("discount"))
			{
				Add("discount", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Discount (Base), CalculationOf: discount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Discount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Discount in base currency.</summary>
	[JsonIgnore]
	public string? Discount_BaseFormattedValue
	{
		get
		{
			return TryGetValue("discount_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Discount (Base), CalculationOf: discount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Discount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Discount in base currency.</summary>
	[JsonIgnore]
	public decimal? Discount_Base
	{
		get
		{
			return TryGetValue("discount_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("discount_base") is false || Remove("discount_base"))
			{
				Add("discount_base", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Discount (%), Precision: 5, MinValue: 0, MaxValue: 100, SchemaName: DiscountPercentage, IntroducedVersion: 5.0.0.0.  Description: Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the contract line.</summary>
	[JsonIgnore]
	public decimal? DiscountPercentage
	{
		get
		{
			return TryGetValue("discountpercentage", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("discountpercentage") is false || Remove("discountpercentage"))
			{
				Add("discountpercentage", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Support Calendar, Format: Text, MaxLength: 168, SchemaName: EffectivityCalendar, IntroducedVersion: 5.0.0.0.  Description: Days of the week and times for which the contract line item is effective.</summary>
	[JsonIgnore]
	public string? EffectivityCalendar
	{
		get
		{
			return TryGetValue("effectivitycalendar", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("effectivitycalendar") is false || Remove("effectivitycalendar"))
			{
				Add("effectivitycalendar", value);
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

	/// <summary>Type: DateTime, RequiredLevel: SystemRequired, DisplayName: End Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ExpiresOn, IntroducedVersion: 5.0.0.0.  Description: Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can change it if required.</summary>
	[JsonIgnore]
	public DateTime? ExpiresOn
	{
		get
		{
			return TryGetValue("expireson", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("expireson") is false || Remove("expireson"))
			{
				Add("expireson", value);
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Quantity, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: InitialQuantity, IntroducedVersion: 5.0.0.0.  Description: Type the number of units of the specified product or service that are eligible for support on the contract line.</summary>
	[JsonIgnore]
	public int? InitialQuantity
	{
		get
		{
			return TryGetValue("initialquantity", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("initialquantity") is false || Remove("initialquantity"))
			{
				Add("initialquantity", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Line Item Order, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: LineItemOrder, IntroducedVersion: 5.0.0.0.  Description: Type the line item number for the contract line to easily identify the contract line and make sure it's listed in the correct order in the parent contract.</summary>
	[JsonIgnore]
	public int? LineItemOrder
	{
		get
		{
			return TryGetValue("lineitemorder", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("lineitemorder") is false || Remove("lineitemorder"))
			{
				Add("lineitemorder", value);
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Net, IntroducedVersion: 5.0.0.0.  Description: Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.</summary>
	[JsonIgnore]
	public string? NetFormattedValue
	{
		get
		{
			return TryGetValue("net@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Net, IntroducedVersion: 5.0.0.0.  Description: Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.</summary>
	[JsonIgnore]
	public decimal? Net
	{
		get
		{
			return TryGetValue("net", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("net") is false || Remove("net"))
			{
				Add("net", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net (Base), CalculationOf: net, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Net_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Net in base currency.</summary>
	[JsonIgnore]
	public string? Net_BaseFormattedValue
	{
		get
		{
			return TryGetValue("net_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net (Base), CalculationOf: net, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Net_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Net in base currency.</summary>
	[JsonIgnore]
	public decimal? Net_Base
	{
		get
		{
			return TryGetValue("net_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("net_base") is false || Remove("net_base"))
			{
				Add("net_base", value);
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

	/// <summary>Type: Owner, RequiredLevel: ApplicationRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: Owner, RequiredLevel: ApplicationRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: Money, RequiredLevel: SystemRequired, DisplayName: Total Price, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: Price, IntroducedVersion: 5.0.0.0.  Description: Type the total service charge for the contract line before any discounts are credited.</summary>
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

	/// <summary>Type: Money, RequiredLevel: SystemRequired, DisplayName: Total Price, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: Price, IntroducedVersion: 5.0.0.0.  Description: Type the total service charge for the contract line before any discounts are credited.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Price (Base), CalculationOf: price, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Price_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Total Price in base currency.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Price (Base), CalculationOf: price, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Price_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Total Price in base currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product that is eligible for services on the contract line.</summary>
	[JsonIgnore]
	public string? ProductIdFormattedValue
	{
		get
		{
			return TryGetValue("_productid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product that is eligible for services on the contract line.</summary>
	[JsonIgnore]
	public Guid? ProductId
	{
		get
		{
			return TryGetValue("_productid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product that is eligible for services on the contract line.</summary>
	[JsonIgnore]
	public Guid? ProductId_product
	{
		set
		{
			if (ContainsKey("productid_product@odata.bind") is false || Remove("productid_product@odata.bind"))
			{
				if (value is not null)
				{
					Add("productid_product@odata.bind", $"({value})");
				}
				else
				{
					Add("_productid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: productid, Format: Text, MaxLength: 100, SchemaName: ProductIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ProductIdName
	{
		get
		{
			return TryGetValue("productidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("productidname") is false || Remove("productidname"))
			{
				Add("productidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Serial Number, Format: Text, MaxLength: 100, SchemaName: ProductSerialNumber, IntroducedVersion: 5.0.0.0.  Description: Type the serial number for the product that is eligible for services on the contract line.</summary>
	[JsonIgnore]
	public string? ProductSerialNumber
	{
		get
		{
			return TryGetValue("productserialnumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("productserialnumber") is false || Remove("productserialnumber"))
			{
				Add("productserialnumber", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Rate, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Rate, IntroducedVersion: 5.0.0.0.  Description: Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.</summary>
	[JsonIgnore]
	public string? RateFormattedValue
	{
		get
		{
			return TryGetValue("rate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Rate, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: Rate, IntroducedVersion: 5.0.0.0.  Description: Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.</summary>
	[JsonIgnore]
	public decimal? Rate
	{
		get
		{
			return TryGetValue("rate", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("rate") is false || Remove("rate"))
			{
				Add("rate", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Rate (Base), CalculationOf: rate, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Rate_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Rate in base currency.</summary>
	[JsonIgnore]
	public string? Rate_BaseFormattedValue
	{
		get
		{
			return TryGetValue("rate_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Rate (Base), CalculationOf: rate, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: Rate_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Rate in base currency.</summary>
	[JsonIgnore]
	public decimal? Rate_Base
	{
		get
		{
			return TryGetValue("rate_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("rate_base") is false || Remove("rate_base"))
			{
				Add("rate_base", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Location, Format: None, SchemaName: ServiceAddress, IntroducedVersion: 5.0.0.0.  Description: Choose the address for the customer account or contact where the services are provided.</summary>
	[JsonIgnore]
	public string? ServiceAddressFormattedValue
	{
		get
		{
			return TryGetValue("_serviceaddress_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Location, Format: None, SchemaName: ServiceAddress, IntroducedVersion: 5.0.0.0.  Description: Choose the address for the customer account or contact where the services are provided.</summary>
	[JsonIgnore]
	public Guid? ServiceAddress
	{
		get
		{
			return TryGetValue("_serviceaddress_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Location, Format: None, SchemaName: ServiceAddress, IntroducedVersion: 5.0.0.0.  Description: Choose the address for the customer account or contact where the services are provided.</summary>
	[JsonIgnore]
	public Guid? ServiceAddress_customeraddress
	{
		set
		{
			if (ContainsKey("serviceaddress_customeraddress@odata.bind") is false || Remove("serviceaddress_customeraddress@odata.bind"))
			{
				if (value is not null)
				{
					Add("serviceaddress_customeraddress@odata.bind", $"({value})");
				}
				else
				{
					Add("_serviceaddress_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: serviceaddress, Format: Text, MaxLength: 100, SchemaName: ServiceAddressName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ServiceAddressName
	{
		get
		{
			return TryGetValue("serviceaddressname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("serviceaddressname") is false || Remove("serviceaddressname"))
			{
				Add("serviceaddressname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Contract Units, SchemaName: ServiceContractUnitsCode, IntroducedVersion: 5.0.0.0.  Description: Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.</summary>
	[JsonIgnore]
	public string? ServiceContractUnitsCodeFormattedValue
	{
		get
		{
			return TryGetValue("servicecontractunitscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Contract Units, SchemaName: ServiceContractUnitsCode, IntroducedVersion: 5.0.0.0.  Description: Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.</summary>
	[JsonIgnore]
	public int? ServiceContractUnitsCode
	{
		get
		{
			return TryGetValue("servicecontractunitscode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("servicecontractunitscode") is false || Remove("servicecontractunitscode"))
			{
				Add("servicecontractunitscode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: servicecontractunitscode, SchemaName: ServiceContractUnitsCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ServiceContractUnitsCodeName
	{
		get
		{
			return TryGetValue("servicecontractunitscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the contract line's status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the contract line's status.</summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Title, Format: Text, MaxLength: 500, SchemaName: Title, IntroducedVersion: 5.0.0.0.  Description: Type a title or name that describes the contract line.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Total Allotments, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: TotalAllotments, IntroducedVersion: 5.0.0.0.  Description: Type the total number of minutes or cases allowed for the contract line.</summary>
	[JsonIgnore]
	public int? TotalAllotments
	{
		get
		{
			return TryGetValue("totalallotments", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("totalallotments") is false || Remove("totalallotments"))
			{
				Add("totalallotments", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Unit, Format: None, SchemaName: UoMId, IntroducedVersion: 5.0.0.0.  Description: Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.</summary>
	[JsonIgnore]
	public string? UoMIdFormattedValue
	{
		get
		{
			return TryGetValue("_uomid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Unit, Format: None, SchemaName: UoMId, IntroducedVersion: 5.0.0.0.  Description: Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.</summary>
	[JsonIgnore]
	public Guid? UoMId
	{
		get
		{
			return TryGetValue("_uomid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Unit, Format: None, SchemaName: UoMId, IntroducedVersion: 5.0.0.0.  Description: Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.</summary>
	[JsonIgnore]
	public Guid? UoMId_uom
	{
		set
		{
			if (ContainsKey("uomid_uom@odata.bind") is false || Remove("uomid_uom@odata.bind"))
			{
				if (value is not null)
				{
					Add("uomid_uom@odata.bind", $"({value})");
				}
				else
				{
					Add("_uomid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: uomid, Format: Text, MaxLength: 100, SchemaName: UoMIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? UoMIdName
	{
		get
		{
			return TryGetValue("uomidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("uomidname") is false || Remove("uomidname"))
			{
				Add("uomidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Unit Schedule, Format: None, SchemaName: UoMScheduleId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the unit group associated with the contract line.</summary>
	[JsonIgnore]
	public string? UoMScheduleIdFormattedValue
	{
		get
		{
			return TryGetValue("_uomscheduleid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Unit Schedule, Format: None, SchemaName: UoMScheduleId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the unit group associated with the contract line.</summary>
	[JsonIgnore]
	public Guid? UoMScheduleId
	{
		get
		{
			return TryGetValue("_uomscheduleid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Unit Schedule, Format: None, SchemaName: UoMScheduleId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the unit group associated with the contract line.</summary>
	[JsonIgnore]
	public Guid? UoMScheduleId_uomschedule
	{
		set
		{
			if (ContainsKey("uomscheduleid_uomschedule@odata.bind") is false || Remove("uomscheduleid_uomschedule@odata.bind"))
			{
				if (value is not null)
				{
					Add("uomscheduleid_uomschedule@odata.bind", $"({value})");
				}
				else
				{
					Add("_uomscheduleid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: uomscheduleid, Format: Text, MaxLength: 100, SchemaName: UoMScheduleIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? UoMScheduleIdName
	{
		get
		{
			return TryGetValue("uomscheduleidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("uomscheduleidname") is false || Remove("uomscheduleidname"))
			{
				Add("uomscheduleidname", value);
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

