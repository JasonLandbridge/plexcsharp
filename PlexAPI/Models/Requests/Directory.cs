//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
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
    
    public class Directory
    {

        [JsonProperty("count")]
        public double? Count { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }
    }
}