namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Agreement to provide customer service during a specified amount of time or number of cases.</summary>
public sealed partial class Contract : Dictionary<string, object>
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

	/// <summary>Type: DateTime, RequiredLevel: SystemRequired, DisplayName: Contract Start Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ActiveOn, IntroducedVersion: 5.0.0.0.  Description: Enter the date when the contract becomes active.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Allotment Type, SchemaName: AllotmentTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of allotment that the contract supports.</summary>
	[JsonIgnore]
	public string? AllotmentTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("allotmenttypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Allotment Type, SchemaName: AllotmentTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of allotment that the contract supports.</summary>
	[JsonIgnore]
	public int? AllotmentTypeCode
	{
		get
		{
			return TryGetValue("allotmenttypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("allotmenttypecode") is false || Remove("allotmenttypecode"))
			{
				Add("allotmenttypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allotmenttypecode, SchemaName: AllotmentTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? AllotmentTypeCodeName
	{
		get
		{
			return TryGetValue("allotmenttypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Billing Account, Format: None, SchemaName: BillingAccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account to which the contract is to be billed.</summary>
	[JsonIgnore]
	public string? BillingAccountIdFormattedValue
	{
		get
		{
			return TryGetValue("_billingaccountid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Billing Account, Format: None, SchemaName: BillingAccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account to which the contract is to be billed.</summary>
	[JsonIgnore]
	public Guid? BillingAccountId
	{
		get
		{
			return TryGetValue("_billingaccountid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Billing Account, Format: None, SchemaName: BillingAccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account to which the contract is to be billed.</summary>
	[JsonIgnore]
	public Guid? BillingAccountId_account
	{
		set
		{
			if (ContainsKey("billingaccountid_account@odata.bind") is false || Remove("billingaccountid_account@odata.bind"))
			{
				if (value is not null)
				{
					Add("billingaccountid_account@odata.bind", $"({value})");
				}
				else
				{
					Add("_billingaccountid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: billingaccountid, Format: Text, MaxLength: 100, SchemaName: BillingAccountIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillingAccountIdName
	{
		get
		{
			return TryGetValue("billingaccountidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingaccountidname") is false || Remove("billingaccountidname"))
			{
				Add("billingaccountidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: billingaccountid, Format: Text, MaxLength: 100, SchemaName: BillingAccountIdYomiName, YomiOf: billingaccountidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillingAccountIdYomiName
	{
		get
		{
			return TryGetValue("billingaccountidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingaccountidyominame") is false || Remove("billingaccountidyominame"))
			{
				Add("billingaccountidyominame", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Billing Contact, Format: None, SchemaName: BillingContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact to whom the contract is to be billed.</summary>
	[JsonIgnore]
	public string? BillingContactIdFormattedValue
	{
		get
		{
			return TryGetValue("_billingcontactid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Billing Contact, Format: None, SchemaName: BillingContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact to whom the contract is to be billed.</summary>
	[JsonIgnore]
	public Guid? BillingContactId
	{
		get
		{
			return TryGetValue("_billingcontactid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Billing Contact, Format: None, SchemaName: BillingContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact to whom the contract is to be billed.</summary>
	[JsonIgnore]
	public Guid? BillingContactId_contact
	{
		set
		{
			if (ContainsKey("billingcontactid_contact@odata.bind") is false || Remove("billingcontactid_contact@odata.bind"))
			{
				if (value is not null)
				{
					Add("billingcontactid_contact@odata.bind", $"({value})");
				}
				else
				{
					Add("_billingcontactid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: billingcontactid, Format: Text, MaxLength: 100, SchemaName: BillingContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillingContactIdName
	{
		get
		{
			return TryGetValue("billingcontactidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingcontactidname") is false || Remove("billingcontactidname"))
			{
				Add("billingcontactidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: billingcontactid, Format: Text, MaxLength: 100, SchemaName: BillingContactIdYomiName, YomiOf: billingcontactidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillingContactIdYomiName
	{
		get
		{
			return TryGetValue("billingcontactidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingcontactidyominame") is false || Remove("billingcontactidyominame"))
			{
				Add("billingcontactidyominame", value);
			}
		}
	}

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Bill To Customer, Format: None, SchemaName: BillingCustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to which the contract should be billed to provide a quick link to address and other customer details.</summary>
	[JsonIgnore]
	public string? BillingCustomerIdFormattedValue
	{
		get
		{
			return TryGetValue("_billingcustomerid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Bill To Customer, Format: None, SchemaName: BillingCustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to which the contract should be billed to provide a quick link to address and other customer details.</summary>
	[JsonIgnore]
	public Guid? BillingCustomerId
	{
		get
		{
			return TryGetValue("_billingcustomerid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: billingcustomerid, Format: Text, MaxLength: 160, SchemaName: BillingCustomerIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillingCustomerIdName
	{
		get
		{
			return TryGetValue("billingcustomeridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingcustomeridname") is false || Remove("billingcustomeridname"))
			{
				Add("billingcustomeridname", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: ApplicationRequired, DisplayName: Bill To Customer Type, AttributeOf: billingcustomerid, SchemaName: BillingCustomerIdType, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillingCustomerIdType
	{
		get
		{
			return TryGetValue("billingcustomeridtype", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingcustomeridtype") is false || Remove("billingcustomeridtype"))
			{
				Add("billingcustomeridtype", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: billingcustomerid, Format: Text, MaxLength: 450, SchemaName: BillingCustomerIdYomiName, YomiOf: billingcustomeridname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillingCustomerIdYomiName
	{
		get
		{
			return TryGetValue("billingcustomeridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingcustomeridyominame") is false || Remove("billingcustomeridyominame"))
			{
				Add("billingcustomeridyominame", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Billing End Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: BillingEndOn, IntroducedVersion: 5.0.0.0.  Description: Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a service.</summary>
	[JsonIgnore]
	public DateTime? BillingEndOn
	{
		get
		{
			return TryGetValue("billingendon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingendon") is false || Remove("billingendon"))
			{
				Add("billingendon", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Billing Frequency, SchemaName: BillingFrequencyCode, IntroducedVersion: 5.0.0.0.  Description: Select the billing schedule of the contract to indicate how often the customer should be invoiced.</summary>
	[JsonIgnore]
	public string? BillingFrequencyCodeFormattedValue
	{
		get
		{
			return TryGetValue("billingfrequencycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Billing Frequency, SchemaName: BillingFrequencyCode, IntroducedVersion: 5.0.0.0.  Description: Select the billing schedule of the contract to indicate how often the customer should be invoiced.</summary>
	[JsonIgnore]
	public int? BillingFrequencyCode
	{
		get
		{
			return TryGetValue("billingfrequencycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingfrequencycode") is false || Remove("billingfrequencycode"))
			{
				Add("billingfrequencycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: billingfrequencycode, SchemaName: BillingFrequencyCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? BillingFrequencyCodeName
	{
		get
		{
			return TryGetValue("billingfrequencycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Billing Start Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: BillingStartOn, IntroducedVersion: 5.0.0.0.  Description: Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a service. This defaults to the same date that is selected in the Contract Start Date field.</summary>
	[JsonIgnore]
	public DateTime? BillingStartOn
	{
		get
		{
			return TryGetValue("billingstarton", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("billingstarton") is false || Remove("billingstarton"))
			{
				Add("billingstarton", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Bill To Address, Format: None, SchemaName: BillToAddress, IntroducedVersion: 5.0.0.0.  Description: Choose which address to send the invoice to.</summary>
	[JsonIgnore]
	public string? BillToAddressFormattedValue
	{
		get
		{
			return TryGetValue("_billtoaddress_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Bill To Address, Format: None, SchemaName: BillToAddress, IntroducedVersion: 5.0.0.0.  Description: Choose which address to send the invoice to.</summary>
	[JsonIgnore]
	public Guid? BillToAddress
	{
		get
		{
			return TryGetValue("_billtoaddress_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Bill To Address, Format: None, SchemaName: BillToAddress, IntroducedVersion: 5.0.0.0.  Description: Choose which address to send the invoice to.</summary>
	[JsonIgnore]
	public Guid? BillToAddress_customeraddress
	{
		set
		{
			if (ContainsKey("billtoaddress_customeraddress@odata.bind") is false || Remove("billtoaddress_customeraddress@odata.bind"))
			{
				if (value is not null)
				{
					Add("billtoaddress_customeraddress@odata.bind", $"({value})");
				}
				else
				{
					Add("_billtoaddress_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: billtoaddress, Format: Text, MaxLength: 100, SchemaName: BillToAddressName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? BillToAddressName
	{
		get
		{
			return TryGetValue("billtoaddressname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("billtoaddressname") is false || Remove("billtoaddressname"))
			{
				Add("billtoaddressname", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Cancellation Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: CancelOn, IntroducedVersion: 5.0.0.0.  Description: Shows the date and time when the contract was canceled.</summary>
	[JsonIgnore]
	public DateTime? CancelOn
	{
		get
		{
			return TryGetValue("cancelon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("cancelon") is false || Remove("cancelon"))
			{
				Add("cancelon", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact specified for the contract.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact specified for the contract.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact specified for the contract.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Contract, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contract.</summary>
	[JsonIgnore]
	public Guid? ContractId
	{
		get
		{
			return TryGetValue("contractid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractid") is false || Remove("contractid"))
			{
				Add("contractid", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: ContractLanguage, IntroducedVersion: 5.0.0.0.  Description: Type additional information about the contract, such as the products or services provided to the customer.</summary>
	[JsonIgnore]
	public string? ContractLanguage
	{
		get
		{
			return TryGetValue("contractlanguage", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractlanguage") is false || Remove("contractlanguage"))
			{
				Add("contractlanguage", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Contract ID, AutoNumberFormat: CNR-{SEQNUM:5}-{RANDSTRING:6}, Format: Text, MaxLength: 100, SchemaName: ContractNumber, IntroducedVersion: 5.0.0.0.  Description: Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.</summary>
	[JsonIgnore]
	public string? ContractNumber
	{
		get
		{
			return TryGetValue("contractnumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractnumber") is false || Remove("contractnumber"))
			{
				Add("contractnumber", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Level, SchemaName: ContractServiceLevelCode, IntroducedVersion: 5.0.0.0.  Description: Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.</summary>
	[JsonIgnore]
	public string? ContractServiceLevelCodeFormattedValue
	{
		get
		{
			return TryGetValue("contractservicelevelcode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Level, SchemaName: ContractServiceLevelCode, IntroducedVersion: 5.0.0.0.  Description: Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.</summary>
	[JsonIgnore]
	public int? ContractServiceLevelCode
	{
		get
		{
			return TryGetValue("contractservicelevelcode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractservicelevelcode") is false || Remove("contractservicelevelcode"))
			{
				Add("contractservicelevelcode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: contractservicelevelcode, SchemaName: ContractServiceLevelCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ContractServiceLevelCodeName
	{
		get
		{
			return TryGetValue("contractservicelevelcodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Template Abbreviation, Format: Text, MaxLength: 20, SchemaName: ContractTemplateAbbreviation, IntroducedVersion: 5.0.0.0.  Description: Shows the abbreviation of the contract template selected when the contract is created.</summary>
	[JsonIgnore]
	public string? ContractTemplateAbbreviation
	{
		get
		{
			return TryGetValue("contracttemplateabbreviation", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contracttemplateabbreviation") is false || Remove("contracttemplateabbreviation"))
			{
				Add("contracttemplateabbreviation", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Contract Template, Format: None, SchemaName: ContractTemplateId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.</summary>
	[JsonIgnore]
	public string? ContractTemplateIdFormattedValue
	{
		get
		{
			return TryGetValue("_contracttemplateid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Contract Template, Format: None, SchemaName: ContractTemplateId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.</summary>
	[JsonIgnore]
	public Guid? ContractTemplateId
	{
		get
		{
			return TryGetValue("_contracttemplateid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Contract Template, Format: None, SchemaName: ContractTemplateId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.</summary>
	[JsonIgnore]
	public Guid? ContractTemplateId_contracttemplate
	{
		set
		{
			if (ContainsKey("contracttemplateid_contracttemplate@odata.bind") is false || Remove("contracttemplateid_contracttemplate@odata.bind"))
			{
				if (value is not null)
				{
					Add("contracttemplateid_contracttemplate@odata.bind", $"({value})");
				}
				else
				{
					Add("_contracttemplateid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: contracttemplateid, Format: Text, MaxLength: 100, SchemaName: ContractTemplateIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ContractTemplateIdName
	{
		get
		{
			return TryGetValue("contracttemplateidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contracttemplateidname") is false || Remove("contracttemplateidname"))
			{
				Add("contracttemplateidname", value);
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Duration, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: Duration, IntroducedVersion: 5.0.0.0.  Description: Shows for the duration of the contract, in days, based on the contract start and end dates.</summary>
	[JsonIgnore]
	public int? Duration
	{
		get
		{
			return TryGetValue("duration", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("duration") is false || Remove("duration"))
			{
				Add("duration", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Support Calendar, Format: Text, MaxLength: 168, SchemaName: EffectivityCalendar, IntroducedVersion: 5.0.0.0.  Description: Days of the week and times during which customer service support is available for the duration of the contract.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address, Format: Email, MaxLength: 100, SchemaName: EmailAddress, IntroducedVersion: 5.0.0.0.  Description: The primary email address for the entity.</summary>
	[JsonIgnore]
	public string? EmailAddress
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

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Entity Image, AttributeOf: entityimageid, MaxSizeInKb: 10240, MaxHeight: 144, MaxWidth: 144, MaxSizeInKb: 10240, SchemaName: EntityImage, IntroducedVersion: 6.0.0.0.  Description: The default image for the entity.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: SystemRequired, DisplayName: Contract End Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ExpiresOn, IntroducedVersion: 5.0.0.0.  Description: Enter the date when the contract expires.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net Price, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: NetPrice, IntroducedVersion: 5.0.0.0.  Description: Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.</summary>
	[JsonIgnore]
	public string? NetPriceFormattedValue
	{
		get
		{
			return TryGetValue("netprice@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net Price, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: NetPrice, IntroducedVersion: 5.0.0.0.  Description: Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.</summary>
	[JsonIgnore]
	public decimal? NetPrice
	{
		get
		{
			return TryGetValue("netprice", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("netprice") is false || Remove("netprice"))
			{
				Add("netprice", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net Price (Base), CalculationOf: netprice, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: NetPrice_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Net Price in base currency.</summary>
	[JsonIgnore]
	public string? NetPrice_BaseFormattedValue
	{
		get
		{
			return TryGetValue("netprice_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Net Price (Base), CalculationOf: netprice, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: NetPrice_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Net Price in base currency.</summary>
	[JsonIgnore]
	public decimal? NetPrice_Base
	{
		get
		{
			return TryGetValue("netprice_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("netprice_base") is false || Remove("netprice_base"))
			{
				Add("netprice_base", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Contract, Format: None, SchemaName: OriginatingContract, IntroducedVersion: 5.0.0.0.  Description: Choose the original contract that this contract was created from. This information is used to track renewal history.</summary>
	[JsonIgnore]
	public string? OriginatingContractFormattedValue
	{
		get
		{
			return TryGetValue("_originatingcontract_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Contract, Format: None, SchemaName: OriginatingContract, IntroducedVersion: 5.0.0.0.  Description: Choose the original contract that this contract was created from. This information is used to track renewal history.</summary>
	[JsonIgnore]
	public Guid? OriginatingContract
	{
		get
		{
			return TryGetValue("_originatingcontract_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Originating Contract, Format: None, SchemaName: OriginatingContract, IntroducedVersion: 5.0.0.0.  Description: Choose the original contract that this contract was created from. This information is used to track renewal history.</summary>
	[JsonIgnore]
	public Guid? OriginatingContract_contract
	{
		set
		{
			if (ContainsKey("originatingcontract_contract@odata.bind") is false || Remove("originatingcontract_contract@odata.bind"))
			{
				if (value is not null)
				{
					Add("originatingcontract_contract@odata.bind", $"({value})");
				}
				else
				{
					Add("_originatingcontract_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: originatingcontract, Format: Text, MaxLength: 100, SchemaName: OriginatingContractName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? OriginatingContractName
	{
		get
		{
			return TryGetValue("originatingcontractname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("originatingcontractname") is false || Remove("originatingcontractname"))
			{
				Add("originatingcontractname", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Address, Format: None, SchemaName: ServiceAddress, IntroducedVersion: 5.0.0.0.  Description: Choose the address for the customer account or contact where the services are provided.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Address, Format: None, SchemaName: ServiceAddress, IntroducedVersion: 5.0.0.0.  Description: Choose the address for the customer account or contact where the services are provided.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Address, Format: None, SchemaName: ServiceAddress, IntroducedVersion: 5.0.0.0.  Description: Choose the address for the customer account or contact where the services are provided.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the contract's status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the contract's status.</summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Contract Name, Format: Text, MaxLength: 100, SchemaName: Title, IntroducedVersion: 5.0.0.0.  Description: Type a title or name for the contract that indicates the purpose of the contract.</summary>
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

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Discount, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: TotalDiscount, IntroducedVersion: 5.0.0.0.  Description: Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.</summary>
	[JsonIgnore]
	public string? TotalDiscountFormattedValue
	{
		get
		{
			return TryGetValue("totaldiscount@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Discount, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: TotalDiscount, IntroducedVersion: 5.0.0.0.  Description: Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.</summary>
	[JsonIgnore]
	public decimal? TotalDiscount
	{
		get
		{
			return TryGetValue("totaldiscount", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("totaldiscount") is false || Remove("totaldiscount"))
			{
				Add("totaldiscount", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Discount (Base), CalculationOf: totaldiscount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: TotalDiscount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Total Discount in base currency.</summary>
	[JsonIgnore]
	public string? TotalDiscount_BaseFormattedValue
	{
		get
		{
			return TryGetValue("totaldiscount_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Discount (Base), CalculationOf: totaldiscount, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: TotalDiscount_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Total Discount in base currency.</summary>
	[JsonIgnore]
	public decimal? TotalDiscount_Base
	{
		get
		{
			return TryGetValue("totaldiscount_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("totaldiscount_base") is false || Remove("totaldiscount_base"))
			{
				Add("totaldiscount_base", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Price, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: TotalPrice, IntroducedVersion: 5.0.0.0.  Description: Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.</summary>
	[JsonIgnore]
	public string? TotalPriceFormattedValue
	{
		get
		{
			return TryGetValue("totalprice@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Price, Precision: 2, MinValue: 0, MaxValue: 100000000000000, SchemaName: TotalPrice, IntroducedVersion: 5.0.0.0.  Description: Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.</summary>
	[JsonIgnore]
	public decimal? TotalPrice
	{
		get
		{
			return TryGetValue("totalprice", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("totalprice") is false || Remove("totalprice"))
			{
				Add("totalprice", value);
			}
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Price (Base), CalculationOf: totalprice, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: TotalPrice_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Total Price in base currency.</summary>
	[JsonIgnore]
	public string? TotalPrice_BaseFormattedValue
	{
		get
		{
			return TryGetValue("totalprice_base@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Money, RequiredLevel: None, DisplayName: Total Price (Base), CalculationOf: totalprice, Precision: 4, MinValue: -922337203685477, MaxValue: 922337203685477, SchemaName: TotalPrice_Base, IntroducedVersion: 5.0.0.0.  Description: Value of the Total Price in base currency.</summary>
	[JsonIgnore]
	public decimal? TotalPrice_Base
	{
		get
		{
			return TryGetValue("totalprice_base", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("totalprice_base") is false || Remove("totalprice_base"))
			{
				Add("totalprice_base", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Discount, SchemaName: UseDiscountAsPercentage, IntroducedVersion: 5.0.0.0.  Description: Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.</summary>
	[JsonIgnore]
	public string? UseDiscountAsPercentageFormattedValue
	{
		get
		{
			return TryGetValue("usediscountaspercentage@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Discount, SchemaName: UseDiscountAsPercentage, IntroducedVersion: 5.0.0.0.  Description: Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.</summary>
	[JsonIgnore]
	public bool? UseDiscountAsPercentage
	{
		get
		{
			return TryGetValue("usediscountaspercentage", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("usediscountaspercentage") is false || Remove("usediscountaspercentage"))
			{
				Add("usediscountaspercentage", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: usediscountaspercentage, SchemaName: UseDiscountAsPercentageName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? UseDiscountAsPercentageName
	{
		get
		{
			return TryGetValue("usediscountaspercentagename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

