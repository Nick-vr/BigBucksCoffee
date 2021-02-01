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
using System.Text.RegularExpressions;

namespace BigBucksCoffee
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public int MenuItemId { get; set; }

        private string _image;

        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                ProductImg.Source = new BitmapImage(new Uri(Image, UriKind.Relative));
            }
        }

        public string MyProductName
        {
            get { return (string)ProductName.Content; }
            set { ProductName.Content = value; }
        }

        public double Price
        {
            get { return (double)ProductPrice.Content; }
            set { ProductPrice.Content = value; }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        // Event Handler -> Raise an event from a child class
        // Delegate field -> Accepts a method instead of a value or instance
        public event EventHandler AddToCartButtonClicked;

        protected virtual void OnAddToCartButtonClicked(EventArgs e)
        {
            AddToCartButtonClicked?.Invoke(this, e);
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            // Pass child event to parent by raising it in an event which can be caught in parent
            OnAddToCartButtonClicked(e);
        }
    }
}