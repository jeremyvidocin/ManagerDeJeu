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
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authService = new AuthenticationService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var (success, role) = _authService.Login(txtUsername.Text, txtPassword.Text);
            if (success)
            {
                // Rediriger en fonction du rôle
                if (role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                }
                this.Hide();
            }
            else
            {
                lblError.Text = "Nom d'utilisateur ou mot de passe incorrect.";
            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Fermer l'application
            Application.Exit();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
