using System.Collections.Generic;
using System.Linq;
using JeanRichard.Xbmc.Lib.JsonCoverters;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    [JsonConverter(typeof (ItemListConverter))]
    public class XbmcItemList<TMedia> : JsonRpcItem, IMediaItemList<TMedia>
    {
        public XbmcItemList(IEnumerable<TMedia> items, LimitsReturned limit)
        {
            Items = items ?? Enumerable.Empty<TMedia>();
            Limit = limit;
        }

        public IEnumerable<TMedia> Items { get; private set; }
        public LimitsReturned Limit { get; private set; }
    }
}