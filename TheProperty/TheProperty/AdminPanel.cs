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
    public partial class AdminPanel : UserControl
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");
        public AdminPanel()
        {
            InitializeComponent();
            _obj = this;
        }

        static AdminPanel _obj;
        public static AdminPanel Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new AdminPanel();
                }
                return _obj;
            }
        }

        public TableLayoutPanel table
        {
            get { return LayoutPanel1; }
            set { LayoutPanel1 = value; }
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM Announcement", connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            AdminPanel.Instance.table.Controls.Clear();
            while (reader.Read())
            {
                ElProperty Item = new ElProperty();

                byte[] Photo = (byte[])(reader[16]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaPictureBox2.Image = Image.FromStream(memoryStream);

                Item.gunaLabel1.Text = $"{reader[5]}к    {reader[10]} / {reader[11]} м";
                Item.gunaLabel2.Text = $"{reader[4]} / {reader[3]}";
                Item.gunaLabel3.Text = reader[2].ToString();
                Item.IDLabel.Text = reader[0].ToString();

                AdminPanel.Instance.table.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }
    }
}
