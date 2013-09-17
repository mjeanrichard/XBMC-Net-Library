using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.XbmcEntities.Global;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player.Property;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class PlayerClient : IPlayerClient
    {
        private static readonly PlayerPropertyFields[] DefaultPlayerProperties = new[] { PlayerPropertyFields.Type, PlayerPropertyFields.Percentage, PlayerPropertyFields.PlaylistId, PlayerPropertyFields.Position, PlayerPropertyFields.Time, PlayerPropertyFields.TotalTime, PlayerPropertyFields.Shuffled, PlayerPropertyFields.Partymode, PlayerPropertyFields.Repeat, PlayerPropertyFields.Speed };
        private static readonly AllFields ItemProperties = AllFields.Title | AllFields.Thumbnail | AllFields.Track | AllFields.Rating | AllFields.PlayCount | AllFields.FanArt | AllFields.Genre | AllFields.File | AllFields.ArtistId | AllFields.Artist | AllFields.AlbumId | AllFields.Album;
        private readonly AsyncHttpClient _client;

        public PlayerClient(AsyncHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns all active players
        /// </summary>
        public async Task<IEnumerable<XbmcPlayer>> GetActivePlayers()
        {
            return await _client.PostAsync("Player.GetActivePlayers", o => o.ParseJsonObjectArray<XbmcPlayer>());
        }

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        public async Task<MediaDetailsBase> GetItem(XbmcPlayer player)
        {
            return await _client.PostAsync("Player.GetItem", t => ClientUtils.CreateMediaDetails(t.GetItem()), new JsonParam("playerid", player.Id), new JsonParam("properties", ItemProperties));
        }

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        public async Task<PlayerProperties> GetProperties(XbmcPlayer player)
        {
            return await _client.PostAsync("Player.GetProperties", JsonRpcItem.LoadFrom<PlayerProperties>, new JsonParam("playerid", player.Id), new JsonParam("properties", DefaultPlayerProperties));
        }

        /// <summary>
        /// Go to next item on the playlist
        /// </summary>
        public async Task GoNext(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.GoNext", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Go to previous item on the playlist
        /// </summary>
        public async Task GoPrevious(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.GoPrevious", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Go to item at the given position in the playlist
        /// </summary>
        public async Task GoTo(int position, XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.GoTo", new JsonParam("playerid", player.Id), new JsonParam("position", position));
        }

        /// <summary>
        /// If picture is zoomed move viewport down
        /// </summary>
        public async Task MoveDown(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.MoveDown", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// If picture is zoomed move viewport left otherwise skip previous
        /// </summary>
        public async Task MoveLeft(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.MoveLeft", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// If picture is zoomed move viewport right otherwise skip next
        /// </summary>
        public async Task MoveRight(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.MoveRight", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// If picture is zoomed move viewport up
        /// </summary>
        public async Task MoveUp(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.MoveUp", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Start playback of the playlist with the given ID
        /// </summary>
        public async Task Open(int playlistId, int playlistPosition)
        {
            await _client.PostWithoutResult("Player.Open", new JsonParam("playlistid", playlistId), new JsonParam("position", playlistPosition));
        }

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        public async Task Open(string path, bool random, bool recursive)
        {
            await _client.PostWithoutResult("Player.Open", new JsonParamObject("item", new JsonParam("path", path), new JsonParam("random", random), new JsonParam("recursive", recursive)));
        }

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        public async Task OpenAlbum(int albumId)
        {
            await _client.PostWithoutResult("Player.Open", new JsonParamObject("item", new JsonParam("albumid", albumId)));
        }

        /// <summary>
        /// Pauses or unpause playback and returns the new state
        /// </summary>
        public async Task<PlayerSpeed> PlayPause(XbmcPlayer player)
        {
            return await _client.PostAsync("Player.PlayPause", JsonRpcItem.LoadFrom<PlayerSpeed>, new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Set the repeat mode of the player
        /// </summary>
        public async Task Repeat(XbmcPlayer player, Repeat state)
        {
            await _client.PostWithoutResult("Player.Repeat",  new JsonParam("playerid", player.Id), new JsonParam("state", state));
        }

        /// <summary>
        /// Rotates current picture
        /// </summary>
        public async Task Rotate(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.Rotate", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Seek through the playing item by percentage
        /// </summary>
        public async Task<PlayerPosition> Seek(XbmcPlayer player, decimal percentage)
        {
            return await _client.PostAsync("Player.Seek", JsonRpcItem.LoadFrom<PlayerPosition>, new JsonParam("playerid", player.Id), new JsonParam("value", percentage));
        }

        /// <summary>
        /// Seek through the playing item by time
        /// </summary>
        public async Task<PlayerPosition> Seek(XbmcPlayer player, Time time)
        {
            return await _client.PostAsync("Player.Seek", JsonRpcItem.LoadFrom<PlayerPosition>, new JsonParam("playerid", player.Id), new JsonParam("value", time));
        }

        /// <summary>
        /// Seek by predefined jumps
        /// </summary>
        public async Task<PlayerPosition> Seek(XbmcPlayer player, SeekJumps seekJump)
        {
            return await _client.PostAsync("Player.Seek", JsonRpcItem.LoadFrom<PlayerPosition>, new JsonParam("playerid", player.Id), new JsonParam("value", seekJump));
        }

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        /// <param name="streamIndex">Index of the audio stream to play</param>
        public async Task SetAudioStream(XbmcPlayer player, int streamIndex)
        {
            await _client.PostWithoutResult("Player.SetAudioStream", new JsonParam("playerid", player.Id), new JsonParam("stream", streamIndex));
        }

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        public async Task SetAudioStream(XbmcPlayer player, SetAudioStreamMode stream)
        {
            await _client.PostWithoutResult("Player.SetAudioStream", new JsonParam("playerid", player.Id), new JsonParam("stream", stream));
        }

        /// <summary>
        /// Set the speed of the current playback
        /// </summary>
        public async Task<PlayerSpeed> SetSpeed(XbmcPlayer player, SpeedNumeric speed)
        {
            return await _client.PostAsync("Player.SetSpeed", JsonRpcItem.LoadFrom<PlayerSpeed>, new JsonParam("playerid", player.Id), new JsonParam("speed", speed));
        }

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        public async Task SetSubtitle(XbmcPlayer player, int subtitleIndex)
        {
            await _client.PostWithoutResult("Player.SetSubtitle", new JsonParam("playerid", player.Id), new JsonParam("subtitle", subtitleIndex));
        }

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        public async Task SetSubtitle(XbmcPlayer player, SubtitleMode subtitle)
        {
            await _client.PostWithoutResult("Player.SetSubtitle", new JsonParam("playerid", player.Id), new JsonParam("subtitle", subtitle));
        }

        /// <summary>
        /// Shuffle items in the player
        /// </summary>
        public async Task Shuffle(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.Shuffle", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Stops playback
        /// </summary>
        public async Task Stop(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.Stop", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Unshuffle items in the player
        /// </summary>
        public async Task UnShuffle(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.UnShuffle", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Zooms current picture
        /// </summary>
        /// <param name="zoomLevel">Zoom level (1-10)</param>
        public async Task Zoom(XbmcPlayer player, int zoomLevel)
        {
            await _client.PostWithoutResult("Player.Zoom", new JsonParam("playerid", player.Id), new JsonParam("value", zoomLevel));
        }

        /// <summary>
        /// Zoom in once
        /// </summary>
        public async Task ZoomIn(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.ZoomIn", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Zoom out once
        /// </summary>
        public async Task ZoomOut(XbmcPlayer player)
        {
            await _client.PostWithoutResult("Player.ZoomOut", new JsonParam("playerid", player.Id));
        }
    }
}