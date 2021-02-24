namespace VladCourse
{
    partial class AddDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoctor));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxPosition = new Guna.UI.WinForms.GunaTextBox();
            this.btnBrowse = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PictureBox = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(126, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 15);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Должность";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Location = new System.Drawing.Point(219, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(132, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TextBoxPosition
            // 
            this.TextBoxPosition.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPosition.BaseColor = System.Drawing.Color.White;
            this.TextBoxPosition.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPosition.BorderSize = 1;
            this.TextBoxPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPosition.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPosition.FocusedBorderColor = System.Drawing.Color.Green;
            this.TextBoxPosition.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPosition.Location = new System.Drawing.Point(129, 41);
            this.TextBoxPosition.Name = "TextBoxPosition";
            this.TextBoxPosition.PasswordChar = '\0';
            this.TextBoxPosition.Radius = 10;
            this.TextBoxPosition.Size = new System.Drawing.Size(222, 30);
            this.TextBoxPosition.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationHoverSpeed = 0.07F;
            this.btnBrowse.AnimationSpeed = 0.03F;
            this.btnBrowse.BaseColor = System.Drawing.Color.ForestGreen;
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedForeColor = System.Drawing.Color.White;
            this.btnBrowse.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.CheckedImage")));
            this.btnBrowse.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowse.LineColor = System.Drawing.Color.ForestGreen;
            this.btnBrowse.Location = new System.Drawing.Point(129, 84);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.btnBrowse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnHoverImage = null;
            this.btnBrowse.OnHoverLineColor = System.Drawing.Color.ForestGreen;
            this.btnBrowse.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowse.Size = new System.Drawing.Size(84, 33);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Поиск";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictureBox.BaseColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(103, 112);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(368, 137);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.TextBoxPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить доктора";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btnBrowse;
        private Guna.UI.WinForms.GunaPictureBox PictureBox;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Guna.UI.WinForms.GunaTextBox TextBoxPosition;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}