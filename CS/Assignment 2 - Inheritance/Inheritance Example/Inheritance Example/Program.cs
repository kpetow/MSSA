using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The school has {School.getStudents()} students.");
            Console.WriteLine($"The school has {School.getTeachers()} teachers.");
            Console.WriteLine($"The school has {School.getJanitors()} janitors.");
            Console.WriteLine($"The school has {School.getEmployees()} employees total.\n");

            Console.Write($"The school offers {School.getClasses()} classes: ");
            Console.WriteLine($"{Subject.History}, {Subject.Math}, and {Subject.Spanish}.\n");


            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Student student_4 = new Student(ref School.students);
            
            Teacher teacher_1 = new Teacher(ref School.teachers, ref School.employees);
            Teacher teacher_2 = new Teacher(ref School.teachers, ref School.employees);
            Teacher teacher_3 = new Teacher(ref School.teachers, ref School.employees);
            
            Janitor janitor_1 = new Janitor(ref School.janitors, ref School.employees);
            Janitor janitor_2 = new Janitor(ref School.janitors, ref School.employees);
           
            Console.WriteLine("");
            Console.WriteLine("Press enter to generate people.\n");
            Console.ReadKey();

            student_1.setClasses(Convert.ToString(Subject.History));
            student_2.setClasses(Convert.ToString(Subject.Spanish));
            student_3.setClasses(Convert.ToString(Subject.Math));
            student_4.setClasses(Convert.ToString(Subject.History));

            teacher_1.setClasses(Convert.ToString(Subject.History));
            teacher_2.setClasses(Convert.ToString(Subject.Math));
            teacher_3.setClasses(Convert.ToString(Subject.Spanish));


            Console.WriteLine($"The school has {School.getStudents()} students.");
            Console.WriteLine($"The school has {School.getTeachers()} teachers.");
            Console.WriteLine($"The school has {School.getJanitors()} janitors.");
            Console.WriteLine($"The school has {School.getEmployees()} employees total.\n");

            Console.WriteLine($"Teacher 1 teaches {teacher_1.getClasses()}.");
            Console.WriteLine($"Teacher 2 teaches {teacher_2.getClasses()}.");
            Console.WriteLine($"Teacher 3 teaches {teacher_3.getClasses()}.\n");

            Console.WriteLine($"Student 1 is taking {student_1.getClasses()}.");
            Console.WriteLine($"Student 2 is taking {student_2.getClasses()}.");
            Console.WriteLine($"Student 3 is taking {student_3.getClasses()}.");
            Console.WriteLine($"Student 4 is taking {student_4.getClasses()}.\n");

            Console.WriteLine("Press enter to submit grades.\n");
            Console.ReadKey();

            Console.WriteLine("Time to grade.\n");
            Console.Write("Insert Student 1's grade: ");
            var grade1 = Console.ReadLine();
            student_1.addGrade(grade1);
            Console.Write("\nInsert Student 2's grade: ");
            var grade2 = Console.ReadLine();
            student_2.addGrade(grade2);

            Console.ReadKey();

            student_1.mexicanNote();

            Console.ReadKey();
        }
    }
}