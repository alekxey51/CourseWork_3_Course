namespace TrpoFilmApp
{
    partial class FilmEl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmEl));
            this.PictureBoxFilm = new Guna.UI.WinForms.GunaPictureBox();
            this.NaneLableFilm = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PictureBoxSoonFilm = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoonFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxFilm
            // 
            this.PictureBoxFilm.BaseColor = System.Drawing.Color.White;
            this.PictureBoxFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxFilm.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFilm.Image")));
            this.PictureBoxFilm.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxFilm.Name = "PictureBoxFilm";
            this.PictureBoxFilm.Size = new System.Drawing.Size(117, 155);
            this.PictureBoxFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxFilm.TabIndex = 0;
            this.PictureBoxFilm.TabStop = false;
            this.PictureBoxFilm.Visible = false;
            this.PictureBoxFilm.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // NaneLableFilm
            // 
            this.NaneLableFilm.AutoSize = true;
            this.NaneLableFilm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NaneLableFilm.Location = new System.Drawing.Point(16, 140);
            this.NaneLableFilm.Name = "NaneLableFilm";
            this.NaneLableFilm.Size = new System.Drawing.Size(86, 15);
            this.NaneLableFilm.TabIndex = 1;
            this.NaneLableFilm.Text = "NaneLableFilm";
            this.NaneLableFilm.Visible = false;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(-2, 100);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(119, 37);
            this.gunaAdvenceButton1.TabIndex = 2;
            this.gunaAdvenceButton1.Text = "Не доступно";
            this.gunaAdvenceButton1.Visible = false;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // PictureBoxSoonFilm
            // 
            this.PictureBoxSoonFilm.BaseColor = System.Drawing.Color.White;
            this.PictureBoxSoonFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSoonFilm.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSoonFilm.Image")));
            this.PictureBoxSoonFilm.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxSoonFilm.Name = "PictureBoxSoonFilm";
            this.PictureBoxSoonFilm.Size = new System.Drawing.Size(117, 155);
            this.PictureBoxSoonFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSoonFilm.TabIndex = 4;
            this.PictureBoxSoonFilm.TabStop = false;
            this.PictureBoxSoonFilm.Visible = false;
            this.PictureBoxSoonFilm.Click += new System.EventHandler(this.PictureBoxSoonFilm_Click);
            // 
            // FilmEl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NaneLableFilm);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.PictureBoxSoonFilm);
            this.Controls.Add(this.PictureBoxFilm);
            this.Name = "FilmEl";
            this.Size = new System.Drawing.Size(117, 155);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoonFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaPictureBox PictureBoxFilm;
        public Guna.UI.WinForms.GunaLabel NaneLableFilm;
        public Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        public Guna.UI.WinForms.GunaPictureBox PictureBoxSoonFilm;
    }
}
