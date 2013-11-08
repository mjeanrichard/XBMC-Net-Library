using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player.Audio
{
    /// <jsonId>
    /// Player.Audio.Stream.Extended
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Player.Audio.Stream",
    ///  "id": "Player.Audio.Stream.Extended",
    ///  "properties": {
    ///    "bitrate": {
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "channels": {
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "codec": {
    ///      "required": true,
    ///      "type": "string"
    ///    }
    ///  }
    ///}
    /// </json>
    public class ExtendedAudioStream : AudioStream
    {
        [JsonProperty(PropertyName = "bitrate")]
        public int Bitrate { get; set; }

        [JsonProperty(PropertyName = "channels")]
        public int Channels { get; set; }

        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }
    }
}