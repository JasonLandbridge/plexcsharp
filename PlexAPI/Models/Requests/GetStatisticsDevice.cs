
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
    
    public class GetStatisticsDevice
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("platform")]
        public string? Platform { get; set; }

        [JsonProperty("clientIdentifier")]
        public string? ClientIdentifier { get; set; }

        [JsonProperty("createdAt")]
        public int? CreatedAt { get; set; }
    }
}