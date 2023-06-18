using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Album Album { get; set; }
        public TimeSpan Duration { get; set; }


        public Song(string title, string artist, Album album, TimeSpan duration)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Duration = duration;
        }






        public static void DisplaySongs(List<Song> Songs)
        {
            if (Songs.Count > 0)
            {
                for (int i = 0; i < Songs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Songs[i].Title}");
                }
            }
            else
            {
                Console.WriteLine("Er zijn geen nummers.");
            }
        }
    }
}