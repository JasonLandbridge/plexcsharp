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
    
    public class RefreshLibraryRequest
    {

        /// <summary>
        /// the Id of the library to refresh
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=sectionId")]
        public double SectionId { get; set; } = default!;
    }
}