//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Video {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Video.Streams
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "id": "Video.Streams",
    ///  "properties": {
    ///    "audio": {
    ///      "items": {
    ///        "additionalProperties": false,
    ///        "properties": {
    ///          "channels": {
    ///            "default": 0,
    ///            "type": "integer"
    ///          },
    ///          "codec": {
    ///            "default": "",
    ///            "type": "string"
    ///          },
    ///          "language": {
    ///            "default": "",
    ///            "type": "string"
    ///          }
    ///        },
    ///        "type": "object"
    ///      },
    ///      "minItems": 1,
    ///      "type": "array"
    ///    },
    ///    "subtitle": {
    ///      "items": {
    ///        "additionalProperties": false,
    ///        "properties": {
    ///          "language": {
    ///            "default": "",
    ///            "type": "string"
    ///          }
    ///        },
    ///        "type": "object"
    ///      },
    ///      "minItems": 1,
    ///      "type": "array"
    ///    },
    ///    "video": {
    ///      "items": {
    ///        "additionalProperties": false,
    ///        "properties": {
    ///          "aspect": {
    ///            "default": 0,
    ///            "type": "number"
    ///          },
    ///          "codec": {
    ///            "default": "",
    ///            "type": "string"
    ///          },
    ///          "duration": {
    ///            "default": 0,
    ///            "type": "integer"
    ///          },
    ///          "height": {
    ///            "default": 0,
    ///            "type": "integer"
    ///          },
    ///          "width": {
    ///            "default": 0,
    ///            "type": "integer"
    ///          }
    ///        },
    ///        "type": "object"
    ///      },
    ///      "minItems": 1,
    ///      "type": "array"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Streams : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private Video.Audio[] _audio;
        
        private Video.Subtitle[] _subtitle;
        
        private Video.Video[] _video;
        
        [Newtonsoft.Json.JsonProperty(PropertyName="audio")]
        public Video.Audio[] Audio {
            get {
                return this._audio;
            }
            set {
                this._audio = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="subtitle")]
        public Video.Subtitle[] Subtitle {
            get {
                return this._subtitle;
            }
            set {
                this._subtitle = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="video")]
        public Video.Video[] Video {
            get {
                return this._video;
            }
            set {
                this._video = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Audio = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObjectArray<Video.Audio>(json, "audio");
            this.Subtitle = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObjectArray<Video.Subtitle>(json, "subtitle");
            this.Video = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObjectArray<Video.Video>(json, "video");
        }
    }
}