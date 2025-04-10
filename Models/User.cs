using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_de_Jeu.Models
{
    public enum UserRole
    {
        Admin,
        User
    }

    public class User
    {
        // Propriétés correspondant aux colonnes de la table "users"
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        // Vous pouvez utiliser un enum pour améliorer la lisibilité
        public UserRole Role { get; set; }

        // Méthode de validation simple, par exemple :
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Username))
                return false;
            if (string.IsNullOrWhiteSpace(PasswordHash))
                return false;
            return true;
        }
    }
}
