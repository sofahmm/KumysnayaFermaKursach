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
            if (ToGetData.IsCorrectKlient(numberPhoneTb.ToString()))
            {
                //App.klient = ToGetData.GetKlient(numberPhoneTb.ToString());
                NavigationService.Navigate(new Pages.ListHorsesPage());
            }
            else if (ToGetData.IsUncurrentKlient(numberPhoneTb.Text.ToString()))
                MessageBox.Show("Введите верные данные!");
        }
    }
}
