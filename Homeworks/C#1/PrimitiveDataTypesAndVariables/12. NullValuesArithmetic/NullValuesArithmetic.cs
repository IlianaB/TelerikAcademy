using System;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? firstVar = null;
            double? secondVar = null;

            Console.WriteLine("Nullable integer = {0}", firstVar);
            Console.WriteLine("Nullable double = {0}", secondVar);

            firstVar = 73920;
            secondVar = 33.5;

            Console.WriteLine("New integer value: {0}", firstVar.GetValueOrDefault());
            Console.WriteLine("New double value: {0}", secondVar.GetValueOrDefault());
        }
    }
}
