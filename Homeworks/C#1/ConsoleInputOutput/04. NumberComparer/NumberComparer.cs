using System;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a, b));   
        }
    }
}
