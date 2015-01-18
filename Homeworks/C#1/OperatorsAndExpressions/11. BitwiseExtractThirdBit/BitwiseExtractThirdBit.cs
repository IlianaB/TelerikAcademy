using System;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

namespace BitwiseExtractThirdBit
{
    class BitwiseExtractThirdBit
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer number: ");
            int number = Int32.Parse(Console.ReadLine());
            int mask = 1 << 3;

            Console.WriteLine((number & mask) == mask ? 1 : 0);

            //Another variant:
            //string numberToString = Convert.ToString(number, 2).PadLeft(64, '0');
            //Console.WriteLine(numberToString[numberToString.Lenght - 4]);
        }
    }
}
