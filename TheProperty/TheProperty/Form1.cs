using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheProperty
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public Form1()
        {
            InitializeComponent();
            SearchPanel.Location = new Point(21, 11);
            this.ActiveControl = UserName;
            PrintAnnouncement("SELECT * FROM Announcement");
            _obj = this;
        }

        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Guna.UI.WinForms.GunaPanel Search
        {
            get { return SearchPanel; }
            set { SearchPanel = value; }
        }
        public TableLayoutPanel tableLayout
        {
            get { return tableLayoutPanel1; }
            set { tableLayoutPanel1 = value; }
        }
        public Guna.UI.WinForms.GunaPanel Info
        {
            get { return InfoPanel; }
            set { InfoPanel = value; }
        }

       Point lastPoint;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = UserName;
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            ReferenceSystem system = new ReferenceSystem();
            system.Show();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGN_IN sIGN_IN = new SIGN_IN();
            sIGN_IN.Show();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGN_UP sIGN_UP = new SIGN_UP();
            sIGN_UP.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add();
            add.gunaLabel5.Text = UserName.Text;
            add.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            SearchPanel.Location = new Point(60, 11);
            AdminPanel Item = new AdminPanel();
            Item.Dock = DockStyle.Fill;
            Info.Controls.Add(Item);
            PrintCount(Item);
            PrintUser(Item);
            PrintProperty(Item);
            _obj = this;
        }

        public void PrintUser(AdminPanel admin)
        {
            OleDbCommand command = new OleDbCommand("SELECT uUsername, COUNT(*) FROM Announcement Group BY uUsername", connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            admin.flowLayoutPanel3.Controls.Clear();
            Random random = new Random();

            while (reader.Read())
            {
                ElUser Item = new ElUser();
                Item.gunaLabel4.Text += reader[0].ToString();
                Item.gunaLabel2.Text += reader[1].ToString();
                admin.flowLayoutPanel3.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        public void PrintProperty(AdminPanel admin)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM Announcement", connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            admin.LayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                ElProperty Item = new ElProperty();

                byte[] Photo = (byte[])(reader[16]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaPictureBox2.Image = Image.FromStream(memoryStream);

                Item.gunaLabel1.Text = $"{reader[5]}к    {reader[10]} / {reader[11]} м";
                Item.gunaLabel2.Text = $"{reader[4]} / {reader[3]}";
                Item.gunaLabel3.Text = reader[2].ToString();
                Item.IDLabel.Text = reader[0].ToString();

                admin.LayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        public void PrintCount(AdminPanel admin)
        {
            OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Announcement", connection);
            connection.Open();
            admin.CountAds.Text = "0" + command.ExecuteScalar().ToString();
            connection.Close();

            OleDbCommand command1 = new OleDbCommand("SELECT COUNT(*) FROM [User]", connection);
            connection.Open();
            admin.CountUsers.Text = "0" + command1.ExecuteScalar().ToString();
            connection.Close();

            Random random = new Random();
            admin.CountBuyAds.Text = "0" + random.Next(20, 40);

            admin.DataTime.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();

        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            PrintAnnouncement("SELECT * FROM Announcement");
            if(InfoPanel.Controls.Count >= 2)
                InfoPanel.Controls.RemoveAt(1);
            SearchPanel.Location = new Point(21, 11);
            tableLayoutPanel1.Visible = true;
            btnUser.Visible = true;
            btnALL.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PrintAnnouncement($"SELECT * FROM Announcement Where uUsername='{UserName.Text}'");
            if (InfoPanel.Controls.Count >= 2)
                InfoPanel.Controls.RemoveAt(1);
            SearchPanel.Location = new Point(21, 11);
            tableLayoutPanel1.Visible = true;
            btnUser.Visible = false;
            btnALL.Visible = true;
        }

        public void PrintAnnouncement(string inquiry)
        {
            OleDbCommand command = new OleDbCommand(inquiry, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            tableLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                ElProperty Item = new ElProperty();

                byte[] Photo = (byte[])(reader[16]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaPictureBox2.Image = Image.FromStream(memoryStream);

                Item.gunaLabel1.Text = $"{reader[5]}к    {reader[10]} / {reader[11]} м";
                Item.gunaLabel2.Text = $"{reader[4]} / {reader[3]}";
                Item.gunaLabel3.Text = reader[2].ToString();
                Item.IDLabel.Text = reader[0].ToString();

                tableLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "Search")
                TextBoxSearch.Text = "";
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
                TextBoxSearch.Text = "Search";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InfoPanel.Controls.RemoveAt(1);
            SearchPanel.Location = new Point(21, 11);
            tableLayoutPanel1.Visible = true;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            PrintAnnouncement($"SELECT * FROM Announcement Where aPrice>={gunaNumeric1.Value} and aPrice <= {gunaNumeric2.Value} or " +
                                                               $"aCountRoom>={gunaNumeric4.Value} and aCountRoom <= {gunaNumeric3.Value} or " +
                                                               $"aSeller='{ComboBoxSeller.Text}' or " +
                                                               $"aFloorEnd={gunaNumeric5.Value}");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gunaNumeric1.Value = 0;
            gunaNumeric2.Value = 0;
            gunaNumeric4.Value = 0;
            gunaNumeric3.Value = 0;
            ComboBoxSeller.Text = ComboBoxSeller.Items[0].ToString();
            gunaNumeric5.Value = 0;
            gunaCheckBox1.Checked = false;
            PrintAnnouncement("SELECT * FROM Announcement");
        }
    }
}
