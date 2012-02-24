using System;

using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    public class JsonRpcException : Exception
    {
        public JsonRpcException(int code, string message, JsonRpcItem jsonData)
            : base(message)
        {
            Code = code;
            JsonData = jsonData != null ? JsonConvert.SerializeObject(jsonData, Formatting.Indented) : "<null>";
        }

        public int Code { get; private set; }
        public string JsonData { get; set; }
    }
}