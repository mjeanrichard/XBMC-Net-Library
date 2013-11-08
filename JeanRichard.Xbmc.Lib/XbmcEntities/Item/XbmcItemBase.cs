using JeanRichard.Xbmc.Lib.JsonRpc;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Item
{
    /// <jsonId>
    /// Item.Details.Base
    /// </jsonId>
    /// <json>
    /// {
    ///  "id": "Item.Details.Base",
    ///  "properties": {
    ///    "label": {
    ///      "required": true,
    ///      "type": "string"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public class XbmcItemBase : JsonRpcItem
    {
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}