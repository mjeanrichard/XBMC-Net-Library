using JeanRichard.Xbmc.Lib.XbmcEntities.Media;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details
{
    /// <jsonId>
    /// Audio.Details.Media
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Audio.Details.Base",
    ///  "id": "Audio.Details.Media",
    ///  "properties": {
    ///    "artist": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "artistid": {
    ///      "$ref": "Array.Integer"
    ///    },
    ///    "displayartist": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "genreid": {
    ///      "$ref": "Array.Integer"
    ///    },
    ///    "musicbrainzalbumartistid": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "musicbrainzalbumid": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "rating": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "title": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "year": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    }
    ///  }
    ///}
    /// </json>
    public abstract class AudioMedia : MediaDetailsBase
    {
        [JsonProperty(PropertyName = "genre")]
        public string[] Genre { get; set; }

        [JsonProperty(PropertyName = "artist")]
        public string[] Artists { get; set; }

        [JsonProperty(PropertyName = "artistid")]
        public int[] ArtistIds { get; set; }

        [JsonProperty(PropertyName = "displayartist")]
        public string Displayartist { get; set; }

        [JsonProperty(PropertyName = "genreid")]
        public int[] GenreId { get; set; }

        [JsonProperty(PropertyName = "musicbrainzalbumartistid")]
        public string MusicBrainzAlbumArtistId { get; set; }

        [JsonProperty(PropertyName = "musicbrainzalbumid")]
        public string MusicBrainzAlbumId { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }
    }
}