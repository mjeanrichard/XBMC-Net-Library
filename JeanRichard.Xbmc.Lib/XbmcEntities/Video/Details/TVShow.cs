//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Video.Details {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// Video.Details.TVShow
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Video.Details.Item",
    ///  "id": "Video.Details.TVShow",
    ///  "properties": {
    ///    "cast": {
    ///      "$ref": "Video.Cast"
    ///    },
    ///    "episode": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "episodeguide": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "genre": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "imdbnumber": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "mpaa": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "originaltitle": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "premiered": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "rating": {
    ///      "default": 0,
    ///      "type": "number"
    ///    },
    ///    "season": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "sorttitle": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "studio": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "tag": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "tvshowid": {
    ///      "$ref": "Library.Id",
    ///      "required": true
    ///    },
    ///    "votes": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "watchedepisodes": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "year": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class TVShow : JeanRichard.Xbmc.Lib.XbmcEntities.Video.Details.Item {
        
        private Video.Cast[] _cast;
        
        private System.Nullable<int> _episode = 0;
        
        private string _episodeGuide = "";
        
        private string[] _genre;
        
        private string _imdbNumber = "";
        
        private string _mpaa = "";
        
        private string _originalTitle = "";
        
        private string _premiered = "";
        
        private System.Nullable<decimal> _rating = 0m;
        
        private System.Nullable<int> _season = 0;
        
        private string _sortTitle = "";
        
        private string[] _studio;
        
        private string[] _tag;
        
        private System.Nullable<int> _tvShowId = -1;
        
        private string _votes = "";
        
        private System.Nullable<int> _watchedepisodes = 0;
        
        private System.Nullable<int> _year = 0;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        [Newtonsoft.Json.JsonProperty(PropertyName="cast")]
        public Video.Cast[] Cast {
            get {
                return this._cast;
            }
            set {
                this._cast = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="episode")]
        public System.Nullable<int> Episode {
            get {
                return this._episode;
            }
            set {
                this._episode = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="episodeguide")]
        public string EpisodeGuide {
            get {
                return this._episodeGuide;
            }
            set {
                this._episodeGuide = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="genre")]
        public string[] Genre {
            get {
                return this._genre;
            }
            set {
                this._genre = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="imdbnumber")]
        public string ImdbNumber {
            get {
                return this._imdbNumber;
            }
            set {
                this._imdbNumber = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="mpaa")]
        public string Mpaa {
            get {
                return this._mpaa;
            }
            set {
                this._mpaa = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="originaltitle")]
        public string OriginalTitle {
            get {
                return this._originalTitle;
            }
            set {
                this._originalTitle = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="premiered")]
        public string Premiered {
            get {
                return this._premiered;
            }
            set {
                this._premiered = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="rating")]
        public System.Nullable<decimal> Rating {
            get {
                return this._rating;
            }
            set {
                this._rating = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="season")]
        public System.Nullable<int> Season {
            get {
                return this._season;
            }
            set {
                this._season = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="sorttitle")]
        public string SortTitle {
            get {
                return this._sortTitle;
            }
            set {
                this._sortTitle = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="studio")]
        public string[] Studio {
            get {
                return this._studio;
            }
            set {
                this._studio = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="tag")]
        public string[] Tag {
            get {
                return this._tag;
            }
            set {
                this._tag = value;
            }
        }
        
        /// <remarks>Minimum: '1'  Default: '-1'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="tvshowid")]
        public System.Nullable<int> TVShowId {
            get {
                return this._tvShowId;
            }
            set {
                this._tvShowId = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="votes")]
        public string Votes {
            get {
                return this._votes;
            }
            set {
                this._votes = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="watchedepisodes")]
        public System.Nullable<int> Watchedepisodes {
            get {
                return this._watchedepisodes;
            }
            set {
                this._watchedepisodes = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="year")]
        public System.Nullable<int> Year {
            get {
                return this._year;
            }
            set {
                this._year = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Cast = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObjectArray<Video.Cast>(json, "cast");
            this.Episode = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "episode", 0);
            this.EpisodeGuide = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "episodeguide", "");
            this.Genre = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "genre");
            this.ImdbNumber = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "imdbnumber", "");
            this.Mpaa = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "mpaa", "");
            this.OriginalTitle = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "originaltitle", "");
            this.Premiered = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "premiered", "");
            this.Rating = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<decimal>>(json, "rating", 0m);
            this.Season = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "season", 0);
            this.SortTitle = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "sorttitle", "");
            this.Studio = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "studio");
            this.Tag = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "tag");
            this.TVShowId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "tvshowid", -1);
            this.Votes = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "votes", "");
            this.Watchedepisodes = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "watchedepisodes", 0);
            this.Year = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "year", 0);
            this.ParseExtension(json);
        }
    }
}
