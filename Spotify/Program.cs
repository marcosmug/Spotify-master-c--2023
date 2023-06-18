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
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        break;
                }
            }


            static void FriendsActivity()
            {
                // Vriendenactiviteit weergeven

                Console.WriteLine("Vriendenactiviteit");
                Console.WriteLine("------------------");
                // Implementeer hier de logica om de vriendenactiviteit weer te geven
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

                Console.WriteLine("/Druk op enter om terug te gaan");
                Console.ReadLine();
                Console.Clear();
            }


            static void Musicplayer()
            {
                Console.Write("Do you want to play a song? (Y/N): ");
                string playChoice = Console.ReadLine();

                if (playChoice.ToUpper() == "Y")
                {
                    Song song = Testdata.Howthedogschill.Songs[0]; // Get the first song from the test data album

                    MusicPlayer musicPlayer = new MusicPlayer();
                    musicPlayer.Play(song);
                }

                Console.WriteLine("\nPress Enter to go back.");
                Console.ReadLine();
                Console.Clear();
            }


            static void Afspeelijsten()
            {
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
                            Console.WriteLine("kies een playlist");
                            int keuzen = Convert.ToInt32(Console.ReadLine());
                            Playlist keuzenplaylist = client.user.Playlists[keuzen - 1];
                            Console.WriteLine($"Dit zijn de nummers uit {keuzenplaylist.Name}");
                            Song.DisplaySongs(keuzenplaylist.Songs);
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
}