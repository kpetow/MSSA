using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Assignment_1
{
    public class Calculator
    {
        public void calcIncome(int option)
        {
            string name;
            decimal wage;
            int hours;
            decimal income;
            Console.WriteLine($"Running Program {option}: Calculate the income of an employee.");
            Console.Write("Enter employee's name: ");
            name = Console.ReadLine();
            Console.Write("Enter hourly wage: ");
            wage = decimal.Parse(Console.ReadLine());
            Console.Write("Enter hours worked this month: ");
            hours = int.Parse(Console.ReadLine());

            income = wage * Convert.ToDecimal(hours);

            Console.WriteLine($"{name} earned ${income} this month.\n");

        }
        public void gradePass(int option)
        {
            string studentName;
            decimal grade;
            decimal passingGrade = 70.0M;

            Console.WriteLine($"Running Program {option}: Determine if a student passes or fails a course.");
            Console.Write("Enter student's name: ");
            studentName = Console.ReadLine();
            Console.Write($"Enter {studentName}'s grade: ");
            grade = decimal.Parse(Console.ReadLine());

            if (grade >= passingGrade)
            {
                Console.WriteLine($"{studentName} has passed! :)\n");
            }
            else
            {
                Console.WriteLine($"{studentName} has failed! :(\n");
            }
        }
    }
}
