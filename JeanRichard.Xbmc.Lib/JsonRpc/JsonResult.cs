using System;
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
            result.Result = json.SelectToken("result");
            if (result.Result == null)
            {
                result.Error = json.Value<JsonError>("error");
            }
            return result;
        }

        public JsonError Error { get; set; }

        public JToken Result { get; set; }
    }
}