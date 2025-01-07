namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Service request case associated with a contract.</summary>
public sealed partial class Incident : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the case is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the case is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Account, Format: None, SchemaName: AccountId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the account with which the case is associated.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Activities Complete, SchemaName: ActivitiesComplete, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public string? ActivitiesCompleteFormattedValue
	{
		get
		{
			return TryGetValue("activitiescomplete@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Activities Complete, SchemaName: ActivitiesComplete, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public bool? ActivitiesComplete
	{
		get
		{
			return TryGetValue("activitiescomplete", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("activitiescomplete") is false || Remove("activitiescomplete"))
			{
				Add("activitiescomplete", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: activitiescomplete, SchemaName: ActivitiesCompleteName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public object? ActivitiesCompleteName
	{
		get
		{
			return TryGetValue("activitiescompletename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Actual Service Units, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: ActualServiceUnits, IntroducedVersion: 5.0.0.0.  Description: Type the number of service units that were actually required to resolve the case.</summary>
	[JsonIgnore]
	public int? ActualServiceUnits
	{
		get
		{
			return TryGetValue("actualserviceunits", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("actualserviceunits") is false || Remove("actualserviceunits"))
			{
				Add("actualserviceunits", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Billed Service Units, Format: None, MinValue: 0, MaxValue: 1000000000, SchemaName: BilledServiceUnits, IntroducedVersion: 5.0.0.0.  Description: Type the number of service units that were billed to the customer for the case.</summary>
	[JsonIgnore]
	public int? BilledServiceUnits
	{
		get
		{
			return TryGetValue("billedserviceunits", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("billedserviceunits") is false || Remove("billedserviceunits"))
			{
				Add("billedserviceunits", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Blocked Profile, SchemaName: BlockedProfile, IntroducedVersion: 6.1.0.0.  Description: Details whether the profile is blocked or not.</summary>
	[JsonIgnore]
	public string? BlockedProfileFormattedValue
	{
		get
		{
			return TryGetValue("blockedprofile@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Blocked Profile, SchemaName: BlockedProfile, IntroducedVersion: 6.1.0.0.  Description: Details whether the profile is blocked or not.</summary>
	[JsonIgnore]
	public bool? BlockedProfile
	{
		get
		{
			return TryGetValue("blockedprofile", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("blockedprofile") is false || Remove("blockedprofile"))
			{
				Add("blockedprofile", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: blockedprofile, SchemaName: BlockedProfileName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? BlockedProfileName
	{
		get
		{
			return TryGetValue("blockedprofilename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Case Age, Format: Text, MaxLength: 4000, SchemaName: caseage, IntroducedVersion: 1.0.0.0.  Description: Shows the duration for which the Case has been active for Active and Resolved Cases.</summary>
	[JsonIgnore]
	public string? caseage
	{
		get
		{
			return TryGetValue("caseage", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("caseage") is false || Remove("caseage"))
			{
				Add("caseage", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Origin, SchemaName: CaseOriginCode, IntroducedVersion: 5.0.0.0.  Description: Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.</summary>
	[JsonIgnore]
	public string? CaseOriginCodeFormattedValue
	{
		get
		{
			return TryGetValue("caseorigincode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Origin, SchemaName: CaseOriginCode, IntroducedVersion: 5.0.0.0.  Description: Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.</summary>
	[JsonIgnore]
	public int? CaseOriginCode
	{
		get
		{
			return TryGetValue("caseorigincode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("caseorigincode") is false || Remove("caseorigincode"))
			{
				Add("caseorigincode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: caseorigincode, SchemaName: CaseOriginCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CaseOriginCodeName
	{
		get
		{
			return TryGetValue("caseorigincodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Type, SchemaName: CaseTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the type of case to identify the incident for use in case routing and analysis.</summary>
	[JsonIgnore]
	public string? CaseTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("casetypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Type, SchemaName: CaseTypeCode, IntroducedVersion: 5.0.0.0.  Description: Select the type of case to identify the incident for use in case routing and analysis.</summary>
	[JsonIgnore]
	public int? CaseTypeCode
	{
		get
		{
			return TryGetValue("casetypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("casetypecode") is false || Remove("casetypecode"))
			{
				Add("casetypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: casetypecode, SchemaName: CaseTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CaseTypeCodeName
	{
		get
		{
			return TryGetValue("casetypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Check Email, SchemaName: CheckEmail, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public string? CheckEmailFormattedValue
	{
		get
		{
			return TryGetValue("checkemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Check Email, SchemaName: CheckEmail, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public bool? CheckEmail
	{
		get
		{
			return TryGetValue("checkemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("checkemail") is false || Remove("checkemail"))
			{
				Add("checkemail", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: checkemail, SchemaName: CheckEmailName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public object? CheckEmailName
	{
		get
		{
			return TryGetValue("checkemailname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact associated with the case.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact associated with the case.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: ContactId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the contact associated with the case.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Line, Format: None, SchemaName: ContractDetailId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract line that the case should be logged under to make sure the customer is charged correctly.</summary>
	[JsonIgnore]
	public string? ContractDetailIdFormattedValue
	{
		get
		{
			return TryGetValue("_contractdetailid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Line, Format: None, SchemaName: ContractDetailId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract line that the case should be logged under to make sure the customer is charged correctly.</summary>
	[JsonIgnore]
	public Guid? ContractDetailId
	{
		get
		{
			return TryGetValue("_contractdetailid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract Line, Format: None, SchemaName: ContractDetailId, IntroducedVersion: 5.0.0.0.  Description: Choose the contract line that the case should be logged under to make sure the customer is charged correctly.</summary>
	[JsonIgnore]
	public Guid? ContractDetailId_contractdetail
	{
		set
		{
			if (ContainsKey("contractdetailid_contractdetail@odata.bind") is false || Remove("contractdetailid_contractdetail@odata.bind"))
			{
				if (value is not null)
				{
					Add("contractdetailid_contractdetail@odata.bind", $"({value})");
				}
				else
				{
					Add("_contractdetailid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: contractdetailid, Format: Text, MaxLength: 100, SchemaName: ContractDetailIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ContractDetailIdName
	{
		get
		{
			return TryGetValue("contractdetailidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("contractdetailidname") is false || Remove("contractdetailidname"))
			{
				Add("contractdetailidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contract, Format: None, SchemaName: ContractId, IntroducedVersion: 5.0.0.0.  Description: Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Level, SchemaName: ContractServiceLevelCode, IntroducedVersion: 5.0.0.0.  Description: Select the service level for the case to make sure the case is handled correctly.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Level, SchemaName: ContractServiceLevelCode, IntroducedVersion: 5.0.0.0.  Description: Select the service level for the case to make sure the case is handled correctly.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Customer Contacted, SchemaName: CustomerContacted, IntroducedVersion: 6.1.0.0.  Description: Tells whether customer service representative has contacted the customer or not.</summary>
	[JsonIgnore]
	public string? CustomerContactedFormattedValue
	{
		get
		{
			return TryGetValue("customercontacted@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Customer Contacted, SchemaName: CustomerContacted, IntroducedVersion: 6.1.0.0.  Description: Tells whether customer service representative has contacted the customer or not.</summary>
	[JsonIgnore]
	public bool? CustomerContacted
	{
		get
		{
			return TryGetValue("customercontacted", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("customercontacted") is false || Remove("customercontacted"))
			{
				Add("customercontacted", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customercontacted, SchemaName: customercontactedName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? customercontactedName
	{
		get
		{
			return TryGetValue("customercontactedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.</summary>
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

	/// <summary>Type: Customer, RequiredLevel: SystemRequired, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 5.0.0.0.  Description: Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Satisfaction, SchemaName: CustomerSatisfactionCode, IntroducedVersion: 5.0.0.0.  Description: Select the customer's level of satisfaction with the handling and resolution of the case.</summary>
	[JsonIgnore]
	public string? CustomerSatisfactionCodeFormattedValue
	{
		get
		{
			return TryGetValue("customersatisfactioncode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Satisfaction, SchemaName: CustomerSatisfactionCode, IntroducedVersion: 5.0.0.0.  Description: Select the customer's level of satisfaction with the handling and resolution of the case.</summary>
	[JsonIgnore]
	public int? CustomerSatisfactionCode
	{
		get
		{
			return TryGetValue("customersatisfactioncode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("customersatisfactioncode") is false || Remove("customersatisfactioncode"))
			{
				Add("customersatisfactioncode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: customersatisfactioncode, SchemaName: CustomerSatisfactionCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? CustomerSatisfactionCodeName
	{
		get
		{
			return TryGetValue("customersatisfactioncodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Deactivated On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: deactivatedon, IntroducedVersion: 1.0.0.0.  Description: Shows the date time when the Case was resolved.</summary>
	[JsonIgnore]
	public DateTime? deactivatedon
	{
		get
		{
			return TryGetValue("deactivatedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("deactivatedon") is false || Remove("deactivatedon"))
			{
				Add("deactivatedon", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decrement Entitlement Terms, SchemaName: DecrementEntitlementTerm, IntroducedVersion: 7.1.0.0.  Description: Shows whether terms of the associated entitlement should be decremented or not.</summary>
	[JsonIgnore]
	public string? DecrementEntitlementTermFormattedValue
	{
		get
		{
			return TryGetValue("decremententitlementterm@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decrement Entitlement Terms, SchemaName: DecrementEntitlementTerm, IntroducedVersion: 7.1.0.0.  Description: Shows whether terms of the associated entitlement should be decremented or not.</summary>
	[JsonIgnore]
	public bool? DecrementEntitlementTerm
	{
		get
		{
			return TryGetValue("decremententitlementterm", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("decremententitlementterm") is false || Remove("decremententitlementterm"))
			{
				Add("decremententitlementterm", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: decremententitlementterm, SchemaName: DecrementEntitlementTermName, IntroducedVersion: 7.1.0.0. </summary>
	[JsonIgnore]
	public object? DecrementEntitlementTermName
	{
		get
		{
			return TryGetValue("decremententitlementtermname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information to describe the case to assist the service team in reaching a resolution.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Approval Status, SchemaName: ecsm_approval_status, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_approval_statusFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_approval_status@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Approval Status, SchemaName: ecsm_approval_status, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public int? ecsm_approval_status
	{
		get
		{
			return TryGetValue("ecsm_approval_status", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_approval_status") is false || Remove("ecsm_approval_status"))
			{
				Add("ecsm_approval_status", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_approval_status, SchemaName: ecsm_approval_statusName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? ecsm_approval_statusName
	{
		get
		{
			return TryGetValue("ecsm_approval_statusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Approved, SchemaName: ecsm_approved, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_approvedFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_approved@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Approved, SchemaName: ecsm_approved, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public bool? ecsm_approved
	{
		get
		{
			return TryGetValue("ecsm_approved", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_approved") is false || Remove("ecsm_approved"))
			{
				Add("ecsm_approved", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_approved, SchemaName: ecsm_approvedName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_approvedName
	{
		get
		{
			return TryGetValue("ecsm_approvedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ecsm_catalogue_item, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_catalogue_itemFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_catalogue_item_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ecsm_catalogue_item, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? ecsm_catalogue_item
	{
		get
		{
			return TryGetValue("_ecsm_catalogue_item_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ecsm_catalogue_item, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? ecsm_catalogue_item_ecsm_catalogue_item
	{
		set
		{
			if (ContainsKey("ecsm_catalogue_item_ecsm_catalogue_item@odata.bind") is false || Remove("ecsm_catalogue_item_ecsm_catalogue_item@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_catalogue_item_ecsm_catalogue_item@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_catalogue_item_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_catalogue_item, Format: Text, MaxLength: 100, SchemaName: ecsm_catalogue_itemName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_catalogue_itemName
	{
		get
		{
			return TryGetValue("ecsm_catalogue_itemname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_catalogue_itemname") is false || Remove("ecsm_catalogue_itemname"))
			{
				Add("ecsm_catalogue_itemname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Category, Format: None, SchemaName: ecsm_category, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_categoryFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_category_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Category, Format: None, SchemaName: ecsm_category, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? ecsm_category
	{
		get
		{
			return TryGetValue("_ecsm_category_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Category, Format: None, SchemaName: ecsm_category, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? ecsm_category_ecsm_category
	{
		set
		{
			if (ContainsKey("ecsm_category_ecsm_category@odata.bind") is false || Remove("ecsm_category_ecsm_category@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_category_ecsm_category@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_category_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_category, Format: Text, MaxLength: 100, SchemaName: ecsm_categoryName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_categoryName
	{
		get
		{
			return TryGetValue("ecsm_categoryname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_categoryname") is false || Remove("ecsm_categoryname"))
			{
				Add("ecsm_categoryname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Change, Format: None, SchemaName: ecsm_change, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_changeFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_change_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Change, Format: None, SchemaName: ecsm_change, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_change
	{
		get
		{
			return TryGetValue("_ecsm_change_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Change, Format: None, SchemaName: ecsm_change, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_change_ecsm_change
	{
		set
		{
			if (ContainsKey("ecsm_change_ecsm_change@odata.bind") is false || Remove("ecsm_change_ecsm_change@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_change_ecsm_change@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_change_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_change, Format: Text, MaxLength: 100, SchemaName: ecsm_changeName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_changeName
	{
		get
		{
			return TryGetValue("ecsm_changename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_changename") is false || Remove("ecsm_changename"))
			{
				Add("ecsm_changename", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Created By Portal, SchemaName: ecsm_created_by_portal, IntroducedVersion: 1.3.0.2.  Description: This is set to true when record is created from the Portal</summary>
	[JsonIgnore]
	public string? ecsm_created_by_portalFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_created_by_portal@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Created By Portal, SchemaName: ecsm_created_by_portal, IntroducedVersion: 1.3.0.2.  Description: This is set to true when record is created from the Portal</summary>
	[JsonIgnore]
	public bool? ecsm_created_by_portal
	{
		get
		{
			return TryGetValue("ecsm_created_by_portal", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_created_by_portal") is false || Remove("ecsm_created_by_portal"))
			{
				Add("ecsm_created_by_portal", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_created_by_portal, SchemaName: ecsm_created_by_portalName, IntroducedVersion: 1.3.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_created_by_portalName
	{
		get
		{
			return TryGetValue("ecsm_created_by_portalname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Duration, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: ecsm_duration, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? ecsm_duration
	{
		get
		{
			return TryGetValue("ecsm_duration", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_duration") is false || Remove("ecsm_duration"))
			{
				Add("ecsm_duration", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName:  Impact, SchemaName: ecsm_impact, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_impactFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_impact@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName:  Impact, SchemaName: ecsm_impact, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public int? ecsm_impact
	{
		get
		{
			return TryGetValue("ecsm_impact", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_impact") is false || Remove("ecsm_impact"))
			{
				Add("ecsm_impact", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_impact, SchemaName: ecsm_impactName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? ecsm_impactName
	{
		get
		{
			return TryGetValue("ecsm_impactname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Incident Type, SchemaName: ecsm_incident_type, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_incident_typeFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_incident_type@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Incident Type, SchemaName: ecsm_incident_type, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public int? ecsm_incident_type
	{
		get
		{
			return TryGetValue("ecsm_incident_type", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_incident_type") is false || Remove("ecsm_incident_type"))
			{
				Add("ecsm_incident_type", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_incident_type, SchemaName: ecsm_incident_typeName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? ecsm_incident_typeName
	{
		get
		{
			return TryGetValue("ecsm_incident_typename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Known Issue, SchemaName: ecsm_is_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_is_known_issueFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_is_known_issue@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Known Issue, SchemaName: ecsm_is_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public bool? ecsm_is_known_issue
	{
		get
		{
			return TryGetValue("ecsm_is_known_issue", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_is_known_issue") is false || Remove("ecsm_is_known_issue"))
			{
				Add("ecsm_is_known_issue", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_is_known_issue, SchemaName: ecsm_is_known_issueName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_is_known_issueName
	{
		get
		{
			return TryGetValue("ecsm_is_known_issuename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Major, SchemaName: ecsm_is_major, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_is_majorFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_is_major@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Major, SchemaName: ecsm_is_major, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public bool? ecsm_is_major
	{
		get
		{
			return TryGetValue("ecsm_is_major", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_is_major") is false || Remove("ecsm_is_major"))
			{
				Add("ecsm_is_major", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_is_major, SchemaName: ecsm_is_majorName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_is_majorName
	{
		get
		{
			return TryGetValue("ecsm_is_majorname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Known Issue, Format: None, SchemaName: ecsm_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_known_issueFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_known_issue_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Known Issue, Format: None, SchemaName: ecsm_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_known_issue
	{
		get
		{
			return TryGetValue("_ecsm_known_issue_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Known Issue, Format: None, SchemaName: ecsm_known_issue, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_known_issue_ecsm_knownissue
	{
		set
		{
			if (ContainsKey("ecsm_known_issue_ecsm_knownissue@odata.bind") is false || Remove("ecsm_known_issue_ecsm_knownissue@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_known_issue_ecsm_knownissue@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_known_issue_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_known_issue, Format: Text, MaxLength: 100, SchemaName: ecsm_known_issueName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_known_issueName
	{
		get
		{
			return TryGetValue("ecsm_known_issuename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_known_issuename") is false || Remove("ecsm_known_issuename"))
			{
				Add("ecsm_known_issuename", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected CI, Format: None, SchemaName: ecsm_problem_affected_ci, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_problem_affected_ciFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_problem_affected_ci_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected CI, Format: None, SchemaName: ecsm_problem_affected_ci, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_problem_affected_ci
	{
		get
		{
			return TryGetValue("_ecsm_problem_affected_ci_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected CI, Format: None, SchemaName: ecsm_problem_affected_ci, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_problem_affected_ci_ecsm_configuration_item
	{
		set
		{
			if (ContainsKey("ecsm_problem_affected_ci_ecsm_configuration_item@odata.bind") is false || Remove("ecsm_problem_affected_ci_ecsm_configuration_item@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_problem_affected_ci_ecsm_configuration_item@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_problem_affected_ci_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_problem_affected_ci, Format: Text, MaxLength: 100, SchemaName: ecsm_problem_affected_ciName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_problem_affected_ciName
	{
		get
		{
			return TryGetValue("ecsm_problem_affected_ciname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_problem_affected_ciname") is false || Remove("ecsm_problem_affected_ciname"))
			{
				Add("ecsm_problem_affected_ciname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected Service, Format: None, SchemaName: ecsm_problem_affected_service, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_problem_affected_serviceFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_problem_affected_service_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected Service, Format: None, SchemaName: ecsm_problem_affected_service, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_problem_affected_service
	{
		get
		{
			return TryGetValue("_ecsm_problem_affected_service_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Problem Affected Service, Format: None, SchemaName: ecsm_problem_affected_service, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public Guid? ecsm_problem_affected_service_ecsm_catalogue_item
	{
		set
		{
			if (ContainsKey("ecsm_problem_affected_service_ecsm_catalogue_item@odata.bind") is false || Remove("ecsm_problem_affected_service_ecsm_catalogue_item@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_problem_affected_service_ecsm_catalogue_item@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_problem_affected_service_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_problem_affected_service, Format: Text, MaxLength: 100, SchemaName: ecsm_problem_affected_serviceName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_problem_affected_serviceName
	{
		get
		{
			return TryGetValue("ecsm_problem_affected_servicename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_problem_affected_servicename") is false || Remove("ecsm_problem_affected_servicename"))
			{
				Add("ecsm_problem_affected_servicename", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Problem Impact, SchemaName: ecsm_problem_impact, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_problem_impactFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_problem_impact@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Problem Impact, SchemaName: ecsm_problem_impact, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public int? ecsm_problem_impact
	{
		get
		{
			return TryGetValue("ecsm_problem_impact", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_problem_impact") is false || Remove("ecsm_problem_impact"))
			{
				Add("ecsm_problem_impact", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Problem Impact Classification, SchemaName: ecsm_problem_impact_classification, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_problem_impact_classification
	{
		get
		{
			return TryGetValue("ecsm_problem_impact_classification", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_problem_impact_classification, SchemaName: ecsm_problem_impact_classificationName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_problem_impact_classificationName
	{
		get
		{
			return TryGetValue("ecsm_problem_impact_classificationname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_problem_impact, SchemaName: ecsm_problem_impactName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_problem_impactName
	{
		get
		{
			return TryGetValue("ecsm_problem_impactname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Raise Change, SchemaName: ecsm_raise_change, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public string? ecsm_raise_changeFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_raise_change@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Raise Change, SchemaName: ecsm_raise_change, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public bool? ecsm_raise_change
	{
		get
		{
			return TryGetValue("ecsm_raise_change", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_raise_change") is false || Remove("ecsm_raise_change"))
			{
				Add("ecsm_raise_change", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_raise_change, SchemaName: ecsm_raise_changeName, IntroducedVersion: 1.0.0.2. </summary>
	[JsonIgnore]
	public object? ecsm_raise_changeName
	{
		get
		{
			return TryGetValue("ecsm_raise_changename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Reproduction Steps, Format: Text, MaxLength: 2000, SchemaName: ecsm_reproduction_steps, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? ecsm_reproduction_steps
	{
		get
		{
			return TryGetValue("ecsm_reproduction_steps", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_reproduction_steps") is false || Remove("ecsm_reproduction_steps"))
			{
				Add("ecsm_reproduction_steps", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Risk Statement, Format: Text, MaxLength: 2000, SchemaName: ecsm_risk_statement, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? ecsm_risk_statement
	{
		get
		{
			return TryGetValue("ecsm_risk_statement", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_risk_statement") is false || Remove("ecsm_risk_statement"))
			{
				Add("ecsm_risk_statement", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Root Cause, Format: Text, MaxLength: 2000, SchemaName: ecsm_root_cause, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? ecsm_root_cause
	{
		get
		{
			return TryGetValue("ecsm_root_cause", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_root_cause") is false || Remove("ecsm_root_cause"))
			{
				Add("ecsm_root_cause", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: ecsm_site, IntroducedVersion: 1.1.0.12.  Description: Site</summary>
	[JsonIgnore]
	public string? ecsm_siteFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_site_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: ecsm_site, IntroducedVersion: 1.1.0.12.  Description: Site</summary>
	[JsonIgnore]
	public Guid? ecsm_site
	{
		get
		{
			return TryGetValue("_ecsm_site_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Site, Format: None, SchemaName: ecsm_site, IntroducedVersion: 1.1.0.12.  Description: Site</summary>
	[JsonIgnore]
	public Guid? ecsm_site_site
	{
		set
		{
			if (ContainsKey("ecsm_site_site@odata.bind") is false || Remove("ecsm_site_site@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_site_site@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_site_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_site, Format: Text, MaxLength: 160, SchemaName: ecsm_siteName, IntroducedVersion: 1.1.0.12. </summary>
	[JsonIgnore]
	public string? ecsm_siteName
	{
		get
		{
			return TryGetValue("ecsm_sitename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_sitename") is false || Remove("ecsm_sitename"))
			{
				Add("ecsm_sitename", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Test product Lookup, Format: None, SchemaName: ecsm_test_product_lookup, IntroducedVersion: 1.1.0.13. </summary>
	[JsonIgnore]
	public string? ecsm_test_product_lookupFormattedValue
	{
		get
		{
			return TryGetValue("_ecsm_test_product_lookup_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Test product Lookup, Format: None, SchemaName: ecsm_test_product_lookup, IntroducedVersion: 1.1.0.13. </summary>
	[JsonIgnore]
	public Guid? ecsm_test_product_lookup
	{
		get
		{
			return TryGetValue("_ecsm_test_product_lookup_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Test product Lookup, Format: None, SchemaName: ecsm_test_product_lookup, IntroducedVersion: 1.1.0.13. </summary>
	[JsonIgnore]
	public Guid? ecsm_test_product_lookup_product
	{
		set
		{
			if (ContainsKey("ecsm_test_product_lookup_product@odata.bind") is false || Remove("ecsm_test_product_lookup_product@odata.bind"))
			{
				if (value is not null)
				{
					Add("ecsm_test_product_lookup_product@odata.bind", $"({value})");
				}
				else
				{
					Add("_ecsm_test_product_lookup_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: ecsm_test_product_lookup, Format: Text, MaxLength: 100, SchemaName: ecsm_test_product_lookupName, IntroducedVersion: 1.1.0.13. </summary>
	[JsonIgnore]
	public string? ecsm_test_product_lookupName
	{
		get
		{
			return TryGetValue("ecsm_test_product_lookupname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_test_product_lookupname") is false || Remove("ecsm_test_product_lookupname"))
			{
				Add("ecsm_test_product_lookupname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Urgency, SchemaName: ecsm_urgency, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_urgencyFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_urgency@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Urgency, SchemaName: ecsm_urgency, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public int? ecsm_urgency
	{
		get
		{
			return TryGetValue("ecsm_urgency", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_urgency") is false || Remove("ecsm_urgency"))
			{
				Add("ecsm_urgency", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_urgency, SchemaName: ecsm_urgencyName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? ecsm_urgencyName
	{
		get
		{
			return TryGetValue("ecsm_urgencyname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Variable Data, Format: Text, MaxLength: 1048576, SchemaName: ecsm_variable_data, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? ecsm_variable_data
	{
		get
		{
			return TryGetValue("ecsm_variable_data", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_variable_data") is false || Remove("ecsm_variable_data"))
			{
				Add("ecsm_variable_data", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Workaround, Format: Text, MaxLength: 2000, SchemaName: ecsm_workaround, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? ecsm_workaround
	{
		get
		{
			return TryGetValue("ecsm_workaround", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_workaround") is false || Remove("ecsm_workaround"))
			{
				Add("ecsm_workaround", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Working Synopsis, Format: Text, MaxLength: 2000, SchemaName: ecsm_working_synopsis, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? ecsm_working_synopsis
	{
		get
		{
			return TryGetValue("ecsm_working_synopsis", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_working_synopsis") is false || Remove("ecsm_working_synopsis"))
			{
				Add("ecsm_working_synopsis", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement, Format: None, SchemaName: EntitlementId, IntroducedVersion: 6.1.0.0.  Description: Choose the entitlement that is applicable for the case.</summary>
	[JsonIgnore]
	public string? EntitlementIdFormattedValue
	{
		get
		{
			return TryGetValue("_entitlementid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement, Format: None, SchemaName: EntitlementId, IntroducedVersion: 6.1.0.0.  Description: Choose the entitlement that is applicable for the case.</summary>
	[JsonIgnore]
	public Guid? EntitlementId
	{
		get
		{
			return TryGetValue("_entitlementid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Entitlement, Format: None, SchemaName: EntitlementId, IntroducedVersion: 6.1.0.0.  Description: Choose the entitlement that is applicable for the case.</summary>
	[JsonIgnore]
	public Guid? EntitlementId_entitlement
	{
		set
		{
			if (ContainsKey("entitlementid_entitlement@odata.bind") is false || Remove("entitlementid_entitlement@odata.bind"))
			{
				if (value is not null)
				{
					Add("entitlementid_entitlement@odata.bind", $"({value})");
				}
				else
				{
					Add("_entitlementid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: entitlementid, Format: Text, MaxLength: 100, SchemaName: EntitlementIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? EntitlementIdName
	{
		get
		{
			return TryGetValue("entitlementidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("entitlementidname") is false || Remove("entitlementidname"))
			{
				Add("entitlementidname", value);
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Escalated On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: EscalatedOn, IntroducedVersion: 6.1.0.0.  Description: Indicates the date and time when the case was escalated.</summary>
	[JsonIgnore]
	public DateTime? EscalatedOn
	{
		get
		{
			return TryGetValue("escalatedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("escalatedon") is false || Remove("escalatedon"))
			{
				Add("escalatedon", value);
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Existing Case, Format: None, SchemaName: ExistingCase, IntroducedVersion: 5.0.0.0.  Description: Select an existing case for the customer that has been populated. For internal use only.</summary>
	[JsonIgnore]
	public string? ExistingCaseFormattedValue
	{
		get
		{
			return TryGetValue("_existingcase_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Existing Case, Format: None, SchemaName: ExistingCase, IntroducedVersion: 5.0.0.0.  Description: Select an existing case for the customer that has been populated. For internal use only.</summary>
	[JsonIgnore]
	public Guid? ExistingCase
	{
		get
		{
			return TryGetValue("_existingcase_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Existing Case, Format: None, SchemaName: ExistingCase, IntroducedVersion: 5.0.0.0.  Description: Select an existing case for the customer that has been populated. For internal use only.</summary>
	[JsonIgnore]
	public Guid? ExistingCase_incident
	{
		set
		{
			if (ContainsKey("existingcase_incident@odata.bind") is false || Remove("existingcase_incident@odata.bind"))
			{
				if (value is not null)
				{
					Add("existingcase_incident@odata.bind", $"({value})");
				}
				else
				{
					Add("_existingcase_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: First Response By KPI, Format: None, SchemaName: FirstResponseByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? FirstResponseByKPIIdFormattedValue
	{
		get
		{
			return TryGetValue("_firstresponsebykpiid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: First Response By KPI, Format: None, SchemaName: FirstResponseByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? FirstResponseByKPIId
	{
		get
		{
			return TryGetValue("_firstresponsebykpiid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: First Response By KPI, Format: None, SchemaName: FirstResponseByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? FirstResponseByKPIId_slakpiinstance
	{
		set
		{
			if (ContainsKey("firstresponsebykpiid_slakpiinstance@odata.bind") is false || Remove("firstresponsebykpiid_slakpiinstance@odata.bind"))
			{
				if (value is not null)
				{
					Add("firstresponsebykpiid_slakpiinstance@odata.bind", $"({value})");
				}
				else
				{
					Add("_firstresponsebykpiid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: firstresponsebykpiid, Format: Text, MaxLength: 100, SchemaName: FirstResponseByKPIIdName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public string? FirstResponseByKPIIdName
	{
		get
		{
			return TryGetValue("firstresponsebykpiidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("firstresponsebykpiidname") is false || Remove("firstresponsebykpiidname"))
			{
				Add("firstresponsebykpiidname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: First Response Sent, SchemaName: FirstResponseSent, IntroducedVersion: 6.1.0.0.  Description: Indicates if the first response has been sent.</summary>
	[JsonIgnore]
	public string? FirstResponseSentFormattedValue
	{
		get
		{
			return TryGetValue("firstresponsesent@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: First Response Sent, SchemaName: FirstResponseSent, IntroducedVersion: 6.1.0.0.  Description: Indicates if the first response has been sent.</summary>
	[JsonIgnore]
	public bool? FirstResponseSent
	{
		get
		{
			return TryGetValue("firstresponsesent", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("firstresponsesent") is false || Remove("firstresponsesent"))
			{
				Add("firstresponsesent", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: firstresponsesent, SchemaName: FirstResponseSentName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? FirstResponseSentName
	{
		get
		{
			return TryGetValue("firstresponsesentname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: First Response SLA Status, SchemaName: FirstResponseSLAStatus, IntroducedVersion: 6.1.0.0.  Description: Shows the status of the initial response time for the case according to the terms of the SLA.</summary>
	[JsonIgnore]
	public string? FirstResponseSLAStatusFormattedValue
	{
		get
		{
			return TryGetValue("firstresponseslastatus@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: First Response SLA Status, SchemaName: FirstResponseSLAStatus, IntroducedVersion: 6.1.0.0.  Description: Shows the status of the initial response time for the case according to the terms of the SLA.</summary>
	[JsonIgnore]
	public int? FirstResponseSLAStatus
	{
		get
		{
			return TryGetValue("firstresponseslastatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("firstresponseslastatus") is false || Remove("firstresponseslastatus"))
			{
				Add("firstresponseslastatus", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: firstresponseslastatus, SchemaName: FirstResponseSLAStatusName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? FirstResponseSLAStatusName
	{
		get
		{
			return TryGetValue("firstresponseslastatusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Follow Up By, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: FollowupBy, IntroducedVersion: 5.0.0.0.  Description: Enter the date by which a customer service representative has to follow up with the customer on this case.</summary>
	[JsonIgnore]
	public DateTime? FollowupBy
	{
		get
		{
			return TryGetValue("followupby", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("followupby") is false || Remove("followupby"))
			{
				Add("followupby", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow up Task Created, SchemaName: FollowUpTaskCreated, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public string? FollowUpTaskCreatedFormattedValue
	{
		get
		{
			return TryGetValue("followuptaskcreated@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Follow up Task Created, SchemaName: FollowUpTaskCreated, IntroducedVersion: 6.0.0.0.  Description: This attribute is used for Sample Service Business Processes.</summary>
	[JsonIgnore]
	public bool? FollowUpTaskCreated
	{
		get
		{
			return TryGetValue("followuptaskcreated", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("followuptaskcreated") is false || Remove("followuptaskcreated"))
			{
				Add("followuptaskcreated", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: followuptaskcreated, SchemaName: FollowUpTaskCreatedName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public object? FollowUpTaskCreatedName
	{
		get
		{
			return TryGetValue("followuptaskcreatedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Case, SchemaName: IncidentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case.</summary>
	[JsonIgnore]
	public Guid? IncidentId
	{
		get
		{
			return TryGetValue("incidentid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("incidentid") is false || Remove("incidentid"))
			{
				Add("incidentid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Stage, SchemaName: IncidentStageCode, IntroducedVersion: 5.0.0.0.  Description: Select the current stage of the service process for the case to assist service team members when they review or transfer a case.</summary>
	[JsonIgnore]
	public string? IncidentStageCodeFormattedValue
	{
		get
		{
			return TryGetValue("incidentstagecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Stage, SchemaName: IncidentStageCode, IntroducedVersion: 5.0.0.0.  Description: Select the current stage of the service process for the case to assist service team members when they review or transfer a case.</summary>
	[JsonIgnore]
	public int? IncidentStageCode
	{
		get
		{
			return TryGetValue("incidentstagecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("incidentstagecode") is false || Remove("incidentstagecode"))
			{
				Add("incidentstagecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: incidentstagecode, SchemaName: IncidentStageCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IncidentStageCodeName
	{
		get
		{
			return TryGetValue("incidentstagecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Influence Score, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: InfluenceScore, IntroducedVersion: 6.1.0.0.  Description: Will contain the Influencer score coming from NetBreeze.</summary>
	[JsonIgnore]
	public double? InfluenceScore
	{
		get
		{
			return TryGetValue("influencescore", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("influencescore") is false || Remove("influencescore"))
			{
				Add("influencescore", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decrementing, SchemaName: IsDecrementing, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public string? IsDecrementingFormattedValue
	{
		get
		{
			return TryGetValue("isdecrementing@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Decrementing, SchemaName: IsDecrementing, IntroducedVersion: 5.0.0.0.  Description: For system use only.</summary>
	[JsonIgnore]
	public bool? IsDecrementing
	{
		get
		{
			return TryGetValue("isdecrementing", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isdecrementing") is false || Remove("isdecrementing"))
			{
				Add("isdecrementing", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdecrementing, SchemaName: IsDecrementingName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsDecrementingName
	{
		get
		{
			return TryGetValue("isdecrementingname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Escalated, SchemaName: IsEscalated, IntroducedVersion: 6.1.0.0.  Description: Indicates if the case has been escalated.</summary>
	[JsonIgnore]
	public string? IsEscalatedFormattedValue
	{
		get
		{
			return TryGetValue("isescalated@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Escalated, SchemaName: IsEscalated, IntroducedVersion: 6.1.0.0.  Description: Indicates if the case has been escalated.</summary>
	[JsonIgnore]
	public bool? IsEscalated
	{
		get
		{
			return TryGetValue("isescalated", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isescalated") is false || Remove("isescalated"))
			{
				Add("isescalated", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isescalated, SchemaName: IsEscalatedName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? IsEscalatedName
	{
		get
		{
			return TryGetValue("isescalatedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Knowledge Base Article, Format: None, SchemaName: KbArticleId, IntroducedVersion: 5.0.0.0.  Description: Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.</summary>
	[JsonIgnore]
	public string? KbArticleIdFormattedValue
	{
		get
		{
			return TryGetValue("_kbarticleid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Knowledge Base Article, Format: None, SchemaName: KbArticleId, IntroducedVersion: 5.0.0.0.  Description: Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.</summary>
	[JsonIgnore]
	public Guid? KbArticleId
	{
		get
		{
			return TryGetValue("_kbarticleid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Knowledge Base Article, Format: None, SchemaName: KbArticleId, IntroducedVersion: 5.0.0.0.  Description: Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.</summary>
	[JsonIgnore]
	public Guid? KbArticleId_kbarticle
	{
		set
		{
			if (ContainsKey("kbarticleid_kbarticle@odata.bind") is false || Remove("kbarticleid_kbarticle@odata.bind"))
			{
				if (value is not null)
				{
					Add("kbarticleid_kbarticle@odata.bind", $"({value})");
				}
				else
				{
					Add("_kbarticleid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: kbarticleid, Format: Text, MaxLength: 100, SchemaName: KbArticleIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? KbArticleIdName
	{
		get
		{
			return TryGetValue("kbarticleidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("kbarticleidname") is false || Remove("kbarticleidname"))
			{
				Add("kbarticleidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Last Interaction, Format: Text, MaxLength: 200, SchemaName: lastinteraction, IntroducedVersion: 1.0.0.0.  Description: Shows the latest activity associated with the Case and the action performed on that activity.</summary>
	[JsonIgnore]
	public string? lastinteraction
	{
		get
		{
			return TryGetValue("lastinteraction", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("lastinteraction") is false || Remove("lastinteraction"))
			{
				Add("lastinteraction", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last On Hold Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastOnHoldTime, IntroducedVersion: 7.0.0.0.  Description: Contains the date time stamp of the last on hold time.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master Case, Format: None, SchemaName: MasterId, IntroducedVersion: 6.1.0.0.  Description: Choose the primary case the current case was merged into.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master Case, Format: None, SchemaName: MasterId, IntroducedVersion: 6.1.0.0.  Description: Choose the primary case the current case was merged into.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Master Case, Format: None, SchemaName: MasterId, IntroducedVersion: 6.1.0.0.  Description: Choose the primary case the current case was merged into.</summary>
	[JsonIgnore]
	public Guid? MasterId_incident
	{
		set
		{
			if (ContainsKey("masterid_incident@odata.bind") is false || Remove("masterid_incident@odata.bind"))
			{
				if (value is not null)
				{
					Add("masterid_incident@odata.bind", $"({value})");
				}
				else
				{
					Add("_masterid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: masterid, Format: Text, MaxLength: 100, SchemaName: MasterIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? MasterIdName
	{
		get
		{
			return TryGetValue("masteridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("masteridname") is false || Remove("masteridname"))
			{
				Add("masteridname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Internal Use Only, SchemaName: Merged, IntroducedVersion: 6.1.0.0.  Description: Tells whether the incident has been merged with another incident.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Internal Use Only, SchemaName: Merged, IntroducedVersion: 6.1.0.0.  Description: Tells whether the incident has been merged with another incident.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: merged, SchemaName: MergedName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Received As, SchemaName: MessageTypeCode, IntroducedVersion: 6.1.0.0.  Description: Shows whether the post originated as a public or private message.</summary>
	[JsonIgnore]
	public string? MessageTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("messagetypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Received As, SchemaName: MessageTypeCode, IntroducedVersion: 6.1.0.0.  Description: Shows whether the post originated as a public or private message.</summary>
	[JsonIgnore]
	public int? MessageTypeCode
	{
		get
		{
			return TryGetValue("messagetypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("messagetypecode") is false || Remove("messagetypecode"))
			{
				Add("messagetypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: messagetypecode, SchemaName: MessageTypeCodeName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? MessageTypeCodeName
	{
		get
		{
			return TryGetValue("messagetypecodename", out var value)
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Survey Invite, Format: Text, MaxLength: 500, SchemaName: msdyn_CaseSurveyInviteUrl, IntroducedVersion: 1.0.  Description: Survey invite url for customer feedback.</summary>
	[JsonIgnore]
	public string? msdyn_CaseSurveyInviteUrl
	{
		get
		{
			return TryGetValue("msdyn_casesurveyinviteurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_casesurveyinviteurl") is false || Remove("msdyn_casesurveyinviteurl"))
			{
				Add("msdyn_casesurveyinviteurl", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Copilot Engaged, SchemaName: msdyn_copilotengaged, IntroducedVersion: 1.0.0.1. </summary>
	[JsonIgnore]
	public string? msdyn_copilotengagedFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_copilotengaged@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Copilot Engaged, SchemaName: msdyn_copilotengaged, IntroducedVersion: 1.0.0.1. </summary>
	[JsonIgnore]
	public bool? msdyn_copilotengaged
	{
		get
		{
			return TryGetValue("msdyn_copilotengaged", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_copilotengaged") is false || Remove("msdyn_copilotengaged"))
			{
				Add("msdyn_copilotengaged", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_copilotengaged, SchemaName: msdyn_copilotengagedName, IntroducedVersion: 1.0.0.1. </summary>
	[JsonIgnore]
	public object? msdyn_copilotengagedName
	{
		get
		{
			return TryGetValue("msdyn_copilotengagedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Alert, Format: None, SchemaName: msdyn_iotalert, IntroducedVersion: 1.0.0.0.  Description: The iot alert that initiated this case</summary>
	[JsonIgnore]
	public string? msdyn_iotalertFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_iotalert_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Alert, Format: None, SchemaName: msdyn_iotalert, IntroducedVersion: 1.0.0.0.  Description: The iot alert that initiated this case</summary>
	[JsonIgnore]
	public Guid? msdyn_iotalert
	{
		get
		{
			return TryGetValue("_msdyn_iotalert_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: IoT Alert, Format: None, SchemaName: msdyn_iotalert, IntroducedVersion: 1.0.0.0.  Description: The iot alert that initiated this case</summary>
	[JsonIgnore]
	public Guid? msdyn_iotalert_msdyn_iotalert
	{
		set
		{
			if (ContainsKey("msdyn_iotalert_msdyn_iotalert@odata.bind") is false || Remove("msdyn_iotalert_msdyn_iotalert@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_iotalert_msdyn_iotalert@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_iotalert_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_iotalert, Format: Text, MaxLength: 100, SchemaName: msdyn_iotalertName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_iotalertName
	{
		get
		{
			return TryGetValue("msdyn_iotalertname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_iotalertname") is false || Remove("msdyn_iotalertname"))
			{
				Add("msdyn_iotalertname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pre Create Entity Attachments Id, Format: Text, MaxLength: 400, SchemaName: msdyn_precreateattachmentsid, IntroducedVersion: 1.0.  Description: Entity Attachments Id before the case record is created</summary>
	[JsonIgnore]
	public string? msdyn_precreateattachmentsid
	{
		get
		{
			return TryGetValue("msdyn_precreateattachmentsid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_precreateattachmentsid") is false || Remove("msdyn_precreateattachmentsid"))
			{
				Add("msdyn_precreateattachmentsid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Pre Create Notes Id, Format: Text, MaxLength: 100, SchemaName: msdyn_precreatenotesid, IntroducedVersion: 1.0.  Description: Notes Id before the case record is created</summary>
	[JsonIgnore]
	public string? msdyn_precreatenotesid
	{
		get
		{
			return TryGetValue("msdyn_precreatenotesid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_precreatenotesid") is false || Remove("msdyn_precreatenotesid"))
			{
				Add("msdyn_precreatenotesid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Next Sla, Format: Text, MaxLength: 400, SchemaName: nextsla, IntroducedVersion: 1.0.0.0.  Description: Shows the unresolved SLA KPI associated with the Case with the earliest expiry time.</summary>
	[JsonIgnore]
	public string? nextsla
	{
		get
		{
			return TryGetValue("nextsla", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("nextsla") is false || Remove("nextsla"))
			{
				Add("nextsla", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Child Cases, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: NumberOfChildIncidents, IntroducedVersion: 6.1.0.0.  Description: Number of child incidents associated with the incident.</summary>
	[JsonIgnore]
	public int? NumberOfChildIncidents
	{
		get
		{
			return TryGetValue("numberofchildincidents", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("numberofchildincidents") is false || Remove("numberofchildincidents"))
			{
				Add("numberofchildincidents", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: On Hold Time (Minutes), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OnHoldTime, IntroducedVersion: 7.0.0.0.  Description: Shows the duration in minutes for which the case was on hold.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Case, Format: None, SchemaName: ParentCaseId, IntroducedVersion: 6.1.0.0.  Description: Choose the parent case for a case.</summary>
	[JsonIgnore]
	public string? ParentCaseIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentcaseid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Case, Format: None, SchemaName: ParentCaseId, IntroducedVersion: 6.1.0.0.  Description: Choose the parent case for a case.</summary>
	[JsonIgnore]
	public Guid? ParentCaseId
	{
		get
		{
			return TryGetValue("_parentcaseid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Case, Format: None, SchemaName: ParentCaseId, IntroducedVersion: 6.1.0.0.  Description: Choose the parent case for a case.</summary>
	[JsonIgnore]
	public Guid? ParentCaseId_incident
	{
		set
		{
			if (ContainsKey("parentcaseid_incident@odata.bind") is false || Remove("parentcaseid_incident@odata.bind"))
			{
				if (value is not null)
				{
					Add("parentcaseid_incident@odata.bind", $"({value})");
				}
				else
				{
					Add("_parentcaseid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentcaseid, Format: Text, MaxLength: 100, SchemaName: ParentCaseIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? ParentCaseIdName
	{
		get
		{
			return TryGetValue("parentcaseidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentcaseidname") is false || Remove("parentcaseidname"))
			{
				Add("parentcaseidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 6.1.0.0.  Description: Select a primary contact for this case.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 6.1.0.0.  Description: Select a primary contact for this case.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Contact, Format: None, SchemaName: PrimaryContactId, IntroducedVersion: 6.1.0.0.  Description: Select a primary contact for this case.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primarycontactid, Format: Text, MaxLength: 100, SchemaName: PrimaryContactIdName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primarycontactid, Format: Text, MaxLength: 100, SchemaName: PrimaryContactIdYomiName, YomiOf: primarycontactidname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Product, Format: None, SchemaName: ProductId, IntroducedVersion: 5.0.0.0.  Description: Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Serial Number, Format: Text, MaxLength: 100, SchemaName: ProductSerialNumber, IntroducedVersion: 5.0.0.0.  Description: Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Resolve By, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ResolveBy, IntroducedVersion: 6.1.0.0.  Description: Enter the date by when the case must be resolved.</summary>
	[JsonIgnore]
	public DateTime? ResolveBy
	{
		get
		{
			return TryGetValue("resolveby", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("resolveby") is false || Remove("resolveby"))
			{
				Add("resolveby", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Resolve By KPI, Format: None, SchemaName: ResolveByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? ResolveByKPIIdFormattedValue
	{
		get
		{
			return TryGetValue("_resolvebykpiid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Resolve By KPI, Format: None, SchemaName: ResolveByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? ResolveByKPIId
	{
		get
		{
			return TryGetValue("_resolvebykpiid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Resolve By KPI, Format: None, SchemaName: ResolveByKPIId, IntroducedVersion: 7.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public Guid? ResolveByKPIId_slakpiinstance
	{
		set
		{
			if (ContainsKey("resolvebykpiid_slakpiinstance@odata.bind") is false || Remove("resolvebykpiid_slakpiinstance@odata.bind"))
			{
				if (value is not null)
				{
					Add("resolvebykpiid_slakpiinstance@odata.bind", $"({value})");
				}
				else
				{
					Add("_resolvebykpiid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: resolvebykpiid, Format: Text, MaxLength: 100, SchemaName: ResolveByKPIIdName, IntroducedVersion: 7.0.0.0. </summary>
	[JsonIgnore]
	public string? ResolveByKPIIdName
	{
		get
		{
			return TryGetValue("resolvebykpiidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("resolvebykpiidname") is false || Remove("resolvebykpiidname"))
			{
				Add("resolvebykpiidname", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Resolve By SLA Status, SchemaName: ResolveBySLAStatus, IntroducedVersion: 6.1.0.0.  Description: Shows the status of the resolution time for the case according to the terms of the SLA.</summary>
	[JsonIgnore]
	public string? ResolveBySLAStatusFormattedValue
	{
		get
		{
			return TryGetValue("resolvebyslastatus@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Resolve By SLA Status, SchemaName: ResolveBySLAStatus, IntroducedVersion: 6.1.0.0.  Description: Shows the status of the resolution time for the case according to the terms of the SLA.</summary>
	[JsonIgnore]
	public int? ResolveBySLAStatus
	{
		get
		{
			return TryGetValue("resolvebyslastatus", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("resolvebyslastatus") is false || Remove("resolvebyslastatus"))
			{
				Add("resolvebyslastatus", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: resolvebyslastatus, SchemaName: ResolveBySLAStatusName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? ResolveBySLAStatusName
	{
		get
		{
			return TryGetValue("resolvebyslastatusname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: First Response By, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ResponseBy, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public DateTime? ResponseBy
	{
		get
		{
			return TryGetValue("responseby", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("responseby") is false || Remove("responseby"))
			{
				Add("responseby", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Responsible Contact (Deprecated), Format: None, SchemaName: ResponsibleContactId, IntroducedVersion: 5.0.0.0.  Description: Choose an additional customer contact who can also help resolve the case.</summary>
	[JsonIgnore]
	public string? ResponsibleContactIdFormattedValue
	{
		get
		{
			return TryGetValue("_responsiblecontactid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Responsible Contact (Deprecated), Format: None, SchemaName: ResponsibleContactId, IntroducedVersion: 5.0.0.0.  Description: Choose an additional customer contact who can also help resolve the case.</summary>
	[JsonIgnore]
	public Guid? ResponsibleContactId
	{
		get
		{
			return TryGetValue("_responsiblecontactid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Responsible Contact (Deprecated), Format: None, SchemaName: ResponsibleContactId, IntroducedVersion: 5.0.0.0.  Description: Choose an additional customer contact who can also help resolve the case.</summary>
	[JsonIgnore]
	public Guid? ResponsibleContactId_contact
	{
		set
		{
			if (ContainsKey("responsiblecontactid_contact@odata.bind") is false || Remove("responsiblecontactid_contact@odata.bind"))
			{
				if (value is not null)
				{
					Add("responsiblecontactid_contact@odata.bind", $"({value})");
				}
				else
				{
					Add("_responsiblecontactid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: responsiblecontactid, Format: Text, MaxLength: 100, SchemaName: ResponsibleContactIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ResponsibleContactIdName
	{
		get
		{
			return TryGetValue("responsiblecontactidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("responsiblecontactidname") is false || Remove("responsiblecontactidname"))
			{
				Add("responsiblecontactidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: responsiblecontactid, Format: Text, MaxLength: 100, SchemaName: ResponsibleContactIdYomiName, YomiOf: responsiblecontactidname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ResponsibleContactIdYomiName
	{
		get
		{
			return TryGetValue("responsiblecontactidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("responsiblecontactidyominame") is false || Remove("responsiblecontactidyominame"))
			{
				Add("responsiblecontactidyominame", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Route Case, SchemaName: RouteCase, IntroducedVersion: 6.1.0.0.  Description: Tells whether the incident has been routed to queue or not.</summary>
	[JsonIgnore]
	public string? RouteCaseFormattedValue
	{
		get
		{
			return TryGetValue("routecase@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Route Case, SchemaName: RouteCase, IntroducedVersion: 6.1.0.0.  Description: Tells whether the incident has been routed to queue or not.</summary>
	[JsonIgnore]
	public bool? RouteCase
	{
		get
		{
			return TryGetValue("routecase", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("routecase") is false || Remove("routecase"))
			{
				Add("routecase", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: routecase, SchemaName: routecaseName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? routecaseName
	{
		get
		{
			return TryGetValue("routecasename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Sentiment Value, Precision: 2, MinValue: -100000000000, MaxValue: 100000000000, SchemaName: SentimentValue, IntroducedVersion: 6.1.0.0.  Description: Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.</summary>
	[JsonIgnore]
	public double? SentimentValue
	{
		get
		{
			return TryGetValue("sentimentvalue", out var value)
				? value is not null ? ((JsonElement)value).GetDouble()
				: null : null;
		}
		set
		{
			if (ContainsKey("sentimentvalue") is false || Remove("sentimentvalue"))
			{
				Add("sentimentvalue", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Stage, SchemaName: ServiceStage, IntroducedVersion: 5.0.0.0.  Description: Select the stage, in the case resolution process, that the case is in.</summary>
	[JsonIgnore]
	public string? ServiceStageFormattedValue
	{
		get
		{
			return TryGetValue("servicestage@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Stage, SchemaName: ServiceStage, IntroducedVersion: 5.0.0.0.  Description: Select the stage, in the case resolution process, that the case is in.</summary>
	[JsonIgnore]
	public int? ServiceStage
	{
		get
		{
			return TryGetValue("servicestage", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("servicestage") is false || Remove("servicestage"))
			{
				Add("servicestage", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: servicestage, SchemaName: ServiceStageName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ServiceStageName
	{
		get
		{
			return TryGetValue("servicestagename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Severity, SchemaName: SeverityCode, IntroducedVersion: 5.0.0.0.  Description: Select the severity of this case to indicate the incident's impact on the customer's business.</summary>
	[JsonIgnore]
	public string? SeverityCodeFormattedValue
	{
		get
		{
			return TryGetValue("severitycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Severity, SchemaName: SeverityCode, IntroducedVersion: 5.0.0.0.  Description: Select the severity of this case to indicate the incident's impact on the customer's business.</summary>
	[JsonIgnore]
	public int? SeverityCode
	{
		get
		{
			return TryGetValue("severitycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("severitycode") is false || Remove("severitycode"))
			{
				Add("severitycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: severitycode, SchemaName: SeverityCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? SeverityCodeName
	{
		get
		{
			return TryGetValue("severitycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.0.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.0.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.0.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 6.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 6.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 6.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slainvokedid, Format: Text, MaxLength: 100, SchemaName: SLAInvokedIdName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: SLAName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Social Profile, Format: None, SchemaName: SocialProfileId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the social profile with which the case is associated.</summary>
	[JsonIgnore]
	public string? SocialProfileIdFormattedValue
	{
		get
		{
			return TryGetValue("_socialprofileid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Social Profile, Format: None, SchemaName: SocialProfileId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the social profile with which the case is associated.</summary>
	[JsonIgnore]
	public Guid? SocialProfileId
	{
		get
		{
			return TryGetValue("_socialprofileid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Social Profile, Format: None, SchemaName: SocialProfileId, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the social profile with which the case is associated.</summary>
	[JsonIgnore]
	public Guid? SocialProfileId_socialprofile
	{
		set
		{
			if (ContainsKey("socialprofileid_socialprofile@odata.bind") is false || Remove("socialprofileid_socialprofile@odata.bind"))
			{
				if (value is not null)
				{
					Add("socialprofileid_socialprofile@odata.bind", $"({value})");
				}
				else
				{
					Add("_socialprofileid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: socialprofileid, Format: Text, MaxLength: 100, SchemaName: SocialProfileIdName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public string? SocialProfileIdName
	{
		get
		{
			return TryGetValue("socialprofileidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("socialprofileidname") is false || Remove("socialprofileidname"))
			{
				Add("socialprofileidname", value);
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the case's status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Select the case's status.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 5.0.0.0.  Description: Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Case Number, AutoNumberFormat: CAS-{SEQNUM:5}-{RANDSTRING:6}, Format: Text, MaxLength: 100, SchemaName: TicketNumber, IntroducedVersion: 5.0.0.0.  Description: Shows the case number for customer reference and searching capabilities. This cannot be modified.</summary>
	[JsonIgnore]
	public string? TicketNumber
	{
		get
		{
			return TryGetValue("ticketnumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("ticketnumber") is false || Remove("ticketnumber"))
			{
				Add("ticketnumber", value);
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

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Case Title, Format: Text, MaxLength: 200, SchemaName: Title, IntroducedVersion: 5.0.0.0.  Description: Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics 365 views.</summary>
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

}

