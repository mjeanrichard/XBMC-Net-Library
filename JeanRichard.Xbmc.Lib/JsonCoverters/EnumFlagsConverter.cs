using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JeanRichard.Xbmc.Lib.JsonCoverters
{
    [AttributeUsage(AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    internal sealed class IntegralEnumAttribute : Attribute
    {}

    public class EnumFlagsConverter : StringEnumConverter
    {
        private static IEnumerable<Enum> GetEnumValues(Type enumerationType)
        {
            if (!enumerationType.IsEnum)
            {
                throw new ArgumentException("enumerationType");
            }

            foreach (FieldInfo fieldInfo in enumerationType.GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                yield return (Enum)fieldInfo.GetValue(enumerationType);
            }
        }

        private static bool HasFlag(Enum variable, Enum value)
        {
            if (variable == null)
            {
                return false;
            }

            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            ulong num = Convert.ToUInt64(value);
            return ((Convert.ToUInt64(variable) & num) == num);
        }

        private static bool IsFlagsEnum(Type enumType)
        {
            return enumType.GetCustomAttributes(typeof(FlagsAttribute), true).Any();
        }

        private static bool IsIntegralEnum(Type enumType)
        {
            return enumType.GetCustomAttributes(typeof(IntegralEnumAttribute), true).Any();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var isFlagsEnum = IsFlagsEnum(objectType);
            if (isFlagsEnum && reader.TokenType == JsonToken.StartArray)
            {
                int newValue = 0;
                while (reader.Read())
                {
                    if (reader.TokenType != JsonToken.EndArray)
                    {
                        Enum enumValue = (Enum)base.ReadJson(reader, objectType, existingValue, serializer);
                        int value = Convert.ToInt32(enumValue);
                        newValue |= value;
                    }
                    else
                    {
                        break;
                    }
                }
                return newValue;
            }
            return base.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                Enum e = (Enum)value;
                Type enumType = value.GetType();

                if (IsFlagsEnum(enumType))
                {
                    writer.WriteStartArray();

                    foreach (Enum enumValue in GetEnumValues(enumType))
                    {
                        MemberInfo enumInfo = enumType.GetMember(enumValue.ToString()).Single();
                        bool isIgnored = enumInfo.GetCustomAttributes(typeof(JsonIgnoreAttribute), false).Length > 0;

                        if (!isIgnored && (HasFlag(e, enumValue)))
                        {
                            base.WriteJson(writer, enumValue, serializer);
                        }
                    }
                    writer.WriteEndArray();
                }
                else if (IsIntegralEnum(enumType))
                {
                    writer.WriteValue((int)value);
                }
                else
                {
                    base.WriteJson(writer, value, serializer);
                }
            }
        }
    }
}