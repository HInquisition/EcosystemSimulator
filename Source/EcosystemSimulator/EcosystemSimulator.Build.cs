// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EcosystemSimulator : ModuleRules
{
	public EcosystemSimulator(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "GameplayAbilities", "GameplayTags", "GameplayTasks" });
        PublicIncludePaths.AddRange(new string[] { "EcosystemSimulator" });
		PrivateDependencyModuleNames.AddRange(new string[] { "BlueprintMapUtilities" });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
