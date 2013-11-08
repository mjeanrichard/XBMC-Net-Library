

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// List.method
    /// </jsonId>
    /// <json>
    /// {
    ///  "default": "none",
    ///  "enums": [
    ///    "none",
    ///    "label",
    ///    "date",
    ///    "size",
    ///    "file",
    ///    "path",
    ///    "drivetype",
    ///    "title",
    ///    "track",
    ///    "time",
    ///    "artist",
    ///    "album",
    ///    "albumtype",
    ///    "genre",
    ///    "country",
    ///    "year",
    ///    "rating",
    ///    "votes",
    ///    "top250",
    ///    "programcount",
    ///    "playlist",
    ///    "episode",
    ///    "season",
    ///    "totalepisodes",
    ///    "watchedepisodes",
    ///    "tvshowstatus",
    ///    "tvshowtitle",
    ///    "sorttitle",
    ///    "productioncode",
    ///    "mpaa",
    ///    "studio",
    ///    "dateadded",
    ///    "lastplayed",
    ///    "playcount",
    ///    "listeners",
    ///    "bitrate",
    ///    "random"
    ///  ],
    ///  "type": "string"
    ///}
    /// </json>
    public enum SortMethods : long {
        
        [System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        
        [System.Runtime.Serialization.EnumMember(Value="label")]
        Label,
        
        [System.Runtime.Serialization.EnumMember(Value="date")]
        Date,
        
        [System.Runtime.Serialization.EnumMember(Value="size")]
        Size,
        
        [System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        
        [System.Runtime.Serialization.EnumMember(Value="path")]
        Path,
        
        [System.Runtime.Serialization.EnumMember(Value="drivetype")]
        DriveType,
        
        [System.Runtime.Serialization.EnumMember(Value="title")]
        Title,
        
        [System.Runtime.Serialization.EnumMember(Value="track")]
        Track,
        
        [System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        
        [System.Runtime.Serialization.EnumMember(Value="artist")]
        Artist,
        
        [System.Runtime.Serialization.EnumMember(Value="album")]
        Album,
        
        [System.Runtime.Serialization.EnumMember(Value="albumtype")]
        AlbumType,
        
        [System.Runtime.Serialization.EnumMember(Value="genre")]
        Genre,
        
        [System.Runtime.Serialization.EnumMember(Value="country")]
        Country,
        
        [System.Runtime.Serialization.EnumMember(Value="year")]
        Year,
        
        [System.Runtime.Serialization.EnumMember(Value="rating")]
        Rating,
        
        [System.Runtime.Serialization.EnumMember(Value="votes")]
        Votes,
        
        [System.Runtime.Serialization.EnumMember(Value="top250")]
        Top250,
        
        [System.Runtime.Serialization.EnumMember(Value="programcount")]
        Programcount,
        
        [System.Runtime.Serialization.EnumMember(Value="playlist")]
        Playlist,
        
        [System.Runtime.Serialization.EnumMember(Value="episode")]
        Episode,
        
        [System.Runtime.Serialization.EnumMember(Value="season")]
        Season,
        
        [System.Runtime.Serialization.EnumMember(Value="totalepisodes")]
        TotalEpisodeS,
        
        [System.Runtime.Serialization.EnumMember(Value="watchedepisodes")]
        Watchedepisodes,
        
        [System.Runtime.Serialization.EnumMember(Value="tvshowstatus")]
        TVShowStatus,
        
        [System.Runtime.Serialization.EnumMember(Value="tvshowtitle")]
        TVShowTitle,
        
        [System.Runtime.Serialization.EnumMember(Value="sorttitle")]
        SortTitle,
        
        [System.Runtime.Serialization.EnumMember(Value="productioncode")]
        ProductionCode,
        
        [System.Runtime.Serialization.EnumMember(Value="mpaa")]
        Mpaa,
        
        [System.Runtime.Serialization.EnumMember(Value="studio")]
        Studio,
        
        [System.Runtime.Serialization.EnumMember(Value="dateadded")]
        Dateadded,
        
        [System.Runtime.Serialization.EnumMember(Value="lastplayed")]
        LastPlayed,
        
        [System.Runtime.Serialization.EnumMember(Value="playcount")]
        PlayCount,
        
        [System.Runtime.Serialization.EnumMember(Value="listeners")]
        ListEners,
        
        [System.Runtime.Serialization.EnumMember(Value="bitrate")]
        Bitrate,
        
        [System.Runtime.Serialization.EnumMember(Value="random")]
        Random,
    }
}
