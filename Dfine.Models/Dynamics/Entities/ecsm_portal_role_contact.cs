namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public sealed partial class ecsm_portal_role_contact : Dictionary<string, object>
{
	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: contactid, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? contactid
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: ecsm_portal_role_contactId, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? ecsm_portal_role_contactId
	{
		get
		{
			return TryGetValue("ecsm_portal_role_contactid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_portal_role_contactid") is false || Remove("ecsm_portal_role_contactid"))
			{
				Add("ecsm_portal_role_contactid", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: ecsm_portal_roleid, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public Guid? ecsm_portal_roleid
	{
		get
		{
			return TryGetValue("ecsm_portal_roleid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_portal_roleid") is false || Remove("ecsm_portal_roleid"))
			{
				Add("ecsm_portal_roleid", value);
			}
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 1.0.0.0. </summary>
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

