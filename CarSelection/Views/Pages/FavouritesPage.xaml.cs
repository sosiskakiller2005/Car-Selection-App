using CarSelection.Assets;
using CarSelection.Model;
using CarSelection.Views.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarSelection.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для FavouritesBtn.xaml
    /// </summary>
    public partial class FavouritesPage : Page
    {
        private CarSelectionEntities _context = App.GetContext();
        Favourites _selectedAd;
        public FavouritesPage()
        {
            InitializeComponent();
            Update();
        }
        /// <summary>
        /// Метод для обновления списка избранных
        /// </summary>
        private void Update()
        {
            List<Favourites> favourites = _context.Favourites.Where(f => f.UserId == Transporter.SelectedUser.Id).ToList();
            FavLv.ItemsSource = favourites;
        }

        private void FavLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FavLv.SelectedItem != null)
            {
                _selectedAd = FavLv.SelectedItem as Favourites;
                CarWindow carWindow = new CarWindow(_selectedAd.Advertisement);
                carWindow.ShowDialog();
                if (carWindow.DialogResult == true)
                {
                    Update();
                }
            }
        }
    }
}
