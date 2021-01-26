using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicJournal
{
    public partial class SignIN : Form
    {
       SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public SignIN()
        {
            InitializeComponent();
            gunaPanel2.Height = 34;
            this.ActiveControl = gunaLabel1;
            PrintGroup();
        }

        public void PrintGroup()
        {
            ComboBoxGroup.Items.Clear();
            SqlCommand command = new SqlCommand($"SELECT [Номер группы] FROM Группа ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            ComboBoxGroup.Items.Add("");

            while (reader.Read())
                ComboBoxGroup.Items.Add(reader[0]);

            reader.Close();
            connection.Close();
        }

        private void MenuPictureBox_Click(object sender, EventArgs e)
        {
            if(gunaPanel2.Height != 66)
                gunaPanel2.Height = 66;
            else
                gunaPanel2.Height = 34;
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = gunaLabel1;
            if (gunaLabel2.Text == "Вход для преподавателей")
            {
                gunaLabel2.Text = "Вход для родителей";
                TextBoxYear.Text = "Пароль";
                gunaPanel2.Height = 34;
            }
            else
            {
                gunaLabel2.Text = "Вход для преподавателей";
                TextBoxYear.Text = "Дата рождения(01.02.1993)";
                gunaPanel2.Height = 34;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxSurname.Text == "admin" && TextBoxYear.Text == "admin" && gunaLabel2.Text == "Вход для родителей")
                {
                    AdminGroup Item = new AdminGroup();
                    Item.Dock = DockStyle.Fill;
                    Form1.Instance.PrintGroup(Item);
                    Form1.Instance.Controls.Add(Item);
                    Form1.Instance.Show();
                    this.Hide();
                }
                else if (TextBoxSurname.Text != "Фамилия" && TextBoxYear.Text != "Дата рождения (01.02.1993)" && ComboBoxGroup.Text != "")
                {
                    SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT Студент.Фамилия, Студент.[Дата рождения], Группа.[Номер группы] " +
                                                                    "FROM Группа " +
                                                                    "INNER JOIN Студент ON Группа.IDгруппы = Студент.IDгруппы " +
                                                                    "WHERE Фамилия='" + TextBoxSurname.Text + "' AND [Дата рождения]='" + TextBoxYear.Text + "' AND [Номер группы]='" + ComboBoxGroup.Text + "'", connection);
                    DataTable dataTable = new DataTable();
                    DataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count != 1)
                    {
                        throw new Exception("Пользователь не найден");
                    }
                    else
                    {
                        Form1.Instance.surname = TextBoxSurname.Text;
                        Form1.Instance.year = TextBoxYear.Text;
                        Form1.Instance.group = ComboBoxGroup.Text;

                        if (gunaLabel2.Text == "Вход для преподавателей")
                        {
                            Thing Item = new Thing();
                            Item.gunaLabel1.Width = 189;
                            Item.gunaLabel1.Location = new Point(10, 7);
                            Item.Dock = DockStyle.Fill;
                            Form1.Instance.PrintThing(Item);
                            Form1.Instance.PrintName(Item);
                            Form1.Instance.Controls.Add(Item);
                            Form1.Instance.Show();
                            this.Hide();
                        }
                        else throw new Exception("Введены неверные данные");
                    }
                }
                else
                {
                    if (TextBoxSurname.Text == "Фамилия")
                        TextBoxSurname.BorderColor = Color.Red;
                    if (TextBoxYear.Text == "Дата рождения (01.02.1993)" || TextBoxYear.Text == "Пароль")
                        TextBoxYear.BorderColor = Color.Red;
                    if (ComboBoxGroup.Text == "")
                        ComboBoxGroup.BorderColor = Color.Red;
                    throw new Exception("Есть пустые поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge");
            }
        }

        private void TextBoxSurname_Enter(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "Фамилия")
            {
                TextBoxSurname.Text = "";
                TextBoxSurname.ForeColor = Color.Black;
            }
        }

        private void TextBoxSurname_Leave(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "")
            {
                TextBoxSurname.Text = "Фамилия";
                TextBoxSurname.ForeColor = Color.Gray;
            }
        }

        private void TextBoxYear_Enter(object sender, EventArgs e)
        {
            if (TextBoxYear.Text == "Дата рождения (01.02.1993)" || TextBoxYear.Text == "Пароль")
            {
                TextBoxYear.Text = "";
                TextBoxYear.ForeColor = Color.Black;
            }
        }

        private void TextBoxYear_Leave(object sender, EventArgs e)
        {
            if (TextBoxYear.Text == "" && gunaLabel2.Text == "Вход для преподавателей")
            {
                TextBoxYear.Text = "Дата рождения (01.02.1993)";
                TextBoxYear.ForeColor = Color.Gray;
            }
            else if (TextBoxYear.Text == "" && gunaLabel2.Text == "Вход для родителей")
            {
                TextBoxYear.Text = "Пароль";
                TextBoxYear.ForeColor = Color.Gray;
            }
        }

        private void TextBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
