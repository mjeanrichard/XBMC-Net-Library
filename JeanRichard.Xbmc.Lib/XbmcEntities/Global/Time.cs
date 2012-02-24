//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Global {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Global.Time
    /// </jsonId>
    /// <json>
    /// {
    ///  "additionalProperties": false,
    ///  "id": "Global.Time",
    ///  "properties": {
    ///    "hours": {
    ///      "maximum": 23,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "milliseconds": {
    ///      "maximum": 999,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "minutes": {
    ///      "maximum": 59,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    },
    ///    "seconds": {
    ///      "maximum": 59,
    ///      "minimum": 0,
    ///      "required": true,
    ///      "type": "integer"
    ///    }
    ///  },
    ///  "type": "object"
    ///}
    /// </json>
    public partial class Time : JeanRichard.Xbmc.Lib.JsonRpc.JsonRpcItem {
        
        private int _hours;
        
        private int _milliseconds;
        
        private int _minutes;
        
        private int _seconds;
        
        /// <remarks>Minimum: '0'  Maximum: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="hours")]
        public int Hours {
            get {
                return this._hours;
            }
            set {
                this._hours = value;
            }
        }
        
        /// <remarks>Minimum: '0'  Maximum: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="milliseconds")]
        public int Milliseconds {
            get {
                return this._milliseconds;
            }
            set {
                this._milliseconds = value;
            }
        }
        
        /// <remarks>Minimum: '0'  Maximum: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="minutes")]
        public int Minutes {
            get {
                return this._minutes;
            }
            set {
                this._minutes = value;
            }
        }
        
        /// <remarks>Minimum: '0'  Maximum: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="seconds")]
        public int Seconds {
            get {
                return this._seconds;
            }
            set {
                this._seconds = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Hours = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<int>(json, "hours");
            this.Milliseconds = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<int>(json, "milliseconds");
            this.Minutes = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<int>(json, "minutes");
            this.Seconds = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<int>(json, "seconds");
        }
    }
}