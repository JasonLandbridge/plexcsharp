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
    using PlexAPI.Utils;
    
    public class PerformVoiceSearchRequest
    {

        /// <summary>
        /// The query term
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=query")]
        public string Query { get; set; } = default!;

        /// <summary>
        /// This gives context to the search, and can result in re-ordering of search result hubs
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sectionId")]
        public double? SectionId { get; set; }

        /// <summary>
        /// The number of items to return per hub
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public double? Limit { get; set; } = 3D;
    }
}