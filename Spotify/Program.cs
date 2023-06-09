using Spotify;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client("admin", "password");

        // try to log in via client class
        bool isLoggedIn = client.Login();

        Console.ReadLine();

        // Create a new playlist
        Console.WriteLine("\nWelke playlist wil je?");

        Playlist myPlaylist = new Playlist("\nMijn geweldige afspeellijst");

        // Add songs to the playlist
        myPlaylist.AddSong(new Song("playboy carti", "Vamp anthem", "carti", TimeSpan.FromMinutes(3)));


        // Show the playlist
        Console.WriteLine("Afspeellijst: " + myPlaylist.Name);

        Console.WriteLine("Nummers:");
        foreach (Song song in myPlaylist.Songs)
        {
            Console.WriteLine(song.Artist + " - " + song.Title);
        }

        Console.ReadKey(true);


        Console.Write("Do you want to play a song? (Y/N): ");
        string playChoice = Console.ReadLine();

        if (playChoice.ToUpper() == "Y")
        {
            // test if song can be played with a test song
            Song song = new Song("Test Song", "Test Artist", "Test Album", TimeSpan.FromMinutes(3));

            // create an instance of the music player
            MusicPlayer musicPlayer = new MusicPlayer();

            // play the song with the music player
            musicPlayer.Play(song);
        }

    }
}