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
        public static ObservableCollection<Core.MyDb.Horse> Horse { get; set; }
        public MenuUserPage()
        {
            InitializeComponent();
            IdLbl.Content = App.user.IdEmployee;
            user = App.user;
            LblPost.Content = App.user.Employee.Post;

           // var mainWin = Application.Current.Windows
           //.Cast<Window>()
           //.FirstOrDefault(window => window is MainWindow) as MainWindow;
           // mainWin.MainLabel.Content = "Меню";
            DataContext = user;
        }



        private void HorsesList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListHorsesPage());
                 
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
            var mainWin = Application.Current.Windows
           .Cast<Window>()
           .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "Список заказов";
        }

        private void ProductListBtn_Click(object sender, RoutedEventArgs e)
        {
            var mainWin = Application.Current.Windows
           .Cast<Window>()
           .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "Список продуктов";
        }

        private void AboutUsBtn_Click(object sender, RoutedEventArgs e)
        {
            var mainWin = Application.Current.Windows
           .Cast<Window>()
           .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "О нас";
        }

        private void CreateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrderPage());
            var mainWin = Application.Current.Windows
           .Cast<Window>()
           .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "Сделать заказ";
        }

        private void OurProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OurProductsPage());
            var mainWin = Application.Current.Windows
           .Cast<Window>()
           .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "Наша продукция";
        }

        private void MineOrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            var mainWin = Application.Current.Windows
           .Cast<Window>()
           .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "Мои заказы";
        }

        private void SborkaMilkListBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SborMilkListPage());
        }
    }
}
