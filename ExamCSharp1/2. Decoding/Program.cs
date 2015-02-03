using System;
using System.Threading;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            decimal result = 0;
            decimal odd = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if (Char.IsLetter(text[i]))
                {
                    result = (text[i] * salt) + 1000;
                }
                else if (Char.IsDigit(text[i]))
                {
                    result = text[i] + salt + 500;
                }
                else
                {
                    result = text[i] - salt;
                }

                if (i % 2 == 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    odd = result * 100;
                    Console.WriteLine("{0}", odd);
                }
            }
        }
    }
}