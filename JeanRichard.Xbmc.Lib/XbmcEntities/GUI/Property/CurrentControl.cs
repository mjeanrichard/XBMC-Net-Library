//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.GUI.Property {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// GUI.Property.currentcontrol
    /// </jsonId>
    /// <json>
    /// {
    ///  "properties": {
    ///    "label": {
    ///      "required": true,
    ///      "type": "string"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class CurrentControl : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private string _label;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="label")]
        public string Label {
            get {
                return this._label;
            }
            set {
                this._label = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Label = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "label");
            this.ParseExtension(json);
        }
    }
}
