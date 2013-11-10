using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Item;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class FilesClient : IFilesClient
    {
        private readonly AsyncHttpClient _client;
        private readonly JsonRpcSerializer _serializer;

        public FilesClient(AsyncHttpClient client, JsonRpcSerializer serializer)
        {
            _client = client;
            _serializer = serializer;
        }

        /// <summary>
        /// Get Music Playlists (from special Directory)
        /// </summary>
        public async Task<XbmcItemList<File>> GetMusicPlaylists()
        {
            return await GetFiles("special://musicplaylists");
        }

        /// <summary>
        /// Get Files and Directories
        /// </summary>
        public async Task<XbmcItemList<File>> GetFiles(string directory)
        {
            return await _client.PostAsync("Files.GetDirectory", t => _serializer.Parse<XbmcItemList<File>>(t), new JsonParam("directory", directory));
        }
    }
}