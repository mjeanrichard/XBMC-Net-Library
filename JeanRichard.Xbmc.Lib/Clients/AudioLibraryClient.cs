using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.JsonRpc.HttpClient;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class AudioLibraryClient : IAudioLibraryClient
    {
        private static readonly AlbumFields DefaultAlbumProperties = AlbumFields.All;
        private static readonly ArtistFields DefaultArtistProperties = ArtistFields.All;
        private static readonly SongFields DefaultSongProperties = SongFields.All;

        private readonly AsyncHttpClient _client;

        public AudioLibraryClient(AsyncHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve details about a specific album
        /// </summary>
        public async Task<Album> GetAlbum(int albumId, AlbumFields fields)
        {
            return await _client.PostAsync("AudioLibrary.GetAlbumDetails", t => JsonRpcItem.LoadFrom<Album>(t, "albumdetails"), new JsonParam("albumid", albumId), new JsonParam("properties", fields ?? DefaultAlbumProperties));
        }

        /// <summary>
        /// Retrieve all albums
        /// </summary>
        public async Task<IMediaItemList<Album>> GetAlbums()
        {
            return await GetAlbums(null, null, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        public async Task<IMediaItemList<Album>> GetAlbums(int? artistId, int? genreId)
        {
            return await GetAlbums(artistId, genreId, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        public async Task<IMediaItemList<Album>> GetAlbums(int? artistId, int? genreId, AlbumFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(ClientUtils.GetOptionalParameter(artistId, "artistid"));
            parameters.AddRange(ClientUtils.GetOptionalParameter(genreId, "genreid"));
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.AddRange(ClientUtils.GetSortOrderParameter(sortMethod, order));
            parameters.Add(new JsonParam("properties", fields ?? DefaultAlbumProperties));

            return await _client.PostAsync("AudioLibrary.GetAlbums", JsonRpcItem.LoadFrom<MediaItemList<Album>>, parameters.ToArray());
        }

        /// <summary>
        /// Retrieve details about a specific artist
        /// </summary>
        public async Task<Artist> GetArtist(int artistId, ArtistFields fields)
        {
            return await _client.PostAsync("AudioLibrary.GetArtistDetails", t => JsonRpcItem.LoadFrom<Artist>(t, "artistdetails"), new JsonParam("artistid", artistId), new JsonParam("properties", fields ?? DefaultArtistProperties));
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        public async Task<IMediaItemList<Artist>> GetArtists(bool? albumArtistsOnly, int? genreId)
        {
            return await GetArtists(albumArtistsOnly, genreId, null, null, null);
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        public async Task<IMediaItemList<Artist>> GetArtists()
        {
            return await GetArtists(null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        /// <param name="albumArtistsOnly">Whether or not to include artists only appearing in compilations. If the parameter is not passed or is passed as null the GUI setting will be used</param>
        public async Task<IMediaItemList<Artist>> GetArtists(bool? albumArtistsOnly, int? genreId, ArtistFields fields, int? startIndex, int? endIndex)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(ClientUtils.GetOptionalParameter(genreId, "genreid"));
            parameters.AddRange(ClientUtils.GetOptionalParameter(albumArtistsOnly, "albumartistsonly"));
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.Add(new JsonParam("properties", fields ?? DefaultArtistProperties));

            return await _client.PostAsync("AudioLibrary.GetArtists", JsonRpcItem.LoadFrom<MediaItemList<Artist>>, parameters.ToArray());
        }

        /// <summary>
        /// Retrieve details about a specific song
        /// </summary>
        public async Task<Song> GetSong(int songId, SongFields fields)
        {
            return await _client.PostAsync("AudioLibrary.GetSongDetails", t => JsonRpcItem.LoadFrom<Song>(t, "songdetails"), new JsonParam("songid", songId), new JsonParam("properties", fields ?? DefaultSongProperties));
        }

        /// <summary>
        /// Retrieve all songs from specified album, artist or genre
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongs(int? artistId, int? albumId, int? genreId)
        {
            return await GetSongs(artistId, albumId, genreId, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all songs from specified album, artist or genre
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongs(int? artistId, int? albumId, int? genreId, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(ClientUtils.GetOptionalParameter(artistId, "artistid"));
            parameters.AddRange(ClientUtils.GetOptionalParameter(albumId, "albumid"));
            parameters.AddRange(ClientUtils.GetOptionalParameter(genreId, "genreid"));
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.AddRange(ClientUtils.GetSortOrderParameter(sortMethod, order));
            parameters.Add(new JsonParam("properties", fields ?? DefaultSongProperties));

            return await _client.PostAsync("AudioLibrary.GetSongs", JsonRpcItem.LoadFrom<MediaItemList<Song>>, parameters.ToArray());
        }

        /// <summary>
        /// Scans the audio sources for new library items
        /// </summary>
        public async Task Scan()
        {
            await _client.PostWithoutResult("AudioLibrary.Scan");
        }
    }
}