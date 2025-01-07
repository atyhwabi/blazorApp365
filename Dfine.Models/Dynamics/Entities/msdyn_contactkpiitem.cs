namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public sealed partial class msdyn_contactkpiitem : Dictionary<string, object>
{
	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By, Format: None, SchemaName: CreatedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdby, Format: Text, MaxLength: 100, SchemaName: CreatedByYomiName, YomiOf: createdbyname, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Created On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: CreatedOn, IntroducedVersion: 1.0.  Description: Date and time when the record was created.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Created By (Delegate), Format: None, SchemaName: CreatedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who created the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: createdonbehalfby, Format: Text, MaxLength: 100, SchemaName: CreatedOnBehalfByYomiName, YomiOf: createdonbehalfbyname, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Import Sequence Number, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: ImportSequenceNumber, IntroducedVersion: 1.0.  Description: Sequence number of the import that created this record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By, Format: None, SchemaName: ModifiedBy, IntroducedVersion: 1.0.  Description: Unique identifier of the user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedby, Format: Text, MaxLength: 100, SchemaName: ModifiedByYomiName, YomiOf: modifiedbyname, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Modified On, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: ModifiedOn, IntroducedVersion: 1.0.  Description: Date and time when the record was modified.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Modified By (Delegate), Format: None, SchemaName: ModifiedOnBehalfBy, IntroducedVersion: 1.0.  Description: Unique identifier of the delegate user who modified the record.</summary>
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

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: modifiedonbehalfby, Format: Text, MaxLength: 100, SchemaName: ModifiedOnBehalfByYomiName, YomiOf: modifiedonbehalfbyname, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Last Updated, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: msdyn_acilastupdatetimestamp, IntroducedVersion: 8.2.0.0.  Description: TimeStamp value when the KPI are retrieved from ACI</summary>
	[JsonIgnore]
	public DateTime? msdyn_acilastupdatetimestamp
	{
		get
		{
			return TryGetValue("msdyn_acilastupdatetimestamp", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_acilastupdatetimestamp") is false || Remove("msdyn_acilastupdatetimestamp"))
			{
				Add("msdyn_acilastupdatetimestamp", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Average customer response time, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: msdyn_averagefirstresponsetimebytheminhrs, IntroducedVersion: 1.0.  Description: Average time taken by the customer(in hrs) to respond.</summary>
	[JsonIgnore]
	public decimal? msdyn_averagefirstresponsetimebytheminhrs
	{
		get
		{
			return TryGetValue("msdyn_averagefirstresponsetimebytheminhrs", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_averagefirstresponsetimebytheminhrs") is false || Remove("msdyn_averagefirstresponsetimebytheminhrs"))
			{
				Add("msdyn_averagefirstresponsetimebytheminhrs", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Average seller response time, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: msdyn_averagefirstresponsetimebyusinhrs, IntroducedVersion: 1.0.  Description: Average time taken by the seller(in hrs) to respond.</summary>
	[JsonIgnore]
	public decimal? msdyn_averagefirstresponsetimebyusinhrs
	{
		get
		{
			return TryGetValue("msdyn_averagefirstresponsetimebyusinhrs", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_averagefirstresponsetimebyusinhrs") is false || Remove("msdyn_averagefirstresponsetimebyusinhrs"))
			{
				Add("msdyn_averagefirstresponsetimebyusinhrs", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Computation Accuracy, SchemaName: msdyn_computationaccuracy, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_computationaccuracyFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_computationaccuracy@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Computation Accuracy, SchemaName: msdyn_computationaccuracy, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? msdyn_computationaccuracy
	{
		get
		{
			return TryGetValue("msdyn_computationaccuracy", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_computationaccuracy") is false || Remove("msdyn_computationaccuracy"))
			{
				Add("msdyn_computationaccuracy", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_computationaccuracy, SchemaName: msdyn_computationaccuracyName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_computationaccuracyName
	{
		get
		{
			return TryGetValue("msdyn_computationaccuracyname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact ID, Format: None, SchemaName: msdyn_contactid, IntroducedVersion: 1.0.  Description: Parent Contact ID</summary>
	[JsonIgnore]
	public string? msdyn_contactidFormattedValue
	{
		get
		{
			return TryGetValue("_msdyn_contactid_value@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact ID, Format: None, SchemaName: msdyn_contactid, IntroducedVersion: 1.0.  Description: Parent Contact ID</summary>
	[JsonIgnore]
	public Guid? msdyn_contactid
	{
		get
		{
			return TryGetValue("_msdyn_contactid_value", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Parent Contact ID, Format: None, SchemaName: msdyn_contactid, IntroducedVersion: 1.0.  Description: Parent Contact ID</summary>
	[JsonIgnore]
	public Guid? msdyn_contactid_contact
	{
		set
		{
			if (ContainsKey("msdyn_contactid_contact@odata.bind") is false || Remove("msdyn_contactid_contact@odata.bind"))
			{
				if (value is not null)
				{
					Add("msdyn_contactid_contact@odata.bind", $"({value})");
				}
				else
				{
					Add("_msdyn_contactid_value", null);
				}
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_contactid, Format: Text, MaxLength: 160, SchemaName: msdyn_contactidName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_contactidName
	{
		get
		{
			return TryGetValue("msdyn_contactidname", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_contactidname") is false || Remove("msdyn_contactidname"))
			{
				Add("msdyn_contactidname", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, AttributeOf: msdyn_contactid, Format: Text, MaxLength: 450, SchemaName: msdyn_contactidYomiName, YomiOf: msdyn_contactidname, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public string? msdyn_contactidYomiName
	{
		get
		{
			return TryGetValue("msdyn_contactidyominame", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_contactidyominame") is false || Remove("msdyn_contactidyominame"))
			{
				Add("msdyn_contactidyominame", value);
			}
		}
	}

	/// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired, DisplayName: Unique Identifier for Entity Instances, SchemaName: msdyn_contactkpiitemId, IntroducedVersion: 1.0.  Description: Unique Identifier for Entity Instances</summary>
	[JsonIgnore]
	public Guid? msdyn_contactkpiitemId
	{
		get
		{
			return TryGetValue("msdyn_contactkpiitemid", out var value)
				? value is not null ? ((JsonElement)value).GetGuid()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_contactkpiitemid") is false || Remove("msdyn_contactkpiitemid"))
			{
				Add("msdyn_contactkpiitemid", value);
			}
		}
	}

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Date, DateTimeBehavior: UserLocal, Format: DateAndTime, SchemaName: msdyn_date, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public DateTime? msdyn_date
	{
		get
		{
			return TryGetValue("msdyn_date", out var value)
				? value is not null ? ((JsonElement)value).GetDateTime()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_date") is false || Remove("msdyn_date"))
			{
				Add("msdyn_date", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Opening Attachments Rate, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: msdyn_emailattachmentopens, IntroducedVersion: 1.0.  Description: Shows the rate of opening attachments on followed emails.</summary>
	[JsonIgnore]
	public decimal? msdyn_emailattachmentopens
	{
		get
		{
			return TryGetValue("msdyn_emailattachmentopens", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_emailattachmentopens") is false || Remove("msdyn_emailattachmentopens"))
			{
				Add("msdyn_emailattachmentopens", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Clicked Links Rate, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: msdyn_emaillinksclicked, IntroducedVersion: 1.0.  Description: Shows the rate of links clicked on in followed emails.</summary>
	[JsonIgnore]
	public decimal? msdyn_emaillinksclicked
	{
		get
		{
			return TryGetValue("msdyn_emaillinksclicked", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_emaillinksclicked") is false || Remove("msdyn_emaillinksclicked"))
			{
				Add("msdyn_emaillinksclicked", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Received Emails, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_emailsreceived, IntroducedVersion: 1.0.  Description: Total number of emails received.</summary>
	[JsonIgnore]
	public int? msdyn_emailsreceived
	{
		get
		{
			return TryGetValue("msdyn_emailsreceived", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_emailsreceived") is false || Remove("msdyn_emailsreceived"))
			{
				Add("msdyn_emailsreceived", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Sent Emails, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_emailssent, IntroducedVersion: 1.0.  Description: Number of emails sent by internal contacts to external contacts.</summary>
	[JsonIgnore]
	public int? msdyn_emailssent
	{
		get
		{
			return TryGetValue("msdyn_emailssent", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_emailssent") is false || Remove("msdyn_emailssent"))
			{
				Add("msdyn_emailssent", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Facetime with customer, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_facetimewithcustomer, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? msdyn_facetimewithcustomer
	{
		get
		{
			return TryGetValue("msdyn_facetimewithcustomer", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_facetimewithcustomer") is false || Remove("msdyn_facetimewithcustomer"))
			{
				Add("msdyn_facetimewithcustomer", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: LI Emails Sent, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_liemailssent, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public int? msdyn_liemailssent
	{
		get
		{
			return TryGetValue("msdyn_liemailssent", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_liemailssent") is false || Remove("msdyn_liemailssent"))
			{
				Add("msdyn_liemailssent", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Received Meetings, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_meetingsreceived, IntroducedVersion: 1.0.  Description: Number of meetings sent by the customer.</summary>
	[JsonIgnore]
	public int? msdyn_meetingsreceived
	{
		get
		{
			return TryGetValue("msdyn_meetingsreceived", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_meetingsreceived") is false || Remove("msdyn_meetingsreceived"))
			{
				Add("msdyn_meetingsreceived", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Sent Meetings, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_meetingssent, IntroducedVersion: 1.0.  Description: Number of meetings sent to the customer.</summary>
	[JsonIgnore]
	public int? msdyn_meetingssent
	{
		get
		{
			return TryGetValue("msdyn_meetingssent", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_meetingssent") is false || Remove("msdyn_meetingssent"))
			{
				Add("msdyn_meetingssent", value);
			}
		}
	}

	/// <summary>Type: String, RequiredLevel: None, DisplayName: Custom Entity Name, Format: Text, MaxLength: 100, SchemaName: msdyn_name, IntroducedVersion: 1.0.  Description: Name of the custom entity.</summary>
	[JsonIgnore]
	public string? msdyn_name
	{
		get
		{
			return TryGetValue("msdyn_name", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_name") is false || Remove("msdyn_name"))
			{
				Add("msdyn_name", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Days Active Since Opportunity Creation, Format: None, MinValue: -2147483648, MaxValue: 2147483647, SchemaName: msdyn_numberofopportunities, IntroducedVersion: 1.0.  Description: Number of open opportunities linked to this contact from the primary contact.</summary>
	[JsonIgnore]
	public int? msdyn_numberofopportunities
	{
		get
		{
			return TryGetValue("msdyn_numberofopportunities", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_numberofopportunities") is false || Remove("msdyn_numberofopportunities"))
			{
				Add("msdyn_numberofopportunities", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Opening Emails Rate, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: msdyn_openedemails, IntroducedVersion: 1.0.  Description: Shows the rate of opening followed emails.</summary>
	[JsonIgnore]
	public decimal? msdyn_openedemails
	{
		get
		{
			return TryGetValue("msdyn_openedemails", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_openedemails") is false || Remove("msdyn_openedemails"))
			{
				Add("msdyn_openedemails", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Phone Calls Made, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_phonecallsmade, IntroducedVersion: 1.0.  Description: Shows the number of phone calls made.</summary>
	[JsonIgnore]
	public int? msdyn_phonecallsmade
	{
		get
		{
			return TryGetValue("msdyn_phonecallsmade", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_phonecallsmade") is false || Remove("msdyn_phonecallsmade"))
			{
				Add("msdyn_phonecallsmade", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Phone Calls Received, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_phonecallsreceived, IntroducedVersion: 1.0.  Description: Shows the number of phone calls received.</summary>
	[JsonIgnore]
	public int? msdyn_phonecallsreceived
	{
		get
		{
			return TryGetValue("msdyn_phonecallsreceived", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_phonecallsreceived") is false || Remove("msdyn_phonecallsreceived"))
			{
				Add("msdyn_phonecallsreceived", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Health State, SchemaName: msdyn_relationshiphealthscorestate, IntroducedVersion: 1.0.  Description: KPI health score.</summary>
	[JsonIgnore]
	public string? msdyn_relationshiphealthscorestateFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_relationshiphealthscorestate@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Health State, SchemaName: msdyn_relationshiphealthscorestate, IntroducedVersion: 1.0.  Description: KPI health score.</summary>
	[JsonIgnore]
	public int? msdyn_relationshiphealthscorestate
	{
		get
		{
			return TryGetValue("msdyn_relationshiphealthscorestate", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_relationshiphealthscorestate") is false || Remove("msdyn_relationshiphealthscorestate"))
			{
				Add("msdyn_relationshiphealthscorestate", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_relationshiphealthscorestate, SchemaName: msdyn_relationshiphealthscorestateName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_relationshiphealthscorestateName
	{
		get
		{
			return TryGetValue("msdyn_relationshiphealthscorestatename", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Relationship Health Score, Format: None, MinValue: 0, MaxValue: 100, SchemaName: msdyn_relationshiphealthscorevalue, IntroducedVersion: 1.0.  Description: Health score for the contact.</summary>
	[JsonIgnore]
	public int? msdyn_relationshiphealthscorevalue
	{
		get
		{
			return TryGetValue("msdyn_relationshiphealthscorevalue", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_relationshiphealthscorevalue") is false || Remove("msdyn_relationshiphealthscorevalue"))
			{
				Add("msdyn_relationshiphealthscorevalue", value);
			}
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Health Trend, SchemaName: msdyn_relationshiphealthtrend, IntroducedVersion: 1.0.  Description: Direction the relationship health is moving.</summary>
	[JsonIgnore]
	public string? msdyn_relationshiphealthtrendFormattedValue
	{
		get
		{
			return TryGetValue("msdyn_relationshiphealthtrend@OData.Community.Display.V1.FormattedValue", out var value)
				? value is not null ? ((JsonElement)value).GetString()
				: null : null;
		}
	}

	/// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Health Trend, SchemaName: msdyn_relationshiphealthtrend, IntroducedVersion: 1.0.  Description: Direction the relationship health is moving.</summary>
	[JsonIgnore]
	public int? msdyn_relationshiphealthtrend
	{
		get
		{
			return TryGetValue("msdyn_relationshiphealthtrend", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_relationshiphealthtrend") is false || Remove("msdyn_relationshiphealthtrend"))
			{
				Add("msdyn_relationshiphealthtrend", value);
			}
		}
	}

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: msdyn_relationshiphealthtrend, SchemaName: msdyn_relationshiphealthtrendName, IntroducedVersion: 1.0. </summary>
	[JsonIgnore]
	public object? msdyn_relationshiphealthtrendName
	{
		get
		{
			return TryGetValue("msdyn_relationshiphealthtrendname", out var value)
				? value is not null ? ((JsonElement)value)
				: null : null;
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Rate of response of the customer, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: msdyn_responseratebythem, IntroducedVersion: 1.0.  Description: Rate of response of the customer.</summary>
	[JsonIgnore]
	public decimal? msdyn_responseratebythem
	{
		get
		{
			return TryGetValue("msdyn_responseratebythem", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_responseratebythem") is false || Remove("msdyn_responseratebythem"))
			{
				Add("msdyn_responseratebythem", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Rate of response by the seller, Precision: 2, MinValue: 0, MaxValue: 100000000000, SchemaName: msdyn_responseratebyus, IntroducedVersion: 1.0.  Description: Rate of response by the seller.</summary>
	[JsonIgnore]
	public decimal? msdyn_responseratebyus
	{
		get
		{
			return TryGetValue("msdyn_responseratebyus", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_responseratebyus") is false || Remove("msdyn_responseratebyus"))
			{
				Add("msdyn_responseratebyus", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Engaged with Customer, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_timespentbycustomer, IntroducedVersion: 1.0.  Description: Time spent by external contacts on activities.</summary>
	[JsonIgnore]
	public int? msdyn_timespentbycustomer
	{
		get
		{
			return TryGetValue("msdyn_timespentbycustomer", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_timespentbycustomer") is false || Remove("msdyn_timespentbycustomer"))
			{
				Add("msdyn_timespentbycustomer", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Time Engaged with Customer in Hours, Precision: 2, MinValue: -100000000000, MaxValue: 100000000000, SchemaName: msdyn_timespentbycustomer_calculated, IntroducedVersion: 9.0.0.0.  Description: Time spent by external contacts on activities.</summary>
	[JsonIgnore]
	public decimal? msdyn_timespentbycustomer_calculated
	{
		get
		{
			return TryGetValue("msdyn_timespentbycustomer_calculated", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_timespentbycustomer_calculated") is false || Remove("msdyn_timespentbycustomer_calculated"))
			{
				Add("msdyn_timespentbycustomer_calculated", value);
			}
		}
	}

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Spent by Team, Format: None, MinValue: 0, MaxValue: 2147483647, SchemaName: msdyn_timespentbyteam, IntroducedVersion: 1.0.  Description: Time spent for emails and meetings by internal contacts in relation to the record.</summary>
	[JsonIgnore]
	public int? msdyn_timespentbyteam
	{
		get
		{
			return TryGetValue("msdyn_timespentbyteam", out var value)
				? value is not null ? ((JsonElement)value).GetInt32()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_timespentbyteam") is false || Remove("msdyn_timespentbyteam"))
			{
				Add("msdyn_timespentbyteam", value);
			}
		}
	}

	/// <summary>Type: Decimal, RequiredLevel: None, DisplayName: Time Spent by Team in Hours, Precision: 1, MinValue: -100000000000, MaxValue: 100000000000, SchemaName: msdyn_timespentbyteam_calculated, IntroducedVersion: 9.0.0.0.  Description: Time spent for emails and meetings by internal contacts in relation to the record.</summary>
	[JsonIgnore]
	public decimal? msdyn_timespentbyteam_calculated
	{
		get
		{
			return TryGetValue("msdyn_timespentbyteam_calculated", out var value)
				? value is not null ? ((JsonElement)value).GetDecimal()
				: null : null;
		}
		set
		{
			if (ContainsKey("msdyn_timespentbyteam_calculated") is false || Remove("msdyn_timespentbyteam_calculated"))
			{
				Add("msdyn_timespentbyteam_calculated", value);
			}
		}
	}

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 1.0.  Description: Unique identifier for the organization.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 1.0.  Description: Unique identifier for the organization.</summary>
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

	/// <summary>Type: Lookup, RequiredLevel: None, DisplayName: Organization Id, Format: None, SchemaName: OrganizationId, IntroducedVersion: 1.0.  Description: Unique identifier for the organization.</summary>
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

	/// <summary>Type: String, RequiredLevel: SystemRequired, AttributeOf: organizationid, Format: Text, MaxLength: 100, SchemaName: OrganizationIdName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: DateTime, RequiredLevel: None, DisplayName: Record Created On, DateTimeBehavior: UserLocal, Format: DateOnly, SchemaName: OverriddenCreatedOn, IntroducedVersion: 1.0.  Description: Date and time when the record was migrated.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: statecode, IntroducedVersion: 1.0.  Description: Status of the Contact KPI.</summary>
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

	/// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, SchemaName: statecode, IntroducedVersion: 1.0.  Description: Status of the Contact KPI.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statecode, SchemaName: statecodeName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: statuscode, IntroducedVersion: 1.0.  Description: Reason for the status of the Contact KPI.</summary>
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

	/// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, SchemaName: statuscode, IntroducedVersion: 1.0.  Description: Reason for the status of the Contact KPI.</summary>
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

	/// <summary>Type: Virtual, RequiredLevel: None, AttributeOf: statuscode, SchemaName: statuscodeName, IntroducedVersion: 1.0. </summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: Time Zone Rule Version Number, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: TimeZoneRuleVersionNumber, IntroducedVersion: 1.0.  Description: For internal use only.</summary>
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

	/// <summary>Type: Integer, RequiredLevel: None, DisplayName: UTC Conversion Time Zone Code, Format: None, MinValue: -1, MaxValue: 2147483647, SchemaName: UTCConversionTimeZoneCode, IntroducedVersion: 1.0.  Description: Time zone code that was in use when the record was created.</summary>
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

	/// <summary>Type: BigInt, RequiredLevel: None, DisplayName: Version Number, MinValue: -9,223372036854776E+18, MaxValue: 9,223372036854776E+18, SchemaName: VersionNumber, IntroducedVersion: 1.0.  Description: Version Number</summary>
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

