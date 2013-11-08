using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class AudioLibraryClient : BaseClient, IAudioLibraryClient
    {
        private static readonly AlbumFields DefaultAlbumProperties = AlbumFields.All;
        private static readonly ArtistFields DefaultArtistProperties = ArtistFields.All;
        private static readonly SongFields DefaultSongProperties = SongFields.All;

        private readonly AsyncHttpClient _client;
        private readonly JsonRpcSerializer _serializer;

        public AudioLibraryClient(AsyncHttpClient client, JsonRpcSerializer serializer)
        {
            _client = client;
            _serializer = serializer;
        }

        /// <summary>
        /// Retrieve details about a specific album
        /// </summary>
        public async Task<Album> GetAlbum(int albumId, AlbumFields fields)
        {
            return await _client.PostAsync("AudioLibrary.GetAlbumDetails", t => _serializer.Parse<Album>(t, "albumdetails"), new JsonParam("albumid", albumId), new JsonParam("properties", fields ?? DefaultAlbumProperties));
        }

        /// <summary>
        /// Retrieve all albums
        /// </summary>
        public async Task<IMediaItemList<Album>> GetAlbums()
        {
            return await GetAlbums(null, null, null, null, null, SortMethods.Label, Orders.Ascending);
        }

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        public async Task<IMediaItemList<Album>> GetAlbums(int? artistId, int? genreId)
        {
            return await GetAlbums(artistId, genreId, null, null, null, SortMethods.Label, Orders.Ascending);
        }

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        public async Task<IMediaItemList<Album>> GetAlbums(int? artistId, int? genreId, AlbumFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.AddRange(ClientUtils.GetSortOrderParameter(sortMethod, order));
            parameters.Add(new JsonParam("properties", fields ?? DefaultAlbumProperties));

            List<JsonParam> filters = new List<JsonParam>();
            filters.AddRange(ClientUtils.GetOptionalParameter(artistId, "artistid"));
            filters.AddRange(ClientUtils.GetOptionalParameter(genreId, "genreid"));
            if (filters.Any())
            {
                JsonParamObject filter = new JsonParamObject("filter", filters.ToArray());
                parameters.Add(filter);
            }

            return await _client.PostAsync("AudioLibrary.GetAlbums", _serializer.Parse<MediaItemList<Album>>, parameters.ToArray());
        }

        /// <summary>
        /// Retrieve details about a specific artist
        /// </summary>
        public async Task<Artist> GetArtist(int artistId, ArtistFields fields)
        {
            return await _client.PostAsync("AudioLibrary.GetArtistDetails", t => _serializer.Parse<Artist>(t, "artistdetails"), new JsonParam("artistid", artistId), new JsonParam("properties", fields ?? DefaultArtistProperties));
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        public async Task<IMediaItemList<Artist>> GetArtists(bool? albumArtistsOnly, int? genreId)
        {
            return await GetArtists(albumArtistsOnly, genreId, null, null, null, SortMethods.Label, Orders.Ascending);
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        public async Task<IMediaItemList<Artist>> GetArtists()
        {
            return await GetArtists(null, null, null, null, null, SortMethods.Label, Orders.Ascending);
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        /// <param name="albumArtistsOnly">Whether or not to include artists only appearing in compilations. If the parameter is not passed or is passed as null the GUI setting will be used</param>
        public async Task<IMediaItemList<Artist>> GetArtists(bool? albumArtistsOnly, int? genreId, ArtistFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(ClientUtils.GetOptionalParameter(genreId, "genreid"));
            parameters.AddRange(ClientUtils.GetOptionalParameter(albumArtistsOnly, "albumartistsonly"));
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.Add(new JsonParam("properties", fields ?? DefaultArtistProperties));

            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.AddRange(ClientUtils.GetSortOrderParameter(sortMethod, order));

            return await _client.PostAsync("AudioLibrary.GetArtists", t => _serializer.Parse<MediaItemList<Artist>>(t), parameters.ToArray());
        }

        /// <summary>
        /// Retrieve details about a specific song
        /// </summary>
        public async Task<Song> GetSong(int songId, SongFields fields)
        {
            return await _client.PostAsync("AudioLibrary.GetSongDetails", t => _serializer.Parse<Song>(t, "songdetails"), new JsonParam("songid", songId), new JsonParam("properties", fields ?? DefaultSongProperties));
        }


        /// <summary>
        /// Retrieve details about a specific song
        /// </summary>
        public async Task<Song> GetSong(int songId)
        {
            return await GetSong(songId, DefaultSongProperties);
        }

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongsForArtist(int artistId)
        {
            return await GetSongs("artistid", artistId, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongsForArtist(int artistId, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            return await GetSongs("artistid", artistId, fields, startIndex, endIndex, sortMethod, order);
        }


        /// <summary>
        /// Retrieve all songs from specified album
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongsForAlbum(int albumId)
        {
            return await GetSongs("albumid", albumId, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongsForAlbum(int albumId, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            return await GetSongs("albumid", albumId, fields, startIndex, endIndex, sortMethod, order);
        }


        /// <summary>
        /// Retrieve all songs from specified genre
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongsForGenre(int genreId)
        {
            return await GetSongs("genreid", genreId, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all songs from specified artist
        /// </summary>
        public async Task<IMediaItemList<Song>> GetSongsForGenre(int genreId, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            return await GetSongs("genreid", genreId, fields, startIndex, endIndex, sortMethod, order);
        }

        /// <summary>
        /// Set the Rating of a Song
        /// </summary>
        public async Task SetSongRating(int? rating, int songId)
        {
            await _client.PostWithoutResultAsync("AudioLibrary.SetSongDetails", new JsonParam("songid", songId), new JsonParam("rating", rating));
        }

        /// <summary>
        /// Scans the audio sources for new library items
        /// </summary>
        public async Task Scan()
        {
            await _client.PostWithoutResultAsync("AudioLibrary.Scan");
        }

        protected async Task<IMediaItemList<Song>> GetSongs(string filterName, int id, SongFields fields, int? startIndex, int? endIndex, SortMethods? sortMethod, Orders? order)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.Add(new JsonParamObject("filter", new JsonParam(filterName, id)));
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.AddRange(ClientUtils.GetSortOrderParameter(sortMethod, order));
            parameters.Add(new JsonParam("properties", fields ?? DefaultSongProperties));

            return await _client.PostAsync("AudioLibrary.GetSongs", _serializer.Parse<MediaItemList<Song>>, parameters.ToArray());
        }
    }
}