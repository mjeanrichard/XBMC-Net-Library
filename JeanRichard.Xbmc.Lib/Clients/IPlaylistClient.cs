using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public interface IPlaylistClient
    {
        /// <summary>
        /// Clear playlist
        /// </summary>
        void Add(Action<bool, ErrorData> resultAction, Playlist playlist, MediaDetailsBase item);

        /// <summary>
        /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        void Insert(Action<bool, ErrorData> resultAction, Playlist playlist, int position, MediaDetailsBase item);

        /// <summary>
        /// Remove item from playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        void Remove(Action<bool, ErrorData> resultAction, Playlist playlist, int position);

        /// <summary>
        /// Swap items in the playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        void Swap(Action<bool, ErrorData> resultAction, Playlist playlist, int position1, int position2);

        /// <summary>
        /// Clear playlist
        /// </summary>
        void Clear(Action<bool, ErrorData> resultAction, Playlist playlist);

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        void GetItems(Action<IMediaItemList<MediaDetailsBase>, ErrorData> resultAction, Playlist playlist);

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        void GetItems(Action<IMediaItemList<MediaDetailsBase>, ErrorData> resultAction, Playlist playlist, AllFields? fields, int? startIndex, int? endIndex);

        /// <summary>
        /// Returns all existing playlists
        /// </summary>
        void GetPlaylists(Action<IEnumerable<Playlist>, ErrorData> resultAction);
    }
}