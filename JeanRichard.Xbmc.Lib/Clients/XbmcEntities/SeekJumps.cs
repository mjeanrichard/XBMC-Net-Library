using System;
using System.Runtime.Serialization;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public enum SeekJumps
    {
        [EnumMember(Value = "smallforward")]
        SmallForward,

        [EnumMember(Value = "smallbackward")]
        SmallBackward,

        [EnumMember(Value = "bigforward")]
        BigForward,

        [EnumMember(Value = "bigbackward")]
        BigBackward
    }
}