using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value 1: ");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 2: ");
            int val2 = int.Parse(Console.ReadLine());

            Calculator<int> calculator = new Calculator<int>();
            Console.WriteLine(calculator.Addition(val1, val2));
        }
        
    }
}
