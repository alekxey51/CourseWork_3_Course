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

namespace TheProperty
{
    public partial class ElProperty : UserControl
    {
        public OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public ElProperty()
        {
            InitializeComponent();
        }

        public Image image(OleDbDataReader reader, int num)
        {
            byte[] Photo = (byte[])(reader[num]);
            MemoryStream memoryStream = new MemoryStream(Photo);
            return Image.FromStream(memoryStream);
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Form1.Instance.Search.Location = new Point(60, 11);
            Form1.Instance.tableLayout.Visible = false;
            try
            {
                OleDbCommand command = new OleDbCommand($"SELECT * FROM Announcement WHERE idAnnouncement={IDLabel.Text}", myConnection);
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                InfoProperty info = new InfoProperty();
                Form1.Instance.Info.Controls.Add(info);
                info.Dock = DockStyle.Fill;

                while (reader.Read())
                {
                    info.gunaPictureBox1.Image = image(reader, 16);
                    info.gunaPictureBox2.Image = image(reader, 16);
                    info.gunaPictureBox3.Image = image(reader, 17); 
                    info.gunaPictureBox4.Image = image(reader, 18); 
                    info.gunaPictureBox5.Image = image(reader, 19);
                    info.gunaLabel10.Text = $"Сутки {reader[14]} р. / 30 дней {reader[15]} р.";
                    info.gunaLabel8.Text = $"{reader[5]}-комнатная квартира";
                    info.gunaLabel9.Text = reader[7].ToString();
                    info.gunaLabel13.Text = reader[9].ToString();
                    info.gunaLabel12.Text = reader[8].ToString();
                    info.gunaLabel11.Text = reader[13].ToString();
                    info.gunaLabel7.Text = $"{reader[4]} / {reader[3]}";
                    info.gunaLabel6.Text = $"{reader[11]} м2";
                    info.gunaLabel5.Text = $"{reader[10]} м2";
                }

                reader.Close();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }

        }
    }
}
