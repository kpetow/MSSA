using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Teacher
    {
        public void multiplyValues(int option)
        {
            int val1;
            int val2; ;
            string result;
            Console.WriteLine($"Running Program {option}: Multiply two values.\n");
            Console.Write("Enter the first value: ");
            val1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second value: ");
            val2 = int.Parse(Console.ReadLine());

            if (val1 == 0 || val2 == 0)
            {
                Console.WriteLine("Value is 0.\n");
            }
            else
            {
                result = Convert.ToString(val1 * val2);
                Console.WriteLine($"Result is {result}.\n");
            }
        }
        public void divideValues(int option)
        {
            float val3;
            float val4;
            string divResult;
            Console.WriteLine($"Running Program {option}: Divide two values.\n");
            Console.Write("Enter your first value: ");
            val3 = float.Parse(Console.ReadLine());
            Console.Write("Enter your second value: ");
            val4 = float.Parse(Console.ReadLine());

            if (val4 == 0)
            {
                Console.WriteLine("You cannot divide by 0.\n");
            }
            else
            {
                divResult = Convert.ToString(val3 / val4);
                Console.WriteLine($"Result is {divResult}.\n");
            }
        }
    }
}
