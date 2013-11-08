using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details
{
    /// <jsonId>
    /// Audio.Details.Album
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Audio.Details.Media",
    ///  "id": "Audio.Details.Album",
    ///  "properties": {
    ///    "albumid": {
    ///      "$ref": "Library.Id",
    ///      "required": true
    ///    },
    ///    "albumlabel": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "description": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "mood": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "playcount": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "style": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "theme": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "type": {
    ///      "default": "",
    ///      "type": "string"
    ///    }
    ///  }
    ///}
    /// </json>
    public class Album : AudioMedia
    {
        public override int? Id
        {
            get { return AlbumId; }
            set { AlbumId = value; }
        }

        [JsonProperty(PropertyName = "albumid")]
        public int? AlbumId { get; set; }

        [JsonProperty(PropertyName = "albumlabel")]
        public string AlbumLabel { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "mood")]
        public string[] Mood { get; set; }

        [JsonProperty(PropertyName = "playcount")]
        public int PlayCount { get; set; }

        [JsonProperty(PropertyName = "style")]
        public string[] Style { get; set; }

        [JsonProperty(PropertyName = "theme")]
        public string[] Theme { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}