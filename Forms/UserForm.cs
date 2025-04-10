using Manager_de_Jeu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_de_Jeu.Forms
{
    public partial class UserForm : Form
    {
        private readonly SearchService _searchService = new SearchService();
        private readonly GameService _gameService = new GameService();
        public UserForm()
        {
            InitializeComponent();
            // Optionnel : initialiser le ComboBox avec les champs autorisés pour le tri
            cboSort.Items.AddRange(new string[] { "Nom", "DateAdded", "MinPlayers" });
            cboSort.SelectedIndex = 0;
            LoadGames();
        }

        private void LoadGames()
        {
            dgvGames.DataSource = _gameService.GetAllGames();
            lblTotalGames.Text = $"Total de jeux : {((DataTable)dgvGames.DataSource).Rows.Count}";


        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dgvGames.ReadOnly = true;
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Supposons que la colonne "Id" ne soit pas pertinente pour l'utilisateur final
            if (dgvGames.Columns.Contains("Id"))
            {
                dgvGames.Columns["Id"].Visible = false;
            }
            //dgvGames.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            //dgvGames.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            //dgvGames.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGames.Font, FontStyle.Bold);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvGames.DataSource = _searchService.SearchGamesByName(txtSearch.Text);
            lblTotalGames.Text = $"Total de jeux : {((DataTable)dgvGames.DataSource).Rows.Count}";
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvGames.DataSource = _searchService.SortGames(cboSort.SelectedItem.ToString());
        }

        // Événement pour le bouton de déconnexion
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Afficher la page de connexion
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Afficher le formulaire de connexion
            this.Hide(); // Masquer le formulaire actuel
        }

        // Événement pour le bouton de fermeture
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Fermer l'application
            Application.Exit();
        }

        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            // Afficher la page de connexion
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Afficher le formulaire de connexion
            this.Hide(); // Masquer le formulaire actuel
        }

        private void lblTotalGames_Click(object sender, EventArgs e)
        {

        }
    }
}
