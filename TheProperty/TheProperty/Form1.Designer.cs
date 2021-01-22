namespace TheProperty
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.TopPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.SearchPanel = new Guna.UI.WinForms.GunaPanel();
            this.btnSearch = new Guna.UI.WinForms.GunaPictureBox();
            this.TextBoxSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnUser = new Guna.UI.WinForms.GunaButton();
            this.btnALL = new Guna.UI.WinForms.GunaButton();
            this.btnAdmPanel = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new Guna.UI.WinForms.GunaPictureBox();
            this.UserName = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric5 = new Guna.UI.WinForms.GunaNumeric();
            this.ComboBoxSeller = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric3 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric4 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric2 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric1 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnEXIT = new Guna.UI.WinForms.GunaButton();
            this.btnUP = new Guna.UI.WinForms.GunaButton();
            this.btnIN = new Guna.UI.WinForms.GunaButton();
            this.InfoPanel = new Guna.UI.WinForms.GunaPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TopPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BaseColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.SearchPanel);
            this.TopPanel.Controls.Add(this.btnUser);
            this.TopPanel.Controls.Add(this.btnALL);
            this.TopPanel.Controls.Add(this.btnAdmPanel);
            this.TopPanel.Controls.Add(this.btnAdd);
            this.TopPanel.Controls.Add(this.btnBack);
            this.TopPanel.Controls.Add(this.UserName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowColor = System.Drawing.Color.Black;
            this.TopPanel.ShadowDepth = 50;
            this.TopPanel.ShadowShift = 2;
            this.TopPanel.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.TopPanel.Size = new System.Drawing.Size(1036, 55);
            this.TopPanel.TabIndex = 10;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.btnSearch);
            this.SearchPanel.Controls.Add(this.TextBoxSearch);
            this.SearchPanel.Location = new System.Drawing.Point(21, 11);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(224, 30);
            this.SearchPanel.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BaseColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(193, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TabStop = false;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearch.BaseColor = System.Drawing.Color.White;
            this.TextBoxSearch.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxSearch.BorderSize = 1;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxSearch.Location = new System.Drawing.Point(3, 2);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.Radius = 10;
            this.TextBoxSearch.Size = new System.Drawing.Size(217, 26);
            this.TextBoxSearch.TabIndex = 6;
            this.TextBoxSearch.Text = "Search";
            this.TextBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.TextBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // btnUser
            // 
            this.btnUser.AnimationHoverSpeed = 0.07F;
            this.btnUser.AnimationSpeed = 0.03F;
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.BaseColor = System.Drawing.Color.Black;
            this.btnUser.BorderColor = System.Drawing.Color.Black;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageSize = new System.Drawing.Size(12, 12);
            this.btnUser.Location = new System.Drawing.Point(992, 11);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = null;
            this.btnUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnUser.Radius = 12;
            this.btnUser.Size = new System.Drawing.Size(32, 30);
            this.btnUser.TabIndex = 21;
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUser.Visible = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnALL
            // 
            this.btnALL.AnimationHoverSpeed = 0.07F;
            this.btnALL.AnimationSpeed = 0.03F;
            this.btnALL.BackColor = System.Drawing.Color.Transparent;
            this.btnALL.BaseColor = System.Drawing.Color.Black;
            this.btnALL.BorderColor = System.Drawing.Color.Black;
            this.btnALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnALL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnALL.FocusedColor = System.Drawing.Color.Empty;
            this.btnALL.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnALL.ForeColor = System.Drawing.Color.White;
            this.btnALL.Image = null;
            this.btnALL.ImageSize = new System.Drawing.Size(20, 20);
            this.btnALL.Location = new System.Drawing.Point(992, 11);
            this.btnALL.Name = "btnALL";
            this.btnALL.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnALL.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnALL.OnHoverForeColor = System.Drawing.Color.White;
            this.btnALL.OnHoverImage = null;
            this.btnALL.OnPressedColor = System.Drawing.Color.Black;
            this.btnALL.Radius = 12;
            this.btnALL.Size = new System.Drawing.Size(32, 30);
            this.btnALL.TabIndex = 20;
            this.btnALL.Text = "ALL";
            this.btnALL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnALL.Visible = false;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // btnAdmPanel
            // 
            this.btnAdmPanel.AnimationHoverSpeed = 0.07F;
            this.btnAdmPanel.AnimationSpeed = 0.03F;
            this.btnAdmPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmPanel.BaseColor = System.Drawing.Color.Black;
            this.btnAdmPanel.BorderColor = System.Drawing.Color.Black;
            this.btnAdmPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmPanel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdmPanel.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdmPanel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdmPanel.ForeColor = System.Drawing.Color.White;
            this.btnAdmPanel.Image = null;
            this.btnAdmPanel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdmPanel.Location = new System.Drawing.Point(692, 12);
            this.btnAdmPanel.Name = "btnAdmPanel";
            this.btnAdmPanel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmPanel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdmPanel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdmPanel.OnHoverImage = null;
            this.btnAdmPanel.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdmPanel.Radius = 12;
            this.btnAdmPanel.Size = new System.Drawing.Size(144, 30);
            this.btnAdmPanel.TabIndex = 19;
            this.btnAdmPanel.Text = "Admin Panel";
            this.btnAdmPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdmPanel.Visible = false;
            this.btnAdmPanel.Click += new System.EventHandler(this.gunaButton7_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Black;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(842, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 12;
            this.btnAdd.Size = new System.Drawing.Size(144, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить объявление";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.gunaButton6_Click);
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserName.Location = new System.Drawing.Point(710, 16);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(93, 20);
            this.UserName.TabIndex = 11;
            this.UserName.Text = "Name";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserName.UseMnemonic = false;
            this.UserName.Visible = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.gunaButton1);
            this.gunaElipsePanel1.Controls.Add(this.gunaCheckBox1);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel9);
            this.gunaElipsePanel1.Controls.Add(this.gunaNumeric5);
            this.gunaElipsePanel1.Controls.Add(this.ComboBoxSeller);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel8);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel5);
            this.gunaElipsePanel1.Controls.Add(this.gunaNumeric3);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel6);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel7);
            this.gunaElipsePanel1.Controls.Add(this.gunaNumeric4);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel1.Controls.Add(this.gunaNumeric2);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.gunaNumeric1);
            this.gunaElipsePanel1.Controls.Add(this.gunaButton5);
            this.gunaElipsePanel1.Controls.Add(this.gunaButton4);
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(2, 58);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 12;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(190, 483);
            this.gunaElipsePanel1.TabIndex = 11;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Black;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(155, 433);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 12;
            this.gunaButton1.Size = new System.Drawing.Size(29, 30);
            this.gunaButton1.TabIndex = 67;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.Black;
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(7, 358);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Radius = 3;
            this.gunaCheckBox1.Size = new System.Drawing.Size(176, 20);
            this.gunaCheckBox1.TabIndex = 66;
            this.gunaCheckBox1.Text = "Не 1-й и не последний этаж";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(51, 304);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(87, 15);
            this.gunaLabel9.TabIndex = 65;
            this.gunaLabel9.Text = "Этажей в доме";
            // 
            // gunaNumeric5
            // 
            this.gunaNumeric5.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric5.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric5.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric5.ButtonColor = System.Drawing.Color.Black;
            this.gunaNumeric5.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric5.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric5.Location = new System.Drawing.Point(5, 323);
            this.gunaNumeric5.Maximum = ((long)(50));
            this.gunaNumeric5.Minimum = ((long)(0));
            this.gunaNumeric5.Name = "gunaNumeric5";
            this.gunaNumeric5.Radius = 9;
            this.gunaNumeric5.Size = new System.Drawing.Size(179, 30);
            this.gunaNumeric5.TabIndex = 64;
            this.gunaNumeric5.Text = "gunaNumeric5";
            this.gunaNumeric5.Value = ((long)(0));
            // 
            // ComboBoxSeller
            // 
            this.ComboBoxSeller.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSeller.BaseColor = System.Drawing.Color.White;
            this.ComboBoxSeller.BorderColor = System.Drawing.Color.Silver;
            this.ComboBoxSeller.BorderSize = 1;
            this.ComboBoxSeller.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSeller.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxSeller.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxSeller.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxSeller.FormattingEnabled = true;
            this.ComboBoxSeller.Items.AddRange(new object[] {
            "",
            "Агенство",
            "Собственник"});
            this.ComboBoxSeller.Location = new System.Drawing.Point(5, 265);
            this.ComboBoxSeller.Name = "ComboBoxSeller";
            this.ComboBoxSeller.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.ComboBoxSeller.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxSeller.Radius = 10;
            this.ComboBoxSeller.Size = new System.Drawing.Size(179, 26);
            this.ComboBoxSeller.TabIndex = 63;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(65, 246);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel8.TabIndex = 28;
            this.gunaLabel8.Text = "Продавец";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(11, 209);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(24, 15);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "ДО";
            // 
            // gunaNumeric3
            // 
            this.gunaNumeric3.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric3.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric3.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric3.ButtonColor = System.Drawing.Color.Black;
            this.gunaNumeric3.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric3.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric3.Location = new System.Drawing.Point(39, 202);
            this.gunaNumeric3.Maximum = ((long)(10));
            this.gunaNumeric3.Minimum = ((long)(0));
            this.gunaNumeric3.Name = "gunaNumeric3";
            this.gunaNumeric3.Radius = 9;
            this.gunaNumeric3.Size = new System.Drawing.Size(140, 30);
            this.gunaNumeric3.TabIndex = 26;
            this.gunaNumeric3.Text = "gunaNumeric3";
            this.gunaNumeric3.Value = ((long)(0));
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(11, 173);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(22, 15);
            this.gunaLabel6.TabIndex = 25;
            this.gunaLabel6.Text = "ОТ";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(51, 147);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(89, 15);
            this.gunaLabel7.TabIndex = 24;
            this.gunaLabel7.Text = "Кол-во комнат";
            // 
            // gunaNumeric4
            // 
            this.gunaNumeric4.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric4.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric4.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric4.ButtonColor = System.Drawing.Color.Black;
            this.gunaNumeric4.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric4.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric4.Location = new System.Drawing.Point(39, 166);
            this.gunaNumeric4.Maximum = ((long)(10));
            this.gunaNumeric4.Minimum = ((long)(0));
            this.gunaNumeric4.Name = "gunaNumeric4";
            this.gunaNumeric4.Radius = 9;
            this.gunaNumeric4.Size = new System.Drawing.Size(140, 30);
            this.gunaNumeric4.TabIndex = 23;
            this.gunaNumeric4.Text = "gunaNumeric4";
            this.gunaNumeric4.Value = ((long)(0));
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(11, 111);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(24, 15);
            this.gunaLabel4.TabIndex = 22;
            this.gunaLabel4.Text = "ДО";
            // 
            // gunaNumeric2
            // 
            this.gunaNumeric2.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric2.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric2.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric2.ButtonColor = System.Drawing.Color.Black;
            this.gunaNumeric2.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric2.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric2.Location = new System.Drawing.Point(39, 104);
            this.gunaNumeric2.Maximum = ((long)(9999999));
            this.gunaNumeric2.Minimum = ((long)(0));
            this.gunaNumeric2.Name = "gunaNumeric2";
            this.gunaNumeric2.Radius = 9;
            this.gunaNumeric2.Size = new System.Drawing.Size(140, 30);
            this.gunaNumeric2.TabIndex = 21;
            this.gunaNumeric2.Text = "gunaNumeric2";
            this.gunaNumeric2.Value = ((long)(0));
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(11, 75);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(22, 15);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "ОТ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(78, 49);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Цена";
            // 
            // gunaNumeric1
            // 
            this.gunaNumeric1.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric1.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric1.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric1.ButtonColor = System.Drawing.Color.Black;
            this.gunaNumeric1.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric1.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric1.Location = new System.Drawing.Point(39, 68);
            this.gunaNumeric1.Maximum = ((long)(9999999));
            this.gunaNumeric1.Minimum = ((long)(0));
            this.gunaNumeric1.Name = "gunaNumeric1";
            this.gunaNumeric1.Radius = 9;
            this.gunaNumeric1.Size = new System.Drawing.Size(140, 30);
            this.gunaNumeric1.TabIndex = 18;
            this.gunaNumeric1.Text = "gunaNumeric1";
            this.gunaNumeric1.Value = ((long)(0));
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.Black;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(5, 433);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 12;
            this.gunaButton5.Size = new System.Drawing.Size(29, 30);
            this.gunaButton5.TabIndex = 17;
            this.gunaButton5.Text = "?";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.Black;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(38, 433);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 12;
            this.gunaButton4.Size = new System.Drawing.Size(113, 30);
            this.gunaButton4.TabIndex = 16;
            this.gunaButton4.Text = "Найти";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.Black;
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(44, -30);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 12;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(103, 60);
            this.gunaElipsePanel2.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Сортировка";
            // 
            // btnEXIT
            // 
            this.btnEXIT.AnimationHoverSpeed = 0.07F;
            this.btnEXIT.AnimationSpeed = 0.03F;
            this.btnEXIT.BackColor = System.Drawing.Color.Transparent;
            this.btnEXIT.BaseColor = System.Drawing.Color.Black;
            this.btnEXIT.BorderColor = System.Drawing.Color.Black;
            this.btnEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXIT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEXIT.FocusedColor = System.Drawing.Color.Empty;
            this.btnEXIT.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnEXIT.ForeColor = System.Drawing.Color.White;
            this.btnEXIT.Image = null;
            this.btnEXIT.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEXIT.Location = new System.Drawing.Point(7, 546);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEXIT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEXIT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEXIT.OnHoverImage = null;
            this.btnEXIT.OnPressedColor = System.Drawing.Color.Black;
            this.btnEXIT.Radius = 13;
            this.btnEXIT.Size = new System.Drawing.Size(50, 35);
            this.btnEXIT.TabIndex = 12;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnUP
            // 
            this.btnUP.AnimationHoverSpeed = 0.07F;
            this.btnUP.AnimationSpeed = 0.03F;
            this.btnUP.BackColor = System.Drawing.Color.Transparent;
            this.btnUP.BaseColor = System.Drawing.Color.Black;
            this.btnUP.BorderColor = System.Drawing.Color.Black;
            this.btnUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUP.FocusedColor = System.Drawing.Color.Empty;
            this.btnUP.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnUP.ForeColor = System.Drawing.Color.White;
            this.btnUP.Image = null;
            this.btnUP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUP.Location = new System.Drawing.Point(125, 546);
            this.btnUP.Name = "btnUP";
            this.btnUP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUP.OnHoverImage = null;
            this.btnUP.OnPressedColor = System.Drawing.Color.Black;
            this.btnUP.Radius = 13;
            this.btnUP.Size = new System.Drawing.Size(61, 35);
            this.btnUP.TabIndex = 13;
            this.btnUP.Text = "SIGN UP";
            this.btnUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // btnIN
            // 
            this.btnIN.AnimationHoverSpeed = 0.07F;
            this.btnIN.AnimationSpeed = 0.03F;
            this.btnIN.BackColor = System.Drawing.Color.Transparent;
            this.btnIN.BaseColor = System.Drawing.Color.Black;
            this.btnIN.BorderColor = System.Drawing.Color.Black;
            this.btnIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIN.FocusedColor = System.Drawing.Color.Empty;
            this.btnIN.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnIN.ForeColor = System.Drawing.Color.White;
            this.btnIN.Image = null;
            this.btnIN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIN.Location = new System.Drawing.Point(60, 546);
            this.btnIN.Name = "btnIN";
            this.btnIN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIN.OnHoverImage = null;
            this.btnIN.OnPressedColor = System.Drawing.Color.Black;
            this.btnIN.Radius = 13;
            this.btnIN.Size = new System.Drawing.Size(62, 35);
            this.btnIN.TabIndex = 14;
            this.btnIN.Text = "SIGN IN";
            this.btnIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.tableLayoutPanel1);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPanel.Location = new System.Drawing.Point(192, 55);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(844, 532);
            this.InfoPanel.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 587);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel InfoPanel;
        private Guna.UI.WinForms.GunaButton btnEXIT;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaShadowPanel TopPanel;
        public Guna.UI.WinForms.GunaPictureBox btnBack;
        public Guna.UI.WinForms.GunaPanel SearchPanel;
        private Guna.UI.WinForms.GunaPictureBox btnSearch;
        private Guna.UI.WinForms.GunaTextBox TextBoxSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric4;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric1;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric5;
        private Guna.UI.WinForms.GunaComboBox ComboBoxSeller;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Guna.UI.WinForms.GunaLabel UserName;
        public Guna.UI.WinForms.GunaButton btnIN;
        public Guna.UI.WinForms.GunaButton btnUP;
        public Guna.UI.WinForms.GunaButton btnUser;
        public Guna.UI.WinForms.GunaButton btnALL;
        public Guna.UI.WinForms.GunaButton btnAdmPanel;
        public Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}