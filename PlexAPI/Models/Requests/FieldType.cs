
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
    
    public class FieldType
    {

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("Operator")]
        public List<Operator>? Operator { get; set; }
    }
}