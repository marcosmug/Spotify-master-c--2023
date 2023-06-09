using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist
    {
        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
    }
}