namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.</summary>
public sealed partial class SystemUser : Dictionary<string, object>
{
	[JsonIgnore]
	public BusinessUnit? BusinessUnitId_BusinessUnit_Nav
	{
		get
		{
			if (ContainsKey("businessunitid")
				&& TryGetValue("businessunitid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<BusinessUnit>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public SystemUser? CreatedBy_SystemUser_Nav
	{
		get
		{
			if (ContainsKey("parentsystemuserid")
				&& TryGetValue("parentsystemuserid", out var item)
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
			if (ContainsKey("parentsystemuserid")
				&& TryGetValue("parentsystemuserid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<SystemUser>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public SystemUser? ModifiedBy_SystemUser_Nav
	{
		get
		{
			if (ContainsKey("parentsystemuserid")
				&& TryGetValue("parentsystemuserid", out var item)
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
			if (ContainsKey("parentsystemuserid")
				&& TryGetValue("parentsystemuserid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<SystemUser>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public SystemUser? ParentSystemUserId_SystemUser_Nav
	{
		get
		{
			if (ContainsKey("parentsystemuserid")
				&& TryGetValue("parentsystemuserid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<SystemUser>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public Site? SiteId_Site_Nav
	{
		get
		{
			if (ContainsKey("siteid")
				&& TryGetValue("siteid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<Site>(jsonElement.GetRawText());
			}
			return null;
		}
	}

	[JsonIgnore]
	public TransactionCurrency? TransactionCurrencyId_TransactionCurrency_Nav
	{
		get
		{
			if (ContainsKey("transactioncurrencyid")
				&& TryGetValue("transactioncurrencyid", out var item)
				&& item is JsonElement jsonElement
				&& jsonElement.ValueKind is JsonValueKind.Object)
			{
				return JsonSerializer.Deserialize<TransactionCurrency>(jsonElement.GetRawText());
			}
			return null;
		}
	}

}

