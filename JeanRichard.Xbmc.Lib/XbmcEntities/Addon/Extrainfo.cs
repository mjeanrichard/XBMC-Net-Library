//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Addon {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Addon.extrainfo
    /// </jsonId>
    /// <json>
    /// {
    ///  "properties": {
    ///    "key": {
    ///      "required": true,
    ///      "type": "string"
    ///    },
    ///    "value": {
    ///      "required": true,
    ///      "type": "string"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Extrainfo : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private string _key;
        
        private string _value;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="key")]
        public string Key {
            get {
                return this._key;
            }
            set {
                this._key = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="value")]
        public string Value {
            get {
                return this._value;
            }
            set {
                this._value = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Key = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "key");
            this.Value = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "value");
            this.ParseExtension(json);
        }
    }
}
