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

namespace VladCourse
{
    public partial class DoctorsControl : UserControl
    {
        
        public DoctorsControl()
        {
            InitializeComponent();
        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.ShowDialog();
        }

    }
}
