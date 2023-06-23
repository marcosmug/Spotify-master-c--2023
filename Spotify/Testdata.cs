using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal static class Testdata
    {

        //artiest
        public static string Mall_grab = "Mall grab";




        //album van artiest
        public static Album Howthedogschill = new Album("how the dogs chill", Mall_grab);

        //maakt een new list aan met alle artists
        public static List<string> GetAllArtists()
        {
            return new List<string>
            {
                Mall_grab
            };
        }
        //maakt een new list aan met alle albums
        public static List<Album> GetAllAlbumns()
        {
            return new List<Album>
            {
                Howthedogschill
            };

        }

         //add liedjes aan de album
        public static void PopulateAlbums()
        {
            Howthedogschill.AddSong(new Song("Liverpool Street in the rain", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Bust", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Looking for trouble", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Liverpool Street in the rain", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Get Impetuous", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
        }

        //maakt users aan

        public static User user1 = new User("steve");
        public static User user2 = new User("be");
        public static User user3 = new User("ally");
        public static User user4 = new User("toetje");
        public static User user5 = new User("Cadext oxten");

        //geeft all users een album
        public static void UsersInformation()
        {
            user1.AddPlaylistUser(new Playlist("samski"));
            user1.Playlists[0].AddsongsFromAlbum(Howthedogschill);
            user2.AddPlaylistUser(new Playlist("jayz"));
            user2.Playlists[0].AddsongsFromAlbum(Howthedogschill);
            user3.AddPlaylistUser(new Playlist("Kitchenman!!!"));
            user3.Playlists[0].AddsongsFromAlbum(Howthedogschill);
        }
        // pakt alle users
        public static List<User> GetAllUsers()
        {
            return new List<User> {
                user1,
                user2,
                user3,
                user4,
                user5
            };
        }
        // zit alle data in een functie data zodat ik het aan kan roepen
        public static void Data()
        {
            PopulateAlbums();
            UsersInformation();

        }

    }
}

