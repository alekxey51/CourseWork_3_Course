using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ORION;

namespace TrpoFilmApp
{
    public partial class Home : Form
    {
        public OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public Home() { InitializeComponent(); }
        public Home(string username, string password)
        {
            InitializeComponent();
            PanelSearch.Location = new Point(26, 11);
            this.ActiveControl = btnFilm;
            UserName.Text = username;
            if (username.ToLower() == "admin" && password.ToLower() == "admin")
            {
                AdminPanel.Visible = true;
                this.ActiveControl = btnAdmin;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static Home _obj;
        public static Home Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Home();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return gunaPanel2; }
            set { gunaPanel2 = value; }
        }

        public Guna.UI.WinForms.GunaPictureBox button
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public Guna.UI.WinForms.GunaPanel pnlSearch
        {
            get { return PanelSearch; }
            set { PanelSearch = value; }
        }

        public void btnAdmin_Click(object sender, EventArgs e)
        {
            PanelSearch.Location = new Point(26, 11);
            btnBack.Visible = false;

            _obj = this;
            gunaPanel2.Controls.RemoveAt(0);
            AdminControl adminControl1 = new AdminControl();
            gunaPanel2.Controls.Add(adminControl1);
            adminControl1.Dock = DockStyle.Fill;
            adminControl1.BringToFront();

            PrintListFilmAdmin(adminControl1);
            PrintLisеSoonFilmAdmin(adminControl1);
            PrintListUserAdmin(adminControl1);
            CountParamAdmin(adminControl1);
        }

        public void CountParamAdmin(AdminControl adminControl1)
        {
            OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Film", myConnection);
            myConnection.Open();
            adminControl1.CountFilm.Text = "0"+command.ExecuteScalar().ToString();
            myConnection.Close();

            command = new OleDbCommand("SELECT COUNT(*) FROM SoonFilm", myConnection);
            myConnection.Open();
            adminControl1.CountSoonFilm.Text = "0" + command.ExecuteScalar().ToString();
            myConnection.Close();

            command = new OleDbCommand("SELECT COUNT(*) FROM Users", myConnection);
            myConnection.Open();
            adminControl1.CountUsers.Text = "0" + command.ExecuteScalar().ToString();
            myConnection.Close();

            adminControl1.DataTime.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
        }

        public void PrintListFilmAdmin(AdminControl adminControl1)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Film]", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            adminControl1.flowLayoutPanel1.Controls.Clear();

            while (reader.Read())
            {
                ListFS Item = new ListFS();
                byte[] Photo = (byte[])(reader[0]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.PictureBox.Image = Image.FromStream(memoryStream);
                Item.gunaLabel1.Text = reader[1].ToString();
                Item.btnDeleteFilm.Visible = true;
                adminControl1.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            myConnection.Close();
        }

        public void PrintListUserAdmin(AdminControl adminControl1)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Users]", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            adminControl1.flowLayoutPanel3.Controls.Clear();
            Random random = new Random();

            while (reader.Read())
            {
                ListUsers Item = new ListUsers();
                Item.gunaLabel4.Text = reader[0].ToString();
                Item.gunaLabel5.Text = reader[1].ToString();
                Item.gunaLabel6.Text = reader[2].ToString();
                Item.gunaLabel7.Text = random.Next(1, 50).ToString();

                adminControl1.flowLayoutPanel3.Controls.Add(Item);
            }
            reader.Close();
            myConnection.Close();
        }

        public void PrintLisеSoonFilmAdmin(AdminControl adminControl1)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM [SoonFilm]", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            adminControl1.flowLayoutPanel2.Controls.Clear();

            while (reader.Read())
            {
                ListFS Item = new ListFS();
                byte[] Photo = (byte[])(reader[0]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.PictureBox.Image = Image.FromStream(memoryStream);
                Item.gunaLabel1.Text = reader[1].ToString();
                Item.Size = new Size(374, 41);
                Item.pLine.Size = new Size(360, 10);
                Item.btnDeleteSoonFilm.Location = new Point(350, 12);
                Item.Data.Visible = true;
                Item.Data.Text = reader[12].ToString();
                Item.btnDeleteSoonFilm.Visible = true;

                adminControl1.flowLayoutPanel2.Controls.Add(Item);
            }
            reader.Close();
            myConnection.Close();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            PanelSearch.Location = new Point(26, 11);
            
            _obj = this;
            gunaPanel2.Controls.RemoveAt(0);
            FilmControl filmControl = new FilmControl();
            gunaPanel2.Controls.Add(filmControl);
            filmControl.Dock = DockStyle.Fill;
            filmControl.BringToFront();

            PrintListFilm(filmControl);
        }

        private void PrintListFilm(FilmControl filmControl)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM Film", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FilmEl Item = new FilmEl();
                byte[] Photo = (byte[])(reader[0]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.PictureBoxFilm.Image = Image.FromStream(memoryStream);
                Item.NaneLableFilm.Text = reader[1].ToString();
                Item.PictureBoxFilm.Visible = true;
                if (reader[8].ToString() == "True")
                {
                    Item.gunaAdvenceButton1.Visible = true;
                    Item.PictureBoxFilm.Cursor = Cursors.Default;
                }
                filmControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            myConnection.Close();
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            PanelSearch.Location = new Point(26, 11);
            
            _obj = this;
            gunaPanel2.Controls.RemoveAt(0);
            FilmControl filmControl = new FilmControl();
            gunaPanel2.Controls.Add(filmControl);
            filmControl.Dock = DockStyle.Fill;
            filmControl.BringToFront();

            PrintListSoonFilm(filmControl);
        }

        public void PrintListSoonFilm(FilmControl filmControl)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM SoonFilm", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FilmEl Item = new FilmEl();
                byte[] Photo = (byte[])(reader[0]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.PictureBoxSoonFilm.Image = Image.FromStream(memoryStream);
                Item.NaneLableFilm.Text = reader[1].ToString();
                Item.PictureBoxSoonFilm.Visible = true;
                if (reader[8].ToString() == "True")
                {
                    Item.gunaAdvenceButton1.Visible = true;
                    Item.PictureBoxSoonFilm.Cursor = Cursors.Default;
                }

                filmControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            myConnection.Close();
        }

        Point lastPoint;
        private void gunaShadowPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void gunaShadowPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void filmEl1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            PanelSearch.Location = new Point(26, 11);
            gunaPanel2.Controls.RemoveAt(0);
            btnBack.Visible = false;
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Search for movies")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
                gunaTextBox1.BorderColor = Color.Silver;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Search for movies";
                gunaTextBox1.ForeColor = Color.Gray;
            }
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            PanelSearch.Location = new Point(26, 11);

            gunaPanel2.Controls.RemoveAt(0);
            FilmControl filmControl = new FilmControl();
            gunaPanel2.Controls.Add(filmControl);
            filmControl.Dock = DockStyle.Fill;
            filmControl.BringToFront();
        }

        private void btnWatchLater_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            PanelSearch.Location = new Point(26, 11);

            gunaPanel2.Controls.RemoveAt(0);
            FilmControl filmControl = new FilmControl();
            gunaPanel2.Controls.Add(filmControl);
            filmControl.Dock = DockStyle.Fill;
            filmControl.BringToFront();
        }
    }
}
