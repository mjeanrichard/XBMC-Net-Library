//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player.Notifications.Player {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Player.Notifications.Player.Seek
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Player.Notifications.Player",
    ///  "id": "Player.Notifications.Player.Seek",
    ///  "properties": {
    ///    "seekoffset": {
    ///      "$ref": "Global.Time"
    ///    },
    ///    "time": {
    ///      "$ref": "Global.Time"
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class Seek : JeanRichard.Xbmc.Lib.XbmcEntities.Player.Notifications.Player {
        
        private Global.Time _seekoffset;
        
        private Global.Time _time;
        
        [Newtonsoft.Json.JsonProperty(PropertyName="seekoffset")]
        public Global.Time Seekoffset {
            get {
                return this._seekoffset;
            }
            set {
                this._seekoffset = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="time")]
        public Global.Time Time {
            get {
                return this._time;
            }
            set {
                this._time = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Seekoffset = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObject<Global.Time>(json, "seekoffset");
            this.Time = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObject<Global.Time>(json, "time");
        }
    }
}