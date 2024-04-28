using CarSelection.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CarSelection
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static CarSelectionEntities _context;
        public static CarSelectionEntities GetContext()
        {
            if (_context == null)
            {
                _context = new CarSelectionEntities();
            }
            return _context;
        }
    }
}
