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
    /// Interaction logic for AddHorsePage.xaml
    /// </summary>
    public partial class AddHorsePage : Page
    {
        public static Core.MyDb.Horse horse { get; set; }
        public static ObservableCollection<Poroda> poroda { get; set; }
        public AddHorsePage()
        {
            InitializeComponent();
            poroda = new ObservableCollection<Poroda>(DbConnection.fermaEntities.Poroda.ToList());
            //horseTypes = new ObservableCollection<HorseType>(DbConnection.fermaEntities.HorseType.ToList());
            //porodaCB.ItemsSource = ToGetData.GetBreeds();
            TypeCB.ItemsSource = ToGetData.GetHorseTypes();
            this.DataContext = this;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dopInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreInfoHorsePage());
            var mainWin = Application.Current.Windows
            .Cast<Window>()
            .FirstOrDefault(window => window is MainWindow) as MainWindow;
            mainWin.MainLabel.Content = "Дополнительная информация";
        }
    }
}
