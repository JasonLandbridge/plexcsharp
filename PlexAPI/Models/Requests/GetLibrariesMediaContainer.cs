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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    
    public class GetLibrariesMediaContainer
    {

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("title1")]
        public string? Title1 { get; set; }

        [JsonProperty("Directory")]
        public List<GetLibrariesDirectory>? Directory { get; set; }
    }
}