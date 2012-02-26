using System;

using JeanRichard.Xbmc.Lib.JsonRpc;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public interface IXbmcServer
    {
        /// <summary>
        /// Retrieve the jsonrpc protocol version
        /// </summary>
        /// <returns>The Version of the RPC Protocol.</returns>
        void GetVersion(Action<int, ErrorData> resultAction);

        /// <summary>
        /// Enumerates all actions and descriptions
        /// </summary>
        void Introspect(Action<JToken, ErrorData> resultAction);

        /// <summary>
        /// Ping responder
        /// </summary>
        /// <returns>the responste to the Ping request (should be "pong")</returns>
        void Ping(Action<string, ErrorData> resultAction);

        /// <summary>
        /// Quit application
        /// </summary>
        void Quit(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Toggle mute/unmute
        /// </summary>
        /// <param name="muteState">true if XBMC should mute.</param>
        /// <returns>MuteState of the Application</returns>
        void SetMute(Action<bool, ErrorData> resultAction, bool muteState);

        /// <summary>
        /// Set the current volume
        /// </summary>
        /// <returns>Current Volume</returns>
        void SetVolume(Action<int, ErrorData> resultAction, int volume);

        /// <summary>
        /// Cleans the audio library from non-existent items
        /// </summary>
        void SetVolume(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Toggle mute/unmute
        /// </summary>
        /// <returns>MuteState of the Application</returns>
        void ToggleMute(Action<bool, ErrorData> resultAction);
    }
}