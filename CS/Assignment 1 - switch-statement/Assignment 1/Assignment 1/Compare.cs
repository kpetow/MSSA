using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Compare
    {
        public void higherValue(int option)
        {
            Console.WriteLine($"Running program {option}: Compare two values and return which is bigger.\n");
            int number1;
            int number2;
            Console.Write("Enter the first value: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second value: ");
            number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} is bigger than {number2}.\n");
            }
            else if (number2 > number1)
            {
                Console.WriteLine($"{number2} is bigger than {number1}.\n");
            }
            else
            {
                Console.WriteLine("The numbers are equal!\n");
            }
        }
        public void evenOdd(int option)
        {
            int num;
            Console.WriteLine($"Running Program {option}: Determine if a number is even or odd.\n");
            Console.Write("Enter a whole number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.\n");
            }
            else
            {
                Console.WriteLine($"{num} is odd.\n");
            }
        }
    }
}
