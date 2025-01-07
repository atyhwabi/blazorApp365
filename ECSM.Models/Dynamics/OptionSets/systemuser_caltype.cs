namespace ECSM.Models.Dynamics;

/// <summary>License type of user. This is used only in the on-premises version of the product. Online licenses are managed through Microsoft 365 Office Portal.</summary>
public static class systemuser_caltype
{
	/// <summary>Administrative</summary>
	public const int Administrative = 1;

	/// <summary>Basic</summary>
	public const int Basic = 2;

	/// <summary>Device Basic</summary>
	public const int DeviceBasic = 4;

	/// <summary>Device Enterprise</summary>
	public const int DeviceEnterprise = 8;

	/// <summary>Device Essential</summary>
	public const int DeviceEssential = 6;

	/// <summary>Device Professional</summary>
	public const int DeviceProfessional = 3;

	/// <summary>Enterprise</summary>
	public const int Enterprise = 7;

	/// <summary>Essential</summary>
	public const int Essential = 5;

	/// <summary>Field Service</summary>
	public const int FieldService = 11;

	/// <summary>Professional</summary>
	public const int Professional = 0;

	/// <summary>Project Service</summary>
	public const int ProjectService = 12;

	/// <summary>Sales</summary>
	public const int Sales = 9;

	/// <summary>Service</summary>
	public const int Service = 10;

}

