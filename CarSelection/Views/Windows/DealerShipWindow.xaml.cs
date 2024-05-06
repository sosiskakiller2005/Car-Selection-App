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
    /// Логика взаимодействия для DealerShipWindow.xaml
    /// </summary>
    public partial class DealerShipWindow : Window
    {
        CarSelectionEntities _context = App.GetContext();
        public DealerShipWindow(DealerShip selectedDealership)
        {
            InitializeComponent();
            DealerShipGrid.DataContext = selectedDealership;
            List<Advertisement> advertisements = _context.Advertisement.Where(ad => ad.DealerShipId == selectedDealership.Id).ToList();
            AdsLv.ItemsSource = advertisements;
        }

        private void AdsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
