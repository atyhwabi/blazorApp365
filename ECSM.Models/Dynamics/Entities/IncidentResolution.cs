namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Special type of activity that includes description of the resolution, billing status, and the duration of the case.</summary>
public sealed partial class IncidentResolution : Dictionary<string, object>
{
	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Activity Additional Parameters, Format: TextArea, MaxLength: 8192, SchemaName: ActivityAdditionalParams, IntroducedVersion: 7.1.0.0.  Description: Additional information provided by the external application as JSON. For internal use only.</summary>
	[JsonIgnore]
	public string? ActivityAdditionalParams
	{
		get
		{
			return TryGetValue("activityadditionalparams", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("activityadditionalparams") is false || Remove("activityadditionalparams"))
			{
				Add("activityadditionalparams", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Case Resolution, SchemaName: ActivityId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case resolution activity.</summary>
	[JsonIgnore]
	public Guid? ActivityId
	{
		get
		{
			return TryGetValue("activityid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("activityid") is false || Remove("activityid"))
			{
				Add("activityid", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, DisplayName: Activity Type, SchemaName: ActivityTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of activity.</summary>
	[JsonIgnore]
	public string? ActivityTypeCode
	{
		get
		{
			return TryGetValue("activitytypecode", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("activitytypecode") is false || Remove("activitytypecode"))
			{
				Add("activitytypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: activitytypecode, SchemaName: ActivityTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? ActivityTypeCodeName
	{
		get
		{
			return TryGetValue("activitytypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Actual Duration, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: ActualDurationMinutes, IntroducedVersion: 5.0.0.0.  Description: Actual duration of the case resolution activity in minutes.</summary>
	[JsonIgnore]
	public int? ActualDurationMinutes
	{
		get
		{
			return TryGetValue("actualdurationminutes", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("actualdurationminutes") is false || Remove("actualdurationminutes"))
			{
				Add("actualdurationminutes", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Actual End, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ActualEnd, IntroducedVersion: 5.0.0.0.  Description: Actual end time of the case resolution activity.</summary>
	[JsonIgnore]
	public DateTime? ActualEnd
	{
		get
		{
			return TryGetValue("actualend", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("actualend") is false || Remove("actualend"))
			{
				Add("actualend", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Actual Start, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ActualStart, IntroducedVersion: 5.0.0.0.  Description: Actual start time of the case resolution activity.</summary>
	[JsonIgnore]
	public DateTime? ActualStart
	{
		get
		{
			return TryGetValue("actualstart", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("actualstart") is false || Remove("actualstart"))
			{
				Add("actualstart", value);
			}
		}
	}

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: BCC, Format: None, SchemaName: BCC, IntroducedVersion: 5.0.0.0.  Description: Blind Carbon-copy (bcc) recipients of the activity.</summary>
	[JsonIgnore]
	public object? BCC
	{
		get
		{
			return TryGetValue("bcc", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("bcc") is false || Remove("bcc"))
			{
				Add("bcc", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Category, Format: Text, MaxLength: 250, SchemaName: Category, IntroducedVersion: 5.0.0.0.  Description: Category for the case resolution activity.</summary>
	[JsonIgnore]
	public string? Category
	{
		get
		{
			return TryGetValue("category", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("category") is false || Remove("category"))
			{
				Add("category", value);
			}
		}
	}

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: CC, Format: None, SchemaName: CC, IntroducedVersion: 5.0.0.0.  Description: Carbon-copy (cc) recipients of the activity.</summary>
	[JsonIgnore]
	public object? CC
	{
		get
		{
			return TryGetValue("cc", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("cc") is false || Remove("cc"))
			{
				Add("cc", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Social Channel, SchemaName: Community, IntroducedVersion: 6.1.0.0.  Description: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.</summary>
	[JsonIgnore]
	public string? CommunityFormattedValue
	{
		get
		{
			return TryGetValue("community@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Social Channel, SchemaName: Community, IntroducedVersion: 6.1.0.0.  Description: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.</summary>
	[JsonIgnore]
	public int? Community
	{
		get
		{
			return TryGetValue("community", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("community") is false || Remove("community"))
			{
				Add("community", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: community, SchemaName: CommunityName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? CommunityName
	{
		get
		{
			return TryGetValue("communityname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the case resolution activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the case resolution activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who created the case resolution activity.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdbyexternalparty, Format: Text, MaxLength: 100, SchemaName: CreatedByExternalPartyYomiName, YomiOf: createdbyexternalpartyname, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the case resolution activity was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the incidentresolution.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the incidentresolution.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who created the incidentresolution.</summary>
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

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Customers, Format: None, SchemaName: Customers, IntroducedVersion: 5.0.0.0.  Description: Customer with which the activity is associated.</summary>
	[JsonIgnore]
	public object? Customers
	{
		get
		{
			return TryGetValue("customers", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("customers") is false || Remove("customers"))
			{
				Add("customers", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Date Delivery Last Attempted, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: DeliveryLastAttemptedOn, IntroducedVersion: 6.0.0.0.  Description: Date and time when the delivery of the activity was last attempted.</summary>
	[JsonIgnore]
	public DateTime? DeliveryLastAttemptedOn
	{
		get
		{
			return TryGetValue("deliverylastattemptedon", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("deliverylastattemptedon") is false || Remove("deliverylastattemptedon"))
			{
				Add("deliverylastattemptedon", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Delivery Priority, SchemaName: DeliveryPriorityCode, IntroducedVersion: 6.0.0.0.  Description: Priority of delivery of the activity to the email server.</summary>
	[JsonIgnore]
	public string? DeliveryPriorityCodeFormattedValue
	{
		get
		{
			return TryGetValue("deliveryprioritycode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Delivery Priority, SchemaName: DeliveryPriorityCode, IntroducedVersion: 6.0.0.0.  Description: Priority of delivery of the activity to the email server.</summary>
	[JsonIgnore]
	public int? DeliveryPriorityCode
	{
		get
		{
			return TryGetValue("deliveryprioritycode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("deliveryprioritycode") is false || Remove("deliveryprioritycode"))
			{
				Add("deliveryprioritycode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: deliveryprioritycode, SchemaName: DeliveryPriorityCodeName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public object? DeliveryPriorityCodeName
	{
		get
		{
			return TryGetValue("deliveryprioritycodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Memo, RequiredLevel: None, DisplayName: Remarks, Format: Text, MaxLength: 100000, SchemaName: Description, IntroducedVersion: 5.0.0.0.  Description: Type additional information that describes the case resolution.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Exchange Item ID, Format: Text, MaxLength: 200, SchemaName: ExchangeItemId, IntroducedVersion: 8.2.0.0.  Description: The message id of activity which is returned from Exchange Server.</summary>
	[JsonIgnore]
	public string? ExchangeItemId
	{
		get
		{
			return TryGetValue("exchangeitemid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("exchangeitemid") is false || Remove("exchangeitemid"))
			{
				Add("exchangeitemid", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 5.0.0.0.  Description: Exchange rate for the currency associated with the activitypointer with respect to the base currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Exchange WebLink, Format: Text, MaxLength: 1250, SchemaName: ExchangeWebLink, IntroducedVersion: 8.2.0.0.  Description: Shows the web link of Activity of type email.</summary>
	[JsonIgnore]
	public string? ExchangeWebLink
	{
		get
		{
			return TryGetValue("exchangeweblink", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("exchangeweblink") is false || Remove("exchangeweblink"))
			{
				Add("exchangeweblink", value);
			}
		}
	}

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: From, Format: None, SchemaName: From, IntroducedVersion: 5.0.0.0.  Description: Person who the activity is from.</summary>
	[JsonIgnore]
	public object? From
	{
		get
		{
			return TryGetValue("from", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("from") is false || Remove("from"))
			{
				Add("from", value);
			}
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: IncidentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case.</summary>
	[JsonIgnore]
	public string? IncidentIdFormattedValue
	{
		get
		{
			return TryGetValue("_incidentid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: IncidentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case.</summary>
	[JsonIgnore]
	public Guid? IncidentId
	{
		get
		{
			return TryGetValue("_incidentid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Case, Format: None, SchemaName: IncidentId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the case.</summary>
	[JsonIgnore]
	public Guid? IncidentId_incident
	{
		set
		{
			if (ContainsKey("incidentid_incident@odata.bind") is false || Remove("incidentid_incident@odata.bind"))
			{
				if (value is not null)
				{
					Add("incidentid_incident@odata.bind", $"({value})");
				}
				else
				{
					Add("_incidentid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: incidentid, Format: Text, MaxLength: 100, SchemaName: IncidentIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? IncidentIdName
	{
		get
		{
			return TryGetValue("incidentidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("incidentidname") is false || Remove("incidentidname"))
			{
				Add("incidentidname", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: None, AttributeOf: incidentid, SchemaName: IncidentIdType, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? IncidentIdType
	{
		get
		{
			return TryGetValue("incidentidtype", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("incidentidtype") is false || Remove("incidentidtype"))
			{
				Add("incidentidtype", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Recurring Instance Type, SchemaName: InstanceTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of instance of a recurring series.</summary>
	[JsonIgnore]
	public string? InstanceTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("instancetypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Recurring Instance Type, SchemaName: InstanceTypeCode, IntroducedVersion: 5.0.0.0.  Description: Type of instance of a recurring series.</summary>
	[JsonIgnore]
	public int? InstanceTypeCode
	{
		get
		{
			return TryGetValue("instancetypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("instancetypecode") is false || Remove("instancetypecode"))
			{
				Add("instancetypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: instancetypecode, SchemaName: InstanceTypeCodeName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? InstanceTypeCodeName
	{
		get
		{
			return TryGetValue("instancetypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Billed, SchemaName: IsBilled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the case resolution activity was billed as part of resolving a case.</summary>
	[JsonIgnore]
	public string? IsBilledFormattedValue
	{
		get
		{
			return TryGetValue("isbilled@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Billed, SchemaName: IsBilled, IntroducedVersion: 5.0.0.0.  Description: Information about whether the case resolution activity was billed as part of resolving a case.</summary>
	[JsonIgnore]
	public bool? IsBilled
	{
		get
		{
			return TryGetValue("isbilled", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isbilled") is false || Remove("isbilled"))
			{
				Add("isbilled", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isbilled, SchemaName: IsBilledName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsBilledName
	{
		get
		{
			return TryGetValue("isbilledname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Private, SchemaName: IsMapiPrivate, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public string? IsMapiPrivateFormattedValue
	{
		get
		{
			return TryGetValue("ismapiprivate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Private, SchemaName: IsMapiPrivate, IntroducedVersion: 5.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public bool? IsMapiPrivate
	{
		get
		{
			return TryGetValue("ismapiprivate", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("ismapiprivate") is false || Remove("ismapiprivate"))
			{
				Add("ismapiprivate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: ismapiprivate, SchemaName: IsMapiPrivateName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsMapiPrivateName
	{
		get
		{
			return TryGetValue("ismapiprivatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Regular Activity, SchemaName: IsRegularActivity, IntroducedVersion: 5.0.0.0.  Description: Information regarding whether the activity is a regular activity type or event type.</summary>
	[JsonIgnore]
	public string? IsRegularActivityFormattedValue
	{
		get
		{
			return TryGetValue("isregularactivity@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: SystemRequired, DisplayName: Is Regular Activity, SchemaName: IsRegularActivity, IntroducedVersion: 5.0.0.0.  Description: Information regarding whether the activity is a regular activity type or event type.</summary>
	[JsonIgnore]
	public bool? IsRegularActivity
	{
		get
		{
			return TryGetValue("isregularactivity", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isregularactivity") is false || Remove("isregularactivity"))
			{
				Add("isregularactivity", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isregularactivity, SchemaName: IsRegularActivityName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsRegularActivityName
	{
		get
		{
			return TryGetValue("isregularactivityname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Workflow Created, SchemaName: IsWorkflowCreated, IntroducedVersion: 5.0.0.0.  Description: Information that specifies if the case resolution activity was created from a workflow rule.</summary>
	[JsonIgnore]
	public string? IsWorkflowCreatedFormattedValue
	{
		get
		{
			return TryGetValue("isworkflowcreated@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Is Workflow Created, SchemaName: IsWorkflowCreated, IntroducedVersion: 5.0.0.0.  Description: Information that specifies if the case resolution activity was created from a workflow rule.</summary>
	[JsonIgnore]
	public bool? IsWorkflowCreated
	{
		get
		{
			return TryGetValue("isworkflowcreated", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("isworkflowcreated") is false || Remove("isworkflowcreated"))
			{
				Add("isworkflowcreated", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: isworkflowcreated, SchemaName: IsWorkflowCreatedName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? IsWorkflowCreatedName
	{
		get
		{
			return TryGetValue("isworkflowcreatedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last On Hold Time, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: LastOnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Contains the date and time stamp of the last on hold time.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Left Voice Mail, SchemaName: LeftVoiceMail, IntroducedVersion: 5.0.0.0.  Description: Left the voice mail</summary>
	[JsonIgnore]
	public string? LeftVoiceMailFormattedValue
	{
		get
		{
			return TryGetValue("leftvoicemail@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Left Voice Mail, SchemaName: LeftVoiceMail, IntroducedVersion: 5.0.0.0.  Description: Left the voice mail</summary>
	[JsonIgnore]
	public bool? LeftVoiceMail
	{
		get
		{
			return TryGetValue("leftvoicemail", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("leftvoicemail") is false || Remove("leftvoicemail"))
			{
				Add("leftvoicemail", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: leftvoicemail, SchemaName: LeftVoiceMailName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public object? LeftVoiceMailName
	{
		get
		{
			return TryGetValue("leftvoicemailname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the case resolution activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the case resolution activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user who last modified the case resolution activity.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedbyexternalparty, Format: Text, MaxLength: 100, SchemaName: ModifiedByExternalPartyYomiName, YomiOf: modifiedbyexternalpartyname, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 5.0.0.0.  Description: Date and time when the case resolution activity was last modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the incidentresolution.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the incidentresolution.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the delegate user who last modified the incidentresolution.</summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Propose new knowledge using this case, SchemaName: msdyn_proposeknowledge, IntroducedVersion: 1.0.0.1.  Description: Use this setting to generate knowledge article from the case using copilot if you did not find a relevant article.</summary>
	[JsonIgnore]
	public string? msdyn_proposeknowledgeFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_proposeknowledge@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Propose new knowledge using this case, SchemaName: msdyn_proposeknowledge, IntroducedVersion: 1.0.0.1.  Description: Use this setting to generate knowledge article from the case using copilot if you did not find a relevant article.</summary>
	[JsonIgnore]
	public bool? msdyn_proposeknowledge
	{
		get
		{
			return TryGetValue("msdyn_proposeknowledge", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_proposeknowledge") is false || Remove("msdyn_proposeknowledge"))
			{
				Add("msdyn_proposeknowledge", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_proposeknowledge, SchemaName: msdyn_proposeknowledgeName, IntroducedVersion: 1.0.0.1. </summary>
	[JsonIgnore]
	public object? msdyn_proposeknowledgeName
	{
		get
		{
			return TryGetValue("msdyn_proposeknowledgename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: On Hold Time (Minutes), Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: OnHoldTime, IntroducedVersion: 8.1.0.0.  Description: Shows how long, in minutes, that the record was on hold.</summary>
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

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Optional Attendees, Format: None, SchemaName: OptionalAttendees, IntroducedVersion: 5.0.0.0.  Description: List of optional attendees for the activity.</summary>
	[JsonIgnore]
	public object? OptionalAttendees
	{
		get
		{
			return TryGetValue("optionalattendees", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("optionalattendees") is false || Remove("optionalattendees"))
			{
				Add("optionalattendees", value);
			}
		}
	}

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Organizer, Format: None, SchemaName: Organizer, IntroducedVersion: 5.0.0.0.  Description: Person who organized the activity.</summary>
	[JsonIgnore]
	public object? Organizer
	{
		get
		{
			return TryGetValue("organizer", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("organizer") is false || Remove("organizer"))
			{
				Add("organizer", value);
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user or team who owns the activity.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user or team who owns the activity.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the business unit that owns the activity.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team that owns the activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team that owns the activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the team that owns the activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user that owns the activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user that owns the activity.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the user that owns the activity.</summary>
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

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Outsource Vendors, Format: None, SchemaName: Partners, IntroducedVersion: 5.0.0.0.  Description: Outsource vendor with which activity is associated.</summary>
	[JsonIgnore]
	public object? Partners
	{
		get
		{
			return TryGetValue("partners", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("partners") is false || Remove("partners"))
			{
				Add("partners", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Delay activity processing until, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: PostponeActivityProcessingUntil, IntroducedVersion: 6.0.0.0.  Description: For internal use only.</summary>
	[JsonIgnore]
	public DateTime? PostponeActivityProcessingUntil
	{
		get
		{
			return TryGetValue("postponeactivityprocessinguntil", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("postponeactivityprocessinguntil") is false || Remove("postponeactivityprocessinguntil"))
			{
				Add("postponeactivityprocessinguntil", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, SchemaName: PriorityCode, IntroducedVersion: 5.0.0.0.  Description: Priority of the activity.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, SchemaName: PriorityCode, IntroducedVersion: 5.0.0.0.  Description: Priority of the activity.</summary>
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

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Process, SchemaName: ProcessId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the Process.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_account
	{
		set
		{
			if (ContainsKey("regardingobjectid_account@odata.bind") is false || Remove("regardingobjectid_account@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_account@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_adx_invitation
	{
		set
		{
			if (ContainsKey("regardingobjectid_adx_invitation@odata.bind") is false || Remove("regardingobjectid_adx_invitation@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_adx_invitation@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_bookableresourcebooking
	{
		set
		{
			if (ContainsKey("regardingobjectid_bookableresourcebooking@odata.bind") is false || Remove("regardingobjectid_bookableresourcebooking@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_bookableresourcebooking@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_bookableresourcebookingheader
	{
		set
		{
			if (ContainsKey("regardingobjectid_bookableresourcebookingheader@odata.bind") is false || Remove("regardingobjectid_bookableresourcebookingheader@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_bookableresourcebookingheader@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_bulkoperation
	{
		set
		{
			if (ContainsKey("regardingobjectid_bulkoperation@odata.bind") is false || Remove("regardingobjectid_bulkoperation@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_bulkoperation@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_campaign
	{
		set
		{
			if (ContainsKey("regardingobjectid_campaign@odata.bind") is false || Remove("regardingobjectid_campaign@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_campaign@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_campaignactivity
	{
		set
		{
			if (ContainsKey("regardingobjectid_campaignactivity@odata.bind") is false || Remove("regardingobjectid_campaignactivity@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_campaignactivity@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_entitlement
	{
		set
		{
			if (ContainsKey("regardingobjectid_entitlement@odata.bind") is false || Remove("regardingobjectid_entitlement@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_entitlement@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_entitlementtemplate
	{
		set
		{
			if (ContainsKey("regardingobjectid_entitlementtemplate@odata.bind") is false || Remove("regardingobjectid_entitlementtemplate@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_entitlementtemplate@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_interactionforemail
	{
		set
		{
			if (ContainsKey("regardingobjectid_interactionforemail@odata.bind") is false || Remove("regardingobjectid_interactionforemail@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_interactionforemail@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_knowledgebaserecord
	{
		set
		{
			if (ContainsKey("regardingobjectid_knowledgebaserecord@odata.bind") is false || Remove("regardingobjectid_knowledgebaserecord@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_knowledgebaserecord@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_lead
	{
		set
		{
			if (ContainsKey("regardingobjectid_lead@odata.bind") is false || Remove("regardingobjectid_lead@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_lead@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_mspp_adplacement
	{
		set
		{
			if (ContainsKey("regardingobjectid_mspp_adplacement@odata.bind") is false || Remove("regardingobjectid_mspp_adplacement@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_mspp_adplacement@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_mspp_pollplacement
	{
		set
		{
			if (ContainsKey("regardingobjectid_mspp_pollplacement@odata.bind") is false || Remove("regardingobjectid_mspp_pollplacement@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_mspp_pollplacement@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_mspp_publishingstatetransitionrule
	{
		set
		{
			if (ContainsKey("regardingobjectid_mspp_publishingstatetransitionrule@odata.bind") is false || Remove("regardingobjectid_mspp_publishingstatetransitionrule@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_mspp_publishingstatetransitionrule@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_mspp_redirect
	{
		set
		{
			if (ContainsKey("regardingobjectid_mspp_redirect@odata.bind") is false || Remove("regardingobjectid_mspp_redirect@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_mspp_redirect@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_mspp_shortcut
	{
		set
		{
			if (ContainsKey("regardingobjectid_mspp_shortcut@odata.bind") is false || Remove("regardingobjectid_mspp_shortcut@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_mspp_shortcut@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Regarding, Format: Regarding, SchemaName: RegardingObjectId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the object with which the activity is associated.</summary>
	[JsonIgnore]
	public Guid? RegardingObjectId_mspp_website
	{
		set
		{
			if (ContainsKey("regardingobjectid_mspp_website@odata.bind") is false || Remove("regardingobjectid_mspp_website@odata.bind"))
			{
				if (value is not null)
				{
					Add("regardingobjectid_mspp_website@odata.bind", $"({value})");
				}
				else
				{
					Add("_regardingobjectid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: regardingobjectid, Format: Text, MaxLength: 400, SchemaName: RegardingObjectIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? RegardingObjectIdName
	{
		get
		{
			return TryGetValue("regardingobjectidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingobjectidname") is false || Remove("regardingobjectidname"))
			{
				Add("regardingobjectidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: regardingobjectid, Format: Text, MaxLength: 400, SchemaName: RegardingObjectIdYomiName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? RegardingObjectIdYomiName
	{
		get
		{
			return TryGetValue("regardingobjectidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("regardingobjectidyominame") is false || Remove("regardingobjectidyominame"))
			{
				Add("regardingobjectidyominame", value);
			}
		}
	}

	/// <summary>Type: EntityName, RequiredLevel: None, AttributeOf: regardingobjectid, SchemaName: RegardingObjectTypeCode, IntroducedVersion: 5.0.0.0. </summary>
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

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Required Attendees, Format: None, SchemaName: RequiredAttendees, IntroducedVersion: 5.0.0.0.  Description: List of required attendees for the activity.</summary>
	[JsonIgnore]
	public object? RequiredAttendees
	{
		get
		{
			return TryGetValue("requiredattendees", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("requiredattendees") is false || Remove("requiredattendees"))
			{
				Add("requiredattendees", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Resolution Type, SchemaName: ResolutionTypeCode, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public string? ResolutionTypeCodeFormattedValue
	{
		get
		{
			return TryGetValue("resolutiontypecode@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Resolution Type, SchemaName: ResolutionTypeCode, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public int? ResolutionTypeCode
	{
		get
		{
			return TryGetValue("resolutiontypecode", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("resolutiontypecode") is false || Remove("resolutiontypecode"))
			{
				Add("resolutiontypecode", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: resolutiontypecode, SchemaName: resolutiontypecodeName, IntroducedVersion: 9.1.0.0. </summary>
	[JsonIgnore]
	public object? resolutiontypecodeName
	{
		get
		{
			return TryGetValue("resolutiontypecodename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: Resources, Format: None, SchemaName: Resources, IntroducedVersion: 5.0.0.0.  Description: Users or facility/equipment that are required for the activity.</summary>
	[JsonIgnore]
	public object? Resources
	{
		get
		{
			return TryGetValue("resources", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("resources") is false || Remove("resources"))
			{
				Add("resources", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Scheduled Duration, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: ScheduledDurationMinutes, IntroducedVersion: 5.0.0.0.  Description: Scheduled duration of the case resolution activity, specified in minutes.</summary>
	[JsonIgnore]
	public int? ScheduledDurationMinutes
	{
		get
		{
			return TryGetValue("scheduleddurationminutes", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("scheduleddurationminutes") is false || Remove("scheduleddurationminutes"))
			{
				Add("scheduleddurationminutes", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Scheduled End, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ScheduledEnd, IntroducedVersion: 5.0.0.0.  Description: Scheduled end time of the case resolution activity.</summary>
	[JsonIgnore]
	public DateTime? ScheduledEnd
	{
		get
		{
			return TryGetValue("scheduledend", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("scheduledend") is false || Remove("scheduledend"))
			{
				Add("scheduledend", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Scheduled Start, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: ScheduledStart, IntroducedVersion: 5.0.0.0.  Description: Scheduled start time of the case resolution activity.</summary>
	[JsonIgnore]
	public DateTime? ScheduledStart
	{
		get
		{
			return TryGetValue("scheduledstart", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("scheduledstart") is false || Remove("scheduledstart"))
			{
				Add("scheduledstart", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sender's Mailbox, Format: None, SchemaName: SenderMailboxId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the mailbox associated with the sender of the email message.</summary>
	[JsonIgnore]
	public string? SenderMailboxIdFormattedValue
	{
		get
		{
			return TryGetValue("_sendermailboxid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sender's Mailbox, Format: None, SchemaName: SenderMailboxId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the mailbox associated with the sender of the email message.</summary>
	[JsonIgnore]
	public Guid? SenderMailboxId
	{
		get
		{
			return TryGetValue("_sendermailboxid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Sender's Mailbox, Format: None, SchemaName: SenderMailboxId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the mailbox associated with the sender of the email message.</summary>
	[JsonIgnore]
	public Guid? SenderMailboxId_mailbox
	{
		set
		{
			if (ContainsKey("sendermailboxid_mailbox@odata.bind") is false || Remove("sendermailboxid_mailbox@odata.bind"))
			{
				if (value is not null)
				{
					Add("sendermailboxid_mailbox@odata.bind", $"({value})");
				}
				else
				{
					Add("_sendermailboxid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: sendermailboxid, Format: Text, MaxLength: 100, SchemaName: SenderMailboxIdName, IntroducedVersion: 6.0.0.0. </summary>
	[JsonIgnore]
	public string? SenderMailboxIdName
	{
		get
		{
			return TryGetValue("sendermailboxidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("sendermailboxidname") is false || Remove("sendermailboxidname"))
			{
				Add("sendermailboxidname", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Date Sent, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: SentOn, IntroducedVersion: 6.0.0.0.  Description: Date and time when the activity was sent.</summary>
	[JsonIgnore]
	public DateTime? SentOn
	{
		get
		{
			return TryGetValue("senton", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("senton") is false || Remove("senton"))
			{
				Add("senton", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: Series Id, SchemaName: SeriesId, IntroducedVersion: 5.0.0.0.  Description: Uniqueidentifier specifying the id of recurring series of an instance.</summary>
	[JsonIgnore]
	public Guid? SeriesId
	{
		get
		{
			return TryGetValue("seriesid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("seriesid") is false || Remove("seriesid"))
			{
				Add("seriesid", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ServiceId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the service with which the case resolution activity is associated.</summary>
	[JsonIgnore]
	public string? ServiceIdFormattedValue
	{
		get
		{
			return TryGetValue("_serviceid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ServiceId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the service with which the case resolution activity is associated.</summary>
	[JsonIgnore]
	public Guid? ServiceId
	{
		get
		{
			return TryGetValue("_serviceid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Service, Format: None, SchemaName: ServiceId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the service with which the case resolution activity is associated.</summary>
	[JsonIgnore]
	public Guid? ServiceId_service
	{
		set
		{
			if (ContainsKey("serviceid_service@odata.bind") is false || Remove("serviceid_service@odata.bind"))
			{
				if (value is not null)
				{
					Add("serviceid_service@odata.bind", $"({value})");
				}
				else
				{
					Add("_serviceid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: serviceid, Format: Text, MaxLength: 100, SchemaName: ServiceIdName, IntroducedVersion: 5.0.0.0. </summary>
	[JsonIgnore]
	public string? ServiceIdName
	{
		get
		{
			return TryGetValue("serviceidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("serviceidname") is false || Remove("serviceidname"))
			{
				Add("serviceidname", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: SLA, Format: None, SchemaName: SLAId, IntroducedVersion: 8.1.0.0.  Description: Choose the service level agreement (SLA) that you want to apply to the case record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Last SLA applied, Format: None, SchemaName: SLAInvokedId, IntroducedVersion: 8.1.0.0.  Description: Last SLA that was applied to this case. This field is for internal use only.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slainvokedid, Format: Text, MaxLength: 100, SchemaName: SLAInvokedIdName, IntroducedVersion: 8.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: slaid, Format: Text, MaxLength: 100, SchemaName: SLAName, IntroducedVersion: 8.1.0.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Sort Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: SortDate, IntroducedVersion: 8.2.0.0.  Description: Shows the date and time by which the activities are sorted.</summary>
	[JsonIgnore]
	public DateTime? SortDate
	{
		get
		{
			return TryGetValue("sortdate", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("sortdate") is false || Remove("sortdate"))
			{
				Add("sortdate", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: None, DisplayName: (Deprecated) Process Stage, SchemaName: StageId, IntroducedVersion: 6.0.0.0.  Description: Unique identifier of the Stage.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the case resolution is open, completed, or canceled. By default, all case resolutions are completed and the status value can't be changed.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 5.0.0.0.  Description: Shows whether the case resolution is open, completed, or canceled. By default, all case resolutions are completed and the status value can't be changed.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Reason for the status of the case resolution activity.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 5.0.0.0.  Description: Reason for the status of the case resolution activity.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Sub-Category, Format: Text, MaxLength: 250, SchemaName: Subcategory, IntroducedVersion: 5.0.0.0.  Description: Subcategory of the case resolution activity.</summary>
	[JsonIgnore]
	public string? Subcategory
	{
		get
		{
			return TryGetValue("subcategory", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("subcategory") is false || Remove("subcategory"))
			{
				Add("subcategory", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: ApplicationRequired, DisplayName: Subject, Format: Text, MaxLength: 200, SchemaName: Subject, IntroducedVersion: 5.0.0.0.  Description: Subject associated with the case resolution activity.</summary>
	[JsonIgnore]
	public string? Subject
	{
		get
		{
			return TryGetValue("subject", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("subject") is false || Remove("subject"))
			{
				Add("subject", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Billable Time, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: TimeSpent, IntroducedVersion: 5.0.0.0.  Description: Time spent on the case resolution activity.</summary>
	[JsonIgnore]
	public int? TimeSpent
	{
		get
		{
			return TryGetValue("timespent", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("timespent") is false || Remove("timespent"))
			{
				Add("timespent", value);
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

	/// <summary>Type: PartyList, RequiredLevel: None, DisplayName: To, Format: None, SchemaName: To, IntroducedVersion: 5.0.0.0.  Description: Person who is the receiver of the activity.</summary>
	[JsonIgnore]
	public object? To
	{
		get
		{
			return TryGetValue("to", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
		set
		{
			if (ContainsKey("to") is false || Remove("to"))
			{
				Add("to", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Total Time, Format: Duration, MinValue: 0, MaxValue: 2147483647, SchemaName: TotalTimeSpent, IntroducedVersion: 9.0.0.0.  Description: Total time spent on the case resolution activity.</summary>
	[JsonIgnore]
	public int? TotalTimeSpent
	{
		get
		{
			return TryGetValue("totaltimespent", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("totaltimespent") is false || Remove("totaltimespent"))
			{
				Add("totaltimespent", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the activitypointer.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the activitypointer.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 5.0.0.0.  Description: Unique identifier of the currency associated with the activitypointer.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 5.0.0.0.  Description: Version number of the activity.</summary>
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

