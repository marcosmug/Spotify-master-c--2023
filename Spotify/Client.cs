using System;
using System.Collections.Generic;
using System.Linq;

namespace Spotify
{
    class Client
    {
        private string username;
        private string password;

        public Client(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool Login()
        {
            // vraag de user om een username
            Console.Write("Enter your username: ");
            string enteredUsername = Console.ReadLine();

            // vraag de user om een wachtwoord
            Console.Write("Enter your password: ");
            string enteredPassword = Console.ReadLine();

            // vergelijk ingevulde wachtwoord en username met de username and password
            if (enteredUsername == username && enteredPassword == password)
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return false;
            }
        }
    }
}