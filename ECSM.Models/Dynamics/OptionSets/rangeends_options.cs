namespace ECSM.Models.Dynamics;

/// <summary>Choose when the appointment should end</summary>
public static class rangeends_options
{
	/// <summary>By end date, #0000ff, The appointment series ends by a specied end date</summary>
	public const int Byenddate = 3;

	/// <summary>By number of occurrences, #0000ff, The appointment series ends after a specified number of occurences</summary>
	public const int Bynumberofoccurrences = 2;

	/// <summary>Never, #0000ff, The appointment series never ends</summary>
	public const int Never = 1;

}

