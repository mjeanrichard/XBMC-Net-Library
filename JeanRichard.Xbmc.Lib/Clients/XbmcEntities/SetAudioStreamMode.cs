using System;
using System.Runtime.Serialization;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public enum SetAudioStreamMode
    {
        [EnumMember(Value = "next")]
        Next,

        [EnumMember(Value = "previous")]
        Previous
    }
}