using System.Runtime.Serialization;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player
{
    /// <jsonId>
    /// Player.Type
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "video",
    ///  "enums": [
    ///    "video",
    ///    "audio",
    ///    "picture"
    ///  ],
    ///  "id": "Player.Type",
    ///  "type": "string"
    ///}
    /// </json>
    public enum PlayerTypes : long
    {
        [EnumMember(Value = "video")] Video,

        [EnumMember(Value = "audio")] Audio,

        [EnumMember(Value = "picture")] Picture,
    }
}