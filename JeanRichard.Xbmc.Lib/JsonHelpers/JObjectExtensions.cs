using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

using JeanRichard.Xbmc.Lib.JsonRpc;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonHelpers
{
    public static class JObjectExtensions
    {
        public static JToken GetItem(this JToken json)
        {
            return json["item"];
        }

        public static TEnumType ParseEnum<TEnumType>(this JToken json, string property)
        {
            return ParseEnum(json, property, default(TEnumType));
        }

        public static TEnumType ParseEnum<TEnumType>(this JToken json, string property, TEnumType defaultValue)
        {
            string enumValue = json.Value<string>(property);

            Type enumType = typeof(TEnumType);
            MemberInfo[] enumMembers = enumType.GetMembers();
            foreach (MemberInfo enumMember in enumMembers)
            {
                EnumMemberAttribute attribute = enumMember.GetCustomAttributes(typeof(EnumMemberAttribute), false).Cast<EnumMemberAttribute>().SingleOrDefault();
                if (attribute != null && attribute.Value.Equals(enumValue, StringComparison.OrdinalIgnoreCase))
                {
                    return (TEnumType)Enum.Parse(enumType, enumMember.Name);
                }
            }
            return defaultValue;
        }

        public static TReturn ParseJsonObject<TReturn>(this JToken json, string property) where TReturn : JsonRpcItem, new()
        {
            if (json == null)
            {
                return null;
            }
            JToken selectToken = json.SelectToken(property);
            if (selectToken == null)
            {
                return null;
            }
            return JsonRpcItem.LoadFrom<TReturn>(selectToken);
        }

        public static TArrayType[] ParseJsonObjectArray<TArrayType>(this JToken json, string property) where TArrayType : JsonRpcItem, new()
        {
            JToken selectToken = json.SelectToken(property);
            if (selectToken == null)
            {
                return null;
            }
            return ParseJsonObjectArray<TArrayType>(selectToken);
        }

        public static TArrayType[] ParseJsonObjectArray<TArrayType>(this JToken json) where TArrayType : JsonRpcItem, new()
        {
            return ParseJsonObjectArray(json, JsonRpcItem.LoadFrom<TArrayType>);
        }

        public static TArrayType[] ParseJsonObjectArray<TArrayType>(this JToken json, Func<JToken, TArrayType> parser) where TArrayType : JsonRpcItem, new()
        {
            if (json == null)
            {
                return new TArrayType[0];
            }
            if (json.Type != JTokenType.Array)
            {
                throw new InvalidOperationException();
            }

            JArray array = (JArray)json;
            return array.Select(parser).ToArray();
        }

        public static TReturn ParseSimpleValue<TReturn>(this JToken json, string property, TReturn defaultValue)
        {
            if (json == null)
            {
                return defaultValue;
            }
            JToken selectToken = json.SelectToken(property);
            if (selectToken == null)
            {
                return defaultValue;
            }
            return selectToken.Value<TReturn>();
        }

        public static TReturn ParseSimpleValue<TReturn>(this JToken json, string property)
        {
            if (json == null)
            {
                return default(TReturn);
            }
            return property == null ? json.Value<TReturn>() : json.Value<TReturn>(property);
        }

        public static TReturn ParseSimpleValue<TReturn>(this JToken json)
        {
            return ParseSimpleValue<TReturn>(json, null);
        }
    }
}