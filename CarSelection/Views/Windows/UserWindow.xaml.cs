using CarSelection.Model;
using CarSelection.Views.Pages;
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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow(User selectedUser)
        {
            InitializeComponent();
        }
        public UserWindow()
        {
            InitializeComponent();

        }

        private void AuthorisationBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.ShowDialog();
            if (authorisationWindow.DialogResult == true)
            {
                LoggedFrame loggedFrame = new LoggedFrame();
                AuthorisationBtn.Visibility = Visibility.Collapsed;
                ProfileBtn.Visibility = Visibility.Visible;
                AdsBtn.Visibility = Visibility.Visible;
            }
        }
    }
}
