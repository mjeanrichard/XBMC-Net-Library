using System;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    public abstract class JsonRpcItem
    {
        public static TItem LoadFrom<TItem>(JToken json, string propertyName) where TItem : JsonRpcItem, new()
        {
            JToken token = json;
            if (!string.IsNullOrWhiteSpace(propertyName) && json != null)
            {
                token = json.SelectToken(propertyName);
            }
            if (token == null)
            {
                return null;
            }

            TItem item = new TItem();
            item.Parse(token);
            return item;
        }

        public static TItem LoadFrom<TItem>(JToken json) where TItem : JsonRpcItem, new()
        {
            return LoadFrom<TItem>(json, null);
        }

        protected virtual void Parse(JToken json)
        {}
    }
}