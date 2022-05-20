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
    /// Interaction logic for MoreInfoHorsePage.xaml
    /// </summary>
    public partial class MoreInfoHorsePage : Page
    {
        
        public MoreInfoHorsePage()
        {
            Title = "ЫАЫААЫ";
            InitializeComponent();
            
            this.DataContext = this;
            
             

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            int t = 0;
            t = Convert.ToInt32(indexBodyTb.Text) / 100;

            var info = new MoreInfoHorse();
            info.IdHorse = Convert.ToInt32(idTb.Text);
            info.Date = DateTb.SelectedDate;
            info.Puls = Convert.ToInt32(pulsTb.Text);
            info.TemperatureBody = Convert.ToInt32(temperatureTb.Text);
            info.IndexBody = Convert.ToInt32(indexBodyTb.Text);
            info.Weight = Convert.ToInt32(weightTb.Text);
            ToGetData.AddMoreInfoHorse(info);
            if (Convert.ToInt32(weightTb.Text) / (t*t) > 20)
                MessageBox.Show("Присутствует избыточный вес!");
        }
    }
}
