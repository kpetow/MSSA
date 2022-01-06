using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_InsertIntoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            ArrayList al = new ArrayList();

            while (flag)
            {
                Console.Write("Add to the List: ");
                al.Add(Console.ReadLine());

                foreach(string s in al)
                {
                    Console.WriteLine(s);
                }


                Console.Write("\nAdd more? Y/N: ");
                string input = Console.ReadLine().ToLower();

                if(input == "y")
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("\nThanks for playing!\n");
                    flag = false;
                }

            }
        }
    }
}
