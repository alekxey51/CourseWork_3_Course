namespace ElectronicJournal
{
    partial class addGroup
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
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.TextBoxGroup = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.Gainsboro;
            this.gunaPictureBox2.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(231, 125);
            this.gunaPictureBox2.TabIndex = 7;
            this.gunaPictureBox2.TabStop = false;
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
            this.gunaButton1.Location = new System.Drawing.Point(28, 84);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 6;
            this.gunaButton1.Size = new System.Drawing.Size(199, 36);
            this.gunaButton1.TabIndex = 9;
            this.gunaButton1.Text = "Добавить";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // TextBoxGroup
            // 
            this.TextBoxGroup.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxGroup.BaseColor = System.Drawing.Color.White;
            this.TextBoxGroup.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxGroup.BorderSize = 1;
            this.TextBoxGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGroup.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxGroup.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxGroup.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxGroup.Location = new System.Drawing.Point(28, 48);
            this.TextBoxGroup.Name = "TextBoxGroup";
            this.TextBoxGroup.PasswordChar = '\0';
            this.TextBoxGroup.Radius = 6;
            this.TextBoxGroup.Size = new System.Drawing.Size(199, 30);
            this.TextBoxGroup.TabIndex = 8;
            this.TextBoxGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(27, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(143, 15);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Название группы (Т-794)";
            // 
            // addGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 149);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.TextBoxGroup);
            this.Controls.Add(this.gunaPictureBox2);
            this.Name = "addGroup";
            this.Text = "Добавить группу";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox TextBoxGroup;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}