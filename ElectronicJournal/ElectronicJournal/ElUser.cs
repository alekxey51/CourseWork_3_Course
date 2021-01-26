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
    public partial class ElUser : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public ElUser()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            string[] FIO = gunaLabel1.Text.Split();
            Form1.Instance.surname = FIO[0];
            Form1.Instance.year = gunaLabel2.Text;
            Form1.Instance.group = GroupUser.Instance.gunaLabel1.Text;

            Form1.Instance.Controls.RemoveAt(0);
            Thing Item = new Thing();
            Item.Dock = DockStyle.Fill;
            Form1.Instance.PrintThing(Item);
            Form1.Instance.PrintName(Item);
            Form1.Instance.Controls.Add(Item);
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] FIO = gunaLabel1.Text.Split();
                SqlCommand command = new SqlCommand($"DELETE FROM Студент WHERE Фамилия='{FIO[0]}' and Имя='{FIO[1]}' and Отчество='{FIO[2]}' and [Дата рождения]='{gunaLabel2.Text}'", connection);
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
