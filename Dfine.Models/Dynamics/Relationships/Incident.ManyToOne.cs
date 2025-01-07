namespace ECSM.Models.Dynamics;

/// <summary>Service request case associated with a contract.</summary>
public static partial class IncidentManyToOne
{
	/// <summary>ReferencedAttribute: businessunitid, ReferencedEntity: businessunit, ReferencedEntityNavigationPropertyName: business_unit_incidents, ReferencingAttribute: owningbusinessunit, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: owningbusinessunit, RelationshipBehavior: 0, SchemaName: business_unit_incidents, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string business_unit_incidents = "owningbusinessunit";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_as_primary_contact, ReferencingAttribute: primarycontactid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: primarycontactid, RelationshipBehavior: 1, SchemaName: contact_as_primary_contact, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string contact_as_primary_contact = "primarycontactid";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: contact_as_responsible_contact, ReferencingAttribute: responsiblecontactid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: responsiblecontactid, RelationshipBehavior: 1, SchemaName: contact_as_responsible_contact, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contact_as_responsible_contact = "responsiblecontactid";

	/// <summary>ReferencedAttribute: contractid, ReferencedEntity: contract, ReferencedEntityNavigationPropertyName: contract_cases, ReferencingAttribute: contractid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: contractid, RelationshipBehavior: 1, SchemaName: contract_cases, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contract_cases = "contractid";

	/// <summary>ReferencedAttribute: contractdetailid, ReferencedEntity: contractdetail, ReferencedEntityNavigationPropertyName: contract_detail_cases, ReferencingAttribute: contractdetailid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: contractdetailid, RelationshipBehavior: 1, SchemaName: contract_detail_cases, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string contract_detail_cases = "contractdetailid";

	/// <summary>ReferencedAttribute: ecsm_catalogue_itemid, ReferencedEntity: ecsm_catalogue_item, ReferencedEntityNavigationPropertyName: ecsm_incident_catalogue_item_ecsm_catalogue_item, ReferencingAttribute: ecsm_catalogue_item, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_catalogue_item, RelationshipBehavior: 1, SchemaName: ecsm_incident_catalogue_item_ecsm_catalogue_item, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_catalogue_item_ecsm_catalogue_item = "ecsm_catalogue_item";

	/// <summary>ReferencedAttribute: ecsm_categoryid, ReferencedEntity: ecsm_category, ReferencedEntityNavigationPropertyName: ecsm_incident_category_ecsm_category_, ReferencingAttribute: ecsm_category, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_category, RelationshipBehavior: 1, SchemaName: ecsm_incident_category_ecsm_category_, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string ecsm_incident_category_ecsm_category_ = "ecsm_category";

	/// <summary>ReferencedAttribute: ecsm_changeid, ReferencedEntity: ecsm_change, ReferencedEntityNavigationPropertyName: ecsm_incident_change_ecsm_change, ReferencingAttribute: ecsm_change, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_change, RelationshipBehavior: 1, SchemaName: ecsm_incident_change_ecsm_change, SecurityTypes: Append, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_incident_change_ecsm_change = "ecsm_change";

	/// <summary>ReferencedAttribute: ecsm_knownissueid, ReferencedEntity: ecsm_knownissue, ReferencedEntityNavigationPropertyName: ecsm_incident_known_issue_ecsm_knownissue, ReferencingAttribute: ecsm_known_issue, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_known_issue, RelationshipBehavior: 1, SchemaName: ecsm_incident_known_issue_ecsm_knownissue, SecurityTypes: Append, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_incident_known_issue_ecsm_knownissue = "ecsm_known_issue";

	/// <summary>ReferencedAttribute: ecsm_configuration_itemid, ReferencedEntity: ecsm_configuration_item, ReferencedEntityNavigationPropertyName: ecsm_incident_problem_affected_ci_ecsm_configuration_item, ReferencingAttribute: ecsm_problem_affected_ci, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_problem_affected_ci, RelationshipBehavior: 1, SchemaName: ecsm_incident_problem_affected_ci_ecsm_configuration_item, SecurityTypes: Append, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_incident_problem_affected_ci_ecsm_configuration_item = "ecsm_problem_affected_ci";

