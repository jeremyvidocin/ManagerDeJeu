namespace Manager_de_Jeu.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            btnLogin = new Button();
            txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            lblTitle = new Label();
            lblPassword = new Label();
            txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            lblUsername = new Label();
            lblError = new Label();
            panelContainer = new Panel();
            bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            resources.ApplyResources(bunifuShadowPanel1, "bunifuShadowPanel1");
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
            bunifuShadowPanel1.BorderRadius = 1;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.Controls.Add(bunifuPictureBox1);
            bunifuShadowPanel1.Controls.Add(btnLogin);
            bunifuShadowPanel1.Controls.Add(txtPassword);
            bunifuShadowPanel1.Controls.Add(lblTitle);
            bunifuShadowPanel1.Controls.Add(lblPassword);
            bunifuShadowPanel1.Controls.Add(txtUsername);
            bunifuShadowPanel1.Controls.Add(lblUsername);
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.PanelColor = Color.FromArgb(236, 240, 241);
            bunifuShadowPanel1.PanelColor2 = Color.FromArgb(236, 240, 241);
            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 5;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            // 
            // bunifuPictureBox1
            // 
            resources.ApplyResources(bunifuPictureBox1, "bunifuPictureBox1");
            bunifuPictureBox1.AllowFocused = false;
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BorderRadius = 35;
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.TabStop = false;
            bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.FromArgb(241, 196, 15);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.ForeColor = Color.FromArgb(44, 62, 80);
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsReturn = false;
            txtPassword.AcceptsTab = false;
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.AnimationSpeed = 200;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.AutoSizeHeight = true;
            txtPassword.BackColor = Color.FromArgb(236, 240, 241);
            txtPassword.BorderColorActive = Color.DodgerBlue;
            txtPassword.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtPassword.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtPassword.BorderColorIdle = Color.Silver;
            txtPassword.BorderRadius = 1;
            txtPassword.BorderThickness = 1;
            txtPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.DefaultFont = new Font("Segoe UI", 9.25F);
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.FromArgb(236, 240, 241);
            txtPassword.HideSelection = true;
            txtPassword.IconLeft = null;
            txtPassword.IconLeftCursor = Cursors.IBeam;
            txtPassword.IconPadding = 10;
            txtPassword.IconRight = null;
            txtPassword.IconRightCursor = Cursors.IBeam;
            txtPassword.MaxLength = 32767;
            txtPassword.Modified = false;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.FromArgb(236, 240, 241);
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtPassword.OnIdleState = stateProperties4;
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderForeColor = Color.Silver;
            txtPassword.PlaceholderText = "";
            txtPassword.ReadOnly = false;
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMarginBottom = 0;
            txtPassword.TextMarginLeft = 3;
            txtPassword.TextMarginTop = 1;
            txtPassword.TextPlaceholder = "";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.WordWrap = true;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Name = "lblTitle";
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblPassword.Name = "lblPassword";
            // 
            // txtUsername
            // 
            txtUsername.AcceptsReturn = false;
            txtUsername.AcceptsTab = false;
            resources.ApplyResources(txtUsername, "txtUsername");
            txtUsername.AnimationSpeed = 200;
            txtUsername.AutoCompleteMode = AutoCompleteMode.None;
            txtUsername.AutoCompleteSource = AutoCompleteSource.None;
            txtUsername.AutoSizeHeight = true;
            txtUsername.BackColor = Color.FromArgb(236, 240, 241);
            txtUsername.BorderColorActive = Color.DodgerBlue;
            txtUsername.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtUsername.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtUsername.BorderColorIdle = Color.Silver;
            txtUsername.BorderRadius = 1;
            txtUsername.BorderThickness = 1;
            txtUsername.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtUsername.CharacterCasing = CharacterCasing.Normal;
            txtUsername.DefaultFont = new Font("Segoe UI", 9.25F);
            txtUsername.DefaultText = "";
            txtUsername.FillColor = Color.FromArgb(236, 240, 241);
            txtUsername.HideSelection = true;
            txtUsername.IconLeft = null;
            txtUsername.IconLeftCursor = Cursors.IBeam;
            txtUsername.IconPadding = 10;
            txtUsername.IconRight = null;
            txtUsername.IconRightCursor = Cursors.IBeam;
            txtUsername.MaxLength = 32767;
            txtUsername.Modified = false;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            txtUsername.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            txtUsername.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            txtUsername.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.FromArgb(236, 240, 241);
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            txtUsername.OnIdleState = stateProperties8;
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.Silver;
            txtUsername.PlaceholderText = "";
            txtUsername.ReadOnly = false;
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.ShortcutsEnabled = true;
            txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TextMarginBottom = 0;
            txtUsername.TextMarginLeft = 3;
            txtUsername.TextMarginTop = 1;
            txtUsername.TextPlaceholder = "";
            txtUsername.UseSystemPasswordChar = false;
            txtUsername.WordWrap = true;
            // 
            // lblUsername
            // 
            resources.ApplyResources(lblUsername, "lblUsername");
            lblUsername.ForeColor = Color.FromArgb(44, 62, 80);
            lblUsername.Name = "lblUsername";
            // 
            // lblError
            // 
            resources.ApplyResources(lblError, "lblError");
            lblError.ForeColor = Color.FromArgb(231, 76, 60);
            lblError.Name = "lblError";
            // 
            // panelContainer
            // 
            resources.ApplyResources(panelContainer, "panelContainer");
            panelContainer.BackColor = Color.FromArgb(236, 240, 241);
            panelContainer.Controls.Add(lblError);
            panelContainer.Name = "panelContainer";
            // 
            // bunifuIconButton1
            // 
            resources.ApplyResources(bunifuIconButton1, "bunifuIconButton1");
            bunifuIconButton1.AllowAnimations = true;
            bunifuIconButton1.AllowBorderColorChanges = true;
            bunifuIconButton1.AllowMouseEffects = true;
            bunifuIconButton1.AnimationSpeed = 200;
            bunifuIconButton1.BackColor = Color.Transparent;
            bunifuIconButton1.BackgroundColor = Color.Crimson;
            bunifuIconButton1.BorderColor = Color.Crimson;
            bunifuIconButton1.BorderRadius = 1;
            bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            bunifuIconButton1.BorderThickness = 1;
            bunifuIconButton1.ColorContrastOnClick = 30;
            bunifuIconButton1.ColorContrastOnHover = 30;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = false;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = false;
            bunifuIconButton1.CustomizableEdges = borderEdges1;
            bunifuIconButton1.DialogResult = DialogResult.None;
            bunifuIconButton1.Image = (Image)resources.GetObject("bunifuIconButton1.Image");
            bunifuIconButton1.ImageMargin = new Padding(0);
            bunifuIconButton1.Name = "bunifuIconButton1";
            bunifuIconButton1.RoundBorders = true;
            bunifuIconButton1.ShowBorders = false;
            bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            bunifuIconButton1.Click += bunifuIconButton1_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 214, 255);
            Controls.Add(bunifuIconButton1);
            Controls.Add(bunifuShadowPanel1);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            bunifuShadowPanel1.ResumeLayout(false);
            bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).EndInit();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Label lblTitle;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private Label lblUsername;
        private Label lblError;
        private Button btnLogin;
        private Label lblPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Panel panelContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
    }
}