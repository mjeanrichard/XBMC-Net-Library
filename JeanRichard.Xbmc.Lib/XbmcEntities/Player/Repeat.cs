using System.Runtime.Serialization;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player
{
    /// <jsonId>
    /// Player.Repeat
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "off",
    ///  "enums": [
    ///    "off",
    ///    "one",
    ///    "all"
    ///  ],
    ///  "id": "Player.Repeat",
    ///  "type": "string"
    ///}
    /// </json>
    public enum Repeat : long
    {
        [EnumMember(Value = "off")] Off,

        [EnumMember(Value = "one")] One,

        [EnumMember(Value = "all")] All,
    }
}