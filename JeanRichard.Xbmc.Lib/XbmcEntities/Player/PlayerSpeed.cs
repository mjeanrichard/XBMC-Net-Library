using JeanRichard.Xbmc.Lib.JsonRpc;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player
{
    /// <jsonId>
    /// Player.Speed
    /// </jsonId>
    /// <json>
    /// {
    ///  "id": "Player.Speed",
    ///  "properties": {
    ///    "speed": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    }
    ///  },
    ///  "required": true,
    ///  "type": "object"
    ///}
    /// </json>
    public class PlayerSpeed : JsonRpcItem
    {
        /// <remarks>Default: '0'</remarks>
        [JsonProperty(PropertyName = "speed")]
        public int Speed { get; set; }
    }
}