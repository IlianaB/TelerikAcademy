using System;
using System.Threading;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Write a number between 1 and 3: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 1: Console.Write("Please enter an integer: ");
                        int integerNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(++integerNum);
                    break;
                case 2: Console.Write("Please enter a double: ");
                        double doubleNum = Double.Parse(Console.ReadLine());
                        Console.WriteLine(++doubleNum);
                    break;
                case 3: Console.Write("Please enter a string: ");
                        string stringInput = Console.ReadLine();
                        Console.WriteLine(stringInput + "*");
                    break;
                default: Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
