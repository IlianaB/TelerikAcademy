using System;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Ten random values between 100 and 200: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", rnd.Next(100, 200 + 1));
            }

            Console.WriteLine();
        }
    }
}
