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
           
        }
    }
}
/*public static void ExportExcel()
{
var allCommands = ConnectionCommands.GetCommands().OrderBy(p => p.Name).ToList();

Excel.Application application = new Excel.Application();
application.SheetsInNewWorkbook = allCommands.Count();

Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

int startRowIndex = 1;

for (int i = 0; i < allCommands.Count(); i++)
{
Excel.Worksheet worksheet = application.Worksheets.Item[i + 1];
worksheet.Name = allCommands[i].Name;
worksheet.Cells[1][startRowIndex] = "Команда из города";
worksheet.Cells[2][startRowIndex] = allCommands[i].City.Name;
startRowIndex = 2;

worksheet.Cells[1][startRowIndex] = "Название соревнования";
worksheet.Cells[2][startRowIndex] = "Дата соревнования";
worksheet.Cells[3][startRowIndex] = "Место в соревновании";
startRowIndex++;
var results = allCommands[i].ResultCompetition.OrderBy(p => p.Competition.Date).GroupBy(p => p.Competition.Date);
foreach (var result in results)
{
Excel.Range headerRange = worksheet.Range[worksheet.Cells[1][startRowIndex], worksheet.Cells[3][startRowIndex]];
headerRange.Merge();
headerRange.Value = result.Key.Date;
headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
headerRange.Font.Italic = true;
startRowIndex++;
foreach (var j in result)
{
worksheet.Cells[1][startRowIndex] = j.Competition.Name;
worksheet.Cells[2][startRowIndex] = j.Competition.NameVenue;
worksheet.Cells[3][startRowIndex] = j.Rank;
}
startRowIndex++;
}
worksheet.Columns.AutoFit();
worksheet.Rows.AutoFit();
startRowIndex = 1;
}
application.Visible = true;
}*/