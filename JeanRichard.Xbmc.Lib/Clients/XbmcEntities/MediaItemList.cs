using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public class MediaItemList<TMedia> : JsonRpcItem where TMedia : MediaDetailsBase, new()
    {
        public MediaItemList(IEnumerable<TMedia> items, LimitsReturned limit)
        {
            Items = items;
            Limit = limit;
        }

        public MediaItemList()
        {}

        public IEnumerable<TMedia> Items { get; private set; }
        public LimitsReturned Limit { get; private set; }

        protected override void Parse(JToken json)
        {
            base.Parse(json);

            foreach (JProperty property in json.Children<JProperty>())
            {
                if (!property.Name.Equals("limits", StringComparison.OrdinalIgnoreCase))
                {
                    Items = json.ParseJsonObjectArray<TMedia>(property.Name);
                    break;
                }
            }
            Limit = json.ParseJsonObject<LimitsReturned>("limits");
        }
    }
}