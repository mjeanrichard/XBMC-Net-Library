//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player.Notifications {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Player.Notifications.Player
    /// </jsonId>
    /// <json>
    /// {
    ///  "id": "Player.Notifications.Player",
    ///  "properties": {
    ///    "playerid": {
    ///      "$ref": "Player.Id",
    ///      "required": true
    ///    },
    ///    "speed": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Player : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private System.Nullable<int> _playerId = -1;
        
        private System.Nullable<int> _speed = 0;
        
        /// <remarks>Minimum: '0'  Maximum: '0'  Default: '-1'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="playerid")]
        public System.Nullable<int> PlayerId {
            get {
                return this._playerId;
            }
            set {
                this._playerId = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="speed")]
        public System.Nullable<int> Speed {
            get {
                return this._speed;
            }
            set {
                this._speed = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.PlayerId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "playerid", -1);
            this.Speed = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "speed", 0);
        }
    }
}
