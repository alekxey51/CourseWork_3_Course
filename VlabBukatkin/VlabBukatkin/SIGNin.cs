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

namespace VlabBukatkin
{
    public partial class SIGNin : Form
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public SIGNin()
        {
            InitializeComponent();
            this.ActiveControl = gunaLabel1;
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            try
            {
                Home mainWindow = new Home(TextBoxUser.Text);

                if (TextBoxUser.Text != "Username" && TextBoxPass.Text != "Password")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Users WHERE uUsername='" + TextBoxUser.Text + "' AND uPassword='" + TextBoxPass.Text + "'", myConnection);
                    DataTable dataTable = new DataTable();

                    oleDbDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count != 1)
                    {
                        MessageBox.Show("Пользователь не найден");
                    }
                    else
                    {
                        mainWindow.gunaPanel6.Height = 42;
                        mainWindow.Width = 640;
                        mainWindow.gunaPanel5.Visible = false;
                        mainWindow.gunaPictureBox7.Location = new Point(439, 5);


                        if (TextBoxUser.Text == "admin" && TextBoxPass.Text == "admin")
                        {
                            mainWindow.gunaPictureBox3.Visible = true;
                            mainWindow.gunaPictureBox7.Location = new Point(411, 6);
                        }

                        mainWindow.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (TextBoxPass.Text == "Password")
                        TextBoxPass.BorderColor = Color.Red;
                    if (TextBoxUser.Text == "Username")
                        TextBoxUser.BorderColor = Color.Red;
                    MessageBox.Show("Есть пустые поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SIGNup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNup sIGNup = new SIGNup();
            sIGNup.Show();
        }

        private void TextBoxUser_Enter(object sender, EventArgs e)
        {
            if (TextBoxUser.Text == "Username")
            {
                TextBoxUser.Text = "";
                TextBoxUser.ForeColor = Color.Black;
                TextBoxUser.BorderColor = Color.Silver;
            }
        }

        private void TextBoxUser_Leave(object sender, EventArgs e)
        {
            if (TextBoxUser.Text == "")
            {
                TextBoxUser.Text = "Username";
                TextBoxUser.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPass_Enter(object sender, EventArgs e)
        {
            if (TextBoxPass.Text == "Password")
            {
                TextBoxPass.Text = "";
                TextBoxPass.ForeColor = Color.Black;
                TextBoxPass.BorderColor = Color.Silver;
            }
        }

        private void TextBoxPass_Leave(object sender, EventArgs e)
        {
            if (TextBoxPass.Text == "")
            {
                TextBoxPass.Text = "Password";
                TextBoxPass.ForeColor = Color.Gray;
            }
        }
    }
}
