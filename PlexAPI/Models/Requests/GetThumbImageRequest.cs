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
    
    public class GetThumbImageRequest
    {

        /// <summary>
        /// the id of the library item to return the children of.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ratingKey")]
        public long RatingKey { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=width")]
        public long Width { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=height")]
        public long Height { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=minSize")]
        public long MinSize { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=upscale")]
        public long Upscale { get; set; } = default!;

        /// <summary>
        /// Plex Authentication Token
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Token")]
        public string XPlexToken { get; set; } = default!;
    }
}