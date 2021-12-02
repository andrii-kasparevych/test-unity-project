using System;
using System.Data;
using Labster.Platform.BuildSettings;
using Labster.Platform.BuildSettings.BuildEvents.SubscriptionInterfaces;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildEventsSubscriber : IPostprocessApplyBuildSettings, IPostprocessBuildWithBuildSettings, IPreprocessApplyBuildSettings, IPreprocessBuildWithBuildSettings
{
    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildPlayerOptions buildPlayerOptions, BuildSettings buildSettings)
    {
        Debug.Log("OnPreprocessBuild for target " + buildPlayerOptions.target + " at path " + buildPlayerOptions.locationPathName
                  + " with build Settings: " + buildSettings.name);
    }

    public void OnPreprocessApply(BuildSettings buildSettings)
    {
        Debug.Log("OnPreprocessApply with build Settings: " + buildSettings.name);
    }

    public void OnPostprocessBuild(BuildPlayerOptions buildPlayerOptions, BuildSettings buildSettings)
    {
        Debug.Log("OnPostprocessBuild for target " + buildPlayerOptions.target + " at path " + buildPlayerOptions.locationPathName
                  + " with build Settings: " + buildSettings.name);
    }

    public void OnPostprocessApply(BuildSettings buildSettings)
    {
        Debug.Log("OnPostprocessApply with build Settings: " + buildSettings.name);
        Debug.Log("Generating .csproj files");
        //Packages.Rider.Editor.RiderScriptEditor.SyncSolution();
        Debug.Log("Finished generating .csproj files");
        
    }
}
