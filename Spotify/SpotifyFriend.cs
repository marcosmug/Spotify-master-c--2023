using System;
using System.Collections.Generic;

public class SpotifyFriend
{
    public string Name { get; set; }
    public List<SpotifyFriend> Friends { get; private set; }

    public SpotifyFriend(string name)
    {
        Name = name;
        Friends = new List<SpotifyFriend>();
    }

    public void AddFriend(SpotifyFriend friend)
    {
        if (!Friends.Contains(friend))
        {
            Friends.Add(friend);
            friend.AddFriend(this);
            Console.WriteLine($"{Name} and {friend.Name} are now friends on Spotify.");
        }
        else
        {
            Console.WriteLine($"{Name} and {friend.Name} are already friends on Spotify.");
        }
    }

    public void RemoveFriend(SpotifyFriend friend)
    {
        if (Friends.Contains(friend))
        {
            Friends.Remove(friend);
            friend.RemoveFriend(this);
            Console.WriteLine($"{Name} and {friend.Name} are no longer friends on Spotify.");
        }
        else
        {
            Console.WriteLine($"{Name} and {friend.Name} are not friends on Spotify.");
        }
    }

    public void DisplayFriends()
    {
        Console.WriteLine($"{Name}'s Friends on Spotify:");
        foreach (var friend in Friends)
        {
            Console.WriteLine(friend.Name);
        }
    }
}