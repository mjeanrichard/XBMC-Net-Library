

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List.Item {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// List.Item.Base
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": [
    ///    "Video.Details.File",
    ///    "Audio.Details.Media"
    ///  ],
    ///  "id": "List.Item.Base",
    ///  "properties": {
    ///    "album": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "albumartist": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "albumartistid": {
    ///      "$ref": "Array.Integer"
    ///    },
    ///    "albumid": {
    ///      "$ref": "Library.Id",
    ///      "default": -1
    ///    },
    ///    "albumlabel": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "cast": {
    ///      "$ref": "Video.Cast"
    ///    },
    ///    "comment": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "country": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "description": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "disc": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "duration": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "episode": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "episodeguide": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "firstaired": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "id": {
    ///      "$ref": "Library.Id",
    ///      "default": -1
    ///    },
    ///    "imdbnumber": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "lyrics": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "mood": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "mpaa": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "musicbrainzartistid": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "musicbrainztrackid": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "originaltitle": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "plotoutline": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "premiered": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "productioncode": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "season": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "set": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "setid": {
    ///      "$ref": "Library.Id",
    ///      "default": -1
    ///    },
    ///    "showlink": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "showtitle": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "sorttitle": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "studio": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "style": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "tag": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "tagline": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "theme": {
    ///      "$ref": "Array.String"
    ///    },
    ///    "top250": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "track": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "trailer": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "tvshowid": {
    ///      "$ref": "Library.Id",
    ///      "default": -1
    ///    },
    ///    "type": {
    ///      "default": "unknown",
    ///      "enums": [
    ///        "unknown",
    ///        "movie",
    ///        "episode",
    ///        "musicvideo",
    ///        "song",
    ///        "picture",
    ///        "channel"
    ///      ],
    ///      "type": "string"
    ///    },
    ///    "uniqueid": {
    ///      "additionalProperties": {
    ///        "default": "",
    ///        "minLength": 1,
    ///        "type": "string"
    ///      },
    ///      "type": "object"
    ///    },
    ///    "votes": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "watchedepisodes": {
    ///      "default": 0,
    ///      "type": "integer"
    ///    },
    ///    "writer": {
    ///      "$ref": "Array.String"
    ///    }
    ///  }
    ///}
    /// </json>
    public partial class Base : Video.Details.File, Audio.Details.Media,  {
        
        private string _album = "";
        
        private string[] _albumArtist;
        
        private System.Nullable<int>[] _albumArtistId;
        
        private System.Nullable<int> _albumId = -1;
        
        private string _albumLabel = "";
        
        private Video.Cast[] _cast;
        
        private string _comment = "";
        
        private string[] _country;
        
        private string _description = "";
        
        private System.Nullable<int> _disc = 0;
        
        private System.Nullable<int> _duration = 0;
        
        private System.Nullable<int> _episode = 0;
        
        private string _episodeGuide = "";
        
        private string _firstAired = "";
        
        private System.Nullable<int> _id = -1;
        
        private string _imdbNumber = "";
        
        private string _lyrics = "";
        
        private string[] _mood;
        
        private string _mpaa = "";
        
        private string _musicBrainzArtistId = "";
        
        private string _musicBrainzTrackId = "";
        
        private string _originalTitle = "";
        
        private string _plotOutline = "";
        
        private string _premiered = "";
        
        private string _productionCode = "";
        
        private System.Nullable<int> _season = 0;
        
        private string _set = "";
        
        private System.Nullable<int> _setId = -1;
        
        private string[] _showLink;
        
        private string _showTitle = "";
        
        private string _sortTitle = "";
        
        private string[] _studio;
        
        private string[] _style;
        
        private string[] _tag;
        
        private string _tagline = "";
        
        private string[] _theme;
        
        private System.Nullable<int> _top250 = 0;
        
        private System.Nullable<int> _track = 0;
        
        private string _trailer = "";
        
        private System.Nullable<int> _tvShowId = -1;
        
        private List.Item.MediaItemTypes _type;
        
        private Object _uniqueid;
        
        private string _votes = "";
        
        private System.Nullable<int> _watchedepisodes = 0;
        
        private string[] _writer;
        
partial void ParseExtension(Newtonsoft.Json.Linq.JToken json);
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="album")]
        public string Album {
            get {
                return this._album;
            }
            set {
                this._album = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="albumartist")]
        public string[] AlbumArtist {
            get {
                return this._albumArtist;
            }
            set {
                this._albumArtist = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="albumartistid")]
        public System.Nullable<int>[] AlbumArtistId {
            get {
                return this._albumArtistId;
            }
            set {
                this._albumArtistId = value;
            }
        }
        
        /// <remarks>Minimum: '1'  Default: '-1'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="albumid")]
        public System.Nullable<int> AlbumId {
            get {
                return this._albumId;
            }
            set {
                this._albumId = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="albumlabel")]
        public string AlbumLabel {
            get {
                return this._albumLabel;
            }
            set {
                this._albumLabel = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="cast")]
        public Video.Cast[] Cast {
            get {
                return this._cast;
            }
            set {
                this._cast = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="comment")]
        public string Comment {
            get {
                return this._comment;
            }
            set {
                this._comment = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="country")]
        public string[] Country {
            get {
                return this._country;
            }
            set {
                this._country = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="description")]
        public string Description {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="disc")]
        public System.Nullable<int> Disc {
            get {
                return this._disc;
            }
            set {
                this._disc = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="duration")]
        public System.Nullable<int> Duration {
            get {
                return this._duration;
            }
            set {
                this._duration = value;
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
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="firstaired")]
        public string FirstAired {
            get {
                return this._firstAired;
            }
            set {
                this._firstAired = value;
            }
        }
        
        /// <remarks>Minimum: '1'  Default: '-1'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="id")]
        public System.Nullable<int> Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
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
        [Newtonsoft.Json.JsonProperty(PropertyName="lyrics")]
        public string Lyrics {
            get {
                return this._lyrics;
            }
            set {
                this._lyrics = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="mood")]
        public string[] Mood {
            get {
                return this._mood;
            }
            set {
                this._mood = value;
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
        [Newtonsoft.Json.JsonProperty(PropertyName="musicbrainzartistid")]
        public string MusicBrainzArtistId {
            get {
                return this._musicBrainzArtistId;
            }
            set {
                this._musicBrainzArtistId = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="musicbrainztrackid")]
        public string MusicBrainzTrackId {
            get {
                return this._musicBrainzTrackId;
            }
            set {
                this._musicBrainzTrackId = value;
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
        [Newtonsoft.Json.JsonProperty(PropertyName="plotoutline")]
        public string PlotOutline {
            get {
                return this._plotOutline;
            }
            set {
                this._plotOutline = value;
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
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="productioncode")]
        public string ProductionCode {
            get {
                return this._productionCode;
            }
            set {
                this._productionCode = value;
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
        [Newtonsoft.Json.JsonProperty(PropertyName="set")]
        public string Set {
            get {
                return this._set;
            }
            set {
                this._set = value;
            }
        }
        
        /// <remarks>Minimum: '1'  Default: '-1'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="setid")]
        public System.Nullable<int> SetId {
            get {
                return this._setId;
            }
            set {
                this._setId = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="showlink")]
        public string[] ShowLink {
            get {
                return this._showLink;
            }
            set {
                this._showLink = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="showtitle")]
        public string ShowTitle {
            get {
                return this._showTitle;
            }
            set {
                this._showTitle = value;
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
        
        [Newtonsoft.Json.JsonProperty(PropertyName="style")]
        public string[] Style {
            get {
                return this._style;
            }
            set {
                this._style = value;
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
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="tagline")]
        public string Tagline {
            get {
                return this._tagline;
            }
            set {
                this._tagline = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="theme")]
        public string[] Theme {
            get {
                return this._theme;
            }
            set {
                this._theme = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="top250")]
        public System.Nullable<int> Top250 {
            get {
                return this._top250;
            }
            set {
                this._top250 = value;
            }
        }
        
        /// <remarks>Default: '0'</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="track")]
        public System.Nullable<int> Track {
            get {
                return this._track;
            }
            set {
                this._track = value;
            }
        }
        
        /// <remarks>Default: ''</remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName="trailer")]
        public string Trailer {
            get {
                return this._trailer;
            }
            set {
                this._trailer = value;
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
        
        [Newtonsoft.Json.JsonProperty(PropertyName="type")]
        public List.Item.MediaItemTypes Type {
            get {
                return this._type;
            }
            set {
                this._type = value;
            }
        }
        
        [Newtonsoft.Json.JsonProperty(PropertyName="uniqueid")]
        public Object Uniqueid {
            get {
                return this._uniqueid;
            }
            set {
                this._uniqueid = value;
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
        
        [Newtonsoft.Json.JsonProperty(PropertyName="writer")]
        public string[] Writer {
            get {
                return this._writer;
            }
            set {
                this._writer = value;
            }
        }
        
        protected override void Parse(Newtonsoft.Json.Linq.JToken json) {
            base.Parse(json);
            this.Album = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "album", "");
            this.AlbumArtist = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "albumartist");
            this.AlbumArtistId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<System.Nullable<int>>(json, "albumartistid");
            this.AlbumId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "albumid", -1);
            this.AlbumLabel = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "albumlabel", "");
            this.Cast = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObjectArray<Video.Cast>(json, "cast");
            this.Comment = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "comment", "");
            this.Country = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "country");
            this.Description = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "description", "");
            this.Disc = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "disc", 0);
            this.Duration = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "duration", 0);
            this.Episode = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "episode", 0);
            this.EpisodeGuide = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "episodeguide", "");
            this.FirstAired = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "firstaired", "");
            this.Id = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "id", -1);
            this.ImdbNumber = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "imdbnumber", "");
            this.Lyrics = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "lyrics", "");
            this.Mood = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "mood");
            this.Mpaa = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "mpaa", "");
            this.MusicBrainzArtistId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "musicbrainzartistid", "");
            this.MusicBrainzTrackId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "musicbrainztrackid", "");
            this.OriginalTitle = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "originaltitle", "");
            this.PlotOutline = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "plotoutline", "");
            this.Premiered = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "premiered", "");
            this.ProductionCode = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "productioncode", "");
            this.Season = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "season", 0);
            this.Set = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "set", "");
            this.SetId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "setid", -1);
            this.ShowLink = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "showlink");
            this.ShowTitle = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "showtitle", "");
            this.SortTitle = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "sorttitle", "");
            this.Studio = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "studio");
            this.Style = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "style");
            this.Tag = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "tag");
            this.Tagline = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "tagline", "");
            this.Theme = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "theme");
            this.Top250 = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "top250", 0);
            this.Track = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "track", 0);
            this.Trailer = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "trailer", "");
            this.TVShowId = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "tvshowid", -1);
            this.Type = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseEnum<List.Item.MediaItemTypes>(json, "type", List.Item.MediaItemTypes.Unknown);
            this.Uniqueid = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseJsonObject<Object>(json, "uniqueid");
            this.Votes = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<string>(json, "votes", "");
            this.Watchedepisodes = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleValue<System.Nullable<int>>(json, "watchedepisodes", 0);
            this.Writer = JeanRichard.Xbmc.Lib.JsonHelpers.JObjectExtensions.ParseSimpleArrayValue<string>(json, "writer");
            this.ParseExtension(json);
        }
    }
}
