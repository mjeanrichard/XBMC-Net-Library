using System.Collections.Generic;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
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
        Task<IEnumerable<XbmcPlayer>> GetActivePlayers();

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        Task<MediaDetailsBase> GetItem(XbmcPlayer player);

        /// <summary>
        /// Retrieves the currently played item
        /// </summary>
        Task<PlayerProperties> GetProperties(XbmcPlayer player);

        /// <summary>
        /// Go to next item on the playlist
        /// </summary>
        Task GoNext(XbmcPlayer player);

        /// <summary>
        /// Go to previous item on the playlist
        /// </summary>
        Task GoPrevious(XbmcPlayer player);

        /// <summary>
        /// Go to item at the given position in the playlist
        /// </summary>
        Task GoTo(int position, XbmcPlayer player);

        /// <summary>
        /// If picture is zoomed move viewport down
        /// </summary>
        Task MoveDown(XbmcPlayer player);

        /// <summary>
        /// If picture is zoomed move viewport left otherwise skip previous
        /// </summary>
        Task MoveLeft(XbmcPlayer player);

        /// <summary>
        /// If picture is zoomed move viewport right otherwise skip next
        /// </summary>
        Task MoveRight(XbmcPlayer player);

        /// <summary>
        /// If picture is zoomed move viewport up
        /// </summary>
        Task MoveUp(XbmcPlayer player);

        /// <summary>
        /// Start playback of the playlist with the given ID
        /// </summary>
        Task Open(int playlistId, int playlistPosition);

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        Task Open(string path, bool random, bool recursive);

        /// <summary>
        /// Start playback of a slideshow with the pictures from the given directory
        /// </summary>
        Task OpenLibraryItem(int itemId);

        /// <summary>
        /// Pauses or unpause playback and returns the new state
        /// </summary>
        Task<PlayerSpeed> PlayPauseToggle(XbmcPlayer player);

        /// <summary>
        /// Set the repeat mode of the player
        /// </summary>
        Task SetRepeat(XbmcPlayer player, Repeat state);

        /// <summary>
        /// Rotates current picture
        /// </summary>
        Task Rotate(XbmcPlayer player);

        /// <summary>
        /// Seek through the playing item by percentage
        /// </summary>
        Task<PlayerPosition> Seek(XbmcPlayer player, decimal percentage);

        /// <summary>
        /// Seek through the playing item by time
        /// </summary>
        Task<PlayerPosition> Seek(XbmcPlayer player, Time time);

        /// <summary>
        /// Seek by predefined jumps
        /// </summary>
        Task<PlayerPosition> Seek(XbmcPlayer player, SeekJumps seekJump);

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        /// <param name="streamIndex">Index of the audio stream to play</param>
        Task SetAudioStream(XbmcPlayer player, int streamIndex);

        /// <summary>
        /// Set the audio stream played by the player
        /// </summary>
        Task SetAudioStream(XbmcPlayer player, SetAudioStreamMode stream);

        /// <summary>
        /// Set the speed of the current playback
        /// </summary>
        Task<PlayerSpeed> SetSpeed(XbmcPlayer player, SpeedNumeric speed);

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        Task SetSubtitle(XbmcPlayer player, int subtitleIndex);

        /// <summary>
        /// Set the subtitle displayed by the player
        /// </summary>
        Task SetSubtitle(XbmcPlayer player, SubtitleMode subtitle);

        /// <summary>
        /// Shuffle items in the player
        /// </summary>
        Task ShuffleOn(XbmcPlayer player);

        /// <summary>
        /// Stops playback
        /// </summary>
        Task Stop(XbmcPlayer player);

        /// <summary>
        /// Unshuffle items in the player
        /// </summary>
        Task ShuffleOff(XbmcPlayer player);

        /// <summary>
        /// Zooms current picture
        /// </summary>
        /// <param name="zoomLevel">Zoom level (1-10)</param>
        Task Zoom(XbmcPlayer player, int zoomLevel);

        /// <summary>
        /// Zoom in once
        /// </summary>
        Task ZoomIn(XbmcPlayer player);

        /// <summary>
        /// Zoom out once
        /// </summary>
        Task ZoomOut(XbmcPlayer player);

        /// <summary>
        /// Shuffle items in the player
        /// </summary>
        Task ShuffleToggle(XbmcPlayer player);
    }
}