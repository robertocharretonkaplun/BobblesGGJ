using UnrealBuildTool;

public class BobblesGGJTarget : TargetRules
{
	public BobblesGGJTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BobblesGGJ");
	}
}
