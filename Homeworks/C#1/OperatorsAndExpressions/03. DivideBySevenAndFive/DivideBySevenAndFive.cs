using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

namespace DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int n = Int32.Parse(Console.ReadLine());
            bool Divided = (n % 35 == 0);

            if (n == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine(Divided);
            }
        }
    }
}
