using JeanRichard.Xbmc.Lib.JsonCoverters;
using JeanRichard.Xbmc.Lib.XbmcEntities.Item;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Media
{
    /// <jsonId>
    /// Media.Details.Base
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Item.Details.Base",
    ///  "id": "Media.Details.Base",
    ///  "properties": {
    ///    "fanart": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "thumbnail": {
    ///      "default": "",
    ///      "type": "string"
    ///    }
    ///  }
    ///}
    /// </json>
    public abstract class MediaDetailsBase : XbmcItemBase
    {
        [JsonProperty(PropertyName = "id")]
        public abstract int? Id { get; set; }

        [JsonProperty(PropertyName = "fanart")]
        public string FanArt { get; set; }

        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }
    }
}