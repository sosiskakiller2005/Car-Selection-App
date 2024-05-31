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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        CarSelectionEntities _context = App.GetContext();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.Show();
            Close();
        }

        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User() 
            {
                Lastname = LastnameTb.Text,
                Name = NameTb.Text,
                Surname = SurnameTb.Text,
                PhoneNumber = PhoneTb.Text,
                Email = eEmailTb.Text,
                DateOfBirth = (DateTime)DateOfBirthPicker.SelectedDate,
                Login = LoginTb.Text,
                Password = PasswordTb.Password
            };
            _context.User.Add(newUser);
            _context.SaveChanges();
            AuthorisationWindow authorisation = new AuthorisationWindow();
            authorisation.Show();
            Close();

        }
    }
}
