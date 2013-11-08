using System;
using JeanRichard.Xbmc.Lib.JsonRpc;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public class XbmcPlayer : JsonRpcItem
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}