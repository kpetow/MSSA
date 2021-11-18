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

namespace WPF_Controls_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public class Coffee
    {
        public string size { get; set; }
        public string item { get; set; }
        public string extras { get; set; }
        public string output { get; set; }

    }
    public partial class MainWindow : Window
    {
        string size;
        string item;
        string extras;
        string summary;

        Coffee coffee1 = new Coffee();
       
        

        public MainWindow()
        {
            InitializeComponent();
            //btnOrder_Click();
            this.DataContext = coffee1;
        }

        public void summaryUpdate()
        {
            this.summary = $"{size} {item} {extras}";
            coffee1.output = summary;
            Debug.WriteLine(coffee1.output);
            //summaryText.Text = summary;
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(sizeSmall))
            {
                this.size = "Small";
            }
            if (sender.Equals(sizeMedium))
            {
                this.size = "Medium";
            }
            if (sender.Equals(sizeLarge))
            {
                this.size = "Large";
            }
            summaryUpdate();
        }

        private void menuSelection(object sender, RoutedEventArgs e)
        {
            if (sender == Latte)
            {
                this.item = "Latte";
            }
            if (sender == Frapuccino)
            {
                this.item = "Frapuccino";
            }
            if (sender == Mocha)
            {
                this.item = "Mocha";
            }
            if (sender == Machiato)
            {
                this.item = "Machiato";
            }
            summaryUpdate();
        }

        private void addExtras(object sender, RoutedEventArgs e)
        {
            if (Cream.IsChecked == true && Sugar.IsChecked == false)
            {
                this.extras = "with Cream";
            }
            if (Sugar.IsChecked == true && Cream.IsChecked == false)
            {
                this.extras = "with Sugar";
            }
            if (Cream.IsChecked == true && Sugar.IsChecked == true)
            {
                this.extras = "with Cream and Sugar";
            }
            if (Cream.IsChecked == false && Sugar.IsChecked == false)
            {
                this.extras = "";
            }
            summaryUpdate();
        }

        private void submitOrder(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Order Submitted!");
            Sugar.IsChecked = false;
            Cream.IsChecked = false;
            sizeSmall.IsChecked = false;
            sizeMedium.IsChecked = false;
            sizeLarge.IsChecked = false;
            menuItems.SelectedIndex = -1;
            summaryText.Text = String.Empty;
        }
    }
}
