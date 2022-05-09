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
    /// Interaction logic for AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        
        public AuthorizationPage()
        {
            InitializeComponent();
            
        }

        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ToGetData.IsCorrectUser(idTb.Text.ToString(), passwordTb.Text.ToString()))
            {
                App.user = ToGetData.GetUser(idTb.Text.ToString(), passwordTb.Text.ToString());
                NavigationService.Navigate(new Pages.MenuUserPage());
            }
                
            else if (ToGetData.IsUncurrentUser(idTb.Text.ToString(), passwordTb.ToString()))
                MessageBox.Show("Введите верные данные!");
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
