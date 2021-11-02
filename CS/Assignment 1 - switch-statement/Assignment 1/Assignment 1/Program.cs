using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Please select an option below.");                
                Console.WriteLine("1: Calculate the income of an employee");
                Console.WriteLine("2: Determine if a student passes or fails a course");
                Console.WriteLine("3: Multiply two values");
                Console.WriteLine("4: Divide two values");
                Console.WriteLine("5: Compare which of two values is bigger");
                Console.WriteLine("6: Determine if a number is odd or even");
                Console.WriteLine("7: Extra Features");
                Console.WriteLine("8: Exit\n");
                Console.Write("Please select: ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine("");



                switch (option)
                {
                    case 1:
                        //Console.BackgroundColor = ConsoleColor.Yellow;
                        //Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string name;
                        decimal wage;
                        int hours;
                        decimal income;
                        Console.WriteLine($"Running Program {option}: Calculate the income of an employee.");
                        Console.Write("Enter employee's name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter hourly wage: ");
                        wage = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter hours worked this month: ");
                        hours = int.Parse(Console.ReadLine());

                        income = wage * Convert.ToDecimal(hours);

                        Console.WriteLine($"{name} earned ${income} this month.\n");
                        break;
                    case 2:
                        //Console.BackgroundColor = ConsoleColor.Red;
                        //Console.ForegroundColor = ConsoleColor.Cyan;
                        string studentName;
                        decimal grade;
                        decimal passingGrade = 70.0M;

                        Console.WriteLine($"Running Program {option}: Determine if a student passes or fails a course.");
                        Console.Write("Enter student's name: ");
                        studentName = Console.ReadLine();
                        Console.Write($"Enter {studentName}'s grade: ");
                        grade = decimal.Parse(Console.ReadLine());

                        if (grade >= passingGrade)
                        {
                            Console.WriteLine($"{studentName} has passed! :)\n");
                        }
                        else
                        {
                            Console.WriteLine($"{studentName} has failed! :(\n");
                        }                        
                        break;
                    case 3:
                        int val1;
                        int val2; ;
                        string result;
                        Console.WriteLine($"Running Program {option}: Multiply two values.\n");
                        Console.Write("Enter the first value: ");
                        val1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second value: ");
                        val2 = int.Parse(Console.ReadLine());

                        if (val1 == 0 || val2 == 0)
                        {
                            Console.WriteLine("Value is 0.\n");
                        }
                        else
                        {
                            result = Convert.ToString(val1 * val2);
                            Console.WriteLine($"Result is {result}.\n");
                        }
                        break;
                    case 4:
                        float val3;
                        float val4;
                        string divResult;
                        Console.WriteLine($"Running Program {option}: Divide two values.\n");
                        Console.Write("Enter your first value: ");
                        val3 = float.Parse(Console.ReadLine());
                        Console.Write("Enter your second value: ");
                        val4 = float.Parse(Console.ReadLine());

                        if (val4 == 0)
                        {
                            Console.WriteLine("You cannot divide by 0.\n");
                        }
                        else
                        {
                            divResult = Convert.ToString(val3 / val4);
                            Console.WriteLine($"Result is {divResult}.\n");
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Running program {option}: Compare two values and return which is bigger.\n");
                        int number1;
                        int number2;
                        Console.Write("Enter the first value: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second value: ");
                        number2 = int.Parse(Console.ReadLine());

                        if (number1 > number2)
                        {
                            Console.WriteLine($"{number1} is bigger than {number2}.\n");
                        }
                        else if (number2 > number1)
                        {
                            Console.WriteLine($"{number2} is bigger than {number1}.\n");
                        }
                        else
                        {
                            Console.WriteLine("The numbers are equal!\n");
                        }
                        break;
                    case 6:
                        int num;
                        Console.WriteLine($"Running Program {option}: Determine if a number is even or odd.\n");
                        Console.Write("Enter a whole number: ");
                        num = int.Parse(Console.ReadLine());

                        if (num % 2 == 0)
                        {
                            Console.WriteLine($"{num} is even.\n");
                        }
                        else
                        {
                            Console.WriteLine($"{num} is odd.\n");
                        }
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
                                Console.WriteLine($"#{extraOption}: Guess a number between 1 and 10 (3 attempts).\n");
                                Random random = new Random();
                                int randomNum = random.Next(1, 11);
                                //Console.WriteLine($"The answer is {randomNum}.");
                                int guess;
                                bool winner = true;
                                for(int i = 0; i < 3; i++)
                                {
                                    Console.Write($"Guess #{i + 1}: ");
                                    guess = int.Parse(Console.ReadLine());
                                    
                                    if (guess > randomNum)
                                    {
                                        Console.WriteLine($"{guess} is too high. Try again.\n");
                                        winner = false;
                                    } if (guess < randomNum)
                                    {
                                        Console.WriteLine($"{guess} is too low. Try again.\n");
                                        winner = false;
                                    }
                                    if(guess == randomNum)
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
                                break;
                            case 2:
                                Console.WriteLine($"#{extraOption}: Determine if a number is prime.\n");
                                Console.Write("Enter a value that is greater than 1: ");
                                int numCheck = int.Parse(Console.ReadLine());
                                bool isPrime = true;

                                if(numCheck <= 1)
                                {
                                    Console.WriteLine("Number needs to be greater than 1.\n");
                                } else
                                {
                                    for(int i = 2; i <= (numCheck / 2); i++)
                                    {
                                        if((numCheck % i) == 0)
                                        {
                                            isPrime = false;                                            
                                            break;
                                        }
                                    }
                                    if (isPrime == true)
                                    {
                                        Console.WriteLine($"{numCheck} is a prime number.\n");
                                    } else
                                    {
                                        Console.WriteLine($"{numCheck} is NOT a prime number.\n");
                                    }
                                }

                                break;
                            default:
                                Console.WriteLine("Press 0 to exit.");
                                break;
                        }
                        break;
                    case 8:
                        flag = false;
                        Console.WriteLine("Press any key to exit.");
                        break;
                    default:
                        Console.WriteLine("Press 0 to exit.");
                        break;
                }
                
                Console.WriteLine("Press enter to continue.\n");
                Console.ReadKey();

            }
            while (flag);
            Console.ReadLine();

            }
            
        }
    }

