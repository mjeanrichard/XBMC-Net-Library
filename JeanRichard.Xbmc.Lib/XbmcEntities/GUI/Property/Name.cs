//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.GUI.Property {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// GUI.Property.Name
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "currentwindow",
    ///  "enums": [
    ///    "currentwindow",
    ///    "currentcontrol",
    ///    "skin",
    ///    "fullscreen"
    ///  ],
    ///  "id": "GUI.Property.Name",
    ///  "type": "string"
    ///}
    /// </json>
    public enum Name : long {
        
        [System.Runtime.Serialization.EnumMember(Value="currentwindow")]
        CurrentWindow,
        
        [System.Runtime.Serialization.EnumMember(Value="currentcontrol")]
        CurrentControl,
        
        [System.Runtime.Serialization.EnumMember(Value="skin")]
        Skin,
        
        [System.Runtime.Serialization.EnumMember(Value="fullscreen")]
        FullScreen,
    }
}