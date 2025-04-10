using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_de_Jeu.Services
{
    using System.Data;
    using MySql.Data.MySqlClient;

    public class SearchService
    {
        public DataTable SearchGamesByName(string searchTerm)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM games WHERE Nom LIKE @searchTerm";
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable SortGames(string sortBy)
        {
            DataTable dt = new DataTable();
            // Il est préférable de valider que le champ passé en paramètre est bien autorisé (ex: Name, DateAdded, etc.)
            string query = $"SELECT * FROM games ORDER BY {sortBy}";
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                using (var adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }

}
