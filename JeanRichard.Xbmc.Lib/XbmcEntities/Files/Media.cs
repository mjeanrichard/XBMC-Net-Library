//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Files {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Files.Media
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "video",
    ///  "enums": [
    ///    "video",
    ///    "music",
    ///    "pictures",
    ///    "files",
    ///    "programs"
    ///  ],
    ///  "id": "Files.Media",
    ///  "type": "string"
    ///}
    /// </json>
    public enum Media : long {
        
        [System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
        
        [System.Runtime.Serialization.EnumMember(Value="music")]
        Music,
        
        [System.Runtime.Serialization.EnumMember(Value="pictures")]
        Pictures,
        
        [System.Runtime.Serialization.EnumMember(Value="files")]
        Files,
        
        [System.Runtime.Serialization.EnumMember(Value="programs")]
        Programs,
    }
}
