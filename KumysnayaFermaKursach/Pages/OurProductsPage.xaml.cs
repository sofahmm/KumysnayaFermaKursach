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
using Core.MyDb;
using Core.DB;

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for OurProductsPage.xaml
    /// </summary>
    public partial class OurProductsPage : Page
    {
        public OurProductsPage()
        {
            InitializeComponent();
        }

        private void CreateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            var category = ToGetData.GetProductCategory("Выпечка");
            NavigationService.Navigate(new AddOrderPage(category));
        }

        private void CreateOrderBtn2_Click(object sender, RoutedEventArgs e)
        {
            var category = ToGetData.GetProductCategory("Кумыс");
            NavigationService.Navigate(new AddOrderPage(category));
        }

        private void CreateOrderBtn3_Click(object sender, RoutedEventArgs e)
        {
            var category = ToGetData.GetProductCategory("Курт");
            NavigationService.Navigate(new AddOrderPage(category));
        }
    }
}
