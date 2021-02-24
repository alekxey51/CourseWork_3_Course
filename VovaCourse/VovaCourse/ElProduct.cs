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
    public partial class ElProduct : UserControl
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public ElProduct()
        {
            InitializeComponent();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand($"SELECT * FROM Товар WHERE IDтовар = {ID.Text}", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                Form2.Instance.InfoPanel.Visible = false;

                while (reader.Read())
                {
                    byte[] Photo = (byte[])(reader[6]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    Form2.Instance.PictureBox.Image = Image.FromStream(memoryStream);
                    Form2.Instance.NameProduct.Text = $"{reader[2]}";
                    Form2.Instance.IDProduct.Text = $"ID  00{reader[0]}";
                    Form2.Instance.ManufacturerProduct.Text = $"{reader[3]}";
                    Form2.Instance.PriceProduct.Text = $"{reader[4]} p.";
                    Form2.Instance.CountProduct.Text = $"{reader[5]} шт";
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}
