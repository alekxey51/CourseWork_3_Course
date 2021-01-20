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

namespace CourseTheCar
{
    public partial class MarkControl : UserControl
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public MarkControl()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand($"SELECT Марка.Название, Марка.История, Модель.Название " +
                                                        $"FROM Марка " +
                                                        $"INNER JOIN Модель ON Марка.Код = Модель.Код " +
                                                        $"WHERE Марка.Название = '{LabelMark.Text}'", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ElControlModel Item = new ElControlModel();
                    Item.Size = new Size(144, 21);
                    Item.Dock = DockStyle.Top;
                    Item.gunaLabel1.Text = "• " + reader[2].ToString();
                    Form1.Instance.Model.Controls.Add(Item);
                    Form1.Instance.ChistoryMark.Text = reader[1].ToString();
                }
                reader.Close();
                connection.Close();

                Form1.Instance.PanelListMark.Visible = true;
                Form1.Instance.ListContent.Text += $" ({LabelMark.Text})";
                Form1.Instance.ListContent.Location = new Point(38, 9);
                Form1.Instance.button.Visible = true;
                Form1.Instance.Models.Text = $"Модельный ряд {LabelMark.Text}";
            }
            catch { connection.Close(); }
        }
    }
}
