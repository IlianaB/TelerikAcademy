using System;

//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

namespace DigitАsWord
{
    class DigitАsWord
    {
        static void Main(string[] args)
        {
            Console.Write("Write a digit from 0 to 9: ");
            string input = Console.ReadLine();
            int digit = 0;
            bool number = Int32.TryParse(input, out digit);

            if (number)
            {
                string name = " ";

                switch (digit)
                {
                    case 0: name = "zero";
                        break;
                    case 1: name = "one";
                        break;
                    case 2: name = "two";
                        break;
                    case 3: name = "three";
                        break;
                    case 4: name = "four";
                        break;
                    case 5: name = "five";
                        break;
                    case 6: name = "six";
                        break;
                    case 7: name = "seven";
                        break;
                    case 8: name = "eight";
                        break;
                    case 9: name = "nine";
                        break;
                    default: Console.WriteLine("Not a digit between 0 and 9");
                        break;
                }

                Console.WriteLine(name);
            }
            
            else
            {
                Console.WriteLine("Not a digit");
            }                       
        }
    }
}
