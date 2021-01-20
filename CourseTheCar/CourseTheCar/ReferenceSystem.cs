using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseTheCar
{
    public partial class ReferenceSystem : Form
    {
        public ReferenceSystem()
        {
            InitializeComponent();
            gunaPanel1.Height = 34;
            gunaPanel3.Height = 34;
            gunaPanel5.Height = 34;
            gunaPanel7.Height = 34;
            gunaPanel9.Height = 34;
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            if(gunaPanel7.Height == 34) gunaPanel7.Height = 186;
            else gunaPanel7.Height = 34;
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            if (gunaPanel9.Height == 34) gunaPanel9.Height = 139;
            else gunaPanel9.Height = 34;
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            if (gunaPanel5.Height == 34) gunaPanel5.Height = 410;
            else gunaPanel5.Height = 34;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            if (gunaPanel3.Height == 34) gunaPanel3.Height = 556;
            else gunaPanel3.Height = 34;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if (gunaPanel1.Height == 34) gunaPanel1.Height = 85;
            else gunaPanel1.Height = 34;
        }
    }
}
