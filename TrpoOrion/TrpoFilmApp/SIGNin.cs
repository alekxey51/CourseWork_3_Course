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

namespace TrpoFilmApp
{
    public partial class SIGNin : Form
    {
        static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        OleDbConnection myConnection;

        public SIGNin()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            this.ActiveControl = gunaLabel1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void LabelCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNup sIGNup = new SIGNup();
            sIGNup.Show();
        }

        private void LabelReestablish_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            labelMessenge.Text = "Попробуйте позже";
            labelMessenge.ForeColor = Color.Red;
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxUser.Text != "Username" && TextBoxPass.Text != "Password")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Users WHERE uUsername='" + TextBoxUser.Text + "' AND uPassword='" + TextBoxPass.Text + "'", myConnection);
                    DataTable dataTable = new DataTable();

                    oleDbDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count != 1)
                    {
                        panelInfo.Visible = true;
                        labelMessenge.ForeColor = Color.Red;
                        labelMessenge.Text = "Пользователь не найден";
                    }
                    else
                    {
                        this.Hide();
                        Home home = new Home(TextBoxUser.Text, TextBoxPass.Text);
                        home.Show();
                    }
                }
                else
                {
                    if (TextBoxPass.Text == "Password")
                        TextBoxPass.BorderColor = Color.Red;
                    if (TextBoxUser.Text == "Username")
                        TextBoxUser.BorderColor = Color.Red;
                    panelInfo.Visible = true;
                    labelMessenge.ForeColor = Color.Red;
                    labelMessenge.Text = "Есть пустые поля";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
