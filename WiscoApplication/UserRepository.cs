using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace WiscoApplication.Data
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString + ";TrustServerCertificate=True";
        }

        public void RegisterUser(string username, string email, string password)
        {
            string hashedPassword = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Username, Email, Password, CreatedAt) VALUES (@Username, @Email, @Password, @CreatedAt)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        private string _username;
        private int _userId;

        public bool LoginUser(string usernameOrEmail, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT UserID, Username, Password FROM Users WHERE Username = @UsernameOrEmail OR Email = @UsernameOrEmail";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsernameOrEmail", usernameOrEmail);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _userId = reader.GetInt32(0);
                            _username = reader.GetString(1);
                            string hashedPassword = reader.GetString(2);
                            return VerifyPassword(password, hashedPassword);
                        }
                    }
                }
            }
            return false;
        }

        public string GetUsername(string identifier)
        {
            string username = string.Empty;
            string query = "SELECT Username FROM Users WHERE Username = @Identifier";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identifier", identifier);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    username = reader["Username"] as string;
                }
            }

            return username;
        }

        public string GetProfileImageUrl(string username)
        {
            string imageUrl = string.Empty;
            string query = "SELECT profile_picture FROM Users WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    imageUrl = reader["profile_picture"] as string;
                }
            }

            return imageUrl;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashOfInput = HashPassword(password);
            return StringComparer.OrdinalIgnoreCase.Compare(hashOfInput, hashedPassword) == 0;
        }
    }
}