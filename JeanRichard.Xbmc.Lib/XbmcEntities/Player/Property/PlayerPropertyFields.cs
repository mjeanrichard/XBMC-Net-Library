using System.Runtime.Serialization;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player.Property
{
    /// <jsonId>
    /// Player.Property.Name
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "type",
    ///  "enums": [
    ///    "type",
    ///    "partymode",
    ///    "speed",
    ///    "time",
    ///    "percentage",
    ///    "totaltime",
    ///    "playlistid",
    ///    "position",
    ///    "repeat",
    ///    "shuffled",
    ///    "canseek",
    ///    "canchangespeed",
    ///    "canmove",
    ///    "canzoom",
    ///    "canrotate",
    ///    "canshuffle",
    ///    "canrepeat",
    ///    "currentaudiostream",
    ///    "audiostreams",
    ///    "subtitleenabled",
    ///    "currentsubtitle",
    ///    "subtitles",
    ///    "live"
    ///  ],
    ///  "id": "Player.Property.Name",
    ///  "type": "string"
    ///}
    /// </json>
    public enum PlayerPropertyFields : long
    {
        [EnumMember(Value = "type")] Type,

        [EnumMember(Value = "partymode")] Partymode,

        [EnumMember(Value = "speed")] Speed,

        [EnumMember(Value = "time")] Time,

        [EnumMember(Value = "percentage")] Percentage,

        [EnumMember(Value = "totaltime")] TotalTime,

        [EnumMember(Value = "playlistid")] PlaylistId,

        [EnumMember(Value = "position")] Position,

        [EnumMember(Value = "repeat")] Repeat,

        [EnumMember(Value = "shuffled")] Shuffled,

        [EnumMember(Value = "canseek")] CanSeek,

        [EnumMember(Value = "canchangespeed")] CanChangespeed,

        [EnumMember(Value = "canmove")] CanMove,

        [EnumMember(Value = "canzoom")] CanZoom,

        [EnumMember(Value = "canrotate")] CanRotate,

        [EnumMember(Value = "canshuffle")] CanShuffle,

        [EnumMember(Value = "canrepeat")] CanRepeat,

        [EnumMember(Value = "currentaudiostream")] CurrentAudioStream,

        [EnumMember(Value = "audiostreams")] AudioStreams,

        [EnumMember(Value = "subtitleenabled")] SubtitleEnabled,

        [EnumMember(Value = "currentsubtitle")] CurrentSubtitle,

        [EnumMember(Value = "subtitles")] SubtitleS,

        [EnumMember(Value = "live")] Live,
    }
}