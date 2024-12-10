using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace TrainReservationSystem
{
    public static class DatabaseHelper
    {
        private static MySqlConnection connection;

        // Connection string
        private static string connectionString = "Server=localhost;User id=root;password=Admin2003;Database=mydb";

        // Method to initialize the connection
        public static void InitializeConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Database connection established.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to the database: {ex.Message}");
                throw;
            }
        }

        // Method to get the connection instance
        public static MySqlConnection GetConnection()
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
            {
                InitializeConnection();  // Ensure connection is established if it's not open
            }
            return new MySqlConnector.MySqlConnection(connectionString);
        }

        // Method to close the connection
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Database connection closed.");
            }
        }
    }
}
