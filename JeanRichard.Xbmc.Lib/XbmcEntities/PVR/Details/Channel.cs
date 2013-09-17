//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.PVR.Details {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// PVR.Details.Channel
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Item.Details.Base",
    ///  "id": "PVR.Details.Channel",
    ///  "properties": {
    ///    "channel": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "channelid": {
    ///      "$ref": "Library.Id",
    ///      "required": true
    ///    },
    ///    "channeltype": {
    ///      "$ref": "PVR.Channel.Type",
    ///      "default": "tv"
    ///    },
    ///    "hidden": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "lastplayed": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "locked": {
    ///      "default": false,
    ///      "type": "boolean"
    ///    },
    ///    "thumbnail": {
    ///      "default": "",
    ///      "type": "string"
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class Channel : JeanRichard.Xbmc.Lib.XbmcEntities.Item.ItemDetailsBase {
        
        private string _channel = "";
        
        private System.Nullable<int> _channelid = -1;
        
        private PVR.Channel.Type _channeltype;
        
        private System.Nullable<bool> _hidden = false;
        
        private string _lastPlayed = "";
        
        private System.Nullable<bool> _locked = false;
        
        private string _thumbnail = "";
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="channel")]
        public string Channel {
            get {
                return this._channel;
            }
            set {
                this._channel = value;
            }
        }
        
        /// <remarks>Minimum: '1'  Default: '-1'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="channelid")]
        public System.Nullable<int> Channelid {
            get {
                return this._channelid;
            }
            set {
                this._channelid = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="channeltype")]
        public PVR.Channel.Type Channeltype {
            get {
                return this._channeltype;
            }
            set {
                this._channeltype = value;
            }
        }
        
        /// <remarks>Default: 'False'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="hidden")]
        public System.Nullable<bool> Hidden {
            get {
                return this._hidden;
            }
            set {
                this._hidden = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="lastplayed")]
        public string LastPlayed {
            get {
                return this._lastPlayed;
            }
            set {
                this._lastPlayed = value;
            }
        }
        
        /// <remarks>Default: 'False'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="locked")]
        public System.Nullable<bool> Locked {
            get {
                return this._locked;
            }
            set {
                this._locked = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="thumbnail")]
        public string Thumbnail {
            get {
                return this._thumbnail;
            }
            set {
                this._thumbnail = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Channel = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "channel", "");
            this.Channelid = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "channelid", -1);
            this.Channeltype = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseEnum<PVR.Channel.Type>(json, "channeltype", PVR.Channel.Type.TV);
            this.Hidden = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<bool>>(json, "hidden", false);
            this.LastPlayed = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "lastplayed", "");
            this.Locked = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<bool>>(json, "locked", false);
            this.Thumbnail = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "thumbnail", "");
            this.ParseExtension(json);
        }
    }
}