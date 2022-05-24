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
        Horse horse;
        public static ObservableCollection<Poroda> poroda { get; set; }
        public AddHorsePage()
        {
            InitializeComponent();
            poroda = new ObservableCollection<Poroda>(DbConnection.fermaEntities.Poroda.ToList());
            TypeCB.ItemsSource = ToGetData.GetHorseTypes();
            this.DataContext = this;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            var h = new Horse();   
            h.Name = nameTxt.Text;
            h.Birthdate = DateTb.SelectedDate;
            var poroda = porodaCB.SelectedItem as Poroda;
            h.IdPoroda = poroda.ID;
            var type = TypeCB.SelectedItem as HorseType;
            h.IdType = type.ID;
            AddData.AddHorse(h);
            NavigationService.GoBack();
        }

       
    }
}
