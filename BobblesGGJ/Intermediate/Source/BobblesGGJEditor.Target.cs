using UnrealBuildTool;

public class BobblesGGJEditorTarget : TargetRules
{
	public BobblesGGJEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BobblesGGJ");
	}
}
