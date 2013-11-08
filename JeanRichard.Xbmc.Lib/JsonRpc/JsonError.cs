using System;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JsonError : JsonRpcItem
    {
        public int Code { get; private set; }

        public string Data { get; private set; }

        public string Message { get; private set; }
    }
}