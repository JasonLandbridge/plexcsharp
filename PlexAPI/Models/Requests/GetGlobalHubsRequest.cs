
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
    using PlexAPI.Utils;
    
    public class GetGlobalHubsRequest
    {

        /// <summary>
        /// The number of items to return with each hub.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=count")]
        public double? Count { get; set; }

        /// <summary>
        /// Only return hubs which are &quot;transient&quot;, meaning those which are prone to changing after media playback or addition (e.g. On Deck, or Recently Added).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=onlyTransient")]
        public OnlyTransient? OnlyTransient { get; set; }
    }
}