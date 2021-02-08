namespace VlabBukatkin
{
    partial class SIGNup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNup));
            this.TextBoxPassword = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxUsername = new Guna.UI.WinForms.GunaTextBox();
            this.LabelSignIN = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnSignUP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxSurname = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
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
            this.TextBoxPassword.Location = new System.Drawing.Point(22, 214);
            this.TextBoxPassword.MaxLength = 30;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '•';
            this.TextBoxPassword.Radius = 13;
            this.TextBoxPassword.Size = new System.Drawing.Size(230, 39);
            this.TextBoxPassword.TabIndex = 26;
            this.TextBoxPassword.Text = "Password";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUsername.BaseColor = System.Drawing.Color.White;
            this.TextBoxUsername.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxUsername.BorderSize = 1;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUsername.Location = new System.Drawing.Point(22, 168);
            this.TextBoxUsername.MaxLength = 30;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.Radius = 13;
            this.TextBoxUsername.Size = new System.Drawing.Size(230, 39);
            this.TextBoxUsername.TabIndex = 25;
            this.TextBoxUsername.Text = "Username";
            this.TextBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.TextBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // LabelSignIN
            // 
            this.LabelSignIN.AutoSize = true;
            this.LabelSignIN.BackColor = System.Drawing.SystemColors.Control;
            this.LabelSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSignIN.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LabelSignIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.LabelSignIN.Location = new System.Drawing.Point(162, 312);
            this.LabelSignIN.Name = "LabelSignIN";
            this.LabelSignIN.Size = new System.Drawing.Size(43, 13);
            this.LabelSignIN.TabIndex = 29;
            this.LabelSignIN.Text = "Sign in";
            this.LabelSignIN.Click += new System.EventHandler(this.LabelSignIN_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel5.Location = new System.Drawing.Point(66, 312);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(97, 13);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "Уже есть аккаунт";
            // 
            // btnSignUP
            // 
            this.btnSignUP.AnimationHoverSpeed = 0.07F;
            this.btnSignUP.AnimationSpeed = 0.03F;
            this.btnSignUP.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignUP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignUP.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSignUP.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignUP.CheckedForeColor = System.Drawing.Color.White;
            this.btnSignUP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignUP.CheckedImage")));
            this.btnSignUP.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUP.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUP.ForeColor = System.Drawing.Color.White;
            this.btnSignUP.Image = null;
            this.btnSignUP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignUP.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUP.Location = new System.Drawing.Point(57, 269);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSignUP.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignUP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignUP.OnHoverImage = null;
            this.btnSignUP.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSignUP.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignUP.Radius = 15;
            this.btnSignUP.Size = new System.Drawing.Size(160, 37);
            this.btnSignUP.TabIndex = 28;
            this.btnSignUP.Text = "Зарегистрироваться";
            this.btnSignUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSurname.BaseColor = System.Drawing.Color.White;
            this.TextBoxSurname.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxSurname.BorderSize = 1;
            this.TextBoxSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSurname.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxSurname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxSurname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxSurname.Location = new System.Drawing.Point(22, 121);
            this.TextBoxSurname.MaxLength = 30;
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.PasswordChar = '\0';
            this.TextBoxSurname.Radius = 13;
            this.TextBoxSurname.Size = new System.Drawing.Size(230, 39);
            this.TextBoxSurname.TabIndex = 24;
            this.TextBoxSurname.Text = "Surname";
            this.TextBoxSurname.Enter += new System.EventHandler(this.TextBoxSurname_Enter);
            this.TextBoxSurname.Leave += new System.EventHandler(this.TextBoxSurname_Leave);
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxName.BaseColor = System.Drawing.Color.White;
            this.TextBoxName.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxName.BorderSize = 1;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxName.Location = new System.Drawing.Point(22, 75);
            this.TextBoxName.MaxLength = 30;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.Radius = 13;
            this.TextBoxName.Size = new System.Drawing.Size(230, 39);
            this.TextBoxName.TabIndex = 23;
            this.TextBoxName.Text = "Name";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(58, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(151, 32);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Регистрация";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SIGNup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(274, 351);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelSignIN);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btnSignUP);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "SIGNup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGNup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox TextBoxPassword;
        private Guna.UI.WinForms.GunaTextBox TextBoxUsername;
        private Guna.UI.WinForms.GunaLabel LabelSignIN;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignUP;
        private Guna.UI.WinForms.GunaTextBox TextBoxSurname;
        private Guna.UI.WinForms.GunaTextBox TextBoxName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}