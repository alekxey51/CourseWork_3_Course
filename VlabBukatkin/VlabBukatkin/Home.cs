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

namespace VlabBukatkin
{
    public partial class Home : Form
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public string username = "";
        public int IDuser;
        public Home(string user)
        {
            InitializeComponent();
            this.ActiveControl = gunaLabel1;
            username = user;
            SearchIDuser();
            PrintRecipe("SELECT * FROM Recipe");
            _obj = this;
        }

        public Home() { }

        static Home _obj;
        public static Home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Home();
                }
                return _obj;
            }
        }

        private void SearchIDuser()
        {
            OleDbCommand command = new OleDbCommand($"SELECT * FROM Users Where uName = '{username}'", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            tableLayoutPanel1.Controls.Clear();
            while (reader.Read()) { IDuser = (int)reader[0]; }
            myConnection.Close();
        }

        private void gunaPictureBox10_Click(object sender, EventArgs e)
        {
            if (gunaPanel6.Height < 174)
                gunaPanel6.Height = 174;
            else
                gunaPanel6.Height = 42;
        }

        public void PrintRecipe(string inquiry)
        {
            OleDbCommand command = new OleDbCommand(inquiry, myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            tableLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                DishControl Item = new DishControl();

                byte[] Photo = (byte[])(reader[1]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaPictureBox6.Image = Image.FromStream(memoryStream);

                Item.IDdish.Text = $"{reader[0]}";
                Item.NameDish.Text = $"{reader[2]}";

                if (username == "admin")
                {
                    Item.gunaPictureBox1.Visible = true;
                }

                tableLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            myConnection.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            InfoControl Item = new InfoControl();
            Item.Dock = DockStyle.Fill;
            InfoPanel.Controls.Add(Item);
            gunaPictureBox6.Visible = true;
            gunaLabel1.Text = "Холодильник";
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            Parametr();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNin sIGNin = new SIGNin();
            sIGNin.Show();
        }

        private void Parametr()
        {
            gunaPictureBox6.Visible = false;
            InfoPanel.Controls.RemoveAt(1);
            tableLayoutPanel1.Visible = true;
            gunaLabel1.Text = "Каталог рецептов";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaLabel1.Text == "Холодильник") { Parametr(); }
            PrintRecipe("SELECT * FROM Recipe");
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (gunaLabel1.Text == "Холодильник") { Parametr(); }
            PrintRecipe("SELECT * FROM Recipe WHERE rCategory = 'Каши'");
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (gunaLabel1.Text == "Холодильник") { Parametr(); }
            PrintRecipe("SELECT * FROM Recipe WHERE rCategory = 'Шашлык'");
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            if (gunaLabel1.Text == "Холодильник") { Parametr(); }
            PrintRecipe("SELECT * FROM Recipe WHERE rCategory = 'Запиканка'");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (gunaLabel1.Text == "Холодильник") { Parametr(); }
            PrintRecipe($"SELECT Favorites.IDuser, Recipe.rPicture, Recipe.rName, Recipe.rCooking, Recipe.rPersonts, Recipe.rIngredient1, " +
                $"Recipe.rCount1, Recipe.rIngredient2, Recipe.rCount2, Recipe.rIngredient3, Recipe.rCount3, Recipe.rIngredient4, " +
                $"Recipe.rCount4, Recipe.rIngredient5, Recipe.rCount5, Recipe.rSteps, Recipe.rCategory " +
"FROM Recipe INNER JOIN Favorites ON Recipe.IDrecipe = Favorites.IDRecipe "+
             $"WHERE Favorites.IDuser = {IDuser}");
            gunaLabel1.Text = "Избранное";
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            add add1 = new add();
            add1.Show();
        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            WidthPanel();
            SearchControl Item = new SearchControl();
            gunaPanel5.Controls.Add(Item);
            Item.Dock = DockStyle.Fill;
            Item.BringToFront();
        }

        private void WidthPanel()
        {
            if (this.Width == 640)
            {
                this.Width = 853;
                this.gunaPanel5.Visible = true;
            }
            else
            {
                this.Width = 640;
                this.gunaPanel5.Visible = false;
            }
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            Spravke spravke = new Spravke();
            spravke.Show();
        }
    }
}
