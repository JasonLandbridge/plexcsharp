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
    /// `delegation` - This is the only supported `type` parameter.
    /// </summary>
    public enum GetTransientTokenQueryParamType
    {
        [JsonProperty("delegation")]
        Delegation,
    }

    public static class GetTransientTokenQueryParamTypeExtension
    {
        public static string Value(this GetTransientTokenQueryParamType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetTransientTokenQueryParamType ToEnum(this string value)
        {
            foreach(var field in typeof(GetTransientTokenQueryParamType).GetFields())
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

                    if (enumVal is GetTransientTokenQueryParamType)
                    {
                        return (GetTransientTokenQueryParamType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetTransientTokenQueryParamType");
        }
    }

}