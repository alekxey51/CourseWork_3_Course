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
    public partial class Appraisal : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public Appraisal()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) " +
                    $"VALUES ('{TextBoxDate.Text}', '{gunaComboBox2.Text}', '{gunaComboBox3.Text}', '{gunaComboBox4.Text}', '{gunaComboBox5.Text}', '{IDUser()}', '{IDPredmet()}')", connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Оценка поставлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        int num;
        public int IDPredmet()
        {
            SqlCommand command = new SqlCommand($"SELECT IDпредмет FROM Предмет " +
                                                $"WHERE Название ='{gunaComboBox6.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            num = Convert.ToInt32(reader[0].ToString());
            connection.Close();
            reader.Close();
            return num;
        }

        public int IDUser()
        {
            string[] FIO = gunaComboBox1.Text.Split();
            SqlCommand command = new SqlCommand($"SELECT IDстудент FROM Студент " +
                                                $"WHERE Фамилия ='{FIO[0]}' and Имя='{FIO[1]}' and Отчество='{FIO[2]}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            num = Convert.ToInt32(reader[0].ToString());
            connection.Close();
            reader.Close();
            return num;
        }
    }
}
