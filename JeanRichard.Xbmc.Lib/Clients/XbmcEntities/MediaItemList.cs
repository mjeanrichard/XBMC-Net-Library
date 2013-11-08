using System.Collections.Generic;
using JeanRichard.Xbmc.Lib.JsonCoverters;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    [JsonConverter(typeof (ItemListConverter))]
    public class MediaItemList<TMedia> : JsonRpcItem, IMediaItemList<TMedia>
    {
        public MediaItemList(IEnumerable<TMedia> items, LimitsReturned limit)
        {
            Items = items;
            Limit = limit;
        }

        public IEnumerable<TMedia> Items { get; private set; }
        public LimitsReturned Limit { get; private set; }
    }
}