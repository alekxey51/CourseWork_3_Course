using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicJournal
{
    public partial class Statistics : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public Statistics()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string[] FIO = gunaComboBox1.Text.Split();
            if (gunaButton1.Text == "Создать ведомость успеваемости")
            {
                PrintFile("SELECT Фамилия, Имя, Отчество, Журнал.Дата, Предмет.Название, Журнал.Оценка FROM Предмет " +
                          "INNER JOIN Журнал ON Предмет.IDпредмет = Журнал.IDпредмет " +
                          "INNER JOIN Студент ON Журнал.IDстудент = Студент.IDстудент " +
                          "INNER JOIN Группа ON Студент.IDгруппы = Группа.IDгруппы " +
                          $"WHERE [Номер группы]='{GroupUser.Instance.gunaLabel1.Text}' and Оценка!='' and Фамилия='{FIO[0]}' and Имя='{FIO[1]}' and Отчество='{FIO[2]}'", "ФИО | Дата | Название предмета | Оценка");
            }
            else if (gunaButton1.Text == "Создать ведомость пропусков")
            {
                PrintFile("SELECT Фамилия, Имя, Отчество, Журнал.Дата, Предмет.Название, Журнал.Нка FROM Предмет " +
                          "INNER JOIN Журнал ON Предмет.IDпредмет = Журнал.IDпредмет " +
                          "INNER JOIN Студент ON Журнал.IDстудент = Студент.IDстудент " +
                          "INNER JOIN Группа ON Студент.IDгруппы = Группа.IDгруппы " +
                          $"WHERE [Номер группы]='{GroupUser.Instance.gunaLabel1.Text}' and Нка!='' and Фамилия='{FIO[0]}' and Имя='{FIO[1]}' and Отчество='{FIO[2]}'", "ФИО | Дата | Название предмета | Нка");
            }
            else if (gunaButton1.Text == "Создать ведомость отработок")
            {
                PrintFile("SELECT Фамилия, Имя, Отчество, Журнал.Дата, Предмет.Название, Журнал.Практика FROM Предмет " +
                          "INNER JOIN Журнал ON Предмет.IDпредмет = Журнал.IDпредмет " +
                          "INNER JOIN Студент ON Журнал.IDстудент = Студент.IDстудент " +
                          "INNER JOIN Группа ON Студент.IDгруппы = Группа.IDгруппы " +
                          $"WHERE [Номер группы]='{GroupUser.Instance.gunaLabel1.Text}' and Нка!='' and Практика='Да' and Фамилия='{FIO[0]}' and Имя='{FIO[1]}' and Отчество='{FIO[2]}'", "ФИО | Дата | Название предмета | Практика");
            }
        }
        
        public void PrintFile(string zapros, string info1)
        {
            SqlCommand command = new SqlCommand($"{zapros}", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            File.Delete($"Ведомость - {gunaComboBox1.Text}.txt");
            File.AppendAllText($"Ведомость - {gunaComboBox1.Text}.txt", $"{info1} \r\n");
            while (reader.Read())
            {
                File.AppendAllText($"Ведомость - {gunaComboBox1.Text}.txt", $"{reader[0]} {reader[1]} {reader[2]} | {reader[3]} | {reader[4]} | {reader[5]} \r\n");
            }

            MessageBox.Show("Ведомость создана");
            reader.Close();
            connection.Close();
        }
    }
}
