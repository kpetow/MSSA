using System;

namespace School
{
    class School
    {
        public static int students;
        public static int employees;
        public static int teachers;
        public static int janitors;

        // Constructor
        public School()
        {
            students = 0;
            employees = 0;
            teachers = 0;
            janitors = 0;
        }

        // Method
        public static int getStudents()
        {
            return students;
        }

        //Amount of employees
        public static int getEmployees()
        {
            return employees;
        }

        // Amount of teachers
        public static int getTeachers()
        {
            return teachers;
        }

        //Amount of janitors
        public static int getJanitors()
        {
            return janitors;
        }
    }

}