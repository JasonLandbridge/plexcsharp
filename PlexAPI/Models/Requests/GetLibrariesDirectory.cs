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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    
    public class GetLibrariesDirectory
    {

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("composite")]
        public string? Composite { get; set; }

        [JsonProperty("filters")]
        public bool? Filters { get; set; }

        [JsonProperty("refreshing")]
        public bool? Refreshing { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("agent")]
        public string? Agent { get; set; }

        [JsonProperty("scanner")]
        public string? Scanner { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        [JsonProperty("updatedAt")]
        public int? UpdatedAt { get; set; }

        [JsonProperty("createdAt")]
        public int? CreatedAt { get; set; }

        [JsonProperty("scannedAt")]
        public int? ScannedAt { get; set; }

        [JsonProperty("content")]
        public bool? Content { get; set; }

        [JsonProperty("directory")]
        public bool? Directory { get; set; }

        [JsonProperty("contentChangedAt")]
        public int? ContentChangedAt { get; set; }

        [JsonProperty("hidden")]
        public int? Hidden { get; set; }

        [JsonProperty("Location")]
        public List<GetLibrariesLocation>? Location { get; set; }
    }
}