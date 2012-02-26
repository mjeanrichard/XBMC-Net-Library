using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class PlaylistClient : IPlaylistClient
    {
        public static JsonParam GetMediaItemParam(MediaDetailsBase mediaItem)
        {
            Type typeName = mediaItem.GetType();
            string idName = null;
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

        private readonly IRpcClient _client;

        public PlaylistClient(IRpcClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Clear playlist
        /// </summary>
        public void Add(Action<bool, ErrorData> resultAction, Playlist playlist, MediaDetailsBase item)
        {
            JsonParam itemParam = GetMediaItemParam(item);
            _client.InvokeForOkResult("Playlist.Add", resultAction, new JsonParam("playlistid", playlist.Id), itemParam);
        }

        /// <summary>
        /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public void Insert(Action<bool, ErrorData> resultAction, Playlist playlist, int position, MediaDetailsBase item)
        {
            JsonParam itemParam = GetMediaItemParam(item);
            _client.InvokeForOkResult("Playlist.Insert", resultAction, new JsonParam("playlistid", playlist.Id), new JsonParam("position", position), itemParam);
        }

        /// <summary>
        /// Remove item from playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public void Remove(Action<bool, ErrorData> resultAction, Playlist playlist, int position)
        {
            _client.InvokeForOkResult("Playlist.Remove", resultAction, new JsonParam("playlistid", playlist.Id), new JsonParam("position", position));
        }

        /// <summary>
        /// Swap items in the playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        public void Swap(Action<bool, ErrorData> resultAction, Playlist playlist, int position1, int position2)
        {
            _client.InvokeForOkResult("Playlist.Swap", resultAction, new JsonParam("playlistid", playlist.Id), new JsonParam("position1", position1), new JsonParam("position2", position2));
        }

        /// <summary>
        /// Clear playlist
        /// </summary>
        public void Clear(Action<bool, ErrorData> resultAction, Playlist playlist)
        {
            _client.InvokeForOkResult("Playlist.Clear", resultAction, new JsonParam("playlistid", playlist.Id));
        }

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        public void GetItems(Action<MediaItemList<MediaDetailsBase>, ErrorData> resultAction, Playlist playlist)
        {
            GetItems(resultAction, playlist, null, null, null);
        }

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        public void GetItems(Action<MediaItemList<MediaDetailsBase>, ErrorData> resultAction, Playlist playlist, AllFields? fields, int? startIndex, int? endIndex)
        {
            List<JsonParam> parameters = new List<JsonParam>();
            parameters.Add(new JsonParam("playlistid", playlist.Id));
            parameters.AddRange(ClientUtils.GetLimitsParameter(startIndex, endIndex));
            parameters.Add(new JsonParam("properties", fields.HasValue ? fields : AllFields.All));
            _client.Invoke("Playlist.GetItems", ParsePlaylistItems, resultAction, parameters.ToArray());
        }

        /// <summary>
        /// Returns all existing playlists
        /// </summary>
        public void GetPlaylists(Action<IEnumerable<Playlist>, ErrorData> resultAction)
        {
            _client.Invoke("Playlist.GetPlaylists", o => o.ParseJsonObjectArray<Playlist>(), resultAction);
        }

        private MediaItemList<MediaDetailsBase> ParsePlaylistItems(JToken token)
        {
            LimitsReturned limits = token.ParseJsonObject<LimitsReturned>("limits");
            MediaDetailsBase[] items = token.SelectToken("items").ParseJsonObjectArray(ClientUtils.CreateMediaDetails);
            return new MediaItemList<MediaDetailsBase>(items, limits);
        }
    }
}