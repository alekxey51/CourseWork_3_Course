using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VladCourse
{
    public partial class ServicesEl : UserControl
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");
        public ServicesEl()
        {
            InitializeComponent();
        }

        public void Delete(string s)
        {
            try
            {
                OleDbCommand command = new OleDbCommand(s, myConnection);
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete("DELETE FROM Services WHERE sName='" + gunaLabel1.Text + "'");
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            Delete("DELETE FROM ServicesStudy WHERE sName='" + gunaLabel1.Text + "'");
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            Delete("DELETE FROM ServicesUltrasound WHERE sName='" + gunaLabel1.Text + "'");
        }
    }
}
