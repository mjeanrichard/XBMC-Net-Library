//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Player.Audio {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Player.Audio.Stream.Extended
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Player.Audio.Stream",
    ///  "id": "Player.Audio.Stream.Extended",
    ///  "properties": {
    ///    "bitrate": {
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "channels": {
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "codec": {
    ///      "required": true,
    ///      "type": "string"
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class ExtendedAudioStream : JeanRichard.Xbmc.Lib.XbmcEntities.Player.Audio.AudioStream {
        
        private int _bitrate;
        
        private int _channels;
        
        private string _codec;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="bitrate")]
        public int Bitrate {
            get {
                return this._bitrate;
            }
            set {
                this._bitrate = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="channels")]
        public int Channels {
            get {
                return this._channels;
            }
            set {
                this._channels = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="codec")]
        public string Codec {
            get {
                return this._codec;
            }
            set {
                this._codec = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Bitrate = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<int>(json, "bitrate");
            this.Channels = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<int>(json, "channels");
            this.Codec = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "codec");
            this.ParseExtension(json);
        }
    }
}
