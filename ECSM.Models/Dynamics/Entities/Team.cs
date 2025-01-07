namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.</summary>
public sealed partial class Team : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Administrator, Format: None, SchemaName: AdministratorId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user primary responsible for the team.</summary>
	[JsonIgnore]
	public string? AdministratorIdFormattedValue
	{
		get
		{
			return TryGetValue("_administratorid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Administrator, Format: None, SchemaName: AdministratorId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user primary responsible for the team.</summary>
	[JsonIgnore]
	public Guid? AdministratorId
	{
		get
		{
			return TryGetValue("_administratorid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Administrator, Format: None, SchemaName: AdministratorId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user primary responsible for the team.</summary>
	[JsonIgnore]
	public Guid? AdministratorId_systemuser
	{
		set
		{
			if (ContainsKey("administratorid_systemuser@odata.bind") is false || Remove("administratorid_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("administratorid_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_administratorid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: administratorid, Format: Text, MaxLength: 100, SchemaName: AdministratorIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? AdministratorIdName
	{
		get
		{
			return TryGetValue("administratoridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("administratoridname") is false || Remove("administratoridname"))
			{
				Add("administratoridname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: administratorid, Format: Text, MaxLength: 100, SchemaName: AdministratorIdYomiName, YomiOf: administratoridname, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? AdministratorIdYomiName
	{
		get
		{
			return TryGetValue("administratoridyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("administratoridyominame") is false || Remove("administratoridyominame"))
			{
				Add("administratoridyominame", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Object Id for a group, SchemaName: AzureActiveDirectoryObjectId, IntroducedVersion: 9.1.0.0.  Description: The object Id for a group.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the team is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the team is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Business Unit, Format: None, SchemaName: BusinessUnitId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit with which the team is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the team.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the team was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Delegated authorization, Format: None, SchemaName: DelegatedAuthorizationId, IntroducedVersion: 9.2.0.0.  Description: The delegated authorization context for the team.</summary>
	[JsonIgnore]
	public string? DelegatedAuthorizationIdFormattedValue
	{
		get
		{
			return TryGetValue("_delegatedauthorizationid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Delegated authorization, Format: None, SchemaName: DelegatedAuthorizationId, IntroducedVersion: 9.2.0.0.  Description: The delegated authorization context for the team.</summary>
	[JsonIgnore]
	public Guid? DelegatedAuthorizationId
	{
		get
		{
			return TryGetValue("_delegatedauthorizationid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Delegated authorization, Format: None, SchemaName: DelegatedAuthorizationId, IntroducedVersion: 9.2.0.0.  Description: The delegated authorization context for the team.</summary>
	[JsonIgnore]
	public Guid? DelegatedAuthorizationId_delegatedauthorization
	{
		set
		{
			if (ContainsKey("delegatedauthorizationid_delegatedauthorization@odata.bind") is false || Remove("delegatedauthorizationid_delegatedauthorization@odata.bind"))
			{
				if (value is not null)
				{
					Add("delegatedauthorizationid_delegatedauthorization@odata.bind", $"({value})");
				}
				else
				{
					Add("_delegatedauthorizationid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: delegatedauthorizationid, Format: Text, MaxLength: 100, SchemaName: DelegatedAuthorizationIdName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? DelegatedAuthorizationIdName
	{
		get
		{
			return TryGetValue("delegatedauthorizationidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("delegatedauthorizationidname") is false || Remove("delegatedauthorizationidname"))
			{
				Add("delegatedauthorizationidname", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 2000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Description of the team.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Email, Format: Email, MaxLength: 100, SchemaName: EMailAddress, IntroducedVersion: 5.0.0.0.  Description: Email address for the team.</summary>
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the team with respect to the base currency.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Default, SchemaName: IsDefault, IntroducedVersion: 5.0.0.0.  Description: Information about whether the team is a default business unit team.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Default, SchemaName: IsDefault, IntroducedVersion: 5.0.0.0.  Description: Information about whether the team is a default business unit team.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isdefault, SchemaName: IsDefaultName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, SchemaName: IsSasTokenSet, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public string? IsSasTokenSetFormattedValue
	{
		get
		{
			return TryGetValue("issastokenset@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, SchemaName: IsSasTokenSet, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public bool? IsSasTokenSet
	{
		get
		{
			return TryGetValue("issastokenset", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("issastokenset") is false || Remove("issastokenset"))
			{
				Add("issastokenset", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: issastokenset, SchemaName: issastokensetName, IntroducedVersion: 9.2.0.0. </summary>
	[JsonIgnore]
	public object? issastokensetName
	{
		get
		{
			return TryGetValue("issastokensetname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Membership Type, SchemaName: MembershipType, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? MembershipTypeFormattedValue
	{
		get
		{
			return TryGetValue("membershiptype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Membership Type, SchemaName: MembershipType, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public int? MembershipType
	{
		get
		{
			return TryGetValue("membershiptype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("membershiptype") is false || Remove("membershiptype"))
			{
				Add("membershiptype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: membershiptype, SchemaName: membershiptypeName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? membershiptypeName
	{
		get
		{
			return TryGetValue("membershiptypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the team.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the team was last modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the team.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Team Name, Format: Text, MaxLength: 160, SchemaName: Name, IntroducedVersion: 5.0.0.0.  Description: Name of the team.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Organization , SchemaName: OrganizationId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the organization associated with the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Default Queue, Format: None, SchemaName: QueueId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the default queue for the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding Object Id, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 6.0.0.0.  Description: Choose the record that the team relates to.</summary>
	[JsonIgnore]
	public string? RegardingObjectIdFormattedValue
	{
		get
		{
			return TryGetValue("_regardingobjectid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding Object Id, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 6.0.0.0.  Description: Choose the record that the team relates to.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId
	{
		get
		{
			return TryGetValue("_regardingobjectid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding Object Id, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 6.0.0.0.  Description: Choose the record that the team relates to.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_knowledgearticle
	{
		set
		{
			if (ContainsKey("regardingobjectid_knowledgearticle@odata.bind") is false || Remove("regardingobjectid_knowledgearticle@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_knowledgearticle@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding Object Id, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 6.0.0.0.  Description: Choose the record that the team relates to.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_opportunity
	{
		set
		{
			if (ContainsKey("regardingobjectid_opportunity@odata.bind") is false || Remove("regardingobjectid_opportunity@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_opportunity@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: None, DisplayName: Regarding Object Type, AttributeOf: regardingobjectid, SchemaName: RegardingObjectTypeCode, IntroducedVersion: 6.0.0.0.  Description: Type of the associated record for team - used for system managed access teams only.</summary>
	[JsonIgnore]
	public string? RegardingObjectTypeCode
	{
		get
		{
			return TryGetValue("regardingobjecttypecode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingobjecttypecode") is false || Remove("regardingobjecttypecode"))
			{
				Add("regardingobjecttypecode", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Sas Token, Format: Text, MaxLength: 50, SchemaName: SasToken, IntroducedVersion: 9.2.0.0.  Description: Sas Token for Team.</summary>
	[JsonIgnore]
	public string? SasToken
	{
		get
		{
			return TryGetValue("sastoken", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("sastoken") is false || Remove("sastoken"))
			{
				Add("sastoken", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Share Link Qualifier, Format: Text, MaxLength: 1250, SchemaName: ShareLinkQualifier, IntroducedVersion: 9.2.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? ShareLinkQualifier
	{
		get
		{
			return TryGetValue("sharelinkqualifier", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("sharelinkqualifier") is false || Remove("sharelinkqualifier"))
			{
				Add("sharelinkqualifier", value);
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

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is System Managed, SchemaName: SystemManaged, IntroducedVersion: 6.0.0.0.  Description: Select whether the team will be managed by the system.</summary>
	[JsonIgnore]
	public string? SystemManagedFormattedValue
	{
		get
		{
			return TryGetValue("systemmanaged@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is System Managed, SchemaName: SystemManaged, IntroducedVersion: 6.0.0.0.  Description: Select whether the team will be managed by the system.</summary>
	[JsonIgnore]
	public bool? SystemManaged
	{
		get
		{
			return TryGetValue("systemmanaged", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("systemmanaged") is false || Remove("systemmanaged"))
			{
				Add("systemmanaged", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: systemmanaged, SchemaName: SystemManagedName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public object? SystemManagedName
	{
		get
		{
			return TryGetValue("systemmanagedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Team, SchemaName: TeamId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier for the team.</summary>
	[JsonIgnore]
	public Guid? TeamId
	{
		get
		{
			return TryGetValue("teamid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("teamid") is false || Remove("teamid"))
			{
				Add("teamid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Team Template Identifier, Format: None, SchemaName: TeamTemplateId, IntroducedVersion: 6.0.0.0.  Description: Shows the team template that is associated with the team.</summary>
	[JsonIgnore]
	public string? TeamTemplateIdFormattedValue
	{
		get
		{
			return TryGetValue("_teamtemplateid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Team Template Identifier, Format: None, SchemaName: TeamTemplateId, IntroducedVersion: 6.0.0.0.  Description: Shows the team template that is associated with the team.</summary>
	[JsonIgnore]
	public Guid? TeamTemplateId
	{
		get
		{
			return TryGetValue("_teamtemplateid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Team Template Identifier, Format: None, SchemaName: TeamTemplateId, IntroducedVersion: 6.0.0.0.  Description: Shows the team template that is associated with the team.</summary>
	[JsonIgnore]
	public Guid? TeamTemplateId_teamtemplate
	{
		set
		{
			if (ContainsKey("teamtemplateid_teamtemplate@odata.bind") is false || Remove("teamtemplateid_teamtemplate@odata.bind"))
			{
				if (value is not null)
				{
					Add("teamtemplateid_teamtemplate@odata.bind", $"({value})");
				}
				else
				{
					Add("_teamtemplateid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Team Type, SchemaName: TeamType, IntroducedVersion: 6.0.0.0.  Description: Select the team type.</summary>
	[JsonIgnore]
	public string? TeamTypeFormattedValue
	{
		get
		{
			return TryGetValue("teamtype@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Team Type, SchemaName: TeamType, IntroducedVersion: 6.0.0.0.  Description: Select the team type.</summary>
	[JsonIgnore]
	public int? TeamType
	{
		get
		{
			return TryGetValue("teamtype", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("teamtype") is false || Remove("teamtype"))
			{
				Add("teamtype", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: teamtype, SchemaName: TeamTypeName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public object? TeamTypeName
	{
		get
		{
			return TryGetValue("teamtypename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the team.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the team.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the team.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Yomi Name, Format: PhoneticGuide, MaxLength: 160, SchemaName: YomiName, YomiOf: name, IntroducedVersion: 5.0.0.0.  Description: Pronunciation of the full name of the team, written in phonetic hiragana or katakana characters.</summary>
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

