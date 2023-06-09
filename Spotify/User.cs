using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Playlist> Playlists { get; set; }
    }
}
