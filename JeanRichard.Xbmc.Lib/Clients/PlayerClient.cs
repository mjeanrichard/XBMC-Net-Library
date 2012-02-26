using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Global;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player.Property;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public class PlayerClient : IPlayerClient
    {
        private static readonly PlayerPropertyFields[] DefaultPlayerProperties = new[] { PlayerPropertyFields.Type, PlayerPropertyFields.Percentage, PlayerPropertyFields.PlaylistId, PlayerPropertyFields.Position, PlayerPropertyFields.Time, PlayerPropertyFields.TotalTime, PlayerPropertyFields.Shuffled, PlayerPropertyFields.Partymode, PlayerPropertyFields.Repeat, PlayerPropertyFields.AudioStreams };
        private const AllFields ItemProperties = AllFields.Title | AllFields.Thumbnail | AllFields.Track | AllFields.Rating | AllFields.PlayCount | AllFields.FanArt | AllFields.Genre | AllFields.File | AllFields.ArtistId | AllFields.Artist | AllFields.AlbumId | AllFields.Album;
        private readonly IRpcClient _client;

        public PlayerClient(IRpcClient client)
        {
            _client = client;
        }

        protected int PlayerId
        {
            get { return 0; }
        }

        /// <summary>
        /// Returns all active players
        /// </summary>
        public void GetActivePlayers(Action<IEnumerable<ActivePlayer>, ErrorData> resultAction)
        {
            _client.Invoke("Player.GetActivePlayers", o => o.ParseJsonObjectArray<ActivePlayer>(), resultAction);
        }

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        public void GetItem(Action<MediaDetailsBase, ErrorData> resultAction)
        {
            _client.Invoke("Player.GetItem", t => ClientUtils.CreateMediaDetails(t.GetItem()), resultAction, new JsonParam("playerid", PlayerId), new JsonParam("properties", ItemProperties));
        }

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        public void GetProperties(Action<PlayerProperties, ErrorData> resultAction)
        {
            _client.Invoke("Player.GetProperties", JsonRpcItem.LoadFrom<PlayerProperties>, resultAction, new JsonParam("playerid", PlayerId), new JsonParam("properties", DefaultPlayerProperties));
        }

        /// <summary>
        /// Go to next item on the playlist
        /// </summary>
        public void GoNext(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.GoNext", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Go to previous item on the playlist
        /// </summary>
        public void GoPrevious(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.GoPrevious", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Go to item at the given position in the playlist
        /// </summary>
        public void GoTo(Action<bool, ErrorData> resultAction, int position)
        {
            _client.InvokeForOkResult("Player.GoTo", resultAction, new JsonParam("playerid", PlayerId), new JsonParam("position", position));
        }

        /// <summary>
        /// If picture is zoomed move viewport down
        /// </summary>
        public void MoveDown(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.MoveDown", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// If picture is zoomed move viewport left otherwise skip previous
        /// </summary>
        public void MoveLeft(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.MoveLeft", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// If picture is zoomed move viewport right otherwise skip next
        /// </summary>
        public void MoveRight(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.MoveRight", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// If picture is zoomed move viewport up
        /// </summary>
        public void MoveUp(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.MoveUp", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Start playback of the playlist with the given ID
        /// </summary>
        public void Open(Action<bool, ErrorData> resultAction, int playlistId, int playlistPosition)
        {
            _client.InvokeForOkResult("Player.Open", resultAction, new JsonParam("playlistid", playlistId), new JsonParam("position", playlistPosition));
        }

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        public void Open(Action<bool, ErrorData> resultAction, string path, bool random, bool recursive)
        {
            _client.InvokeForOkResult("Player.Open", resultAction, new JsonParamObject("item", new JsonParam("path", path), new JsonParam("random", random), new JsonParam("recursive", recursive)));
        }

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        public void OpenAlbum(Action<bool, ErrorData> resultAction, int albumId)
        {
            _client.InvokeForOkResult("Player.Open", resultAction, new JsonParamObject("item", new JsonParam("albumid", albumId)));
        }

        /// <summary>
        /// Pauses or unpause playback and returns the new state
        /// </summary>
        public void PlayPause(Action<PlayerSpeed, ErrorData> resultAction)
        {
            _client.Invoke("Player.PlayPause", JsonRpcItem.LoadFrom<PlayerSpeed>, resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Set the repeat mode of the player
        /// </summary>
        public void Repeat(Action<bool, ErrorData> resultAction, Repeat state)
        {
            _client.InvokeForOkResult("Player.Repeat", resultAction, new JsonParam("playerid", PlayerId), new JsonParam("state", state));
        }

        /// <summary>
        /// Rotates current picture
        /// </summary>
        public void Rotate(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.Rotate", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Seek through the playing item by percentage
        /// </summary>
        public void Seek(Action<PlayerPosition, ErrorData> resultAction, decimal percentage)
        {
            _client.Invoke("Player.Seek", JsonRpcItem.LoadFrom<PlayerPosition>, resultAction, new JsonParam("playerid", PlayerId), new JsonParam("value", percentage));
        }

        /// <summary>
        /// Seek through the playing item by time
        /// </summary>
        public void Seek(Action<PlayerPosition, ErrorData> resultAction, Time time)
        {
            _client.Invoke("Player.Seek", JsonRpcItem.LoadFrom<PlayerPosition>, resultAction, new JsonParam("playerid", PlayerId), new JsonParam("value", time));
        }

        /// <summary>
        /// Seek by predefined jumps
        /// </summary>
        public void Seek(Action<PlayerPosition, ErrorData> resultAction, SeekJumps seekJump)
        {
            _client.Invoke("Player.Seek", JsonRpcItem.LoadFrom<PlayerPosition>, resultAction, new JsonParam("playerid", PlayerId), new JsonParam("value", seekJump));
        }

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        /// <param name="streamIndex">Index of the audio stream to play</param>
        public void SetAudioStream(Action<bool, ErrorData> resultAction, int streamIndex)
        {
            _client.InvokeForOkResult("Player.SetAudioStream", resultAction, new JsonParam("playerid", PlayerId), new JsonParam("stream", streamIndex));
        }

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        public void SetAudioStream(Action<bool, ErrorData> resultAction, SetAudioStreamMode stream)
        {
            _client.InvokeForOkResult("Player.SetAudioStream", resultAction, new JsonParam("playerid", PlayerId), new JsonParam("stream", stream));
        }

        /// <summary>
        /// Set the speed of the current playback
        /// </summary>
        public void SetSpeed(Action<PlayerSpeed, ErrorData> resultAction, SpeedNumeric speed)
        {
            _client.Invoke("Player.SetSpeed", JsonRpcItem.LoadFrom<PlayerSpeed>, resultAction, new JsonParam("playerid", PlayerId), new JsonParam("speed", speed));
        }

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        public void SetSubtitle(Action<bool, ErrorData> resultAction, int subtitleIndex)
        {
            _client.InvokeForOkResult("Player.SetSubtitle", resultAction, new JsonParam("playerid", PlayerId), new JsonParam("subtitle", subtitleIndex));
        }

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        public void SetSubtitle(Action<bool, ErrorData> resultAction, SubtitleMode subtitle)
        {
            _client.InvokeForOkResult("Player.SetSubtitle", resultAction, new JsonParam("playerid", PlayerId), new JsonParam("subtitle", subtitle));
        }

        /// <summary>
        /// Shuffle items in the player
        /// </summary>
        public void Shuffle(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.Shuffle", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Stops playback
        /// </summary>
        public void Stop(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.Stop", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Unshuffle items in the player
        /// </summary>
        public void UnShuffle(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.UnShuffle", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Zooms current picture
        /// </summary>
        /// <param name="zoomLevel">Zoom level (1-10)</param>
        public void Zoom(Action<bool, ErrorData> resultAction, int zoomLevel)
        {
            _client.InvokeForOkResult("Player.Zoom", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Zoom in once
        /// </summary>
        public void ZoomIn(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.ZoomIn", resultAction, new JsonParam("playerid", PlayerId));
        }

        /// <summary>
        /// Zoom out once
        /// </summary>
        public void ZoomOut(Action<bool, ErrorData> resultAction)
        {
            _client.InvokeForOkResult("Player.ZoomOut", resultAction, new JsonParam("playerid", PlayerId));
        }
    }
}