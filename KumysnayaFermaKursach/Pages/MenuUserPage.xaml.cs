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
using Core.MyDb;
using System.Collections.ObjectModel;
using Core.DB;

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for MenuUserPage.xaml
    /// </summary>
    public partial class MenuUserPage : Page
    {
        
        public static Core.MyDb.User user { get; set; }
        //public static ObservableCollection<Core.MyDb.Horse> Horse { get; set; }
        public MenuUserPage()
        {
            InitializeComponent();
            IdLbl.Content = App.user.IdEmployee;
            user = App.user;
            LblPost.Content = App.user.Employee.Post.Name;

            // var mainWin = Application.Current.Windows
            //.Cast<Window>()
            //.FirstOrDefault(window => window is MainWindow) as MainWindow;
            // mainWin.MainLabel.Content = "Меню";
            ToGetData.NewItemAddedEvent += RefreshPage;
            DataContext = user;
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
            NavigationService.Navigate(new ReportsPage());
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

        private void SborkaMilkListBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SborMilkListPage());
        }
        public void RefreshPage()
        {
            Dispatcher.Invoke(()=>
            lblHours.GetBindingExpression(Label.ContentProperty)
                      .UpdateTarget());
            //lblHours.Content = App.user.Employee.AmountHours;
        }
    }
}
