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
    public partial class ElThing : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public ElThing()
        {
            InitializeComponent();
        }

        private void ElThing_Click(object sender, EventArgs e)
        {
            string[] FIO = Thing.Instance1.gunaLabel1.Text.Split();
            SqlCommand command = new SqlCommand($"SELECT Студент.Фамилия, Предмет.Название, Журнал.Дата, Журнал.Оценка, Журнал.Нка, Журнал.Практика, Журнал.Отработка, Журнал.IDжурнал " +
                                                $"FROM Студент " +
                                                $"INNER JOIN Журнал ON dbo.Студент.IDстудент = Журнал.IDстудент " +
                                                $"INNER JOIN Предмет ON Журнал.IDпредмет = Предмет.IDпредмет " +
                                                $"WHERE Студент.Фамилия = '{FIO[0]}' AND Предмет.Название = '{gunaLabel1.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Thing.Instance1.flowLayoutPanel2.Controls.Clear();

            while (reader.Read())
            {
                ElInfoThing Item = new ElInfoThing();
                Item.gunaLabel7.Text = reader[7].ToString();
                Item.gunaLabel2.Text = reader[1].ToString();
                Item.gunaLabel3.Text = reader[2].ToString();
                if(reader[3].ToString() != "")
                    Item.gunaLabel4.Text = reader[3].ToString();
                else if(reader[4].ToString() != "")
                    Item.gunaLabel4.Text = reader[4].ToString();
                Item.gunaLabel5.Text = reader[5].ToString();
                Item.gunaLabel6.Text = reader[6].ToString();
                if (Thing.Instance1.gunaLabel1.Width != 160)
                    Item.gunaLabel1.Visible = false;
                Thing.Instance1.flowLayoutPanel2.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void ElThing_Load(object sender, EventArgs e)
        {

        }
    }
}
