using JeanRichard.Xbmc.Lib.JsonRpc;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields
{
    /// <jsonId>
    /// Audio.Fields.Song
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Item.Fields.Base",
    ///  "id": "Audio.Fields.Song",
    ///  "items": {
    ///    "description": "Requesting the genreid, artistid and/or albumartistid field will result in increased response times",
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
    ///      "thumbnail",
    ///      "file",
    ///      "albumid",
    ///      "lastplayed",
    ///      "disc",
    ///      "genreid",
    ///      "artistid",
    ///      "displayartist",
    ///      "albumartistid"
    ///    ],
    ///    "type": "string"
    ///  }
    ///}
    /// </json>
    public class SongFields : FlagsBase<SongFields>
    {
        public static SongFields None = new SongFields();

        public static SongFields Title = new SongFields("title");

        public static SongFields Artist = new SongFields("artist");

        public static SongFields AlbumArtist = new SongFields("albumartist");

        public static SongFields Genre = new SongFields("genre");

        public static SongFields Year = new SongFields("year");

        public static SongFields Rating = new SongFields("rating");

        public static SongFields Album = new SongFields("album");

        public static SongFields Track = new SongFields("track");

        public static SongFields Duration = new SongFields("duration");

        public static SongFields Comment = new SongFields("comment");

        public static SongFields Lyrics = new SongFields("lyrics");

        public static SongFields MusicBrainzTrackId = new SongFields("musicbrainztrackid");

        public static SongFields MusicBrainzArtistId = new SongFields("musicbrainzartistid");

        public static SongFields MusicBrainzAlbumId = new SongFields("musicbrainzalbumid");

        public static SongFields MusicBrainzAlbumArtistId = new SongFields("musicbrainzalbumartistid");

        public static SongFields PlayCount = new SongFields("playcount");

        public static SongFields FanArt = new SongFields("fanart");

        public static SongFields Thumbnail = new SongFields("thumbnail");

        public static SongFields File = new SongFields("file");

        public static SongFields AlbumId = new SongFields("albumid");

        public static SongFields LastPlayed = new SongFields("lastplayed");

        public static SongFields Disc = new SongFields("disc");

        public static SongFields GenreId = new SongFields("genreid");

        public static SongFields ArtistId = new SongFields("artistid");

        public static SongFields Displayartist = new SongFields("displayartist");

        public static SongFields AlbumArtistId = new SongFields("albumartistid");

        public static SongFields All = Combine(Title, Artist, AlbumArtist, Genre, Year, Rating, Album, Track, Duration, Comment, Lyrics, MusicBrainzTrackId, MusicBrainzArtistId, MusicBrainzAlbumId, MusicBrainzAlbumArtistId, PlayCount, FanArt, Thumbnail, File, AlbumId, LastPlayed, Disc, GenreId, ArtistId, Displayartist, AlbumArtistId);


        protected SongFields(string value) : base(value)
        {}

        public SongFields()
        {}
    }
}