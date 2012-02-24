using System;

using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Global;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients.XbmcEntities
{
    public class PlayerPosition : JsonRpcItem
    {
        public static PlayerPosition LoadFrom(JToken json)
        {
            PlayerPosition player = new PlayerPosition();
            player.Parse(json);
            return player;
        }

        public decimal Percentage { get; set; }
        public Time Time { get; set; }
        public Time TotalTime { get; set; }

        protected override void Parse(JToken json)
        {
            Percentage = json.ParseSimpleValue<decimal>("percentage");
            TotalTime = json.ParseJsonObject<Time>("totaltime");
            Time = json.ParseJsonObject<Time>("time");
        }
    }
}