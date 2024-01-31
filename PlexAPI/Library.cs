
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
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// API Calls interacting with Plex Media Server Libraries<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface ILibrary
    {

        /// <summary>
        /// Get Hash Value
        /// 
        /// <remarks>
        /// This resource returns hash values for local files
        /// </remarks>
        /// </summary>
        Task<GetFileHashResponse> GetFileHashAsync(string url, double? type = null);

        /// <summary>
        /// Get Recently Added
        /// 
        /// <remarks>
        /// This endpoint will return the recently added content.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetRecentlyAddedResponse> GetRecentlyAddedAsync();

        /// <summary>
        /// Get All Libraries
        /// 
        /// <remarks>
        /// A library section (commonly referred to as just a library) is a collection of media. <br/>
        /// Libraries are typed, and depending on their type provide either a flat or a hierarchical view of the media. <br/>
        /// For example, a music library has an artist &gt; albums &gt; tracks structure, whereas a movie library is flat.<br/>
        /// <br/>
        /// Libraries have features beyond just being a collection of media; for starters, they include information about supported types, filters and sorts. <br/>
        /// This allows a client to provide a rich interface around the media (e.g. allow sorting movies by release year).<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetLibrariesResponse> GetLibrariesAsync();

        /// <summary>
        /// Get Library Details
        /// 
        /// <remarks>
        /// ## Library Details Endpoint<br/>
        /// <br/>
        /// This endpoint provides comprehensive details about the library, focusing on organizational aspects rather than the content itself.   <br/>
        /// <br/>
        /// The details include:<br/>
        /// <br/>
        /// ### Directories<br/>
        /// Organized into three categories:<br/>
        /// <br/>
        /// - **Primary Directories**: <br/>
        ///   - Used in some clients for quick access to media subsets (e.g., &quot;All&quot;, &quot;On Deck&quot;).<br/>
        ///   - Most can be replicated via media queries.<br/>
        ///   - Customizable by users.<br/>
        /// <br/>
        /// - **Secondary Directories**:<br/>
        ///   - Marked with `secondary=&quot;1&quot;`.<br/>
        ///   - Used in older clients for structured navigation.<br/>
        /// <br/>
        /// - **Special Directories**:<br/>
        ///   - Includes a &quot;By Folder&quot; entry for filesystem-based browsing.<br/>
        ///   - Contains an obsolete `search=&quot;1&quot;` entry for on-the-fly search dialog creation.<br/>
        /// <br/>
        /// ### Types<br/>
        /// Each type in the library comes with a set of filters and sorts, aiding in building dynamic media controls:<br/>
        /// <br/>
        /// - **Type Object Attributes**:<br/>
        ///   - `key`: Endpoint for the media list of this type.<br/>
        ///   - `type`: Metadata type (if standard Plex type).<br/>
        ///   - `title`: Title for this content type (e.g., &quot;Movies&quot;).<br/>
        /// <br/>
        /// - **Filter Objects**:<br/>
        ///   - Subset of the media query language.<br/>
        ///   - Attributes include `filter` (name), `filterType` (data type), `key` (endpoint for value range), and `title`.<br/>
        /// <br/>
        /// - **Sort Objects**:<br/>
        ///   - Description of sort fields.<br/>
        ///   - Attributes include `defaultDirection` (asc/desc), `descKey` and `key` (sort parameters), and `title`.<br/>
        /// <br/>
        /// &gt; **Note**: Filters and sorts are optional; without them, no filtering controls are rendered.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetLibraryResponse> GetLibraryAsync(double sectionId, IncludeDetails? includeDetails = null);

        /// <summary>
        /// Delete Library Section
        /// 
        /// <remarks>
        /// Delate a library using a specific section
        /// </remarks>
        /// </summary>
        Task<DeleteLibraryResponse> DeleteLibraryAsync(double sectionId);

        /// <summary>
        /// Get Library Items
        /// 
        /// <remarks>
        /// Fetches details from a specific section of the library identified by a section key and a tag. The tag parameter accepts the following values:<br/>
        /// - `all`: All items in the section.<br/>
        /// - `unwatched`: Items that have not been played.<br/>
        /// - `newest`: Items that are recently released.<br/>
        /// - `recentlyAdded`: Items that are recently added to the library.<br/>
        /// - `recentlyViewed`: Items that were recently viewed.<br/>
        /// - `onDeck`: Items to continue watching.<br/>
        /// - `collection`: Items categorized by collection.<br/>
        /// - `edition`: Items categorized by edition.<br/>
        /// - `genre`: Items categorized by genre.<br/>
        /// - `year`: Items categorized by year of release.<br/>
        /// - `decade`: Items categorized by decade.<br/>
        /// - `director`: Items categorized by director.<br/>
        /// - `actor`: Items categorized by starring actor.<br/>
        /// - `country`: Items categorized by country of origin.<br/>
        /// - `contentRating`: Items categorized by content rating.<br/>
        /// - `rating`: Items categorized by rating.<br/>
        /// - `resolution`: Items categorized by resolution.<br/>
        /// - `firstCharacter`: Items categorized by the first letter.<br/>
        /// - `folder`: Items categorized by folder.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetLibraryItemsResponse> GetLibraryItemsAsync(long sectionId, Tag tag);

        /// <summary>
        /// Refresh Library
        /// 
        /// <remarks>
        /// This endpoint Refreshes the library.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<RefreshLibraryResponse> RefreshLibraryAsync(double sectionId);

        /// <summary>
        /// Search Library
        /// 
        /// <remarks>
        /// Search for content within a specific section of the library.<br/>
        /// <br/>
        /// ### Types<br/>
        /// Each type in the library comes with a set of filters and sorts, aiding in building dynamic media controls:<br/>
        /// <br/>
        /// - **Type Object Attributes**:<br/>
        ///   - `type`: Metadata type (if standard Plex type).  <br/>
        ///   - `title`: Title for this content type (e.g., &quot;Movies&quot;).<br/>
        /// <br/>
        /// - **Filter Objects**:<br/>
        ///   - Subset of the media query language.<br/>
        ///   - Attributes include `filter` (name), `filterType` (data type), `key` (endpoint for value range), and `title`.<br/>
        /// <br/>
        /// - **Sort Objects**:<br/>
        ///   - Description of sort fields.<br/>
        ///   - Attributes include `defaultDirection` (asc/desc), `descKey` and `key` (sort parameters), and `title`.<br/>
        /// <br/>
        /// &gt; **Note**: Filters and sorts are optional; without them, no filtering controls are rendered.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<SearchLibraryResponse> SearchLibraryAsync(long sectionId, Type type);

        /// <summary>
        /// Get Items Metadata
        /// 
        /// <remarks>
        /// This endpoint will return the metadata of a library item specified with the ratingKey.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetMetadataResponse> GetMetadataAsync(double ratingKey);

        /// <summary>
        /// Get Items Children
        /// 
        /// <remarks>
        /// This endpoint will return the children of of a library item specified with the ratingKey.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetMetadataChildrenResponse> GetMetadataChildrenAsync(double ratingKey);

        /// <summary>
        /// Get On Deck
        /// 
        /// <remarks>
        /// This endpoint will return the on deck content.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetOnDeckResponse> GetOnDeckAsync();
    }

    /// <summary>
    /// API Calls interacting with Plex Media Server Libraries<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Library: ILibrary
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.0";
        private const string _sdkGenVersion = "2.239.4";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.0 2.239.4 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Library(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetFileHashResponse> GetFileHashAsync(string url, double? type = null)
        {
            var request = new GetFileHashRequest()
            {
                Url = url,
                Type = type,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/hashes", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetFileHashResponse
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
                    response.Object = JsonConvert.DeserializeObject<GetFileHashResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetRecentlyAddedResponse> GetRecentlyAddedAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/library/recentlyAdded";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetRecentlyAddedResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetRecentlyAddedResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetRecentlyAddedLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetLibrariesResponse> GetLibrariesAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/library/sections";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetLibrariesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetLibrariesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetLibrariesLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetLibraryResponse> GetLibraryAsync(double sectionId, IncludeDetails? includeDetails = null)
        {
            var request = new GetLibraryRequest()
            {
                SectionId = sectionId,
                IncludeDetails = includeDetails,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/sections/{sectionId}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetLibraryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetLibraryLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<DeleteLibraryResponse> DeleteLibraryAsync(double sectionId)
        {
            var request = new DeleteLibraryRequest()
            {
                SectionId = sectionId,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/sections/{sectionId}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DeleteLibraryResponse
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
                    response.Object = JsonConvert.DeserializeObject<DeleteLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetLibraryItemsResponse> GetLibraryItemsAsync(long sectionId, Tag tag)
        {
            var request = new GetLibraryItemsRequest()
            {
                SectionId = sectionId,
                Tag = tag,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/sections/{sectionId}/{tag}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetLibraryItemsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<GetLibraryItemsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<RefreshLibraryResponse> RefreshLibraryAsync(double sectionId)
        {
            var request = new RefreshLibraryRequest()
            {
                SectionId = sectionId,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/sections/{sectionId}/refresh", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RefreshLibraryResponse
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
                    response.Object = JsonConvert.DeserializeObject<RefreshLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<SearchLibraryResponse> SearchLibraryAsync(long sectionId, Type type)
        {
            var request = new SearchLibraryRequest()
            {
                SectionId = sectionId,
                Type = type,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/sections/{sectionId}/search", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new SearchLibraryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<SearchLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetMetadataResponse> GetMetadataAsync(double ratingKey)
        {
            var request = new GetMetadataRequest()
            {
                RatingKey = ratingKey,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/metadata/{ratingKey}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetMetadataResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetMetadataResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetMetadataLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetMetadataChildrenResponse> GetMetadataChildrenAsync(double ratingKey)
        {
            var request = new GetMetadataChildrenRequest()
            {
                RatingKey = ratingKey,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/library/metadata/{ratingKey}/children", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetMetadataChildrenResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetMetadataChildrenResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetMetadataChildrenLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetOnDeckResponse> GetOnDeckAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/library/onDeck";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetOnDeckResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetOnDeckResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetOnDeckLibraryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}