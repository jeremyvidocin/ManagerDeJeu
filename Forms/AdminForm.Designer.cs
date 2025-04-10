namespace Manager_de_Jeu.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numMinPlayers;
        private System.Windows.Forms.NumericUpDown numMaxPlayers;
        private System.Windows.Forms.NumericUpDown numCards;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMinPlayers;
        private System.Windows.Forms.Label lblMaxPlayers;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.GroupBox grpGameDetails;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            grpGameDetails = new GroupBox();
            txtDescription = new Bunifu.UI.WinForms.BunifuTextBox();
            txtName = new Bunifu.UI.WinForms.BunifuTextBox();
            lblName = new Label();
            lblDescription = new Label();
            lblMinPlayers = new Label();
            numMinPlayers = new NumericUpDown();
            lblMaxPlayers = new Label();
            numMaxPlayers = new NumericUpDown();
            lblCards = new Label();
            numCards = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelHeader = new Panel();
            bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            lblTitle = new Label();
            dgvGames = new Bunifu.UI.WinForms.BunifuDataGridView();
            txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            lblTotalGames = new Bunifu.UI.WinForms.BunifuLabel();
            grpGameDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCards).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // grpGameDetails
            // 
            grpGameDetails.Controls.Add(txtDescription);
            grpGameDetails.Controls.Add(txtName);
            grpGameDetails.Controls.Add(lblName);
            grpGameDetails.Controls.Add(lblDescription);
            grpGameDetails.Controls.Add(lblMinPlayers);
            grpGameDetails.Controls.Add(numMinPlayers);
            grpGameDetails.Controls.Add(lblMaxPlayers);
            grpGameDetails.Controls.Add(numMaxPlayers);
            grpGameDetails.Controls.Add(lblCards);
            grpGameDetails.Controls.Add(numCards);
            grpGameDetails.Font = new Font("Segoe UI", 10F);
            grpGameDetails.ForeColor = Color.White;
            grpGameDetails.Location = new Point(40, 455);
            grpGameDetails.Name = "grpGameDetails";
            grpGameDetails.Size = new Size(700, 194);
            grpGameDetails.TabIndex = 0;
            grpGameDetails.TabStop = false;
            grpGameDetails.Text = "DÉTAILS DU JEU";
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = false;
            txtDescription.AcceptsTab = false;
            txtDescription.AnimationSpeed = 200;
            txtDescription.AutoCompleteMode = AutoCompleteMode.None;
            txtDescription.AutoCompleteSource = AutoCompleteSource.None;
            txtDescription.AutoSizeHeight = true;
            txtDescription.BackColor = Color.FromArgb(236, 240, 241);
            txtDescription.BackgroundImage = (Image)resources.GetObject("txtDescription.BackgroundImage");
            txtDescription.BorderColorActive = Color.DodgerBlue;
            txtDescription.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtDescription.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtDescription.BorderColorIdle = Color.Silver;
            txtDescription.BorderRadius = 1;
            txtDescription.BorderThickness = 1;
            txtDescription.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.DefaultFont = new Font("Segoe UI", 9.25F);
            txtDescription.DefaultText = "";
            txtDescription.FillColor = Color.FromArgb(236, 240, 241);
            txtDescription.HideSelection = true;
            txtDescription.IconLeft = null;
            txtDescription.IconLeftCursor = Cursors.IBeam;
            txtDescription.IconPadding = 10;
            txtDescription.IconRight = null;
            txtDescription.IconRightCursor = Cursors.IBeam;
            txtDescription.Location = new Point(20, 116);
            txtDescription.MaxLength = 32767;
            txtDescription.MinimumSize = new Size(1, 1);
            txtDescription.Modified = false;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtDescription.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtDescription.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtDescription.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.FromArgb(236, 240, 241);
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtDescription.OnIdleState = stateProperties4;
            txtDescription.Padding = new Padding(3);
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderForeColor = Color.Silver;
            txtDescription.PlaceholderText = "";
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(260, 39);
            txtDescription.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtDescription.TabIndex = 2;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.TextMarginBottom = 0;
            txtDescription.TextMarginLeft = 3;
            txtDescription.TextMarginTop = 1;
            txtDescription.TextPlaceholder = "";
            txtDescription.UseSystemPasswordChar = false;
            txtDescription.WordWrap = true;
            // 
            // txtName
            // 
            txtName.AcceptsReturn = false;
            txtName.AcceptsTab = false;
            txtName.AnimationSpeed = 200;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.AutoSizeHeight = true;
            txtName.BackColor = Color.FromArgb(236, 240, 241);
            txtName.BackgroundImage = (Image)resources.GetObject("txtName.BackgroundImage");
            txtName.BorderColorActive = Color.DodgerBlue;
            txtName.BorderColorDisabled = Color.FromArgb(255, 128, 0);
            txtName.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtName.BorderColorIdle = Color.Gray;
            txtName.BorderRadius = 1;
            txtName.BorderThickness = 1;
            txtName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.DefaultFont = new Font("Segoe UI", 9.25F);
            txtName.DefaultText = "";
            txtName.FillColor = Color.FromArgb(236, 240, 241);
            txtName.ForeColor = SystemColors.Menu;
            txtName.HideSelection = true;
            txtName.IconLeft = null;
            txtName.IconLeftCursor = Cursors.IBeam;
            txtName.IconPadding = 10;
            txtName.IconRight = null;
            txtName.IconRightCursor = Cursors.IBeam;
            txtName.Location = new Point(20, 56);
            txtName.MaxLength = 32767;
            txtName.MinimumSize = new Size(1, 1);
            txtName.Modified = false;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            txtName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(255, 128, 0);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            txtName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            txtName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Gray;
            stateProperties8.FillColor = Color.FromArgb(236, 240, 241);
            stateProperties8.ForeColor = SystemColors.Menu;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            txtName.OnIdleState = stateProperties8;
            txtName.Padding = new Padding(3);
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.SlateGray;
            txtName.PlaceholderText = "";
            txtName.ReadOnly = false;
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(260, 31);
            txtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMarginBottom = 0;
            txtName.TextMarginLeft = 3;
            txtName.TextMarginTop = 1;
            txtName.TextPlaceholder = "";
            txtName.UseSystemPasswordChar = false;
            txtName.WordWrap = true;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Nom :";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 90);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description :";
            // 
            // lblMinPlayers
            // 
            lblMinPlayers.ForeColor = Color.White;
            lblMinPlayers.Location = new Point(350, 30);
            lblMinPlayers.Name = "lblMinPlayers";
            lblMinPlayers.Size = new Size(100, 23);
            lblMinPlayers.TabIndex = 0;
            lblMinPlayers.Text = "Min Joueurs :";
            // 
            // numMinPlayers
            // 
            numMinPlayers.Location = new Point(350, 55);
            numMinPlayers.Name = "numMinPlayers";
            numMinPlayers.Size = new Size(100, 25);
            numMinPlayers.TabIndex = 0;
            // 
            // lblMaxPlayers
            // 
            lblMaxPlayers.ForeColor = Color.White;
            lblMaxPlayers.Location = new Point(350, 90);
            lblMaxPlayers.Name = "lblMaxPlayers";
            lblMaxPlayers.Size = new Size(100, 23);
            lblMaxPlayers.TabIndex = 0;
            lblMaxPlayers.Text = "Max Joueurs :";
            // 
            // numMaxPlayers
            // 
            numMaxPlayers.BackColor = SystemColors.Window;
            numMaxPlayers.Location = new Point(350, 115);
            numMaxPlayers.Name = "numMaxPlayers";
            numMaxPlayers.Size = new Size(100, 25);
            numMaxPlayers.TabIndex = 0;
            // 
            // lblCards
            // 
            lblCards.ForeColor = Color.White;
            lblCards.Location = new Point(500, 30);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(100, 23);
            lblCards.TabIndex = 0;
            lblCards.Text = "Cartes :";
            // 
            // numCards
            // 
            numCards.Location = new Point(500, 55);
            numCards.Name = "numCards";
            numCards.Size = new Size(100, 25);
            numCards.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(241, 196, 15);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(44, 62, 80);
            btnAdd.Location = new Point(943, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += Button_MouseEnter;
            btnAdd.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(44, 62, 80);
            btnUpdate.Location = new Point(943, 293);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += Button_MouseEnter;
            btnUpdate.MouseLeave += Button_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(236, 240, 241);
            btnDelete.Location = new Point(943, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(39, 174, 96);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(236, 240, 241);
            btnClear.Location = new Point(753, 533);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 6;
            btnClear.Text = "Effacer";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += Button_MouseEnter;
            btnClear.MouseLeave += Button_MouseLeave;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(44, 62, 80);
            panelHeader.Controls.Add(bunifuIconButton1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1180, 60);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // bunifuIconButton1
            // 
            bunifuIconButton1.AllowAnimations = true;
            bunifuIconButton1.AllowBorderColorChanges = false;
            bunifuIconButton1.AllowMouseEffects = true;
            bunifuIconButton1.AnimationSpeed = 200;
            bunifuIconButton1.BackColor = Color.Transparent;
            bunifuIconButton1.BackgroundColor = Color.Crimson;
            bunifuIconButton1.BorderColor = Color.Crimson;
            bunifuIconButton1.BorderRadius = 1;
            bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            bunifuIconButton1.BorderThickness = 0;
            bunifuIconButton1.ColorContrastOnClick = 30;
            bunifuIconButton1.ColorContrastOnHover = 30;
            bunifuIconButton1.Cursor = Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuIconButton1.CustomizableEdges = borderEdges1;
            bunifuIconButton1.DialogResult = DialogResult.OK;
            bunifuIconButton1.Image = (Image)resources.GetObject("bunifuIconButton1.Image");
            bunifuIconButton1.ImageMargin = new Padding(0);
            bunifuIconButton1.Location = new Point(1155, 3);
            bunifuIconButton1.Name = "bunifuIconButton1";
            bunifuIconButton1.RoundBorders = true;
            bunifuIconButton1.ShowBorders = true;
            bunifuIconButton1.Size = new Size(22, 22);
            bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            bunifuIconButton1.TabIndex = 10;
            bunifuIconButton1.Click += bunifuIconButton1_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(236, 240, 241);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1180, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTION DES JEUX";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvGames
            // 
            dgvGames.AllowCustomTheming = false;
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvGames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGames.BorderStyle = BorderStyle.None;
            dgvGames.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGames.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGames.ColumnHeadersHeight = 40;
            dgvGames.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvGames.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvGames.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvGames.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvGames.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvGames.CurrentTheme.BackColor = Color.White;
            dgvGames.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvGames.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvGames.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvGames.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvGames.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvGames.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvGames.CurrentTheme.Name = null;
            dgvGames.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvGames.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvGames.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvGames.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvGames.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGames.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGames.EnableHeadersVisualStyles = false;
            dgvGames.GridColor = Color.FromArgb(221, 238, 255);
            dgvGames.HeaderBackColor = Color.DodgerBlue;
            dgvGames.HeaderBgColor = Color.Empty;
            dgvGames.HeaderForeColor = Color.White;
            dgvGames.Location = new Point(40, 72);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.RowHeadersVisible = false;
            dgvGames.RowTemplate.Height = 40;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(833, 377);
            dgvGames.TabIndex = 0;
            dgvGames.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvGames.CellContentClick += dgvGames_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.AcceptsReturn = false;
            txtSearch.AcceptsTab = false;
            txtSearch.AnimationSpeed = 200;
            txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtSearch.AutoCompleteSource = AutoCompleteSource.None;
            txtSearch.AutoSizeHeight = true;
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BackgroundImage = (Image)resources.GetObject("txtSearch.BackgroundImage");
            txtSearch.BorderColorActive = Color.DodgerBlue;
            txtSearch.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtSearch.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtSearch.BorderColorIdle = Color.Silver;
            txtSearch.BorderRadius = 25;
            txtSearch.BorderThickness = 1;
            txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.DefaultFont = new Font("Segoe UI", 9.25F);
            txtSearch.DefaultText = "";
            txtSearch.FillColor = Color.White;
            txtSearch.HideSelection = true;
            txtSearch.IconLeft = null;
            txtSearch.IconLeftCursor = Cursors.IBeam;
            txtSearch.IconPadding = 10;
            txtSearch.IconRight = null;
            txtSearch.IconRightCursor = Cursors.IBeam;
            txtSearch.Location = new Point(943, 125);
            txtSearch.MaxLength = 32767;
            txtSearch.MinimumSize = new Size(1, 1);
            txtSearch.Modified = false;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            txtSearch.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            txtSearch.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            txtSearch.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            txtSearch.OnIdleState = stateProperties12;
            txtSearch.Padding = new Padding(3);
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Silver;
            txtSearch.PlaceholderText = "\r\nRechercher";
            txtSearch.ReadOnly = false;
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(225, 39);
            txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtSearch.TabIndex = 8;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextMarginBottom = 0;
            txtSearch.TextMarginLeft = 3;
            txtSearch.TextMarginTop = 1;
            txtSearch.TextPlaceholder = "\r\nRechercher";
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.WordWrap = true;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotalGames
            // 
            lblTotalGames.AllowParentOverrides = false;
            lblTotalGames.AutoEllipsis = false;
            lblTotalGames.CursorType = Cursors.Default;
            lblTotalGames.Font = new Font("Segoe UI", 9F);
            lblTotalGames.ForeColor = Color.White;
            lblTotalGames.Location = new Point(791, 455);
            lblTotalGames.Name = "lblTotalGames";
            lblTotalGames.RightToLeft = RightToLeft.No;
            lblTotalGames.Size = new Size(82, 15);
            lblTotalGames.TabIndex = 9;
            lblTotalGames.Text = "Total de jeux : 0";
            lblTotalGames.TextAlignment = ContentAlignment.TopLeft;
            lblTotalGames.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(1180, 699);
            Controls.Add(dgvGames);
            Controls.Add(lblTotalGames);
            Controls.Add(txtSearch);
            Controls.Add(grpGameDetails);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(panelHeader);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administration - Gestion des jeux";
            grpGameDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCards).EndInit();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView dgvGames;
        private Bunifu.UI.WinForms.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalGames;
    }
}