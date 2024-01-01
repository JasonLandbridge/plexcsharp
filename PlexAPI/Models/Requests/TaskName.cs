
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// the name of the task to be started.
    /// </summary>
    public enum TaskName
    {
        [JsonProperty("BackupDatabase")]
        BackupDatabase,
        [JsonProperty("BuildGracenoteCollections")]
        BuildGracenoteCollections,
        [JsonProperty("CheckForUpdates")]
        CheckForUpdates,
        [JsonProperty("CleanOldBundles")]
        CleanOldBundles,
        [JsonProperty("CleanOldCacheFiles")]
        CleanOldCacheFiles,
        [JsonProperty("DeepMediaAnalysis")]
        DeepMediaAnalysis,
        [JsonProperty("GenerateAutoTags")]
        GenerateAutoTags,
        [JsonProperty("GenerateChapterThumbs")]
        GenerateChapterThumbs,
        [JsonProperty("GenerateMediaIndexFiles")]
        GenerateMediaIndexFiles,
        [JsonProperty("OptimizeDatabase")]
        OptimizeDatabase,
        [JsonProperty("RefreshLibraries")]
        RefreshLibraries,
        [JsonProperty("RefreshLocalMedia")]
        RefreshLocalMedia,
        [JsonProperty("RefreshPeriodicMetadata")]
        RefreshPeriodicMetadata,
        [JsonProperty("UpgradeMediaAnalysis")]
        UpgradeMediaAnalysis,
    }

    public static class TaskNameExtension
    {
        public static string Value(this TaskName value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TaskName ToEnum(this string value)
        {
            foreach(var field in typeof(TaskName).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is TaskName)
                    {
                        return (TaskName)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TaskName");
        }
    }
}