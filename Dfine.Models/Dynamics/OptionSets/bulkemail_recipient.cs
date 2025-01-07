namespace ECSM.Models.Dynamics;

/// <summary>Select the records to send the direct email to</summary>
public static class bulkemail_recipient
{
	/// <summary>All records on all pages, Send direct email to all the records on all the pages in the current view.</summary>
	public const int Allrecordsonallpages = 3;

	/// <summary>All records on current page, Send direct email to all the records on this page.</summary>
	public const int Allrecordsoncurrentpage = 2;

	/// <summary>Selected records on current page, Send direct email only to the records you selected on this page.</summary>
	public const int Selectedrecordsoncurrentpage = 1;

}

