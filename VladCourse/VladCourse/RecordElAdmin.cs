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
    public partial class RecordElAdmin : UserControl
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public RecordElAdmin()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if(this.Size == new Size(671, 178))
                this.Size = new Size(671, 38);
            else
                this.Size = new Size(671, 178);
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("DELETE FROM Record WHERE rStreet='" + gunaLabel13.Text + "' AND rPhone='"+ gunaLabel14.Text + "'", myConnection);
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
    }
}
