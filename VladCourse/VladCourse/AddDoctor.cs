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

namespace VladCourse
{
    public partial class AddDoctor : Form
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    PictureBox.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxPosition.Text != "")
                {
                    MemoryStream memoryStream = new MemoryStream();
                    PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] Photo = new byte[memoryStream.Length];

                    memoryStream.Position = 0;
                    memoryStream.Read(Photo, 0, Photo.Length);

                    OleDbCommand command = new OleDbCommand("INSERT INTO Doctor (dPhoto, dPosition) VALUES (@photo, '" + TextBoxPosition.Text + "')", myConnection);
                    command.Parameters.AddWithValue("@photo", Photo);

                    myConnection.Open();
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    this.Close();
                    MessageBox.Show("Good");
                }
                else
                {
                    TextBoxPosition.BorderColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }
    }
}