	/// <summary>ReferencedAttribute: ecsm_catalogue_itemid, ReferencedEntity: ecsm_catalogue_item, ReferencedEntityNavigationPropertyName: ecsm_incident_problem_affected_service_ecsm_catalogue_item, ReferencingAttribute: ecsm_problem_affected_service, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_problem_affected_service, RelationshipBehavior: 1, SchemaName: ecsm_incident_problem_affected_service_ecsm_catalogue_item, SecurityTypes: Append, IntroducedVersion: 1.0.0.2. </summary>
	public const string ecsm_incident_problem_affected_service_ecsm_catalogue_item = "ecsm_problem_affected_service";

	/// <summary>ReferencedAttribute: siteid, ReferencedEntity: site, ReferencedEntityNavigationPropertyName: ecsm_incident_site_site, ReferencingAttribute: ecsm_site, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_site, RelationshipBehavior: 1, SchemaName: ecsm_incident_site_site, SecurityTypes: Append, IntroducedVersion: 1.1.0.12. </summary>
	public const string ecsm_incident_site_site = "ecsm_site";

	/// <summary>ReferencedAttribute: productid, ReferencedEntity: product, ReferencedEntityNavigationPropertyName: ecsm_incident_test_product_lookup_product, ReferencingAttribute: ecsm_test_product_lookup, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ecsm_test_product_lookup, RelationshipBehavior: 1, SchemaName: ecsm_incident_test_product_lookup_product, SecurityTypes: Append, IntroducedVersion: 1.1.0.13. </summary>
	public const string ecsm_incident_test_product_lookup_product = "ecsm_test_product_lookup";

	/// <summary>ReferencedAttribute: entitlementid, ReferencedEntity: entitlement, ReferencedEntityNavigationPropertyName: entitlement_cases, ReferencingAttribute: entitlementid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: entitlementid, RelationshipBehavior: 1, SchemaName: entitlement_cases, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string entitlement_cases = "entitlementid";

	/// <summary>ReferencedAttribute: accountid, ReferencedEntity: account, ReferencedEntityNavigationPropertyName: incident_customer_accounts, ReferencingAttribute: customerid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: customerid_account, RelationshipBehavior: 1, SchemaName: incident_customer_accounts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_customer_accounts = "customerid_account";

	/// <summary>ReferencedAttribute: contactid, ReferencedEntity: contact, ReferencedEntityNavigationPropertyName: incident_customer_contacts, ReferencingAttribute: customerid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: customerid_contact, RelationshipBehavior: 1, SchemaName: incident_customer_contacts, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_customer_contacts = "customerid_contact";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_existingcase, ReferencingAttribute: existingcase, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: existingcase, RelationshipBehavior: 1, SchemaName: incident_existingcase, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string incident_existingcase = "existingcase";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_master_incident, ReferencingAttribute: masterid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: masterid, RelationshipBehavior: 1, SchemaName: incident_master_incident, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string incident_master_incident = "masterid";

	/// <summary>ReferencedAttribute: incidentid, ReferencedEntity: incident, ReferencedEntityNavigationPropertyName: incident_parent_incident, ReferencingAttribute: parentcaseid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: parentcaseid, RelationshipBehavior: 1, SchemaName: incident_parent_incident, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string incident_parent_incident = "parentcaseid";

	/// <summary>ReferencedAttribute: kbarticleid, ReferencedEntity: kbarticle, ReferencedEntityNavigationPropertyName: kbarticle_incidents, ReferencingAttribute: kbarticleid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: kbarticleid, RelationshipBehavior: 1, SchemaName: kbarticle_incidents, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string kbarticle_incidents = "kbarticleid";

