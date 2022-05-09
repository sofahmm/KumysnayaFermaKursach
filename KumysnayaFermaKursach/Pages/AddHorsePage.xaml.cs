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

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for AddHorsePage.xaml
    /// </summary>
    public partial class AddHorsePage : Page
    {
        public AddHorsePage()
        {
            InitializeComponent();
            porodaCB.ItemsSource = ToGetData.GetBreeds();
            TypeCB.ItemsSource = ToGetData.GetHorseTypes();
            DataContext = this;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
