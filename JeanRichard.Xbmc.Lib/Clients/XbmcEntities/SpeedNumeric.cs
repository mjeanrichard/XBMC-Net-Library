using System;

using JeanRichard.Xbmc.Lib.JsonCoverters;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    [IntegralEnum]
    public enum SpeedNumeric
    {
        Slow6 = -32,
        Slow5 = -16,
        Slow4 = -8,
        Slow3 = -4,
        Slow2 = -2,
        Slow1 = -1,
        Pause = 0,
        Normal = 1,
        Fast1 = 2,
        Fast2 = 4,
        Fast3 = 8,
        Fast4 = 16,
        Fast5 = 32,
    }
}