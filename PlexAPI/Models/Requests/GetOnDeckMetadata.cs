
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
    using System.Collections.Generic;
    using System;
    
    public class GetOnDeckMetadata
    {

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("librarySectionID")]
        public double? LibrarySectionID { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        [JsonProperty("librarySectionUUID")]
        public string? LibrarySectionUUID { get; set; }

        [JsonProperty("ratingKey")]
        public double? RatingKey { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("parentRatingKey")]
        public double? ParentRatingKey { get; set; }

        [JsonProperty("grandparentRatingKey")]
        public double? GrandparentRatingKey { get; set; }

        [JsonProperty("guid")]
        public string? Guid { get; set; }

        [JsonProperty("parentGuid")]
        public string? ParentGuid { get; set; }

        [JsonProperty("grandparentGuid")]
        public string? GrandparentGuid { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("grandparentKey")]
        public string? GrandparentKey { get; set; }

        [JsonProperty("parentKey")]
        public string? ParentKey { get; set; }

        [JsonProperty("librarySectionKey")]
        public string? LibrarySectionKey { get; set; }

        [JsonProperty("grandparentTitle")]
        public string? GrandparentTitle { get; set; }

        [JsonProperty("parentTitle")]
        public string? ParentTitle { get; set; }

        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        [JsonProperty("summary")]
        public string? Summary { get; set; }

        [JsonProperty("index")]
        public double? Index { get; set; }

        [JsonProperty("parentIndex")]
        public double? ParentIndex { get; set; }

        [JsonProperty("lastViewedAt")]
        public double? LastViewedAt { get; set; }

        [JsonProperty("year")]
        public double? Year { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("parentThumb")]
        public string? ParentThumb { get; set; }

        [JsonProperty("grandparentThumb")]
        public string? GrandparentThumb { get; set; }

        [JsonProperty("grandparentArt")]
        public string? GrandparentArt { get; set; }

        [JsonProperty("grandparentTheme")]
        public string? GrandparentTheme { get; set; }

        [JsonProperty("duration")]
        public double? Duration { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public DateTime? OriginallyAvailableAt { get; set; }

        [JsonProperty("addedAt")]
        public double? AddedAt { get; set; }

        [JsonProperty("updatedAt")]
        public double? UpdatedAt { get; set; }

        [JsonProperty("Media")]
        public List<GetOnDeckMedia>? Media { get; set; }

        [JsonProperty("Guid")]
        public List<Guids>? Guids { get; set; }
    }
}