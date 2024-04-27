using UnrealBuildTool;

public class SuperMarioTarget : TargetRules
{
	public SuperMarioTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SuperMario");
	}
}
