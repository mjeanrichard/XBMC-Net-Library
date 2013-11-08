using JeanRichard.Xbmc.Lib.JsonRpc;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields
{
    /// <jsonId>
    /// Audio.Fields.Artist
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "Item.Fields.Base",
    ///  "id": "Audio.Fields.Artist",
    ///  "items": {
    ///    "enums": [
    ///      "instrument",
    ///      "style",
    ///      "mood",
    ///      "born",
    ///      "formed",
    ///      "description",
    ///      "genre",
    ///      "died",
    ///      "disbanded",
    ///      "yearsactive",
    ///      "musicbrainzartistid",
    ///      "fanart",
    ///      "thumbnail"
    ///    ],
    ///    "type": "string"
    ///  }
    ///}
    /// </json>
    public class ArtistFields : FlagsBase<ArtistFields>
    {
        public static ArtistFields None = new ArtistFields();

        public static ArtistFields Instrument = new ArtistFields("instrument");

        public static ArtistFields Style = new ArtistFields("style");

        public static ArtistFields Mood = new ArtistFields("mood");

        public static ArtistFields Born = new ArtistFields("born");

        public static ArtistFields Formed = new ArtistFields("formed");

        public static ArtistFields Description = new ArtistFields("description");

        public static ArtistFields Genre = new ArtistFields("genre");

        public static ArtistFields Died = new ArtistFields("died");

        public static ArtistFields Disbanded = new ArtistFields("disbanded");

        public static ArtistFields Yearsactive = new ArtistFields("yearsactive");

        public static ArtistFields MusicBrainzArtistId = new ArtistFields("musicbrainzartistid");

        public static ArtistFields FanArt = new ArtistFields("fanart");

        public static ArtistFields Thumbnail = new ArtistFields("thumbnail");

        public static ArtistFields All = Combine(Instrument, Style, Mood, Born, Formed, Description, Genre, Died, Disbanded, Yearsactive, MusicBrainzArtistId, FanArt, Thumbnail);

        protected ArtistFields(string value) : base(value)
        {}

        public ArtistFields()
        {}
    }
}