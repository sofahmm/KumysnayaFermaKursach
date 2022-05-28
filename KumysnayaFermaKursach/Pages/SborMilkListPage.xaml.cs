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

        private void OtchetBtn_Click(object sender, RoutedEventArgs e)
        {
            var allSborMoloka = ToGetData.GetHorses().OrderBy(p => p.ID).ToList();

            var application = new Excel.Application();
            application.SheetsInNewWorkbook = allSborMoloka.Count();

            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            int startRowIndex = 1;
            for(int i= 0; i < allSborMoloka.Count(); i++)
            {
                Excel.Worksheet worksheet = application.Worksheets.Item[i + 1];
                
                worksheet.Name = allSborMoloka[i].ID.ToString();

                worksheet.Cells[1][startRowIndex] = "Дата";
                worksheet.Cells[2][startRowIndex] = "Лошадь";
                worksheet.Cells[3][startRowIndex] = "Бак";
                worksheet.Cells[4][startRowIndex] = "Консистенция";
                worksheet.Cells[5][startRowIndex] = "Цвет";
                worksheet.Cells[6][startRowIndex] = "Статус";

                startRowIndex++;

                Excel.Range rangeBorders = worksheet.Range[worksheet.Cells[1][1], worksheet.Cells[6][startRowIndex - 1]];
                rangeBorders.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle =
                rangeBorders.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle =
                rangeBorders.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle =
                rangeBorders.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle =
                rangeBorders.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                worksheet.Columns.AutoFit();

                application.Visible = true;
            }
        }
    }
}
