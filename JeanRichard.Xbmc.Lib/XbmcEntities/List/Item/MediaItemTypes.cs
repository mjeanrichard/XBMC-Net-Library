using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List.Item
{
    /// <jsonId>
    /// List.Item.type
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "unknown",
    ///  "enums": [
    ///    "unknown",
    ///    "movie",
    ///    "episode",
    ///    "musicvideo",
    ///    "song",
    ///    "picture",
    ///    "channel"
    ///  ],
    ///  "type": "string"
    ///}
    /// </json>
    public enum MediaItemTypes
    {
        [EnumMember(Value = "unknown")] Unknown,

        [EnumMember(Value = "movie")] Movie,

        [EnumMember(Value = "episode")] Episode,

        [EnumMember(Value = "musicvideo")] MusicVideo,

        [EnumMember(Value = "song")] Song,

        [EnumMember(Value = "picture")] Picture,

        [EnumMember(Value = "channel")] Channel,
    }
}