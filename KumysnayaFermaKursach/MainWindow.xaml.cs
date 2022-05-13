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
using KumysnayaFermaKursach.Pages;

namespace KumysnayaFermaKursach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            navFr.Navigate(new Pages.AuthorizationPage());
            navFr.Navigated += ChangeTitle;
        }

        private void ChangeTitle(object sender, NavigationEventArgs e)
        {
            MainLabel.Content = (navFr.Content as Page).Title;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (navFr.CanGoBack)
            {
                navFr.GoBack();
                //MainLabel.Content = "Кумысная ферма";
            }
               
            else
                MessageBox.Show("Нельзя перейти назад!");
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (navFr.CanGoForward)
                navFr.GoForward();
            else
                MessageBox.Show("Нельзя перейти вперед!");
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
