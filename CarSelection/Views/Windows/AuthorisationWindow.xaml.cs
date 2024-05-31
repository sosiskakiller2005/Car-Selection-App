using BusTrips.Assets;
using CarSelection.Assets;
using CarSelection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarSelection.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        private CarSelectionEntities _context = App.GetContext();
        public AuthorisationWindow()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = _context.User.ToList();

            if (LoginTb.Text == "" && PasswordTb.Password == "")
            {
                MessageBoxHelper.Error("Введите логин и пароль");
            }
            else if (LoginTb.Text == "")
            {
                MessageBoxHelper.Error("Введите логин");
            }
            else if (PasswordTb.Password == "")
            {
                MessageBoxHelper.Error("Введите пароль");
            }
            else
            {
                string login = LoginTb.Text;
                string password = PasswordTb.Password;
                foreach (User user in users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        Transporter.SelectedUser = user;
                        DialogResult = true;
                        this.Close();
                        break;                    }
                    else if (user.Login == login & user.Password != password)
                    {
                        MessageBoxHelper.Error("Неправильно введен пароль");
                        DialogResult = true;
                        break;
                    }
                    if (DialogResult == false)
                    {
                        MessageBoxHelper.Error("Пользователь с таким логином не найден");
                    }
                }
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
    }
}
