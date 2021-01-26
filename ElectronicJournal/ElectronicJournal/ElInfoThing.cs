using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicJournal
{
    public partial class ElInfoThing : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=410-013;Initial Catalog=BDCourse;Integrated Security=True");

        public ElInfoThing()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Журнал WHERE IDжурнал='{gunaLabel7.Text}'", connection);
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
