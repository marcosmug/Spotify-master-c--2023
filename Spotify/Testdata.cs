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


        public static List<string> GetAllArtists()
        {
            return new List<string>
            {
                Mall_grab
            };
        }

        public static List<Album> GetAllAlbumns()
        {
            return new List<Album>
            {
                Howthedogschill
            };

        }


        public static void PopulateAlbums()
        {
            Howthedogschill.AddSong(new Song("Liverpool Street in the rain", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Bust", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Looking for trouble", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Liverpool Street in the rain", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
            Howthedogschill.AddSong(new Song("Get Impetuous", Mall_grab, Howthedogschill, TimeSpan.FromMinutes(5)));
        }

        public static User user1 = new User("steve");
        public static User user2 = new User("be");
        public static User user3 = new User("ally");
        public static User user4 = new User("cum");
        public static User user5 = new User("bum");


        public static void UsersInformation()
        {
            user1.AddPlaylistUser(new Playlist("samski"));
            user1.Playlists[0].AddsongsFromAlbum(Howthedogschill);
            user2.AddPlaylistUser(new Playlist("jayz"));
            user2.Playlists[0].AddsongsFromAlbum(Howthedogschill);
            user3.AddPlaylistUser(new Playlist("Kitchenman!!!"));
            user3.Playlists[0].AddsongsFromAlbum(Howthedogschill);
        }

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

        public static void Data()
        {
            PopulateAlbums();
            UsersInformation();

        }

    }
}

