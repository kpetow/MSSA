using System;
using System.Collections.Generic;

namespace School
{
    class Student
    {
        // Fields
        private int id;
        private string classes;
        private string grade;

        // Constructor
        public void setClasses(string classes)
        {
            this.classes = classes;
        }

        public string getClasses()
        {

            return this.classes;
        }
        public Student(ref int student)
        {
            student++;
            this.id = student;
        }
        public void addGrade<T>(T newGrade) //receive value and store grade for a student 
        {
            this.grade = newGrade.ToString();
        }

        public void mexicanNote() //converts grade to Mexican grading system
        {
            Dictionary<string, int> mexicanGrades = new Dictionary<string, int>();
            mexicanGrades.Add("F", 5);
            mexicanGrades.Add("D", 6);
            mexicanGrades.Add("C", 7);
            mexicanGrades.Add("B", 8);
            mexicanGrades.Add("A", 9);
            mexicanGrades.Add("A+", 10);

            if (mexicanGrades.ContainsKey(grade))
            {
                Console.WriteLine($"Grade converted from {} to {1}.\n");
            }

        }
        public void americanNote()
        {
            
        }
    }
}
/* Conversion Table
 * 5 = F
 * 6 = D
 * 7 = C
 * 7.9 = C+
 * 8 = B
 * 9 = A
 * 10 = A+
*/