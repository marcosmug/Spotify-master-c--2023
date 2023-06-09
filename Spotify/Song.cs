using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        public Song(string title, string artist, string album, TimeSpan duration)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Duration = duration;
        }

        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
