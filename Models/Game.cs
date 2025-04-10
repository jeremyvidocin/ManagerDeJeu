using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_de_Jeu.Models
{
    public class Game
    {
        // Propriétés correspondant aux colonnes de la table "games"
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int NumberOfCards { get; set; }
        public DateTime DateAdded { get; set; }

        // Vous pouvez ajouter ici des méthodes de validation ou autres comportements
        public bool IsValid()
        {
            // Par exemple, vérifier que le nom n'est pas vide et que le nombre de joueurs est cohérent
            if (string.IsNullOrWhiteSpace(Name))
                return false;
            if (MinPlayers < 1 || MaxPlayers < MinPlayers)
                return false;
            // D'autres validations peuvent être ajoutées
            return true;
        }
    }
}
