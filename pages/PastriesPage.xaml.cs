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
    /// Interaction logic for PastriesPage.xaml
    /// </summary>
    public partial class PastriesPage : Page
    {
        private Settings _settings;
        private IMenuItemRepo _pastriesRepo;

        public PastriesPage()
        {
            InitializeComponent();
            _settings = new Settings("Big Bucks Coffee - Pastries");
            WindowTitle = _settings.Title;

            _pastriesRepo = new PastriesRepo();
            var menuItems = _pastriesRepo.GetMenuItems();
            GenerateControlsForMenuItems(menuItems);
        }

        private void GenerateControlsForMenuItems(IEnumerable<IMenuItem> menuItems)
        {
            foreach (IMenuItem menuItem in menuItems)
            {
                UserControl1 userControl1 = new UserControl1
                {
                    MenuItemId = menuItem.Id,
                    Image = menuItem.Image,
                    MyProductName = menuItem.Name,
                    Price = menuItem.Price,
                };

                PastriesPageWrap.Children.Add(userControl1);
            }
        }
    }
}