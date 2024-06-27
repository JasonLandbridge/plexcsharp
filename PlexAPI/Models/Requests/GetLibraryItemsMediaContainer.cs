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
    using PlexAPI.Models.Components;
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    
    public class GetLibraryItemsMediaContainer
    {

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("identifier")]
        public string? Identifier { get; set; }

        [JsonProperty("librarySectionID")]
        public LibrarySectionID? LibrarySectionID { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        [JsonProperty("librarySectionUUID")]
        public string? LibrarySectionUUID { get; set; }

        [JsonProperty("mediaTagPrefix")]
        public string? MediaTagPrefix { get; set; }

        [JsonProperty("mediaTagVersion")]
        public int? MediaTagVersion { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("title1")]
        public string? Title1 { get; set; }

        [JsonProperty("title2")]
        public string? Title2 { get; set; }

        [JsonProperty("viewGroup")]
        public string? ViewGroup { get; set; }

        [JsonProperty("viewMode")]
        public int? ViewMode { get; set; }

        [JsonProperty("mixedParents")]
        public bool? MixedParents { get; set; }

        [JsonProperty("Metadata")]
        public List<GetLibraryItemsMetadata>? Metadata { get; set; }
    }
}