
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
    using PlexAPI.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;



    /// <summary>
    /// The protocol to use when connecting to your plex server.
    /// </summary>
    public enum ServerProtocol
    {
        [JsonProperty("http")]
        Http,
        [JsonProperty("https")]
        Https,
    }

    public static class ServerProtocolExtension
    {
        public static string Value(this ServerProtocol value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServerProtocol ToEnum(this string value)
        {
            foreach(var field in typeof(ServerProtocol).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ServerProtocol)
                    {
                        return (ServerProtocol)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServerProtocol");
        }
    }

    /// <summary>
    /// Plex-API: A Plex Media Server API Map
    /// 
    /// <remarks>
    /// An Open API Spec for interacting with Plex.tv and Plex Servers
    /// </remarks>
    /// </summary>
    public interface IPlexAPISDK
    {

        /// <summary>
        /// Operations against the Plex Media Server System.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IServer Server { get; }

        /// <summary>
        /// API Calls interacting with Plex Media Server Media<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IMedia Media { get; }

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
        public IActivities Activities { get; }

        /// <summary>
        /// Butler is the task manager of the Plex Media Server Ecosystem.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IButler Butler { get; }

        /// <summary>
        /// Hubs are a structured two-dimensional container for media, generally represented by multiple horizontal rows.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IHubs Hubs { get; }

        /// <summary>
        /// API Calls that perform search operations with Plex Media Server<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ISearch Search { get; }

        /// <summary>
        /// API Calls interacting with Plex Media Server Libraries<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ILibrary Library { get; }

        /// <summary>
        /// Submit logs to the Log Handler for Plex Media Server<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ILog Log { get; }

        /// <summary>
        /// Playlists are ordered collections of media. They can be dumb (just a list of media) or smart (based on a media query, such as &quot;all albums from 2017&quot;). <br/>
        /// 
        /// <remarks>
        /// They can be organized in (optionally nesting) folders.<br/>
        /// Retrieving a playlist, or its items, will trigger a refresh of its metadata. <br/>
        /// This may cause the duration and number of items to change.<br/>
        /// 
        /// </remarks>
        /// </summary>
        public IPlaylists Playlists { get; }

        /// <summary>
        /// API Calls against Security for Plex Media Server<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ISecurity Security { get; }

        /// <summary>
        /// API Calls that perform search operations with Plex Media Server Sessions<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ISessions Sessions { get; }

        /// <summary>
        /// This describes the API for searching and applying updates to the Plex Media Server.<br/>
        /// 
        /// <remarks>
        /// Updates to the status can be observed via the Event API.<br/>
        /// 
        /// </remarks>
        /// </summary>
        public IUpdater Updater { get; }

        /// <summary>
        /// API Calls that perform operations with Plex Media Server Videos<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IVideo Video { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "{protocol}://{ip}:{port}",
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public int serverIndex = 0;
        public List<Dictionary<string, string>> ServerDefaults = new List<Dictionary<string, string>>();

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], this.ServerDefaults[this.serverIndex]);
        }
    }

    /// <summary>
    /// Plex-API: A Plex Media Server API Map
    /// 
    /// <remarks>
    /// An Open API Spec for interacting with Plex.tv and Plex Servers
    /// </remarks>
    /// </summary>
    public class PlexAPISDK: IPlexAPISDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.4";
        private const string _sdkGenVersion = "2.237.3";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.4 2.237.3 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IServer Server { get; private set; }
        public IMedia Media { get; private set; }
        public IActivities Activities { get; private set; }
        public IButler Butler { get; private set; }
        public IHubs Hubs { get; private set; }
        public ISearch Search { get; private set; }
        public ILibrary Library { get; private set; }
        public ILog Log { get; private set; }
        public IPlaylists Playlists { get; private set; }
        public ISecurity Security { get; private set; }
        public ISessions Sessions { get; private set; }
        public IUpdater Updater { get; private set; }
        public IVideo Video { get; private set; }

        public PlexAPISDK(Security? security = null, int? serverIndex = null, ServerProtocol? protocol = null, string?  ip = null, string?  port = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }
            List<Dictionary<string, string>> serverDefaults = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    {"protocol", protocol == null ? "http" : ServerProtocolExtension.Value(protocol.Value)},
                    {"ip", ip == null ? "10.10.10.47" : ip},
                    {"port", port == null ? "32400" : port},
                },
            };

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            SDKConfiguration = new SDKConfig()
            {
                ServerDefaults = serverDefaults,
                serverUrl = _serverUrl
            };

            Server = new Server(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Media = new Media(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Activities = new Activities(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Butler = new Butler(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Hubs = new Hubs(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Search = new Search(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Library = new Library(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Log = new Log(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Playlists = new Playlists(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Security = new Security(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Sessions = new Sessions(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Updater = new Updater(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Video = new Video(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}