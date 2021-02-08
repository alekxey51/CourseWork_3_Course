namespace VlabBukatkin
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaRadioButton1 = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaRadioButton2 = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaRadioButton3 = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaRadioButton4 = new Guna.UI.WinForms.GunaRadioButton();
            this.TextBoxSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel7.Location = new System.Drawing.Point(10, 143);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(96, 16);
            this.gunaLabel7.TabIndex = 40;
            this.gunaLabel7.Text = "Быстрве рецепты";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(209, 55);
            this.gunaLabel2.TabIndex = 41;
            this.gunaLabel2.Text = "Сортировка";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(20, 45);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(168, 10);
            this.gunaSeparator1.TabIndex = 42;
            // 
            // gunaRadioButton1
            // 
            this.gunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaRadioButton1.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton1.Location = new System.Drawing.Point(13, 166);
            this.gunaRadioButton1.Name = "gunaRadioButton1";
            this.gunaRadioButton1.Size = new System.Drawing.Size(93, 20);
            this.gunaRadioButton1.TabIndex = 43;
            this.gunaRadioButton1.Text = "до 15 минут";
            this.gunaRadioButton1.CheckedChanged += new System.EventHandler(this.gunaRadioButton1_CheckedChanged);
            // 
            // gunaRadioButton2
            // 
            this.gunaRadioButton2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaRadioButton2.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton2.Location = new System.Drawing.Point(13, 192);
            this.gunaRadioButton2.Name = "gunaRadioButton2";
            this.gunaRadioButton2.Size = new System.Drawing.Size(93, 20);
            this.gunaRadioButton2.TabIndex = 44;
            this.gunaRadioButton2.Text = "до 30 минут";
            this.gunaRadioButton2.CheckedChanged += new System.EventHandler(this.gunaRadioButton2_CheckedChanged);
            // 
            // gunaRadioButton3
            // 
            this.gunaRadioButton3.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton3.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaRadioButton3.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton3.Location = new System.Drawing.Point(13, 218);
            this.gunaRadioButton3.Name = "gunaRadioButton3";
            this.gunaRadioButton3.Size = new System.Drawing.Size(93, 20);
            this.gunaRadioButton3.TabIndex = 45;
            this.gunaRadioButton3.Text = "до 45 минут";
            this.gunaRadioButton3.CheckedChanged += new System.EventHandler(this.gunaRadioButton3_CheckedChanged);
            // 
            // gunaRadioButton4
            // 
            this.gunaRadioButton4.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton4.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton4.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaRadioButton4.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton4.Location = new System.Drawing.Point(13, 244);
            this.gunaRadioButton4.Name = "gunaRadioButton4";
            this.gunaRadioButton4.Size = new System.Drawing.Size(93, 20);
            this.gunaRadioButton4.TabIndex = 46;
            this.gunaRadioButton4.Text = "до 60 минут";
            this.gunaRadioButton4.CheckedChanged += new System.EventHandler(this.gunaRadioButton4_CheckedChanged);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearch.BaseColor = System.Drawing.Color.White;
            this.TextBoxSearch.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxSearch.BorderSize = 1;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.Location = new System.Drawing.Point(13, 93);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.Radius = 10;
            this.TextBoxSearch.Size = new System.Drawing.Size(175, 30);
            this.TextBoxSearch.TabIndex = 47;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel1.Location = new System.Drawing.Point(10, 72);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 16);
            this.gunaLabel1.TabIndex = 48;
            this.gunaLabel1.Text = "Название";
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(68, 396);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.btnSearch.Radius = 15;
            this.btnSearch.Size = new System.Drawing.Size(115, 37);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(21, 396);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.Radius = 15;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(43, 37);
            this.gunaAdvenceButton1.TabIndex = 50;
            this.gunaAdvenceButton1.Text = "ALL";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.gunaRadioButton4);
            this.Controls.Add(this.gunaRadioButton3);
            this.Controls.Add(this.gunaRadioButton2);
            this.Controls.Add(this.gunaRadioButton1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel7);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(209, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton1;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton2;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton3;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton4;
        private Guna.UI.WinForms.GunaTextBox TextBoxSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}
