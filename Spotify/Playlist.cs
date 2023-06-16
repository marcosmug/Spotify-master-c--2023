using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void DeletePlaylist()
        {
            // Maak de lijst met nummers leeg
            Songs.Clear();

            // Herstel de naam van de afspeellijst naar een lege string
            Name = string.Empty;
        }
    }
}