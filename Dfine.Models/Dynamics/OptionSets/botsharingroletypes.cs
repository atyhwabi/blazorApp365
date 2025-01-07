namespace ECSM.Models.Dynamics;

/// <summary>Type of sharing roles associated with Power Virtual Agents bots.</summary>
public static class botsharingroletypes
{
	/// <summary>Chatbot author, #0000ff, Creates, edit and maintains bot content (trigger phrases, topic content, entities and variables). USes Power Automate solutions, authentication action and other extensibility integrations (e.g. skill) provided by developers in content editing.</summary>
	public const int Chatbotauthor = 2;

	/// <summary>Chatbot manager, #0000ff, A manager has full access to all bot content, can publish content, is accountable for bot operations, and can configure hand-off, channels and other operational information.</summary>
	public const int Chatbotmanager = 1;

	/// <summary>Chatbot reviewer, #0000ff, View bot performance in analytics section, monitors CSAT, provides feedback and suggestions.</summary>
	public const int Chatbotreviewer = 3;

}

