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
        public List<User> Authors { get; private set; }


        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            this.Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            this.Songs.Remove(song);
        }

        public void Addplaylist(Playlist playlist)
        {
            this.Songs.AddRange(playlist.Songs);
        }

        public void RemovePlaylist(Playlist playlist)
        {
            foreach (Song song in playlist.Songs)
            {
                this.Songs.Remove(song);
            }
        }

        public void AddAuthor(User author)
        {
            this.Authors.Add(author);
        }

        public void RemoveAuthor(User author)
        {
            this.Authors.Remove(author);
        }


        public static void DisplayPlaylists(List<Playlist> playlists)
        {
            if (playlists.Count > 0)
            {
                for (int i = 0; i < playlists.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {playlists[i].Name}");
                }
            }
            else
            {
                Console.WriteLine("Er zijn geen afspeellijsten.");
            }
        }
    }
}