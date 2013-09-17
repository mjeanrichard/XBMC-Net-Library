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
    /// List.Fields.Files
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Item.Fields.Base",
    ///  "id": "List.Fields.Files",
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
    ///      "size",
    ///      "lastmodified",
    ///      "mimetype"
    ///    ],
    ///    "type": "string"
    ///  }
    ///}
    /// </json>
    public class Files : JeanRichard.Xbmc.Lib.JsonRpc.FlagsBase<Files> {
        
        public static Files None = new Files();
        
        public static Files Title = new Files("title");
        
        public static Files Artist = new Files("artist");
        
        public static Files AlbumArtist = new Files("albumartist");
        
        public static Files Genre = new Files("genre");
        
        public static Files Year = new Files("year");
        
        public static Files Rating = new Files("rating");
        
        public static Files Album = new Files("album");
        
        public static Files Track = new Files("track");
        
        public static Files Duration = new Files("duration");
        
        public static Files Comment = new Files("comment");
        
        public static Files Lyrics = new Files("lyrics");
        
        public static Files MusicBrainzTrackId = new Files("musicbrainztrackid");
        
        public static Files MusicBrainzArtistId = new Files("musicbrainzartistid");
        
        public static Files MusicBrainzAlbumId = new Files("musicbrainzalbumid");
        
        public static Files MusicBrainzAlbumArtistId = new Files("musicbrainzalbumartistid");
        
        public static Files PlayCount = new Files("playcount");
        
        public static Files FanArt = new Files("fanart");
        
        public static Files Director = new Files("director");
        
        public static Files Trailer = new Files("trailer");
        
        public static Files Tagline = new Files("tagline");
        
        public static Files Plot = new Files("plot");
        
        public static Files PlotOutline = new Files("plotoutline");
        
        public static Files OriginalTitle = new Files("originaltitle");
        
        public static Files LastPlayed = new Files("lastplayed");
        
        public static Files Writer = new Files("writer");
        
        public static Files Studio = new Files("studio");
        
        public static Files Mpaa = new Files("mpaa");
        
        public static Files Cast = new Files("cast");
        
        public static Files Country = new Files("country");
        
        public static Files ImdbNumber = new Files("imdbnumber");
        
        public static Files Premiered = new Files("premiered");
        
        public static Files ProductionCode = new Files("productioncode");
        
        public static Files Runtime = new Files("runtime");
        
        public static Files Set = new Files("set");
        
        public static Files ShowLink = new Files("showlink");
        
        public static Files StreamDetails = new Files("streamdetails");
        
        public static Files Top250 = new Files("top250");
        
        public static Files Votes = new Files("votes");
        
        public static Files FirstAired = new Files("firstaired");
        
        public static Files Season = new Files("season");
        
        public static Files Episode = new Files("episode");
        
        public static Files ShowTitle = new Files("showtitle");
        
        public static Files Thumbnail = new Files("thumbnail");
        
        public static Files File = new Files("file");
        
        public static Files Resume = new Files("resume");
        
        public static Files ArtistId = new Files("artistid");
        
        public static Files AlbumId = new Files("albumid");
        
        public static Files TVShowId = new Files("tvshowid");
        
        public static Files SetId = new Files("setid");
        
        public static Files Watchedepisodes = new Files("watchedepisodes");
        
        public static Files Disc = new Files("disc");
        
        public static Files Tag = new Files("tag");
        
        public static Files Art = new Files("art");
        
        public static Files GenreId = new Files("genreid");
        
        public static Files Displayartist = new Files("displayartist");
        
        public static Files AlbumArtistId = new Files("albumartistid");
        
        public static Files Description = new Files("description");
        
        public static Files Theme = new Files("theme");
        
        public static Files Mood = new Files("mood");
        
        public static Files Style = new Files("style");
        
        public static Files AlbumLabel = new Files("albumlabel");
        
        public static Files SortTitle = new Files("sorttitle");
        
        public static Files EpisodeGuide = new Files("episodeguide");
        
        public static Files Uniqueid = new Files("uniqueid");
        
        public static Files Dateadded = new Files("dateadded");
        
        public static Files Size = new Files("size");
        
        public static Files LastModified = new Files("lastmodified");
        
        public static Files Mimetype = new Files("mimetype");
        
        public static Files All = Files.Combine(Files.Title, Files.Artist, Files.AlbumArtist, Files.Genre, Files.Year, Files.Rating, Files.Album, Files.Track, Files.Duration, Files.Comment, Files.Lyrics, Files.MusicBrainzTrackId, Files.MusicBrainzArtistId, Files.MusicBrainzAlbumId, Files.MusicBrainzAlbumArtistId, Files.PlayCount, Files.FanArt, Files.Director, Files.Trailer, Files.Tagline, Files.Plot, Files.PlotOutline, Files.OriginalTitle, Files.LastPlayed, Files.Writer, Files.Studio, Files.Mpaa, Files.Cast, Files.Country, Files.ImdbNumber, Files.Premiered, Files.ProductionCode, Files.Runtime, Files.Set, Files.ShowLink, Files.StreamDetails, Files.Top250, Files.Votes, Files.FirstAired, Files.Season, Files.Episode, Files.ShowTitle, Files.Thumbnail, Files.File, Files.Resume, Files.ArtistId, Files.AlbumId, Files.TVShowId, Files.SetId, Files.Watchedepisodes, Files.Disc, Files.Tag, Files.Art, Files.GenreId, Files.Displayartist, Files.AlbumArtistId, Files.Description, Files.Theme, Files.Mood, Files.Style, Files.AlbumLabel, Files.SortTitle, Files.EpisodeGuide, Files.Uniqueid, Files.Dateadded, Files.Size, Files.LastModified, Files.Mimetype);
        

        protected Files(string value) : base(value)
        {}

        public Files()
        {}
        
    }
}