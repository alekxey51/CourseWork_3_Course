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
    public partial class add : Form
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public add()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                gunaPictureBox6.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);

                OleDbCommand command = new OleDbCommand("INSERT INTO Recipe (rPicture, rName, rCooking, rPersonts, rIngredient1, rCount1, rIngredient2, rCount2, rIngredient3, rCount3, rIngredient4, rCount4, rIngredient5, rCount5, rSteps, rCategory) " +
                                                        "VALUES (@photo, '" + gunaTextBox1.Text + "', '" + gunaTextBox2.Text + "', '" + gunaTextBox3.Text + "', '" + gunaComboBox1.Text + "', " +
                                                        "'" + gunaTextBox4.Text + "', '" + gunaComboBox2.Text + "', '" + gunaTextBox5.Text + "', '" + gunaComboBox3.Text + "', '" + gunaTextBox6.Text + "', " +
                                                        "'" + gunaComboBox4.Text + "', '" + gunaTextBox7.Text + "', '" + gunaComboBox5.Text + "', '" + gunaTextBox8.Text + "',  '" + gunaTextBox9.Text + "', '" + gunaComboBox6.Text + "')", myConnection);
                command.Parameters.AddWithValue("@photo", Photo);

                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    gunaPictureBox6.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
