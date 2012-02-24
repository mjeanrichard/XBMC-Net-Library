using System;

using JeanRichard.Xbmc.Lib.Clients;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.JsonRpc.HttpClient;

namespace JeanRichard.Xbmc.Tester
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            JsonRpcSerializer serializer = new JsonRpcSerializer();
            JsonRpcHttpClient client = new JsonRpcHttpClient(serializer, new Uri("http://192.168.175.35:8080/jsonrpc"));
            AudioLibrary library = new AudioLibrary(client);
            PlayerBase player = new PlayerBase(client);
            XbmcServer server = new XbmcServer(client);
            //player.GetActivePlayers(ResultAction);
            //player.GetItem(ResultAction);
            //player.GetProperties(Result);

            //library.GetAlbums(ResultAction, 214, null, null, 2, null);
            library.GetArtists(ResultAction);
            //library.GetSongs(ResultAction, null, null, null);
            //library.GetSong(ResultAction, 6695, null);
            //library.GetAlbum(ResultAction, 470, null);
            //library.GetArtist(ResultAction, 215, null);

            //player.OpenAlbum(ResultAction, 469);

            //server.Introspect(ResultAction);
            //server.ToggleMute(ResultAction);
            //server.Ping(ResultAction);
            //server.GetVersion(ResultAction);

            Console.ReadLine();
        }

        private static void ResultAction<TParam>(TParam data, ErrorData arg2)
        {
            
        }
    }
}