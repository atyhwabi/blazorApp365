namespace ECSM.Models.Dynamics;

/// <summary>Options to cascade closing cases</summary>
public static class cascadecaseclosurepreference
{
	/// <summary>Close all child cases when parent case is closed</summary>
	public const int Closeallchildcaseswhenparentcaseisclosed = 0;

	/// <summary>Don't allow parent case closure until all child cases are closed</summary>
	public const int Dontallowparentcaseclosureuntilallchildcasesareclosed = 1;

}

