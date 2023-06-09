using Spotify;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Client class
        Client client = new Client();

        // Test login with valid credentials
        client.Login("user1", "pass1");

        Console.ReadLine();
    }
}