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
    public partial class addProduct : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public addProduct()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    gunaPictureBox1.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaComboBox2.Text != "")
                {
                    MemoryStream memoryStream = new MemoryStream();
                    gunaPictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] Photo = new byte[memoryStream.Length];
                    memoryStream.Position = 0;
                    memoryStream.Read(Photo, 0, Photo.Length);
                    OleDbCommand comm = new OleDbCommand($"SELECT IDраздел FROM Раздел WHERE Название = '{gunaComboBox2.Text}'", connection);
                    connection.Open();
                    int n = int.Parse(comm.ExecuteScalar().ToString());
                    OleDbCommand command = new OleDbCommand($"INSERT INTO Товар (IDраздел, Название, Производитель, Цена, Количество, Photo) " +
                                                                       $"VALUES ({n}, '{gunaTextBox1.Text}', '{gunaTextBox3.Text}', '{gunaTextBox2.Text}', '{gunaNumeric2.Value}', @photo)", connection);
                    command.Parameters.AddWithValue("@photo", Photo);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Good");
                    Parametr();
                }
                else throw new Exception("Выберите раздел");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge");
                connection.Close();
            }
        }

        public void Parametr()
        {
            gunaTextBox1.Text = "";
            gunaTextBox2.Text = "";
            gunaTextBox3.Text = "";
            gunaNumeric2.Value = 0;
            gunaComboBox2.StartIndex = -1;
            gunaComboBox1.StartIndex = -1;
            gunaPictureBox1.Image = null;
        }

        private void gunaComboBox2_Click(object sender, EventArgs e)
        {
            gunaComboBox2.Items.Clear();
            OleDbCommand command = new OleDbCommand($"SELECT Раздел.Название " +
                                                    $"FROM Каталог " +
                                                    $"INNER JOIN Раздел ON Каталог.IDкаталог = Раздел.IDкаталог " +
                                                    $"WHERE Каталог.Название = '{gunaComboBox1.Text}'", connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
                gunaComboBox2.Items.Add(reader[0]);

            reader.Close();
            connection.Close();
        }

        private void gunaComboBox1_Click(object sender, EventArgs e)
        {
            gunaComboBox2.StartIndex = -1;
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
