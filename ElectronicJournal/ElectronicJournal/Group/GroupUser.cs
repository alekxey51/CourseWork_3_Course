using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicJournal
{
    public partial class GroupUser : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public GroupUser()
        {
            InitializeComponent();
            _obj2 = this;
        }

        static GroupUser _obj2;
        public static GroupUser Instance
        {
            get
            {
                if (_obj2 == null)
                {
                    _obj2 = new GroupUser();
                }
                return _obj2;
            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Form1.Instance.Controls.RemoveAt(0);
            AdminGroup Item = new AdminGroup();
            Item.Dock = DockStyle.Fill;
            Form1.Instance.PrintGroup(Item);
            Form1.Instance.Controls.Add(Item);            
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
            if (TextBoxYear.Text == "Дата рождения (01.02.1993)")
            {
                TextBoxYear.Text = "";
                TextBoxYear.ForeColor = Color.Black;
            }
        }

        private void TextBoxYear_Leave(object sender, EventArgs e)
        {
            if (TextBoxYear.Text == "")
            {
                TextBoxYear.Text = "Дата рождения (01.02.1993)";
                TextBoxYear.ForeColor = Color.Gray;
            }
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT Студент.Фамилия, Студент.Имя, Студент.Отчество, Студент.[Дата рождения] " +
                                                $"FROM Студент " +
                                                $"INNER JOIN Группа ON Студент.IDгруппы = Группа.IDгруппы " +
                                                $"WHERE Группа.[Номер группы] ='{gunaLabel1.Text}' And Фамилия LIKE '{TextBoxSurname.Text}%' or [Дата рождения] LIKE '{TextBoxYear.Text}%'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            Random rand = new Random();
            while (reader.Read())
            {
                ElUser Item1 = new ElUser();
                Item1.gunaLabel1.Text = reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                Item1.gunaLabel4.Text = rand.Next(0, 10).ToString();
                Item1.gunaLabel5.Text = rand.Next(0, 10).ToString();
                Item1.gunaLabel2.Text = reader[3].ToString();
                flowLayoutPanel1.Controls.Add(Item1);
            }
            reader.Close();
            connection.Close();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            addGroup addGroup1 = new addGroup();
            addGroup1.Text = gunaButton9.Text;
            addGroup1.gunaLabel1.Text = "Название предмета";
            addGroup1.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            addUser user = new addUser();
            user.TextBoxGroup.Text = gunaLabel1.Text;
            user.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Appraisal appraisal = new Appraisal();
            PrintFIO(appraisal);
            PrintPredmet(appraisal);
            appraisal.Show();
        }
        public void PrintPredmet(Appraisal appraisal)
        {
            appraisal.gunaComboBox6.Items.Clear();
            SqlCommand command = new SqlCommand($"SELECT Название " +
                                                $"FROM Группа " +
                                                $"INNER JOIN Расписание ON Группа.IDгруппы = Расписание.IDгруппы " +
                                                $"INNER JOIN Предмет ON Расписание.IDпредмет = Предмет.IDпредмет " +
                                                $"WHERE [Номер группы]='{gunaLabel1.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                appraisal.gunaComboBox6.Items.Add(reader[0]);

            reader.Close();
            connection.Close();
        }

        public void PrintFIO(Appraisal appraisal)
        {
            appraisal.gunaComboBox1.Items.Clear();
            SqlCommand command = new SqlCommand($"SELECT Фамилия, Имя, Отчество " +
                                                $"FROM Группа " +
                                                $"INNER JOIN Студент ON Группа.IDгруппы = Студент.IDгруппы " +
                                                $"WHERE [Номер группы]='{gunaLabel1.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                appraisal.gunaComboBox1.Items.Add(reader[0] + " " + reader[1] + " " + reader[2]);

            reader.Close();
            connection.Close();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            CreatePrintFIO(statistics);
            statistics.gunaButton1.Text += "успеваемости";
            statistics.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            CreatePrintFIO(statistics);
            statistics.gunaButton1.Text += "пропусков";
            statistics.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            CreatePrintFIO(statistics);
            statistics.gunaButton1.Text += "отработок";
            statistics.Show();
        }

        public void CreatePrintFIO(Statistics statistics)
        {
            statistics.gunaComboBox1.Items.Clear();
            SqlCommand command = new SqlCommand($"SELECT Фамилия, Имя, Отчество " +
                                                $"FROM Группа " +
                                                $"INNER JOIN Студент ON Группа.IDгруппы = Студент.IDгруппы " +
                                                $"WHERE [Номер группы]='{gunaLabel1.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                statistics.gunaComboBox1.Items.Add(reader[0] + " " + reader[1] + " " + reader[2]);

            reader.Close();
            connection.Close();
        }
    }
}
