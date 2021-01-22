namespace TheProperty
{
    partial class ElProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElProperty));
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.IDLabel = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(159, 109);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 2;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 113);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 12);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "2к   52.7 / 30.4 м";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(127, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(30, 12);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "9 / 12";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(3, 125);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 12);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Леси Украинки, 4к1";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IDLabel.Location = new System.Drawing.Point(40, 65);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(15, 12);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "ID";
            // 
            // ElProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.IDLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ElProperty";
            this.Size = new System.Drawing.Size(159, 142);
            this.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaLabel IDLabel;
    }
}
