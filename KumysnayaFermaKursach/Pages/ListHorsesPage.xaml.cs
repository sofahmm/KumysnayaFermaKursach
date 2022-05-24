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
        public static Horse horse { get; set; }
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
            var poroda = SortPoroda.SelectedItem as Poroda;
            HorsesLV.ItemsSource = SortData.SortHorseBreed(poroda);
        }

        private void AddHorseBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddHorsePage());
        }

        private void dopInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreInfoHorseListPage());
        }

        private void sbrosBtn_Click(object sender, RoutedEventArgs e)
        {
            HorsesLV.ItemsSource = ToGetData.GetHorses();
        }
    }
}
