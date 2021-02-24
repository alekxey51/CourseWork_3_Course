using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladCourse
{
    public partial class Record : Form
    {
        public OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");
        public Record()
        {
            InitializeComponent();
            this.ActiveControl = gunaLabel1;
        }

        Point lastPoint;
        private void gunaElipsePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void gunaElipsePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxName.Text != "Name" && TextBoxSurname.Text != "Surname" && TextBoxPhone.Text != "Phone" && TextBoxStreet1.Text != "Street")
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Record (rName, rSurname, rStreet, rPhone, rReception, rDate, rServicesStudy, rServicesUltrasound) VALUES ('" + TextBoxName.Text + "', '" + TextBoxSurname.Text + "', '" + TextBoxStreet1.Text + "', '" + TextBoxPhone.Text + "' , '" + gunaComboBox1.Text + "', '" + DateTimeRecord.Text + "', '" + gunaComboBox2.Text + "', '" + gunaComboBox3.Text + "')", myConnection);

                    myConnection.Open();
                    command.ExecuteNonQuery();
                    myConnection.Close();
                    
                    this.Close();
                    MessageBox.Show("Good");
                }
                else
                {
                    if (TextBoxName.Text == "Name")
                        TextBoxName.BorderColor = Color.Red;
                    if (TextBoxSurname.Text == "Surname")
                        TextBoxSurname.BorderColor = Color.Red;
                    if (TextBoxPhone.Text == "Phone")
                        TextBoxPhone.BorderColor = Color.Red;
                    if (TextBoxStreet1.Text == "Street")
                        TextBoxStreet1.BorderColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Name")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = Color.Black;
                TextBoxName.BorderColor = Color.Silver;
            }
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
            {
                TextBoxName.Text = "Name";
                TextBoxName.ForeColor = Color.Gray;
            }
        }

        private void TextBoxSurname_Enter(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "Surname")
            {
                TextBoxSurname.Text = "";
                TextBoxSurname.ForeColor = Color.Black;
                TextBoxSurname.BorderColor = Color.Silver;
            }
        }

        private void TextBoxSurname_Leave(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "")
            {
                TextBoxSurname.Text = "Surname";
                TextBoxSurname.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPhone_Enter(object sender, EventArgs e)
        {
            if (TextBoxPhone.Text == "Phone")
            {
                TextBoxPhone.Text = "";
                TextBoxPhone.ForeColor = Color.Black;
                TextBoxPhone.BorderColor = Color.Silver;
            }

        }

        private void TextBoxPhone_Leave(object sender, EventArgs e)
        {
            if (TextBoxPhone.Text == "")
            {
                TextBoxPhone.Text = "Phone";
                TextBoxPhone.ForeColor = Color.Gray;
            }
        }

        private void TextBoxStreet1_Enter(object sender, EventArgs e)
        {
            if (TextBoxStreet1.Text == "Street")
            {
                TextBoxStreet1.Text = "";
                TextBoxStreet1.ForeColor = Color.Black;
                TextBoxStreet1.BorderColor = Color.Silver;
            }
        }

        private void TextBoxStreet1_Leave(object sender, EventArgs e)
        {
            if (TextBoxStreet1.Text == "")
            {
                TextBoxStreet1.Text = "Street";
                TextBoxStreet1.ForeColor = Color.Gray;
            }
        }
    }
}
