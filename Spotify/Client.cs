using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{   internal class Client
    {
        private Musicplayer musicplayer;
        private User currentUser;
        private List<Song> allSongs;

        public Client()
        {
            // Initialize the music player and song collection
            musicplayer = new Musicplayer();
            allSongs = new List<Song>();
        }

        public void Login(string username, string password)
        {
            User authenticatedUser = AuthenticateUser(username, password);

            if (authenticatedUser != null)
            {
                currentUser = authenticatedUser;
                Console.WriteLine("Login successful. Welcome, " + currentUser.Username + "!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }

        private User AuthenticateUser(string username, string password)
        {
            

            
            List<User> userList = GetPredefinedUserList();

            User? authenticatedUser = userList.FirstOrDefault(user =>
                user.Username == username && user.Password == password);

            return authenticatedUser;
        }

        private List<User> GetPredefinedUserList()
        {
            // Create a list of predefined users
            List<User> userList = new List<User>
    {
        new User { Username = "user1", Password = "pass1" },
        new User { Username = "user2", Password = "pass2" },
        // Add more users as needed
    };

            return userList;
        }

    }
}
