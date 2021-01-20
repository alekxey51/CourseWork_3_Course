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

namespace CourseTheCar
{
    public partial class AddCar : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public AddCar()
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
                if (gunaTextBox1.Text != "")
                {
                    MemoryStream memoryStream = new MemoryStream();
                    gunaPictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] Photo = new byte[memoryStream.Length];

                    memoryStream.Position = 0;
                    memoryStream.Read(Photo, 0, Photo.Length);

                    OleDbCommand command = new OleDbCommand($"INSERT INTO Марка (Название, Picture) VALUES ('{gunaTextBox1.Text}', @photo)", connection);
                    command.Parameters.AddWithValue("@photo", Photo);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    //this.Close();
                    //MessageBox.Show("Good");
                }
                else
                {
                    gunaTextBox1.BorderColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            gunaPictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] Photo = new byte[memoryStream.Length];

            memoryStream.Position = 0;
            memoryStream.Read(Photo, 0, Photo.Length);
            OleDbCommand command = new OleDbCommand($"UPDATE Марка set Picture = @photo WHERE Код = {int.Parse(gunaTextBox1.Text)}", connection);
            command.Parameters.AddWithValue("@photo", Photo);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
