//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Video.Details {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Video.Details.Media
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Video.Details.Base",
    ///  "id": "Video.Details.Media",
    ///  "properties": {
    ///    "title": {
    ///      "default": "",
    ///      "type": "string"
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class Media : JeanRichard.Xbmc.Lib.XbmcEntities.Video.Details.Base {
        
        private string _title = "";
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="title")]
        public string Title {
            get {
                return this._title;
            }
            set {
                this._title = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Title = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "title", "");
        }
    }
}