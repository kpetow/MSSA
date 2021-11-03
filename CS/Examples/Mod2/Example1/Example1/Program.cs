using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{

    class Calculator
    {
        public int addition(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.addition(5, 6));
        }
    }
}
