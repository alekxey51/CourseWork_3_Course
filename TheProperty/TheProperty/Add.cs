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
    public partial class Add : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public Add()
        {
            InitializeComponent();
        }

        public void ElVisible()
        {
            Form1 mainWindow = new Form1();
            mainWindow.UserName.Text = gunaLabel5.Text;
            mainWindow.btnIN.Visible = false;
            mainWindow.btnUP.Visible = false;
            mainWindow.btnAdd.Visible = true;
            mainWindow.btnUser.Visible = true;
            if (gunaLabel5.Text == "admin") { mainWindow.btnAdmPanel.Visible = true; }
            mainWindow.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElVisible();
        }

        Point lastPoint;
        private void Add_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Add_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        byte[] Photo1;
        byte[] Photo2;
        byte[] Photo3;
        byte[] Photo4;

        public byte[] PhotoBD(Guna.UI.WinForms.GunaPictureBox PictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] Photo = new byte[memoryStream.Length];
            memoryStream.Position = 0;
            memoryStream.Read(Photo, 0, Photo.Length);

            return Photo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Photo1 = PhotoBD(PictureBox);
                Photo2 = PhotoBD(PictureBox2);
                Photo3 = PhotoBD(PictureBox3);
                Photo4 = PhotoBD(PictureBox4);
                OleDbCommand command = new OleDbCommand($"INSERT INTO Announcement (uUsername, aAdress, aFloorEnd, aFloor, aCountRoom, aTipProperty, aSeller, aPhone, aNameOwner, aTotalArea, aKitchenArea, aTipRepairs, aDiscription, aPrice, aPrice30, aPhoto, aPhoto2, aPhoto3, aPhoto4) " +
                                                                          $"VALUES ({gunaLabel5.Text}, '{TextBoxAdress.Text}', {gunaNumeric3.Value}, {gunaNumeric1.Value}, {gunaNumeric2.Value}, '{ComboBoxTio.Text}', '{ComboBoxSeller.Text}', '{TextBoxPhone.Text}', '{TextBoxNameSell.Text}', '{TextBox1.Text}', '{TextBox2.Text}', '{ComboBox1.Text}', '{TextBoxDiscription.Text}', {int.Parse(TextBoxPrice.Text)}, {int.Parse(TextBoxPrice30.Text)}, @photo, @photo2, @photo3, @photo4)", connection);
                
                command.Parameters.AddWithValue("@photo", Photo1);
                command.Parameters.AddWithValue("@photo2", Photo2);
                command.Parameters.AddWithValue("@photo3", Photo3);
                command.Parameters.AddWithValue("@photo4", Photo4);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                ElVisible();
                this.Close();
            }
            catch(NullReferenceException nex)
            {
                MessageBox.Show(nex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }

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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    PictureBox2.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    PictureBox3.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    PictureBox4.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
