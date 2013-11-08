using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details
{
    /// <jsonId>
    /// Audio.Details.Artist
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Audio.Details.Base",
    ///  "id": "Audio.Details.Artist",
    ///  "properties": {
    ///    "artist": {
    ///      "required": true,
    ///      "type": "string"
    ///    },
    ///    "artistid": {
    ///      "$ref": "Library.Id",
    ///      "required": true
    ///    },
    ///    "born": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "description": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "died": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "disbanded": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "formed": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "instrument": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "mood": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "musicbrainzartistid": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "style": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "yearsactive": {
    ///      "$ref": "Array.String"
    ///    }
    ///  }
    ///}
    /// </json>
    public class Artist : AudioMedia
    {
        public override int? Id
        {
            get { return ArtistId; }
            set { ArtistId = value; }
        }

        [JsonProperty(PropertyName = "artist")]
        public string ArtistName { get; set; }

        [JsonProperty(PropertyName = "artistid")]
        public int? ArtistId { get; set; }

        [JsonProperty(PropertyName = "born")]
        public string Born { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "died")]
        public string Died { get; set; }

        [JsonProperty(PropertyName = "disbanded")]
        public string Disbanded { get; set; }

        [JsonProperty(PropertyName = "formed")]
        public string Formed { get; set; }

        [JsonProperty(PropertyName = "instrument")]
        public string[] Instrument { get; set; }

        [JsonProperty(PropertyName = "mood")]
        public string[] Mood { get; set; }

        [JsonProperty(PropertyName = "musicbrainzartistid")]
        public string MusicBrainzArtistId { get; set; }

        [JsonProperty(PropertyName = "style")]
        public string[] Style { get; set; }

        [JsonProperty(PropertyName = "yearsactive")]
        public string[] Yearsactive { get; set; }
    }
}