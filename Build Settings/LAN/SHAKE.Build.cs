// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SHAKE : ModuleRules
{
    public SHAKE(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "NetCore", "OnlineSubsystem", "OnlineSubsystemUtils", "Voice" });

        //DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
        DynamicallyLoadedModuleNames.Add("OnlineSubsystemNull");
    }
}
