using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrpoFilmApp;

namespace ORION
{
    public partial class InfoFilm2 : UserControl
    {
        public InfoFilm2()
        {
            InitializeComponent();
            gunaPictureBox4.Location = new Point(gunaPictureBox2.Location.X, 39);
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            gunaPictureBox3.Location = gunaPictureBox2.Location;
            gunaPictureBox2.Visible = false;
            gunaPictureBox3.Visible = true;
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            gunaPictureBox2.Visible = true;
            gunaPictureBox3.Visible = false;
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            gunaPictureBox5.Location = gunaPictureBox4.Location;
            gunaPictureBox4.Visible = false;
            gunaPictureBox5.Visible = true;
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            gunaPictureBox4.Visible = true;
            gunaPictureBox5.Visible = false;
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            gunaLabel12.Location = new Point(191, 189);
            gunaPictureBox6.Visible = false;
            gunaLabel12.Visible = true;
        }
    }
}
