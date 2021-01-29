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

namespace BigBucksCoffee
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private Settings _settings;

        public Home()
        {
            InitializeComponent();
            _settings = new Settings("Big Bucks Coffee");
            WindowTitle = _settings.Title;
        }

        private void OnClickHomeImage(object sender, RoutedEventArgs e)
        {
            SelectCategoryPage selectCategoryPage = new SelectCategoryPage();
            NavigationService.Navigate(selectCategoryPage);
        }
    }
}