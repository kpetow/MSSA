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
        //public class Loadout
        //{
        //    public int brightness { get; set; }
        //    public bool easy { get; set; }
        //    public bool normal { get; set; }
        //    public bool hard { get; set; }
        //    public string resolution { get; set; }
        //    public bool hints { get; set; }
        //    public string mode { get; set; }


        //    public Loadout()
        //    {
        //        this.brightness = 50;
        //        this.easy = false;
        //        this.normal  = true;
        //        this.hard = false;
        //        this.resolution = "1920 x 1080";
        //        this.hints = false;
        //        this.mode = "normal";

        //    }
        //}

        Profile loadout1;
        Profile loadout2;
        Profile loadout3;
        Profile loadout4;

        public MainWindow()
        {
            loadout1 = new Profile();
            loadout2 = new Profile();
            loadout3 = new Profile();
            loadout4 = new Profile();
            InitializeComponent();
            //DataContext = this;

        }





        private void load1(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout1;
            verifyCurrentProfile();
            updateModeUI();
            updateResUI();
            //printDebug();
            btn1.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn3.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn4.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));


        }
        private void load2(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout2;
            verifyCurrentProfile();
            updateModeUI();
            updateResUI();
            //printDebug();
            btn2.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn1.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn3.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn4.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

        }
        private void load3(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout3;
            verifyCurrentProfile();
            updateModeUI();
            updateResUI();
            //printDebug();
            btn3.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn1.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn4.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

        }
        private void load4(object sender, RoutedEventArgs e)
        {
            this.DataContext = loadout4;
            verifyCurrentProfile();
            updateResUI();
            updateModeUI();
            //printDebug();
            btn4.Background = new SolidColorBrush(Color.FromRgb(100, 175, 200));
            btn2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn3.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            btn1.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

        }

        //private void printDebug()
        //{
        //    Debug.WriteLine("-----------------------------------------------------------");
        //    Debug.WriteLine($"Loadout 1: {loadout1.Brightness} | {loadout1.Difficulty} | Resolution: {loadout1.Resolution} | Hints: {loadout1.Hints}");
        //    Debug.WriteLine($"Loadout 2: {loadout2.Brightness} | {loadout2.Difficulty} | Resolution: {loadout2.Resolution} | Hints: {loadout2.Hints}");
        //    Debug.WriteLine($"Loadout 3: {loadout3.Brightness} | {loadout3.Difficulty} | Resolution: {loadout3.Resolution} | Hints: {loadout3.Hints}");
        //    Debug.WriteLine($"Loadout 4: {loadout4.Brightness} | {loadout4.Difficulty} | Resolution: {loadout4.Resolution} | Hints: {loadout4.Hints}");
        //}

        private Profile verifyCurrentProfile()
        {
            if (DataContext == loadout1)
            {
                return loadout1;
            }
            else if (DataContext == loadout2)
            {
                return loadout2;
            }
            else if (DataContext == loadout3)
            {
                return loadout3;
            }
            else
            {
                return loadout4;
            }
        }

        private void updateModeUI()
        {
            Profile currentProfile = verifyCurrentProfile();

            if (currentProfile.Difficulty == "Easy")
            {
                easyBtn.IsChecked = true;
            }
            else if (currentProfile.Difficulty == "Normal")
            {
                normalBtn.IsChecked = true;
            }
            else if (currentProfile.Difficulty == "Hard")
            {
                hardBtn.IsChecked = true;
            }

        }

            private void changeMode(object sender, RoutedEventArgs e)
            {
                RadioButton radio = sender as RadioButton;
                string difficulty = radio.Content.ToString();

                Profile currentProfile = verifyCurrentProfile();

                if (difficulty == "Easy")
                {
                    currentProfile.Difficulty = difficulty;
                }
                else if (difficulty == "Normal")
                {
                    currentProfile.Difficulty = difficulty;
                }
                else if (difficulty == "Hard")
                {
                    currentProfile.Difficulty = difficulty;
                }
            }

        private void changeRes(object sender, EventArgs e)
        {
            ComboBoxItem combo = sender as ComboBoxItem;
            string resOption = combo.Content.ToString();
            
            Profile currentProfile = verifyCurrentProfile();

            if(resOption == "1920 x 1080")
            {
                currentProfile.Resolution = resOption;
            }
            else if(resOption == "2460 x 1080")
            {
                currentProfile.Resolution= resOption;
            }
            else if(resOption == "1024 x 768")
            {
                currentProfile.Resolution = resOption;
            }
        }

        public void updateResUI()
        {
            Profile currentProfile = verifyCurrentProfile();

            if (currentProfile.Resolution == "1920 x 1080")
            {
                res1.IsSelected = true;
            }
            else if (currentProfile.Resolution == "2460 x 1080")
            {
                res2.IsSelected = true;
            }
            else if (currentProfile.Resolution == "1024 x 768")
            {
                res3.IsSelected = true;
            }

        }

        private void printDebug(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("-----------------------------------------------------------");
            Debug.WriteLine($"Loadout 1: {loadout1.Brightness} | {loadout1.Difficulty} | Resolution: {loadout1.Resolution} | Hints: {loadout1.Hints}");
            Debug.WriteLine($"Loadout 2: {loadout2.Brightness} | {loadout2.Difficulty} | Resolution: {loadout2.Resolution} | Hints: {loadout2.Hints}");
            Debug.WriteLine($"Loadout 3: {loadout3.Brightness} | {loadout3.Difficulty} | Resolution: {loadout3.Resolution} | Hints: {loadout3.Hints}");
            Debug.WriteLine($"Loadout 4: {loadout4.Brightness} | {loadout4.Difficulty} | Resolution: {loadout4.Resolution} | Hints: {loadout4.Hints}");
        }
    }
    }
