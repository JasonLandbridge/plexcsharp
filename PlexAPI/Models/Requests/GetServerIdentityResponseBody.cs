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
    
    /// <summary>
    /// The Server Identity information
    /// </summary>
    public class GetServerIdentityResponseBody
    {

        [JsonProperty("MediaContainer")]
        public GetServerIdentityMediaContainer? MediaContainer { get; set; }
    }
}