using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

namespace ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer digit: ");
            int number = Int32.Parse(Console.ReadLine());
            bool thirdDigit = ((number / 100) % 10 == 7);

            Console.WriteLine(thirdDigit);
        }
    }
}
