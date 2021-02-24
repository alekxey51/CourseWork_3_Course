using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VovaCourse
{
    public partial class ReferenceSystem : Form
    {
        public ReferenceSystem()
        {
            InitializeComponent();
            gunaPanel7.Height = 34;
            gunaPanel1.Height = 34;
            gunaPanel3.Height = 34;
            gunaPanel5.Height = 34;
            gunaPanel9.Height = 34;
            gunaPanel11.Height = 34;
            gunaPanel13.Height = 34;
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            if (gunaPanel7.Height == 34) gunaPanel7.Height = 131;
            else gunaPanel7.Height = 34;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if (gunaPanel1.Height == 34) gunaPanel1.Height = 227;
            else gunaPanel1.Height = 34;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            if (gunaPanel3.Height == 34) gunaPanel3.Height = 404;
            else gunaPanel3.Height = 34;
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            if (gunaPanel5.Height == 34) gunaPanel5.Height = 336;
            else gunaPanel5.Height = 34;
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            if (gunaPanel9.Height == 34) gunaPanel9.Height = 357;
            else gunaPanel9.Height = 34;
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            if (gunaPanel11.Height == 34) gunaPanel11.Height = 85;
            else gunaPanel11.Height = 34;
        }

        private void gunaPictureBox10_Click(object sender, EventArgs e)
        {
            if (gunaPanel13.Height == 34) gunaPanel13.Height = 186;
            else gunaPanel13.Height = 34;
        }
    }
}
