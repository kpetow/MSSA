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
using WPFCRUD.Model;

namespace WPFCRUD
{
    /// <summary>
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : Window
    {
        public Form()
        {
            InitializeComponent();
        }

        private void addNewStudent(object sender, RoutedEventArgs e)
        {
            Student oStudent = new Student();
            oStudent.FirstName = FirstNameTxt.Text;
            oStudent.LastName = LastNameTxt.Text;
            oStudent.Age = int.Parse(AgeTxt.Text);
            oStudent.Height = decimal.Parse(HeightTxt.Text);
            oStudent.Failed = FailedTxt.Text;

            using (WPFEntities db = new WPFEntities())
            {
                db.Student.Add(oStudent);
            }
        }

        private void closeWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
