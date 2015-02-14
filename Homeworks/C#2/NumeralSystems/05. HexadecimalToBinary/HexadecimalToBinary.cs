using System;
using System.Text;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _05.HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Write a hexadecimal number: ");
            string input = Console.ReadLine();

            string binary = ConvertHexNumber(input);

            Console.WriteLine("The binary representation of {0} is {1}", input, binary);
        }

        private static string ConvertHexNumber(string input)
        {
            StringBuilder binNum = new StringBuilder();
            string binary = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0': binNum.Append("0000");
                        break;
                    case '1': binNum.Append("0001");
                        break;
                    case '2': binNum.Append("0010");
                        break;
                    case '3': binNum.Append("0011");
                        break;
                    case '4': binNum.Append("0100");
                        break;
                    case '5': binNum.Append("0101");
                        break;
                    case '6': binNum.Append("0110");
                        break;
                    case '7': binNum.Append("0111");
                        break;
                    case '8': binNum.Append("1000");
                        break;
                    case '9': binNum.Append("1001");
                        break;
                    case 'A': binNum.Append("1010");
                        break;
                    case 'B': binNum.Append("1011");
                        break;
                    case 'C': binNum.Append("1100");
                        break;
                    case 'D': binNum.Append("1101");
                        break;
                    case 'E': binNum.Append("1110");
                        break;
                    case 'F': binNum.Append("1111");
                        break;
                }
            }

            binary = binNum.ToString();
            return binary;
        }
    }
}
