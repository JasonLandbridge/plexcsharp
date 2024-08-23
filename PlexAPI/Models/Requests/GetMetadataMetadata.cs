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
    using NodaTime;
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    
    public class GetMetadataMetadata
    {

        [JsonProperty("ratingKey")]
        public string? RatingKey { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("guid")]
        public string? Guid { get; set; }

        [JsonProperty("studio")]
        public string? Studio { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        [JsonProperty("librarySectionID")]
        public int? LibrarySectionID { get; set; }

        [JsonProperty("librarySectionKey")]
        public string? LibrarySectionKey { get; set; }

        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        [JsonProperty("summary")]
        public string? Summary { get; set; }

        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("audienceRating")]
        public double? AudienceRating { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("tagline")]
        public string? Tagline { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public LocalDate? OriginallyAvailableAt { get; set; }

        [JsonProperty("addedAt")]
        public int? AddedAt { get; set; }

        [JsonProperty("updatedAt")]
        public int? UpdatedAt { get; set; }

        [JsonProperty("audienceRatingImage")]
        public string? AudienceRatingImage { get; set; }

        [JsonProperty("hasPremiumPrimaryExtra")]
        public string? HasPremiumPrimaryExtra { get; set; }

        [JsonProperty("ratingImage")]
        public string? RatingImage { get; set; }

        [JsonProperty("Media")]
        public List<GetMetadataMedia>? Media { get; set; }

        [JsonProperty("Genre")]
        public List<GetMetadataGenre>? Genre { get; set; }

        [JsonProperty("Country")]
        public List<GetMetadataCountry>? Country { get; set; }

        [JsonProperty("Guid")]
        public List<Guids>? Guids { get; set; }

        [JsonProperty("Rating")]
        public List<Ratings>? Ratings { get; set; }

        [JsonProperty("Director")]
        public List<GetMetadataDirector>? Director { get; set; }

        [JsonProperty("Writer")]
        public List<GetMetadataWriter>? Writer { get; set; }

        [JsonProperty("Role")]
        public List<GetMetadataRole>? Role { get; set; }

        [JsonProperty("Producer")]
        public List<Producer>? Producer { get; set; }
    }
}