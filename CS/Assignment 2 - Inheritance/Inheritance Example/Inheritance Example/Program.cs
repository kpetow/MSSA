using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The school has {School.getStudents()} students.");
            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Student student_4 = new Student(ref School.students);
            Student student_5 = new Student(ref School.students);
            

            Console.WriteLine($"The school has {School.getTeachers()} teachers.");
            Teacher teacher_1 = new Teacher(ref School.teachers, ref School.employees);
            Teacher teacher_2 = new Teacher(ref School.teachers, ref School.employees);
            Teacher teacher_3 = new Teacher(ref School.teachers, ref School.employees);
            

            Console.WriteLine($"The school has {School.getJanitors()} janitors.");
            Janitor janitor_1 = new Janitor(ref School.janitors, ref School.employees);
            Janitor janitor_2 = new Janitor(ref School.janitors, ref School.employees);
           
            Console.WriteLine("");
            Console.WriteLine("Press enter to generate people.\n");
            Console.ReadKey();

            Console.WriteLine($"The school has {School.getStudents()} students.");
            Console.WriteLine($"The school has {School.getTeachers()} teachers.");
            Console.WriteLine($"The school has {School.getJanitors()} janitors.");
            Console.WriteLine($"The school has {School.getEmployees()} employees total.\n");
        }
    }
}