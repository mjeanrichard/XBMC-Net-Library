using System;

using JeanRichard.Xbmc.Lib.Clients;
using JeanRichard.Xbmc.Lib.Clients.XbmcEntities;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.HttpClient;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;

namespace JeanRichard.Xbmc.Tester
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            JsonRpcSerializer serializer = new JsonRpcSerializer();
            JsonRpcHttpClient client = new JsonRpcHttpClient(serializer, new Uri("http://192.168.175.35:8080/jsonrpc"));
            AudioLibraryClient libraryClient = new AudioLibraryClient(client);
            PlayerClient playerClient = new PlayerClient(client);
            XbmcServerClient serverClient = new XbmcServerClient(client);
            PlaylistClient playlist = new PlaylistClient(client);
            
            //player.GetActivePlayers(ResultAction);
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

            playlist.Remove(ResultAction, new Playlist { Id = 0 }, 1);
            //playlist.Add(ResultAction, new Playlist { Id = 0 }, new Album { Id = 470 });
            //playlist.GetItems(ResultAction, new Playlist { Id = 0 });
            //playlist.GetPlaylists(ResultAction);

            Console.ReadLine();
        }

        private static void ResultAction<TParam>(TParam data, ErrorData arg2)
        {
            
        }
    }
}