using Core.DB;
using Core.MyDb;
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
using System.Windows.Shapes;

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for SborMolokaWindow.xaml
    /// </summary>
    public partial class SborMolokaWindow : Window
    {
        public static ObservableCollection<Horse> horses { get; set; }
        public static ObservableCollection<Bak> baks { get; set; }
        public static ObservableCollection<Konsistention> konsistentions { get; set; }
        public static ObservableCollection<StatusSbora> statusSboras { get; set; }
        public SborMolokaWindow()
        {
            InitializeComponent();
            horses = new ObservableCollection<Horse>(DbConnection.fermaEntities.Horse.ToList());
            baks = new ObservableCollection<Bak>(DbConnection.fermaEntities.Bak.ToList());
            konsistentions = new ObservableCollection<Konsistention>(DbConnection.fermaEntities.Konsistention.ToList());
            statusSboras = new ObservableCollection<StatusSbora>(DbConnection.fermaEntities.StatusSbora.ToList());
            DataContext = this;
        }

        private void saveMilkBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
