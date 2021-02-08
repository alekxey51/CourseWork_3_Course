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
    public partial class InfoDish : UserControl
    {
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public InfoDish()
        {
            InitializeComponent();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Favorites (IDuser, IDRecipe) " +
                                                        $"VALUES ({Convert.ToInt32(Home.Instance.IDuser)}, {Convert.ToInt32(IDdishinfo.Text)})", myConnection);

            myConnection.Open();
            command.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Рецепт добавлен в избранное");
        }

        int count = 0;
        private void gunaButton7_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand($"SELECT Name FROM Refrigerator WHERE IDuser = {Convert.ToInt32(Home.Instance.IDuser)}", myConnection);
            myConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string[] arr = new string[] { label1.Text, label2.Text, label3.Text, label4.Text, label5.Text };
            List<string> listNew = new List<string>();

            while (reader.Read()) { listNew.Add(reader[0].ToString()); }

            for(int i = 0; i < arr.Length; i++)
                for (int j = 0; j< listNew.Count; j++)
                    if(arr[i] == listNew[j])
                    {
                        count++;
                        break;
                    }

            if(count >= 5) { MessageBox.Show("У вас есть все ингредиенты"); }
            else { MessageBox.Show("У вас не хватает ингредиентов"); }

            listNew.Clear();
            count = 0;

            reader.Close();
            myConnection.Close();
        }
    }
}
