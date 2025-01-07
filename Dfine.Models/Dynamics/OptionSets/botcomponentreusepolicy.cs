namespace ECSM.Models.Dynamics;

/// <summary>Type of Reuse Policy associated with Power Virtual Agents chatbot subcomponents.</summary>
public static class botcomponentreusepolicy
{
	/// <summary>None, #0000ff, Not Reusable. By default, a chatbot subcomponent is not reusable and Reuse Policy is None</summary>
	public const int None = 0;

	/// <summary>Private, #0000ff, Is required by one or more Public chatbot subcomponent, but is not directly invokable or visible</summary>
	public const int Private = 1;

	/// <summary>Public, #0000ff, Visible shared / reusable chatbot subcomponent for use in all bots in the environment</summary>
	public const int Public = 2;

}

