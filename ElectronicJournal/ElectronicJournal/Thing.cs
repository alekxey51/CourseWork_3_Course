using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicJournal
{
    public partial class Thing : UserControl
    {
        public Thing()
        {
            InitializeComponent();
            _obj1 = this;
        }

        static Thing _obj1;
        public static Thing Instance1
        {
            get
            {
                if (_obj1 == null)
                {
                    _obj1 = new Thing();
                }
                return _obj1;
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Form1.Instance.Controls.RemoveAt(0);
            AdminGroup Item = new AdminGroup();
            Item.Dock = DockStyle.Fill;
            Form1.Instance.PrintGroup(Item);
            Form1.Instance.Controls.Add(Item);
        }
    }
}
