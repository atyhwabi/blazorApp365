namespace ECSM.Models.Dynamics;

/// <summary>Application Based Access Control Mode. 0 is Disabled, 1 is Enabled, 2 is audit mode, 3 is Enabled for roles</summary>
public static class organization_applicationbasedaccesscontrolmode
{
	/// <summary>AuditMode</summary>
	public const int AuditMode = 2;

	/// <summary>Disabled</summary>
	public const int Disabled = 0;

	/// <summary>Enabled</summary>
	public const int Enabled = 1;

	/// <summary>Enabled for roles</summary>
	public const int Enabledforroles = 3;

}

