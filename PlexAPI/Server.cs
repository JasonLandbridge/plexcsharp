
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
    /// Operations against the Plex Media Server System.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface IServer
    {

        /// <summary>
        /// Server Capabilities
        /// 
        /// <remarks>
        /// Server Capabilities
        /// </remarks>
        /// </summary>
        Task<GetServerCapabilitiesResponse> GetServerCapabilitiesAsync();

        /// <summary>
        /// Get Server Preferences
        /// 
        /// <remarks>
        /// Get Server Preferences
        /// </remarks>
        /// </summary>
        Task<GetServerPreferencesResponse> GetServerPreferencesAsync();

        /// <summary>
        /// Get Available Clients
        /// 
        /// <remarks>
        /// Get Available Clients
        /// </remarks>
        /// </summary>
        Task<GetAvailableClientsResponse> GetAvailableClientsAsync();

        /// <summary>
        /// Get Devices
        /// 
        /// <remarks>
        /// Get Devices
        /// </remarks>
        /// </summary>
        Task<GetDevicesResponse> GetDevicesAsync();

        /// <summary>
        /// Get Server Identity
        /// 
        /// <remarks>
        /// Get Server Identity
        /// </remarks>
        /// </summary>
        Task<GetServerIdentityResponse> GetServerIdentityAsync();

        /// <summary>
        /// Get MyPlex Account
        /// 
        /// <remarks>
        /// Returns MyPlex Account Information
        /// </remarks>
        /// </summary>
        Task<GetMyPlexAccountResponse> GetMyPlexAccountAsync();

        /// <summary>
        /// Get a Resized Photo
        /// 
        /// <remarks>
        /// Plex&apos;s Photo transcoder is used throughout the service to serve images at specified sizes.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetResizedPhotoResponse> GetResizedPhotoAsync(GetResizedPhotoRequest request);

        /// <summary>
        /// Get Server List
        /// 
        /// <remarks>
        /// Get Server List
        /// </remarks>
        /// </summary>
        Task<GetServerListResponse> GetServerListAsync();
    }

    /// <summary>
    /// Operations against the Plex Media Server System.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Server: IServer
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.0";
        private const string _sdkGenVersion = "2.277.0";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.0 2.277.0 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Server(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetServerCapabilitiesResponse> GetServerCapabilitiesAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetServerCapabilitiesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetServerCapabilitiesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetServerCapabilitiesServerResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetServerPreferencesResponse> GetServerPreferencesAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/:/prefs";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetServerPreferencesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetServerPreferencesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetServerPreferencesServerResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetAvailableClientsResponse> GetAvailableClientsAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/clients";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetAvailableClientsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetAvailableClientsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetAvailableClientsServerResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetDevicesResponse> GetDevicesAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/devices";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetDevicesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetDevicesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetDevicesServerResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetServerIdentityResponse> GetServerIdentityAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/identity";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetServerIdentityResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetServerIdentityResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetServerIdentityServerResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetMyPlexAccountResponse> GetMyPlexAccountAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/myplex/account";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetMyPlexAccountResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetMyPlexAccountResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetMyPlexAccountServerResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetResizedPhotoResponse> GetResizedPhotoAsync(GetResizedPhotoRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/photo/:/transcode", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetResizedPhotoResponse
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
                    response.Object = JsonConvert.DeserializeObject<GetResizedPhotoResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetServerListResponse> GetServerListAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/servers";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetServerListResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetServerListResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetServerListServerResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}