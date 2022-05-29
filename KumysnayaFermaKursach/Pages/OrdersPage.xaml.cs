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
using Core.DB;
using Core.MyDb;

namespace KumysnayaFermaKursach
{
    /// <summary>
    /// Interaction logic for OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            var order = ToGetData.GetOrders();
          
            if (App.klient != null)        
                OrdersLV.ItemsSource = order.Where(x => x.PhoneNumber == App.klient.PhoneNumber).ToList();
            else
                OrdersLV.ItemsSource = order;

           
            statusOrderCb.ItemsSource = ToGetData.GetStatusOrders();
            sortProductCb.ItemsSource = ToGetData.GetProducts();
            DataContext = this;
            changedBtn.Visibility = Visibility.Hidden;
        }

        private void sortProductCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var product = sortProductCb.SelectedItem as Product;
            OrdersLV.ItemsSource = SortData.SortOrdeProductName(product);
        }

        private void statusOrderCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var status = statusOrderCb.SelectedItem as StatusOrder;
            OrdersLV.ItemsSource = SortData.SortStatusOrder(status);
        }

        private void sbrosBtn_Click(object sender, RoutedEventArgs e)
        {
            OrdersLV.ItemsSource = ToGetData.GetOrders();
        }

        private void changedBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
