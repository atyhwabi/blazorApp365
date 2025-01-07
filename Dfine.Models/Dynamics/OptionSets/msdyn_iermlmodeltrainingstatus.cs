namespace ECSM.Models.Dynamics;

/// <summary>Indicates model's recent training status</summary>
public static class msdyn_iermlmodeltrainingstatus
{
	/// <summary>Loading data</summary>
	public const int Loadingdata = 100000007;

	/// <summary>Not trained, #0000ff</summary>
	public const int Nottrained = 100000000;

	/// <summary>Publish completed</summary>
	public const int Publishcompleted = 100000006;

	/// <summary>Publish failed</summary>
	public const int Publishfailed = 100000005;

	/// <summary>Publish in progress</summary>
	public const int Publishinprogress = 100000004;

	/// <summary>Training completed, #0000ff</summary>
	public const int Trainingcompleted = 100000002;

	/// <summary>Training failed, #0000ff</summary>
	public const int Trainingfailed = 100000003;

	/// <summary>Training in progress, #0000ff</summary>
	public const int Traininginprogress = 100000001;

}

