namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>This entity is used to store social profile information of its associated account and contacts on different social channels.</summary>
public sealed partial class SocialProfile : Dictionary<string, object>
{
	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Blocked, SchemaName: Blocked, IntroducedVersion: 6.1.0.0.  Description: Identifies if the social profile has been blocked.</summary>
	[JsonIgnore]
	public string? BlockedFormattedValue
	{
		get
		{
			return TryGetValue("blocked@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: Blocked, SchemaName: Blocked, IntroducedVersion: 6.1.0.0.  Description: Identifies if the social profile has been blocked.</summary>
	[JsonIgnore]
	public bool? Blocked
	{
		get
		{
			return TryGetValue("blocked", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("blocked") is false || Remove("blocked"))
			{
				Add("blocked", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: blocked, SchemaName: BlockedName, IntroducedVersion: 6.1.0.0. </summary>
	[JsonIgnore]
	public object? BlockedName
	{
		get
		{
			return TryGetValue("blockedname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Social Channel, SchemaName: Community, IntroducedVersion: 6.1.0.0.  Description: Identifies where the social profile originated from, such as Twitter, or Facebook.</summary>
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

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Social Channel, SchemaName: Community, IntroducedVersion: 6.1.0.0.  Description: Identifies where the social profile originated from, such as Twitter, or Facebook.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 6.1.0.0.  Description: Date and time when the record was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 6.1.0.0.  Description: Shows the customer that this social profile belongs to.</summary>
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

	/// <summary>Type: Customer, RequiredLevel: None, DisplayName: Customer, Format: None, SchemaName: CustomerId, IntroducedVersion: 6.1.0.0.  Description: Shows the customer that this social profile belongs to.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Parent Customer Type, AttributeOf: customerid, Format: Text, MaxLength: 160, SchemaName: CustomerIdName, IntroducedVersion: 6.1.0.0.  Description: Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.</summary>
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

	/// <summary>Type: EntityName, RequiredLevel: None, DisplayName: Parent Customer Type, AttributeOf: customerid, SchemaName: CustomerIdType, IntroducedVersion: 6.1.0.0.  Description: Select the parent account or parent contact for the contact</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Parent Customer Type, AttributeOf: customerid, Format: Text, MaxLength: 450, SchemaName: CustomerIdYomiName, YomiOf: customeridname, IntroducedVersion: 6.1.0.0.  Description: Select the parent account or parent contact for the contact</summary>
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

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Exchange Rate, Precision: 12, MinValue: 1E-12, MaxValue: 100000000000, SchemaName: ExchangeRate, IntroducedVersion: 6.1.0.0.  Description: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the data import or data migration that created this record.</summary>
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

	/// <summary>Type: Double, RequiredLevel: None, DisplayName: Influence Score, Precision: 2, MinValue: 0, MaxValue: 1000000000, SchemaName: InfluenceScore, IntroducedVersion: 6.1.0.0.  Description: Shows the score that determines the online social influence of the social profile.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 6.1.0.0.  Description: Date and time when the record was modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: customeroptout, SchemaName: msdyn_customeroptout, IntroducedVersion: 1.0.0.0.  Description: Flag specifying whether Customer has opted out of getting messages using this SP.</summary>
	[JsonIgnore]
	public string? msdyn_customeroptoutFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_customeroptout@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Boolean, RequiredLevel: None, DisplayName: customeroptout, SchemaName: msdyn_customeroptout, IntroducedVersion: 1.0.0.0.  Description: Flag specifying whether Customer has opted out of getting messages using this SP.</summary>
	[JsonIgnore]
	public bool? msdyn_customeroptout
	{
		get
		{
			return TryGetValue("msdyn_customeroptout", out var value)
				? value is not null ? ((JsonElement)value).GetBoolean()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_customeroptout") is false || Remove("msdyn_customeroptout"))
			{
				Add("msdyn_customeroptout", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_customeroptout, SchemaName: msdyn_customeroptoutName, IntroducedVersion: 1.0.0.0. </summary>
	[JsonIgnore]
	public object? msdyn_customeroptoutName
	{
		get
		{
			return TryGetValue("msdyn_customeroptoutname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Follower Count, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: msdyn_ocfollowercount, IntroducedVersion: 1.0.0.2.  Description: Customer's Followers on the Social channel.</summary>
	[JsonIgnore]
	public int? msdyn_ocfollowercount
	{
		get
		{
			return TryGetValue("msdyn_ocfollowercount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_ocfollowercount") is false || Remove("msdyn_ocfollowercount"))
			{
				Add("msdyn_ocfollowercount", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Followings Count, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: msdyn_ocfollowingcount, IntroducedVersion: 1.0.0.2.  Description: Customer's followings on the Social channel</summary>
	[JsonIgnore]
	public int? msdyn_ocfollowingcount
	{
		get
		{
			return TryGetValue("msdyn_ocfollowingcount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_ocfollowingcount") is false || Remove("msdyn_ocfollowingcount"))
			{
				Add("msdyn_ocfollowingcount", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Friend Count, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: msdyn_ocfriendcount, IntroducedVersion: 1.0.0.2.  Description: Customer's Friend count on the Social Channel</summary>
	[JsonIgnore]
	public int? msdyn_ocfriendcount
	{
		get
		{
			return TryGetValue("msdyn_ocfriendcount", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_ocfriendcount") is false || Remove("msdyn_ocfriendcount"))
			{
				Add("msdyn_ocfriendcount", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Phone number, Format: Text, MaxLength: 100, SchemaName: msdyn_phonenumber, IntroducedVersion: 1.0.0.0.  Description: The phone number of the social profile.</summary>
	[JsonIgnore]
	public string? msdyn_phonenumber
	{
		get
		{
			return TryGetValue("msdyn_phonenumber", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_phonenumber") is false || Remove("msdyn_phonenumber"))
			{
				Add("msdyn_phonenumber", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Profile Image Link, Format: Text, MaxLength: 4000, SchemaName: msdyn_profileimagelink, IntroducedVersion: 1.0.0.2.  Description: Link to the Customer's Social Channel Profile image.</summary>
	[JsonIgnore]
	public string? msdyn_profileimagelink
	{
		get
		{
			return TryGetValue("msdyn_profileimagelink", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_profileimagelink") is false || Remove("msdyn_profileimagelink"))
			{
				Add("msdyn_profileimagelink", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 6.1.0.0.  Description: Date and time that the record was migrated.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 6.1.0.0.  Description: Shows the user or team that is assigned to manage the record. This field is updated every time the record is assigned to a different user.</summary>
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

	/// <summary>Type: Owner, RequiredLevel: SystemRequired, DisplayName: Owner, Format: None, SchemaName: OwnerId, IntroducedVersion: 6.1.0.0.  Description: Shows the user or team that is assigned to manage the record. This field is updated every time the record is assigned to a different user.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdName, IntroducedVersion: 6.1.0.0.  Description: Name of the owner</summary>
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

	/// <summary>Type: EntityName, RequiredLevel: SystemRequired, AttributeOf: ownerid, SchemaName: OwnerIdType, IntroducedVersion: 6.1.0.0.  Description: Owner Id Type</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: ownerid, Format: Text, MaxLength: 100, SchemaName: OwnerIdYomiName, YomiOf: owneridname, IntroducedVersion: 6.1.0.0.  Description: Yomi name of the owner</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Business Unit, Format: None, SchemaName: OwningBusinessUnit, IntroducedVersion: 6.1.0.0.  Description: Unique identifier for the business unit that owns the record</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: owningbusinessunit, Format: Text, MaxLength: 160, SchemaName: OwningBusinessUnitName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning Team, Format: None, SchemaName: OwningTeam, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the team who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Owning User, Format: None, SchemaName: OwningUser, IntroducedVersion: 6.1.0.0.  Description: Unique identifier of the user who owns the contact.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Full Name, Format: Text, MaxLength: 160, SchemaName: ProfileFullName, IntroducedVersion: 6.1.0.0.  Description: Shows the display name of the customer on this social profile.</summary>
	[JsonIgnore]
	public string? ProfileFullName
	{
		get
		{
			return TryGetValue("profilefullname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("profilefullname") is false || Remove("profilefullname"))
			{
				Add("profilefullname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Profile Link, Format: Url, MaxLength: 100, SchemaName: ProfileLink, IntroducedVersion: 6.1.0.0.  Description: Shows the customer that this social profile belongs to.</summary>
	[JsonIgnore]
	public string? ProfileLink
	{
		get
		{
			return TryGetValue("profilelink", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("profilelink") is false || Remove("profilelink"))
			{
				Add("profilelink", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Profile Name, Format: Text, MaxLength: 100, SchemaName: ProfileName, IntroducedVersion: 6.1.0.0.  Description: Shows the name of the social profile on the corresponding social channel.</summary>
	[JsonIgnore]
	public string? ProfileName
	{
		get
		{
			return TryGetValue("profilename", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("profilename") is false || Remove("profilename"))
			{
				Add("profilename", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Social Profile ID, SchemaName: SocialProfileId, IntroducedVersion: 6.1.0.0.  Description: Unique Identifier of the social profile name.</summary>
	[JsonIgnore]
	public Guid? SocialProfileId
	{
		get
		{
			return TryGetValue("socialprofileid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("socialprofileid") is false || Remove("socialprofileid"))
			{
				Add("socialprofileid", value);
			}
		}
	}

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 6.1.0.0.  Description: Status of the Social Profile</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: StateCode, IntroducedVersion: 6.1.0.0.  Description: Status of the Social Profile</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: StateCodeName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 6.1.0.0.  Description: Reason for the status of the Social Profile</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: StatusCode, IntroducedVersion: 6.1.0.0.  Description: Reason for the status of the Social Profile</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: StatusCodeName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 6.1.0.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Currency, Format: None, SchemaName: TransactionCurrencyId, IntroducedVersion: 6.1.0.0.  Description: Choose the local currency for the record to make sure budgets are reported in the correct currency.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: transactioncurrencyid, Format: Text, MaxLength: 100, SchemaName: TransactionCurrencyIdName, IntroducedVersion: 6.1.0.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Unique Profile ID, Format: Text, MaxLength: 100, SchemaName: UniqueProfileID, IntroducedVersion: 6.1.0.0.  Description: Unique ID of the Profile ID</summary>
	[JsonIgnore]
	public string? UniqueProfileID
	{
		get
		{
			return TryGetValue("uniqueprofileid", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("uniqueprofileid") is false || Remove("uniqueprofileid"))
			{
				Add("uniqueprofileid", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 6.1.0.0.  Description: Time zone code that was in use when the record was created.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 6.1.0.0.  Description: Version number of the social profile.</summary>
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

