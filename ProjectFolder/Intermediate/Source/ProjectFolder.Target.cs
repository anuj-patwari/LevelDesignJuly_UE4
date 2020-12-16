using UnrealBuildTool;

public class ProjectFolderTarget : TargetRules
{
	public ProjectFolderTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectFolder");
	}
}
