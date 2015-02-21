using System;
using System.Linq;

//Write a program that can solve these tasks:
    // - Reverses the digits of a number
    // - Calculates the average of a sequence of integers
    // - Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
    //- The decimal number should be non-negative
    //- The sequence should not be empty
    //- a should not be equal to 0

namespace _13.SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            PrintMenu();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Choose an operation: ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        ReverseDigits();
                        break;
                    case ConsoleKey.D2:
                        CalculateAverage();
                        break;
                    case ConsoleKey.D3:
                        SolveLinear();
                        break;
                    default:
                        PrintError("You've entered invalid menu choice!");
                        break;
                }
            } while (true);
        }

        private static void PrintMenu()
        {
            string menu = "Choose an option: ";
            string[] menuOptions = new string[3];
            menuOptions[0] = "1. Reverse the digits of a number";
            menuOptions[1] = "2. Calculates the average of a sequence of integers";
            menuOptions[2] = "3. Solves a linear equation a * x + b = 0";

            Console.WriteLine(new string('=', Console.WindowWidth - 1));
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(Console.WindowWidth / 2 - menu.Length / 2, 1);
            Console.WriteLine(menu);
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0, start = Console.CursorTop; i < menuOptions.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - menuOptions[1].Length / 2, i + start);
                Console.WriteLine(menuOptions[i]);
            }
            Console.WriteLine(new string('=', Console.WindowWidth - 1));
        }

        private static void ReverseDigits()
        {
            while (true)
            {
                Console.Write("Enter a positive number: ");
                string input = Console.ReadLine();

                if (isPositiveInteger(input))
                {
                    char[] arr = input.ToCharArray();
                    Array.Reverse(arr);

                    int result = int.Parse(String.Join("", arr));
                    Console.WriteLine("Number {0}, revsered is: {1}.", input, result);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You've entered invalid number!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static void CalculateAverage()
        {
            while (true)
            {
                Console.Write("Enter a positive number for array length: ");
                string n = Console.ReadLine();

                if (isPositiveInteger(n))
                {
                    int[] average = FillAverageArray(n);
                    Console.WriteLine("Average is: {0}.", average.Average());
                    break;
                }
                else
                {
                    PrintError("You've entered invalid number!");
                }
            }
        }

        private static void SolveLinear()
        {
            while (true)
            {
                Console.Write("Enter a number for 'a': ");
                string a = Console.ReadLine();
                int aParsed = 0;

                Console.Write("Enter a number for 'b': ");
                string b = Console.ReadLine();
                int bParsed = 0;

                bool error = false;

                if (isNotZero(a) && isInteger(a))
                {
                    aParsed = int.Parse(a);
                }
                else
                {
                    PrintError("You've entered invalid number! 'a' should be a non-zero number!");
                    error = true;
                }

                if (isInteger(b))
                {
                    bParsed = int.Parse(b);
                }
                else
                {
                    PrintError("You've entered invalid number! 'b' should be a number!");
                    error = true;
                }

                if (!error)
                {
                    Console.WriteLine("Result for the equation {0} * x + {1} = 0 is: ", a, b);
                    Console.WriteLine("x = {0}", (-bParsed / (double)aParsed));
                    break;
                }
            }
        }

        private static int[] FillAverageArray(string n)
        {
            int[] numbers = new int[int.Parse(n)];

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write("Enter a number {0} from the array: ", i);
                    string number = Console.ReadLine();

                    if (isInteger(number))
                    {
                        numbers[i] = int.Parse(number);
                        break;
                    }

                    PrintError("You've entered invalid number!");
                }
            }

            return numbers;
        }

        private static void PrintError(string error)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static bool isPositiveInteger(string input)
        {
            int number = 0;
            bool isNumber = int.TryParse(input, out number);

            return isNumber && number > 0;
        }

        private static bool isNotZero(string input)
        {
            int number = 0;
            bool isNumber = int.TryParse(input, out number);

            return isNumber && number != 0;
        }

        private static bool isInteger(string input)
        {
            int number = 0;
            bool isNumber = int.TryParse(input, out number);

            return isNumber;
        }
    }
}
