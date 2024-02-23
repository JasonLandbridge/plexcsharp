
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI
{
    using Newtonsoft.Json;
    using PlexAPI.Models.Components;
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Activities are awesome. They provide a way to monitor and control asynchronous operations on the server. In order to receive real-time updates for activities, a client would normally subscribe via either EventSource or Websocket endpoints.<br/>
    /// 
    /// <remarks>
    /// Activities are associated with HTTP replies via a special `X-Plex-Activity` header which contains the UUID of the activity.<br/>
    /// Activities are optional cancellable. If cancellable, they may be cancelled via the `DELETE` endpoint. Other details:<br/>
    /// - They can contain a `progress` (from 0 to 100) marking the percent completion of the activity.<br/>
    /// - They must contain an `type` which is used by clients to distinguish the specific activity.<br/>
    /// - They may contain a `Context` object with attributes which associate the activity with various specific entities (items, libraries, etc.)<br/>
    /// - The may contain a `Response` object which attributes which represent the result of the asynchronous operation.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public interface IActivities
    {

        /// <summary>
        /// Get Server Activities
        /// 
        /// <remarks>
        /// Get Server Activities
        /// </remarks>
        /// </summary>
        Task<GetServerActivitiesResponse> GetServerActivitiesAsync();

        /// <summary>
        /// Cancel Server Activities
        /// 
        /// <remarks>
        /// Cancel Server Activities
        /// </remarks>
        /// </summary>
        Task<CancelServerActivitiesResponse> CancelServerActivitiesAsync(string activityUUID);
    }

    /// <summary>
    /// Activities are awesome. They provide a way to monitor and control asynchronous operations on the server. In order to receive real-time updates for activities, a client would normally subscribe via either EventSource or Websocket endpoints.<br/>
    /// 
    /// <remarks>
    /// Activities are associated with HTTP replies via a special `X-Plex-Activity` header which contains the UUID of the activity.<br/>
    /// Activities are optional cancellable. If cancellable, they may be cancelled via the `DELETE` endpoint. Other details:<br/>
    /// - They can contain a `progress` (from 0 to 100) marking the percent completion of the activity.<br/>
    /// - They must contain an `type` which is used by clients to distinguish the specific activity.<br/>
    /// - They may contain a `Context` object with attributes which associate the activity with various specific entities (items, libraries, etc.)<br/>
    /// - The may contain a `Response` object which attributes which represent the result of the asynchronous operation.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class Activities: IActivities
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.0";
        private const string _sdkGenVersion = "2.269.0";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.0 2.269.0 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Activities(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetServerActivitiesResponse> GetServerActivitiesAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/activities";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetServerActivitiesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetServerActivitiesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }

            if((response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetServerActivitiesActivitiesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<CancelServerActivitiesResponse> CancelServerActivitiesAsync(string activityUUID)
        {
            var request = new CancelServerActivitiesRequest()
            {
                ActivityUUID = activityUUID,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/activities/{activityUUID}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CancelServerActivitiesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200) || (response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<CancelServerActivitiesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}