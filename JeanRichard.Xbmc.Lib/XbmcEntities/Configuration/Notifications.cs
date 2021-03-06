//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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
    ///    "application": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "audiolibrary": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "gui": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "input": {
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
    ///    "playlist": {
    ///      "required": true,
    ///      "type": "boolean"
    ///    },
    ///    "pvr": {
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
        
        private bool _application;
        
        private bool _audioLibrary;
        
        private bool _gui;
        
        private bool _input;
        
        private bool _other;
        
        private bool _player;
        
        private bool _playlist;
        
        private bool _pvr;
        
        private bool _system;
        
        private bool _videoLibrary;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="application")]
        public bool Application {
            get {
                return this._application;
            }
            set {
                this._application = value;
            }
        }
        
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
        
        [Newtonsoft.Json.JsonProperty(PropertyName="input")]
        public bool Input {
            get {
                return this._input;
            }
            set {
                this._input = value;
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
        
        [Newtonsoft.Json.JsonProperty(PropertyName="playlist")]
        public bool Playlist {
            get {
                return this._playlist;
            }
            set {
                this._playlist = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="pvr")]
        public bool Pvr {
            get {
                return this._pvr;
            }
            set {
                this._pvr = value;
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
            this.Application = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "application");
            this.AudioLibrary = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "audiolibrary");
            this.Gui = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "gui");
            this.Input = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "input");
            this.Other = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "other");
            this.Player = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "player");
            this.Playlist = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "playlist");
            this.Pvr = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "pvr");
            this.System = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "system");
            this.VideoLibrary = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<bool>(json, "videolibrary");
            this.ParseExtension(json);
        }
    }
}
