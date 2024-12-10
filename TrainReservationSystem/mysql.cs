using System;
using MySqlConnector;

namespace TrainReservationSystem
{
    internal class Mysql
    {
        // Define the connection string
        private string connectionString = "Server=localhost;User id=root;password=Admin2003;Database=mydb";

        // Method to connect to the database and display connection status
        public void Connect()
        {
            // Create a new MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    Console.WriteLine("Connection successful!");
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the connection attempt
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
