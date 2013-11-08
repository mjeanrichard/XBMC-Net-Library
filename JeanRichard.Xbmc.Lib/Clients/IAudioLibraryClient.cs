using System;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public interface IAudioLibraryClient
    {
        /// <summary>
        /// Retrieve details about a specific album
        /// </summary>
        Task<Album> GetAlbum(int albumId, AlbumFields fields);

        /// <summary>
        /// Retrieve all albums
        /// </summary>
        Task<IMediaItemList<Album>> GetAlbums();

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        Task<IMediaItemList<Album>> GetAlbums(int? artistId, int? genreId);

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        Task<IMediaItemList<Album>> GetAlbums(int? artistId, int? genreId, AlbumFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order);

        /// <summary>
        /// Retrieve details about a specific artist
        /// </summary>
        Task<Artist> GetArtist(int artistId, ArtistFields fields);

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        Task<IMediaItemList<Artist>> GetArtists(bool? albumArtistsOnly, int? genreId);

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        Task<IMediaItemList<Artist>> GetArtists();

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        /// <param name="albumArtistsOnly">Whether or not to include artists only appearing in compilations. If the parameter is not passed or is passed as null the GUI setting will be used</param>
        Task<IMediaItemList<Artist>> GetArtists(bool? albumArtistsOnly, int? genreId, ArtistFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order);

        /// <summary>
        /// Retrieve details about a specific song
        /// </summary>
        Task<Song> GetSong(int songId, SongFields fields);

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        Task<IMediaItemList<Song>> GetSongsForArtist(int artistId);

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        Task<IMediaItemList<Song>> GetSongsForArtist(int artistId, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order);

        /// <summary>
        /// Retrieve all songs from specified album
        /// </summary>
        Task<IMediaItemList<Song>> GetSongsForAlbum(int albumId);

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        Task<IMediaItemList<Song>> GetSongsForAlbum(int albumId, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order);

        /// <summary>
        /// Retrieve all songs from specified genre
        /// </summary>
        Task<IMediaItemList<Song>> GetSongsForGenre(int genreId);

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        Task<IMediaItemList<Song>> GetSongsForGenre(int genreId, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order);

        /// <summary>
        /// Scans the audio sources for new library items
        /// </summary>
        Task Scan();

        Task SetSongRating(int? rating, int songId);

        /// <summary>
        /// Retrieve details about a specific song
        /// </summary>
        Task<Song> GetSong(int songId);
    }
}