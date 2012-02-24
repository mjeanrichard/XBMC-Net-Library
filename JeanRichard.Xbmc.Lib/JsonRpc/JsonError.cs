using System;

using JeanRichard.Xbmc.Lib.JsonHelpers;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JsonError : JsonRpcItem
    {
        public int Code { get; private set; }

        public string Data { get; private set; }

        public string Message { get; private set; }

        protected override void Parse(JToken json)
        {
            Code = json.ParseSimpleValue<int>("code");
            Message = json.ParseSimpleValue<string>("message");
            JToken dataToken = json.SelectToken("data");
            if (dataToken != null)
            {
                Data = dataToken.ToString();
            }
        }
    }
}