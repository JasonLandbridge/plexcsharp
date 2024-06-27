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
    using PlexAPI.Utils;
    using System;
    
    /// <summary>
    /// The type of library to filter. Can be &quot;movie&quot; or &quot;show&quot;, or all if not present.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum Libtype
    {
        [JsonProperty("movie")]
        Movie,
        [JsonProperty("show")]
        Show,
    }

    public static class LibtypeExtension
    {
        public static string Value(this Libtype value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Libtype ToEnum(this string value)
        {
            foreach(var field in typeof(Libtype).GetFields())
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

                    if (enumVal is Libtype)
                    {
                        return (Libtype)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Libtype");
        }
    }

}