using System;

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.Write("Write a float number: ");
            double firstNumber = Double.Parse(Console.ReadLine());
            Console.Write("Write a float number: ");
            double secondNumber = Double.Parse(Console.ReadLine());
            bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;

            Console.WriteLine("Are the two float numbers equal: {0}", equal);
        }
    }
}
