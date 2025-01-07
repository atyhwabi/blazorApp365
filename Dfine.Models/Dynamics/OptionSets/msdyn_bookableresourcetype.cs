namespace ECSM.Models.Dynamics;

/// <summary>Select whether the resource is an account, contact, user, equipment, crew, facility or a pool of resources.</summary>
public static class msdyn_bookableresourcetype
{
	/// <summary>Account</summary>
	public const int Account = 5;

	/// <summary>Contact</summary>
	public const int Contact = 2;

	/// <summary>Crew</summary>
	public const int Crew = 6;

	/// <summary>Equipment</summary>
	public const int Equipment = 4;

	/// <summary>Facility</summary>
	public const int Facility = 7;

	/// <summary>Generic</summary>
	public const int Generic = 1;

	/// <summary>Pool</summary>
	public const int Pool = 8;

	/// <summary>User</summary>
	public const int User = 3;

}

