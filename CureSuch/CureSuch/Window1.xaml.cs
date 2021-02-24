using System;
using System.Windows;
using System.Data.SqlClient;
using System.Data;

namespace CureSuch
{
    public partial class Window1 : Window
    {
        public string UserLogin;
        public string UserPassword;
        public string UserId;
        string IdDrug;
        string connection = @"Server=DESKTOP-KSIPHVB\SQLEXPRESS;Initial Catalog=KURSACH1;Trusted_Connection=True;";
        SqlConnection connect = null;
        SqlCommand command = null;
        SqlDataReader reader = null;

        public Window1(string login, string password, string userId)
        {
            InitializeComponent();
            UserLogin = login;
            UserPassword = password;
            UserId = userId;
            connect = new SqlConnection(connection);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connect.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Dress", connect);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                IdDrug = dt.Rows[Название.SelectedIndex][0].ToString();
                
                string date = DateTime.Now.ToString();
                SqlCommand addCommand = new SqlCommand("INSERT INTO Orders (IdUser, [Date], IdDress) VALUES ('" + Convert.ToInt32(UserId) + "', '" + date + "', '" + Convert.ToInt32(IdDrug) + "')", connect);
                addCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Заказ успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Заказ не добавлен");
            }
        }

        private void MyOrders_Click(object sender, RoutedEventArgs e)
        {
            Orders ord = new Orders();
            ord.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Dress", connect);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                IdDrug = dt.Rows[2][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(IdDrug);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Spravka spr = new Spravka();
            spr.Show();
        }
    }
}
