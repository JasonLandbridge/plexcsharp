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
    using Newtonsoft.Json;
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    
    /// <summary>
    /// If the account’s Plex Pass subscription is active
    /// </summary>
    public class Subscription
    {

        /// <summary>
        /// List of features allowed on your Plex Pass subscription
        /// </summary>
        [JsonProperty("features")]
        public List<Features>? Features { get; set; }

        /// <summary>
        /// If the account&apos;s Plex Pass subscription is active
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Date the account subscribed to Plex Pass
        /// </summary>
        [JsonProperty("subscribedAt")]
        public string? SubscribedAt { get; set; } = null;

        /// <summary>
        /// String representation of subscriptionActive
        /// </summary>
        [JsonProperty("status")]
        public GetUserDetailsAuthenticationStatus? Status { get; set; }

        /// <summary>
        /// Payment service used for your Plex Pass subscription
        /// </summary>
        [JsonProperty("paymentService")]
        public string? PaymentService { get; set; } = null;

        /// <summary>
        /// Name of Plex Pass subscription plan
        /// </summary>
        [JsonProperty("plan")]
        public string? Plan { get; set; } = null;
    }
}