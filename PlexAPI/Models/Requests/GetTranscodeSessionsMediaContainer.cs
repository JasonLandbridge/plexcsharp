
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
    
    public class GetTranscodeSessionsMediaContainer
    {

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("TranscodeSession")]
        public List<TranscodeSession>? TranscodeSession { get; set; }
    }
}