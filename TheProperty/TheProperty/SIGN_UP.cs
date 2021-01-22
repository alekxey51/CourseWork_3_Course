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

namespace TheProperty
{
    public partial class SIGN_UP : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public SIGN_UP()
        {
            InitializeComponent();
            this.ActiveControl = Label;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainWindow = new Form1();
            mainWindow.UserName.Text = TextBoxUsername.Text;
            mainWindow.Show();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxName.Text != "Name" && TextBoxSurname.Text != "Surname" && TextBoxUsername.Text != "Username" && TextBoxPassword.Text != "Password")
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO [User] (uName, uSurname, uUsername, uPassword) VALUES ('" + TextBoxName.Text + "', '" + TextBoxSurname.Text + "', '" + TextBoxUsername.Text + "', '" + TextBoxPassword.Text + "')", connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    this.Hide();
                    SIGN_IN sIGN_IN = new SIGN_IN();
                    sIGN_IN.Show();
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
                    panelInfo.Visible = true;
                    labelMessenge.ForeColor = Color.Red;
                    labelMessenge.Text = "Есть пустые поля";
                }
            }
            catch
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Пользователь с таким UserName уже зарегестрирован";
                connection.Close();
            }
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGN_IN sIGN_IN = new SIGN_IN();
            sIGN_IN.Show();
        }

        Point lastPoint;
        private void SIGN_UP_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SIGN_UP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Name")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = Color.Black;
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
