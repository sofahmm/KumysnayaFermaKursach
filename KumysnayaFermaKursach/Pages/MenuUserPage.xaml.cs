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
using KumysnayaFermaKursach.Pages;



namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for MenuUserPage.xaml
    /// </summary>
    public partial class MenuUserPage : Page
    {
        public MenuUserPage()
        {
            InitializeComponent();
        }

        private void HorsesList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListHorsesPage());
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }

        private void ProductListBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AboutUsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrderPage());
        }

        private void OurProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OurProductsPage());
        }

        private void MineOrdersBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
