namespace TheProperty
{
    partial class SIGN_IN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGN_IN));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.Messenge = new System.Windows.Forms.Label();
            this.gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSignIN = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxPassword = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxUser = new Guna.UI.WinForms.GunaTextBox();
            this.Label = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.Messenge);
            this.ErrorPanel.Controls.Add(this.gunaPictureBox);
            this.ErrorPanel.Location = new System.Drawing.Point(12, 165);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(208, 19);
            this.ErrorPanel.TabIndex = 37;
            this.ErrorPanel.Visible = false;
            // 
            // Messenge
            // 
            this.Messenge.Dock = System.Windows.Forms.DockStyle.Right;
            this.Messenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Messenge.Location = new System.Drawing.Point(25, 0);
            this.Messenge.Name = "Messenge";
            this.Messenge.Size = new System.Drawing.Size(183, 19);
            this.Messenge.TabIndex = 1;
            this.Messenge.Text = "Messeng";
            this.Messenge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPictureBox
            // 
            this.gunaPictureBox.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox.Image")));
            this.gunaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox.Name = "gunaPictureBox";
            this.gunaPictureBox.Size = new System.Drawing.Size(19, 19);
            this.gunaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox.TabIndex = 0;
            this.gunaPictureBox.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.CheckedBaseColor = System.Drawing.Color.White;
            this.btnClose.CheckedBorderColor = System.Drawing.Color.White;
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnClose.CheckedImage")));
            this.btnClose.CheckedLineColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.LineColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(193, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 36;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSignIN
            // 
            this.btnSignIN.AnimationHoverSpeed = 0.07F;
            this.btnSignIN.AnimationSpeed = 0.03F;
            this.btnSignIN.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIN.BaseColor = System.Drawing.Color.Black;
            this.btnSignIN.BorderColor = System.Drawing.Color.Black;
            this.btnSignIN.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSignIN.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignIN.CheckedForeColor = System.Drawing.Color.White;
            this.btnSignIN.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignIN.CheckedImage")));
            this.btnSignIN.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIN.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIN.ForeColor = System.Drawing.Color.White;
            this.btnSignIN.Image = null;
            this.btnSignIN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignIN.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIN.Location = new System.Drawing.Point(50, 215);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnSignIN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIN.OnHoverImage = null;
            this.btnSignIN.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIN.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIN.Radius = 15;
            this.btnSignIN.Size = new System.Drawing.Size(131, 30);
            this.btnSignIN.TabIndex = 33;
            this.btnSignIN.Text = "SING IN";
            this.btnSignIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPassword.BaseColor = System.Drawing.Color.White;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPassword.BorderSize = 1;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPassword.Location = new System.Drawing.Point(12, 122);
            this.TextBoxPassword.MaxLength = 30;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '•';
            this.TextBoxPassword.Radius = 13;
            this.TextBoxPassword.Size = new System.Drawing.Size(208, 35);
            this.TextBoxPassword.TabIndex = 32;
            this.TextBoxPassword.Text = "Password";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUser.BaseColor = System.Drawing.Color.White;
            this.TextBoxUser.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxUser.BorderSize = 1;
            this.TextBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUser.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUser.Location = new System.Drawing.Point(12, 80);
            this.TextBoxUser.MaxLength = 30;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordChar = '\0';
            this.TextBoxUser.Radius = 13;
            this.TextBoxUser.Size = new System.Drawing.Size(208, 35);
            this.TextBoxUser.TabIndex = 31;
            this.TextBoxUser.Text = "Username";
            this.TextBoxUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.TextBoxUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Label.Location = new System.Drawing.Point(89, 32);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(53, 25);
            this.Label.TabIndex = 30;
            this.Label.Text = "Вход";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Controls.Add(this.gunaLabel8);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel1.Location = new System.Drawing.Point(230, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(32, 275);
            this.gunaPanel1.TabIndex = 38;
            this.gunaPanel1.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(5, 188);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(29, 23);
            this.gunaLabel8.TabIndex = 6;
            this.gunaLabel8.Text = "->";
            this.gunaLabel8.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(7, 148);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(17, 23);
            this.gunaLabel7.TabIndex = 5;
            this.gunaLabel7.Text = "U";
            this.gunaLabel7.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(8, 165);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(17, 23);
            this.gunaLabel6.TabIndex = 4;
            this.gunaLabel6.Text = "P";
            this.gunaLabel6.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(8, 117);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(17, 23);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "N";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(7, 98);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(17, 23);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "G";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(9, 81);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(14, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "I";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(8, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(17, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "S";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // SIGN_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 275);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SIGN_IN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGN_IN_UP";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SIGN_IN_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SIGN_IN_MouseMove);
            this.ErrorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox TextBoxPassword;
        private Guna.UI.WinForms.GunaTextBox TextBoxUser;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label Messenge;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignIN;
        private Guna.UI.WinForms.GunaLabel Label;
    }
}