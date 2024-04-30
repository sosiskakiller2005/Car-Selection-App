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
        private CarSelectionEntities _context = App.GetContext();
        public UserWindow(User selectedUser)
        {
            InitializeComponent();
        }
        public UserWindow()
        {
            InitializeComponent();
            adsLv.ItemsSource = _context.Advertisement.ToList();

        }

        private void AuthorisationBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.ShowDialog();
            if (authorisationWindow.DialogResult == true)
            {
                AuthorisationBtn.Visibility = Visibility.Collapsed;
                ProfileBtn.Visibility = Visibility.Visible;
                AdsBtn.Visibility = Visibility.Visible;
                FavouriteAdsBtn.Visibility = Visibility.Visible;
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void adsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Advertisement selectedAd = adsLv.SelectedItem as Advertisement;
            CarWindow carWindow = new CarWindow(selectedAd);
            carWindow.ShowDialog();
        }
    }
}
