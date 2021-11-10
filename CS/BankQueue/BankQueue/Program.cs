using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerNum = 0;

            Queue<int> ticket = new Queue<int>();
           
            Console.WriteLine("Options:\n");
            Console.WriteLine("1. Add a customer");
            Console.WriteLine("2. Serve a customer");
            Console.WriteLine("Any other key. Close up and go home\n");

            bool open = true;

            do
            {
                Console.Write("Selection: ");
                int option = int.Parse(Console.ReadLine());
                

                switch (option)
                {
                    case 1:
                        customerNum++;
                        ticket.Enqueue(customerNum);
                        Console.WriteLine($"There are {ticket.Count} customers in line.\n");
                        
                        break;
                    case 2:
                        Console.WriteLine($"Customer #{ticket.Peek()} has been served.");
                        ticket.Dequeue();
                        Console.WriteLine($"There are {ticket.Count} customers in line.\n");
                        
                        break;
                    default:
                        Console.WriteLine("End program.");
                        open = false;
                        break;
                }
            }
            while (open == true);
        }
    }
}
