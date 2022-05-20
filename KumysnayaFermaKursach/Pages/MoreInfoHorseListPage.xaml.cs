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
using Core.MyDb;
using Core.DB;

namespace KumysnayaFermaKursach.Pages
{
    /// <summary>
    /// Interaction logic for MoreInfoHorseListPage.xaml
    /// </summary>
    public partial class MoreInfoHorseListPage : Page
    {
        public MoreInfoHorseListPage()
        {
            InitializeComponent();
            HorsesLV.ItemsSource = ToGetData.GetMoreInfoHorse();
            this.DataContext = this;

        }

        private void AddHorseInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreInfoHorsePage());

        }
    }
}
