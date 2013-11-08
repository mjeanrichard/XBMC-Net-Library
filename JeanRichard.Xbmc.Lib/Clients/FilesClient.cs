using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class FilesClient
    {
        private readonly AsyncHttpClient _client;

        public FilesClient(AsyncHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Zoom out once
        /// </summary>
        public async Task GetPlaylists()
        {
            //await _client.PostWithoutResultAsync("Player.ZoomOut", new JsonParam("playerid", player.Id));
        }
    }
}