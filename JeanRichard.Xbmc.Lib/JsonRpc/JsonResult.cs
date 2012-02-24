using System;

using JeanRichard.Xbmc.Lib.JsonHelpers;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JsonResult : JsonRpcItem
    {
        public static JsonResult LoadFrom(JToken json)
        {
            JsonResult result = new JsonResult();
            result.Parse(json);
            return result;
        }

        public JsonError Error { get; set; }

        public JToken Result { get; set; }

        protected override void Parse(JToken json)
        {
            Result = json["result"];
            Error = json.ParseJsonObject<JsonError>("error");
        }
    }
}