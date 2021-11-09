using System;

namespace School
{
    class Student
    {
        // Fields
        private int id;
        private string classes;

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
    }
}