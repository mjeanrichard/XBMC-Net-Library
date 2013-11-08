using JeanRichard.Xbmc.Lib.JsonRpc;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List
{
    /// <jsonId>
    /// List.Sort
    /// </jsonId>
    /// <json>
    /// {
    ///  "id": "List.Sort",
    ///  "properties": {
    ///    "ignorearticle": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "method": {
    ///      "default": "none",
    ///      "enums": [
    ///        "none",
    ///        "label",
    ///        "date",
    ///        "size",
    ///        "file",
    ///        "path",
    ///        "drivetype",
    ///        "title",
    ///        "track",
    ///        "time",
    ///        "artist",
    ///        "album",
    ///        "albumtype",
    ///        "genre",
    ///        "country",
    ///        "year",
    ///        "rating",
    ///        "votes",
    ///        "top250",
    ///        "programcount",
    ///        "playlist",
    ///        "episode",
    ///        "season",
    ///        "totalepisodes",
    ///        "watchedepisodes",
    ///        "tvshowstatus",
    ///        "tvshowtitle",
    ///        "sorttitle",
    ///        "productioncode",
    ///        "mpaa",
    ///        "studio",
    ///        "dateadded",
    ///        "lastplayed",
    ///        "playcount",
    ///        "listeners",
    ///        "bitrate",
    ///        "random"
    ///      ],
    ///      "type": "string"
    ///    },
    ///    "order": {
    ///      "default": "ascending",
    ///      "enums": [
    ///        "ascending",
    ///        "descending"
    ///      ],
    ///      "type": "string"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public class Sort : JsonRpcItem
    {
        public Sort()
        {
            IgnoreArticle = false;
        }

        [JsonProperty(PropertyName = "ignorearticle")]
        public bool IgnoreArticle { get; set; }

        [JsonProperty(PropertyName = "method")]
        public SortMethods Method { get; set; }

        [JsonProperty(PropertyName = "order")]
        public Orders Order { get; set; }
    }
}