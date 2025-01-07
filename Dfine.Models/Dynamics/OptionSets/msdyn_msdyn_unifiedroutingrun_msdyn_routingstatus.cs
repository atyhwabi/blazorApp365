namespace ECSM.Models.Dynamics;

/// <summary>Defines routing status</summary>
public static class msdyn_msdyn_unifiedroutingrun_msdyn_routingstatus
{
	/// <summary>Agent assignment - completed, #0000ff</summary>
	public const int Agentassignmentcompleted = 100000006;

	/// <summary>Intake rules - completed, #0000ff</summary>
	public const int Intakerulescompleted = 100000000;

	/// <summary>Queue: Assignment rules - completed, #0000ff</summary>
	public const int QueueAssignmentrulescompleted = 100000005;

	/// <summary>Queue: Assignment selection rules - completed, #0000ff</summary>
	public const int QueueAssignmentselectionrulescompleted = 100000004;

	/// <summary>Queue: Prioritization rules - completed, #0000ff</summary>
	public const int QueuePrioritizationrulescompleted = 100000003;

	/// <summary>Workstream: Classification rules - processing..., #0000ff</summary>
	public const int WorkstreamClassificationrulesprocessing = 100000001;

	/// <summary>Workstream: Route-to-queue rules - completed, #0000ff</summary>
	public const int WorkstreamRoutetoqueuerulescompleted = 100000002;

}

