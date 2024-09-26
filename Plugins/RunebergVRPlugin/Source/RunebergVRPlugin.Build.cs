using UnrealBuildTool;
 
public class RunebergVRPlugin : ModuleRules
{
    public RunebergVRPlugin(ReadOnlyTargetRules Target)  : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = "Public/RunebergVRPlugin.h";
        bEnforceIWYU = true;
        bUseUnity = true;

        PublicIncludePaths.AddRange(new string[] { "RunebergVRPlugin/Source/Public", "Public" });
				
		PrivateIncludePaths.AddRange(new string[] { "RunebergVRPlugin/Source/Private", "Private"});
		
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem"});
 
        PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore"});
 
        DynamicallyLoadedModuleNames.AddRange(new string[] { "RunebergVRPlugin" });
    }
}