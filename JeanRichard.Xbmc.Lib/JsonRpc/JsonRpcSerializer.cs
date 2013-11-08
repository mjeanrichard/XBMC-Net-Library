using System;
using System.IO;
using System.Text;

using JeanRichard.Xbmc.Lib.JsonCoverters;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    public class JsonRpcSerializer
    {
        private readonly JsonSerializerSettings _serializerSettings;
        private JsonSerializer _jsonSerializer;

        public JsonRpcSerializer()
        {
            _serializerSettings = new JsonSerializerSettings();

            _serializerSettings.Converters.Add(new EnumFlagsConverter());
            _serializerSettings.Converters.Add(new ParamConverter());
            _serializerSettings.Converters.Add(new XbmcFlagsConverter());
            _serializerSettings.Converters.Add(new ParamObjectConverter());
            _serializerSettings.Converters.Add(new MediaDetailsBaseConverter());

            _serializerSettings.NullValueHandling = NullValueHandling.Ignore;

            _jsonSerializer = JsonSerializer.Create(_serializerSettings);
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

        public T Parse<T>(JToken json, string propertyName)
        {
            JToken token = json;
            if (!string.IsNullOrWhiteSpace(propertyName) && json != null)
            {
                token = json.SelectToken(propertyName);
            }
            if (token == null)
            {
                return default(T);
            }

            T entity = token.ToObject<T>(_jsonSerializer);
            return entity;
        }

        public TItem Parse<TItem>(JToken json)
        {
            return Parse<TItem>(json, null);
        }

    }
}