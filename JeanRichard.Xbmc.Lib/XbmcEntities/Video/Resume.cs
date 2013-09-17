//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Video {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Video.Resume
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "id": "Video.Resume",
    ///  "properties": {
    ///    "position": {
    ///      "default": 0,
    ///      "minimum": 0,
    ///      "type": "number"
    ///    },
    ///    "total": {
    ///      "default": 0,
    ///      "minimum": 0,
    ///      "type": "number"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Resume : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private System.Nullable<decimal> _position = 0m;
        
        private System.Nullable<decimal> _total = 0m;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        /// <remarks>Minimum: '0'  Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="position")]
        public System.Nullable<decimal> Position {
            get {
                return this._position;
            }
            set {
                this._position = value;
            }
        }
        
        /// <remarks>Minimum: '0'  Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="total")]
        public System.Nullable<decimal> Total {
            get {
                return this._total;
            }
            set {
                this._total = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Position = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<decimal>>(json, "position", 0m);
            this.Total = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<decimal>>(json, "total", 0m);
            this.ParseExtension(json);
        }
    }
}
