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
            AdvertismentsPage advertismentsPage = new AdvertismentsPage();
            MainFrame.Navigate(advertismentsPage);
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.ShowDialog();
        }

        private void FavouritesBtn_Click(object sender, RoutedEventArgs e)
        {
            FavouritesPage favouritesPage = new FavouritesPage();
            MainFrame.Navigate(favouritesPage);
        }

        private void AuthorisationBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.ShowDialog();
            if (authorisationWindow.DialogResult == true)
            {
                AdsBtn.Visibility = Visibility.Visible;
                ProfileBtn.Visibility = Visibility.Visible;
                FavouritesBtn.Visibility = Visibility.Visible;
                AuthorisationBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void AdsBtn_Click(object sender, RoutedEventArgs e)
        {
            AdvertismentsPage advertismentsPages = new AdvertismentsPage();
            MainFrame.Navigate(advertismentsPages);
        }
    }
}
