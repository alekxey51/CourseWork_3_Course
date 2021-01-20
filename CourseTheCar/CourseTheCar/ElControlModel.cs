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

namespace CourseTheCar
{
    public partial class ElControlModel : UserControl
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public ElControlModel()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Height == 21)
                {
                    OleDbCommand command = new OleDbCommand($"SELECT Модель.Название, Модификацы " +
                                                            $"FROM Модель " +
                                                            $"INNER JOIN Модификацыя ON Модель.IDмодель = Модификацыя.IDмодель " +
                                                            $"WHERE Модель.Название = '{gunaLabel1.Text.Replace("•", "").Replace(" ", "")}'", connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ELModel2 Item = new ELModel2();
                        Item.Dock = DockStyle.Top;
                        Item.gunaLabel1.Text = reader[1].ToString();
                        flowLayoutPanel1.Controls.Add(Item);
                        this.Height += 26;
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    this.Height = 21;
                }
            }
            catch
            {
                connection.Close();
            }
        }
    }
}
