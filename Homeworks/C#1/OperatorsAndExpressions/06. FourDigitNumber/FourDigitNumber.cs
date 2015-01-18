using System;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Write an four-digit number: ");
            int number = Int32.Parse(Console.ReadLine());
            int forthDigit = number % 10;
            int thirdDigit = (number / 10) % 10;
            int secondDigit = (number / 100) % 10;
            int firstDigit = (number / 1000) % 10;

            Console.WriteLine("The sum of the digits is: " + (firstDigit + secondDigit + thirdDigit + forthDigit));
            Console.WriteLine("The number in reversed order is: " + forthDigit + thirdDigit + secondDigit + firstDigit);
            Console.WriteLine("When the last digit is in the first position the number is: " + forthDigit + firstDigit + secondDigit + thirdDigit);
            Console.WriteLine("When we exchange the second and the third digits the number is: " + firstDigit + thirdDigit + secondDigit + forthDigit);
        }
    }
}
