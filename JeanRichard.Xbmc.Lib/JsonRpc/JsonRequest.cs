using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.JsonCoverters;

using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JsonRequest : JsonRpcObject
    {
        public JsonRequest(int id, string method, IEnumerable<JsonParam> parameters)
            : base(id)
        {
            Method = method;
            Parameters = parameters;
        }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "params", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParamConverter))]
        public IEnumerable<JsonParam> Parameters { get; set; }
    }
}