using JeanRichard.Xbmc.Lib.JsonRpc;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Global
{
    /// <jsonId>
    /// Global.Time
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "id": "Global.Time",
    ///  "properties": {
    ///    "hours": {
    ///      "maximum": 23,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "milliseconds": {
    ///      "maximum": 999,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "minutes": {
    ///      "maximum": 59,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "seconds": {
    ///      "maximum": 59,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public class Time : JsonRpcItem
    {
        [JsonProperty(PropertyName = "hours")]
        public int Hours { get; set; }

        [JsonProperty(PropertyName = "milliseconds")]
        public int Milliseconds { get; set; }

        [JsonProperty(PropertyName = "minutes")]
        public int Minutes { get; set; }

        [JsonProperty(PropertyName = "seconds")]
        public int Seconds { get; set; }
    }
}