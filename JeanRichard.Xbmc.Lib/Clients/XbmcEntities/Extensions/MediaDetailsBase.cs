using System;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Media
{
    public partial class MediaDetailsBase
    {
        public virtual int? Id
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }
    }
}

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details
{
    public partial class Artist
    {
        public override int? Id
        {
            get { return ArtistId; }
            set { ArtistId = value; }
        }
    }

    public partial class Song
    {
        public override int? Id
        {
            get { return SongId; }
            set { SongId = value; }
        }
    }

    public partial class Album
    {
        public override int? Id
        {
            get { return AlbumId; }
            set { AlbumId = value; }
        }
    }
}