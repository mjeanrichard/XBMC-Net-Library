using System;
using System.Runtime.Serialization;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public enum SubtitleMode
    {
        [EnumMember(Value = "previous")]
        Previous,

        [EnumMember(Value = "next")]
        Next,

        [EnumMember(Value = "off")]
        Off,

        [EnumMember(Value = "on")]
        On
    }
}