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
    /// Interaction logic for SelectCategoryPage.xaml
    /// </summary>
    public partial class SelectCategoryPage : Page
    {
        private Settings _settings;
        private CoffeePage _coffeePage;
        private NonCoffeePage _nonCoffeePage;
        private PastriesPage _pastriesPage;

        public SelectCategoryPage()
        {
            InitializeComponent();

            _settings = new Settings("Big Bucks Coffee - Select Category");
            WindowTitle = _settings.Title;

            _coffeePage = new CoffeePage();
            _nonCoffeePage = new NonCoffeePage();
            _pastriesPage = new PastriesPage();
        }

        private void OnClickCoffee(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(_coffeePage);
        }

        private void OnClickNonCoffee(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(_nonCoffeePage);
        }

        private void OnClickPastries(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(_pastriesPage);
        }
    }
}