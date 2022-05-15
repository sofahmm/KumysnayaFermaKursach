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
using Core.MyDb;

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for AuthorizationKlientWindow.xaml
    /// </summary>
    public partial class AuthorizationKlientWindow : Window
    {
        public AuthorizationKlientWindow()
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
            /*if (ToGetData.IsCorrectUser(idTb.Text.ToString(), passwordTb.Text.ToString()))
            {
                App.user = ToGetData.GetUser(idTb.Text.ToString(), passwordTb.Text.ToString());
                NavigationService.Navigate(new Pages.MenuUserPage());
                //NavigationService.Navigated += frame_Navigated;
            }
                
            else if (ToGetData.IsUncurrentUser(idTb.Text.ToString(), passwordTb.ToString()))
                MessageBox.Show("Введите верные данные!");*/

            if (ToGetData.IsCorrectKlient(numberPhoneTb.ToString()))
            {
                App.klient = ToGetData.GetKlient(numberPhoneTb.ToString());
                NavigationService.Navigate(new Pages.MenuKlientPage());
            }
        }
    }
}
