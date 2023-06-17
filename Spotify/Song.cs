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
        public List<string> Artists { get; private set; } = new List<string>();
        public string Album { get; set; }
        public TimeSpan Duration { get; set; }

        public string Genre { get; private set; }
        


        public Song(string title,List<string> artists, string genre, string album, TimeSpan duration)
        {
            Title = title;
            Artists = artists;
            Album = album;
            Duration = duration;
            Genre = genre;
        }

        public void AddArtist(string artist) {
            this.Artists.Add(artist);       
        }

        public void RemoveArtist(string artist) {
            this.Artists.Remove(artist);
        }
    }
}