namespace TrpoFilmApp
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnBack = new Guna.UI.WinForms.GunaPictureBox();
            this.PanelSearch = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.UserName = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserPicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.UserPanel = new Guna.UI.WinForms.GunaPanel();
            this.btnWatchLater = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFavourites = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSoonFilm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFilm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AdminPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btnAdmin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new Guna.UI.WinForms.GunaPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new System.Windows.Forms.Panel();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnBack);
            this.gunaShadowPanel1.Controls.Add(this.PanelSearch);
            this.gunaShadowPanel1.Controls.Add(this.UserName);
            this.gunaShadowPanel1.Controls.Add(this.panel2);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(170, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 50;
            this.gunaShadowPanel1.ShadowShift = 2;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(760, 55);
            this.gunaShadowPanel1.TabIndex = 3;
            this.gunaShadowPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaShadowPanel1_MouseDown);
            this.gunaShadowPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaShadowPanel1_MouseMove);
            // 
            // btnBack
            // 
            this.btnBack.BaseColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(21, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(20, 20);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 10;
            this.btnBack.TabStop = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.gunaPictureBox3_Click);
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.gunaPictureBox1);
            this.PanelSearch.Controls.Add(this.gunaTextBox1);
            this.PanelSearch.Location = new System.Drawing.Point(66, 11);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(224, 30);
            this.PanelSearch.TabIndex = 10;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(193, 5);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.gunaTextBox1.Location = new System.Drawing.Point(3, 2);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(217, 26);
            this.gunaTextBox1.TabIndex = 6;
            this.gunaTextBox1.Text = "Search for movies";
            this.gunaTextBox1.Enter += new System.EventHandler(this.gunaTextBox1_Enter);
            this.gunaTextBox1.Leave += new System.EventHandler(this.gunaTextBox1_Leave);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserName.Location = new System.Drawing.Point(624, 1);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(72, 48);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "Alekxey";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserName.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UserPicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(704, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 55);
            this.panel2.TabIndex = 5;
            // 
            // UserPicture
            // 
            this.UserPicture.BaseColor = System.Drawing.Color.White;
            this.UserPicture.Image = ((System.Drawing.Image)(resources.GetObject("UserPicture.Image")));
            this.UserPicture.Location = new System.Drawing.Point(3, 6);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(38, 38);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 7;
            this.UserPicture.TabStop = false;
            this.UserPicture.UseTransfarantBackground = false;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.UserPanel);
            this.gunaPanel1.Controls.Add(this.AdminPanel);
            this.gunaPanel1.Controls.Add(this.panel1);
            this.gunaPanel1.Controls.Add(this.button1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(170, 555);
            this.gunaPanel1.TabIndex = 4;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.btnWatchLater);
            this.UserPanel.Controls.Add(this.btnFavourites);
            this.UserPanel.Controls.Add(this.btnSoonFilm);
            this.UserPanel.Controls.Add(this.btnFilm);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 137);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(170, 188);
            this.UserPanel.TabIndex = 7;
            // 
            // btnWatchLater
            // 
            this.btnWatchLater.AnimationHoverSpeed = 0.07F;
            this.btnWatchLater.AnimationSpeed = 0.03F;
            this.btnWatchLater.BaseColor = System.Drawing.Color.White;
            this.btnWatchLater.BorderColor = System.Drawing.Color.Black;
            this.btnWatchLater.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnWatchLater.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnWatchLater.CheckedForeColor = System.Drawing.Color.Black;
            this.btnWatchLater.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnWatchLater.CheckedImage")));
            this.btnWatchLater.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnWatchLater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchLater.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnWatchLater.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWatchLater.FocusedColor = System.Drawing.Color.Empty;
            this.btnWatchLater.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWatchLater.ForeColor = System.Drawing.Color.Black;
            this.btnWatchLater.Image = ((System.Drawing.Image)(resources.GetObject("btnWatchLater.Image")));
            this.btnWatchLater.ImageOffsetX = 5;
            this.btnWatchLater.ImageSize = new System.Drawing.Size(19, 19);
            this.btnWatchLater.LineColor = System.Drawing.SystemColors.Control;
            this.btnWatchLater.Location = new System.Drawing.Point(0, 126);
            this.btnWatchLater.Name = "btnWatchLater";
            this.btnWatchLater.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnWatchLater.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnWatchLater.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnWatchLater.OnHoverImage = null;
            this.btnWatchLater.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnWatchLater.OnPressedColor = System.Drawing.Color.Black;
            this.btnWatchLater.Size = new System.Drawing.Size(170, 42);
            this.btnWatchLater.TabIndex = 6;
            this.btnWatchLater.Text = "    Watch Later";
            this.btnWatchLater.Click += new System.EventHandler(this.btnWatchLater_Click);
            // 
            // btnFavourites
            // 
            this.btnFavourites.AnimationHoverSpeed = 0.07F;
            this.btnFavourites.AnimationSpeed = 0.03F;
            this.btnFavourites.BaseColor = System.Drawing.Color.White;
            this.btnFavourites.BorderColor = System.Drawing.Color.Black;
            this.btnFavourites.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnFavourites.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFavourites.CheckedForeColor = System.Drawing.Color.Black;
            this.btnFavourites.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnFavourites.CheckedImage")));
            this.btnFavourites.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavourites.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFavourites.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavourites.FocusedColor = System.Drawing.Color.Empty;
            this.btnFavourites.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFavourites.ForeColor = System.Drawing.Color.Black;
            this.btnFavourites.Image = ((System.Drawing.Image)(resources.GetObject("btnFavourites.Image")));
            this.btnFavourites.ImageOffsetX = 5;
            this.btnFavourites.ImageSize = new System.Drawing.Size(19, 19);
            this.btnFavourites.LineColor = System.Drawing.SystemColors.Control;
            this.btnFavourites.Location = new System.Drawing.Point(0, 84);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnFavourites.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFavourites.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnFavourites.OnHoverImage = null;
            this.btnFavourites.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnFavourites.OnPressedColor = System.Drawing.Color.Black;
            this.btnFavourites.Size = new System.Drawing.Size(170, 42);
            this.btnFavourites.TabIndex = 4;
            this.btnFavourites.Text = "    Favourites";
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            // 
            // btnSoonFilm
            // 
            this.btnSoonFilm.AnimationHoverSpeed = 0.07F;
            this.btnSoonFilm.AnimationSpeed = 0.03F;
            this.btnSoonFilm.BaseColor = System.Drawing.Color.White;
            this.btnSoonFilm.BorderColor = System.Drawing.Color.Black;
            this.btnSoonFilm.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSoonFilm.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSoonFilm.CheckedForeColor = System.Drawing.Color.Black;
            this.btnSoonFilm.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSoonFilm.CheckedImage")));
            this.btnSoonFilm.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnSoonFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoonFilm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSoonFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoonFilm.FocusedColor = System.Drawing.Color.Empty;
            this.btnSoonFilm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSoonFilm.ForeColor = System.Drawing.Color.Black;
            this.btnSoonFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnSoonFilm.Image")));
            this.btnSoonFilm.ImageOffsetX = 5;
            this.btnSoonFilm.ImageSize = new System.Drawing.Size(19, 19);
            this.btnSoonFilm.LineColor = System.Drawing.SystemColors.Control;
            this.btnSoonFilm.Location = new System.Drawing.Point(0, 42);
            this.btnSoonFilm.Name = "btnSoonFilm";
            this.btnSoonFilm.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnSoonFilm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSoonFilm.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSoonFilm.OnHoverImage = null;
            this.btnSoonFilm.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnSoonFilm.OnPressedColor = System.Drawing.Color.Black;
            this.btnSoonFilm.Size = new System.Drawing.Size(170, 42);
            this.btnSoonFilm.TabIndex = 3;
            this.btnSoonFilm.Text = "    Скоро в кино";
            this.btnSoonFilm.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.AnimationHoverSpeed = 0.07F;
            this.btnFilm.AnimationSpeed = 0.03F;
            this.btnFilm.BaseColor = System.Drawing.Color.White;
            this.btnFilm.BorderColor = System.Drawing.Color.Black;
            this.btnFilm.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnFilm.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFilm.CheckedForeColor = System.Drawing.Color.Black;
            this.btnFilm.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnFilm.CheckedImage")));
            this.btnFilm.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm.FocusedColor = System.Drawing.Color.Empty;
            this.btnFilm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilm.ForeColor = System.Drawing.Color.Black;
            this.btnFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnFilm.Image")));
            this.btnFilm.ImageOffsetX = 5;
            this.btnFilm.ImageSize = new System.Drawing.Size(18, 18);
            this.btnFilm.LineColor = System.Drawing.SystemColors.Control;
            this.btnFilm.Location = new System.Drawing.Point(0, 0);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnFilm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFilm.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnFilm.OnHoverImage = null;
            this.btnFilm.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnFilm.OnPressedColor = System.Drawing.Color.Black;
            this.btnFilm.Size = new System.Drawing.Size(170, 42);
            this.btnFilm.TabIndex = 2;
            this.btnFilm.Text = "    Фильмы";
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.gunaSeparator1);
            this.AdminPanel.Controls.Add(this.btnAdmin);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPanel.Location = new System.Drawing.Point(0, 80);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(170, 57);
            this.AdminPanel.TabIndex = 6;
            this.AdminPanel.Visible = false;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(27, 44);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(114, 10);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // btnAdmin
            // 
            this.btnAdmin.AnimationHoverSpeed = 0.07F;
            this.btnAdmin.AnimationSpeed = 0.03F;
            this.btnAdmin.BaseColor = System.Drawing.Color.White;
            this.btnAdmin.BorderColor = System.Drawing.Color.Black;
            this.btnAdmin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdmin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdmin.CheckedForeColor = System.Drawing.Color.Black;
            this.btnAdmin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.CheckedImage")));
            this.btnAdmin.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageOffsetX = 5;
            this.btnAdmin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdmin.LineColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdmin.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdmin.OnHoverImage = null;
            this.btnAdmin.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdmin.Size = new System.Drawing.Size(170, 42);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "    AdminPanel";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 80);
            this.panel1.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.BaseColor = System.Drawing.Color.White;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(36, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(92, 22);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(0, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(257, 135);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(232, 63);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.Location = new System.Drawing.Point(1, 240);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(756, 15);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Онлайн-кинотеатр ORION: фильмы в хорошем качестве всегда приносят настоящее удово" +
    "льствие";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.Location = new System.Drawing.Point(72, 255);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(608, 104);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = resources.GetString("gunaLabel2.Text");
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(170, 55);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(760, 500);
            this.gunaPanel2.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaPictureBox logo;
        private Guna.UI.WinForms.GunaPanel UserPanel;
        private Guna.UI.WinForms.GunaPanel AdminPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel UserName;
        private Guna.UI.WinForms.GunaCirclePictureBox UserPicture;
        private Guna.UI.WinForms.GunaAdvenceButton btnSoonFilm;
        private Guna.UI.WinForms.GunaAdvenceButton btnFilm;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        public Guna.UI.WinForms.GunaAdvenceButton btnAdmin;
        private Guna.UI.WinForms.GunaAdvenceButton btnWatchLater;
        private Guna.UI.WinForms.GunaAdvenceButton btnFavourites;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public System.Windows.Forms.Panel gunaPanel2;
        public Guna.UI.WinForms.GunaPictureBox btnBack;
        public Guna.UI.WinForms.GunaPanel PanelSearch;
    }
}