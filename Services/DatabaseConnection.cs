using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_de_Jeu.Services
{
    using MySql.Data.MySqlClient;

    public class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=boardgames_db;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(connectionString);
            // Optionnel : Gérer ici l'ouverture et la fermeture de la connexion
            return connection;
        }
    }

}
