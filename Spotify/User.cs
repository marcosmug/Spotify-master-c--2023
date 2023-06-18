using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Spotify
{
    internal class User
    {
        public string Name { get; set; }

        public List<Playlist> Playlists { get; set; }

        public readonly List<User> Friends;

        public User(string name)
        {
            Name = name;
            Playlists = new List<Playlist>();
            Friends = new List<User>();
        }

        public void RemoveFriend(User Friend)
        {
            this.Friends.Remove(Friend);
        }

        public void AddFriend(User Friend)
        {
            this.Friends.Add(Friend);
        }
    }
}