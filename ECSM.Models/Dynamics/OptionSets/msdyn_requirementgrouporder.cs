namespace ECSM.Models.Dynamics;

/// <summary>Ordering of teams for scheduling a requirement group.</summary>
public static class msdyn_requirementgrouporder
{
	/// <summary>Earliest Time First, #0000ff, Sort by the earliest start time.</summary>
	public const int EarliestTimeFirst = 690970001;

	/// <summary>Fewest Resources First, #0000ff, Sort by the number of resources needed to satisfy the set of requirements in ascending order.</summary>
	public const int FewestResourcesFirst = 690970000;

}

