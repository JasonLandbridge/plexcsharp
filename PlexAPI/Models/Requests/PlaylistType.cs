
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
    /// limit to a type of playlist.
    /// </summary>
    public enum PlaylistType
    {
        [JsonProperty("audio")]
        Audio,
        [JsonProperty("video")]
        Video,
        [JsonProperty("photo")]
        Photo,
    }

    public static class PlaylistTypeExtension
    {
        public static string Value(this PlaylistType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PlaylistType ToEnum(this string value)
        {
            foreach(var field in typeof(PlaylistType).GetFields())
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

                    if (enumVal is PlaylistType)
                    {
                        return (PlaylistType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PlaylistType");
        }
    }

}