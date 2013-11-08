using JeanRichard.Xbmc.Lib.JsonRpc;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields
{
    /// <jsonId>
    /// Audio.Fields.Album
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Item.Fields.Base",
    ///  "id": "Audio.Fields.Album",
    ///  "items": {
    ///    "description": "Requesting the genreid and/or artistid field will result in increased response times",
    ///    "enums": [
    ///      "title",
    ///      "description",
    ///      "artist",
    ///      "genre",
    ///      "theme",
    ///      "mood",
    ///      "style",
    ///      "type",
    ///      "albumlabel",
    ///      "rating",
    ///      "year",
    ///      "musicbrainzalbumid",
    ///      "musicbrainzalbumartistid",
    ///      "fanart",
    ///      "thumbnail",
    ///      "playcount",
    ///      "genreid",
    ///      "artistid",
    ///      "displayartist"
    ///    ],
    ///    "type": "string"
    ///  }
    ///}
    /// </json>
    public class AlbumFields : FlagsBase<AlbumFields>
    {
        public static AlbumFields None = new AlbumFields();

        public static AlbumFields Title = new AlbumFields("title");

        public static AlbumFields Description = new AlbumFields("description");

        public static AlbumFields Artist = new AlbumFields("artist");

        public static AlbumFields Genre = new AlbumFields("genre");

        public static AlbumFields Theme = new AlbumFields("theme");

        public static AlbumFields Mood = new AlbumFields("mood");

        public static AlbumFields Style = new AlbumFields("style");

        public static AlbumFields Type = new AlbumFields("type");

        public static AlbumFields AlbumLabel = new AlbumFields("albumlabel");

        public static AlbumFields Rating = new AlbumFields("rating");

        public static AlbumFields Year = new AlbumFields("year");

        public static AlbumFields MusicBrainzAlbumId = new AlbumFields("musicbrainzalbumid");

        public static AlbumFields MusicBrainzAlbumArtistId = new AlbumFields("musicbrainzalbumartistid");

        public static AlbumFields FanArt = new AlbumFields("fanart");

        public static AlbumFields Thumbnail = new AlbumFields("thumbnail");

        public static AlbumFields PlayCount = new AlbumFields("playcount");

        public static AlbumFields GenreId = new AlbumFields("genreid");

        public static AlbumFields ArtistId = new AlbumFields("artistid");

        public static AlbumFields Displayartist = new AlbumFields("displayartist");

        public static AlbumFields All = Combine(Title, Description, Artist, Genre, Theme, Mood, Style, Type, AlbumLabel, Rating, Year, MusicBrainzAlbumId, MusicBrainzAlbumArtistId, FanArt, Thumbnail, PlayCount, GenreId, ArtistId, Displayartist);


        protected AlbumFields(string value) : base(value)
        {}

        public AlbumFields()
        {}
    }
}