using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawConeWithAsterisks
{
    class Print
    {
        public static void printTriangle()
        {
            Console.WriteLine("\nOption 1: Print an upside down triangle\n");
            Console.Write("Enter the base width: ");
            
            int input = int.Parse(Console.ReadLine());
            int j;
            int i;

            for (i = input; i > 0; i = i - 2)
            {
                for (j = input - i; j > 0; j = j-2)
                {
                    Console.Write(" ");
                }
                for (j = i; j > 0; j--)
                {
                    Console.Write("*");

                }
                Console.Write("\n");
                
            }
            Console.ReadKey();
        }
        public static void printHourGlass()
        {
            Console.WriteLine("Option 2: Print an hour glass\n");
            Console.Write("Enter the base width: ");

            int input = int.Parse(Console.ReadLine());
            int aux = input;
            int i;
            int j;

            for (i = input; i > 0; i = i - 2)
            {
                for (j = input - i; j > 0; j = j - 2)
                {
                    Console.Write(" ");
                }
                for (j = i; j > 0; j--)
                {
                    Console.Write("*");

                }
                Console.Write("\n");

            }
            for (i = 3; i <= aux; i = i + 2)
            {
                for (j = 1; j <= aux - i; j = j + 2)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.Write("\n");

            }
            Console.ReadKey();
        }

    }

}




