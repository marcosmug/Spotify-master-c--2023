using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;

namespace Spotify
{
    internal class MusicPlayer
    {
        private Song currentSong; // Huidig afgespeelde nummer
        private bool isPlaying; // Geeft de afspeelstatus weer

        // Methode om een nummer af te spelen
        public void Play(Song song)
        {
            currentSong = song; // Huidig nummer instellen op het opgegeven nummer
            isPlaying = true; // Afspeelstatus instellen op 'true' (afspelen) Bolean is playing wordt gebruikt om hem later ook op pauzen te zetten of te skippen

            // De totale duur van het nummer in seconden verkrijgen
            int totalSeconds = (int)song.Duration.TotalSeconds;

            // Nummerinformatie weergeven
            Console.WriteLine("Afspelen: " + currentSong.Title);
            Console.WriteLine("Artiest: " + currentSong.Artist);
            Console.WriteLine("Album: " + currentSong.Album);

            // Door de duur aftellen
            while (totalSeconds > 0 && isPlaying)
            {
                // Huidige duur weergeven
                TimeSpan remainingDuration = TimeSpan.FromSeconds(totalSeconds);
                Console.Clear();
                Console.WriteLine("Duur: " + remainingDuration.ToString("hh\\:mm\\:ss"));
                Console.WriteLine(currentSong.Title);
                Console.WriteLine(currentSong.Artist);
                Console.WriteLine(currentSong.Album);
                Console.WriteLine("Houd 'q' ingedrukt om het nummer te stoppen");

                // Wachten voor 1 seconde om de tijd te simuleren
                Thread.Sleep(1000);

                // 1 seconde van de totale duur aftrekken
                totalSeconds--;
            }

            // Controleren of het nummer is afgelopen of handmatig gepauzeerd
            if (totalSeconds <= 0)
            {
                Console.WriteLine("Nummer afgelopen: " + currentSong.Title);
            }
            else
            {
                Console.WriteLine("Nummer gepauzeerd: " + currentSong.Title);
            }
        }

        // Methode om het huidige nummer te pauzeren
        public void Pause()
        {
            if (isPlaying)
            {
                isPlaying = false; // Afspeelstatus instellen op 'false' (gepauzeerd)
                Console.WriteLine("Gepauzeerd: " + currentSong.Title);
            }
            else
            {
                Console.WriteLine("Al gepauzeerd.");
            }
        }

        // Methode om het gepauzeerde nummer te hervatten
        public void Resume()
        {
            if (!isPlaying)
            {
                isPlaying = true; // Afspeelstatus instellen op 'true' (hervat)
                Console.WriteLine("Hervat: " + currentSong.Title);
            }
            else
            {
                Console.WriteLine("Al aan het afspelen.");
            }
        }
    }


}