using System;
using System.Collections.Generic;
using Spotify;

namespace Spotify
{
    internal class Program
    {
        static List<Playlist> playlists = new List<Playlist>();
        public static Client client = new Client("admin", "password");
        static void Main(string[] args)
        {



            // probeer in te loggen via client class
            bool isLoggedIn = client.Login();

            // Menu weergeven
            while (true)
            {
                Console.WriteLine("----------------");
                Console.WriteLine("Spotify Home");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Vriendenactiviteiten");
                Console.WriteLine("2. Afspeellijsten");
                Console.WriteLine("3. Huidge nummer");
                Console.WriteLine("4. vrienden");
                Console.WriteLine("0. Afsluiten");
                Console.WriteLine("----------------");
                Console.WriteLine("Kies een optie");

                string? choice = Console.ReadLine();

                Console.Clear();

                // Opties verwerken
                switch (choice)
                {
                    case "1":
                        FriendsActivity();
                        break;
                    case "2":
                        Afspeelijsten();
                        break;
                    case "3":
                        Musicplayer();
                        break;
                    case "4":
                        FriendsActivity();
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        break;
                }
            }


            static void FriendsActivity()
            {


                Console.WriteLine("Vriendenactiviteit");
                Console.WriteLine("------------------");

                Testdata.Data();
                List<User> list = Testdata.GetAllUsers();
                foreach (User user in list)
                {
                    Console.WriteLine(user.Name);
                    Console.WriteLine("Wil je vrienden zijn met deze user? Type 1 voor ja, 2 voor nee\n");
                    string vriendenchoice = Console.ReadLine();

                    if (vriendenchoice.ToUpper() == "1")
                    {
                        Console.WriteLine("You are now friends with " + user.Name);
                        client.user.Friends.Add(user);
                        User.Displayfriends(client.user.Friends);
                        Console.WriteLine("\nVriend playlistXD:");
                        Playlist.DisplayPlaylists(user.Playlists);
                    }
                    else if (vriendenchoice.ToUpper() == "2")
                    {
                        Console.WriteLine("Jammer geen vrienden");
                    }
                    Console.WriteLine("/Druk op enter om terug te gaan");
                    Console.ReadLine();
                    Console.Clear();
                }
            };

        }


        static void Musicplayer()
        {
            Testdata.Data();
            Album album = Testdata.Howthedogschill;

            Console.Write("Do you want to play a song? (Y/N): ");
            string playChoice = Console.ReadLine();

            if (playChoice.ToUpper() == "Y")
            {
                Song song = album.Songs[0]; // Get the first song from the test data album

                MusicPlayer musicPlayer = new MusicPlayer();
                musicPlayer.Play(song);
            }

            Console.WriteLine("\nPress Enter to go back.");
            Console.ReadLine();
            Console.Clear();
        }


        static void Afspeelijsten()
        {
            Testdata.Data();
            Album album = Testdata.Howthedogschill;

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Wat wil je doen?\n");
                Console.WriteLine("1. Maak een nieuwe afspeellijst");
                Console.WriteLine("2. Bestaande afspeellijsten:");
                Console.WriteLine("3. Terug naar het hoofdmenu");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Welke playlist wil je maken?");
                        string playlistName = Console.ReadLine();

                        Playlist myPlaylist = new Playlist(playlistName);
                        client.user.Playlists.Add(myPlaylist);

                        Console.WriteLine($"Afspeellijst '{myPlaylist.Name}' is gemaakt.");
                        break;

                    case "2":
                        Console.WriteLine("Bestaande afspeellijsten:");
                        Playlist.DisplayPlaylists(client.user.Playlists);
                        Console.WriteLine("Kies een playlist");
                        int playlistChoice = Convert.ToInt32(Console.ReadLine());
                        Playlist selectedPlaylist = client.user.Playlists[playlistChoice - 1];
                        Playlist.DisplayPlaylists(client.user.Playlists);
                        Console.WriteLine("1. Voeg een nummer toe");
                        Console.WriteLine("2. Verwijder een nummer");
                        Console.WriteLine("3. nummer afspelen");
                        Console.WriteLine("Kies een optie");
                        int optionChoice = Convert.ToInt32(Console.ReadLine());

                        switch (optionChoice)
                        {
                            case 1:
                                Console.WriteLine("Nummers:");
                                Song.DisplaySongs(Testdata.Howthedogschill.Songs);

                                Console.WriteLine("Kies een nummer om toe te voegen aan je playlist");
                                int songChoice = Convert.ToInt32(Console.ReadLine());

                                if (songChoice >= 1 && songChoice <= Testdata.Howthedogschill.Songs.Count)
                                {
                                    Song selectedSong = Testdata.Howthedogschill.Songs[songChoice - 1];
                                    selectedPlaylist.AddSong(selectedSong);
                                    Console.WriteLine($"Het nummer '{selectedSong.Title}' is toegevoegd aan de afspeellijst.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Nummers:");
                                Song.DisplaySongs(selectedPlaylist.Songs);

                                Console.WriteLine("Kies een nummer om te verwijderen uit je playlist");
                                int deleteChoice = Convert.ToInt32(Console.ReadLine());

                                if (deleteChoice >= 1 && deleteChoice <= selectedPlaylist.Songs.Count)
                                {
                                    Song selectedSong = selectedPlaylist.Songs[deleteChoice - 1];
                                    selectedPlaylist.RemoveSong(selectedSong);
                                    Console.WriteLine($"Het nummer '{selectedSong.Title}' is verwijderd uit de afspeellijst.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Nummers:");
                                Song.DisplaySongs(selectedPlaylist.Songs);

                                Console.Write("kies een nummer om af te spelen");
                                int afspeelkeuzen = Convert.ToInt32(Console.ReadLine());

                                if (afspeelkeuzen >= 1 && afspeelkeuzen <= selectedPlaylist.Songs.Count)
                                {
                                    Song selectedSong = selectedPlaylist.Songs[afspeelkeuzen - 1];
                                    MusicPlayer musicPlayer = new MusicPlayer();
                                    musicPlayer.Play(selectedSong);
                                }


                                break;
                        }
                        break;

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        break;
                }

                Console.WriteLine("\nDruk op Enter om verder te gaan...");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}
