namespace TrpoFilmApp
{
    partial class ListFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListFS));
            this.PictureBox = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnDeleteFilm = new Guna.UI.WinForms.GunaPictureBox();
            this.pLine = new Guna.UI.WinForms.GunaSeparator();
            this.Data = new Guna.UI.WinForms.GunaLabel();
            this.btnDeleteSoonFilm = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSoonFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BaseColor = System.Drawing.Color.White;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(3, 1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(35, 34);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.UseTransfarantBackground = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel1.Location = new System.Drawing.Point(42, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(36, 13);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Name";
            // 
            // btnDeleteFilm
            // 
            this.btnDeleteFilm.BaseColor = System.Drawing.Color.White;
            this.btnDeleteFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFilm.Image")));
            this.btnDeleteFilm.Location = new System.Drawing.Point(277, 12);
            this.btnDeleteFilm.Name = "btnDeleteFilm";
            this.btnDeleteFilm.Size = new System.Drawing.Size(15, 15);
            this.btnDeleteFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteFilm.TabIndex = 2;
            this.btnDeleteFilm.TabStop = false;
            this.btnDeleteFilm.Visible = false;
            this.btnDeleteFilm.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // pLine
            // 
            this.pLine.LineColor = System.Drawing.Color.Silver;
            this.pLine.Location = new System.Drawing.Point(0, 35);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(300, 10);
            this.pLine.TabIndex = 3;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Data.Location = new System.Drawing.Point(195, 12);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(31, 13);
            this.Data.TabIndex = 4;
            this.Data.Text = "Data";
            this.Data.Visible = false;
            // 
            // btnDeleteSoonFilm
            // 
            this.btnDeleteSoonFilm.BaseColor = System.Drawing.Color.White;
            this.btnDeleteSoonFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSoonFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSoonFilm.Image")));
            this.btnDeleteSoonFilm.Location = new System.Drawing.Point(277, 12);
            this.btnDeleteSoonFilm.Name = "btnDeleteSoonFilm";
            this.btnDeleteSoonFilm.Size = new System.Drawing.Size(15, 15);
            this.btnDeleteSoonFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteSoonFilm.TabIndex = 5;
            this.btnDeleteSoonFilm.TabStop = false;
            this.btnDeleteSoonFilm.Visible = false;
            this.btnDeleteSoonFilm.Click += new System.EventHandler(this.btnDeleteSoonFilm_Click);
            // 
            // ListFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteSoonFilm);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.pLine);
            this.Controls.Add(this.btnDeleteFilm);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.PictureBox);
            this.Name = "ListFS";
            this.Size = new System.Drawing.Size(300, 41);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSoonFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI.WinForms.GunaCirclePictureBox PictureBox;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaPictureBox btnDeleteFilm;
        public Guna.UI.WinForms.GunaSeparator pLine;
        public Guna.UI.WinForms.GunaLabel Data;
        public Guna.UI.WinForms.GunaPictureBox btnDeleteSoonFilm;
    }
}
