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

namespace VlabBukatkin
{
    public partial class InfoControl : UserControl
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public InfoControl()
        {
            InitializeComponent();
            PrintRefrigerator();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem.ToString());
            try
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO Refrigerator (IDuser, Name) " +
                                                        $"VALUES ({Convert.ToInt32(Home.Instance.IDuser)}, '{listBox2.SelectedItem}')", myConnection);
                
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }

        private void PrintRefrigerator()
        {
            OleDbCommand command = new OleDbCommand($"SELECT * FROM Refrigerator WHERE IDuser = {Convert.ToInt32(Home.Instance.IDuser)}", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[2].ToString());
            }
            reader.Close();
            myConnection.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand($"DELETE FROM Refrigerator" +
                                                        $" WHERE IDuser = {Convert.ToInt32(Home.Instance.IDuser)} and Name = '{listBox1.SelectedItem}'", myConnection);
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }
    }
}
