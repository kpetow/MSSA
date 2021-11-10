using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGuestList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            do
            {
                Console.Write("\nEnter a guest name: ");
                guestList.Add(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Guest List:\n");

                foreach (string name in guestList)
                {
                    
                    Console.WriteLine(name);


                }
            }
            while (guestList.Count <= 10);
            Console.WriteLine("\nYou have reached the maximum guest capacity.");
        }
    }
}
