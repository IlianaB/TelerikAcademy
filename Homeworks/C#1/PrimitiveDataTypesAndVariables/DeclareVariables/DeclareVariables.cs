using System;

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            ushort a = 52130;
            sbyte b = -115;
            int c = 4825932;
            byte d = 97;
            short e = -10000;

            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e);
        }
    }
}
