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
    public partial class AdminGroup : UserControl
    {
        public AdminGroup()
        {
            InitializeComponent();
            _obj3 = this;
        }

        static AdminGroup _obj3;
        public static AdminGroup Instance
        {
            get
            {
                if (_obj3 == null)
                {
                    _obj3 = new AdminGroup();
                }
                return _obj3;
            }
        }

        private void gunaElipsePanel1_Click(object sender, EventArgs e)
        {
            addGroup addGroup1 = new addGroup();
            addGroup1.Show();
        }
    }
}
