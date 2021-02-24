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

namespace VovaCourse
{
    public partial class Form2 : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public Form2()
        {
            InitializeComponent();
            PrintCatalog();
            _obj = this;
        }

        static Form2 _obj;
        public static Form2 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form2();
                }
                return _obj;
            }
        }
        public FlowLayoutPanel Product
        {
            get { return flowLayoutPanel1; }
            set { flowLayoutPanel1 = value; }
        }
        public Guna.UI.WinForms.GunaPanel InfoPanel
        {
            get { return gunaPanel5; }
            set { gunaPanel5 = value; }
        }
        public Guna.UI.WinForms.GunaLabel NameProduct
        {
            get { return gunaLabel18; }
            set { gunaLabel18 = value; }
        }
        public Guna.UI.WinForms.GunaLabel IDProduct
        {
            get { return gunaLabel1; }
            set { gunaLabel1 = value; }
        }
        public Guna.UI.WinForms.GunaLabel ManufacturerProduct
        {
            get { return gunaLabel4; }
            set { gunaLabel4 = value; }
        }
        public Guna.UI.WinForms.GunaLabel PriceProduct
        {
            get { return gunaLabel3; }
            set { gunaLabel3 = value; }
        }
        public Guna.UI.WinForms.GunaLabel CountProduct
        {
            get { return gunaLabel2; }
            set { gunaLabel2 = value; }
        }
        public Guna.UI.WinForms.GunaPictureBox PictureBox
        {
            get { return gunaPictureBox13; }
            set { gunaPictureBox13 = value; }
        }
        public void PrintCatalog()
        {
            try
            {
                OleDbCommand command = new OleDbCommand($"SELECT * FROM Каталог", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ElCatalog Item = new ElCatalog();
                    Item.gunaLabel1.Text = reader[1].ToString();
                    Item.Height = 42;
                    flowLayoutPanel2.Controls.Add(Item);
                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            addProduct add = new addProduct();
            OleDbCommand command = new OleDbCommand($"SELECT Название FROM Каталог", connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while(reader.Read())
                add.gunaComboBox1.Items.Add(reader[0]);

            reader.Close();
            connection.Close();
            add.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            PrintProduct("SELECT * FROM Товар " +
                        $"WHERE Название = '{gunaTextBox1.Text}' or " +
                        $"Цена >= {gunaNumeric3.Value} and Цена <= {gunaNumeric4.Value} or " +
                        $"Количество >= {gunaNumeric2.Value} and Количество <= {gunaNumeric1.Value}");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            PrintProduct("SELECT * FROM Товар");
        }

        public void PrintProduct(string quirt)
        {
            try
            {
                Product.Controls.Clear();
                OleDbCommand command = new OleDbCommand(quirt, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ElProduct Item = new ElProduct();

                    byte[] Photo = (byte[])(reader[6]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    Item.gunaPictureBox2.Image = Image.FromStream(memoryStream);
                    Item.gunaLabel2.Text = $"{reader[2]}";
                    Item.ID.Text = $"{reader[0]}";
                    Product.Controls.Add(Item);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(gunaLabel2.Text.Remove(gunaLabel2.Text.Length - 3));
                if (n + gunaNumeric5.Value >= 0)
                {
                    OleDbCommand command = new OleDbCommand($"UPDATE Товар set Количество = {n + gunaNumeric5.Value} WHERE Название = '{gunaLabel18.Text}'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    gunaLabel2.Text = $"{n + gunaNumeric5.Value} шт";
                    gunaNumeric5.Value = 0;
                    gunaPanel7.Visible = true;
                }
                else throw new Exception("Такого количества товара нет в наличии");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void gunaLabel22_Click(object sender, EventArgs e)
        {
            if (gunaPanel7.Visible == true)
                gunaPanel7.Visible = false;
            else 
                gunaPanel7.Visible = true;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            ReferenceSystem system = new ReferenceSystem();
            system.Show();
        }
    }
}
