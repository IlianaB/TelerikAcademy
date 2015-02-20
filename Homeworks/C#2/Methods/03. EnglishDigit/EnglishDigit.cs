using System;

//Write a method that returns the last digit of given integer as an English word.

namespace _03.EnglishDigit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            string word = " ";

            word = TransformLastDigit(number);

            Console.WriteLine("The last digit of the number you have just entered is: {0}", word);
        }

        private static string TransformLastDigit(int number)
        {
            int lastDigit = number % 10;
            string word = " ";

            switch (lastDigit)
            {
                case 0: word = "zero";
                    break;
                case 1: word = "one";
                    break;
                case 2: word = "two";
                    break;
                case 3: word = "three";
                    break;
                case 4: word = "four";
                    break;
                case 5: word = "five";
                    break;
                case 6: word = "six";
                    break;
                case 7: word = "seven";
                    break;
                case 8: word = "eight";
                    break;
                case 9: word = "nine";
                    break;
            }

            return word;
        }
    }
}
