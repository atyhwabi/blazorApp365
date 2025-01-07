namespace ECSM.Models.Dynamics;

/// <summary>Validation status reason of the record URL.</summary>
public static class sharepoint_validationstatusreason
{
	/// <summary>Authentication failure.</summary>
	public const int Authenticationfailure = 6;

	/// <summary>Invalid certificates.</summary>
	public const int Invalidcertificates = 7;

	/// <summary>The URL could not be accessed because of Internet Explorer security settings.</summary>
	public const int TheURLcouldnotbeaccessedbecauseofInternetExplorersecuritysettings = 5;

	/// <summary>The URL schemes of Microsoft Dynamics 365 and SharePoint are different.</summary>
	public const int TheURLschemesofMicrosoftDynamics365andSharePointaredifferent = 4;

	/// <summary>This record's URL has not been validated.</summary>
	public const int ThisrecordsURLhasnotbeenvalidated = 1;

	/// <summary>This record's URL is not valid.</summary>
	public const int ThisrecordsURLisnotvalid = 3;

	/// <summary>This record's URL is valid.</summary>
	public const int ThisrecordsURLisvalid = 2;

}

