using System;

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string firstVar = "The \"use\" of quotations causes difficulties.";
            string secondVar = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(firstVar);
            Console.WriteLine(secondVar);
        }
    }
}
