using System;

using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class XbmcServer : IXbmcServer
    {
        private readonly IRpcClient _client;

        public XbmcServer(IRpcClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve the jsonrpc protocol version
        /// </summary>
        /// <returns>The Version of the RPC Protocol.</returns>
        public void GetVersion(Action<int, ErrorData> resultAction)
        {
            _client.Invoke("JSONRPC.Version", t => t.ParseSimpleValue<int>("version"), resultAction);
        }

        /// <summary>
        /// Enumerates all actions and descriptions
        /// </summary>
        public void Introspect(Action<JToken, ErrorData> resultAction)
        {
            _client.Invoke("JSONRPC.Introspect", t => t, resultAction, new JsonParam("getdescriptions", true), new JsonParam("getmetadata", true), new JsonParam("filterbytransport", true));
        }

        /// <summary>
        /// Ping responder
        /// </summary>
        /// <returns>the responste to the Ping request (should be "pong")</returns>
        public void Ping(Action<string, ErrorData> resultAction)
        {
            _client.InvokeSimple("JSONRPC.Ping", resultAction);
        }

        /// <summary>
        /// Quit application
        /// </summary>
        public void Quit(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Application.Quit", resultAction);
        }

        /// <summary>
        /// Toggle mute/unmute
        /// </summary>
        /// <param name="muteState">true if XBMC should mute.</param>
        /// <returns>MuteState of the Application</returns>
        public void SetMute(Action<bool, ErrorData> resultAction, bool muteState)
        {
            _client.InvokeSimple("Application.SetMute", resultAction, new JsonParam("mute", muteState));
        }

        /// <summary>
        /// Set the current volume
        /// </summary>
        /// <returns>Current Volume</returns>
        public void SetVolume(Action<int, ErrorData> resultAction, int volume)
        {
            if (volume > 100 || volume < 0)
            {
                throw new ArgumentException("Volume must be between 0 an 100.", "volume");
            }
            _client.InvokeSimple("Application.SetVolume", resultAction, new JsonParam("volume", volume));
        }

        /// <summary>
        /// Cleans the audio library from non-existent items
        /// </summary>
        public void SetVolume(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("AudioLibrary.Clean", resultAction);
        }

        /// <summary>
        /// Toggle mute/unmute
        /// </summary>
        /// <returns>MuteState of the Application</returns>
        public void ToggleMute(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeSimple("Application.SetMute", resultAction, new JsonParam("mute", "toggle"));
        }
    }
}