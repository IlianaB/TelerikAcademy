using System;

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Write number in Hexadecimal representation: ");
            string hexaNumber = Console.ReadLine();
            int count = hexaNumber.Length - 1;
            long decimalNumber = 0;
            int factor = 0;

            for (int i = 0; i < hexaNumber.Length; i++)
            {
                switch (hexaNumber[i])
                {
                    case 'A':
                        factor = 10;
                        break;
                    case 'B':
                        factor = 11;
                        break;
                    case 'C':
                        factor = 12;
                        break;
                    case 'D':
                        factor = 13;
                        break;
                    case 'E':
                        factor = 14;
                        break;
                    case 'F':
                        factor = 15;
                        break;
                    default:
                        factor = int.Parse(hexaNumber[i].ToString());
                        break;
                }

                decimalNumber += factor * (long)Math.Pow(16, (count - i));
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
