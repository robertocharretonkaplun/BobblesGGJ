using UnrealBuildTool;

public class BobblesGGJServerTarget : TargetRules
{
	public BobblesGGJServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BobblesGGJ");
	}
}
