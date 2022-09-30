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

namespace Wpf_Palashicheva_PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Палашичева Дарья Анатольевна" +
                "\nСтудентка группы 402-ИСП");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Yellow;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Red;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Orange;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Green;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.BlueViolet;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Blue;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Gray;
        }
    }
}
