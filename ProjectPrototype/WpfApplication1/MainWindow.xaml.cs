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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomeScreen homePage = new HomeScreen();
        PlantSearch plantSearch = new PlantSearch();
        public MainWindow()
        {
            InitializeComponent();
            MainWindowStackPanel.Children.Add(homePage);
        }

        private void MainWindowStackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowStackPanel.Children.Clear();
            MainWindowStackPanel.Children.Add(homePage);
        }
    }
}
