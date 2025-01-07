namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Language</summary>
public sealed partial class LanguageLocale : Dictionary<string, object>
{
	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Code, Format: Text, MaxLength: 100, SchemaName: Code, IntroducedVersion: 8.0.0.0.  Description: Code</summary>
	[JsonIgnore]
	public string? Code
	{
		get
		{
			return TryGetValue("code", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("code") is false || Remove("code"))
			{
				Add("code", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Language, Format: Text, MaxLength: 100, SchemaName: Language, IntroducedVersion: 8.0.0.0.  Description: Language</summary>
	[JsonIgnore]
	public string? Language
	{
		get
		{
			return TryGetValue("language", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("language") is false || Remove("language"))
			{
				Add("language", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: LanguageLocaleId, IntroducedVersion: 8.0.0.0.  Description: LanguageLocaleId</summary>
	[JsonIgnore]
	public Guid? LanguageLocaleId
	{
		get
		{
			return TryGetValue("languagelocaleid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("languagelocaleid") is false || Remove("languagelocaleid"))
			{
				Add("languagelocaleid", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Locale ID, Format: None, MinValue: 1, MaxValue: 2147483647, SchemaName: LocaleId, IntroducedVersion: 8.0.0.0.  Description: Locale ID</summary>
	[JsonIgnore]
	public int? LocaleId
	{
		get
		{
			return TryGetValue("localeid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("localeid") is false || Remove("localeid"))
			{
				Add("localeid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Name, Format: Text, MaxLength: 100, SchemaName: Name, IntroducedVersion: 8.0.0.0.  Description: Name</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the organization associated with the language locale.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the organization associated with the language locale.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Organization, Format: None, SchemaName: OrganizationId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the organization associated with the language locale.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Region, Format: Text, MaxLength: 100, SchemaName: Region, IntroducedVersion: 8.0.0.0.  Description: Region</summary>
	[JsonIgnore]
	public string? Region
	{
		get
		{
			return TryGetValue("region", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("region") is false || Remove("region"))
			{
				Add("region", value);
			}
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: State Code, SchemaName: statecode, IntroducedVersion: 8.0.0.0.  Description: State Code</summary>
	[JsonIgnore]
	public string? statecodeFormattedValue
	{
		get
		{
			return TryGetValue("statecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: State Code, SchemaName: statecode, IntroducedVersion: 8.0.0.0.  Description: State Code</summary>
	[JsonIgnore]
	public int? statecode
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: statecodeName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? statecodeName
	{
		get
		{
			return TryGetValue("statecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Language Status Code, SchemaName: statuscode, IntroducedVersion: 8.0.0.0.  Description: Language Status Code</summary>
	[JsonIgnore]
	public string? statuscodeFormattedValue
	{
		get
		{
			return TryGetValue("statuscode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Language Status Code, SchemaName: statuscode, IntroducedVersion: 8.0.0.0.  Description: Language Status Code</summary>
	[JsonIgnore]
	public int? statuscode
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: statuscodeName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? statuscodeName
	{
		get
		{
			return TryGetValue("statuscodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 8.0.0.0. </summary>
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

