using System;

using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public interface IAudioLibraryClient
    {
        /// <summary>
        /// Retrieve details about a specific album
        /// </summary>
        void GetAlbum(Action<Album, ErrorData> resultAction, int albumId, AlbumFields? fields);

        /// <summary>
        /// Retrieve all albums
        /// </summary>
        void GetAlbums(Action<MediaItemList<Album>, ErrorData> resultAction);

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        void GetAlbums(Action<MediaItemList<Album>, ErrorData> resultAction, int? artistId, int? genreId);

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        void GetAlbums(Action<MediaItemList<Album>, ErrorData> resultAction, int? artistId, int? genreId, AlbumFields? fields, int? startIndex, int? endIndex);

        /// <summary>
        /// Retrieve details about a specific artist
        /// </summary>
        void GetArtist(Action<Artist, ErrorData> resultAction, int artistId, ArtistFields? fields);

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        void GetArtists(Action<MediaItemList<Artist>, ErrorData> resultAction, bool? albumArtistsOnly, int? genreId);

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        void GetArtists(Action<MediaItemList<Artist>, ErrorData> resultAction);

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        /// <param name="albumArtistsOnly">Whether or not to include artists only appearing in compilations. If the parameter is not passed or is passed as null the GUI setting will be used</param>
        void GetArtists(Action<MediaItemList<Artist>, ErrorData> resultAction, bool? albumArtistsOnly, int? genreId, ArtistFields? fields, int? startIndex, int? endIndex);

        /// <summary>
        /// Retrieve details about a specific song
        /// </summary>
        void GetSong(Action<Song, ErrorData> resultAction, int songId, SongFields? fields);

        /// <summary>
        /// Retrieve all songs from specified album, artist or genre
        /// </summary>
        void GetSongs(Action<MediaItemList<Song>, ErrorData> resultAction, int? artistId, int? albumId, int? genreId);

        /// <summary>
        /// Retrieve all songs from specified album, artist or genre
        /// </summary>
        void GetSongs(Action<MediaItemList<Song>, ErrorData> resultAction, int? artistId, int? albumId, int? genreId, SongFields? fields, int? startIndex, int? endIndex);

        /// <summary>
        /// Scans the audio sources for new library items
        /// </summary>
        void Scan(Action<bool, ErrorData> resultAction);
    }
}