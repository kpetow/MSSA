using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_ArrayOfNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Kevin", "Bob", "Mike", "Jessica", "Sandy", "Billy", "Amanda" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"The second name in the array is {names[1]}");
        }
    }
}
