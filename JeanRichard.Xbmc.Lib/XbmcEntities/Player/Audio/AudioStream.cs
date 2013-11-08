using JeanRichard.Xbmc.Lib.JsonRpc;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player.Audio
{
    /// <jsonId>
    /// Player.Audio.Stream
    /// </jsonId>
    /// <json>
    /// {
    ///  "id": "Player.Audio.Stream",
    ///  "properties": {
    ///    "index": {
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "language": {
    ///      "required": true,
    ///      "type": "string"
    ///    },
    ///    "name": {
    ///      "required": true,
    ///      "type": "string"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public class AudioStream : JsonRpcItem
    {
        [JsonProperty(PropertyName = "index")]
        public int Index { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}