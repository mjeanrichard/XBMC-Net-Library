using System;
using System.Runtime.Serialization;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public enum SpeedChange
    {
        [EnumMember(Value = "increment")]
        Increase,

        [EnumMember(Value = "decrement")]
        Decrease
    }
}