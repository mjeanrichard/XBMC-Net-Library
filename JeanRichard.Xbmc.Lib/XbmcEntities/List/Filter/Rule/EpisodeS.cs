//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List.Filter.Rule {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// List.Filter.Rule.Episodes
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "List.Filter.Rule",
    ///  "id": "List.Filter.Rule.Episodes",
    ///  "properties": {
    ///    "field": {
    ///      "$ref": "List.Filter.Fields.Episodes",
    ///      "required": true
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class EpisodeS : JeanRichard.Xbmc.Lib.XbmcEntities.List.Filter.Rule {
        
        private List.Filter.Fields.EpisodeS _field;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="field")]
        public List.Filter.Fields.EpisodeS Field {
            get {
                return this._field;
            }
            set {
                this._field = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Field = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseEnum<List.Filter.Fields.EpisodeS>(json, "field");
            this.ParseExtension(json);
        }
    }
}
