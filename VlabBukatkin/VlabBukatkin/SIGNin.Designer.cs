namespace VlabBukatkin
{
    partial class SIGNin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNin));
            this.SIGNup = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnSignIN = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxPass = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxUser = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // SIGNup
            // 
            this.SIGNup.AutoSize = true;
            this.SIGNup.BackColor = System.Drawing.SystemColors.Control;
            this.SIGNup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SIGNup.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.SIGNup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.SIGNup.Location = new System.Drawing.Point(159, 225);
            this.SIGNup.Name = "SIGNup";
            this.SIGNup.Size = new System.Drawing.Size(40, 13);
            this.SIGNup.TabIndex = 19;
            this.SIGNup.Text = "Create";
            this.SIGNup.Click += new System.EventHandler(this.SIGNup_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel5.Location = new System.Drawing.Point(67, 225);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(93, 13);
            this.gunaLabel5.TabIndex = 18;
            this.gunaLabel5.Text = "Создать аккаунт";
            // 
            // btnSignIN
            // 
            this.btnSignIN.AnimationHoverSpeed = 0.07F;
            this.btnSignIN.AnimationSpeed = 0.03F;
            this.btnSignIN.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignIN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignIN.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSignIN.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignIN.CheckedForeColor = System.Drawing.Color.White;
            this.btnSignIN.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignIN.CheckedImage")));
            this.btnSignIN.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIN.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIN.ForeColor = System.Drawing.Color.White;
            this.btnSignIN.Image = null;
            this.btnSignIN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignIN.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIN.Location = new System.Drawing.Point(54, 181);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSignIN.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignIN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIN.OnHoverImage = null;
            this.btnSignIN.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIN.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSignIN.Radius = 15;
            this.btnSignIN.Size = new System.Drawing.Size(160, 37);
            this.btnSignIN.TabIndex = 16;
            this.btnSignIN.Text = "Войти";
            this.btnSignIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPass.BaseColor = System.Drawing.Color.White;
            this.TextBoxPass.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPass.BorderSize = 1;
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPass.Location = new System.Drawing.Point(21, 127);
            this.TextBoxPass.MaxLength = 30;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '•';
            this.TextBoxPass.Radius = 13;
            this.TextBoxPass.Size = new System.Drawing.Size(230, 39);
            this.TextBoxPass.TabIndex = 15;
            this.TextBoxPass.Text = "Password";
            this.TextBoxPass.Enter += new System.EventHandler(this.TextBoxPass_Enter);
            this.TextBoxPass.Leave += new System.EventHandler(this.TextBoxPass_Leave);
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
            this.TextBoxUser.Location = new System.Drawing.Point(21, 80);
            this.TextBoxUser.MaxLength = 30;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordChar = '\0';
            this.TextBoxUser.Radius = 13;
            this.TextBoxUser.Size = new System.Drawing.Size(230, 39);
            this.TextBoxUser.TabIndex = 14;
            this.TextBoxUser.Text = "Username";
            this.TextBoxUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.TextBoxUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(58, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(158, 32);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "Авторизация";
            // 
            // SIGNin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(274, 269);
            this.Controls.Add(this.SIGNup);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "SIGNin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel SIGNup;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignIN;
        private Guna.UI.WinForms.GunaTextBox TextBoxPass;
        private Guna.UI.WinForms.GunaTextBox TextBoxUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

