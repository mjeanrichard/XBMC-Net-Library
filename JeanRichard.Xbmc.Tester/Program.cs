using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeanRichard.Xbmc.Lib.Clients;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.Async;
using JeanRichard.Xbmc.Lib.JsonRpc.HttpClient;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Fields;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;
using JeanRichard.Xbmc.Lib.XbmcEntities.Player.Property;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Tester
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            JsonRpcSerializer serializer = new JsonRpcSerializer();

            AsyncHttpClient client = new AsyncHttpClient(serializer);
            client.BaseUri = new Uri("http://Suffix:8080/jsonrpc");
            AudioLibraryClient libraryClient = new AudioLibraryClient(client, serializer);
            PlayerClient playerClient = new PlayerClient(client, serializer);
            //XbmcServerClient serverClient = new XbmcServerClient(client);
            PlaylistClient playlist = new PlaylistClient(client, serializer);

            XbmcPlayer player = new XbmcPlayer { Id = 0 };
            //playerClient.PlayPause(ResultAction, player);
            PlayerProperties props = playerClient.GetProperties(player).Result;

            IEnumerable<Playlist> playlists = playlist.GetPlaylists().Result;

            IMediaItemList<MediaDetailsBase> items = playlist.GetItems(playlists.First()).Result;

            var artists = libraryClient.GetArtists(null, null, ArtistFields.All, 0, 50, SortMethods.Album, Orders.Ascending).Result;

            //player.GetItem(ResultAction);
            //player.GetProperties(Result);
            //player.Seek(ResultAction, 10);

            //library.GetAlbums(ResultAction, 214, null, null, 2, null);
            //library.GetArtists(ResultAction);
            //library.GetSongs(ResultAction, null, null, null);
            //library.GetSong(ResultAction, 6695, null);
            //library.GetAlbum(ResultAction, 470, null);
            //library.GetArtist(ResultAction, 215, null);

            //player.OpenAlbum(ResultAction, 469);

            //server.Introspect(ResultAction);
            //server.ToggleMute(ResultAction);
            //server.Ping(ResultAction);
            //server.GetVersion(ResultAction);

            //playlist.Remove(ResultAction, new Playlist { Id = 0 }, 1);
            //playlist.Add(ResultAction, new Playlist { Id = 0 }, new Album { Id = 470 });
            //playlist.GetItems(ResultAction, new Playlist { Id = 0 });
            //playlist.GetPlaylists(ResultAction);

            Console.ReadLine();
        }
    }
}