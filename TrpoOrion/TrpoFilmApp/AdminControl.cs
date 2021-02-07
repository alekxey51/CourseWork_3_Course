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

namespace TrpoFilmApp
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();

            _obj = this;
        }

        static AdminControl _obj;
        public static AdminControl Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new AdminControl();
                }
                return _obj;
            }
        }

        public Panel panel
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public FlowLayoutPanel PnlSoonFilm
        {
            get { return flowLayoutPanel2; }
            set { flowLayoutPanel2 = value; }
        }

        public FlowLayoutPanel PnlFilm
        {
            get { return flowLayoutPanel1; }
            set { flowLayoutPanel1 = value; }
        }

        private void btnAddFilm_Click_1(object sender, EventArgs e)
        {
            AddFilm addFilm = new AddFilm();
            addFilm.btnAddFilm.Visible = true;
            addFilm.TextBoxPremiereWorld.Value = DateTime.Now;
            addFilm.TextBoxPremiereRF.Value = DateTime.Now;
            addFilm.Show();
        }

        private void btnAddSerial_Click(object sender, EventArgs e)
        {
            AddFilm addFilm = new AddFilm();
            addFilm.btnAddSoonFilm.Visible = true;
            addFilm.btnAddSoonFilm.Location = new Point(293, 388);
            addFilm.TextBoxPremiereWorld.Value = DateTime.Now;
            addFilm.TextBoxPremiereRF.Value = DateTime.Now;
            addFilm.Show();
        }

        
    }
}
