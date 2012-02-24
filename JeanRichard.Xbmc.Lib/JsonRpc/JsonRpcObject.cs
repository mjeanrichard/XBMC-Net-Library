using System;

using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JsonRpcObject
    {
        public JsonRpcObject(int id)
        {
            Id = id;
            JsonRpc = "2.0";
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "jsonrpc")]
        public string JsonRpc { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}