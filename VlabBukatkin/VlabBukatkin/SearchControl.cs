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
    public partial class SearchControl : UserControl
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public SearchControl()
        {
            InitializeComponent();
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PrintRecipe($"SELECT * FROM Recipe WHERE rCooking <= {15}");
        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PrintRecipe($"SELECT * FROM Recipe WHERE rCooking <= {30}");
        }

        private void gunaRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PrintRecipe($"SELECT * FROM Recipe WHERE rCooking <= {45}");
        }

        private void gunaRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            PrintRecipe($"SELECT * FROM Recipe WHERE rCooking <= {60}");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PrintRecipe($"SELECT * FROM Recipe WHERE rName = '{TextBoxSearch.Text}'");
        }

        public void PrintRecipe(string inquiry)
        {
            OleDbCommand command = new OleDbCommand(inquiry, myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            Home.Instance.tableLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                DishControl Item = new DishControl();

                byte[] Photo = (byte[])(reader[1]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaPictureBox6.Image = Image.FromStream(memoryStream);

                Item.IDdish.Text = $"{reader[0]}";
                Item.NameDish.Text = $"{reader[2]}";

                Home.Instance.tableLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            myConnection.Close();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            PrintRecipe("SELECT * FROM Recipe");
            if (gunaRadioButton1.Checked == true)
                gunaRadioButton1.Checked = false;
            if (gunaRadioButton2.Checked == true)
                gunaRadioButton2.Checked = false;
            if (gunaRadioButton3.Checked == true)
                gunaRadioButton3.Checked = false;
            if (gunaRadioButton4.Checked == true)
                gunaRadioButton4.Checked = false;
        }
    }
}
