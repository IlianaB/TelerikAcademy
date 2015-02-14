using System;
using System.Text;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

namespace _07.OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("s = ");
            int s = int.Parse(Console.ReadLine());
            string number = ConvertToOtherSystem(input, s);

            Console.WriteLine("The representation of {0} in a numeral system with base {1} is {2}.", input, s, number);
        }

        private static string ConvertToOtherSystem(int input, int systemBase)
        {
            StringBuilder numberBuilder = new StringBuilder();
            int result = 0;

            while (input > 0)
            {
                result = input % systemBase;

                if (result > 9)
                {
                    numberBuilder.Insert(0, (char)('A' + result - 10));
                }
                else
                {
                    numberBuilder.Insert(0, result);
                }
                input /= systemBase;
            }
            string number = numberBuilder.ToString();

            return number;
        }
    }
}
