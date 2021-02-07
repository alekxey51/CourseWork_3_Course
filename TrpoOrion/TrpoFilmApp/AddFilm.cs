using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace TrpoFilmApp
{
    public partial class AddFilm : Form
    {
        static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        OleDbConnection myConnection;

        public AddFilm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
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

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);

                OleDbCommand command = new OleDbCommand("INSERT INTO Film (fPhoto, fNameFilm, fYear, fCountry, fRating, fGoingTime, fDescription, fLink, fBlock, fFeesUSA, fFeesWorld, fPremiereWorld, fPremiereRF, fAge) VALUES (@photo, '" + TextBoxName.Text + "', '" + TextBoxYear.Text + "', '" + TextBoxCountry.Text + "', '" + TextBoxRating.Text + "' , '" + TextBoxTime.Text + "', '" + TextBoxDiscription.Text + "', '"+TextBoxLink.Text+"','"+ gunaSwitch1.Checked.ToString() + "', '"+TextBoxFeesUSA.Text+"', '"+TextBoxFeesWorld.Text+"', '"+TextBoxPremiereWorld.Text+"', '"+TextBoxPremiereRF.Text+"', '"+TextBoxAge.Text+"')", myConnection);
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

        Point lastPoint;
        private void AddFilm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddFilm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddSoonFilm_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);
                
                OleDbCommand command = new OleDbCommand("INSERT INTO SoonFilm (sPhoto, sNameFilm, sYear, sCountry, sRating, sGoingTime, sDescription, sLink, sBlock, sFeesUSA, sFeesWorld, sPremiereWorld, sPremiereRF, sAge) VALUES (@photo, '" + TextBoxName.Text + "', '" + TextBoxYear.Text + "', '" + TextBoxCountry.Text + "', '" + TextBoxRating.Text + "' , '" + TextBoxTime.Text + "', '" + TextBoxDiscription.Text + "', '"+TextBoxLink.Text+"', '"+ gunaSwitch1.Checked.ToString() + "', '" + TextBoxFeesUSA.Text + "', '" + TextBoxFeesWorld.Text + "', '" + TextBoxPremiereWorld.Text + "', '" + TextBoxPremiereRF.Text + "', '" + TextBoxAge.Text + "')", myConnection);
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
    }
}
