namespace Manager_de_Jeu.Forms
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            lblSort = new Label();
            cboSort = new ComboBox();
            lblTotalGames = new Label();
            dgvGames = new Bunifu.UI.WinForms.BunifuDataGridView();
            bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuIconButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            bunifuPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSort
            // 
            lblSort.BackColor = Color.FromArgb(44, 62, 80);
            lblSort.ForeColor = Color.FromArgb(236, 240, 241);
            lblSort.Location = new Point(25, 255);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(100, 23);
            lblSort.TabIndex = 3;
            lblSort.Text = "Trier par :";
            // 
            // cboSort
            // 
            cboSort.BackColor = Color.FromArgb(236, 240, 241);
            cboSort.ForeColor = Color.FromArgb(44, 62, 80);
            cboSort.Location = new Point(25, 281);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(150, 23);
            cboSort.TabIndex = 4;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // lblTotalGames
            // 
            lblTotalGames.BackColor = Color.FromArgb(44, 62, 80);
            lblTotalGames.ForeColor = Color.FromArgb(236, 240, 241);
            lblTotalGames.Location = new Point(25, 390);
            lblTotalGames.Name = "lblTotalGames";
            lblTotalGames.Size = new Size(150, 23);
            lblTotalGames.TabIndex = 5;
            lblTotalGames.Text = "Total de jeux : 0";
            lblTotalGames.Click += lblTotalGames_Click;
            // 
            // dgvGames
            // 
            dgvGames.AllowCustomTheming = false;
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.AllowUserToOrderColumns = true;
            dgvGames.AllowUserToResizeColumns = false;
            dgvGames.AllowUserToResizeRows = false;
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
            dgvGames.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(44, 62, 80);
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
            dgvGames.HeaderBackColor = Color.FromArgb(44, 62, 80);
            dgvGames.HeaderBgColor = Color.Empty;
            dgvGames.HeaderForeColor = Color.White;
            dgvGames.Location = new Point(25, 27);
            dgvGames.Name = "dgvGames";
            dgvGames.RowHeadersVisible = false;
            dgvGames.RowTemplate.Height = 40;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(828, 454);
            dgvGames.TabIndex = 8;
            dgvGames.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvGames.CellContentClick += dgvGames_CellContentClick;
            // 
            // bunifuIconButton1
            // 
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuIconButton1.CustomizableEdges = borderEdges1;
            bunifuIconButton1.DialogResult = DialogResult.None;
            bunifuIconButton1.Image = (Image)resources.GetObject("bunifuIconButton1.Image");
            bunifuIconButton1.ImageMargin = new Padding(0);
            bunifuIconButton1.Location = new Point(175, 3);
            bunifuIconButton1.Name = "bunifuIconButton1";
            bunifuIconButton1.RoundBorders = true;
            bunifuIconButton1.ShowBorders = true;
            bunifuIconButton1.Size = new Size(22, 22);
            bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            bunifuIconButton1.TabIndex = 10;
            bunifuIconButton1.Click += bunifuIconButton1_Click;
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.FromArgb(44, 62, 80);
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 3;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(bunifuIconButton2);
            bunifuPanel1.Controls.Add(txtSearch);
            bunifuPanel1.Controls.Add(bunifuIconButton1);
            bunifuPanel1.Controls.Add(lblSort);
            bunifuPanel1.Controls.Add(cboSort);
            bunifuPanel1.Controls.Add(lblTotalGames);
            bunifuPanel1.Location = new Point(878, -2);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(201, 512);
            bunifuPanel1.TabIndex = 11;
            // 
            // bunifuIconButton2
            // 
            bunifuIconButton2.AllowAnimations = true;
            bunifuIconButton2.AllowBorderColorChanges = true;
            bunifuIconButton2.AllowMouseEffects = true;
            bunifuIconButton2.AnimationSpeed = 200;
            bunifuIconButton2.BackColor = Color.Transparent;
            bunifuIconButton2.BackgroundColor = Color.Transparent;
            bunifuIconButton2.BorderColor = Color.Transparent;
            bunifuIconButton2.BorderRadius = 1;
            bunifuIconButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            bunifuIconButton2.BorderThickness = 1;
            bunifuIconButton2.ColorContrastOnClick = 30;
            bunifuIconButton2.ColorContrastOnHover = 30;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = false;
            borderEdges2.TopRight = false;
            bunifuIconButton2.CustomizableEdges = borderEdges2;
            bunifuIconButton2.DialogResult = DialogResult.None;
            bunifuIconButton2.Image = (Image)resources.GetObject("bunifuIconButton2.Image");
            bunifuIconButton2.ImageMargin = new Padding(0);
            bunifuIconButton2.Location = new Point(156, 461);
            bunifuIconButton2.Name = "bunifuIconButton2";
            bunifuIconButton2.RoundBorders = true;
            bunifuIconButton2.ShowBorders = false;
            bunifuIconButton2.Size = new Size(35, 35);
            bunifuIconButton2.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            bunifuIconButton2.TabIndex = 12;
            bunifuIconButton2.Click += bunifuIconButton2_Click;
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
            txtSearch.Location = new Point(25, 137);
            txtSearch.MaxLength = 32767;
            txtSearch.MinimumSize = new Size(1, 1);
            txtSearch.Modified = false;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtSearch.OnIdleState = stateProperties4;
            txtSearch.Padding = new Padding(3);
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Silver;
            txtSearch.PlaceholderText = "Rechercher";
            txtSearch.ReadOnly = false;
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(150, 39);
            txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtSearch.TabIndex = 11;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextMarginBottom = 0;
            txtSearch.TextMarginLeft = 3;
            txtSearch.TextMarginTop = 1;
            txtSearch.TextPlaceholder = "Rechercher";
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.WordWrap = true;
            // 
            // UserForm
            // 
            BackColor = Color.FromArgb(176, 214, 255);
            ClientSize = new Size(1077, 506);
            Controls.Add(dgvGames);
            Controls.Add(bunifuPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bibliothèque de Jeux";
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            bunifuPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboSort;
        private Label lblTotalGames;
        private Label lblSort;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvGames;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton2;
    }
}