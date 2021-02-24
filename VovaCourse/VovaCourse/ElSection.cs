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

namespace VovaCourse
{
    public partial class ElSection : UserControl
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public ElSection()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2.Instance.Product.Controls.Clear();
                OleDbCommand command = new OleDbCommand("SELECT IDтовар, Товар.Название, Photo " +
                                                        "FROM Раздел " +
                                                        "INNER JOIN Товар ON Раздел.IDраздел = Товар.IDраздел " +
                                                        $"WHERE Раздел.Название = '{gunaLabel1.Text}'", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ElProduct Item = new ElProduct();

                    byte[] Photo = (byte[])(reader[2]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    Item.gunaPictureBox2.Image = Image.FromStream(memoryStream);
                    Item.gunaLabel2.Text = $"{reader[1]}";
                    Item.ID.Text = $"{reader[0]}";
                    Form2.Instance.Product.Controls.Add(Item);
                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}
