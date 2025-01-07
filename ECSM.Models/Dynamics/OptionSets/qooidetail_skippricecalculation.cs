namespace ECSM.Models.Dynamics;

/// <summary>Based on the options in SkipPriceCalculation , OOB price calculation for  qooi line item level will be skipped</summary>
public static class qooidetail_skippricecalculation
{
	/// <summary>DoPriceCalcAlways</summary>
	public const int DoPriceCalcAlways = 0;

	/// <summary>SkipPriceCalcOnCreate</summary>
	public const int SkipPriceCalcOnCreate = 1;

	/// <summary>SkipPriceCalcOnUpdate</summary>
	public const int SkipPriceCalcOnUpdate = 2;

	/// <summary>SkipPriceCalcOnUpSert</summary>
	public const int SkipPriceCalcOnUpSert = 3;

}

