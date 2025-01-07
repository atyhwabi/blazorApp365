namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Defines the amount and type of support a customer should receive.</summary>
public sealed partial class Entitlement : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Account associated with Entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Account associated with Entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Account associated with Entitlement.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 450, SchemaName: AccountIdName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: accountid, Format: Text, MaxLength: 450, SchemaName: AccountIdYomiName, YomiOf: accountidname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Allocation Type, SchemaName: AllocationTypeCode, IntroducedVersion: 6.1.0.0.  Description: Select the type of entitlement terms.</summary>
	[JsonIgnore]
	public string? AllocationTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("allocationtypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Allocation Type, SchemaName: AllocationTypeCode, IntroducedVersion: 6.1.0.0.  Description: Select the type of entitlement terms.</summary>
	[JsonIgnore]
	public int? AllocationTypeCode
	{
		get
		{
			return TryGetValue("allocationtypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("allocationtypecode") is false || Remove("allocationtypecode"))
			{
				Add("allocationtypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: allocationtypecode, SchemaName: AllocationTypeCodeName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? AllocationTypeCodeName
	{
		get
		{
			return TryGetValue("allocationtypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Contact associated with Entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Contact associated with Entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Contact associated with Entitlement.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contactid, Format: Text, MaxLength: 100, SchemaName: ContactIdName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contactid, Format: Text, MaxLength: 100, SchemaName: ContactIdYomiName, YomiOf: contactidname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 6.1.0.0.  Description: Date and time when the record was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who created the entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who created the entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who created the entitlement.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 6.1.0.0.  Description: Choose a contact or account for which this entitlement has been defined.</summary>
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

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 6.1.0.0.  Description: Choose a contact or account for which this entitlement has been defined.</summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, AttributeOf: customerid, Format: Text, MaxLength: 160, SchemaName: CustomerIdName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: EntityName, RequiredLevel: ApplicationRequired, DisplayName: Customer Type, AttributeOf: customerid, SchemaName: CustomerIdType, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: customerid, Format: Text, MaxLength: 450, SchemaName: CustomerIdYomiName, YomiOf: customeridname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Decrease Remaining On, SchemaName: DecreaseRemainingOn, IntroducedVersion: 6.1.0.0.  Description: Select whether to decrease the remaining terms when the case is created or when it is resolved.</summary>
	[JsonIgnore]
	public string? DecreaseRemainingOnFormattedValue
	{
		get
		{
			return TryGetValue("decreaseremainingon@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Decrease Remaining On, SchemaName: DecreaseRemainingOn, IntroducedVersion: 6.1.0.0.  Description: Select whether to decrease the remaining terms when the case is created or when it is resolved.</summary>
	[JsonIgnore]
	public int? DecreaseRemainingOn
	{
		get
		{
			return TryGetValue("decreaseremainingon", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("decreaseremainingon") is false || Remove("decreaseremainingon"))
			{
				Add("decreaseremainingon", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: decreaseremainingon, SchemaName: DecreaseRemainingOnName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? DecreaseRemainingOnName
	{
		get
		{
			return TryGetValue("decreaseremainingonname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 6.1.0.0.  Description: Type additional information to describe the Entitlement</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email Address, Format: Email, MaxLength: 100, SchemaName: EmailAddress, IntroducedVersion: 6.1.0.0.  Description: The primary email address for the entity.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: SystemRequired, DisplayName: End Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: EndDate, IntroducedVersion: 6.1.0.0.  Description: Enter the date when the entitlement ends.</summary>
	[JsonIgnore]
	public DateTime? EndDate
	{
		get
		{
			return TryGetValue("enddate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("enddate") is false || Remove("enddate"))
			{
				Add("enddate", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Entitlement, SchemaName: EntitlementId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for entity instances</summary>
	[JsonIgnore]
	public Guid? EntitlementId
	{
		get
		{
			return TryGetValue("entitlementid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("entitlementid") is false || Remove("entitlementid"))
			{
				Add("entitlementid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement Template, Format: None, SchemaName: EntitlementTemplateId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Entitlement Template associated with Entitlement.</summary>
	[JsonIgnore]
	public string? EntitlementTemplateIdFormattedValue
	{
		get
		{
			return TryGetValue("_entitlementtemplateid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement Template, Format: None, SchemaName: EntitlementTemplateId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Entitlement Template associated with Entitlement.</summary>
	[JsonIgnore]
	public Guid? EntitlementTemplateId
	{
		get
		{
			return TryGetValue("_entitlementtemplateid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement Template, Format: None, SchemaName: EntitlementTemplateId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for Entitlement Template associated with Entitlement.</summary>
	[JsonIgnore]
	public Guid? EntitlementTemplateId_entitlementtemplate
	{
		set
		{
			if (ContainsKey("entitlementtemplateid_entitlementtemplate@odata.bind") is false || Remove("entitlementtemplateid_entitlementtemplate@odata.bind"))
			{
				if (value is not null)
				{
					Add("entitlementtemplateid_entitlementtemplate@odata.bind", $"({value})");
				}
				else
				{
					Add("_entitlementtemplateid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: entitlementtemplateid, Format: Text, MaxLength: 100, SchemaName: EntitlementTemplateIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? EntitlementTemplateIdName
	{
		get
		{
			return TryGetValue("entitlementtemplateidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("entitlementtemplateidname") is false || Remove("entitlementtemplateidname"))
			{
				Add("entitlementtemplateidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Entity Type, SchemaName: entitytype, IntroducedVersion: 9.0.0.20.  Description: Entity type for which the entitlement applies</summary>
	[JsonIgnore]
	public string? entitytypeFormattedValue
	{
		get
		{
			return TryGetValue("entitytype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Entity Type, SchemaName: entitytype, IntroducedVersion: 9.0.0.20.  Description: Entity type for which the entitlement applies</summary>
	[JsonIgnore]
	public int? entitytype
	{
		get
		{
			return TryGetValue("entitytype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("entitytype") is false || Remove("entitytype"))
			{
				Add("entitytype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: entitytype, SchemaName: entitytypeName, IntroducedVersion: 9.0.0.20. </summary>
	[JsonIgnore]
	public object? entitytypeName
	{
		get
		{
			return TryGetValue("entitytypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 10, MinValue: 1E-10, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 6.1.0.0.  Description: Exchange rate for the currency associated with the contact with respect to the base currency.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 6.1.0.0.  Description: Sequence number of the import that created this record.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, DisplayName: Is Default, SchemaName: IsDefault, IntroducedVersion: 7.1.0.0.  Description: Shows whether this entitlement is the default one for the specified customer.</summary>
	[JsonIgnore]
	public string? IsDefaultFormattedValue
	{
		get
		{
			return TryGetValue("isdefault@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, DisplayName: Is Default, SchemaName: IsDefault, IntroducedVersion: 7.1.0.0.  Description: Shows whether this entitlement is the default one for the specified customer.</summary>
	[JsonIgnore]
	public bool? IsDefault
	{
		get
		{
			return TryGetValue("isdefault", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdefault") is false || Remove("isdefault"))
			{
				Add("isdefault", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdefault, SchemaName: IsDefaultName, IntroducedVersion: 7.1.0.0. </summary>
	[JsonIgnore]
	public object? IsDefaultName
	{
		get
		{
			return TryGetValue("isdefaultname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: KB Access Level, SchemaName: KbAccessLevel, IntroducedVersion: 6.1.0.0.  Description: Select the access someone will have to the knowledge base on the portal.</summary>
	[JsonIgnore]
	public string? KbAccessLevelFormattedValue
	{
		get
		{
			return TryGetValue("kbaccesslevel@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: KB Access Level, SchemaName: KbAccessLevel, IntroducedVersion: 6.1.0.0.  Description: Select the access someone will have to the knowledge base on the portal.</summary>
	[JsonIgnore]
	public int? KbAccessLevel
	{
		get
		{
			return TryGetValue("kbaccesslevel", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("kbaccesslevel") is false || Remove("kbaccesslevel"))
			{
				Add("kbaccesslevel", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: kbaccesslevel, SchemaName: KbAccessLevelName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? KbAccessLevelName
	{
		get
		{
			return TryGetValue("kbaccesslevelname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 6.1.0.0.  Description: Date and time when the record was modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Entitlement Name, Format: Text, MaxLength: 100, SchemaName: Name, IntroducedVersion: 6.1.0.0.  Description: Type a meaningful name for the entitlement.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 6.1.0.0.  Description: Date and time that the record was migrated.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 6.1.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 6.1.0.0.  Description: Owner Id</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 6.1.0.0.  Description: Name of the owner</summary>
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

	/// <summary>Type: EntityName, RequiredLevel: None, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 6.1.0.0.  Description: Owner Id Type</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 6.1.0.0.  Description: Yomi name of the owner</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 100, SchemaName: OwningBusinessUnitName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process Id, SchemaName: ProcessId, IntroducedVersion: 6.1.0.0.  Description: Contains the id of the process associated with the entity.</summary>
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Remaining Terms, Precision: 2, MinValue: -100000000000, MaxValue: 100000000000, SchemaName: RemainingTerms, IntroducedVersion: 6.1.0.0.  Description: Type the total number of entitlement terms that are left.</summary>
	[JsonIgnore]
	public decimal? RemainingTerms
	{
		get
		{
			return TryGetValue("remainingterms", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("remainingterms") is false || Remove("remainingterms"))
			{
				Add("remainingterms", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, DisplayName: Restrict based on entitlement terms, SchemaName: RestrictCaseCreation, IntroducedVersion: 6.1.0.0.  Description: Tells whether case creation is restricted based on entitlement terms.</summary>
	[JsonIgnore]
	public string? RestrictCaseCreationFormattedValue
	{
		get
		{
			return TryGetValue("restrictcasecreation@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, DisplayName: Restrict based on entitlement terms, SchemaName: RestrictCaseCreation, IntroducedVersion: 6.1.0.0.  Description: Tells whether case creation is restricted based on entitlement terms.</summary>
	[JsonIgnore]
	public bool? RestrictCaseCreation
	{
		get
		{
			return TryGetValue("restrictcasecreation", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("restrictcasecreation") is false || Remove("restrictcasecreation"))
			{
				Add("restrictcasecreation", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: restrictcasecreation, SchemaName: RestrictCaseCreationName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? RestrictCaseCreationName
	{
		get
		{
			return TryGetValue("restrictcasecreationname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 6.1.0.0.  Description: Choose the service level agreement (SLA) associated with the entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 6.1.0.0.  Description: Choose the service level agreement (SLA) associated with the entitlement.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 6.1.0.0.  Description: Choose the service level agreement (SLA) associated with the entitlement.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: SLAIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? SLAIdName
	{
		get
		{
			return TryGetValue("slaidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("slaidname") is false || Remove("slaidname"))
			{
				Add("slaidname", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Stage Id, SchemaName: StageId, IntroducedVersion: 6.1.0.0.  Description: Contains the id of the stage where the entity is located.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: SystemRequired, DisplayName: Start Date, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: StartDate, IntroducedVersion: 6.1.0.0.  Description: Enter the date when the entitlement starts.</summary>
	[JsonIgnore]
	public DateTime? StartDate
	{
		get
		{
			return TryGetValue("startdate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("startdate") is false || Remove("startdate"))
			{
				Add("startdate", value);
			}
		}
	}

	/// <summary>Type: State, RequiredLevel: None, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: State, RequiredLevel: None, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Code, SchemaName: StatusCode, IntroducedVersion: 6.1.0.0.  Description: Select the reason code that explains the status of the entitlement.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Code, SchemaName: StatusCode, IntroducedVersion: 6.1.0.0.  Description: Select the reason code that explains the status of the entitlement.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Total Terms, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: TotalTerms, IntroducedVersion: 6.1.0.0.  Description: Type the total number of entitlement terms.</summary>
	[JsonIgnore]
	public decimal? TotalTerms
	{
		get
		{
			return TryGetValue("totalterms", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("totalterms") is false || Remove("totalterms"))
			{
				Add("totalterms", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the currency associated with the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the currency associated with the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the currency associated with the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: TraversedPath, IntroducedVersion: 6.1.0.0.  Description: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 6.1.0.0.  Description: Time zone code that was in use when the record was created.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 6.1.0.0.  Description: Version Number</summary>
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

