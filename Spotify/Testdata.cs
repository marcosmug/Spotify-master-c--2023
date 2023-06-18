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
            GetAllAlbumns().Add(Howthedogschill);
        }



        public static void Data()
        {
            PopulateAlbums();
        }

    }
}