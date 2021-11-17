using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawConeWithAsterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option.\n");
            Console.WriteLine("1: Print a Triangle");
            Console.WriteLine("2: Print an Hour Glass\n");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Print.printTriangle();
                    break;
                case 2:
                    Print.printHourGlass();
                    break;
            }
        }
    }
}

//input number to create a cone shape with asterisks

//input number to create and hourglass shape