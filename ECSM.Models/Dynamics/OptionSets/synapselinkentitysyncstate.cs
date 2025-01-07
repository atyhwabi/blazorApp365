namespace ECSM.Models.Dynamics;

/// <summary>Synapse Link entity sync state</summary>
public static class synapselinkentitysyncstate
{
	/// <summary>Completed, #0000ff, Completed</summary>
	public const int Completed = 4;

	/// <summary>CompletedWithFailures, #0000ff, Completed with failures</summary>
	public const int CompletedWithFailures = 8;

	/// <summary>InProgress, #0000ff, In progress</summary>
	public const int InProgress = 2;

	/// <summary>None, #0000ff, None</summary>
	public const int None = 0;

	/// <summary>NotStarted, #0000ff, Not started</summary>
	public const int NotStarted = 1;

	/// <summary>Paused, #0000ff, Paused</summary>
	public const int Paused = 32;

	/// <summary>PostProcessing, #0000ff, Post processing</summary>
	public const int PostProcessing = 64;

	/// <summary>RequestedInitialData, #0000ff, Requested initial data</summary>
	public const int RequestedInitialData = 16;

}

