using System;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

namespace SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Write five numbers, separated by space: ");
            string sequence = Console.ReadLine();
            string[] arr = sequence.Split(' ');
            double sum = 0;
            double numberDouble = 0;

            foreach (string number in arr)
                {
                    numberDouble = Double.Parse(number);
                    sum += numberDouble;
                }
                        
             Console.WriteLine(sum);
        }
    }
}
