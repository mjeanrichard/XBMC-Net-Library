using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.JsonRpc;

using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.JsonCoverters
{
    public class ParamConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IEnumerable<JsonParam>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            IEnumerable<JsonParam> jsonParams = (IEnumerable<JsonParam>)value;

            writer.WriteStartObject();
            foreach (JsonParam jsonParam in jsonParams)
            {
                writer.WritePropertyName(jsonParam.Name);
                serializer.Serialize(writer, jsonParam.Value);
            }
            writer.WriteEndObject();
        }
    }
}