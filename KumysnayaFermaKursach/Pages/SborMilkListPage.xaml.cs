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
using Excel = Microsoft.Office.Interop.Excel;


namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for SborMilkListPage.xaml
    /// </summary>
    public partial class SborMilkListPage : Page
    {
        ObservableCollection<StatusSbora> sbor { get; set; }
        public SborMilkListPage()
        {
            InitializeComponent();
            var milk = ToGetData.GetSborMilks();
            sbor = new ObservableCollection<StatusSbora>(DbConnection.fermaEntities.StatusSbora.ToList());
            //statusCb.ItemsSource = ToGetData.GetStatusSbora();
            HorsesLV.ItemsSource = milk;
            this.DataContext = this;
        }

        private void addSbor_Click(object sender, RoutedEventArgs e)
        {
            SborMolokaWindow sborMolokaWindow = new SborMolokaWindow();
            sborMolokaWindow.Show();
        }

        private void searchDataTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = Convert.ToInt32(searchDataTb.Text);
            HorsesLV.ItemsSource = SearchData.SearchSborMilksIdH(a);
        }

        private void dataSearchDP_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime dat = Convert.ToDateTime(dataSearchDP.SelectedDate);
            HorsesLV.ItemsSource = SearchData.SearchSborMilksDate(dat);
        }

        private void sbrosit_Click(object sender, RoutedEventArgs e)
        {
            var tt = ToGetData.GetSborMilks();
            HorsesLV.ItemsSource = tt;
        }
    }
}