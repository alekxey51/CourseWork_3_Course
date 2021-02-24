using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladCourse
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
                Match matchPhone = Regex.Match(TextBoxPhone.Text, @"((\(\d{3}\) ?)|(\d{3}-))?\d{2}-\d{3}-\d{2}-\d{2}");
                Match matchMail = Regex.Match(TextBoxEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                if (matchMail.Success && matchPhone.Success)
                {
                    if (TextBoxPassword.Text != TextBoxPass2.Text)
                    {
                        panelInfo.Visible = true;
                        labelMessenge.ForeColor = Color.Red;
                        labelMessenge.Text = "Password не совпадает";
                    }
                    else if (TextBoxName.Text != "Name" && TextBoxSurname.Text != "Surname" && TextBoxUsername.Text != "Username" && TextBoxPassword.Text != "Password" && TextBoxEmail.Text != "Email" && TextBoxPhone.Text != "(375)29-943-28-53" && TextBoxPass2.Text != "Password")
                    {
                        OleDbCommand command = new OleDbCommand("INSERT INTO Users (uName, uSurname, uEmail, uPhone, uUsername, uPassword, uPassword2) VALUES ('" + TextBoxName.Text + "', '" + TextBoxSurname.Text + "', '" + TextBoxEmail.Text + "', '" + TextBoxPhone.Text + "', '" + TextBoxUsername.Text + "', '" + TextBoxPassword.Text + "', '" + TextBoxPass2.Text + "')", myConnection);

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
                        if (TextBoxEmail.Text == "Email")
                            TextBoxEmail.BorderColor = Color.Red;
                        if (TextBoxPhone.Text == "Phone")
                            TextBoxPhone.BorderColor = Color.Red;
                        if (TextBoxUsername.Text == "Username")
                            TextBoxUsername.BorderColor = Color.Red;
                        if (TextBoxPassword.Text == "Password")
                            TextBoxPassword.BorderColor = Color.Red;
                        if (TextBoxPass2.Text == "Password")
                            TextBoxPass2.BorderColor = Color.Red;
                        panelInfo.Visible = true;
                        labelMessenge.ForeColor = Color.Red;
                        labelMessenge.Text = "Есть пустые поля";
                    }
                }
                else
                {
                    panelInfo.Visible = true;
                    labelMessenge.ForeColor = Color.Red;
                    labelMessenge.Text = "Проверьте E-mail, Phone";
                }
            }
            catch
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Пользователь с таким UserName уже зарегестрирован";
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

        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == "Email")
            {
                TextBoxEmail.Text = "";
                TextBoxEmail.ForeColor = Color.Black;
                TextBoxEmail.BorderColor = Color.Silver;
            }
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == "")
            {
                TextBoxEmail.Text = "Email";
                TextBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPhone_Enter(object sender, EventArgs e)
        {
            if (TextBoxPhone.Text == "(375)29-943-28-53")
            {
                TextBoxPhone.Text = "";
                TextBoxPhone.ForeColor = Color.Black;
                TextBoxPhone.BorderColor = Color.Silver;
            }
        }

        private void TextBoxPhone_Leave(object sender, EventArgs e)
        {
            if (TextBoxPhone.Text == "")
            {
                TextBoxPhone.Text = "(375)29-943-28-53";
                TextBoxPhone.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPass2_Enter(object sender, EventArgs e)
        {
            if (TextBoxPass2.Text == "Password")
            {
                TextBoxPass2.Text = "";
                TextBoxPass2.ForeColor = Color.Black;
                TextBoxPass2.BorderColor = Color.Silver;
            }
        }

        private void TextBoxPass2_Leave(object sender, EventArgs e)
        {
            if (TextBoxPass2.Text == "")
            {
                TextBoxPass2.Text = "Password";
                TextBoxPass2.ForeColor = Color.Gray;
            }
        }
    }
}
