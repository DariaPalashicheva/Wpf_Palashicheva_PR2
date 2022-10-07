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
using System.Windows.Shapes;

namespace Wpf_Palashicheva_PR2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void MenuItemRed_Click(object sender, RoutedEventArgs e)
        {
            Ink.DefaultDrawingAttributes.Color = Colors.Red;
        }
        private void MenuItemBlue_Click(object sender, RoutedEventArgs e)
        {
            Ink.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void MenuItemGreen_Click(object sender, RoutedEventArgs e)
        {
            Ink.DefaultDrawingAttributes.Color = Colors.Green;

        }

        private void MenuItemEraser_Click(object sender, RoutedEventArgs e)
        {
            Ink.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        //    Ink.DefaultDrawingAttributes.Width = ((Slider)sender).Value;
       //     Ink.DefaultDrawingAttributes.Height = ((Slider)sender).Value;
        }
    }
}
