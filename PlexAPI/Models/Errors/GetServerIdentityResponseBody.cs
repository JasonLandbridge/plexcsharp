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
    using PlexAPI.Utils;
    using System.Net.Http;
    using System;
    
    /// <summary>
    /// Request Timeout
    /// </summary>
    public class GetServerIdentityResponseBody : Exception
    {

        [JsonProperty("code")]
        public long? Code { get; set; }

        [JsonProperty("message")]
        private string? _message { get; set; }
        public override string Message { get {return _message ?? "";} }

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        [JsonProperty("-")]
        public HttpResponseMessage? RawResponse { get; set; }
    }
}