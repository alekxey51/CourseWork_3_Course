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
using System.IO;

namespace VlabBukatkin
{
    public partial class DishControl : UserControl
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public DishControl()
        {
            InitializeComponent();
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            PrintRecipe($"SELECT * FROM Recipe WHERE IDrecipe = {IDdish.Text}");
            WidthPanel();
        }

        private void WidthPanel()
        {
            if (Home.Instance.Width == 640)
            {
                Home.Instance.Width = 853;
                Home.Instance.gunaPanel5.Visible = true;
            }
            else
            {
                Home.Instance.Width = 640;
                Home.Instance.gunaPanel5.Visible = false;
            }
        }

        public void PrintRecipe(string inquiry)
        {
            OleDbCommand command = new OleDbCommand(inquiry, myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                InfoDish Item = new InfoDish();

                byte[] Photo = (byte[])(reader[1]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaPictureBox2.Image = Image.FromStream(memoryStream);

                Item.IDdishinfo.Text = $"{reader[0]}";
                Item.gunaLabel2.Text = $"{reader[2]}";
                Item.gunaLabel5.Text = $"{reader[3]} мин.";
                Item.gunaLabel6.Text = $"{reader[4]} персону";

                Item.label1.Text = $"{reader[5]}";
                Item.label6.Text = $"{reader[6]}";
                Item.label2.Text = $"{reader[7]}";
                Item.label7.Text = $"{reader[8]}";
                Item.label3.Text = $"{reader[9]}";
                Item.label8.Text = $"{reader[10]}";
                Item.label4.Text = $"{reader[11]}";
                Item.label9.Text = $"{reader[12]}";
                Item.label5.Text = $"{reader[13]}";
                Item.label10.Text = $"{reader[14]}";

                Item.label11.Text = $"{reader[15]}";

                Home.Instance.gunaPanel5.Controls.Add(Item);
                Item.Dock = DockStyle.Fill;
                Item.BringToFront();

            }
            reader.Close();
            myConnection.Close();
        }

        private void NameDish_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("DELETE FROM Recipe WHERE IDrecipe='" + IDdish.Text + "'", myConnection);
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }
    }
}
