using Spotify;

class Program
{
    static void Main(string[] args)
    {

        Client client = new Client("admin", "password");

        // probeer in te loggen via client class
        bool isLoggedIn = client.Login();

        Console.Clear();

        // Create a new playlist
        Console.WriteLine("Welke playlist wil je?");

        Playlist myPlaylist = new Playlist("Mijn geweldige afspeellijst");
        Playlist myPlaylist1 = new Playlist("Fortnite");
        Playlist myPlaylist2 = new Playlist("Rainbow six siege");
        // Add songs to the playlist
        myPlaylist.AddSong(new Song("X For breakfast", new List<string> { "ken karson"},"rap", "If look could kill", TimeSpan.FromMinutes(3)));

        // Show the playlist
        Console.WriteLine( myPlaylist.Name);
        Console.WriteLine(myPlaylist1.Name);
        Console.WriteLine(myPlaylist2.Name);


        Console.WriteLine("\nNummers:");
        foreach (Song song in myPlaylist.Songs)
        {
            
            Console.WriteLine(string.Join(",", song.Artists)+ " - " + song.Title);
        }


        SpotifyFriend friend1 = new SpotifyFriend("John");
        SpotifyFriend friend2 = new SpotifyFriend("Sarah");
        SpotifyFriend friend3 = new SpotifyFriend("Michael");

        friend1.AddFriend(friend2);
        friend1.AddFriend(friend3);
        friend2.AddFriend(friend3);

        friend1.DisplayFriends(); // Output: John's Friends on Spotify: Sarah, Michael
        friend2.DisplayFriends(); // Output: Sarah's Friends on Spotify: John, Michael
        friend3.DisplayFriends(); // Output: Michael's Friends on Spotify: John, Sarah

        friend1.RemoveFriend(friend2);
        friend2.RemoveFriend(friend3);

        friend1.DisplayFriends(); // Output: John's Friends on Spotify: Michael
        friend2.DisplayFriends(); // Output: Sarah's Friends on Spotify: 
        friend3.DisplayFriends(); // Output: Michael's Friends on Spotify: John

        Console.ReadKey(true);

        Console.Write("Do you want to play a song? (Y/N): ");
        string playChoice = Console.ReadLine();



        if (playChoice.ToUpper() == "Y")
        {

            // test of nummer agespeeld kan worden met test nummer
            Song song = new Song(
                "X For breakfast",
                new List<string> { "ken karson" },
                "rap",
                "If looks could kill",
                TimeSpan.FromMinutes(3) // Stel de duur van het nummer in op 3 minuten
            );

            // creer insitantie van de musicplayer
            MusicPlayer musicPlayer = new MusicPlayer();

            // speel nummer af met de musicplayer
            musicPlayer.Play(song);
        }

        Console.ReadLine();
    }
}