using UnrealBuildTool;

public class BobblesGGJClientTarget : TargetRules
{
	public BobblesGGJClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("BobblesGGJ");
	}
}
