namespace ElectronicJournal
{
    partial class SignIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIN));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.MenuPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxSurname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxYear = new Guna.UI.WinForms.GunaTextBox();
            this.ComboBoxGroup = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Controls.Add(this.MenuPictureBox);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(346, 34);
            this.gunaPanel1.TabIndex = 0;
            // 
            // MenuPictureBox
            // 
            this.MenuPictureBox.BaseColor = System.Drawing.Color.White;
            this.MenuPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MenuPictureBox.Image")));
            this.MenuPictureBox.Location = new System.Drawing.Point(314, 7);
            this.MenuPictureBox.Name = "MenuPictureBox";
            this.MenuPictureBox.Size = new System.Drawing.Size(21, 21);
            this.MenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPictureBox.TabIndex = 1;
            this.MenuPictureBox.TabStop = false;
            this.MenuPictureBox.Click += new System.EventHandler(this.MenuPictureBox_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(146, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Электронный журнал";
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSurname.BaseColor = System.Drawing.Color.White;
            this.TextBoxSurname.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxSurname.BorderSize = 1;
            this.TextBoxSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSurname.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxSurname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxSurname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxSurname.Location = new System.Drawing.Point(58, 106);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.PasswordChar = '\0';
            this.TextBoxSurname.Radius = 6;
            this.TextBoxSurname.Size = new System.Drawing.Size(232, 30);
            this.TextBoxSurname.TabIndex = 1;
            this.TextBoxSurname.Text = "Фамилия";
            this.TextBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSurname.TextChanged += new System.EventHandler(this.TextBoxSurname_TextChanged);
            this.TextBoxSurname.Enter += new System.EventHandler(this.TextBoxSurname_Enter);
            this.TextBoxSurname.Leave += new System.EventHandler(this.TextBoxSurname_Leave);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Controls.Add(this.gunaPanel1);
            this.gunaPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(346, 66);
            this.gunaPanel2.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaLabel2.Location = new System.Drawing.Point(12, 35);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(334, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Вход для преподавателей";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxYear.BaseColor = System.Drawing.Color.White;
            this.TextBoxYear.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxYear.BorderSize = 1;
            this.TextBoxYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxYear.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxYear.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxYear.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxYear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxYear.Location = new System.Drawing.Point(58, 174);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.PasswordChar = '\0';
            this.TextBoxYear.Radius = 6;
            this.TextBoxYear.Size = new System.Drawing.Size(232, 30);
            this.TextBoxYear.TabIndex = 3;
            this.TextBoxYear.Text = "Дата рождения (01.02.1993)";
            this.TextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxYear.Enter += new System.EventHandler(this.TextBoxYear_Enter);
            this.TextBoxYear.Leave += new System.EventHandler(this.TextBoxYear_Leave);
            // 
            // ComboBoxGroup
            // 
            this.ComboBoxGroup.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxGroup.BaseColor = System.Drawing.Color.White;
            this.ComboBoxGroup.BorderColor = System.Drawing.Color.Silver;
            this.ComboBoxGroup.BorderSize = 1;
            this.ComboBoxGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGroup.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.Location = new System.Drawing.Point(58, 142);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxGroup.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxGroup.Radius = 6;
            this.ComboBoxGroup.Size = new System.Drawing.Size(232, 26);
            this.ComboBoxGroup.TabIndex = 4;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(58, 210);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 6;
            this.gunaButton1.Size = new System.Drawing.Size(232, 36);
            this.gunaButton1.TabIndex = 5;
            this.gunaButton1.Text = "Войти";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.Gainsboro;
            this.gunaPictureBox2.Location = new System.Drawing.Point(41, 85);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(265, 183);
            this.gunaPictureBox2.TabIndex = 6;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(310, 252);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // SignIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 287);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.ComboBoxGroup);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPanel2);
            this.Name = "SignIN";
            this.Text = "Электронный журнал";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox MenuPictureBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox TextBoxSurname;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox TextBoxYear;
        private Guna.UI.WinForms.GunaComboBox ComboBoxGroup;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}

