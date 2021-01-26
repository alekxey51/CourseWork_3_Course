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
    public partial class addUser : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public addUser()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) " +
                    $"VALUES ('{TextBoxSurname.Text}', '{TextBoxName.Text}', '{TextBoxOtchestvo.Text}', '{TextBoxYear.Text}', '{IDgroup()}')", connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Студент добавлен");
                ElUser group = new ElUser();
                group.gunaLabel1.Text = TextBoxName.Text + " " + TextBoxName.Text + " " + TextBoxOtchestvo.Text;
                group.gunaLabel2.Text = TextBoxYear.Text;
                GroupUser.Instance.flowLayoutPanel1.Controls.Add(group);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        public int IDgroup()
        {
            SqlCommand command1 = new SqlCommand($"SELECT IDгруппы FROM Группа WHERE [Номер группы] ='{GroupUser.Instance.gunaLabel1.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command1.ExecuteReader();
            reader.Read();
            int idгруппы = Convert.ToInt32(reader[0].ToString());
            connection.Close();
            reader.Close();
            return idгруппы;
        }
    }
}
