using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Global;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player.Property;

namespace JeanRichard.Xbmc.Lib.Clients
{
    public interface IPlayerClient
    {
        /// <summary>
        /// Returns all active players
        /// </summary>
        void GetActivePlayers(Action<IEnumerable<ActivePlayer>, ErrorData> resultAction);

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        void GetItem(Action<MediaDetailsBase, ErrorData> resultAction);

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        void GetProperties(Action<PlayerProperties, ErrorData> resultAction);

        /// <summary>
        /// Go to next item on the playlist
        /// </summary>
        void GoNext(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Go to previous item on the playlist
        /// </summary>
        void GoPrevious(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Go to item at the given position in the playlist
        /// </summary>
        void GoTo(Action<bool, ErrorData> resultAction, int position);

        /// <summary>
        /// If picture is zoomed move viewport down
        /// </summary>
        void MoveDown(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// If picture is zoomed move viewport left otherwise skip previous
        /// </summary>
        void MoveLeft(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// If picture is zoomed move viewport right otherwise skip next
        /// </summary>
        void MoveRight(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// If picture is zoomed move viewport up
        /// </summary>
        void MoveUp(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Start playback of the playlist with the given ID
        /// </summary>
        void Open(Action<bool, ErrorData> resultAction, int playlistId, int playlistPosition);

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        void Open(Action<bool, ErrorData> resultAction, string path, bool random, bool recursive);

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        void OpenAlbum(Action<bool, ErrorData> resultAction, int albumId);

        /// <summary>
        /// Pauses or unpause playback and returns the new state
        /// </summary>
        void PlayPause(Action<PlayerSpeed, ErrorData> resultAction);

        /// <summary>
        /// Set the repeat mode of the player
        /// </summary>
        void Repeat(Action<bool, ErrorData> resultAction, Repeat state);

        /// <summary>
        /// Rotates current picture
        /// </summary>
        void Rotate(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Seek through the playing item by percentage
        /// </summary>
        void Seek(Action<PlayerPosition, ErrorData> resultAction, decimal percentage);

        /// <summary>
        /// Seek through the playing item by time
        /// </summary>
        void Seek(Action<PlayerPosition, ErrorData> resultAction, Time time);

        /// <summary>
        /// Seek by predefined jumps
        /// </summary>
        void Seek(Action<PlayerPosition, ErrorData> resultAction, SeekJumps seekJump);

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        /// <param name="streamIndex">Index of the audio stream to play</param>
        void SetAudioStream(Action<bool, ErrorData> resultAction, int streamIndex);

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        void SetAudioStream(Action<bool, ErrorData> resultAction, SetAudioStreamMode stream);

        /// <summary>
        /// Set the speed of the current playback
        /// </summary>
        void SetSpeed(Action<PlayerSpeed, ErrorData> resultAction, SpeedNumeric speed);

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        void SetSubtitle(Action<bool, ErrorData> resultAction, int subtitleIndex);

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        void SetSubtitle(Action<bool, ErrorData> resultAction, SubtitleMode subtitle);

        /// <summary>
        /// Shuffle items in the player
        /// </summary>
        void Shuffle(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Stops playback
        /// </summary>
        void Stop(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Unshuffle items in the player
        /// </summary>
        void UnShuffle(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Zooms current picture
        /// </summary>
        /// <param name="zoomLevel">Zoom level (1-10)</param>
        void Zoom(Action<bool, ErrorData> resultAction, int zoomLevel);

        /// <summary>
        /// Zoom in once
        /// </summary>
        void ZoomIn(Action<bool, ErrorData> resultAction);

        /// <summary>
        /// Zoom out once
        /// </summary>
        void ZoomOut(Action<bool, ErrorData> resultAction);
    }
}