using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;



namespace Assignment_1
{
    public class Game
    {
        public void factorialInput()
        {
            var negativeInput = new IndexOutOfRangeException("Number cannot be negative");
            try
            {


                Console.WriteLine("Game 1: Calculate a factorial.");
                Console.Write("Enter a positive integer: ");
                int numF = int.Parse(Console.ReadLine());

                if (numF < 0)
                {
                    throw negativeInput;
                }
                int result = Game.factorialCalc(numF);
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException e)
            {
                Trace.WriteLine(e);
                Console.WriteLine("You cannot enter a negative number.");
            }
        }
        public static int factorialCalc(int number)
        {
            int result;

            if (number == 0)
            {
                result = 1;
            }
            else
            {
                result = number * factorialCalc(number - 1);
            }
            return result;
        }
        public void seasonFinder()
        {
            try
            {
                Console.Write("Enter a date (dd-mmm): ");
                string d = Console.ReadLine();
                DateTime date = DateTime.ParseExact(d, "dd-MMM", CultureInfo.InvariantCulture);
                DateTime spring = new DateTime(2021, 03, 20);
                DateTime summer = new DateTime(2021, 06, 20);
                DateTime fall = new DateTime(2021, 09, 22);
                DateTime winter = new DateTime(2021, 12, 21);

                if (date < spring)
                {
                    Console.WriteLine("The season is Winter.");
                }
                else if (date < summer)
                {
                    Console.WriteLine("The season is Spring.");
                }
                else if (date < fall)
                {
                    Console.WriteLine("The season is Summer.");
                }
                else if (date < winter)
                {
                    Console.WriteLine("The season is Fall.");
                }
                else
                {
                    Console.WriteLine("The season is Winter.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You did not enter a valid month and day.");
                Console.WriteLine(e);
            }

        }
        public void Rochambeau(int option)
        {
            string playAgain = "y";
            do
            {
                Console.WriteLine($"Game {option}: Rock, Paper, Scissors\n");
                try
                {
                    string[] cpu = { "r", "p", "s" };
                    Random random = new Random();
                    int cpuChoice = random.Next(1, cpu.Length);
                    string opp = cpu[cpuChoice];
                    Console.Write("Choose rock, paper, or scissors (r/p/s): ");
                    string yourMove = Console.ReadLine();
                    if (yourMove == opp)
                    {
                        Console.WriteLine($"CPU picked {opp}. It's a tie!");
                    } else if (yourMove == "r" && opp == "s")
                    {
                        Console.WriteLine($"CPU picked {opp}. You win!");
                    } else if(yourMove == "p" && opp == "r")
                    {
                        Console.WriteLine($"CPU picked {opp}. You win!");
                    } else if(yourMove == "s" && opp == "p")
                    {
                        Console.WriteLine($"CPU picked {opp}. You win!");
                    } else
                    {
                        Console.WriteLine($"CPU picked {opp}. You LOSE!");
                    }
                    Console.Write("Play again? y/n: ");
                    playAgain = Console.ReadLine();
                    Console.WriteLine("");
                    if (playAgain != "y")
                    {
                        Console.WriteLine("Press any key to return.");
                        Console.ReadKey();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("You made a mistake:");
                    Console.WriteLine(e);
                }
            }
            while(playAgain == "y");
            
        }
    }
}
