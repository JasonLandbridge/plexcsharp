//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI
{
    using Newtonsoft.Json;
    using PlexAPI.Hooks;
    using PlexAPI.Models.Components;
    using PlexAPI.Models.Errors;
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils.Retries;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// API Calls that perform search operations with Plex Media Server Sessions<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface ISessions
    {

        /// <summary>
        /// Get Active Sessions
        /// 
        /// <remarks>
        /// This will retrieve the &quot;Now Playing&quot; Information of the PMS.
        /// </remarks>
        /// </summary>
        Task<GetSessionsResponse> GetSessionsAsync();

        /// <summary>
        /// Get Session History
        /// 
        /// <remarks>
        /// This will Retrieve a listing of all history views.
        /// </remarks>
        /// </summary>
        Task<GetSessionHistoryResponse> GetSessionHistoryAsync(string? sort = null, long? accountId = null, QueryParamFilter? filter = null, long? librarySectionID = null);

        /// <summary>
        /// Get Transcode Sessions
        /// 
        /// <remarks>
        /// Get Transcode Sessions
        /// </remarks>
        /// </summary>
        Task<GetTranscodeSessionsResponse> GetTranscodeSessionsAsync();

        /// <summary>
        /// Stop a Transcode Session
        /// 
        /// <remarks>
        /// Stop a Transcode Session
        /// </remarks>
        /// </summary>
        Task<StopTranscodeSessionResponse> StopTranscodeSessionAsync(string sessionKey);
    }

    /// <summary>
    /// API Calls that perform search operations with Plex Media Server Sessions<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Sessions: ISessions
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.5.0";
        private const string _sdkGenVersion = "2.409.8";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.5.0 2.409.8 0.0.3 PlexAPI";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<PlexAPI.Models.Components.Security>? _securitySource;

        public Sessions(ISpeakeasyHttpClient client, Func<PlexAPI.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetSessionsResponse> GetSessionsAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/status/sessions";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("getSessions", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Requests.GetSessionsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetSessionsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.Object = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Errors.GetSessionsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<GetSessionHistoryResponse> GetSessionHistoryAsync(string? sort = null, long? accountId = null, QueryParamFilter? filter = null, long? librarySectionID = null)
        {
            var request = new GetSessionHistoryRequest()
            {
                Sort = sort,
                AccountId = accountId,
                Filter = filter,
                LibrarySectionID = librarySectionID,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/status/sessions/history/all", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("getSessionHistory", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Requests.GetSessionHistoryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetSessionHistoryResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.Object = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Errors.GetSessionHistoryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<GetTranscodeSessionsResponse> GetTranscodeSessionsAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/transcode/sessions";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("getTranscodeSessions", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Requests.GetTranscodeSessionsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetTranscodeSessionsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.Object = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Errors.GetTranscodeSessionsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<StopTranscodeSessionResponse> StopTranscodeSessionAsync(string sessionKey)
        {
            var request = new StopTranscodeSessionRequest()
            {
                SessionKey = sessionKey,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/transcode/sessions/{sessionKey}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("stopTranscodeSession", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 204)
            {                
                return new StopTranscodeSessionResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<StopTranscodeSessionResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }
    }
}