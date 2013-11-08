

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// List.order
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "ascending",
    ///  "enums": [
    ///    "ascending",
    ///    "descending"
    ///  ],
    ///  "type": "string"
    ///}
    /// </json>
    public enum Orders : long {
        
        [System.Runtime.Serialization.EnumMember(Value="ascending")]
        Ascending,
        
        [System.Runtime.Serialization.EnumMember(Value="descending")]
        Descending,
    }
}
