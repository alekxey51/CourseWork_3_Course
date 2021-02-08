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
    public partial class SIGNup : Form
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public SIGNup()
        {
            InitializeComponent();
            this.ActiveControl = gunaLabel1;
        }

        private void LabelSignIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNin sIGNin = new SIGNin();
            sIGNin.Show();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxName.Text != "Name" && TextBoxSurname.Text != "Surname" && TextBoxUsername.Text != "Username" && TextBoxPassword.Text != "Password")
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Users (uName, uSurname, uUsername, uPassword) VALUES ('" + TextBoxName.Text + "', '" + TextBoxSurname.Text + "', '" + TextBoxUsername.Text + "', '" + TextBoxPassword.Text + "')", myConnection);

                    myConnection.Open();
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    this.Hide();
                    SIGNin sIGNin = new SIGNin();
                    sIGNin.Show();
                }
                else
                {
                    if (TextBoxName.Text == "Name")
                        TextBoxName.BorderColor = Color.Red;
                    if (TextBoxSurname.Text == "Surname")
                        TextBoxSurname.BorderColor = Color.Red;
                    if (TextBoxPassword.Text == "Password")
                        TextBoxPassword.BorderColor = Color.Red;
                    if (TextBoxUsername.Text == "Username")
                        TextBoxUsername.BorderColor = Color.Red;
                    MessageBox.Show("Есть пустые поля");
                }
            }
            catch
            {
                MessageBox.Show("Пользователь с таким UserName уже зарегестрирован");
                myConnection.Close();
            }
        }

        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Name")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = Color.Black;
                TextBoxName.BorderColor = Color.Silver;
            }
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
            {
                TextBoxName.Text = "Name";
                TextBoxName.ForeColor = Color.Gray;
            }
        }

        private void TextBoxSurname_Enter(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "Surname")
            {
                TextBoxSurname.Text = "";
                TextBoxSurname.ForeColor = Color.Black;
                TextBoxSurname.BorderColor = Color.Silver;
            }
        }

        private void TextBoxSurname_Leave(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "")
            {
                TextBoxSurname.Text = "Surname";
                TextBoxSurname.ForeColor = Color.Gray;
            }
        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "Username")
            {
                TextBoxUsername.Text = "";
                TextBoxUsername.ForeColor = Color.Black;
                TextBoxUsername.BorderColor = Color.Silver;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "")
            {
                TextBoxUsername.Text = "Username";
                TextBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Password")
            {
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = Color.Black;
                TextBoxPassword.BorderColor = Color.Silver;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = "Password";
                TextBoxPassword.ForeColor = Color.Gray;
            }
        }
    }
}
