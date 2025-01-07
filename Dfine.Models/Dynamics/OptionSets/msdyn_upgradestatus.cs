namespace ECSM.Models.Dynamics;

/// <summary>Status/Outcome of an UpgradeRun, UpgradeVersion, and UpgradeStep: started/success/failure</summary>
public static class msdyn_upgradestatus
{
	/// <summary>Failure, #c00000</summary>
	public const int Failure = 100000002;

	/// <summary>Started, #0000ff</summary>
	public const int Started = 100000000;

	/// <summary>Success, #008000</summary>
	public const int Success = 100000001;

}

