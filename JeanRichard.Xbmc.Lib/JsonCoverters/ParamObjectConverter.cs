using System;

using JeanRichard.Xbmc.Lib.JsonRpc;

using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.JsonCoverters
{
    public class ParamObjectConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(JsonParamObject);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JsonParamObject jsonParamObject = (JsonParamObject)value;

            writer.WriteStartObject();
            foreach (JsonParam jsonParam in jsonParamObject.Parameters)
            {
                writer.WritePropertyName(jsonParam.Name);
                serializer.Serialize(writer, jsonParam.Value);
            }
            writer.WriteEndObject();
        }
    }
}