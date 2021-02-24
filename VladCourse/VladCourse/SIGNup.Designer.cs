namespace VladCourse
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelMessenge = new System.Windows.Forms.Label();
            this.gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.TextBoxPassword = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxUsername = new Guna.UI.WinForms.GunaTextBox();
            this.LabelSignIN = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnSignUP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxSurname = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxEmail = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxPhone = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxPass2 = new Guna.UI.WinForms.GunaTextBox();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelMessenge);
            this.panelInfo.Controls.Add(this.gunaPictureBox);
            this.panelInfo.Location = new System.Drawing.Point(12, 305);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(239, 23);
            this.panelInfo.TabIndex = 31;
            this.panelInfo.Visible = false;
            // 
            // labelMessenge
            // 
            this.labelMessenge.AutoSize = true;
            this.labelMessenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessenge.Location = new System.Drawing.Point(22, 4);
            this.labelMessenge.Name = "labelMessenge";
            this.labelMessenge.Size = new System.Drawing.Size(35, 13);
            this.labelMessenge.TabIndex = 1;
            this.labelMessenge.Text = "label1";
            // 
            // gunaPictureBox
            // 
            this.gunaPictureBox.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox.Image")));
            this.gunaPictureBox.Location = new System.Drawing.Point(0, 2);
            this.gunaPictureBox.Name = "gunaPictureBox";
            this.gunaPictureBox.Size = new System.Drawing.Size(19, 19);
            this.gunaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox.TabIndex = 0;
            this.gunaPictureBox.TabStop = false;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPassword.BaseColor = System.Drawing.Color.White;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPassword.BorderSize = 1;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPassword.Location = new System.Drawing.Point(12, 262);
            this.TextBoxPassword.MaxLength = 30;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '•';
            this.TextBoxPassword.Radius = 13;
            this.TextBoxPassword.Size = new System.Drawing.Size(228, 39);
            this.TextBoxPassword.TabIndex = 28;
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
            this.TextBoxUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUsername.Location = new System.Drawing.Point(12, 217);
            this.TextBoxUsername.MaxLength = 30;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.Radius = 13;
            this.TextBoxUsername.Size = new System.Drawing.Size(462, 39);
            this.TextBoxUsername.TabIndex = 27;
            this.TextBoxUsername.Text = "Username";
            this.TextBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.TextBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // LabelSignIN
            // 
            this.LabelSignIN.AutoSize = true;
            this.LabelSignIN.BackColor = System.Drawing.Color.White;
            this.LabelSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSignIN.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LabelSignIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelSignIN.Location = new System.Drawing.Point(263, 389);
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
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel5.Location = new System.Drawing.Point(188, 389);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(77, 13);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "I have accunt!";
            // 
            // btnSignUP
            // 
            this.btnSignUP.AnimationHoverSpeed = 0.07F;
            this.btnSignUP.AnimationSpeed = 0.03F;
            this.btnSignUP.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUP.BaseColor = System.Drawing.Color.ForestGreen;
            this.btnSignUP.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnSignUP.CheckedBaseColor = System.Drawing.Color.ForestGreen;
            this.btnSignUP.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignUP.CheckedForeColor = System.Drawing.Color.White;
            this.btnSignUP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignUP.CheckedImage")));
            this.btnSignUP.CheckedLineColor = System.Drawing.Color.ForestGreen;
            this.btnSignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUP.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUP.ForeColor = System.Drawing.Color.White;
            this.btnSignUP.Image = null;
            this.btnSignUP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignUP.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUP.Location = new System.Drawing.Point(57, 343);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.btnSignUP.OnHoverBorderColor = System.Drawing.Color.LimeGreen;
            this.btnSignUP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignUP.OnHoverImage = null;
            this.btnSignUP.OnHoverLineColor = System.Drawing.Color.ForestGreen;
            this.btnSignUP.OnPressedColor = System.Drawing.Color.LimeGreen;
            this.btnSignUP.Radius = 15;
            this.btnSignUP.Size = new System.Drawing.Size(374, 37);
            this.btnSignUP.TabIndex = 30;
            this.btnSignUP.Text = "SING UP";
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
            this.TextBoxSurname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxSurname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxSurname.Location = new System.Drawing.Point(246, 127);
            this.TextBoxSurname.MaxLength = 30;
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.PasswordChar = '\0';
            this.TextBoxSurname.Radius = 13;
            this.TextBoxSurname.Size = new System.Drawing.Size(228, 39);
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
            this.TextBoxName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxName.Location = new System.Drawing.Point(12, 127);
            this.TextBoxName.MaxLength = 30;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.Radius = 13;
            this.TextBoxName.Size = new System.Drawing.Size(228, 39);
            this.TextBoxName.TabIndex = 23;
            this.TextBoxName.Text = "Name";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel2.Location = new System.Drawing.Point(192, 101);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(114, 15);
            this.gunaLabel2.TabIndex = 22;
            this.gunaLabel2.Text = "Create your account";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaLabel1.Location = new System.Drawing.Point(205, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(88, 37);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Hello!";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.ForestGreen;
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(489, 59);
            this.gunaPanel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxEmail.BaseColor = System.Drawing.Color.White;
            this.TextBoxEmail.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxEmail.BorderSize = 1;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxEmail.Location = new System.Drawing.Point(12, 172);
            this.TextBoxEmail.MaxLength = 30;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.Radius = 13;
            this.TextBoxEmail.Size = new System.Drawing.Size(228, 39);
            this.TextBoxEmail.TabIndex = 25;
            this.TextBoxEmail.Text = "Email";
            this.TextBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.TextBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPhone.BaseColor = System.Drawing.Color.White;
            this.TextBoxPhone.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPhone.BorderSize = 1;
            this.TextBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPhone.Location = new System.Drawing.Point(246, 172);
            this.TextBoxPhone.MaxLength = 30;
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.PasswordChar = '\0';
            this.TextBoxPhone.Radius = 13;
            this.TextBoxPhone.Size = new System.Drawing.Size(228, 39);
            this.TextBoxPhone.TabIndex = 26;
            this.TextBoxPhone.Text = "(375)29-943-28-53";
            this.TextBoxPhone.Enter += new System.EventHandler(this.TextBoxPhone_Enter);
            this.TextBoxPhone.Leave += new System.EventHandler(this.TextBoxPhone_Leave);
            // 
            // TextBoxPass2
            // 
            this.TextBoxPass2.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPass2.BaseColor = System.Drawing.Color.White;
            this.TextBoxPass2.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPass2.BorderSize = 1;
            this.TextBoxPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass2.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPass2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxPass2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPass2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPass2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPass2.Location = new System.Drawing.Point(246, 262);
            this.TextBoxPass2.MaxLength = 30;
            this.TextBoxPass2.Name = "TextBoxPass2";
            this.TextBoxPass2.PasswordChar = '•';
            this.TextBoxPass2.Radius = 13;
            this.TextBoxPass2.Size = new System.Drawing.Size(228, 39);
            this.TextBoxPass2.TabIndex = 29;
            this.TextBoxPass2.Text = "Password";
            this.TextBoxPass2.Enter += new System.EventHandler(this.TextBoxPass2_Enter);
            this.TextBoxPass2.Leave += new System.EventHandler(this.TextBoxPass2_Leave);
            // 
            // SIGNup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 419);
            this.Controls.Add(this.TextBoxPass2);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelSignIN);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btnSignUP);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SIGNup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGNup";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelMessenge;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox;
        private Guna.UI.WinForms.GunaTextBox TextBoxPassword;
        private Guna.UI.WinForms.GunaTextBox TextBoxUsername;
        private Guna.UI.WinForms.GunaLabel LabelSignIN;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignUP;
        private Guna.UI.WinForms.GunaTextBox TextBoxSurname;
        private Guna.UI.WinForms.GunaTextBox TextBoxName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox TextBoxPass2;
        private Guna.UI.WinForms.GunaTextBox TextBoxPhone;
        private Guna.UI.WinForms.GunaTextBox TextBoxEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}