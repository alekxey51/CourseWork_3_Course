using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;

namespace CureSuch
{

    public partial class MainWindow : Window
    {
        string connection = @"Server=DESKTOP-KSIPHVB\SQLEXPRESS;Initial Catalog=KURSACH1;Trusted_Connection=True;";
        SqlConnection connect = null;
        public static string idUser;

        public MainWindow()
        {
            InitializeComponent();
            connect = new SqlConnection(connection);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("SELECT IdUser, Login, Password FROM Users WHERE Login = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'", connect);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                idUser = dt.Rows[0][0].ToString();
                if(dt.Rows.Count != 1)
                {
                    MessageBox.Show("Пользователь не найден");
                }
                else
                {
                    Hide();
                    Window1 win = new Window1(txtUsername.Text, txtPassword.Text, idUser);
                    win.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void TxtUsermame_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
