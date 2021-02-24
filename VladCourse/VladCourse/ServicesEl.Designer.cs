namespace VladCourse
{
    partial class ServicesEl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesEl));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnDelete1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDelete3 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDelete2 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(37, 6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(130, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Наименование услуги";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(524, 6);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Стоимость руб.";
            // 
            // btnDelete1
            // 
            this.btnDelete1.BaseColor = System.Drawing.Color.White;
            this.btnDelete1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete1.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete1.Image")));
            this.btnDelete1.Location = new System.Drawing.Point(360, 6);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(15, 15);
            this.btnDelete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete1.TabIndex = 3;
            this.btnDelete1.TabStop = false;
            this.btnDelete1.Visible = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelete3
            // 
            this.btnDelete3.BaseColor = System.Drawing.Color.White;
            this.btnDelete3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete3.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete3.Image")));
            this.btnDelete3.Location = new System.Drawing.Point(318, 6);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(15, 15);
            this.btnDelete3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete3.TabIndex = 4;
            this.btnDelete3.TabStop = false;
            this.btnDelete3.Visible = false;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BaseColor = System.Drawing.Color.White;
            this.btnDelete2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete2.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete2.Image")));
            this.btnDelete2.Location = new System.Drawing.Point(339, 6);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(15, 15);
            this.btnDelete2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete2.TabIndex = 5;
            this.btnDelete2.TabStop = false;
            this.btnDelete2.Visible = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // ServicesEl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnDelete3);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "ServicesEl";
            this.Size = new System.Drawing.Size(651, 30);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaPictureBox btnDelete1;
        public Guna.UI.WinForms.GunaPictureBox btnDelete3;
        public Guna.UI.WinForms.GunaPictureBox btnDelete2;
    }
}
