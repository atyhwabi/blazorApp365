namespace ECSM.Models.Dynamics;

/// <summary>Azure state of user.</summary>
public static class systemuser_azurestate
{
	/// <summary>Exists</summary>
	public const int Exists = 0;

	/// <summary>Not found or hard deleted</summary>
	public const int Notfoundorharddeleted = 2;

	/// <summary>Soft deleted</summary>
	public const int Softdeleted = 1;

}

