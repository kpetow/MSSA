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
using System.Windows.Shapes;
using WPFCRUD.Model;

namespace WPFCRUD
{
    /// <summary>
    /// Interaction logic for ListOfStudents.xaml
    /// </summary>
    public partial class ListOfStudents : Window
    {
        public ListOfStudents()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            List<StudentClass> myListOfStudents = new List<StudentClass>();
            //using (WPFEntities db = new WPFEntities())
            //{
            //    myListOfStudents = (from obj in db.Student select new Student
            //    {
            //        Id = obj.Id,
            //        FirstName = obj.FirstName,
            //        LastName = obj.LastName,
            //        Age = obj.Age,
            //        Height = obj.Height,
            //        Failed = obj.Failed
            //    }).ToList();   
            //}

            using (WPFEntities db = new WPFEntities()) //opening connection to the DB
            {
                myListOfStudents = (from obj in db.Student
                                    select new StudentClass
                                    {
                                        Id = obj.Id,
                                        FirstName = obj.FirstName,
                                        LastName = obj.LastName,
                                        Age = obj.Age,
                                        Height = obj.Height,
                                        Failed = obj.Failed

                                    }).ToList();
            } // closing connection to the DB

            DataGrid.ItemsSource = myListOfStudents;
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenFormWindow(object sender, RoutedEventArgs e)
        {
            Form studentsListWindow = new Form();
            studentsListWindow.ShowDialog();
        }
    }

    public class StudentClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public bool Failed { get; set; }
    }
}
