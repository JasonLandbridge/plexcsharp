
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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ITv
    {

        /// <summary>
        /// Get a Pin
        /// 
        /// <remarks>
        /// Retrieve a Pin from Plex.tv for authentication flows
        /// </remarks>
        /// </summary>
        Task<GetPinResponse> GetPinAsync(string xPlexClientIdentifier, bool? strong = null, string? serverUrl = null);

        /// <summary>
        /// Get Access Token
        /// 
        /// <remarks>
        /// Retrieve an Access Token from Plex.tv after the Pin has already been authenticated
        /// </remarks>
        /// </summary>
        Task<GetTokenResponse> GetTokenAsync(string pinID, string xPlexClientIdentifier, string? serverUrl = null);
    }

    public class Tv: ITv
    {
        /**
        * GetPinServerList contains the list of server urls available to the SDK.
        */
        public static readonly string[] GetPinServerList = {
            "https://plex.tv/api/v2",
        };

        /**
        * GetTokenServerList contains the list of server urls available to the SDK.
        */
        public static readonly string[] GetTokenServerList = {
            "https://plex.tv/api/v2",
        };

        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.0";
        private const string _sdkGenVersion = "2.248.6";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.0 2.248.6 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Tv(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetPinResponse> GetPinAsync(string xPlexClientIdentifier, bool? strong = null, string? serverUrl = null)
        {
            var request = new GetPinRequest()
            {
                XPlexClientIdentifier = xPlexClientIdentifier,
                Strong = strong,
            };
            string baseUrl = Utilities.TemplateUrl(GetPinServerList[0], new Dictionary<string, string>(){
            });
            if (serverUrl != null)
            {
                baseUrl = serverUrl;
            }
            var urlString = URLBuilder.Build(baseUrl, "/pins", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetPinResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetPinResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.FourHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetPinPlexTvResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetTokenResponse> GetTokenAsync(string pinID, string xPlexClientIdentifier, string? serverUrl = null)
        {
            var request = new GetTokenRequest()
            {
                PinID = pinID,
                XPlexClientIdentifier = xPlexClientIdentifier,
            };
            string baseUrl = Utilities.TemplateUrl(GetTokenServerList[0], new Dictionary<string, string>(){
            });
            if (serverUrl != null)
            {
                baseUrl = serverUrl;
            }
            var urlString = URLBuilder.Build(baseUrl, "/pins/{pinID}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetTokenResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<GetTokenResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}