	/// <summary>ReferencedAttribute: externalpartyid, ReferencedEntity: externalparty, ReferencedEntityNavigationPropertyName: lk_externalparty_incident_createdby, ReferencingAttribute: createdbyexternalparty, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: CreatedByExternalParty, RelationshipBehavior: 0, SchemaName: lk_externalparty_incident_createdby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_externalparty_incident_createdby = "CreatedByExternalParty";

	/// <summary>ReferencedAttribute: externalpartyid, ReferencedEntity: externalparty, ReferencedEntityNavigationPropertyName: lk_externalparty_incident_modifiedby, ReferencingAttribute: modifiedbyexternalparty, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ModifiedByExternalParty, RelationshipBehavior: 0, SchemaName: lk_externalparty_incident_modifiedby, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_externalparty_incident_modifiedby = "ModifiedByExternalParty";

	/// <summary>ReferencedAttribute: parentcaseid, ReferencedEntity: childincidentcount, ReferencedEntityNavigationPropertyName: lk_incident_ChildIncidentCount, ReferencingAttribute: incidentid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: incidentid_childincidentcount, RelationshipBehavior: 1, SchemaName: lk_incident_ChildIncidentCount, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string lk_incident_ChildIncidentCount = "incidentid_childincidentcount";

	/// <summary>ReferencedAttribute: imagedescriptorid, ReferencedEntity: imagedescriptor, ReferencedEntityNavigationPropertyName: lk_incident_entityimage, ReferencingAttribute: entityimageid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: entityimageid_imagedescriptor, RelationshipBehavior: 0, SchemaName: lk_incident_entityimage, SecurityTypes: None, IntroducedVersion: 6.0.0.0. </summary>
	public const string lk_incident_entityimage = "entityimageid_imagedescriptor";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentbase_createdby, ReferencingAttribute: createdby, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: createdby, RelationshipBehavior: 0, SchemaName: lk_incidentbase_createdby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_incidentbase_createdby = "createdby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentbase_createdonbehalfby, ReferencingAttribute: createdonbehalfby, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: createdonbehalfby, RelationshipBehavior: 0, SchemaName: lk_incidentbase_createdonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_incidentbase_createdonbehalfby = "createdonbehalfby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentbase_modifiedby, ReferencingAttribute: modifiedby, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: modifiedby, RelationshipBehavior: 0, SchemaName: lk_incidentbase_modifiedby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_incidentbase_modifiedby = "modifiedby";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: lk_incidentbase_modifiedonbehalfby, ReferencingAttribute: modifiedonbehalfby, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: modifiedonbehalfby, RelationshipBehavior: 0, SchemaName: lk_incidentbase_modifiedonbehalfby, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string lk_incidentbase_modifiedonbehalfby = "modifiedonbehalfby";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: manualsla_cases, ReferencingAttribute: slaid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: slaid_sla, RelationshipBehavior: 1, SchemaName: manualsla_cases, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string manualsla_cases = "slaid_sla";

	/// <summary>ReferencedAttribute: msdyn_iotalertid, ReferencedEntity: msdyn_iotalert, ReferencedEntityNavigationPropertyName: msdyn_msdyn_iotalert_incident_IoTAlert, ReferencingAttribute: msdyn_iotalert, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: msdyn_IoTAlert, RelationshipBehavior: 1, SchemaName: msdyn_msdyn_iotalert_incident_IoTAlert, SecurityTypes: Append, IntroducedVersion: 1.0.0.0. </summary>
	public const string msdyn_msdyn_iotalert_incident_IoTAlert = "msdyn_IoTAlert";

	/// <summary>ReferencedAttribute: ownerid, ReferencedEntity: owner, ReferencedEntityNavigationPropertyName: owner_incidents, ReferencingAttribute: ownerid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: ownerid, RelationshipBehavior: 0, SchemaName: owner_incidents, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string owner_incidents = "ownerid";

	/// <summary>ReferencedAttribute: processstageid, ReferencedEntity: processstage, ReferencedEntityNavigationPropertyName: processstage_incident, ReferencingAttribute: stageid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: stageid_processstage, RelationshipBehavior: 2, SchemaName: processstage_incident, SecurityTypes: ParentChild, IntroducedVersion: 6.0.0.0. </summary>
	public const string processstage_incident = "stageid_processstage";

