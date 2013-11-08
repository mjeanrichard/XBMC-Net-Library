using JeanRichard.Xbmc.Lib.JsonRpc;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List
{
    /// <jsonId>
    /// List.LimitsReturned
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "id": "List.LimitsReturned",
    ///  "properties": {
    ///    "end": {
    ///      "$ref": "List.Amount",
    ///      "default": -1
    ///    },
    ///    "start": {
    ///      "default": 0,
    ///      "minimum": 0,
    ///      "type": "integer"
    ///    },
    ///    "total": {
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public class LimitsReturned : JsonRpcItem
    {
        [JsonProperty(PropertyName = "end")]
        public int? End { get; set; }

        [JsonProperty(PropertyName = "start")]
        public int Start { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
    }
}