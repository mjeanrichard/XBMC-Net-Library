//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.PVR.Details.Channelgroup {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// PVR.Details.ChannelGroup.Extended
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "PVR.Details.ChannelGroup",
    ///  "id": "PVR.Details.ChannelGroup.Extended",
    ///  "properties": {
    ///    "channels": {
    ///      "items": {
    ///        "$ref": "PVR.Details.Channel"
    ///      },
    ///      "type": "array"
    ///    },
    ///    "limits": {
    ///      "$ref": "List.LimitsReturned",
    ///      "required": true
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class Extended : JeanRichard.Xbmc.Lib.XbmcEntities.PVR.Details.Channelgroup {
        
        private PVR.Details.Channel[] _channels;
        
        private List.LimitsReturned _limits;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="channels")]
        public PVR.Details.Channel[] Channels {
            get {
                return this._channels;
            }
            set {
                this._channels = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="limits")]
        public List.LimitsReturned Limits {
            get {
                return this._limits;
            }
            set {
                this._limits = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Channels = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObjectArray<PVR.Details.Channel>(json, "channels");
            this.Limits = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObject<List.LimitsReturned>(json, "limits");
            this.ParseExtension(json);
        }
    }
}
