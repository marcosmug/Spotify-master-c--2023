using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album
    {
        public string Name { get; private set; }
        public List<string> Artists { get; private set; } = new List<string>();
        public List<Song> Songs { get; private set; }

        public Album(string name, params string[] artists)
        {
            this.Name = name;
            this.Artists.AddRange(artists);
            this.Songs = new List<Song>();
        }

        public void AddArtist(string artist)
        {
            this.Artists.Add(artist);
        }

        public void RemoveArtist(string artist)
        {
            this.Artists.Remove(artist);
        }

        public void AddSong(Song song)
        {
            this.Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            this.Songs.Remove(song);
        }
    }
}
