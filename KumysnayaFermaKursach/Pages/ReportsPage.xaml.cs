﻿using Core.DB;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for ReportsPage.xaml
    /// </summary>
    public partial class ReportsPage : Page
    {
        public ReportsPage()
        {
            InitializeComponent();
        }

        private void HorseReportBtn_Click(object sender, RoutedEventArgs e)
        {
            var allSborMoloka = ToGetData.GetSborMilks().OrderBy(p => p.ID).ToList();

            var application = new Microsoft.Office.Interop.Excel.Application();
            application.SheetsInNewWorkbook = allSborMoloka.Count();

            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            int startRowIndex = 1;
            for (int i = 0; i < allSborMoloka.Count(); i++)
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
                var results = allSborMoloka[i].Horse.SborMilk.OrderBy(p => p.Horse.ID).GroupBy(p => p.Horse.ID);
                foreach (var result in results)
                {
                    Excel.Range headerRange = worksheet.Range[worksheet.Cells[1][startRowIndex], worksheet.Cells[3][startRowIndex]];
                    headerRange.Merge();
                    headerRange.Value = result.Key.ToString();
                    headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    headerRange.Font.Italic = true;
                    startRowIndex++;
                    foreach (var j in result)
                    {
                        worksheet.Cells[1][startRowIndex] = j.IdHorse;
                        worksheet.Cells[2][startRowIndex] = j.IdStatus;
                        worksheet.Cells[3][startRowIndex] = j.Date;
                    }
                    startRowIndex++;
                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
                startRowIndex = 1;

                application.Visible = true;
            }
        }
    }
}