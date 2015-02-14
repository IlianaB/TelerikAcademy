using System;
using System.Text;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace _06.BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.Write("Write a binary number: ");
            string input = Console.ReadLine();
            string inputZeros = input.PadLeft(32, '0');

            string result = ConvertToHex(inputZeros);

            Console.WriteLine("The hexadecimal representation of {0} is {1}.", input, result);

        }

        private static string ConvertToHex(string inputZeros)
        {
            string number = string.Empty;
            StringBuilder hexNum = new StringBuilder();

            if (inputZeros == "0")
            {
                return "0";
            }
            else
            {
                for (int i = 0; i < inputZeros.Length; i += 4)
                {
                    number = inputZeros.Substring(i, 4);

                    switch (number)
                    {
                        case "0001": hexNum.Append("1");
                            break;
                        case "0010": hexNum.Append("2");
                            break;
                        case "0011": hexNum.Append("3");
                            break;
                        case "0100": hexNum.Append("4");
                            break;
                        case "0101": hexNum.Append("5");
                            break;
                        case "0110": hexNum.Append("6");
                            break;
                        case "0111": hexNum.Append("7");
                            break;
                        case "1000": hexNum.Append("8");
                            break;
                        case "1001": hexNum.Append("9");
                            break;
                        case "1010": hexNum.Append("A");
                            break;
                        case "1011": hexNum.Append("B");
                            break;
                        case "1100": hexNum.Append("C");
                            break;
                        case "1101": hexNum.Append("D");
                            break;
                        case "1110": hexNum.Append("E");
                            break;
                        case "1111": hexNum.Append("F");
                            break;
                    }
                }

                string result = hexNum.ToString();
                return result;
            }

        }
    }
}
