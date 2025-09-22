// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PuzzlePlatform : ModuleRules
{
	public PuzzlePlatform(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"PuzzlePlatform",
			"PuzzlePlatform/Variant_Platforming",
			"PuzzlePlatform/Variant_Platforming/Animation",
			"PuzzlePlatform/Variant_Combat",
			"PuzzlePlatform/Variant_Combat/AI",
			"PuzzlePlatform/Variant_Combat/Animation",
			"PuzzlePlatform/Variant_Combat/Gameplay",
			"PuzzlePlatform/Variant_Combat/Interfaces",
			"PuzzlePlatform/Variant_Combat/UI",
			"PuzzlePlatform/Variant_SideScrolling",
			"PuzzlePlatform/Variant_SideScrolling/AI",
			"PuzzlePlatform/Variant_SideScrolling/Gameplay",
			"PuzzlePlatform/Variant_SideScrolling/Interfaces",
			"PuzzlePlatform/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
