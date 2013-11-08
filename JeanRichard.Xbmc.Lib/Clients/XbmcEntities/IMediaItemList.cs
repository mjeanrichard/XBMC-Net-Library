using System.Collections.Generic;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public interface IMediaItemList<out TMedia>
    {
        IEnumerable<TMedia> Items { get; }
        LimitsReturned Limit { get; }
    }
}