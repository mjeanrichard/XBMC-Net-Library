using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class PlaylistClient : IPlaylistClient
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

        public PlaylistClient(AsyncHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Clear playlist
        /// </summary>
        public async Task Add(Playlist playlist, MediaDetailsBase item)
        {
            JsonParam itemParam = GetMediaItemParam(item);
            await _client.PostWithoutResult("Playlist.Add", new JsonParam("playlistid", playlist.Id), itemParam);
        }

        /// <summary>
        /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public async Task Insert(Playlist playlist, int position, MediaDetailsBase item)
        {
            JsonParam itemParam = GetMediaItemParam(item);
            await _client.PostWithoutResult("Playlist.Insert", new JsonParam("playlistid", playlist.Id), new JsonParam("position", position), itemParam);
        }

        /// <summary>
        /// Remove item from playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public async Task Remove(Playlist playlist, int position)
        {
            await _client.PostWithoutResult("Playlist.Remove", new JsonParam("playlistid", playlist.Id), new JsonParam("position", position));
        }

        /// <summary>
        /// Swap items in the playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public async Task Swap(Playlist playlist, int position1, int position2)
        {
            await _client.PostWithoutResult("Playlist.Swap", new JsonParam("playlistid", playlist.Id), new JsonParam("position1", position1), new JsonParam("position2", position2));
        }

        /// <summary>
        /// Clear playlist
        /// </summary>
        public async Task Clear(Playlist playlist)
        {
            await _client.PostWithoutResult("Playlist.Clear", new JsonParam("playlistid", playlist.Id));
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
            return await _client.PostAsync("Playlist.GetItems", ParsePlaylistItems, parameters.ToArray());
        }

        /// <summary>
        /// Returns all existing playlists
        /// </summary>
        public async Task<IEnumerable<Playlist>> GetPlaylists()
        {
            return await _client.PostAsync("Playlist.GetPlaylists", o => o.ParseJsonObjectArray<Playlist>());
        }

        private MediaItemList<MediaDetailsBase> ParsePlaylistItems(JToken token)
        {
            LimitsReturned limits = token.ParseJsonObject<LimitsReturned>("limits");
            MediaDetailsBase[] items = token.SelectToken("items").ParseJsonObjectArray(ClientUtils.CreateMediaDetails);
            return new MediaItemList<MediaDetailsBase>(items, limits);
        }
    }
}