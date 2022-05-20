using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        public static ObservableCollection<Product> product { get; set; }
        public AddOrderPage()
        {
            InitializeComponent();
            product = new ObservableCollection<Product>(DbConnection.fermaEntities.Product.ToList());
            this.DataContext = this;
            var ordd = ToGetData.GetOrders();

            //int t = Convert.ToInt32(AmountTb.Text)*
            //llblUnit.Content = 
            //NameProductCb.ItemsSource = ToGetData.GetProducts();
        }
        public AddOrderPage(ProductCategory category)
        {
            product = new ObservableCollection<Product>(DbConnection.fermaEntities.Product
                                    .Where(p => p.IdProductCategory == category.ID).ToList());
            InitializeComponent();
            this.DataContext = this;
            var ordd = ToGetData.GetOrders();
        }

        private void chernovikBtn_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order();
            order.FullNameCustomer = FirstNameTb.Text;
            var product = NameProductCb.SelectedItem as Product;
            order.IdProduct = product.ID;
            order.Amount = Convert.ToInt32(AmountTb.Text);
            order.Date = DateTb.SelectedDate;
            order.Sum = Convert.ToInt32(SumLbl.Content);
            if (bankKardCb.IsChecked == true)
                order.IdSposobOplat = 1;
            else if (nalichCb.IsChecked == true)
                order.IdSposobOplat = 2;
            order.IdStatusOrder = 1;
            var unit = llblUnit.Content as Unit;
            order.IdUnit = unit.ID;
            order.PhoneNumber = PhoneNumber.Text;
            order.Oformlenie = false;
            ToGetData.AddOrder(order);
        }

        private void createOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order();
            order.FullNameCustomer = FirstNameTb.Text;
            var product = NameProductCb.SelectedItem as Product;
            order.IdProduct = product.ID;
            order.Amount = Convert.ToInt32(AmountTb.Text);
            order.Date = DateTb.SelectedDate;
            order.Sum = Convert.ToInt32(SumLbl.Content);
            if (bankKardCb.IsChecked == true)
                order.IdSposobOplat = 1;
            else if (nalichCb.IsChecked == true)
                order.IdSposobOplat = 2;
            order.IdStatusOrder = 5;
            var unit = llblUnit.Content as Unit;
            order.IdUnit = unit.ID;
            order.PhoneNumber = PhoneNumber.Text;
            order.Oformlenie = true;
            ToGetData.AddOrder(order);
        }

        private void AmountTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var pr = new Product();
            //var t = Convert.ToInt32(AmountTb.Text) * pr.Amount;
            var selCb = NameProductCb.SelectedItem as Product;
                SumLbl.Content =selCb.Amount * int.Parse(AmountTb.Text);
        }
    }
}
