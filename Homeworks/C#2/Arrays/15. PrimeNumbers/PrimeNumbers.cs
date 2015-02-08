using System;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            bool[] primeNums = new bool[10000000];
            int count = 0;

            for (int i = 2; i < Math.Sqrt(primeNums.Length); i++)
            {
                if (primeNums[i] == false)
                {
                    for (int j = i * i; j < primeNums.Length; j += i)
                    {
                        primeNums[j] = true;
                    }
                }
            }

            //If you want to print all prime numbers between 1 and 10 000 000, uncomment the lines below.
            //for (int i = 2; i < primeNums.Length; i++)
            //{
            //    if (!primeNums[i]) Console.Write(i + " ");
            //}

            for (int i = 2; i < primeNums.Length; i++)
            {
                if (!primeNums[i]) count++;
            }

            Console.WriteLine("Prime numbers between 1 and 10 000 000 are {0}.", count);

        }
    }
}
