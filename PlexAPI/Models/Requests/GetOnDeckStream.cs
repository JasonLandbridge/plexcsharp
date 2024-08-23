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
    
    public class GetOnDeckStream
    {

        [JsonProperty("id")]
        public double? Id { get; set; }

        [JsonProperty("streamType")]
        public double? StreamType { get; set; }

        [JsonProperty("default")]
        public bool? Default { get; set; }

        [JsonProperty("codec")]
        public string? Codec { get; set; }

        [JsonProperty("index")]
        public double? Index { get; set; }

        [JsonProperty("bitrate")]
        public double? Bitrate { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("languageTag")]
        public string? LanguageTag { get; set; }

        [JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        [JsonProperty("bitDepth")]
        public double? BitDepth { get; set; }

        [JsonProperty("chromaLocation")]
        public string? ChromaLocation { get; set; }

        [JsonProperty("chromaSubsampling")]
        public string? ChromaSubsampling { get; set; }

        [JsonProperty("codedHeight")]
        public double? CodedHeight { get; set; }

        [JsonProperty("codedWidth")]
        public double? CodedWidth { get; set; }

        [JsonProperty("colorRange")]
        public string? ColorRange { get; set; }

        [JsonProperty("frameRate")]
        public double? FrameRate { get; set; }

        [JsonProperty("height")]
        public double? Height { get; set; }

        [JsonProperty("level")]
        public double? Level { get; set; }

        [JsonProperty("profile")]
        public string? Profile { get; set; }

        [JsonProperty("refFrames")]
        public double? RefFrames { get; set; }

        [JsonProperty("width")]
        public double? Width { get; set; }

        [JsonProperty("displayTitle")]
        public string? DisplayTitle { get; set; }

        [JsonProperty("extendedDisplayTitle")]
        public string? ExtendedDisplayTitle { get; set; }
    }
}