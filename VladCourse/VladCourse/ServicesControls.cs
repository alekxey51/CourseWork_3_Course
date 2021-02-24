using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladCourse
{
    public partial class ServicesControls : UserControl
    {
        public ServicesControls()
        {
            InitializeComponent();
        }

        private void AddBox1_Click(object sender, EventArgs e)
        {
            AddServices addServices = new AddServices();
            addServices.btnAdd1.Location = new Point(99, 83);
            addServices.btnAdd1.Visible = true;
            addServices.ShowDialog();
        }

        private void AddBox2_Click(object sender, EventArgs e)
        {
            AddServices addServices = new AddServices();
            addServices.btnAdd2.Location = new Point(99, 83);
            addServices.btnAdd2.Visible = true;
            addServices.ShowDialog();
        }

        private void AddBox3_Click(object sender, EventArgs e)
        {
            AddServices addServices = new AddServices();
            addServices.btnAdd3.Location = new Point(99, 83);
            addServices.btnAdd3.Visible = true;
            addServices.ShowDialog();
        }
    }
}
