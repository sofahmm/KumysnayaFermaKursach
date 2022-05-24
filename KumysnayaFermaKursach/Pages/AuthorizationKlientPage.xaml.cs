using Core.DB;
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

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for AuthorizationKlientPage.xaml
    /// </summary>
    public partial class AuthorizationKlientPage : Page
    {
        public AuthorizationKlientPage()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegistrationKlient registrationKlient = new RegistrationKlient();
            registrationKlient.Show();
        }

        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void authBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (Authorization.IsCorrectKlient(numberPhoneTb.Text))
            {
                App.klient = ToGetData.GetKlient(numberPhoneTb.Text.ToString());
                NavigationService.Navigate(new Pages.MenuKlientPage());
            }
            else if (Authorization.IsUncurrentKlient(numberPhoneTb.Text))
                MessageBox.Show("Введите верные данные!");
        }
    }
}
