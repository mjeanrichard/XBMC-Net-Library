

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List.Item {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// List.Item.filetype
    /// </jsonId>
    /// <json>
    /// {
    ///  "enums": [
    ///    "file",
    ///    "directory"
    ///  ],
    ///  "required": true,
    ///  "type": "string"
    ///}
    /// </json>
    public enum FileType : long {
        
        [System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        
        [System.Runtime.Serialization.EnumMember(Value="directory")]
        Directory,
    }
}
