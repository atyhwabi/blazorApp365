namespace ECSM.Models.Dynamics;

/// <summary>Action to be taken due to overflow</summary>
public static class msdyn_overflowactiontype
{
	/// <summary>Default, #0000ff</summary>
	public const int Default = 192350000;

	/// <summary>Direct Callback, #0000ff, Initiate callback for the customer</summary>
	public const int DirectCallback = 192350003;

	/// <summary>End Conversation, #0000ff, Close the conversation</summary>
	public const int EndConversation = 192350001;

	/// <summary>Queue Transfer, #0000ff, Transfer work item to another queue</summary>
	public const int QueueTransfer = 192350005;

	/// <summary>Remain In Queue, #0000ff, Keep work item waiting in queue for agent assignment</summary>
	public const int RemainInQueue = 192350006;

	/// <summary>Transfer to Phone, #0000ff, Transfer call to an external number</summary>
	public const int TransfertoPhone = 192350002;

	/// <summary>Voicemail, #0000ff, Transfer call to voicemail</summary>
	public const int Voicemail = 192350004;

}

