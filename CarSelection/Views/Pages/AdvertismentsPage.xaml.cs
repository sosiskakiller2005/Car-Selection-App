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
    /// Логика взаимодействия для AdvertismentsPage.xaml
    /// </summary>
    public partial class AdvertismentsPage : Page
    {
        private CarSelectionEntities _context = App.GetContext();
        Advertisement _selectedAd;

        public AdvertismentsPage()
        {
            InitializeComponent();
            #region Заполнение комбобксов
            AdsLv.ItemsSource = _context.Advertisement.ToList();
            List<Brand> brands = _context.Brand.ToList();
            brands.Insert(0, new Brand { Name = "Все марки" });
            BrandsCmb.ItemsSource = brands;
            BrandsCmb.DisplayMemberPath = "Name";
            BrandsCmb.SelectedIndex = 0;

            List<Body> bodys = _context.Body.ToList();
            bodys.Insert(0, new Body { Name = "Все кузовы" });
            BodysCmb.ItemsSource = bodys;
            BodysCmb.DisplayMemberPath = "Name";
            BodysCmb.SelectedIndex = 0;

            List<TypeOfFuel> typesOfFuel = _context.TypeOfFuel.ToList();
            typesOfFuel.Insert(0, new TypeOfFuel { Name = "Все двигатели" });
            EngineTypesCmb.ItemsSource = typesOfFuel;
            EngineTypesCmb.DisplayMemberPath = "Name";
            EngineTypesCmb.SelectedIndex = 0;
            #endregion
        }
        private void Filter()
        {
            List<Advertisement> filteredAds = _context.Advertisement.ToList();
            if (BrandsCmb.SelectedIndex != 0)
            {
                if (BodysCmb.SelectedIndex != 0)
                {
                    if (EngineTypesCmb.SelectedIndex != 0)
                    {
                        filteredAds = filteredAds.Where(ad => ad.Car.Brand == BrandsCmb.SelectedItem && ad.Car.Body == BodysCmb.SelectedItem && ad.Car.Engine.TypeOfFuel == EngineTypesCmb.SelectedItem).ToList();
                    }
                    else
                    {
                        filteredAds = filteredAds.Where(ad => ad.Car.Brand == BrandsCmb.SelectedItem && ad.Car.Body == BodysCmb.SelectedItem).ToList();
                    }
                }
                else
                {
                    if (EngineTypesCmb.SelectedIndex != 0)
                    {
                        filteredAds = filteredAds.Where(ad => ad.Car.Brand == BrandsCmb.SelectedItem && ad.Car.Engine.TypeOfFuel == EngineTypesCmb.SelectedItem).ToList();
                    }
                    else
                    {
                        filteredAds = filteredAds.Where(ad => ad.Car.Brand == BrandsCmb.SelectedItem).ToList();
                    }
                }
            }
            else
            {
                if (BodysCmb.SelectedIndex != 0)
                {
                    if (EngineTypesCmb.SelectedIndex != 0)
                    {
                        filteredAds = filteredAds.Where(ad => ad.Car.Body == BodysCmb.SelectedItem && ad.Car.Engine.TypeOfFuel == EngineTypesCmb.SelectedItem).ToList();
                    }
                    else
                    {
                        filteredAds = filteredAds.Where(ad => ad.Car.Body == BodysCmb.SelectedItem).ToList();
                    }
                }
                else
                {
                    if (EngineTypesCmb.SelectedIndex != 0)
                    {
                        filteredAds = filteredAds.Where(ad => ad.Car.Engine.TypeOfFuel == EngineTypesCmb.SelectedItem).ToList();
                    }
                }
            }
            AdsLv.ItemsSource = filteredAds;
        }

        private void adsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedAd = AdsLv.SelectedItem as Advertisement;
            CarWindow carWindow = new CarWindow(_selectedAd);
            carWindow.ShowDialog();
        }


        private void BrandsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void BodysCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }


        private void EngineTypesCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

    }
}
