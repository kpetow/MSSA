using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class ExtraFunctions
    {
        public void randomGame(int extraOption)
        {
            Console.WriteLine($"#{extraOption}: Guess a number between 1 and 10 (3 attempts).\n");
            Random random = new Random();
            int randomNum = random.Next(1, 11);
            //Console.WriteLine($"The answer is {randomNum}.");
            int guess;
            bool winner = true;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Guess #{i + 1}: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine($"{guess} is too high. Try again.\n");
                    winner = false;
                }
                if (guess < randomNum)
                {
                    Console.WriteLine($"{guess} is too low. Try again.\n");
                    winner = false;
                }
                if (guess == randomNum)
                {
                    Console.WriteLine($"{guess} is the correct Answer!\n");
                    i = 4;
                    winner = true;
                }
            }
            if (!winner)
            {
                Console.WriteLine($"You are out of guesses. The correct answer was {randomNum}.\n");
            }
        }
        public void primeCheck(int extraOption)
        {
            Console.WriteLine($"#{extraOption}: Determine if a number is prime.\n");
            Console.Write("Enter a value that is greater than 1: ");
            int numCheck = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (numCheck <= 1)
            {
                Console.WriteLine("Number needs to be greater than 1.\n");
            }
            else
            {
                for (int i = 2; i <= (numCheck / 2); i++)
                {
                    if ((numCheck % i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine($"{numCheck} is a prime number.\n");
                }
                else
                {
                    Console.WriteLine($"{numCheck} is NOT a prime number.\n");
                }
            }
        }
        public void numberSwap(int extraOption)
        {
            Console.WriteLine($"#{extraOption}: Swap values of two variables.\n");
            Console.Write("Enter a value for a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPress enter to swap.");
            Console.ReadKey();

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"\na = {a}");
            Console.WriteLine($"b = {b}");

        }
        public void cubicValue(int extraOption)
        {
            Console.WriteLine($"#{extraOption}: Calculate the cube of a number.\n");
            Console.Write("Enter an integer: ");

            double baseNumber = double.Parse(Console.ReadLine());
            double cubeResult = Math.Pow(baseNumber, 3.0);
            
            Console.WriteLine($"The result is {cubeResult}.\n");
        }
        public void calcAverage(int extraOption)
        {
            Console.WriteLine($"#{extraOption}: Calculate average of integers.\n");
            Console.Write("Enter the total amount of integers (1-10): ");

            decimal range = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < range; i++)
            {
                Console.Write($"Enter value #{i+1}: ");
                total += decimal.Parse(Console.ReadLine());
            }
            decimal avg =  total / range;
            Console.WriteLine("Press enter to calculate the average.\n");
            Console.WriteLine($"The average is {avg}.\n");
        }
        public void multiTable(int extraOption)
        {
            Console.WriteLine($"#{extraOption}: Display a multiplication table.\n");
            Console.Write("Enter an integer: ");

            int mainNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int multiple = mainNum * i;
                Console.WriteLine($"{mainNum} * {i, -2} = {multiple}\n");
            }
        }
        public void alphaOrder(int extraOption)
        {
            Console.WriteLine($"#{extraOption}: Alphabetically order a string.\n");
            Console.Write("Enter a word or sequence of letters: ");

            string entry = Console.ReadLine().ToLower();
            char[] letters = entry.ToArray();
            Array.Sort(letters);

            Console.WriteLine("\n" + new string(letters) + "\n");
            
        }
    }
}
