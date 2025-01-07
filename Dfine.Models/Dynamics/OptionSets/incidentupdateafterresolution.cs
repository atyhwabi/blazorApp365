namespace ECSM.Models.Dynamics;

/// <summary>Option set for different type of update Incidents/Cases after resolution</summary>
public static class incidentupdateafterresolution
{
	/// <summary>Canceled cases, #0000ff, Canceled cases</summary>
	public const int Canceledcases = 2;

	/// <summary>Don't allow updates, #0000ff, Don't allow updates</summary>
	public const int Dontallowupdates = 0;

	/// <summary>Resolved and canceled cases, #0000ff, Resolved and canceled cases</summary>
	public const int Resolvedandcanceledcases = 3;

	/// <summary>Resolved cases, #0000ff, Resolved cases</summary>
	public const int Resolvedcases = 1;

}

