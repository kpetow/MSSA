using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal operand1;
            decimal operand2;
            decimal result;
            bool active = true;
            do
            {
                Stack<int> calculator = new Stack<int>();

                Console.Write("\nEnter value 1: ");
                int val1 = int.Parse(Console.ReadLine());

                Console.Write("\nEnter value 2: ");
                int val2 = int.Parse(Console.ReadLine());

                calculator.Push(val1);
                calculator.Push(val2);

                Console.WriteLine("Choose an operation to perform.\n");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Exit program");

                Console.Write("Selection: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nAddition\n");
                        operand1 = calculator.Pop();
                        operand2 = calculator.Pop();
                        result = operand1 + operand2;
                        Console.WriteLine($"{val1} + {val2} = {result}");
                        break;
                    case 2:
                        Console.WriteLine("\nSubtraction\n");
                        operand1 = calculator.Pop();
                        operand2 = calculator.Pop();
                        result = operand1 - operand2;
                        Console.WriteLine($"{val1} - {val2} = {result}");
                        break;
                    case 3:
                        Console.WriteLine("\nMultiplication\n");
                        operand1 = calculator.Pop();
                        operand2 = calculator.Pop();
                        result = operand1 * operand2;
                        Console.WriteLine($"{val1} * {val2} = {result}");
                        break;
                    case 4:
                        Console.WriteLine("\nDivision\n");
                        operand1 = calculator.Pop();
                        operand2 = calculator.Pop();
                        result = operand1 / operand2;
                        Console.WriteLine($"{val1} / {val2} = {result}");
                        break;
                }
            }
            while (active == true);

        }
    }
}
