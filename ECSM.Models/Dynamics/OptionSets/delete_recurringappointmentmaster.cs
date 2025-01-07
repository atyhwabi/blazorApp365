namespace ECSM.Models.Dynamics;

/// <summary>How would you like to delete this series?</summary>
public static class delete_recurringappointmentmaster
{
	/// <summary>All instances, Delete all instances</summary>
	public const int Allinstances = 1;

	/// <summary>The series, leave past appointments, Delete all series except the past appointments</summary>
	public const int Theseriesleavepastappointments = 2;

}

