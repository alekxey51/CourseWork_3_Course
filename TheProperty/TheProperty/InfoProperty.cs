using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheProperty
{
    public partial class InfoProperty : UserControl
    {
        public InfoProperty()
        {
            InitializeComponent();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Image = gunaPictureBox2.Image;
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Image = gunaPictureBox4.Image;
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Image = gunaPictureBox3.Image;
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Image = gunaPictureBox5.Image;
        }
    }
}
