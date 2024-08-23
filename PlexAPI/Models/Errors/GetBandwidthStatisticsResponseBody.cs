//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Errors
{
    using Newtonsoft.Json;
    using PlexAPI.Models.Errors;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System;
    
    /// <summary>
    /// Unauthorized - Returned if the X-Plex-Token is missing from the header or query.
    /// </summary>
    public class GetBandwidthStatisticsResponseBody : Exception
    {

        [JsonProperty("errors")]
        public List<GetBandwidthStatisticsErrors>? Errors { get; set; }

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        [JsonProperty("-")]
        public HttpResponseMessage? RawResponse { get; set; }
    }
}