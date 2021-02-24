using System;
using System.Windows;
using System.Data.SqlClient;

namespace CureSuch
{
    public partial class Registration : Window
    {
        string connection = @"Server=DESKTOP-KSIPHVB\SQLEXPRESS;Initial Catalog=KURSACH1;Trusted_Connection=True;";
        public Registration()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (txtName.Text == "")
                    throw new Exception("Введите Имя");
                else if (!Char.IsUpper(txtName.Text[0]))
                    throw new Exception("Ошибка! Имя с маленикой буквы");
                else if (txtSurname.Text == "")
                    throw new Exception("Введите Фамилию");
                else if (!Char.IsUpper(txtSurname.Text[0]))
                    throw new Exception("Ошибка! Фамилия с маленикой буквы");
                else if (txtAdress.Text == "")
                    throw new Exception("Введите Адрес");
                else if (!Char.IsUpper(txtName.Text[0]))
                    throw new Exception("Ошибка! Адрес с маленикой буквы");
                else if (txtLogin.Text == "")
                    throw new Exception("Введите Логин");
                else if (txtPassword.Text.Length < 6)
                    throw new Exception("Пароль должен содержать минимум 6 символов.");
                else
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Users ([Login], [Password], [Name], Surname, Adress) VALUES ('" + txtLogin.Text + "', '" + txtPassword.Text + "', '" + txtName.Text + "', '" + txtSurname.Text + "' , '" + txtAdress.Text + "')", con);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Вы зарегестрировались");
                    this.Hide();
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
