//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace LukeHagar.PlexAPI.SDK
{
    using LukeHagar.PlexAPI.SDK.Hooks;
    using LukeHagar.PlexAPI.SDK.Models.Components;
    using LukeHagar.PlexAPI.SDK.Models.Errors;
    using LukeHagar.PlexAPI.SDK.Models.Requests;
    using LukeHagar.PlexAPI.SDK.Utils.Retries;
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// API Calls interacting with Plex Media Server Media<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface IMedia
    {

        /// <summary>
        /// Mark Media Played
        /// 
        /// <remarks>
        /// This will mark the provided media key as Played.
        /// </remarks>
        /// </summary>
        Task<MarkPlayedResponse> MarkPlayedAsync(double key);

        /// <summary>
        /// Mark Media Unplayed
        /// 
        /// <remarks>
        /// This will mark the provided media key as Unplayed.
        /// </remarks>
        /// </summary>
        Task<MarkUnplayedResponse> MarkUnplayedAsync(double key);

        /// <summary>
        /// Update Media Play Progress
        /// 
        /// <remarks>
        /// This API command can be used to update the play progress of a media item.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<UpdatePlayProgressResponse> UpdatePlayProgressAsync(string key, double time, string state);

        /// <summary>
        /// Get Banner Image
        /// 
        /// <remarks>
        /// Gets the banner image of the media item
        /// </remarks>
        /// </summary>
        Task<GetBannerImageResponse> GetBannerImageAsync(GetBannerImageRequest request);

        /// <summary>
        /// Get Thumb Image
        /// 
        /// <remarks>
        /// Gets the thumbnail image of the media item
        /// </remarks>
        /// </summary>
        Task<GetThumbImageResponse> GetThumbImageAsync(GetThumbImageRequest request);
    }

    /// <summary>
    /// API Calls interacting with Plex Media Server Media<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Media: IMedia
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.6.3";
        private const string _sdkGenVersion = "2.415.8";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.6.3 2.415.8 0.0.3 LukeHagar.PlexAPI.SDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<LukeHagar.PlexAPI.SDK.Models.Components.Security>? _securitySource;

        public Media(ISpeakeasyHttpClient client, Func<LukeHagar.PlexAPI.SDK.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<MarkPlayedResponse> MarkPlayedAsync(double key)
        {
            var request = new MarkPlayedRequest()
            {
                Key = key,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/:/scrobble", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("markPlayed", null, _securitySource);

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
                return new MarkPlayedResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<MarkPlayedBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<MarkPlayedUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<MarkUnplayedResponse> MarkUnplayedAsync(double key)
        {
            var request = new MarkUnplayedRequest()
            {
                Key = key,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/:/unscrobble", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("markUnplayed", null, _securitySource);

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
                return new MarkUnplayedResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<MarkUnplayedBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<MarkUnplayedUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<UpdatePlayProgressResponse> UpdatePlayProgressAsync(string key, double time, string state)
        {
            var request = new UpdatePlayProgressRequest()
            {
                Key = key,
                Time = time,
                State = state,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/:/progress", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("updatePlayProgress", null, _securitySource);

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
                return new UpdatePlayProgressResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<UpdatePlayProgressBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<UpdatePlayProgressUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<GetBannerImageResponse> GetBannerImageAsync(GetBannerImageRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/library/metadata/{ratingKey}/banner", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-banner-image", null, _securitySource);

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
                if(Utilities.IsContentTypeMatch("image/jpeg", contentType))
                {
                    var response = new GetBannerImageResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.Bytes = await httpResponse.Content.ReadAsByteArrayAsync();
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetBannerImageBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetBannerImageUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<GetThumbImageResponse> GetThumbImageAsync(GetThumbImageRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/library/metadata/{ratingKey}/thumb", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-thumb-image", null, _securitySource);

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
                if(Utilities.IsContentTypeMatch("image/jpeg", contentType))
                {
                    var response = new GetThumbImageResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.Bytes = await httpResponse.Content.ReadAsByteArrayAsync();
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetThumbImageBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetThumbImageUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }
    }
}