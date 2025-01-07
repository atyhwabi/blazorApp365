namespace ECSM.Models.Dynamics;

/// <summary>The type of an event parameter used by Cxp Events</summary>
public static class msdynmkt_eventparametertype
{
	/// <summary>CDP-A Built-in Signal Property, #0000ff, Event Parameter's value comes from a CDP-A built-in signal property. e.g. Signal.User.Id.</summary>
	public const int CDPABuiltinSignalProperty = 534130001;

	/// <summary>CDP-A Contactable Signal Property, #0000ff, Event Parameter's value comes from a CDP-A contactable signal property provided by the signal producer.</summary>
	public const int CDPAContactableSignalProperty = 534130003;

	/// <summary>CDP-A Event Binding Signal Property, #0000ff, Event Parameter's value comes from a CDP-A Event Binding signal property provided by the signal producer.</summary>
	public const int CDPAEventBindingSignalProperty = 534130004;

	/// <summary>CDP-A Signal Property, #0000ff, Event Parameter's value comes from a CDP-A signal property explicitly provided by the signal producer.</summary>
	public const int CDPASignalProperty = 534130002;

	/// <summary>Customer Identifier, #0000ff, Event Parameter contains a Customer Identifier</summary>
	public const int CustomerIdentifier = 534130000;

}

