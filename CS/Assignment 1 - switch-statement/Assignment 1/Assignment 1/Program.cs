using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please select an option below.");                
                Console.WriteLine("1: Calculate the income of an employee");
                Console.WriteLine("2: Determine if a student passes or fails a course");
                Console.WriteLine("3: Multiply two values");
                Console.WriteLine("4: Divide two values");
                Console.WriteLine("5: Compare which of two values is bigger");
                Console.WriteLine("6: Determine if a number is odd or even");
                Console.WriteLine("7: Extra Features");
                Console.WriteLine("8: Game menu");
                Console.WriteLine("9: Exit\n");
                Console.Write("Please select: ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine("");



                switch (option)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Calculator incomeCalc = new Calculator();
                        incomeCalc.calcIncome(option);                        
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Calculator grader = new Calculator();
                        grader.gradePass(option);
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Teacher multi = new Teacher();
                        multi.multiplyValues(option);   
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Teacher divi = new Teacher();
                        divi.divideValues(option);    
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Compare higherlower = new Compare();
                        higherlower.higherValue(option);
                        break;
                    case 6:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Compare testnum = new Compare();
                        testnum.evenOdd(option);
                        break;
                    case 7:
                        int extraOption;
                        Console.WriteLine("Extra features\n");

                        Console.WriteLine("1: Guess a number (3 attempts).");
                        Console.WriteLine("2: Determine if a number is prime.\n");
                        Console.Write("Please select: ");

                        extraOption = int.Parse(Console.ReadLine());
                        switch (extraOption)
                        {

                            case 1:
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;
                                ExtraFunctions game = new ExtraFunctions();
                                game.randomGame(option);
                                break;
                            case 2:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor= ConsoleColor.Black;
                                ExtraFunctions prime = new ExtraFunctions();
                                prime.primeCheck(option);
                                break;
                            default:
                                Console.WriteLine("Press 0 to exit.");
                                break;
                        }
                        break;
                    case 8:
                        int gameOption;
                        Console.WriteLine("Game menu\n");

                        Console.WriteLine("1: Calculate a Factorial.");
                        Console.WriteLine("2: Find the season.");
                        Console.WriteLine("3: Rock Paper Scissors.\n");
                        Console.Write("Please select: ");
                        gameOption = int.Parse(Console.ReadLine());

                        switch (gameOption)
                        {
                            case 1:
                                Console.WriteLine("");
                                Game game1 = new Game();
                                game1.factorialInput();
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine($"Game {gameOption}: Find the season.\n");
                                Game game2 = new Game();
                                game2.seasonFinder();
                                break;
                            case 3:
                                Game game3 = new Game();
                                game3.Rochambeau(gameOption);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 9:
                        flag = false;
                        Console.WriteLine("Press any key to exit.");
                        break;
                    default:
                        Console.WriteLine("Press 0 to exit.");
                        break;
                }
                 Console.ResetColor();
                Console.WriteLine("Press enter to continue.\n");
                Console.ReadKey();

            }
            while (flag);
            Console.ReadLine();

            }
            
        }
    }

