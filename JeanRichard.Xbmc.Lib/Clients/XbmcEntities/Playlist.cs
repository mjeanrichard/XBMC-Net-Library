using System;

using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public class Playlist : JsonRpcItem
    {
        public int Id { get; set; }
        public string Type { get; set; }

        protected override void Parse(JToken json)
        {
            Type = json.ParseSimpleValue<string>("type");
            Id = json.ParseSimpleValue<int>("playlistid");
        }
    }
}