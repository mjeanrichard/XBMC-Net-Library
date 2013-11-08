using JeanRichard.Xbmc.Lib.JsonRpc;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List
{
    /// <jsonId>
    /// List.Limits
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "id": "List.Limits",
    ///  "properties": {
    ///    "end": {
    ///      "$ref": "List.Amount",
    ///      "default": -1,
    ///      "description": "Index of the last item to return"
    ///    },
    ///    "start": {
    ///      "default": 0,
    ///      "description": "Index of the first item to return",
    ///      "minimum": 0,
    ///      "type": "integer"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public class Limits : JsonRpcItem
    {
        [JsonProperty(PropertyName = "end")]
        public int? End { get; set; }

        /// <summary>
        /// Index of the first item to return
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int Start { get; set; }
    }
}