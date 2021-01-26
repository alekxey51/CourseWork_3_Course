using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicJournal
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            _obj = this;
        }

        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public string surname;
        public string group;
        public string year;

        public void PrintThing(Thing Item)
        {
            SqlCommand command = new SqlCommand($"SELECT Группа.[Номер группы], Предмет.Название " +
                                                $"FROM Группа " +
                                                $"INNER JOIN Расписание ON Группа.IDгруппы = Расписание.IDгруппы " +
                                                $"INNER JOIN Предмет ON Расписание.IDпредмет = Предмет.IDпредмет " +
                                                $"WHERE Группа.[Номер группы] ='{group}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Item.flowLayoutPanel1.Controls.Clear();

            while (reader.Read())
            {
                ElThing Item1 = new ElThing();
                Item1.gunaLabel1.Text = reader[1].ToString();
                Item.flowLayoutPanel1.Controls.Add(Item1);
            }
            reader.Close();
            connection.Close();
        }

        public void PrintName(Thing Item)
        {
            try
            {
                SqlCommand command = new SqlCommand($"SELECT Фамилия, Имя, Отчество " +
                                                    $"FROM Студент " +
                                                    $"WHERE [Дата рождения] ='{year}' AND Студент.Фамилия ='{surname}'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Item.gunaLabel1.Text = reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        public void PrintGroup(AdminGroup Item)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Группа", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Group Item1 = new Group();
                Item1.gunaLabel1.Text = reader[1].ToString();
                Item.tableLayoutPanel1.Controls.Add(Item1);
            }
            reader.Close();
            connection.Close();
        }

    }
}
