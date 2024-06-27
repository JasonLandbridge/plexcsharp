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
    
    public class GetSessionsMedia
    {

        [JsonProperty("audioChannels")]
        public int? AudioChannels { get; set; }

        [JsonProperty("audioCodec")]
        public string? AudioCodec { get; set; }

        [JsonProperty("bitrate")]
        public int? Bitrate { get; set; }

        [JsonProperty("container")]
        public string? Container { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("selected")]
        public bool? Selected { get; set; }

        [JsonProperty("Part")]
        public List<GetSessionsPart>? Part { get; set; }
    }
}