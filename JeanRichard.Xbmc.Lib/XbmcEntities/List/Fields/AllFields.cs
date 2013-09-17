//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields {
    using System;
    using System.Runtime.Serialization;
    
    
    /// <jsonId>
    /// List.Fields.All
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Item.Fields.Base",
    ///  "id": "List.Fields.All",
    ///  "items": {
    ///    "enums": [
    ///      "title",
    ///      "artist",
    ///      "albumartist",
    ///      "genre",
    ///      "year",
    ///      "rating",
    ///      "album",
    ///      "track",
    ///      "duration",
    ///      "comment",
    ///      "lyrics",
    ///      "musicbrainztrackid",
    ///      "musicbrainzartistid",
    ///      "musicbrainzalbumid",
    ///      "musicbrainzalbumartistid",
    ///      "playcount",
    ///      "fanart",
    ///      "director",
    ///      "trailer",
    ///      "tagline",
    ///      "plot",
    ///      "plotoutline",
    ///      "originaltitle",
    ///      "lastplayed",
    ///      "writer",
    ///      "studio",
    ///      "mpaa",
    ///      "cast",
    ///      "country",
    ///      "imdbnumber",
    ///      "premiered",
    ///      "productioncode",
    ///      "runtime",
    ///      "set",
    ///      "showlink",
    ///      "streamdetails",
    ///      "top250",
    ///      "votes",
    ///      "firstaired",
    ///      "season",
    ///      "episode",
    ///      "showtitle",
    ///      "thumbnail",
    ///      "file",
    ///      "resume",
    ///      "artistid",
    ///      "albumid",
    ///      "tvshowid",
    ///      "setid",
    ///      "watchedepisodes",
    ///      "disc",
    ///      "tag",
    ///      "art",
    ///      "genreid",
    ///      "displayartist",
    ///      "albumartistid",
    ///      "description",
    ///      "theme",
    ///      "mood",
    ///      "style",
    ///      "albumlabel",
    ///      "sorttitle",
    ///      "episodeguide",
    ///      "uniqueid",
    ///      "dateadded",
    ///      "channel",
    ///      "channeltype",
    ///      "hidden",
    ///      "locked",
    ///      "channelnumber",
    ///      "starttime",
    ///      "endtime"
    ///    ],
    ///    "type": "string"
    ///  }
    ///}
    /// </json>
    public class AllFields : JeanRichard.Xbmc.Lib.JsonRpc.FlagsBase<AllFields> {
        
        public static AllFields None = new AllFields();
        
        public static AllFields Title = new AllFields("title");
        
        public static AllFields Artist = new AllFields("artist");
        
        public static AllFields AlbumArtist = new AllFields("albumartist");
        
        public static AllFields Genre = new AllFields("genre");
        
        public static AllFields Year = new AllFields("year");
        
        public static AllFields Rating = new AllFields("rating");
        
        public static AllFields Album = new AllFields("album");
        
        public static AllFields Track = new AllFields("track");
        
        public static AllFields Duration = new AllFields("duration");
        
        public static AllFields Comment = new AllFields("comment");
        
        public static AllFields Lyrics = new AllFields("lyrics");
        
        public static AllFields MusicBrainzTrackId = new AllFields("musicbrainztrackid");
        
        public static AllFields MusicBrainzArtistId = new AllFields("musicbrainzartistid");
        
        public static AllFields MusicBrainzAlbumId = new AllFields("musicbrainzalbumid");
        
        public static AllFields MusicBrainzAlbumArtistId = new AllFields("musicbrainzalbumartistid");
        
        public static AllFields PlayCount = new AllFields("playcount");
        
        public static AllFields FanArt = new AllFields("fanart");
        
        public static AllFields Director = new AllFields("director");
        
        public static AllFields Trailer = new AllFields("trailer");
        
        public static AllFields Tagline = new AllFields("tagline");
        
        public static AllFields Plot = new AllFields("plot");
        
        public static AllFields PlotOutline = new AllFields("plotoutline");
        
        public static AllFields OriginalTitle = new AllFields("originaltitle");
        
        public static AllFields LastPlayed = new AllFields("lastplayed");
        
        public static AllFields Writer = new AllFields("writer");
        
        public static AllFields Studio = new AllFields("studio");
        
        public static AllFields Mpaa = new AllFields("mpaa");
        
        public static AllFields Cast = new AllFields("cast");
        
        public static AllFields Country = new AllFields("country");
        
        public static AllFields ImdbNumber = new AllFields("imdbnumber");
        
        public static AllFields Premiered = new AllFields("premiered");
        
        public static AllFields ProductionCode = new AllFields("productioncode");
        
        public static AllFields Runtime = new AllFields("runtime");
        
        public static AllFields Set = new AllFields("set");
        
        public static AllFields ShowLink = new AllFields("showlink");
        
        public static AllFields StreamDetails = new AllFields("streamdetails");
        
        public static AllFields Top250 = new AllFields("top250");
        
        public static AllFields Votes = new AllFields("votes");
        
        public static AllFields FirstAired = new AllFields("firstaired");
        
        public static AllFields Season = new AllFields("season");
        
        public static AllFields Episode = new AllFields("episode");
        
        public static AllFields ShowTitle = new AllFields("showtitle");
        
        public static AllFields Thumbnail = new AllFields("thumbnail");
        
        public static AllFields File = new AllFields("file");
        
        public static AllFields Resume = new AllFields("resume");
        
        public static AllFields ArtistId = new AllFields("artistid");
        
        public static AllFields AlbumId = new AllFields("albumid");
        
        public static AllFields TVShowId = new AllFields("tvshowid");
        
        public static AllFields SetId = new AllFields("setid");
        
        public static AllFields Watchedepisodes = new AllFields("watchedepisodes");
        
        public static AllFields Disc = new AllFields("disc");
        
        public static AllFields Tag = new AllFields("tag");
        
        public static AllFields Art = new AllFields("art");
        
        public static AllFields GenreId = new AllFields("genreid");
        
        public static AllFields Displayartist = new AllFields("displayartist");
        
        public static AllFields AlbumArtistId = new AllFields("albumartistid");
        
        public static AllFields Description = new AllFields("description");
        
        public static AllFields Theme = new AllFields("theme");
        
        public static AllFields Mood = new AllFields("mood");
        
        public static AllFields Style = new AllFields("style");
        
        public static AllFields AlbumLabel = new AllFields("albumlabel");
        
        public static AllFields SortTitle = new AllFields("sorttitle");
        
        public static AllFields EpisodeGuide = new AllFields("episodeguide");
        
        public static AllFields Uniqueid = new AllFields("uniqueid");
        
        public static AllFields Dateadded = new AllFields("dateadded");
        
        public static AllFields Channel = new AllFields("channel");
        
        public static AllFields Channeltype = new AllFields("channeltype");
        
        public static AllFields Hidden = new AllFields("hidden");
        
        public static AllFields Locked = new AllFields("locked");
        
        public static AllFields Channelnumber = new AllFields("channelnumber");
        
        public static AllFields Starttime = new AllFields("starttime");
        
        public static AllFields Endtime = new AllFields("endtime");
        
        public static AllFields All = AllFields.Combine(AllFields.Title, AllFields.Artist, AllFields.AlbumArtist, AllFields.Genre, AllFields.Year, AllFields.Rating, AllFields.Album, AllFields.Track, AllFields.Duration, AllFields.Comment, AllFields.Lyrics, AllFields.MusicBrainzTrackId, AllFields.MusicBrainzArtistId, AllFields.MusicBrainzAlbumId, AllFields.MusicBrainzAlbumArtistId, AllFields.PlayCount, AllFields.FanArt, AllFields.Director, AllFields.Trailer, AllFields.Tagline, AllFields.Plot, AllFields.PlotOutline, AllFields.OriginalTitle, AllFields.LastPlayed, AllFields.Writer, AllFields.Studio, AllFields.Mpaa, AllFields.Cast, AllFields.Country, AllFields.ImdbNumber, AllFields.Premiered, AllFields.ProductionCode, AllFields.Runtime, AllFields.Set, AllFields.ShowLink, AllFields.StreamDetails, AllFields.Top250, AllFields.Votes, AllFields.FirstAired, AllFields.Season, AllFields.Episode, AllFields.ShowTitle, AllFields.Thumbnail, AllFields.File, AllFields.Resume, AllFields.ArtistId, AllFields.AlbumId, AllFields.TVShowId, AllFields.SetId, AllFields.Watchedepisodes, AllFields.Disc, AllFields.Tag, AllFields.Art, AllFields.GenreId, AllFields.Displayartist, AllFields.AlbumArtistId, AllFields.Description, AllFields.Theme, AllFields.Mood, AllFields.Style, AllFields.AlbumLabel, AllFields.SortTitle, AllFields.EpisodeGuide, AllFields.Uniqueid, AllFields.Dateadded, AllFields.Channel, AllFields.Channeltype, AllFields.Hidden, AllFields.Locked, AllFields.Channelnumber, AllFields.Starttime, AllFields.Endtime);
        

        protected AllFields(string value) : base(value)
        {}

        public AllFields()
        {}
        
    }
}
