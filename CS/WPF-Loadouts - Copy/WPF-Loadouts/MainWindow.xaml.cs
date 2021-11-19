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
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace WPF_Loadouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Loadout
        {
            public int brightness { get; set; }
            public string mode { get; set; } 
            public string resolution { get; set; }
            public bool hints { get; set; }


            public Loadout()
            {
                this.brightness = 50;
                this.mode = "normal";
                this.resolution = "1920 x 1080";
                this.hints = false;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = this;
        }

        Loadout loadout1 = new Loadout();
        Loadout loadout2 = new Loadout();
        Loadout loadout3 = new Loadout();
        Loadout loadout4 = new Loadout();

        private void load1(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout1;
            btn1.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn3.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn4.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            
            
        }
        private void load2(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout2;
            btn2.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn1.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn3.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn4.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

        }
        private void load3(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout3;
            btn3.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn1.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn4.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

        }        
        private void load4(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout4;
            btn4.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn3.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn1.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

        }

        private void printValue(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine("-----------------------------------------------------------");
            Debug.WriteLine($"Loadout 1: Brightness = {loadout1.brightness}");
            Debug.WriteLine($"Loadout 2: Brightness = {loadout2.brightness}");
            Debug.WriteLine($"Loadout 3: Brightness = {loadout2.brightness}");
            Debug.WriteLine($"Loadout 4: Brightness = {loadout2.brightness}");
        }

        private void saveSettings(object sender, RoutedEventArgs e)
        {

        }

        private void changeDiff(object sender, RoutedEventArgs e)
        {
            if (easyOpt.IsChecked == true && normalOpt.IsChecked == false && hardOpt.IsChecked == false)
            {
                string mode = "Easy";
                Debug.WriteLine($"Difficulty: {mode}");
                
            }
            if (easyOpt.IsChecked == false && normalOpt.IsChecked == true && hardOpt.IsChecked == false)
            {
                string mode = "Normal";
                Debug.WriteLine($"Difficulty: {mode}");
            }
            if (easyOpt.IsChecked == false && normalOpt.IsChecked == false && hardOpt.IsChecked == true)
            {
                string mode = "Hard";
                Debug.WriteLine($"Difficulty: {mode}");
            }

        }

        
    }
}
