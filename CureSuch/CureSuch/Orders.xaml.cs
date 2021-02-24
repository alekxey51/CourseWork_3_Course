using System.Data.SqlClient;
using System.Windows;

namespace CureSuch
{
    public partial class Orders : Window
    {
        string connection = @"Server=DESKTOP-KSIPHVB\SQLEXPRESS;Initial Catalog=KURSACH1;Trusted_Connection=True;";
        SqlConnection connect = null;
        
        
        public Orders()
        {
            InitializeComponent();
            connect = new SqlConnection(connection);
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT Orders.IdOrder, Orders.[Date], Dress.[Name], Dress.DescriptionShort, Dress.DescriptionLong, Dress.Price FROM Orders INNER JOIN Dress ON(Orders.IdDress = Dress.IdDress) INNER JOIN Users ON(Orders.IdUser =  Users.IdUser) WHERE Orders.IdUser = '" + MainWindow.idUser + "'", connect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    string IdOrder = reader["IdOrder"].ToString();
                    string date = reader["Date"].ToString();
                    string name = reader["Name"].ToString();
                    string descriptionShort = reader["DescriptionShort"].ToString();
                    string descriptionLong = reader["DescriptionLong"].ToString();
                    string price = reader["Price"].ToString();

                    Order ord = new Order(IdOrder, name, date, descriptionShort, descriptionLong, price);

                    dataGrid.Items.Add(ord);
                }
            }
        }

        private void CureName_LostFocus(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(CureName.Text))
            {
                CureName.Visibility = System.Windows.Visibility.Collapsed;
                Whatermark.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Whatermark_GotFocus(object sender, RoutedEventArgs e)
        {
            Whatermark.Visibility = System.Windows.Visibility.Collapsed;
            CureName.Visibility = System.Windows.Visibility.Visible;
            CureName.Focus();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы отменили заказ");
        }
    }
}
