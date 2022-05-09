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
            DataContext = this;
        }

        private void SortAge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SortPoroda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SortType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddHorseBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddHorsePage());
        }
    }
}
