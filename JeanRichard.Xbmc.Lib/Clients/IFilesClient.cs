using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Item;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public interface IFilesClient
    {
        /// <summary>
        /// Get Music Playlists (from special Directory)
        /// </summary>
        Task<XbmcItemList<File>> GetMusicPlaylists();

        /// <summary>
        /// Get Files and Directories
        /// </summary>
        Task<XbmcItemList<File>> GetFiles(string directory);
    }
}