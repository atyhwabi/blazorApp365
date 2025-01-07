namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public sealed partial class ecsm_category : Dictionary<string, object>
{
	[JsonIgnore]
	public SystemUser? CreatedBy_SystemUser_Nav
	{
		get
		{
			if (ContainsKey("createdby")
				&& TryGetValue("createdby", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return jsonElement.Deserialize<SystemUser>();
			}
			return null;
		}
	}

	[JsonIgnore]
	public SystemUser? CreatedOnBehalfBy_SystemUser_Nav
	{
		get
		{
			if (ContainsKey("createdby")
				&& TryGetValue("createdby", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return jsonElement.Deserialize<SystemUser>();
			}
			return null;
		}
	}

	[JsonIgnore]
	public SystemUser? ModifiedBy_SystemUser_Nav
	{
		get
		{
			if (ContainsKey("createdby")
				&& TryGetValue("createdby", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return jsonElement.Deserialize<SystemUser>();
			}
			return null;
		}
	}

	[JsonIgnore]
	public SystemUser? ModifiedOnBehalfBy_SystemUser_Nav
	{
		get
		{
			if (ContainsKey("createdby")
				&& TryGetValue("createdby", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return jsonElement.Deserialize<SystemUser>();
			}
			return null;
		}
	}

}

