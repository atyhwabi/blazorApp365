namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Organizational knowledge for internal and external use.</summary>
public sealed partial class KnowledgeArticle : Dictionary<string, object>
{
	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Article Public Number, AutoNumberFormat: KA-{SEQNUM:5}, Format: Text, MaxLength: 4000, SchemaName: ArticlePublicNumber, IntroducedVersion: 8.0.0.0.  Description: Shows the automatically generated ID exposed to customers, partners, and other external users to reference and look up articles.</summary>
	[JsonIgnore]
	public string? ArticlePublicNumber
	{
		get
		{
			return TryGetValue("articlepublicnumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("articlepublicnumber") is false || Remove("articlepublicnumber"))
			{
				Add("articlepublicnumber", value);
			}
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Content, Format: TextArea, MaxLength: 1073741823, SchemaName: Content, IntroducedVersion: 8.0.0.0.  Description: Shows the body of the article stored in HTML format.</summary>
	[JsonIgnore]
	public string? Content
	{
		get
		{
			return TryGetValue("content", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("content") is false || Remove("content"))
			{
				Add("content", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 8.0.0.0.  Description: Date and time when the record was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Description, Format: TextArea, MaxLength: 155, SchemaName: Description, IntroducedVersion: 8.0.0.0.  Description: A short overview of the article, primarily used in search results and for search engine optimization.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: FAQ, SchemaName: ecsm_faq, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_faqFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_faq@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: FAQ, SchemaName: ecsm_faq, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public bool? ecsm_faq
	{
		get
		{
			return TryGetValue("ecsm_faq", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_faq") is false || Remove("ecsm_faq"))
			{
				Add("ecsm_faq", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_faq, SchemaName: ecsm_faqName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? ecsm_faqName
	{
		get
		{
			return TryGetValue("ecsm_faqname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Public, SchemaName: ecsm_public, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? ecsm_publicFormattedValue
	{
		get
		{
			return TryGetValue("ecsm_public@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Public, SchemaName: ecsm_public, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public bool? ecsm_public
	{
		get
		{
			return TryGetValue("ecsm_public", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ecsm_public") is false || Remove("ecsm_public"))
			{
				Add("ecsm_public", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ecsm_public, SchemaName: ecsm_publicName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? ecsm_publicName
	{
		get
		{
			return TryGetValue("ecsm_publicname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: ExchangeRate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 8.0.0.0.  Description: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Expiration Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ExpirationDate, IntroducedVersion: 8.0.0.0.  Description: Enter an expiration date for the article. Leave this field blank for no expiration date.</summary>
	[JsonIgnore]
	public DateTime? ExpirationDate
	{
		get
		{
			return TryGetValue("expirationdate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("expirationdate") is false || Remove("expirationdate"))
			{
				Add("expirationdate", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Expiration State Id, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: ExpirationStateId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the expiration state of the entity.</summary>
	[JsonIgnore]
	public int? ExpirationStateId
	{
		get
		{
			return TryGetValue("expirationstateid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("expirationstateid") is false || Remove("expirationstateid"))
			{
				Add("expirationstateid", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Expired Status, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: ExpirationStatusId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the expiration status of the entity.</summary>
	[JsonIgnore]
	public int? ExpirationStatusId
	{
		get
		{
			return TryGetValue("expirationstatusid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("expirationstatusid") is false || Remove("expirationstatusid"))
			{
				Add("expirationstatusid", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Expired Review Options, SchemaName: ExpiredReviewOptions, IntroducedVersion: 8.0.0.0.  Description: Expired Review Options</summary>
	[JsonIgnore]
	public string? ExpiredReviewOptionsFormattedValue
	{
		get
		{
			return TryGetValue("expiredreviewoptions@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Expired Review Options, SchemaName: ExpiredReviewOptions, IntroducedVersion: 8.0.0.0.  Description: Expired Review Options</summary>
	[JsonIgnore]
	public int? ExpiredReviewOptions
	{
		get
		{
			return TryGetValue("expiredreviewoptions", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("expiredreviewoptions") is false || Remove("expiredreviewoptions"))
			{
				Add("expiredreviewoptions", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 8.0.0.0.  Description: Sequence number of the import that created this record.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: expiredreviewoptions, SchemaName: isExpiredReviewOptions, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? isExpiredReviewOptions
	{
		get
		{
			return TryGetValue("isexpiredreviewoptions", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Internal, SchemaName: IsInternal, IntroducedVersion: 8.1.0.0.  Description: Shows whether this article is only visible internally.</summary>
	[JsonIgnore]
	public string? IsInternalFormattedValue
	{
		get
		{
			return TryGetValue("isinternal@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Internal, SchemaName: IsInternal, IntroducedVersion: 8.1.0.0.  Description: Shows whether this article is only visible internally.</summary>
	[JsonIgnore]
	public bool? IsInternal
	{
		get
		{
			return TryGetValue("isinternal", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isinternal") is false || Remove("isinternal"))
			{
				Add("isinternal", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isinternal, SchemaName: IsInternalName, IntroducedVersion: 8.1.0.0. </summary>
	[JsonIgnore]
	public object? IsInternalName
	{
		get
		{
			return TryGetValue("isinternalname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Latest Version, SchemaName: IsLatestVersion, IntroducedVersion: 8.0.0.0.  Description: Shows which version of the knowledge article is the latest version.</summary>
	[JsonIgnore]
	public string? IsLatestVersionFormattedValue
	{
		get
		{
			return TryGetValue("islatestversion@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Latest Version, SchemaName: IsLatestVersion, IntroducedVersion: 8.0.0.0.  Description: Shows which version of the knowledge article is the latest version.</summary>
	[JsonIgnore]
	public bool? IsLatestVersion
	{
		get
		{
			return TryGetValue("islatestversion", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("islatestversion") is false || Remove("islatestversion"))
			{
				Add("islatestversion", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: islatestversion, SchemaName: IsLatestVersionName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? IsLatestVersionName
	{
		get
		{
			return TryGetValue("islatestversionname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Primary Article, SchemaName: IsPrimary, IntroducedVersion: 8.0.0.0.  Description: Select whether the article is the primary article.</summary>
	[JsonIgnore]
	public string? IsPrimaryFormattedValue
	{
		get
		{
			return TryGetValue("isprimary@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Primary Article, SchemaName: IsPrimary, IntroducedVersion: 8.0.0.0.  Description: Select whether the article is the primary article.</summary>
	[JsonIgnore]
	public bool? IsPrimary
	{
		get
		{
			return TryGetValue("isprimary", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isprimary") is false || Remove("isprimary"))
			{
				Add("isprimary", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isprimary, SchemaName: IsPrimaryName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? IsPrimaryName
	{
		get
		{
			return TryGetValue("isprimaryname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: setproductassociations, SchemaName: isProductAssociations, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? isProductAssociations
	{
		get
		{
			return TryGetValue("isproductassociations", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: readyforreview, SchemaName: isReadyForReview, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? isReadyForReview
	{
		get
		{
			return TryGetValue("isreadyforreview", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: review, SchemaName: isReview, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? isReview
	{
		get
		{
			return TryGetValue("isreview", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Root Article, SchemaName: IsRootArticle, IntroducedVersion: 8.0.0.0.  Description: Select whether the article is the root article.</summary>
	[JsonIgnore]
	public string? IsRootArticleFormattedValue
	{
		get
		{
			return TryGetValue("isrootarticle@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Root Article, SchemaName: IsRootArticle, IntroducedVersion: 8.0.0.0.  Description: Select whether the article is the root article.</summary>
	[JsonIgnore]
	public bool? IsRootArticle
	{
		get
		{
			return TryGetValue("isrootarticle", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isrootarticle") is false || Remove("isrootarticle"))
			{
				Add("isrootarticle", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isrootarticle, SchemaName: IsRootArticleName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? IsRootArticleName
	{
		get
		{
			return TryGetValue("isrootarticlename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: updatecontent, SchemaName: isUpdateContent, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public object? isUpdateContent
	{
		get
		{
			return TryGetValue("isupdatecontent", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: Recommended, DisplayName: Keywords, Format: Text, MaxLength: 4000, SchemaName: Keywords, IntroducedVersion: 8.0.0.0.  Description: Type keywords to be used for searches in knowledge base articles. Separate keywords by using commas.</summary>
	[JsonIgnore]
	public string? Keywords
	{
		get
		{
			return TryGetValue("keywords", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("keywords") is false || Remove("keywords"))
			{
				Add("keywords", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Knowledge Article, SchemaName: knowledgearticleId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for entity instances</summary>
	[JsonIgnore]
	public Guid? knowledgearticleId
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Knowledge Article Views, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: KnowledgeArticleViews, IntroducedVersion: 8.0.0.0.  Description: Shows the total number of article views.</summary>
	[JsonIgnore]
	public int? KnowledgeArticleViews
	{
		get
		{
			return TryGetValue("knowledgearticleviews", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("knowledgearticleviews") is false || Remove("knowledgearticleviews"))
			{
				Add("knowledgearticleviews", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Knowledge Article View(Last Updated Time), DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: KnowledgeArticleViews_Date, IntroducedVersion: 8.0.0.0.  Description: The date time for Knowledge Article View.</summary>
	[JsonIgnore]
	public DateTime? KnowledgeArticleViews_Date
	{
		get
		{
			return TryGetValue("knowledgearticleviews_date", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("knowledgearticleviews_date") is false || Remove("knowledgearticleviews_date"))
			{
				Add("knowledgearticleviews_date", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Knowledge Article View(State), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: KnowledgeArticleViews_State, IntroducedVersion: 8.0.0.0.  Description: State of Knowledge Article View.</summary>
	[JsonIgnore]
	public int? KnowledgeArticleViews_State
	{
		get
		{
			return TryGetValue("knowledgearticleviews_state", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("knowledgearticleviews_state") is false || Remove("knowledgearticleviews_state"))
			{
				Add("knowledgearticleviews_state", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Language, Format: None, SchemaName: LanguageLocaleId, IntroducedVersion: 8.0.0.0.  Description: Select the language that the article's content is in.</summary>
	[JsonIgnore]
	public string? LanguageLocaleIdFormattedValue
	{
		get
		{
			return TryGetValue("_languagelocaleid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Language, Format: None, SchemaName: LanguageLocaleId, IntroducedVersion: 8.0.0.0.  Description: Select the language that the article's content is in.</summary>
	[JsonIgnore]
	public Guid? LanguageLocaleId
	{
		get
		{
			return TryGetValue("_languagelocaleid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: SystemRequired, DisplayName: Language, Format: None, SchemaName: LanguageLocaleId, IntroducedVersion: 8.0.0.0.  Description: Select the language that the article's content is in.</summary>
	[JsonIgnore]
	public Guid? LanguageLocaleId_languagelocale
	{
		set
		{
			if (ContainsKey("languagelocaleid_languagelocale@odata.bind") is false || Remove("languagelocaleid_languagelocale@odata.bind"))
			{
				if (value is not null)
				{
					Add("languagelocaleid_languagelocale@odata.bind", $"({value})");
				}
				else
				{
					Add("_languagelocaleid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, AttributeOf: languagelocaleid, Format: None, MinValue: 1, MaxValue: 2147483647, SchemaName: LanguageLocaleIdLocaleId, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public int? LanguageLocaleIdLocaleId
	{
		get
		{
			return TryGetValue("languagelocaleidlocaleid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("languagelocaleidlocaleid") is false || Remove("languagelocaleidlocaleid"))
			{
				Add("languagelocaleidlocaleid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: languagelocaleid, Format: Text, MaxLength: 500, SchemaName: LanguageLocaleIdName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public string? LanguageLocaleIdName
	{
		get
		{
			return TryGetValue("languagelocaleidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("languagelocaleidname") is false || Remove("languagelocaleidname"))
			{
				Add("languagelocaleidname", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Major Version Number, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MajorVersionNumber, IntroducedVersion: 8.0.0.0.  Description: Shows the major version number of this article's content.</summary>
	[JsonIgnore]
	public int? MajorVersionNumber
	{
		get
		{
			return TryGetValue("majorversionnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("majorversionnumber") is false || Remove("majorversionnumber"))
			{
				Add("majorversionnumber", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: SystemRequired, DisplayName: Minor Version Number, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: MinorVersionNumber, IntroducedVersion: 8.0.0.0.  Description: Shows the minor version number of this article's content.</summary>
	[JsonIgnore]
	public int? MinorVersionNumber
	{
		get
		{
			return TryGetValue("minorversionnumber", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("minorversionnumber") is false || Remove("minorversionnumber"))
			{
				Add("minorversionnumber", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 8.0.0.0.  Description: Date and time when the record was modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, DisplayName: File storage content reference, MaxSizeInKb: 32768, MaxSizeInKb: 32768, SchemaName: msdyn_contentstore, IntroducedVersion: 1.0.  Description: Stores the reference to content in file store</summary>
	[JsonIgnore]
	public object? msdyn_contentstore
	{
		get
		{
			return TryGetValue("msdyn_contentstore", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_contentstore, Format: Text, MaxLength: 200, SchemaName: msdyn_contentstore_Name, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_contentstore_Name
	{
		get
		{
			return TryGetValue("msdyn_contentstore_name", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_contentstore_name") is false || Remove("msdyn_contentstore_name"))
			{
				Add("msdyn_contentstore_name", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Creation Mode, SchemaName: msdyn_creationmode, IntroducedVersion: 1.0.  Description: Opiton set to hold details about article if it is generated by AI or manually created</summary>
	[JsonIgnore]
	public string? msdyn_creationmodeFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_creationmode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Creation Mode, SchemaName: msdyn_creationmode, IntroducedVersion: 1.0.  Description: Opiton set to hold details about article if it is generated by AI or manually created</summary>
	[JsonIgnore]
	public int? msdyn_creationmode
	{
		get
		{
			return TryGetValue("msdyn_creationmode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_creationmode") is false || Remove("msdyn_creationmode"))
			{
				Add("msdyn_creationmode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_creationmode, SchemaName: msdyn_creationmodeName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_creationmodeName
	{
		get
		{
			return TryGetValue("msdyn_creationmodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: External Reference Id, Format: Text, MaxLength: 450, SchemaName: msdyn_externalreferenceid, IntroducedVersion: 1.0.0.0.  Description: External Reference Id</summary>
	[JsonIgnore]
	public string? msdyn_externalreferenceid
	{
		get
		{
			return TryGetValue("msdyn_externalreferenceid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_externalreferenceid") is false || Remove("msdyn_externalreferenceid"))
			{
				Add("msdyn_externalreferenceid", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Ingested Article URL, Format: Text, MaxLength: 2048, SchemaName: msdyn_ingestedarticleurl, IntroducedVersion: 9.1.0.0.  Description: Ingested article URL</summary>
	[JsonIgnore]
	public string? msdyn_ingestedarticleurl
	{
		get
		{
			return TryGetValue("msdyn_ingestedarticleurl", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_ingestedarticleurl") is false || Remove("msdyn_ingestedarticleurl"))
			{
				Add("msdyn_ingestedarticleurl", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Integrated Search Dataprovider Id , Format: None, SchemaName: msdyn_integratedsearchproviderid, IntroducedVersion: 1.0.0.0.  Description: Integrated Search Dataprovider Id </summary>
	[JsonIgnore]
	public string? msdyn_integratedsearchprovideridFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_integratedsearchproviderid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Integrated Search Dataprovider Id , Format: None, SchemaName: msdyn_integratedsearchproviderid, IntroducedVersion: 1.0.0.0.  Description: Integrated Search Dataprovider Id </summary>
	[JsonIgnore]
	public Guid? msdyn_integratedsearchproviderid
	{
		get
		{
			return TryGetValue("_msdyn_integratedsearchproviderid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Integrated Search Dataprovider Id , Format: None, SchemaName: msdyn_integratedsearchproviderid, IntroducedVersion: 1.0.0.0.  Description: Integrated Search Dataprovider Id </summary>
	[JsonIgnore]
	public Guid? msdyn_integratedsearchproviderid_msdyn_integratedsearchprovider
	{
		set
		{
			if (ContainsKey("msdyn_integratedsearchproviderid_msdyn_integratedsearchprovider@odata.bind") is false || Remove("msdyn_integratedsearchproviderid_msdyn_integratedsearchprovider@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_integratedsearchproviderid_msdyn_integratedsearchprovider@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_integratedsearchproviderid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_integratedsearchproviderid, Format: Text, MaxLength: 255, SchemaName: msdyn_integratedsearchprovideridName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_integratedsearchprovideridName
	{
		get
		{
			return TryGetValue("msdyn_integratedsearchprovideridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_integratedsearchprovideridname") is false || Remove("msdyn_integratedsearchprovideridname"))
			{
				Add("msdyn_integratedsearchprovideridname", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is content synced to file storage, SchemaName: msdyn_iscontentsyncedtostore, IntroducedVersion: 1.0.  Description: Sets whether the article content is synced to file storage</summary>
	[JsonIgnore]
	public string? msdyn_iscontentsyncedtostoreFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_iscontentsyncedtostore@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is content synced to file storage, SchemaName: msdyn_iscontentsyncedtostore, IntroducedVersion: 1.0.  Description: Sets whether the article content is synced to file storage</summary>
	[JsonIgnore]
	public bool? msdyn_iscontentsyncedtostore
	{
		get
		{
			return TryGetValue("msdyn_iscontentsyncedtostore", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_iscontentsyncedtostore") is false || Remove("msdyn_iscontentsyncedtostore"))
			{
				Add("msdyn_iscontentsyncedtostore", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_iscontentsyncedtostore, SchemaName: msdyn_iscontentsyncedtostoreName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_iscontentsyncedtostoreName
	{
		get
		{
			return TryGetValue("msdyn_iscontentsyncedtostorename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Ingested Article, SchemaName: msdyn_isingestedarticle, IntroducedVersion: 9.1.0.0.  Description: Value is true for all Ingested articles</summary>
	[JsonIgnore]
	public string? msdyn_isingestedarticleFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_isingestedarticle@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Ingested Article, SchemaName: msdyn_isingestedarticle, IntroducedVersion: 9.1.0.0.  Description: Value is true for all Ingested articles</summary>
	[JsonIgnore]
	public bool? msdyn_isingestedarticle
	{
		get
		{
			return TryGetValue("msdyn_isingestedarticle", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_isingestedarticle") is false || Remove("msdyn_isingestedarticle"))
			{
				Add("msdyn_isingestedarticle", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_isingestedarticle, SchemaName: msdyn_isingestedarticleName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_isingestedarticleName
	{
		get
		{
			return TryGetValue("msdyn_isingestedarticlename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Keywords and Description Suggestion control, SchemaName: msdyn_keywordsdescsuggestioncontrol, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? msdyn_keywordsdescsuggestioncontrolFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_keywordsdescsuggestioncontrol@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Keywords and Description Suggestion control, SchemaName: msdyn_keywordsdescsuggestioncontrol, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public bool? msdyn_keywordsdescsuggestioncontrol
	{
		get
		{
			return TryGetValue("msdyn_keywordsdescsuggestioncontrol", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_keywordsdescsuggestioncontrol") is false || Remove("msdyn_keywordsdescsuggestioncontrol"))
			{
				Add("msdyn_keywordsdescsuggestioncontrol", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_keywordsdescsuggestioncontrol, SchemaName: msdyn_keywordsdescsuggestioncontrolName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_keywordsdescsuggestioncontrolName
	{
		get
		{
			return TryGetValue("msdyn_keywordsdescsuggestioncontrolname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Language Code, Format: Text, MaxLength: 100, SchemaName: msdyn_languagecode, IntroducedVersion: 1.0.0.0.  Description: The Language Code that the article's content is in.</summary>
	[JsonIgnore]
	public string? msdyn_languagecode
	{
		get
		{
			return TryGetValue("msdyn_languagecode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_languagecode") is false || Remove("msdyn_languagecode"))
			{
				Add("msdyn_languagecode", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: File storage migration retry count, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_retrycountformigrationtocontentstore, IntroducedVersion: 1.0.  Description: Displays the number of times migration to file storage retry is attempted for an article</summary>
	[JsonIgnore]
	public int? msdyn_retrycountformigrationtocontentstore
	{
		get
		{
			return TryGetValue("msdyn_retrycountformigrationtocontentstore", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_retrycountformigrationtocontentstore") is false || Remove("msdyn_retrycountformigrationtocontentstore"))
			{
				Add("msdyn_retrycountformigrationtocontentstore", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 8.0.0.0.  Description: Date and time that the record was migrated.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user or team who owns the record.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 8.0.0.0.  Description: Unique identifier of the user or team who owns the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 8.0.0.0.  Description: Name of the owner</summary>
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

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 8.0.0.0.  Description: Owner Id Type</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 8.0.0.0.  Description: Yomi name of the owner</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the team that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 8.0.0.0.  Description: Unique identifier for the user that owns the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Article Content Id, Format: None, SchemaName: ParentArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the parent article content associated with the entity.</summary>
	[JsonIgnore]
	public string? ParentArticleContentIdFormattedValue
	{
		get
		{
			return TryGetValue("_parentarticlecontentid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Article Content Id, Format: None, SchemaName: ParentArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the parent article content associated with the entity.</summary>
	[JsonIgnore]
	public Guid? ParentArticleContentId
	{
		get
		{
			return TryGetValue("_parentarticlecontentid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Article Content Id, Format: None, SchemaName: ParentArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the parent article content associated with the entity.</summary>
	[JsonIgnore]
	public Guid? ParentArticleContentId_knowledgearticle
	{
		set
		{
			if (ContainsKey("parentarticlecontentid_knowledgearticle@odata.bind") is false || Remove("parentarticlecontentid_knowledgearticle@odata.bind"))
			{
				if (value is not null)
				{
					Add("parentarticlecontentid_knowledgearticle@odata.bind", $"({value})");
				}
				else
				{
					Add("_parentarticlecontentid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: parentarticlecontentid, Format: Text, MaxLength: 500, SchemaName: ParentArticleContentIdName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public string? ParentArticleContentIdName
	{
		get
		{
			return TryGetValue("parentarticlecontentidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("parentarticlecontentidname") is false || Remove("parentarticlecontentidname"))
			{
				Add("parentarticlecontentidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Previous Article Content ID, Format: None, SchemaName: PreviousArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Shows the version that the current article was restored from.</summary>
	[JsonIgnore]
	public string? PreviousArticleContentIdFormattedValue
	{
		get
		{
			return TryGetValue("_previousarticlecontentid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Previous Article Content ID, Format: None, SchemaName: PreviousArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Shows the version that the current article was restored from.</summary>
	[JsonIgnore]
	public Guid? PreviousArticleContentId
	{
		get
		{
			return TryGetValue("_previousarticlecontentid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Previous Article Content ID, Format: None, SchemaName: PreviousArticleContentId, IntroducedVersion: 8.0.0.0.  Description: Shows the version that the current article was restored from.</summary>
	[JsonIgnore]
	public Guid? PreviousArticleContentId_knowledgearticle
	{
		set
		{
			if (ContainsKey("previousarticlecontentid_knowledgearticle@odata.bind") is false || Remove("previousarticlecontentid_knowledgearticle@odata.bind"))
			{
				if (value is not null)
				{
					Add("previousarticlecontentid_knowledgearticle@odata.bind", $"({value})");
				}
				else
				{
					Add("_previousarticlecontentid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: previousarticlecontentid, Format: Text, MaxLength: 100, SchemaName: PreviousArticleContentIdName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public string? PreviousArticleContentIdName
	{
		get
		{
			return TryGetValue("previousarticlecontentidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("previousarticlecontentidname") is false || Remove("previousarticlecontentidname"))
			{
				Add("previousarticlecontentidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Author Id, Format: None, SchemaName: primaryauthorid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the primary author associated with the article.</summary>
	[JsonIgnore]
	public string? primaryauthoridFormattedValue
	{
		get
		{
			return TryGetValue("_primaryauthorid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Author Id, Format: None, SchemaName: primaryauthorid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the primary author associated with the article.</summary>
	[JsonIgnore]
	public Guid? primaryauthorid
	{
		get
		{
			return TryGetValue("_primaryauthorid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Primary Author Id, Format: None, SchemaName: primaryauthorid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the primary author associated with the article.</summary>
	[JsonIgnore]
	public Guid? primaryauthorid_systemuser
	{
		set
		{
			if (ContainsKey("primaryauthorid_systemuser@odata.bind") is false || Remove("primaryauthorid_systemuser@odata.bind"))
			{
				if (value is not null)
				{
					Add("primaryauthorid_systemuser@odata.bind", $"({value})");
				}
				else
				{
					Add("_primaryauthorid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: primaryauthorid, Format: Text, MaxLength: 100, SchemaName: primaryauthoridName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public string? primaryauthoridName
	{
		get
		{
			return TryGetValue("primaryauthoridname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("primaryauthoridname") is false || Remove("primaryauthoridname"))
			{
				Add("primaryauthoridname", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process Id, SchemaName: processid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the process associated with the entity.</summary>
	[JsonIgnore]
	public Guid? processid
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Publish On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: PublishOn, IntroducedVersion: 8.0.0.0.  Description: Date and time when the record was published.</summary>
	[JsonIgnore]
	public DateTime? PublishOn
	{
		get
		{
			return TryGetValue("publishon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("publishon") is false || Remove("publishon"))
			{
				Add("publishon", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Published Status, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: PublishStatusId, IntroducedVersion: 8.0.0.0.  Description: Publish Status of the Article.</summary>
	[JsonIgnore]
	public int? PublishStatusId
	{
		get
		{
			return TryGetValue("publishstatusid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("publishstatusid") is false || Remove("publishstatusid"))
			{
				Add("publishstatusid", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Rating, Precision: 2, MinValue: -100000000000, MaxValue: 100000000000, SchemaName: Rating, IntroducedVersion: 8.1.0.0.  Description: Information which specifies how helpful the related record was.</summary>
	[JsonIgnore]
	public decimal? Rating
	{
		get
		{
			return TryGetValue("rating", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("rating") is false || Remove("rating"))
			{
				Add("rating", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Rating(Count), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: Rating_Count, IntroducedVersion: 8.1.0.0.  Description: Rating Count</summary>
	[JsonIgnore]
	public int? Rating_Count
	{
		get
		{
			return TryGetValue("rating_count", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("rating_count") is false || Remove("rating_count"))
			{
				Add("rating_count", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Rating(Last Updated Time), DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: Rating_Date, IntroducedVersion: 8.1.0.0.  Description: The date time for Rating.</summary>
	[JsonIgnore]
	public DateTime? Rating_Date
	{
		get
		{
			return TryGetValue("rating_date", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("rating_date") is false || Remove("rating_date"))
			{
				Add("rating_date", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Rating(State), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: Rating_State, IntroducedVersion: 8.1.0.0.  Description: State of Rating</summary>
	[JsonIgnore]
	public int? Rating_State
	{
		get
		{
			return TryGetValue("rating_state", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("rating_state") is false || Remove("rating_state"))
			{
				Add("rating_state", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Rating(sum), Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: Rating_Sum, IntroducedVersion: 8.1.0.0.  Description: Total sum of Rating</summary>
	[JsonIgnore]
	public decimal? Rating_Sum
	{
		get
		{
			return TryGetValue("rating_sum", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("rating_sum") is false || Remove("rating_sum"))
			{
				Add("rating_sum", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Ready For Review, SchemaName: ReadyForReview, IntroducedVersion: 8.0.0.0.  Description: Ready For Review</summary>
	[JsonIgnore]
	public string? ReadyForReviewFormattedValue
	{
		get
		{
			return TryGetValue("readyforreview@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Ready For Review, SchemaName: ReadyForReview, IntroducedVersion: 8.0.0.0.  Description: Ready For Review</summary>
	[JsonIgnore]
	public bool? ReadyForReview
	{
		get
		{
			return TryGetValue("readyforreview", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("readyforreview") is false || Remove("readyforreview"))
			{
				Add("readyforreview", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Review, SchemaName: Review, IntroducedVersion: 8.0.0.0.  Description: Review</summary>
	[JsonIgnore]
	public string? ReviewFormattedValue
	{
		get
		{
			return TryGetValue("review@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Review, SchemaName: Review, IntroducedVersion: 8.0.0.0.  Description: Review</summary>
	[JsonIgnore]
	public int? Review
	{
		get
		{
			return TryGetValue("review", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("review") is false || Remove("review"))
			{
				Add("review", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Root Article Id, Format: None, SchemaName: RootArticleId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the root article.</summary>
	[JsonIgnore]
	public string? RootArticleIdFormattedValue
	{
		get
		{
			return TryGetValue("_rootarticleid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Root Article Id, Format: None, SchemaName: RootArticleId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the root article.</summary>
	[JsonIgnore]
	public Guid? RootArticleId
	{
		get
		{
			return TryGetValue("_rootarticleid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Root Article Id, Format: None, SchemaName: RootArticleId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the root article.</summary>
	[JsonIgnore]
	public Guid? RootArticleId_knowledgearticle
	{
		set
		{
			if (ContainsKey("rootarticleid_knowledgearticle@odata.bind") is false || Remove("rootarticleid_knowledgearticle@odata.bind"))
			{
				if (value is not null)
				{
					Add("rootarticleid_knowledgearticle@odata.bind", $"({value})");
				}
				else
				{
					Add("_rootarticleid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: rootarticleid, Format: Text, MaxLength: 100, SchemaName: RootArticleIdName, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public string? RootArticleIdName
	{
		get
		{
			return TryGetValue("rootarticleidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("rootarticleidname") is false || Remove("rootarticleidname"))
			{
				Add("rootarticleidname", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Scheduled Status, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ScheduledStatusId, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the scheduled status of the entity.</summary>
	[JsonIgnore]
	public int? ScheduledStatusId
	{
		get
		{
			return TryGetValue("scheduledstatusid", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("scheduledstatusid") is false || Remove("scheduledstatusid"))
			{
				Add("scheduledstatusid", value);
			}
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Set Category Associations, SchemaName: SetCategoryAssociations, IntroducedVersion: 8.1.0.0.  Description: Shows whether category associations have been set</summary>
	[JsonIgnore]
	public string? SetCategoryAssociationsFormattedValue
	{
		get
		{
			return TryGetValue("setcategoryassociations@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Set Category Associations, SchemaName: SetCategoryAssociations, IntroducedVersion: 8.1.0.0.  Description: Shows whether category associations have been set</summary>
	[JsonIgnore]
	public bool? SetCategoryAssociations
	{
		get
		{
			return TryGetValue("setcategoryassociations", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("setcategoryassociations") is false || Remove("setcategoryassociations"))
			{
				Add("setcategoryassociations", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: setcategoryassociations, SchemaName: SetCategoryAssociationsName, IntroducedVersion: 8.1.0.0. </summary>
	[JsonIgnore]
	public object? SetCategoryAssociationsName
	{
		get
		{
			return TryGetValue("setcategoryassociationsname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Set Product Associations, SchemaName: SetProductAssociations, IntroducedVersion: 8.0.0.0.  Description: Set Product Associations</summary>
	[JsonIgnore]
	public string? SetProductAssociationsFormattedValue
	{
		get
		{
			return TryGetValue("setproductassociations@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Set Product Associations, SchemaName: SetProductAssociations, IntroducedVersion: 8.0.0.0.  Description: Set Product Associations</summary>
	[JsonIgnore]
	public bool? SetProductAssociations
	{
		get
		{
			return TryGetValue("setproductassociations", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("setproductassociations") is false || Remove("setproductassociations"))
			{
				Add("setproductassociations", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Stage Id, SchemaName: stageid, IntroducedVersion: 8.0.0.0.  Description: Contains the id of the stage where the entity is located.</summary>
	[JsonIgnore]
	public Guid? stageid
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 8.0.0.0.  Description: Shows whether the article is a draft or is published, archived, or discarded. Draft articles aren't available externally and can be edited. Published articles are available externally, based on applicable permissions, but can't be edited. All metadata changes are reflected in the published version. Archived and discarded articles aren't available externally and can't be edited.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 8.0.0.0.  Description: Shows whether the article is a draft or is published, archived, or discarded. Draft articles aren't available externally and can be edited. Published articles are available externally, based on applicable permissions, but can't be edited. All metadata changes are reflected in the published version. Archived and discarded articles aren't available externally and can't be edited.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 8.0.0.0.  Description: Select the article's status.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 8.0.0.0.  Description: Select the article's status.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 8.0.0.0.  Description: Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 8.0.0.0.  Description: Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Subject, Format: None, SchemaName: SubjectId, IntroducedVersion: 8.0.0.0.  Description: Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, AttributeOf: subjectid, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: SubjectIdDsc, IntroducedVersion: 8.0.0.0. </summary>
	[JsonIgnore]
	public int? SubjectIdDsc
	{
		get
		{
			return TryGetValue("subjectiddsc", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("subjectiddsc") is false || Remove("subjectiddsc"))
			{
				Add("subjectiddsc", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: subjectid, Format: Text, MaxLength: 100, SchemaName: SubjectIdName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 8.0.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, DisplayName: Title, Format: Text, MaxLength: 4000, SchemaName: Title, IntroducedVersion: 8.0.0.0.  Description: Type a title for the article.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 8.0.0.0.  Description: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 8.0.0.0.  Description: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 8.0.0.0.  Description: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 8.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: (Deprecated) Traversed Path, Format: Text, MaxLength: 1250, SchemaName: traversedpath, IntroducedVersion: 8.0.0.0.  Description: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.</summary>
	[JsonIgnore]
	public string? traversedpath
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Update Content, SchemaName: UpdateContent, IntroducedVersion: 8.0.0.0.  Description: Update Content</summary>
	[JsonIgnore]
	public string? UpdateContentFormattedValue
	{
		get
		{
			return TryGetValue("updatecontent@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Update Content, SchemaName: UpdateContent, IntroducedVersion: 8.0.0.0.  Description: Update Content</summary>
	[JsonIgnore]
	public bool? UpdateContent
	{
		get
		{
			return TryGetValue("updatecontent", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("updatecontent") is false || Remove("updatecontent"))
			{
				Add("updatecontent", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 8.0.0.0.  Description: Time zone code that was in use when the record was created.</summary>
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

