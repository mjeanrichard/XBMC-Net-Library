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
    /// Video.subtitle
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "properties": {
    ///    "language": {
    ///      "default": "",
    ///      "type": "string"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Subtitle : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private string _language = "";
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="language")]
        public string Language {
            get {
                return this._language;
            }
            set {
                this._language = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Language = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "language", "");
            this.ParseExtension(json);
        }
    }
}
