//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Configuration
    /// </jsonId>
    /// <json>
    /// {
    ///  "id": "Configuration",
    ///  "properties": {
    ///    "notifications": {
    ///      "$ref": "Configuration.Notifications",
    ///      "required": true
    ///    }
    ///  },
    ///  "required": true,
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Configuration : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private Configuration.Notifications _notifications;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="notifications")]
        public Configuration.Notifications Notifications {
            get {
                return this._notifications;
            }
            set {
                this._notifications = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Notifications = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObject<Configuration.Notifications>(json, "notifications");
            this.ParseExtension(json);
        }
    }
}
