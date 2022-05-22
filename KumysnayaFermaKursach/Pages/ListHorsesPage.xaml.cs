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
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for ListHorsesPage.xaml
    /// </summary>
    public partial class ListHorsesPage : Page
    {
        public ListHorsesPage()
        {
            InitializeComponent();
            var horses = ToGetData.GetHorses();
            HorsesLV.ItemsSource = horses;
            SortPoroda.ItemsSource = ToGetData.GetBreeds();
            DataContext = this;
        }


        private void SortPoroda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /* DateTime dat = Convert.ToDateTime(dataSearchDP.SelectedDate);
            HorsesLV.ItemsSource = DbConnection.fermaEntities.SborMilk.Where(d => d.Date == dat).ToList();
        }*/
            var poroda = SortPoroda.SelectedItem;
            var n = new Poroda();
            HorsesLV.ItemsSource = DbConnection.fermaEntities.Horse.Where(d => d.Poroda.Name == poroda).ToList();
        }

        private void SortType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddHorseBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddHorsePage());
            var mainWin = Application.Current.Windows
            .Cast<Window>()
            .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "Добавить лошадь ";
        }

        private void dopInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreInfoHorseListPage());
        }

    }
}
