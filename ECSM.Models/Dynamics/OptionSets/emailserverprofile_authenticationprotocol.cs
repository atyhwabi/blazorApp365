namespace ECSM.Models.Dynamics;

/// <summary>Authentication protocol used when connecting to the email server.</summary>
public static class emailserverprofile_authenticationprotocol
{
	/// <summary>Auto Detect</summary>
	public const int AutoDetect = 0;

	/// <summary>Basic</summary>
	public const int Basic = 3;

	/// <summary>Negotiate</summary>
	public const int Negotiate = 1;

	/// <summary>NTLM</summary>
	public const int NTLM = 2;

	/// <summary>OAuth</summary>
	public const int OAuth = 4;

}

