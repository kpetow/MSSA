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

namespace WPF_ButtonColorChanger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void changeToRed(object sender, RoutedEventArgs e)
        {
            topRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        }

        private void changeToBlue(object sender, RoutedEventArgs e)
        {
            topRectangle.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 255));
        }

        private void changeToGreen(object sender, RoutedEventArgs e)
        {
            topRectangle.Fill = new SolidColorBrush(Color.FromRgb(0, 200, 0));
        }

        private void changeToYellow(object sender, RoutedEventArgs e)
        {
            topRectangle.Fill = new SolidColorBrush(Color.FromRgb(236, 255, 0));
        }
    }
}
