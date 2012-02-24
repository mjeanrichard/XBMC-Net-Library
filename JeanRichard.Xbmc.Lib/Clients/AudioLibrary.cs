using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.HttpClient;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class AudioLibrary
    {
        private const AlbumFields DefaultAlbumProperties = AlbumFields.All;
        private const ArtistFields DefaultArtistProperties = ArtistFields.All;
        private const SongFields DefaultSongProperties = SongFields.All;

        private static IEnumerable<JsonParam> GetLimitsParameter(int? startIndex, int? endIndex)
        {
            if (startIndex.HasValue || endIndex.HasValue)
            {
                Limits limits = new Limits();
                limits.Start = startIndex ?? 0;
                limits.End = endIndex;
                yield return new JsonParam("limits", limits);
            }
        }

        private static IEnumerable<JsonParam> GetOptionalParameter<T>(T? libraryId, string propertyName) where T : struct
        {
            if (libraryId.HasValue)
            {
                yield return new JsonParam(propertyName, libraryId);
            }
        }

        private readonly JsonRpcHttpClient _client;

        public AudioLibrary(JsonRpcHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve details about a specific album
        /// </summary>
        public void GetAlbum(Action<Album, ErrorData> resultAction, int albumId, AlbumFields? fields)
        {
            _client.Invoke("AudioLibrary.GetAlbumDetails", t => JsonRpcItem.LoadFrom<Album>(t, "albumdetails"), resultAction, new JsonParam("albumid", albumId), new JsonParam("properties", fields.HasValue ? fields : DefaultAlbumProperties));
        }

        /// <summary>
        /// Retrieve all albums
        /// </summary>
        public void GetAlbums(Action<MediaItemList<Album>, ErrorData> resultAction)
        {
            GetAlbums(resultAction, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        public void GetAlbums(Action<MediaItemList<Album>, ErrorData> resultAction, int? artistId, int? genreId)
        {
            GetAlbums(resultAction, artistId, genreId, null, null, null);
        }

        /// <summary>
        /// Retrieve all albums from specified artist or genre
        /// </summary>
        public void GetAlbums(Action<MediaItemList<Album>, ErrorData> resultAction, int? artistId, int? genreId, AlbumFields? fields, int? startIndex, int? endIndex)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(GetOptionalParameter(artistId, "artistid"));
            parameters.AddRange(GetOptionalParameter(genreId, "genreid"));
            parameters.AddRange(GetLimitsParameter(startIndex, endIndex));
            parameters.Add(new JsonParam("properties", fields.HasValue ? fields : DefaultAlbumProperties));

            _client.Invoke("AudioLibrary.GetAlbums", JsonRpcItem.LoadFrom<MediaItemList<Album>>, resultAction, parameters.ToArray());
        }

        /// <summary>
        /// Retrieve details about a specific artist
        /// </summary>
        public void GetArtist(Action<Artist, ErrorData> resultAction, int artistId, ArtistFields? fields)
        {
            _client.Invoke("AudioLibrary.GetArtistDetails", t => JsonRpcItem.LoadFrom<Artist>(t, "artistdetails"), resultAction, new JsonParam("artistid", artistId), new JsonParam("properties", fields.HasValue ? fields : DefaultArtistProperties));
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        public void GetArtists(Action<MediaItemList<Artist>, ErrorData> resultAction, bool? albumArtistsOnly, int? genreId)
        {
            GetArtists(resultAction, albumArtistsOnly, genreId, null, null, null);
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        public void GetArtists(Action<MediaItemList<Artist>, ErrorData> resultAction)
        {
            GetArtists(resultAction, null, null, null, null, null);
        }

        /// <summary>
        /// Retrieve all artists
        /// </summary>
        /// <param name="albumArtistsOnly">Whether or not to include artists only appearing in compilations. If the parameter is not passed or is passed as null the GUI setting will be used</param>
        public void GetArtists(Action<MediaItemList<Artist>, ErrorData> resultAction, bool? albumArtistsOnly, int? genreId, ArtistFields? fields, int? startIndex, int? endIndex)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(GetOptionalParameter(genreId, "genreid"));
            parameters.AddRange(GetOptionalParameter(albumArtistsOnly, "albumartistsonly"));
            parameters.AddRange(GetLimitsParameter(startIndex, endIndex));
            parameters.Add(new JsonParam("properties", fields.HasValue ? fields : DefaultArtistProperties));

            _client.Invoke("AudioLibrary.GetArtists", JsonRpcItem.LoadFrom<MediaItemList<Artist>>, resultAction, parameters.ToArray());
        }

        /// <summary>
        /// Retrieve details about a specific song
        /// </summary>
        public void GetSong(Action<Song, ErrorData> resultAction, int songId, SongFields? fields)
        {
            _client.Invoke("AudioLibrary.GetSongDetails", t => JsonRpcItem.LoadFrom<Song>(t, "songdetails"), resultAction, new JsonParam("songid", songId), new JsonParam("properties", fields.HasValue ? fields : DefaultSongProperties));
        }

        /// <summary>
        /// Retrieve all songs from specified album, artist or genre
        /// </summary>
        public void GetSongs(Action<MediaItemList<Song>, ErrorData> resultAction, int? artistId, int? albumId, int? genreId)
        {
            GetSongs(resultAction, artistId, albumId, genreId, null, null, null);
        }

        /// <summary>
        /// Retrieve all songs from specified album, artist or genre
        /// </summary>
        public void GetSongs(Action<MediaItemList<Song>, ErrorData> resultAction, int? artistId, int? albumId, int? genreId, SongFields? fields, int? startIndex, int? endIndex)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.AddRange(GetOptionalParameter(artistId, "artistid"));
            parameters.AddRange(GetOptionalParameter(albumId, "albumid"));
            parameters.AddRange(GetOptionalParameter(genreId, "genreid"));
            parameters.AddRange(GetLimitsParameter(startIndex, endIndex));
            parameters.Add(new JsonParam("properties", fields.HasValue ? fields : DefaultSongProperties));

            _client.Invoke("AudioLibrary.GetSongs", JsonRpcItem.LoadFrom<MediaItemList<Song>>, resultAction, parameters.ToArray());
        }

        /// <summary>
        /// Scans the audio sources for new library items
        /// </summary>
        public void Scan(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("AudioLibrary.Scan", resultAction);
        }
    }
}