
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
    
    public class ClearPlaylistContentsRequest
    {

        /// <summary>
        /// the ID of the playlist
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=playlistID")]
        public double PlaylistID { get; set; } = default!;
    }
}