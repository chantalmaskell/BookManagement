using System;
using MySqlConnector;

namespace BlazorApp1.Database
{
    public class DatabaseConnector
    {
        private readonly string _connectionString;

        public DatabaseConnector(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void OpenConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection opened successfully!");

                    string selectQuery = "SELECT * FROM users;";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // how the output will display for above query
                            Console.WriteLine($"User ID: {reader["user_id"]}, First Name: {reader["first_name"]}, Last Name: {reader["last_name"]}, Email Address: {reader["email_address"]}");
                        }
                    }

                    connection.Close();
                    Console.WriteLine("Connection closed.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}