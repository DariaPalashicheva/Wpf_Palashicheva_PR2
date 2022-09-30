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

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            Window1.Close();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.White;
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            SB.Text = "Изменить цвет окна";
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            SB.Text = "Информация о разработчике";
        }

        private void MenuItem_MouseLeave_1(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void MenuItem_MouseEnter_2(object sender, MouseEventArgs e)
        {
            SB.Text = "Выход из приложения";
        }

        private void MenuItem_MouseLeave_2(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.Yellow;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в жёлтый";
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.Red;
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в красный";
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.Orange;
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в оранжевый";
        }

        private void Image_MouseLeave_2(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.Green;
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в зеленый";
        }

        private void Image_MouseLeave_3(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.BlueViolet;
        }

        private void Image_MouseEnter_4(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в фиолетовый";
        }

        private void Image_MouseLeave_4(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.Blue;
        }

        private void Image_MouseEnter_5(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в синий";
        }

        private void Image_MouseLeave_5(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.Gray;
        }

        private void Image_MouseEnter_6(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в серый";
        }

        private void Image_MouseLeave_6(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            Window1.Background = Brushes.White;
        }

        private void Image_MouseEnter_7(object sender, MouseEventArgs e)
        {
            SB.Text = "Покрасить фон в белый";
        }

        private void Image_MouseLeave_7(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }


        private void Image_MouseEnter_8(object sender, MouseEventArgs e)
        {
            SB.Text = "Информация о разработчике";
        }

        private void Image_MouseLeave_8(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Image_MouseEnter_9(object sender, MouseEventArgs e)
        {
            SB.Text = "Выход из приложения";
        }

        private void Image_MouseLeave_9(object sender, MouseEventArgs e)
        {
            SB.Text = "";
        }

        private void Win2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
