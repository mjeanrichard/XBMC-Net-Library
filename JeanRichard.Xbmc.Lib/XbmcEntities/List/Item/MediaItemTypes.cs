//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List.Item {
    using System;
    using System.Runtime.Serialization;
    
    
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
    public enum MediaItemTypes : long {
        
        [System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        
        [System.Runtime.Serialization.EnumMember(Value="movie")]
        Movie,
        
        [System.Runtime.Serialization.EnumMember(Value="episode")]
        Episode,
        
        [System.Runtime.Serialization.EnumMember(Value="musicvideo")]
        MusicVideo,
        
        [System.Runtime.Serialization.EnumMember(Value="song")]
        Song,
        
        [System.Runtime.Serialization.EnumMember(Value="picture")]
        Picture,
        
        [System.Runtime.Serialization.EnumMember(Value="channel")]
        Channel,
    }
}
