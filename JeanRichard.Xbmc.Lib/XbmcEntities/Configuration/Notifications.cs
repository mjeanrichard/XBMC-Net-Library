//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Configuration {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Configuration.Notifications
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "id": "Configuration.Notifications",
    ///  "properties": {
    ///    "audiolibrary": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "gui": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "other": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "player": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "system": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "videolibrary": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Notifications : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private bool _audioLibrary;
        
        private bool _gui;
        
        private bool _other;
        
        private bool _player;
        
        private bool _system;
        
        private bool _videoLibrary;
        
        [Newtonsoft.Json.JsonProperty(PropertyName="audiolibrary")]
        public bool AudioLibrary {
            get {
                return this._audioLibrary;
            }
            set {
                this._audioLibrary = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="gui")]
        public bool Gui {
            get {
                return this._gui;
            }
            set {
                this._gui = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="other")]
        public bool Other {
            get {
                return this._other;
            }
            set {
                this._other = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="player")]
        public bool Player {
            get {
                return this._player;
            }
            set {
                this._player = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="system")]
        public bool System {
            get {
                return this._system;
            }
            set {
                this._system = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="videolibrary")]
        public bool VideoLibrary {
            get {
                return this._videoLibrary;
            }
            set {
                this._videoLibrary = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.AudioLibrary = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "audiolibrary");
            this.Gui = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "gui");
            this.Other = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "other");
            this.Player = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "player");
            this.System = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "system");
            this.VideoLibrary = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "videolibrary");
        }
    }
}
