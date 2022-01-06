using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secNum, sum;
            bool flag = true;


            Console.Write("Introduce first number: ");
            firstNum = getEvenNum();

            Console.Write("Introduce second number: ");
            secNum = getEvenNum();

            sum = firstNum + secNum;
            Console.WriteLine("The sum of {0} and {1} is {2}",firstNum, secNum, sum);
        }

        public static double getEvenNum()
        {
            double num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Please input an even number.");
                return getEvenNum();
            }
        }
    }
}
