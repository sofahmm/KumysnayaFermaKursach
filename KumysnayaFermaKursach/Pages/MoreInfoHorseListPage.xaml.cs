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
    /// Interaction logic for MoreInfoHorseListPage.xaml
    /// </summary>
    public partial class MoreInfoHorseListPage : Page
    {
        public MoreInfoHorseListPage()
        {
            InitializeComponent();
            HorsesLV.ItemsSource = ToGetData.GetMoreInfoHorse();
            sortIDHorseCb.ItemsSource = ToGetData.GetHorses();

            this.DataContext = this;

        }

        private void AddHorseInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreInfoHorsePage());

        }

        private void sortIDHorseCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /* var poroda = SortPoroda.SelectedItem as Poroda;
            var n = new Poroda();
            HorsesLV.ItemsSource = DbConnection.fermaEntities.Horse.Where(d => d.Poroda.Name == poroda.Name).ToList();*/
            var idHorse = sortIDHorseCb.SelectedItem as Horse;
            HorsesLV.ItemsSource = SortData.SortDopInfoIdHorse(idHorse);
        }

        private void sbrosBtn_Click(object sender, RoutedEventArgs e)
        {
            HorsesLV.ItemsSource = ToGetData.GetMoreInfoHorse();
        }
    }
}