	/// <summary>ReferencedAttribute: productid, ReferencedEntity: product, ReferencedEntityNavigationPropertyName: product_incidents, ReferencingAttribute: productid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: productid, RelationshipBehavior: 1, SchemaName: product_incidents, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string product_incidents = "productid";

	/// <summary>ReferencedAttribute: slaid, ReferencedEntity: sla, ReferencedEntityNavigationPropertyName: sla_cases, ReferencingAttribute: slainvokedid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: slainvokedid_sla, RelationshipBehavior: 1, SchemaName: sla_cases, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string sla_cases = "slainvokedid_sla";

	/// <summary>ReferencedAttribute: slakpiinstanceid, ReferencedEntity: slakpiinstance, ReferencedEntityNavigationPropertyName: slakpiinstance_incident_firstresponsebykpi, ReferencingAttribute: firstresponsebykpiid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: firstresponsebykpiid, RelationshipBehavior: 1, SchemaName: slakpiinstance_incident_firstresponsebykpi, SecurityTypes: Append, IntroducedVersion: 7.0.0.0. </summary>
	public const string slakpiinstance_incident_firstresponsebykpi = "firstresponsebykpiid";

	/// <summary>ReferencedAttribute: slakpiinstanceid, ReferencedEntity: slakpiinstance, ReferencedEntityNavigationPropertyName: slakpiinstance_incident_resolvebykpi, ReferencingAttribute: resolvebykpiid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: resolvebykpiid, RelationshipBehavior: 1, SchemaName: slakpiinstance_incident_resolvebykpi, SecurityTypes: Append, IntroducedVersion: 7.0.0.0. </summary>
	public const string slakpiinstance_incident_resolvebykpi = "resolvebykpiid";

	/// <summary>ReferencedAttribute: socialprofileid, ReferencedEntity: socialprofile, ReferencedEntityNavigationPropertyName: socialprofile_cases, ReferencingAttribute: socialprofileid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: socialprofileid, RelationshipBehavior: 1, SchemaName: socialprofile_cases, SecurityTypes: Append, IntroducedVersion: 6.1.0.0. </summary>
	public const string socialprofile_cases = "socialprofileid";

	/// <summary>ReferencedAttribute: subjectid, ReferencedEntity: subject, ReferencedEntityNavigationPropertyName: subject_incidents, ReferencingAttribute: subjectid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: subjectid, RelationshipBehavior: 1, SchemaName: subject_incidents, SecurityTypes: Append, IntroducedVersion: 5.0.0.0. </summary>
	public const string subject_incidents = "subjectid";

	/// <summary>ReferencedAttribute: systemuserid, ReferencedEntity: systemuser, ReferencedEntityNavigationPropertyName: system_user_incidents, ReferencingAttribute: owninguser, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: owninguser, RelationshipBehavior: 0, SchemaName: system_user_incidents, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string system_user_incidents = "owninguser";

	/// <summary>ReferencedAttribute: teamid, ReferencedEntity: team, ReferencedEntityNavigationPropertyName: team_incidents, ReferencingAttribute: owningteam, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: owningteam, RelationshipBehavior: 0, SchemaName: team_incidents, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string team_incidents = "owningteam";

	/// <summary>ReferencedAttribute: transactioncurrencyid, ReferencedEntity: transactioncurrency, ReferencedEntityNavigationPropertyName: TransactionCurrency_Incident, ReferencingAttribute: transactioncurrencyid, ReferencingEntity: incident, ReferencingEntityNavigationPropertyName: transactioncurrencyid, RelationshipBehavior: 0, SchemaName: TransactionCurrency_Incident, SecurityTypes: None, IntroducedVersion: 5.0.0.0. </summary>
	public const string TransactionCurrency_Incident = "transactioncurrencyid";

}

