using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.XbmcEntities.Global;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player.Property;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class PlayerClient : BaseClient, IPlayerClient
    {
        private static readonly PlayerPropertyFields[] DefaultPlayerProperties = {PlayerPropertyFields.Type, PlayerPropertyFields.Percentage, PlayerPropertyFields.PlaylistId, PlayerPropertyFields.Position, PlayerPropertyFields.Time, PlayerPropertyFields.TotalTime, PlayerPropertyFields.Shuffled, PlayerPropertyFields.Partymode, PlayerPropertyFields.Repeat, PlayerPropertyFields.Speed};
        private static readonly AllFields ItemProperties = AllFields.Title | AllFields.Thumbnail | AllFields.Track | AllFields.Rating | AllFields.PlayCount | AllFields.FanArt | AllFields.Genre | AllFields.File | AllFields.ArtistId | AllFields.Artist | AllFields.AlbumId | AllFields.Album;
        private readonly AsyncHttpClient _client;
        private readonly JsonRpcSerializer _jsonRpcSerializer;

        public PlayerClient(AsyncHttpClient client, JsonRpcSerializer jsonRpcSerializer)
        {
            _client = client;
            _jsonRpcSerializer = jsonRpcSerializer;
        }

        /// <summary>
        /// Returns all active players
        /// </summary>
        public async Task<IEnumerable<XbmcPlayer>> GetActivePlayers()
        {
            return await _client.PostAsync("Player.GetActivePlayers", _jsonRpcSerializer.Parse<IEnumerable<XbmcPlayer>>);
        }

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        public async Task<MediaDetailsBase> GetItem(XbmcPlayer player)
        {
            return await _client.PostAsync("Player.GetItem", t => _jsonRpcSerializer.Parse<MediaDetailsBase>(t, "item"), new JsonParam("playerid", player.Id), new JsonParam("properties", ItemProperties));
        }

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        public async Task<PlayerProperties> GetProperties(XbmcPlayer player)
        {
            return await _client.PostAsync("Player.GetProperties", _jsonRpcSerializer.Parse<PlayerProperties>, new JsonParam("playerid", player.Id), new JsonParam("properties", DefaultPlayerProperties));
        }

        /// <summary>
        /// Go to next item on the playlist
        /// </summary>
        public async Task GoNext(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.GoTo", new JsonParam("playerid", player.Id), new JsonParam("to", "next"));
        }

        /// <summary>
        /// Go to previous item on the playlist
        /// </summary>
        public async Task GoPrevious(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.GoTo", new JsonParam("playerid", player.Id), new JsonParam("to", "previous"));
        }

        /// <summary>
        /// Go to item at the given position in the playlist
        /// </summary>
        public async Task GoTo(int position, XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.GoTo", new JsonParam("playerid", player.Id), new JsonParam("to", position));
        }

        /// <summary>
        /// If picture is zoomed move viewport down
        /// </summary>
        public async Task MoveDown(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.Move", new JsonParam("playerid", player.Id), new JsonParam("direction", "down"));
        }

        /// <summary>
        /// If picture is zoomed move viewport left otherwise skip previous
        /// </summary>
        public async Task MoveLeft(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.Move", new JsonParam("playerid", player.Id), new JsonParam("direction", "left"));
        }

        /// <summary>
        /// If picture is zoomed move viewport right otherwise skip next
        /// </summary>
        public async Task MoveRight(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.Move", new JsonParam("playerid", player.Id), new JsonParam("direction", "right"));
        }

        /// <summary>
        /// If picture is zoomed move viewport up
        /// </summary>
        public async Task MoveUp(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.Move", new JsonParam("playerid", player.Id), new JsonParam("direction", "up"));
        }

        /// <summary>
        /// Start playback of the playlist with the given ID
        /// </summary>
        public async Task Open(int playlistId, int playlistPosition)
        {
            await _client.PostWithoutResultAsync("Player.Open", new JsonParamObject("item", new JsonParam("playlistid", playlistId), new JsonParam("position", playlistPosition)));
        }

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        public async Task Open(string path, bool random, bool recursive)
        {
            await _client.PostWithoutResultAsync("Player.Open", new JsonParamObject("item", new JsonParam("path", path), new JsonParam("random", random), new JsonParam("recursive", recursive)));
        }

        /// <summary>
        /// Start playback of a album
        /// </summary>
        public async Task OpenLibraryItem(int itemId)
        {
            await _client.PostWithoutResultAsync("Player.Open", new JsonParamObject("item", new JsonParam("channelid", itemId)));
        }

        /// <summary>
        /// Pauses or unpause playback and returns the new state
        /// </summary>
        public async Task<PlayerSpeed> PlayPauseToggle(XbmcPlayer player)
        {
            return await _client.PostAsync("Player.PlayPause", _jsonRpcSerializer.Parse<PlayerSpeed>, new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Rotates current picture
        /// </summary>
        public async Task Rotate(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.Rotate", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Seek through the playing item by percentage
        /// </summary>
        public async Task<PlayerPosition> Seek(XbmcPlayer player, decimal percentage)
        {
            return await _client.PostAsync("Player.Seek", _jsonRpcSerializer.Parse<PlayerPosition>, new JsonParam("playerid", player.Id), new JsonParam("value", percentage));
        }

        /// <summary>
        /// Seek through the playing item by time
        /// </summary>
        public async Task<PlayerPosition> Seek(XbmcPlayer player, Time time)
        {
            return await _client.PostAsync("Player.Seek", _jsonRpcSerializer.Parse<PlayerPosition>, new JsonParam("playerid", player.Id), new JsonParam("value", time));
        }

        /// <summary>
        /// Seek by predefined jumps
        /// </summary>
        public async Task<PlayerPosition> Seek(XbmcPlayer player, SeekJumps seekJump)
        {
            return await _client.PostAsync("Player.Seek", _jsonRpcSerializer.Parse<PlayerPosition>, new JsonParam("playerid", player.Id), new JsonParam("value", seekJump));
        }

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        /// <param name="streamIndex">Index of the audio stream to play</param>
        public async Task SetAudioStream(XbmcPlayer player, int streamIndex)
        {
            await _client.PostWithoutResultAsync("Player.SetAudioStream", new JsonParam("playerid", player.Id), new JsonParam("stream", streamIndex));
        }

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        public async Task SetAudioStream(XbmcPlayer player, SetAudioStreamMode stream)
        {
            await _client.PostWithoutResultAsync("Player.SetAudioStream", new JsonParam("playerid", player.Id), new JsonParam("stream", stream));
        }

        /// <summary>
        /// Set the repeat mode of the player
        /// </summary>
        public async Task SetRepeat(XbmcPlayer player, Repeat state)
        {
            await _client.PostWithoutResultAsync("Player.SetRepeat", new JsonParam("playerid", player.Id), new JsonParam("repeat", state));
        }

        /// <summary>
        /// Set the speed of the current playback
        /// </summary>
        public async Task<PlayerSpeed> SetSpeed(XbmcPlayer player, SpeedNumeric speed)
        {
            return await _client.PostAsync("Player.SetSpeed", _jsonRpcSerializer.Parse<PlayerSpeed>, new JsonParam("playerid", player.Id), new JsonParam("speed", speed));
        }

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        public async Task SetSubtitle(XbmcPlayer player, int subtitleIndex)
        {
            await _client.PostWithoutResultAsync("Player.SetSubtitle", new JsonParam("playerid", player.Id), new JsonParam("subtitle", subtitleIndex));
        }

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        public async Task SetSubtitle(XbmcPlayer player, SubtitleMode subtitle)
        {
            await _client.PostWithoutResultAsync("Player.SetSubtitle", new JsonParam("playerid", player.Id), new JsonParam("subtitle", subtitle));
        }

        /// <summary>
        /// Shuffle items in the player
        /// </summary>
        public async Task ShuffleOn(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.SetShuffle", new JsonParam("playerid", player.Id), new JsonParam("shuffle", true));
        }

        /// <summary>
        /// Shuffle items in the player
        /// </summary>
        public async Task ShuffleToggle(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.SetShuffle", new JsonParam("playerid", player.Id), new JsonParam("shuffle", "toggle"));
        }

        /// <summary>
        /// Stops playback
        /// </summary>
        public async Task Stop(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.Stop", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Unshuffle items in the player
        /// </summary>
        public async Task ShuffleOff(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.SetShuffle", new JsonParam("playerid", player.Id), new JsonParam("shuffle", false));
        }

        /// <summary>
        /// Zooms current picture
        /// </summary>
        /// <param name="zoomLevel">Zoom level (1-10)</param>
        public async Task Zoom(XbmcPlayer player, int zoomLevel)
        {
            await _client.PostWithoutResultAsync("Player.Zoom", new JsonParam("playerid", player.Id), new JsonParam("value", zoomLevel));
        }

        /// <summary>
        /// Zoom in once
        /// </summary>
        public async Task ZoomIn(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.ZoomIn", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Zoom out once
        /// </summary>
        public async Task ZoomOut(XbmcPlayer player)
        {
            await _client.PostWithoutResultAsync("Player.ZoomOut", new JsonParam("playerid", player.Id));
        }

        /// <summary>
        /// Start playback of the playlist Position
        /// </summary>
        public async Task Open(int playlistPosition)
        {
            await _client.PostWithoutResultAsync("Player.Open", new JsonParam("item", playlistPosition));
        }
    }
}