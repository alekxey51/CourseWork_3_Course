namespace TrpoFilmApp
{
    partial class AdminControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControl));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnAddFilm = new Guna.UI.WinForms.GunaPictureBox();
            this.CountFilm = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnAddSerial = new Guna.UI.WinForms.GunaPictureBox();
            this.CountSoonFilm = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.CountUsers = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.DataTime = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFilm)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSerial)).BeginInit();
            this.gunaElipsePanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaElipsePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.btnAddFilm);
            this.gunaElipsePanel1.Controls.Add(this.CountFilm);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(8, 8);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(196, 77);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BaseColor = System.Drawing.Color.White;
            this.btnAddFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFilm.Image")));
            this.btnAddFilm.Location = new System.Drawing.Point(170, 51);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(26, 26);
            this.btnAddFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddFilm.TabIndex = 0;
            this.btnAddFilm.TabStop = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click_1);
            // 
            // CountFilm
            // 
            this.CountFilm.BackColor = System.Drawing.Color.White;
            this.CountFilm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountFilm.Location = new System.Drawing.Point(0, 23);
            this.CountFilm.Name = "CountFilm";
            this.CountFilm.Size = new System.Drawing.Size(196, 45);
            this.CountFilm.TabIndex = 2;
            this.CountFilm.Text = "000";
            this.CountFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(0, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(196, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Количество фильмов";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.btnAddSerial);
            this.gunaElipsePanel2.Controls.Add(this.CountSoonFilm);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(210, 8);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(196, 77);
            this.gunaElipsePanel2.TabIndex = 1;
            // 
            // btnAddSerial
            // 
            this.btnAddSerial.BaseColor = System.Drawing.Color.White;
            this.btnAddSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSerial.Image")));
            this.btnAddSerial.Location = new System.Drawing.Point(170, 51);
            this.btnAddSerial.Name = "btnAddSerial";
            this.btnAddSerial.Size = new System.Drawing.Size(26, 26);
            this.btnAddSerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddSerial.TabIndex = 2;
            this.btnAddSerial.TabStop = false;
            this.btnAddSerial.Click += new System.EventHandler(this.btnAddSerial_Click);
            // 
            // CountSoonFilm
            // 
            this.CountSoonFilm.BackColor = System.Drawing.Color.White;
            this.CountSoonFilm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountSoonFilm.Location = new System.Drawing.Point(0, 23);
            this.CountSoonFilm.Name = "CountSoonFilm";
            this.CountSoonFilm.Size = new System.Drawing.Size(196, 45);
            this.CountSoonFilm.TabIndex = 3;
            this.CountSoonFilm.Text = "000";
            this.CountSoonFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(0, 8);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(196, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Скоро в кино";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Controls.Add(this.CountUsers);
            this.gunaElipsePanel3.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(412, 8);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Size = new System.Drawing.Size(196, 77);
            this.gunaElipsePanel3.TabIndex = 1;
            // 
            // CountUsers
            // 
            this.CountUsers.BackColor = System.Drawing.Color.White;
            this.CountUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountUsers.Location = new System.Drawing.Point(0, 23);
            this.CountUsers.Name = "CountUsers";
            this.CountUsers.Size = new System.Drawing.Size(196, 45);
            this.CountUsers.TabIndex = 4;
            this.CountUsers.Text = "000";
            this.CountUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.White;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(0, 8);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(196, 15);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Количество пользователей";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaElipsePanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.gunaElipsePanel3);
            this.panel1.Controls.Add(this.gunaElipsePanel2);
            this.panel1.Controls.Add(this.gunaElipsePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 580);
            this.panel1.TabIndex = 2;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel6.Location = new System.Drawing.Point(4, 390);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(97, 19);
            this.gunaLabel6.TabIndex = 6;
            this.gunaLabel6.Text = "Пользователи";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel5.Location = new System.Drawing.Point(334, 95);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(95, 19);
            this.gunaLabel5.TabIndex = 5;
            this.gunaLabel5.Text = "Скоро в кино";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel4.Location = new System.Drawing.Point(5, 95);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 19);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Фильмы";
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel4.Controls.Add(this.DataTime);
            this.gunaElipsePanel4.Controls.Add(this.gunaLabel8);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(614, 8);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Size = new System.Drawing.Size(120, 77);
            this.gunaElipsePanel4.TabIndex = 3;
            // 
            // DataTime
            // 
            this.DataTime.BackColor = System.Drawing.Color.White;
            this.DataTime.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataTime.Location = new System.Drawing.Point(0, 29);
            this.DataTime.Name = "DataTime";
            this.DataTime.Size = new System.Drawing.Size(120, 31);
            this.DataTime.TabIndex = 4;
            this.DataTime.Text = "00.00.00";
            this.DataTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.Color.White;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(0, 12);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(120, 15);
            this.gunaLabel8.TabIndex = 3;
            this.gunaLabel8.Text = "Дата";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 412);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(726, 155);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(338, 117);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(396, 261);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 261);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(9, 568);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(726, 10);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(752, 580);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFilm)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSerial)).EndInit();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaElipsePanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox btnAddFilm;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox btnAddSerial;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        public Guna.UI.WinForms.GunaLabel CountFilm;
        public Guna.UI.WinForms.GunaLabel CountSoonFilm;
        public Guna.UI.WinForms.GunaLabel CountUsers;
        public Guna.UI.WinForms.GunaLabel DataTime;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}
