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

namespace VovaCourse
{
    public partial class ElCatalog : UserControl
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public ElCatalog()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Height == 42)
                {
                    OleDbCommand command = new OleDbCommand("SELECT Каталог.Название, Раздел.Название " +
                                                            "FROM Каталог " +
                                                            "INNER JOIN Раздел ON Каталог.IDкаталог = Раздел.IDкаталог " +
                                                            $"WHERE Каталог.Название = '{gunaLabel1.Text}'", connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ElSection Item = new ElSection();
                        Item.Dock = DockStyle.Top;
                        Item.gunaLabel1.Text = reader[1].ToString();
                        flowLayoutPanel1.Controls.Add(Item);
                        this.Height += 30;
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    this.Height = 42;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}
