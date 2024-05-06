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
    /// Логика взаимодействия для CarWindow.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        Advertisement _selectedAd;
        CarSelectionEntities _context = App.GetContext();
        public CarWindow(Advertisement selectedAd)
        {
            InitializeComponent();
            _selectedAd = selectedAd;
            AdGrid.DataContext = selectedAd;
            CarNameTbl.DataContext = selectedAd;
            if (Transporter.SelectedUser != null)
            {
                if (_context.Favourites.Any(f => f.AdvertismentId == _selectedAd.Id && f.UserId == Transporter.SelectedUser.Id) == true)
                {
                    BitmapImage redIcon = new BitmapImage();
                    redIcon.BeginInit();
                    redIcon.UriSource = new Uri("C:\\Users\\user\\source\\repos\\CarSelection\\CarSelection\\Resources\\red-heart-icon.png");
                    redIcon.EndInit();
                    iconImage.Source = redIcon;
                }
                else
                {
                    BitmapImage whiteIcon = new BitmapImage();
                    whiteIcon.BeginInit();
                    whiteIcon.UriSource = new Uri("C:\\Users\\user\\source\\repos\\CarSelection\\CarSelection\\Resources\\white-heart-icon.jpg");
                    whiteIcon.EndInit();
                    iconImage.Source = whiteIcon;
                }
            }

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            DealerShipWindow dealerShipWindow = new DealerShipWindow(_selectedAd.Car.DealerShip);
            dealerShipWindow.ShowDialog();    
        }

        private void FavouriteBtn_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage whiteIcon = new BitmapImage();
            whiteIcon.BeginInit();
            whiteIcon.UriSource = new Uri("C:\\Users\\user\\source\\repos\\CarSelection\\CarSelection\\Resources\\white-heart-icon.jpg");
            whiteIcon.EndInit();
            BitmapImage redIcon = new BitmapImage();
            redIcon.BeginInit();
            redIcon.UriSource = new Uri("C:\\Users\\user\\source\\repos\\CarSelection\\CarSelection\\Resources\\red-heart-icon.png");
            redIcon.EndInit();
             
            if (Transporter.SelectedUser != null)
            {
                Favourites newFavourite = new Favourites()
                {
                    UserId = Transporter.SelectedUser.Id,
                    AdvertismentId = _selectedAd.Id                
                };

                if (_context.Favourites.Any(f => f.UserId == newFavourite.UserId && f.AdvertismentId == newFavourite.AdvertismentId))
                {
                    Favourites selectedFavourite = _context.Favourites.FirstOrDefault(f => f.AdvertismentId == _selectedAd.Id && f.UserId == Transporter.SelectedUser.Id);
                    _context.Favourites.Remove(selectedFavourite);
                    iconImage.Source = whiteIcon;
                    DialogResult = true;
                    MessageBox.Show("Удалено из избранных");
                }
                else
                {
                    _context.Favourites.Add(newFavourite);
                    MessageBox.Show("Добавлено в избранные");
                    iconImage.Source = redIcon;
                }
                _context.SaveChanges();
            }
            else
            {
                MessageBoxHelper.Error("Войдите, чтобы добавить объявление в избранные");
            }
        }
    }
}
