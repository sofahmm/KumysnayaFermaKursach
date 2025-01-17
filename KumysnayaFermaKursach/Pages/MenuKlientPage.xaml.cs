﻿using System;
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
    /// Interaction logic for MenuKlientPage.xaml
    /// </summary>
    public partial class MenuKlientPage : Page
    {
        public static KlientAuth klient { get; set; }
        public MenuKlientPage()
        {
            InitializeComponent();
            LblNameKl.Content = App.klient.Name;
            LblNumberPhone.Content = App.klient.PhoneNumber;
            klient = App.klient;           
            DataContext = klient;
        }

        private void OurProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OurProductsPage());
        }

        private void MineOrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }

        private void CreateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrderPage());
        }

        private void AboutUsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
