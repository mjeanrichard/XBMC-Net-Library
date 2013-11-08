using System;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Global;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public class PlayerPosition : JsonRpcItem
    {
        public decimal Percentage { get; set; }
        public Time Time { get; set; }
        public Time TotalTime { get; set; }
    }
}