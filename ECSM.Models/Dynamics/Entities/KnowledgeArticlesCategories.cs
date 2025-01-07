namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Category for a Knowledge Article.</summary>
public sealed partial class KnowledgeArticlesCategories : Dictionary<string, object>
{
	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: CategoryId, IntroducedVersion: 8.1.0.0. </summary>
	[JsonIgnore]
	public Guid? CategoryId
	{
		get
		{
			return TryGetValue("categoryid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("categoryid") is false || Remove("categoryid"))
			{
				Add("categoryid", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: KnowledgeArticleCategoryId, IntroducedVersion: 8.1.0.0.  Description: Unique identifier of the Category for the knowledge article.</summary>
	[JsonIgnore]
	public Guid? KnowledgeArticleCategoryId
	{
		get
		{
			return TryGetValue("knowledgearticlecategoryid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("knowledgearticlecategoryid") is false || Remove("knowledgearticlecategoryid"))
			{
				Add("knowledgearticlecategoryid", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, SchemaName: KnowledgeArticleId, IntroducedVersion: 8.1.0.0. </summary>
	[JsonIgnore]
	public Guid? KnowledgeArticleId
	{
		get
		{
			return TryGetValue("knowledgearticleid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("knowledgearticleid") is false || Remove("knowledgearticleid"))
			{
				Add("knowledgearticleid", value);
			}
		}
	}

	/// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 8.1.0.0. </summary>
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

