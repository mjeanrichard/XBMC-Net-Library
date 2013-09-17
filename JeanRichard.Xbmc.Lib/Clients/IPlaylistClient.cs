using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        Task Add(Playlist playlist, MediaDetailsBase item);

        /// <summary>
        /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        Task Insert(Playlist playlist, int position, MediaDetailsBase item);

        /// <summary>
        /// Remove item from playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        Task Remove(Playlist playlist, int position);

        /// <summary>
        /// Swap items in the playlist. Does not work for picture playlists (aka slideshows).
        /// </summary>
        Task Swap(Playlist playlist, int position1, int position2);

        /// <summary>
        /// Clear playlist
        /// </summary>
        Task Clear(Playlist playlist);

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        Task<IMediaItemList<MediaDetailsBase>> GetItems(Playlist playlist);

        /// <summary>
        /// Get all items from playlist
        /// </summary>
        Task<IMediaItemList<MediaDetailsBase>> GetItems(Playlist playlist, AllFields fields, int? startIndex, int? endIndex);

        /// <summary>
        /// Returns all existing playlists
        /// </summary>
        Task<IEnumerable<Playlist>> GetPlaylists();
    }
}