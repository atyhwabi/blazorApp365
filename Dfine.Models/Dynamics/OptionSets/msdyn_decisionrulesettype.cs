namespace ECSM.Models.Dynamics;

/// <summary>Defines type of the rule set</summary>
public static class msdyn_decisionrulesettype
{
	/// <summary>Dataverse Components, #0000ee, Embellishing the work-item using dataverse components</summary>
	public const int DataverseComponents = 192350002;

	/// <summary>Declarative, #0000ff, Embellishing the work-item using conditional expressions on different entities</summary>
	public const int Declarative = 192350000;

	/// <summary>Intelligent Conversation Distribution, #0000ff, Route conversations using an LLM model based prediction</summary>
	public const int IntelligentConversationDistribution = 192350003;

	/// <summary>ML model based, #0000ff, Embellishing the work-item using ML model</summary>
	public const int MLmodelbased = 192350001;

}

