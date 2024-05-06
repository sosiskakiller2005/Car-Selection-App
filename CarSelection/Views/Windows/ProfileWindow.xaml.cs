using BusTrips.Assets;
using CarSelection.Assets;
using CarSelection.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        User selectedUser = Transporter.SelectedUser;
        CarSelectionEntities _context = App.GetContext();
        public ProfileWindow()
        {
            InitializeComponent();
            ProfileGrid.DataContext = Transporter.SelectedUser;
            SaveBtn.Visibility = Visibility.Collapsed;

        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {

            SaveBtn.Visibility = Visibility.Visible;
            if (selectedUser.Lastname == LastnameTb.Text && selectedUser.Name == NameTb.Text && selectedUser.Surname == SurnameTb.Text &&
                selectedUser.PhoneNumber == PhoneNumberTb.Text && selectedUser.Email == EmailTb.Text &&
                selectedUser.Login == LoginTb.Text && selectedUser.Password == PasswrodTb.Text )
            {
                SaveBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxHelper.Question("Отменить изменения?") == true)
            {
                Close();
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxHelper.Question("Сохранить изменения") == true)
            {
                selectedUser.Lastname = LastnameTb.Text;
                selectedUser.Name = NameTb.Text;
                selectedUser.Surname = SurnameTb.Text;
                selectedUser.PhoneNumber = PhoneNumberTb.Text;
                selectedUser.Email = EmailTb.Text;
                selectedUser.Login = LoginTb.Text;
                selectedUser.Password = PasswrodTb.Text;
                _context.SaveChanges();
            }           
        }
    }
}
