namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public sealed partial class ecsm_incident : Dictionary<string, object>
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
				return JsonSerializer.Deserialize<SystemUser>(jsonElement.GetRawText());
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
				return JsonSerializer.Deserialize<SystemUser>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public Account? ecsm_account_Account_Nav
	{
		get
		{
			if (ContainsKey("ecsm_account")
				&& TryGetValue("ecsm_account", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<Account>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public ecsm_category? ecsm_category_ecsm_category_Nav
	{
		get
		{
			if (ContainsKey("ecsm_category")
				&& TryGetValue("ecsm_category", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<ecsm_category>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public Contact? ecsm_contact_Contact_Nav
	{
		get
		{
			if (ContainsKey("ecsm_contact")
				&& TryGetValue("ecsm_contact", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<Contact>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public ecsm_service_catalogue? ecsm_service_catalogue_ecsm_service_catalogue_Nav
	{
		get
		{
			if (ContainsKey("ecsm_service_catalogue")
				&& TryGetValue("ecsm_service_catalogue", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<ecsm_service_catalogue>(jsonElement.GetRawText());
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
				return JsonSerializer.Deserialize<SystemUser>(jsonElement.GetRawText());
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
				return JsonSerializer.Deserialize<SystemUser>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public SLA? SLAId_SLA_Nav
	{
		get
		{
			if (ContainsKey("slaid")
				&& TryGetValue("slaid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<SLA>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public SLA? SLAInvokedId_SLA_Nav
	{
		get
		{
			if (ContainsKey("slaid")
				&& TryGetValue("slaid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<SLA>(jsonElement.GetRawText());
			}
			return null;
		}
	}

}

