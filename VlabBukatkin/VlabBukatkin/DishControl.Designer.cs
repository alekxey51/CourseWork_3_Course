namespace VlabBukatkin
{
    partial class DishControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishControl));
            this.gunaPictureBox6 = new Guna.UI.WinForms.GunaPictureBox();
            this.NameDish = new Guna.UI.WinForms.GunaLabel();
            this.IDdish = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox6
            // 
            this.gunaPictureBox6.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaPictureBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox6.Image")));
            this.gunaPictureBox6.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox6.Name = "gunaPictureBox6";
            this.gunaPictureBox6.Size = new System.Drawing.Size(144, 105);
            this.gunaPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox6.TabIndex = 5;
            this.gunaPictureBox6.TabStop = false;
            this.gunaPictureBox6.Click += new System.EventHandler(this.gunaPictureBox6_Click);
            // 
            // NameDish
            // 
            this.NameDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameDish.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameDish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameDish.Location = new System.Drawing.Point(0, 105);
            this.NameDish.Name = "NameDish";
            this.NameDish.Size = new System.Drawing.Size(144, 32);
            this.NameDish.TabIndex = 6;
            this.NameDish.Text = "Название";
            this.NameDish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameDish.Click += new System.EventHandler(this.NameDish_Click);
            // 
            // IDdish
            // 
            this.IDdish.AutoSize = true;
            this.IDdish.Location = new System.Drawing.Point(46, 40);
            this.IDdish.Name = "IDdish";
            this.IDdish.Size = new System.Drawing.Size(18, 13);
            this.IDdish.TabIndex = 7;
            this.IDdish.Text = "ID";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(126, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(18, 18);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 8;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Visible = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // DishControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.NameDish);
            this.Controls.Add(this.gunaPictureBox6);
            this.Controls.Add(this.IDdish);
            this.Name = "DishControl";
            this.Size = new System.Drawing.Size(144, 139);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox6;
        public Guna.UI.WinForms.GunaLabel NameDish;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public System.Windows.Forms.Label IDdish;
    }
}
