using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ElectronicJournal
{
    public partial class Group : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public Group()
        {
            InitializeComponent();
        }

        private void gunaElipsePanel1_Click(object sender, EventArgs e)
        {
            Form1.Instance.Controls.RemoveAt(0);
            GroupUser Item = new GroupUser();
            Item.gunaLabel1.Text = this.gunaLabel1.Text;
            Item.Dock = DockStyle.Fill;
            PrintUserGroup(Item);
            Form1.Instance.Controls.Add(Item);
        }

        public void PrintUserGroup(GroupUser Item)
        {
            SqlCommand command = new SqlCommand($"SELECT Студент.Фамилия, Студент.Имя, Студент.Отчество, Студент.[Дата рождения] " +
                                                $"FROM Студент " +
                                                $"INNER JOIN Группа ON Студент.IDгруппы = Группа.IDгруппы " +
                                                $"WHERE Группа.[Номер группы] ='{gunaLabel1.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Item.flowLayoutPanel1.Controls.Clear();
            Random rand = new Random();
            while (reader.Read())
            {
                ElUser Item1 = new ElUser();
                Item1.gunaLabel1.Text = reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                Item1.gunaLabel4.Text = rand.Next(0, 10).ToString();
                Item1.gunaLabel5.Text = rand.Next(0, 10).ToString();
                Item1.gunaLabel2.Text = reader[3].ToString();
                Item.flowLayoutPanel1.Controls.Add(Item1);
            }
            reader.Close();
            connection.Close();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Группа WHERE [Номер группы]='{gunaLabel1.Text}'", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.Hide();
                MessageBox.Show("Delete Good");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge");
            }
        }
    }
}
