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
    public partial class SIGN_IN : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public SIGN_IN()
        {
            InitializeComponent();
            this.ActiveControl = Label;
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGN_UP sIGN_UP = new SIGN_UP();
            sIGN_UP.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainWindow = new Form1();
            mainWindow.UserName.Text = TextBoxUser.Text;
            mainWindow.Show();
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 mainWindow = new Form1();

                if (TextBoxUser.Text != "Username" && TextBoxPassword.Text != "Password")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM [User] WHERE uUsername='" + TextBoxUser.Text + "' AND uPassword='" + TextBoxPassword.Text + "'", connection);
                    DataTable dataTable = new DataTable();

                    oleDbDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count != 1)
                    {
                        ErrorPanel.Visible = true;
                        Messenge.ForeColor = Color.Red;
                        Messenge.Text = "Пользователь не найден";
                    }
                    else
                    {
                        mainWindow.UserName.Text = TextBoxUser.Text;
                        mainWindow.btnAdd.Visible = true;
                        mainWindow.btnIN.Visible = false;
                        mainWindow.btnUP.Visible = false;
                        mainWindow.btnUser.Visible = true;
                        if (TextBoxUser.Text == "admin") { mainWindow.btnAdmPanel.Visible = true; }
                        mainWindow.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (TextBoxPassword.Text == "Password")
                        TextBoxPassword.BorderColor = Color.Red;
                    if (TextBoxUser.Text == "Username")
                        TextBoxUser.BorderColor = Color.Red;
                    ErrorPanel.Visible = true;
                    Messenge.ForeColor = Color.Red;
                    Messenge.Text = "Есть пустые поля";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Point lastPoint;
        private void SIGN_IN_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SIGN_IN_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TextBoxUser_Enter(object sender, EventArgs e)
        {
            if (TextBoxUser.Text == "Username")
            {
                TextBoxUser.Text = "";
                TextBoxUser.ForeColor = Color.Black;
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
