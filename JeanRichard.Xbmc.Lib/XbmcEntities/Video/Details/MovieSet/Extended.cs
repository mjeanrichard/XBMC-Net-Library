//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Video.Details.MovieSet {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Video.Details.MovieSet.Extended
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Video.Details.MovieSet",
    ///  "id": "Video.Details.MovieSet.Extended",
    ///  "properties": {
    ///    "movies": {
    ///      "items": {
    ///        "$ref": "Video.Details.Movie"
    ///      },
    ///      "type": "array"
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class Extended : JeanRichard.Xbmc.Lib.XbmcEntities.Video.Details.MovieSet {
        
        private Video.Details.Movie[] _movieS;
        
        [Newtonsoft.Json.JsonProperty(PropertyName="movies")]
        public Video.Details.Movie[] MovieS {
            get {
                return this._movieS;
            }
            set {
                this._movieS = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.MovieS = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObjectArray<Video.Details.Movie>(json, "movies");
        }
    }
}