using Spotify;

class Program
{
    static void Main(string[] args)
    {

        Client client = new Client("admin", "password");

        // probeer in te loggen via client class
        bool isLoggedIn = client.Login();


        // Create a new playlist
        Console.WriteLine("\nWelke playlist wil je?");

        Playlist myPlaylist = new Playlist("\nMijn geweldige afspeellijst");

        // Add songs to the playlist
        myPlaylist.AddSong(new Song("X For breakfast", "Ken Carson", "If look could kill", TimeSpan.FromMinutes(3)));

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

            // test of nummer agespeeld kan worden met test nummer
            Song song = new Song(
                "X For breakfast",
                "Ken Carson",
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