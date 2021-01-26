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
    public partial class addGroup : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public addGroup()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Text == "Добавить группу")
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Группа ([Номер группы]) VALUES ('" + TextBoxGroup.Text + "')", connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Группы добавлена");
                    Group group = new Group();
                    group.gunaLabel1.Text = TextBoxGroup.Text;
                    AdminGroup.Instance.tableLayoutPanel1.Controls.Add(group);
                }
                else
                {
                    SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT Название FROM Предмет " +
                                                                    "WHERE Название='" + TextBoxGroup.Text + "'", connection);
                    DataTable dataTable = new DataTable();
                    DataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count != 1)
                    {
                        AddPredmet();
                    }
                    addPredmetGroup();
                    MessageBox.Show("Предмет добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        public void AddPredmet()
        {
            SqlCommand command = new SqlCommand("INSERT INTO Предмет (Название) VALUES ('" + TextBoxGroup.Text + "')", connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void addPredmetGroup()
        {
            SqlCommand command1 = new SqlCommand($"SELECT IDгруппы FROM Группа WHERE [Номер группы] ='{GroupUser.Instance.gunaLabel1.Text}'", connection);
            connection.Open();
            SqlDataReader reader = command1.ExecuteReader();
            reader.Read();
            int idгруппы = Convert.ToInt32(reader[0].ToString());
            reader.Close();

            command1 = new SqlCommand($"SELECT IDпредмет FROM Предмет WHERE Название ='{TextBoxGroup.Text}'", connection);
            reader = command1.ExecuteReader();
            reader.Read();
            int idпредмет = Convert.ToInt32(reader[0].ToString());
            reader.Close();

            SqlCommand command = new SqlCommand("INSERT INTO Расписание (IDгруппы, IDпредмет) VALUES ('" + idгруппы + "', '" + idпредмет + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
