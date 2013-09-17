using System;
using System.IO;
using System.Text;

using JeanRichard.Xbmc.Lib.JsonCoverters;

using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    public class JsonRpcSerializer
    {
        private readonly JsonSerializerSettings _serializerSettings;

        public JsonRpcSerializer()
        {
            _serializerSettings = new JsonSerializerSettings();

            _serializerSettings.Converters.Add(new EnumFlagsConverter());
            _serializerSettings.Converters.Add(new ParamConverter());
            _serializerSettings.Converters.Add(new XbmcFlagsConverter());
            _serializerSettings.Converters.Add(new ParamObjectConverter());

            _serializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        public void Serialize<T>(T request, Stream stream) where T : JsonRpcObject
        {
            string jsonData = JsonConvert.SerializeObject(request, Formatting.Indented, _serializerSettings);
            byte[] buffer = Encoding.UTF8.GetBytes(jsonData);
            stream.Write(buffer, 0, buffer.Length);
        }

        public string Serialize<T>(T request) where T : JsonRpcObject
        {
            string jsonData = JsonConvert.SerializeObject(request, Formatting.Indented, _serializerSettings);
            return jsonData;
        }
    }
}