using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_de_Jeu.Services
{
    using System;
    using System.Data;
    using System.Security.Cryptography;
    using System.Text;
    using MySql.Data.MySqlClient;

    public class AuthenticationService
    {
        // Hash le mot de passe avec SHA-256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (var b in hash)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        // Méthode de connexion : retourne un tuple (succès, rôle)
        public (bool success, string role) Login(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            string query = "SELECT Role FROM users WHERE Username = @username AND PasswordHash = @passwordHash";
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@passwordHash", hashedPassword);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return (true, result.ToString());
                    }
                }
            }
            return (false, null);
        }
    }

}
