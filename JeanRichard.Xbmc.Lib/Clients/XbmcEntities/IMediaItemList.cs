using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public interface IMediaItemList<out TMedia> where TMedia : MediaDetailsBase, new()
    {
        IEnumerable<TMedia> Items { get; }
        LimitsReturned Limit { get; }
    }
}