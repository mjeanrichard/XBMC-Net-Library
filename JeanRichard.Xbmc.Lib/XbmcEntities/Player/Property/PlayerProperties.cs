using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Global;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player.Audio;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player.Property
{
    /// <jsonId>
    /// Player.Property.Value
    /// </jsonId>
    /// <json>
    /// {
    ///  "id": "Player.Property.Value",
    ///  "properties": {
    ///    "audiostreams": {
    ///      "items": {
    ///        "$ref": "Player.Audio.Stream"
    ///      },
    ///      "type": "array"
    ///    },
    ///    "canchangespeed": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "canmove": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "canrepeat": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "canrotate": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "canseek": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "canshuffle": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "canzoom": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "currentaudiostream": {
    ///      "$ref": "Player.Audio.Stream.Extended"
    ///    },
    ///    "currentsubtitle": {
    ///      "$ref": "Player.Subtitle"
    ///    },
    ///    "live": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "partymode": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "percentage": {
    ///      "$ref": "Player.Position.Percentage",
    ///      "default": 0
    ///    },
    ///    "playlistid": {
    ///      "$ref": "Playlist.Id",
    ///      "default": -1
    ///    },
    ///    "position": {
    ///      "$ref": "Playlist.Position",
    ///      "default": -1
    ///    },
    ///    "repeat": {
    ///      "$ref": "Player.Repeat",
    ///      "default": "off"
    ///    },
    ///    "shuffled": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "speed": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "subtitleenabled": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "subtitles": {
    ///      "items": {
    ///        "$ref": "Player.Subtitle"
    ///      },
    ///      "type": "array"
    ///    },
    ///    "time": {
    ///      "$ref": "Global.Time"
    ///    },
    ///    "totaltime": {
    ///      "$ref": "Global.Time"
    ///    },
    ///    "type": {
    ///      "$ref": "Player.Type",
    ///      "default": "video"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public class PlayerProperties : JsonRpcItem
    {
        private int? _playlistId = -1;

        private int? _position = -1;

        [JsonProperty(PropertyName = "audiostreams")]
        public AudioStream[] AudioStreams { get; set; }

        [JsonProperty(PropertyName = "canchangespeed")]
        public bool CanChangespeed { get; set; }

        [JsonProperty(PropertyName = "canmove")]
        public bool CanMove { get; set; }

        [JsonProperty(PropertyName = "canrepeat")]
        public bool CanRepeat { get; set; }

        [JsonProperty(PropertyName = "canrotate")]
        public bool CanRotate { get; set; }

        [JsonProperty(PropertyName = "canseek")]
        public bool CanSeek { get; set; }

        [JsonProperty(PropertyName = "canshuffle")]
        public bool CanShuffle { get; set; }

        [JsonProperty(PropertyName = "canzoom")]
        public bool CanZoom { get; set; }

        [JsonProperty(PropertyName = "currentaudiostream")]
        public ExtendedAudioStream CurrentAudioStream { get; set; }

        [JsonProperty(PropertyName = "currentsubtitle")]
        public Subtitle CurrentSubtitle { get; set; }

        [JsonProperty(PropertyName = "live")]
        public bool Live { get; set; }

        [JsonProperty(PropertyName = "partymode")]
        public bool Partymode { get; set; }

        [JsonProperty(PropertyName = "percentage")]
        public decimal Percentage { get; set; }

        [JsonProperty(PropertyName = "playlistid")]
        public int? PlaylistId
        {
            get { return _playlistId; }
            set { _playlistId = value; }
        }

        [JsonProperty(PropertyName = "position")]
        public int? Position
        {
            get { return _position; }
            set { _position = value; }
        }

        [JsonProperty(PropertyName = "repeat")]
        public Repeat Repeat { get; set; }

        [JsonProperty(PropertyName = "shuffled")]
        public bool Shuffled { get; set; }

        [JsonProperty(PropertyName = "speed")]
        public int Speed { get; set; }

        [JsonProperty(PropertyName = "subtitleenabled")]
        public bool SubtitleEnabled { get; set; }

        [JsonProperty(PropertyName = "subtitles")]
        public Subtitle[] SubtitleS { get; set; }

        [JsonProperty(PropertyName = "time")]
        public Time Time { get; set; }

        [JsonProperty(PropertyName = "totaltime")]
        public Time TotalTime { get; set; }

        [JsonProperty(PropertyName = "type")]
        public PlayerTypes Type { get; set; }
    }
}