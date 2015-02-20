using System;

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

namespace _01.SayHello
{
    class SayHello
    {
        static void Main()
        {
            PrintHello();
        }

        private static void PrintHello()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
