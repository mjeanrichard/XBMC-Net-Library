using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class PlaylistClient : BaseClient, IPlaylistClient
    {
        protected static JsonParam GetMediaItemParam(MediaDetailsBase mediaItem)
        {
            Type typeName = mediaItem.GetType();
            string idName;
            if (typeName == typeof(Song))
            {
                idName = "songid";
            }
            else if (typeName == typeof(Artist))
            {
                idName = "artistid";
            }
            else if (typeName == typeof(Album))
            {
                idName = "albumid";
            }
            else
            {
                throw new ArgumentOutOfRangeException("mediaItem", String.Format("MediaItemType [{0}] is unknown.", typeName));
            }
            return new JsonParamObject("item", new JsonParam(idName, mediaItem.Id));
        }

        private readonly AsyncHttpClient _client;
        private readonly JsonRpcSerializer _serializer;

        public PlaylistClient(AsyncHttpClient client, JsonRpcSerializer serializer)
        {
            _client = client;
            _serializer = serializer;
        }

        /// <summary>
        /// Clear playlist
        /// </summary>
        public async Task Add(Playlist playlist, MediaDetailsBase item)
        {
            JsonParam itemParam = GetMediaItemParam(item);
            await _client.PostWithoutResultAsync("Playlist.Add", new JsonParam("playlistid", playlist.Id), itemParam);
        }

        /// <summary>
        /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public async Task Insert(Playlist playlist, int position, MediaDetailsBase item)
        {
            JsonParam itemParam = GetMediaItemParam(item);
            await _client.PostWithoutResultAsync("Playlist.Insert", new JsonParam("playlistid", playlist.Id), new JsonParam("position", position), itemParam);
        }

        /// <summary>
        /// Remove item from playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public async Task Remove(Playlist playlist, int position)
        {
            await _client.PostWithoutResultAsync("Playlist.Remove", new JsonParam("playlistid", playlist.Id), new JsonParam("position", position));
        }

        /// <summary>
        /// Swap items in the playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public async Task Swap(Playlist playlist, int position1, int position2)
        {
            await _client.PostWithoutResultAsync("Playlist.Swap", new JsonParam("playlistid", playlist.Id), new JsonParam("position1", position1), new JsonParam("position2", position2));
        }

        /// <summary>
        /// Clear playlist
        /// </summary>
        public async Task Clear(Playlist playlist)
        {
            await _client.PostWithoutResultAsync("Playlist.Clear", new JsonParam("playlistid", playlist.Id));
        }

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        public async Task<IMediaItemList<MediaDetailsBase>> GetItems(Playlist playlist)
        {
            return await GetItems(playlist, null, null, null);
        }

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        public async Task<IMediaItemList<MediaDetailsBase>> GetItems(Playlist playlist, AllFields fields, int? startIndex, int? endIndex)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.Add(new JsonParam("playlistid", playlist.Id));
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.Add(new JsonParam("properties", fields ?? AllFields.All));
            return await _client.PostAsync("Playlist.GetItems", _serializer.Parse<MediaItemList<MediaDetailsBase>>, parameters.ToArray());
        }

        /// <summary>
        /// Returns all existing playlists
        /// </summary>
        public async Task<IEnumerable<Playlist>> GetPlaylists()
        {
            return await _client.PostAsync("Playlist.GetPlaylists", _serializer.Parse<IEnumerable<Playlist>>);
        }
    }
}