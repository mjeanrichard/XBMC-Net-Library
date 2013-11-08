using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details
{
    /// <jsonId>
    /// Audio.Details.Song
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Audio.Details.Media",
    ///  "id": "Audio.Details.Song",
    ///  "properties": {
    ///    "album": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "albumartist": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "albumartistid": {
    ///      "$ref": "Array.Integer"
    ///    },
    ///    "albumid": {
    ///      "$ref": "Library.Id",
    ///      "default": -1
    ///    },
    ///    "comment": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "disc": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "duration": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "file": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "lastplayed": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "lyrics": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "musicbrainzartistid": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "musicbrainztrackid": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "playcount": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "songid": {
    ///      "$ref": "Library.Id",
    ///      "required": true
    ///    },
    ///    "track": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    }
    ///  }
    ///}
    /// </json>
    public class Song : AudioMedia
    {
        public override int? Id
        {
            get { return SongId; }
            set { SongId = value; }
        }

        [JsonProperty(PropertyName = "album")]
        public string Album { get; set; }

        [JsonProperty(PropertyName = "albumartist")]
        public string[] AlbumArtist { get; set; }

        [JsonProperty(PropertyName = "albumartistid")]
        public int[] AlbumArtistId { get; set; }

        [JsonProperty(PropertyName = "albumid")]
        public int? AlbumId { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "disc")]
        public int Disc { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }

        [JsonProperty(PropertyName = "file")]
        public string File { get; set; }

        [JsonProperty(PropertyName = "lastplayed")]
        public string LastPlayed { get; set; }

        [JsonProperty(PropertyName = "lyrics")]
        public string Lyrics { get; set; }

        [JsonProperty(PropertyName = "musicbrainzartistid")]
        public string MusicBrainzArtistId { get; set; }

        [JsonProperty(PropertyName = "musicbrainztrackid")]
        public string MusicBrainzTrackId { get; set; }

        [JsonProperty(PropertyName = "playcount")]
        public int PlayCount { get; set; }

        [JsonProperty(PropertyName = "songid")]
        public int? SongId { get; set; }

        [JsonProperty(PropertyName = "track")]
        public int? Track { get; set; }

        [JsonIgnore]
        public string ArtistsString
        {
            get { return string.Join(", ", Artists); }
        }
    }
}