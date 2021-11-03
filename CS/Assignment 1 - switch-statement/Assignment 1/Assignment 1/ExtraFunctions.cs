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
    }
}
