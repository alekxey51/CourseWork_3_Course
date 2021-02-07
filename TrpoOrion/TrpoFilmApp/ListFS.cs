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
    public partial class ListFS : UserControl
    {
        public ListFS()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Home home = new Home();
                OleDbCommand command = new OleDbCommand("DELETE FROM Film WHERE fNameFilm='" + gunaLabel1.Text + "'", home.myConnection);
                home.myConnection.Open();
                command.ExecuteNonQuery();
                home.myConnection.Close();
                this.Hide();

                MessageBox.Show("Delete Good");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSoonFilm_Click(object sender, EventArgs e)
        {
            try
            {
                Home home = new Home();
                OleDbCommand command = new OleDbCommand("DELETE FROM SoonFilm WHERE sNameFilm='" + gunaLabel1.Text + "'", home.myConnection);
                home.myConnection.Open();
                command.ExecuteNonQuery();
                home.myConnection.Close();
                this.Hide();

                MessageBox.Show("Delete Good");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
