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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    
    public class GetTransientTokenRequest
    {

        /// <summary>
        /// `delegation` - This is the only supported `type` parameter.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public GetTransientTokenQueryParamType Type { get; set; } = default!;

        /// <summary>
        /// `all` - This is the only supported `scope` parameter.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=scope")]
        public Scope Scope { get; set; } = default!;
    }
}