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

namespace EmployeeRef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Patient p1;
        public Patient p2;
        public Patient p3;
        public Patient p4;
        public Patient p5;

        public List<Patient> patients { get; set; }    

        public MainWindow()
        {
            InitializeComponent();

            p1 = new Patient(firstName: "Bob", lastName: "Smith", id: 1234, age: 35);
            p2 = new Patient(firstName: "Carl", lastName: "Jones", id: 5678, age: 22);
            p3 = new Patient(firstName: "Lisa", lastName: "Stanley", id: 4523, age: 50);
            p4 = new Patient(firstName: "Bill", lastName: "Macy", id: 5874, age: 43);
            p5 = new Patient(firstName: "Amanda", lastName: "Burns", id: 1165, age: 18);

            patients = new List<Patient>();
            patients.Add(p1);
            patients.Add(p2);
            patients.Add(p3);
            patients.Add(p4);
            patients.Add(p5);

            DataContext = this;
        }
    }
}
