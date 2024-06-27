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
    
    public class GetRecentlyAddedMediaContainer
    {

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("identifier")]
        public string? Identifier { get; set; }

        [JsonProperty("mediaTagPrefix")]
        public string? MediaTagPrefix { get; set; }

        [JsonProperty("mediaTagVersion")]
        public double? MediaTagVersion { get; set; }

        [JsonProperty("mixedParents")]
        public bool? MixedParents { get; set; }

        [JsonProperty("Metadata")]
        public List<GetRecentlyAddedMetadata>? Metadata { get; set; }
    }
}