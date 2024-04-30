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
        public CarWindow(Advertisement selectedAd)
        {
            InitializeComponent();
            AdGrid.DataContext = selectedAd;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
