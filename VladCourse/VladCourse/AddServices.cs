using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladCourse
{
    public partial class AddServices : Form
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public AddServices()
        {
            InitializeComponent();
        }

        public void Add(string s)
        {
            try
            {
                if (TextBoxServices.Text != "" && TextBoxPrice.Text != "")
                {
                    OleDbCommand command = new OleDbCommand(s, myConnection);

                    myConnection.Open();
                    command.ExecuteNonQuery();
                    myConnection.Close();

                    this.Close();
                    MessageBox.Show("Good");
                }
                else
                {
                    TextBoxServices.BorderColor = Color.Red;
                    TextBoxPrice.BorderColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            Add("INSERT INTO Services (sName, sPrice) VALUES ('" + TextBoxServices.Text + "', '" + TextBoxPrice.Text + "')");
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            Add("INSERT INTO ServicesStudy (sName, sPrice) VALUES ('" + TextBoxServices.Text + "', '" + TextBoxPrice.Text + "')");
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            Add("INSERT INTO ServicesUltrasound (sName, sPrice) VALUES ('" + TextBoxServices.Text + "', '" + TextBoxPrice.Text + "')");
        }
    }
}
