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
    public partial class ELModel2 : UserControl
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public ELModel2()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            Form1.Instance.mod.Text = gunaLabel1.Text;
            Form1.Instance.printHaracteristic(gunaLabel1.Text);
            Form1.Instance.btnWord.Visible = true;
            Form1.Instance.GlInfo.AutoScroll = true;
            Form1.Instance.GlInfoClose.Visible = false;
        }
    }
}
