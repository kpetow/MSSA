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
        int id;
        public Form(int id = 0)
        {
            InitializeComponent();

            this.id = id;

            if (id != 0)
            {
                using (Model.WPFEntities db = new Model.WPFEntities())
                {
                    Model.Student oStudent = db.Student.Find(id);

                    FirstNameTxt.Text = oStudent.FirstName;
                    LastNameTxt.Text = oStudent.LastName;
                    AgeTxt.Text = oStudent.Age.ToString();
                    HeightTxt.Text = oStudent.Height.ToString();
                    FailedTxt.IsChecked = oStudent.Failed;
                }
            }
        }

        private void addNewStudent(object sender, RoutedEventArgs e)
        {
            if (id == 0)
            {
                using (WPFEntities db = new WPFEntities())
                {
                    Student oStudent = new Student();
                    oStudent.FirstName = FirstNameTxt.Text;
                    oStudent.LastName = LastNameTxt.Text;
                    oStudent.Age = int.Parse(AgeTxt.Text);
                    oStudent.Height = decimal.Parse(HeightTxt.Text);
                    oStudent.Failed = FailedTxt.IsChecked.Value;

                    db.Student.Add(oStudent);
                    db.SaveChanges();
                }
                
            } else
            {
                using (WPFEntities db = new WPFEntities())
                {
                    Model.Student oStudent = db.Student.Find(id);                    
                    oStudent.FirstName = FirstNameTxt.Text;
                    oStudent.LastName = LastNameTxt.Text;
                    oStudent.Age = int.Parse(AgeTxt.Text);
                    oStudent.Height = decimal.Parse(HeightTxt.Text);
                    oStudent.Failed = FailedTxt.IsChecked.Value;

                    db.Entry(oStudent).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

            }
            this.Close();
        }

        private void closeWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
