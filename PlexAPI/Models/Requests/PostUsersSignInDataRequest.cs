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
    
    public class PostUsersSignInDataRequest
    {

        /// <summary>
        /// The unique identifier for the client application<br/>
        /// 
        /// <remarks>
        /// This is used to track the client application and its usage<br/>
        /// (UUID, serial number, or other number unique per device)<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Client-Identifier")]
        public string? XPlexClientIdentifier { get; set; }

        /// <summary>
        /// Login credentials
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/x-www-form-urlencoded")]
        public PostUsersSignInDataRequestBody? RequestBody { get; set; }
    }
}