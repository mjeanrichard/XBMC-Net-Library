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
    /// GUI.Property.skin
    /// </jsonId>
    /// <json>
    /// {
    ///  "properties": {
    ///    "id": {
    ///      "minLength": 1,
    ///      "required": true,
    ///      "type": "string"
    ///    },
    ///    "name": {
    ///      "default": "",
    ///      "type": "string"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Skin : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private int _id;
        
        private string _name = "";
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="id")]
        public int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="name")]
        public string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Id = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<int>(json, "id");
            this.Name = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "name", "");
            this.ParseExtension(json);
        }
    }
}