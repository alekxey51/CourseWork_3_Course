namespace TrpoFilmApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxUser = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxPass = new Guna.UI.WinForms.GunaTextBox();
            this.btnSignIN = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.LabelCreate = new Guna.UI.WinForms.GunaLabel();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.LabelReestablish = new Guna.UI.WinForms.GunaLabel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelMessenge = new System.Windows.Forms.Label();
            this.gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.gunaLabel1.Location = new System.Drawing.Point(127, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(88, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Hello!";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(108, 89);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(130, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Sign in to your account";
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
            this.TextBoxUser.Location = new System.Drawing.Point(31, 149);
            this.TextBoxUser.MaxLength = 30;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordChar = '\0';
            this.TextBoxUser.Radius = 13;
            this.TextBoxUser.Size = new System.Drawing.Size(275, 39);
            this.TextBoxUser.TabIndex = 2;
            this.TextBoxUser.Text = "Username";
            this.TextBoxUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.TextBoxUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
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
            this.TextBoxPass.Location = new System.Drawing.Point(31, 199);
            this.TextBoxPass.MaxLength = 30;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '•';
            this.TextBoxPass.Radius = 13;
            this.TextBoxPass.Size = new System.Drawing.Size(275, 39);
            this.TextBoxPass.TabIndex = 3;
            this.TextBoxPass.Text = "Password";
            this.TextBoxPass.Enter += new System.EventHandler(this.TextBoxPass_Enter);
            this.TextBoxPass.Leave += new System.EventHandler(this.TextBoxPass_Leave);
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
            this.btnSignIN.Location = new System.Drawing.Point(73, 299);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnSignIN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIN.OnHoverImage = null;
            this.btnSignIN.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIN.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIN.Radius = 15;
            this.btnSignIN.Size = new System.Drawing.Size(186, 37);
            this.btnSignIN.TabIndex = 4;
            this.btnSignIN.Text = "SING IN";
            this.btnSignIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel5.Location = new System.Drawing.Point(88, 347);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(121, 13);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Don\'t have an accunt?";
            // 
            // LabelCreate
            // 
            this.LabelCreate.AutoSize = true;
            this.LabelCreate.BackColor = System.Drawing.Color.White;
            this.LabelCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCreate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LabelCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LabelCreate.Location = new System.Drawing.Point(207, 347);
            this.LabelCreate.Name = "LabelCreate";
            this.LabelCreate.Size = new System.Drawing.Size(40, 13);
            this.LabelCreate.TabIndex = 9;
            this.LabelCreate.Text = "Create";
            this.LabelCreate.Click += new System.EventHandler(this.LabelCreate_Click);
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
            this.btnClose.Location = new System.Drawing.Point(299, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LabelReestablish
            // 
            this.LabelReestablish.AutoSize = true;
            this.LabelReestablish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelReestablish.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.LabelReestablish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LabelReestablish.Location = new System.Drawing.Point(205, 249);
            this.LabelReestablish.Name = "LabelReestablish";
            this.LabelReestablish.Size = new System.Drawing.Size(101, 12);
            this.LabelReestablish.TabIndex = 5;
            this.LabelReestablish.Text = "Reestablish password?";
            this.LabelReestablish.Click += new System.EventHandler(this.LabelReestablish_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelMessenge);
            this.panelInfo.Controls.Add(this.gunaPictureBox);
            this.panelInfo.Location = new System.Drawing.Point(31, 243);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(168, 23);
            this.panelInfo.TabIndex = 11;
            this.panelInfo.Visible = false;
            // 
            // labelMessenge
            // 
            this.labelMessenge.AutoSize = true;
            this.labelMessenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessenge.Location = new System.Drawing.Point(22, 5);
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
            // SIGNin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 419);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LabelCreate);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.LabelReestablish);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SIGNin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel LabelCreate;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignIN;
        private Guna.UI.WinForms.GunaTextBox TextBoxPass;
        private Guna.UI.WinForms.GunaTextBox TextBoxUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaLabel LabelReestablish;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelMessenge;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox;
    }
}

