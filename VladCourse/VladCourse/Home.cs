using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladCourse
{
    public partial class Home : Form
    {
        string UserName;
        string UserPass;
        public OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public Home(string Name, string Pass)
        {
            InitializeComponent();
            if (Name.ToLower() == "admin" && Pass.ToLower() == "admin")
                AdminControl.Visible = true;
            UserName = Name;
            UserPass = Pass;
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.RemoveAt(0);
            DoctorsControl doctorsControl = new DoctorsControl();
            if(UserName.ToLower() == "admin" && UserPass.ToLower() == "admin")
                doctorsControl.AddBox.Visible = true;
            PrintDoctor(doctorsControl);
            HomePanel.Controls.Add(doctorsControl);
            doctorsControl.Show();
            doctorsControl.Dock = DockStyle.Fill;
            doctorsControl.BringToFront();
        }

        private void PrintDoctor(DoctorsControl doctorsControl)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Doctor]", myConnection);
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DoctorEl Item = new DoctorEl();

                    if (UserName.ToLower() == "admin" && UserPass.ToLower() == "admin")
                    {
                        Item.btnDelete.Visible = true;
                    }

                    byte[] Photo = (byte[])(reader[0]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    Item.PictureBox.Image = Image.FromStream(memoryStream);
                    Item.NameProfesion.Text = reader[1].ToString();
                    doctorsControl.tableLayoutPanel1.Controls.Add(Item);
                }
                reader.Close();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.RemoveAt(0);
            ServicesControls servicesControls = new ServicesControls();
            if (UserName.ToLower() == "admin" && UserPass.ToLower() == "admin")
            {
                servicesControls.AddBox1.Visible = true;
                servicesControls.AddBox2.Visible = true;
                servicesControls.AddBox3.Visible = true;
            }
            HomePanel.Controls.Add(servicesControls);
            servicesControls.Show();
            servicesControls.Dock = DockStyle.Fill;
            servicesControls.BringToFront();

            PrintServices(servicesControls);
            PrintServicesStudy(servicesControls);
            PrintServicesUltrasound(servicesControls);
        }

        private void PrintServices(ServicesControls servicesControls)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Services]", myConnection);
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ServicesEl Item = new ServicesEl();
                    if (UserName.ToLower() == "admin" && UserPass.ToLower() == "admin")
                    {
                        Item.btnDelete1.Visible = true;
                        Item.btnDelete1.Location = new Point(627, 6);
                    }
                    Item.gunaLabel1.Text = reader[0].ToString();
                    Item.gunaLabel2.Text = reader[1].ToString();
                    servicesControls.flowLayoutPanel1.Controls.Add(Item);
                }
                reader.Close();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }
        }

        private void PrintServicesStudy(ServicesControls servicesControls)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [ServicesStudy]", myConnection);
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ServicesEl Item = new ServicesEl();

                    if (UserName.ToLower() == "admin" && UserPass.ToLower() == "admin")
                    {
                        Item.btnDelete2.Visible = true;
                        Item.btnDelete2.Location = new Point(627, 6);
                    }

                    Item.gunaLabel1.Text = reader[0].ToString();
                    Item.gunaLabel2.Text = reader[1].ToString();
                    servicesControls.flowLayoutPanel2.Controls.Add(Item);
                }
                reader.Close();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }
        }
        private void PrintServicesUltrasound(ServicesControls servicesControls)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [ServicesUltrasound]", myConnection);
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ServicesEl Item = new ServicesEl();
                    if (UserName.ToLower() == "admin" && UserPass.ToLower() == "admin")
                    {
                        Item.btnDelete3.Visible = true;
                        Item.btnDelete3.Location = new Point(627, 6);
                    }
                    Item.gunaLabel1.Text = reader[0].ToString();
                    Item.gunaLabel2.Text = reader[1].ToString();
                    servicesControls.flowLayoutPanel3.Controls.Add(Item);
                }
                reader.Close();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Services]", myConnection);
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                Record record = new Record();

                while (reader.Read())
                {
                    string str = reader[0].ToString() + " | " + reader[1].ToString() + " руб";
                    record.gunaComboBox1.Items.Add(str);
                }

                command = new OleDbCommand("SELECT * FROM [ServicesStudy]", myConnection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string str = reader[0].ToString() + " | " + reader[1].ToString() + " руб";
                    record.gunaComboBox2.Items.Add(str);
                }

                command = new OleDbCommand("SELECT * FROM [ServicesUltrasound]", myConnection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string str = reader[0].ToString() + " | " + reader[1].ToString() + " руб";
                    record.gunaComboBox3.Items.Add(str);
                }

                record.ShowDialog();
                reader.Close();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }
        }

        private void btnAdminRecord_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.RemoveAt(0);
            RecordControlAdmin recordControlAdmin = new RecordControlAdmin();

            HomePanel.Controls.Add(recordControlAdmin);
            recordControlAdmin.Show();
            recordControlAdmin.Dock = DockStyle.Fill;
            recordControlAdmin.BringToFront();

            PrintAdminRecord(recordControlAdmin);
        }

        private void PrintAdminRecord(RecordControlAdmin recordControlAdmin)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Record]", myConnection);
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RecordElAdmin Item = new RecordElAdmin();
                    Item.gunaLabel2.Text = reader[0].ToString() + " " + reader[1].ToString();
                    Item.gunaLabel6.Text = reader[5].ToString();
                    Item.gunaLabel13.Text = reader[2].ToString();
                    Item.gunaLabel14.Text = reader[3].ToString();
                    Item.gunaLabel12.Text = reader[4].ToString();
                    Item.gunaLabel15.Text = reader[6].ToString();
                    Item.gunaLabel10.Text = reader[7].ToString();
                    Item.Size = new Size(671, 38);
                    recordControlAdmin.flowLayoutPanel1.Controls.Add(Item);
                }
                reader.Close();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ReferenceSystem reference = new ReferenceSystem();
            reference.Show();
        }
    }
}
