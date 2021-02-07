using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORION;
using System.Data.OleDb;

namespace TrpoFilmApp
{
    public partial class FilmEl : UserControl
    {
        public OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public FilmEl()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            BuySubscription buySubscription = new BuySubscription();
            buySubscription.Show();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            try
            { 
                if (this.PictureBoxFilm.Cursor == Cursors.Hand)
                {
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [Film] WHERE fNameFilm='" + this.NaneLableFilm.Text + "'", myConnection);
                    myConnection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    InfoFilm2 infoFilm2 = new InfoFilm2();
                    Home.Instance.PnlContainer.Controls.Add(infoFilm2);

                    infoFilm2.gunaPictureBox1.Image = this.PictureBoxFilm.Image;
                    
                    while (reader.Read())
                    {
                        //информация
                        infoFilm2.gunaLabel1.Text = reader[1].ToString(); //название
                        infoFilm2.gunaLabel2.Text += reader[2].ToString()+" г."; //год
                        infoFilm2.gunaLabel3.Text += reader[3].ToString(); //страна
                        infoFilm2.gunaLabel6.Text += reader[9].ToString()+" $"; //сборы сша
                        infoFilm2.gunaLabel8.Text += reader[10].ToString()+" $"; //сборы мир
                        infoFilm2.gunaLabel9.Text += reader[11].ToString(); //премьера мир
                        infoFilm2.gunaLabel11.Text += reader[12].ToString(); //премьера рф
                        infoFilm2.gunaLabel10.Text += reader[13].ToString()+"+"; //возраст
                        infoFilm2.gunaLabel4.Text += reader[4].ToString(); //рейтинг
                        infoFilm2.gunaLabel5.Text += reader[5].ToString()+" мин"; //время

                        //описание
                        infoFilm2.gunaLabel7.Text = reader[6].ToString();
                    }

                    infoFilm2.Dock = DockStyle.Fill;
                    Home.Instance.PnlContainer.Controls["InfoFilm2"].BringToFront();

                    Home.Instance.button.Visible = true;
                    Home.Instance.pnlSearch.Location = new Point(66, 11);
                    reader.Close();
                    myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }

        private void PictureBoxSoonFilm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.PictureBoxSoonFilm.Cursor == Cursors.Hand)
                {
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [SoonFilm] WHERE sNameFilm='" + this.NaneLableFilm.Text + "'", myConnection);
                    myConnection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    InfoFilm2 infoFilm2 = new InfoFilm2();
                    Home.Instance.PnlContainer.Controls.Add(infoFilm2);

                    infoFilm2.gunaPictureBox1.Image = this.PictureBoxSoonFilm.Image;

                    while (reader.Read())
                    {
                        //информация
                        infoFilm2.gunaLabel1.Text = reader[1].ToString(); //название
                        infoFilm2.gunaLabel2.Text += reader[2].ToString(); //год
                        infoFilm2.gunaLabel3.Text += reader[3].ToString(); //страна
                        infoFilm2.gunaLabel6.Text += reader[9].ToString() + " $"; //сборы сша
                        infoFilm2.gunaLabel8.Text += reader[10].ToString() + " $"; //сборы мир
                        infoFilm2.gunaLabel9.Text += reader[11].ToString(); //премьера мир
                        infoFilm2.gunaLabel11.Text += reader[12].ToString(); //премьера рф
                        infoFilm2.gunaLabel10.Text += reader[13].ToString() + "+"; //возраст
                        infoFilm2.gunaLabel4.Text += reader[4].ToString(); //рейтинг
                        infoFilm2.gunaLabel5.Text += reader[5].ToString() + " мин"; //время

                        infoFilm2.DataPrimere.Text = (Convert.ToDateTime(reader[12]) - DateTime.Now).Days.ToString() + " дней";
                        infoFilm2.TimePremere.Text = (Convert.ToDateTime(reader[12]) - DateTime.Now).Hours.ToString() + ":"+ (Convert.ToDateTime(reader[12]) - DateTime.Now).Minutes.ToString() + ":"+ (Convert.ToDateTime(reader[12]) - DateTime.Now).Seconds.ToString();

                        //описание
                        infoFilm2.gunaLabel7.Text = reader[6].ToString();
                    }

                    infoFilm2.InfoPrimerPanel.Visible = true;
                    
                    infoFilm2.Dock = DockStyle.Fill;
                    Home.Instance.PnlContainer.Controls["InfoFilm2"].BringToFront();

                    Home.Instance.button.Visible = true;
                    Home.Instance.pnlSearch.Location = new Point(66, 11);
                    reader.Close();
                    myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }
    }
}
