using Core.MyDb;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for EditOrderPage.xaml
    /// </summary>
    public partial class EditOrderPage : Page
    {
        public static Order order { get; set; }
        public EditOrderPage(Order order1)
        {
            InitializeComponent();
            order = order1;
            DataContext = this;
            AmountTb.Text = order1.Amount.ToString();
            FirstNameTb.Text = order1.FullNameCustomer;
            NameProductLbl.Content = order1.Product.Name;
            if (order1.IdSposobOplat == 1)
            {
                bankKardCb.IsChecked = true;
                nalichCb.IsChecked = false;
            }


            else if (order1.IdSposobOplat == 2)
            {
                nalichCb.IsChecked = true;
                bankKardCb.IsChecked = false;
            }
            DateTb.SelectedDate = order1.Date;
            PhoneNumber.Text = order1.PhoneNumber;
            SumLbl.Content = order1.Sum;
        }

        private void createOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            var ord = new Order();
            ord.Oformlenie = true;
            Core.DB.DbConnection.fermaEntities.SaveChanges();
            NavigationService.GoBack();
        }

        private void chernovikBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AmountTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
